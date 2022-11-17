﻿using System;
using System.Reflection;
using System.Windows.Forms;

namespace Polaris.Forms.Subjects
{
    public partial class Subjects : Form
    {
        public Subjects()
        {
            InitializeComponent();
        }

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

        #region Events

        private void NotesView_Click(object sender, EventArgs e)
        {
            sectionLabel.Text = "Notes Section";
        }

        private void ActivitiesView_Click(object sender, EventArgs e)
        {
            sectionLabel.Text = "Activities Section";
        }

        private void GradesView_Click(object sender, EventArgs e)
        {
            sectionLabel.Text = "Grades Section";
        }

        #endregion Events

        private void Subjects_Load(object sender, EventArgs e)
        {
            OpenChildForm(new GradesView());
        }
    }
}