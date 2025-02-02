﻿using System;
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
            Load += new EventHandler(Root_Load);
            HiddenScroll();
        }

        #region CustomStyles

        private void TasksPanel_Paint(object sender, PaintEventArgs e)
        {
            AddBorder(e);
        }

        private void ClassesPanel_Paint(object sender, PaintEventArgs e)
        {
            AddBorder(e);
        }

        private void FTPanel_Paint(object sender, PaintEventArgs e)
        {
            AddBorder(e);
        }

        private static void AddBorder(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle,
                ColorTranslator.FromHtml("#27282F"), 0, ButtonBorderStyle.Solid,
                ColorTranslator.FromHtml("#27282F"), 2, ButtonBorderStyle.Solid,
                ColorTranslator.FromHtml("#27282F"), 0, ButtonBorderStyle.Solid,
                ColorTranslator.FromHtml("#27282F"), 0, ButtonBorderStyle.Solid);
        }

        private void HiddenScroll()
        {
            // hide scroll bar in sidebar panel
            SidePanel.VerticalScroll.Maximum = 0;
            SidePanel.VerticalScroll.Visible = false;
            SidePanel.HorizontalScroll.Maximum = 0;
            SidePanel.HorizontalScroll.Visible = false;
            SidePanel.AutoScroll = true;

            // hide scroll bar in embedded panel
            EmbedPanel.VerticalScroll.Maximum = 0;
            EmbedPanel.VerticalScroll.Visible = false;
            EmbedPanel.HorizontalScroll.Maximum = 0;
            EmbedPanel.HorizontalScroll.Visible = false;
            EmbedPanel.AutoScroll = true;
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

        #region Click events for logo button

        private void LogoBtn_Click(object sender, EventArgs e)
        {
            ToggleButtonFontColor(new FontAwesome.Sharp.IconButton());
            LabelText.Text = "Overview";
            OpenChildForm(new Overview());
        }

        #endregion Click events for logo button

        #region Click events for tasks section

        private void TasksBtn_Click(object sender, EventArgs e)
        {
            ToggleButtonFontColor(AllBtn);
            LabelText.Text = "Tasks";
            OpenChildForm(new Tasks.All_Tasks());
        }

        private void AllBtn_Click(object sender, EventArgs e)
        {
            ToggleButtonFontColor(AllBtn);
            LabelText.Text = "Tasks";
            OpenChildForm(new Tasks.All_Tasks());
        }

        private void DraftsBtn_Click(object sender, EventArgs e)
        {
            ToggleButtonFontColor(DraftsBtn);
            LabelText.Text = "Tasks";
            OpenChildForm(new Tasks.Drafts_Tasks());
        }

        private void ArchivesBtn_Click(object sender, EventArgs e)
        {
            ToggleButtonFontColor(ArchivesBtn);
            LabelText.Text = "Tasks";
            OpenChildForm(new Tasks.Archive_Tasks());
        }

        private void DeletedBtn_Click(object sender, EventArgs e)
        {
            ToggleButtonFontColor(DeletedBtn);
            LabelText.Text = "Tasks";
            OpenChildForm(new Tasks.Delete_Tasks());
        }

        #endregion Click events for tasks section

        #region Click events for notes section

        // on click, toggle ClassBtn IconChar with either ChevronUp or ChevronDown
        private void ClassesBtn_Click(object sender, EventArgs e)
        {
            if (ClassesBtn.IconChar == FontAwesome.Sharp.IconChar.ChevronUp)
                ClassesBtn.IconChar = FontAwesome.Sharp.IconChar.ChevronDown;
            else
                ClassesBtn.IconChar = FontAwesome.Sharp.IconChar.ChevronUp;

            ClassPanel.Visible = !ClassPanel.Visible;
        }

        // on ClassBtn_Click, set LabelText to ClassBtn text
        private void ClassBtn_Click(object sender, EventArgs e)
        {
            ToggleButtonFontColor((FontAwesome.Sharp.IconButton)sender);
            LabelText.Text = ((FontAwesome.Sharp.IconButton)sender).Text;
            OpenChildForm(new Classes.NotesView());
        }

        #endregion Click events for notes section

        #region LoadClassOnClasses

        // sample data
        private readonly string[] classes = { "SDF 104", "CC 104", "CC 105" };

        private void Root_Load(object sender, EventArgs e)
        {
            int buttonCount = classes.Length;
            var buttons = new FontAwesome.Sharp.IconButton[buttonCount];

            for (int i = 0; i < buttonCount; i++)
            {
                var button = new FontAwesome.Sharp.IconButton
                {
                    Text = "  " + classes[i],
                    TextAlign = ContentAlignment.MiddleLeft,
                    IconChar = FontAwesome.Sharp.IconChar.Stop,
                    IconColor = ColorTranslator.FromHtml("#6A6A73"),
                    IconSize = 25,
                    ImageAlign = ContentAlignment.MiddleLeft,
                    TextImageRelation = TextImageRelation.ImageBeforeText,
                    FlatStyle = FlatStyle.Flat,
                };
                button.FlatAppearance.BorderSize = 0;
                button.ForeColor = ColorTranslator.FromHtml("#6A6A73");
                button.BackColor = ColorTranslator.FromHtml("#1B1C21");
                button.Font = new Font("Nobile Medium", 12);
                button.Height = 44;
                button.Width = 264;
                button.Padding = new Padding(15, 0, 0, 0);
                button.Click += new EventHandler(ClassBtn_Click);
                buttons[i] = button;
            }

            ClassPanel.Controls.AddRange(buttons);
        }

        #endregion LoadClassOnClasses

        #region Click events for financial tracker section

        private void FTBtn_Click(object sender, EventArgs e)
        {
            ToggleButtonFontColor(new FontAwesome.Sharp.IconButton());
            LabelText.Text = "Extra";
            OpenChildForm(new FTS.FTSView());
        }

        #endregion Click events for financial tracker section
    }
}