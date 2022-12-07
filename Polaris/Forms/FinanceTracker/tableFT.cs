﻿using Polaris.Components;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data.Odbc;
using System.Drawing;
using System.Windows.Forms;

namespace Polaris.Forms.FinanceTracker
{
    public partial class tableFT : UserControl
    {
        public tableFT()
        {
            InitializeComponent();
        }

        #region Getter, Setter & Constructor

        private string _id;
        private string _value = "0";
        private string _description = "Description";
        private string _createdDate = "Created Date";
        private string _modifiedDate = "Modified Date";
        private Color _color = ColorTranslator.FromHtml("#141519");

        [Category("Record Property")]
        public string ID
        {
            get { return _id; }
            set { _id = value; idLabel.Text = value; }
        }

        [Category("Record Property")]
        public string Value
        {
            get { return _value; }
            set { _value = value; ValueLabel.Text = value; }
        }

        [Category("Record Property")]
        public string Description
        {
            get { return _description; }
            set { _description = value; DescriptionLabel.Text = value; }
        }

        [Category("Record Property")]
        public string[] Tags { get; set; }

        [Category("Record Property")]
        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; CreatedLabel.Text = value; }
        }

        [Category("Record Property")]
        public string ModifiedDate
        {
            get { return _modifiedDate; }
            set { _modifiedDate = value; ModifiedLabel.Text = value; }
        }

        [Category("Record Property")]
        public Color Color
        {
            get { return _color; }
            set { _color = value; background.BackColor = value; }
        }

        #endregion Getter, Setter & Constructor

        #region Events

        private void editButton_Click(object sender, EventArgs e)
        {
            FTInput inputForm = new FTInput();
            inputForm.valueLabel.Text = Value;
            inputForm.descriptionLabel.Text = Description;
            inputForm.editing = true;
            inputForm.recordID = ID;
            inputForm.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            FinanceTracker financeTracker = (FinanceTracker)ParentForm;
            RemoveFinanceFromDB();
            financeTracker.TableRecord.Remove(this);
            financeTracker.GenerateDynamicRecords();
        }

        public void mouse_Enter(object sender, EventArgs e)
        {
            background.BackColor = ColorTranslator.FromHtml("#1E2125");
        }

        public void mouse_Leave(object sender, EventArgs e)
        {
            background.BackColor = Color;
        }

        #endregion Events

        #region DB functions

        private void RemoveFinanceFromDB()
        {
            string connectionString = "Driver={MySQL ODBC 8.0 Unicode Driver};Server=localhost;Database=polaris;User=root;Password=password;Option=3;";
            OdbcConnection connection = new OdbcConnection(connectionString);

            connection.Close();
            connection.Open();

            OdbcCommand cmd = new OdbcCommand("DELETE FROM finance WHERE id = " + ID, connection);
            cmd.ExecuteNonQuery();
            cmd = new OdbcCommand("DELETE FROM finance_tags WHERE finance_id = " + ID, connection);
            cmd.ExecuteNonQuery();

            connection.Close();
        }

        private static readonly ArrayList tags = new ArrayList();
        public ArrayList TableTags { get; set; } = tags;

        private void LoadTags()
        {
            string connectionString = "Driver={MySQL ODBC 8.0 Unicode Driver};Server=localhost;Database=polaris;User=root;Password=password;Option=3;";
            OdbcConnection connection = new OdbcConnection(connectionString);
            OdbcDataReader dataReader;

            connection.Close();
            connection.Open();

            OdbcCommand cmd = new OdbcCommand("SELECT * FROM finance_tags WHERE finance_id = " + ID, connection);
            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                Tag tag = new Tag()
                {
                    TagName = dataReader.GetString(1),
                    TagID = dataReader.GetString(2),
                };
                TableTags.Add(tag);
            }

            connection.Close();
        }

        private void GenerateDynamicTags()
        {
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < TableTags.Count; i++)
            {
                Tag tag = (Tag)TableTags[i];
                if (tag.TagID == ID)
                {
                    flowLayoutPanel1.Controls.Add(tag);
                }
            }
        }

        #endregion DB functions

        #region Hidden Scroll

        private void HiddenScroll()
        {
            flowLayoutPanel1.AutoScroll = false;
            flowLayoutPanel1.VerticalScroll.Visible = false;
            flowLayoutPanel1.VerticalScroll.Enabled = false;
            flowLayoutPanel1.VerticalScroll.Maximum = 0;
            flowLayoutPanel1.AutoScroll = true;
        }

        #endregion Hidden Scroll

        private void tableFT_Load(object sender, EventArgs e)
        {
            LoadTags();
            GenerateDynamicTags();
            HiddenScroll();
        }
    }
}