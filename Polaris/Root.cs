﻿using System;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Polaris
{
    public partial class Root : Form
    {
        public Root()
        {
            InitializeComponent();
        }

        #region CustomStyles

        // add border to task panels
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle,
                ColorTranslator.FromHtml("#27282F"), 0, ButtonBorderStyle.Solid,
                ColorTranslator.FromHtml("#27282F"), 2, ButtonBorderStyle.Solid,
                ColorTranslator.FromHtml("#27282F"), 0, ButtonBorderStyle.Solid,
                ColorTranslator.FromHtml("#27282F"), 0, ButtonBorderStyle.Solid);
        }

        #endregion CustomStyles

        #region Functions

        // onclick set visibility of sidebar
        private void TogglePanelBtn_Click(object sender, EventArgs e)
        {
            SidePanel.Visible = !SidePanel.Visible;
        }

        // onclick open certain forms
        private Form activeForm = null;

        private void OpenChildForm(Form childForm)
        {
            _ = typeof(Panel).InvokeMember("DoubleBuffered",
               BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
               null, EmbedPanel, new object[] { true });

            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            EmbedPanel.Controls.Add(childForm);
            EmbedPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        // onclick set active button font and icon color
        private FontAwesome.Sharp.IconButton activeIconButton = null;

        private void ToggleButtonFontColor(FontAwesome.Sharp.IconButton button)
        {
            if (activeIconButton != null)
            {
                activeIconButton.ForeColor = ColorTranslator.FromHtml("#6A6A73");
                activeIconButton.IconColor = ColorTranslator.FromHtml("#6A6A73");
            }
            activeIconButton = button;
            activeIconButton.ForeColor = ColorTranslator.FromHtml("#FDFEFF");
            activeIconButton.IconColor = ColorTranslator.FromHtml("#FDFEFF");
        }

        #endregion Functions

        #region Click events for task buttons

        private void LogoBtn_Click(object sender, EventArgs e)
        {
            LabelText.Text = "Overview";
            OpenChildForm(new Overview());
            ToggleButtonFontColor(new FontAwesome.Sharp.IconButton());
        }

        private void TasksBtn_Click(object sender, EventArgs e)
        {
            ToggleButtonFontColor(AllBtn);
            OpenChildForm(new All_Tasks());
            LabelText.Text = "Tasks";
        }

        private void AllBtn_Click(object sender, EventArgs e)
        {
            ToggleButtonFontColor(AllBtn);
            OpenChildForm(new All_Tasks());
            LabelText.Text = "Tasks";
        }

        private void DraftsBtn_Click(object sender, EventArgs e)
        {
            ToggleButtonFontColor(DraftsBtn);
            OpenChildForm(new Drafts_Tasks());
            LabelText.Text = "Tasks";
        }

        private void ArchivesBtn_Click(object sender, EventArgs e)
        {
            ToggleButtonFontColor(ArchivesBtn);
            OpenChildForm(new Archive_Tasks());
            LabelText.Text = "Tasks";
        }

        private void DeletedBtn_Click(object sender, EventArgs e)
        {
            ToggleButtonFontColor(DeletedBtn);
            OpenChildForm(new Delete_Tasks());
            LabelText.Text = "Tasks";
        }

        #endregion Click events for task buttons
    }
}