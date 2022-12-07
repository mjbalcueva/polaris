﻿using FontAwesome.Sharp;
using Polaris.Forms.FinanceTracker;
using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Polaris.Forms.Subjects
{
    public partial class Subjects : Form
    {
        private string subText;
        private static Subjects subject = new Subjects();

        public Subjects()
        {
            InitializeComponent();
        }

        public Subjects(string text)
        {
            subject.subText = text;
            InitializeComponent();
        }

        #region Open Form

        private Form activeForm = null;

        public void OpenChildForm(Form childForm)
        {
            _ = typeof(Panel).InvokeMember("DoubleBuffered",
               BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
               null, embedPanel, new object[] { true });

            activeForm?.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            embedPanel.Controls.Add(childForm);
            embedPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        #endregion Open Form

        #region Events

        private void NotesView_Click(object sender, EventArgs e)
        {
            sectionLabel.Text = "Notes Section";
            sectionButton.Text = "Add Note";
            sectionButton.Enabled = true;
            ToggleActiveButton(NotesView);
            OpenChildForm(new NotesView(subject.subText));
        }

        private void ActivitiesView_Click(object sender, EventArgs e)
        {
            sectionLabel.Text = "Activities Section";
            sectionButton.Text = "Add Activity";
            sectionButton.Enabled = true;
            ToggleActiveButton(ActivitiesView);
            OpenChildForm(new ActivitiesView(subject.subText));
        }

        private void GradesView_Click(object sender, EventArgs e)
        {
            sectionLabel.Text = "Grades Section";
            sectionButton.Text = "Viewing Grades";
            sectionButton.Enabled = false;
            ToggleActiveButton(GradesView);
            OpenChildForm(new GradesView(subject.subText));
        }

        #endregion Events

        #region Toggle Button

        private IconButton activeBtn = null;

        private void ToggleActiveButton(IconButton button)
        {
            if (activeBtn != null)
            {
                activeBtn.BackColor = ColorTranslator.FromHtml("#090A0B");
                activeBtn.ForeColor = ColorTranslator.FromHtml("#6A6A73");
            }
            activeBtn = button;
            activeBtn.BackColor = ColorTranslator.FromHtml("#414149");
            activeBtn.ForeColor = ColorTranslator.FromHtml("#FDFEFF");
        }

        #endregion Toggle Button

        private void Subjects_Load(object sender, EventArgs e)
        {
            OpenChildForm(new NotesView(subject.subText));
            sectionLabel.Text = "Notes Section";
            sectionButton.Text = "Add Note";
            ToggleActiveButton(NotesView);
        }

        private void sectionButton_Click(object sender, EventArgs e)
        {
            if (sectionLabel.Text == "Notes Section")
            {
                NVInput nvInput = new NVInput(subject.subText);
                nvInput.Show();
            }
            else if (sectionLabel.Text == "Activities Section")
            {
                AVInput avInput = new AVInput(subject.subText);
                avInput.Show();
            }
        }
    }
}