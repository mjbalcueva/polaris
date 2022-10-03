﻿namespace Polaris
{
    partial class Root
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SidePanel = new System.Windows.Forms.Panel();
            this.ClassesPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ClassesBtn = new FontAwesome.Sharp.IconButton();
            this.AddClassesBdg = new FontAwesome.Sharp.IconButton();
            this.TasksPanel = new System.Windows.Forms.TableLayoutPanel();
            this.TasksBtn = new FontAwesome.Sharp.IconButton();
            this.AllBtn = new FontAwesome.Sharp.IconButton();
            this.DraftsBtn = new FontAwesome.Sharp.IconButton();
            this.ArchivesBtn = new FontAwesome.Sharp.IconButton();
            this.DeletedBtn = new FontAwesome.Sharp.IconButton();
            this.AddNotesBdg = new FontAwesome.Sharp.IconButton();
            this.AllCountBadge = new FontAwesome.Sharp.IconButton();
            this.DraftsCountBadge = new FontAwesome.Sharp.IconButton();
            this.ArchivesCountBadge = new FontAwesome.Sharp.IconButton();
            this.DeletedCountBadge = new FontAwesome.Sharp.IconButton();
            this.LogoBtn = new FontAwesome.Sharp.IconButton();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.LabelText = new System.Windows.Forms.Label();
            this.TogglePanelBtn = new FontAwesome.Sharp.IconButton();
            this.EmbedPanel = new System.Windows.Forms.Panel();
            this.SidePanel.SuspendLayout();
            this.ClassesPanel.SuspendLayout();
            this.TasksPanel.SuspendLayout();
            this.TitlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.SidePanel.Controls.Add(this.ClassesPanel);
            this.SidePanel.Controls.Add(this.TasksPanel);
            this.SidePanel.Controls.Add(this.LogoBtn);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(300, 653);
            this.SidePanel.TabIndex = 0;
            // 
            // ClassesPanel
            // 
            this.ClassesPanel.ColumnCount = 2;
            this.ClassesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.ClassesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ClassesPanel.Controls.Add(this.ClassesBtn, 0, 0);
            this.ClassesPanel.Controls.Add(this.AddClassesBdg, 1, 0);
            this.ClassesPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClassesPanel.Location = new System.Drawing.Point(0, 380);
            this.ClassesPanel.Name = "ClassesPanel";
            this.ClassesPanel.Padding = new System.Windows.Forms.Padding(15);
            this.ClassesPanel.RowCount = 1;
            this.ClassesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ClassesPanel.Size = new System.Drawing.Size(300, 80);
            this.ClassesPanel.TabIndex = 2;
            this.ClassesPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ClassesPanel_Paint);
            // 
            // ClassesBtn
            // 
            this.ClassesBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClassesBtn.FlatAppearance.BorderSize = 0;
            this.ClassesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClassesBtn.Font = new System.Drawing.Font("Nobile Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ClassesBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.ClassesBtn.IconChar = FontAwesome.Sharp.IconChar.ChevronUp;
            this.ClassesBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.ClassesBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ClassesBtn.IconSize = 35;
            this.ClassesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClassesBtn.Location = new System.Drawing.Point(18, 18);
            this.ClassesBtn.Name = "ClassesBtn";
            this.ClassesBtn.Size = new System.Drawing.Size(210, 44);
            this.ClassesBtn.TabIndex = 0;
            this.ClassesBtn.Text = "  Classes";
            this.ClassesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClassesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ClassesBtn.UseVisualStyleBackColor = true;
            this.ClassesBtn.Click += new System.EventHandler(this.ClassesBtn_Click);
            // 
            // AddClassesBdg
            // 
            this.AddClassesBdg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(73)))));
            this.AddClassesBdg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddClassesBdg.FlatAppearance.BorderSize = 0;
            this.AddClassesBdg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddClassesBdg.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.AddClassesBdg.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.AddClassesBdg.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddClassesBdg.IconSize = 25;
            this.AddClassesBdg.Location = new System.Drawing.Point(234, 18);
            this.AddClassesBdg.Name = "AddClassesBdg";
            this.AddClassesBdg.Size = new System.Drawing.Size(48, 44);
            this.AddClassesBdg.TabIndex = 1;
            this.AddClassesBdg.UseVisualStyleBackColor = false;
            // 
            // TasksPanel
            // 
            this.TasksPanel.ColumnCount = 2;
            this.TasksPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.TasksPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TasksPanel.Controls.Add(this.TasksBtn, 0, 0);
            this.TasksPanel.Controls.Add(this.AllBtn, 0, 1);
            this.TasksPanel.Controls.Add(this.DraftsBtn, 0, 2);
            this.TasksPanel.Controls.Add(this.ArchivesBtn, 0, 3);
            this.TasksPanel.Controls.Add(this.DeletedBtn, 0, 4);
            this.TasksPanel.Controls.Add(this.AddNotesBdg, 1, 0);
            this.TasksPanel.Controls.Add(this.AllCountBadge, 1, 1);
            this.TasksPanel.Controls.Add(this.DraftsCountBadge, 1, 2);
            this.TasksPanel.Controls.Add(this.ArchivesCountBadge, 1, 3);
            this.TasksPanel.Controls.Add(this.DeletedCountBadge, 1, 4);
            this.TasksPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TasksPanel.Location = new System.Drawing.Point(0, 100);
            this.TasksPanel.Name = "TasksPanel";
            this.TasksPanel.Padding = new System.Windows.Forms.Padding(15);
            this.TasksPanel.RowCount = 5;
            this.TasksPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TasksPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TasksPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TasksPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TasksPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TasksPanel.Size = new System.Drawing.Size(300, 280);
            this.TasksPanel.TabIndex = 1;
            this.TasksPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TasksPanel_Paint);
            // 
            // TasksBtn
            // 
            this.TasksBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TasksBtn.FlatAppearance.BorderSize = 0;
            this.TasksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TasksBtn.Font = new System.Drawing.Font("Nobile Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.TasksBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.TasksBtn.IconChar = FontAwesome.Sharp.IconChar.ListCheck;
            this.TasksBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.TasksBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.TasksBtn.IconSize = 35;
            this.TasksBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TasksBtn.Location = new System.Drawing.Point(18, 18);
            this.TasksBtn.Name = "TasksBtn";
            this.TasksBtn.Size = new System.Drawing.Size(210, 44);
            this.TasksBtn.TabIndex = 0;
            this.TasksBtn.Text = "  Tasks";
            this.TasksBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TasksBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TasksBtn.Click += new System.EventHandler(this.TasksBtn_Click);
            // 
            // AllBtn
            // 
            this.AllBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllBtn.FlatAppearance.BorderSize = 0;
            this.AllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllBtn.Font = new System.Drawing.Font("Nobile Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.AllBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.AllBtn.IconChar = FontAwesome.Sharp.IconChar.CaretRight;
            this.AllBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.AllBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AllBtn.IconSize = 25;
            this.AllBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AllBtn.Location = new System.Drawing.Point(18, 68);
            this.AllBtn.Name = "AllBtn";
            this.AllBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.AllBtn.Size = new System.Drawing.Size(210, 44);
            this.AllBtn.TabIndex = 1;
            this.AllBtn.Text = "  All";
            this.AllBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AllBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AllBtn.Click += new System.EventHandler(this.AllBtn_Click);
            // 
            // DraftsBtn
            // 
            this.DraftsBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DraftsBtn.FlatAppearance.BorderSize = 0;
            this.DraftsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DraftsBtn.Font = new System.Drawing.Font("Nobile Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.DraftsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.DraftsBtn.IconChar = FontAwesome.Sharp.IconChar.CaretRight;
            this.DraftsBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.DraftsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DraftsBtn.IconSize = 25;
            this.DraftsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DraftsBtn.Location = new System.Drawing.Point(18, 118);
            this.DraftsBtn.Name = "DraftsBtn";
            this.DraftsBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.DraftsBtn.Size = new System.Drawing.Size(210, 44);
            this.DraftsBtn.TabIndex = 2;
            this.DraftsBtn.Text = "  Drafts";
            this.DraftsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DraftsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DraftsBtn.Click += new System.EventHandler(this.DraftsBtn_Click);
            // 
            // ArchivesBtn
            // 
            this.ArchivesBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ArchivesBtn.FlatAppearance.BorderSize = 0;
            this.ArchivesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ArchivesBtn.Font = new System.Drawing.Font("Nobile Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ArchivesBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.ArchivesBtn.IconChar = FontAwesome.Sharp.IconChar.CaretRight;
            this.ArchivesBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.ArchivesBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ArchivesBtn.IconSize = 25;
            this.ArchivesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ArchivesBtn.Location = new System.Drawing.Point(18, 168);
            this.ArchivesBtn.Name = "ArchivesBtn";
            this.ArchivesBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.ArchivesBtn.Size = new System.Drawing.Size(210, 44);
            this.ArchivesBtn.TabIndex = 3;
            this.ArchivesBtn.Text = "  Archived";
            this.ArchivesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ArchivesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ArchivesBtn.Click += new System.EventHandler(this.ArchivesBtn_Click);
            // 
            // DeletedBtn
            // 
            this.DeletedBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeletedBtn.FlatAppearance.BorderSize = 0;
            this.DeletedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeletedBtn.Font = new System.Drawing.Font("Nobile Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.DeletedBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.DeletedBtn.IconChar = FontAwesome.Sharp.IconChar.CaretRight;
            this.DeletedBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.DeletedBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DeletedBtn.IconSize = 25;
            this.DeletedBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeletedBtn.Location = new System.Drawing.Point(18, 218);
            this.DeletedBtn.Name = "DeletedBtn";
            this.DeletedBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.DeletedBtn.Size = new System.Drawing.Size(210, 44);
            this.DeletedBtn.TabIndex = 4;
            this.DeletedBtn.Text = "  Deleted";
            this.DeletedBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeletedBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeletedBtn.Click += new System.EventHandler(this.DeletedBtn_Click);
            // 
            // AddNotesBdg
            // 
            this.AddNotesBdg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.AddNotesBdg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddNotesBdg.FlatAppearance.BorderSize = 0;
            this.AddNotesBdg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNotesBdg.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.AddNotesBdg.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.AddNotesBdg.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddNotesBdg.IconSize = 25;
            this.AddNotesBdg.Location = new System.Drawing.Point(234, 18);
            this.AddNotesBdg.Name = "AddNotesBdg";
            this.AddNotesBdg.Size = new System.Drawing.Size(48, 44);
            this.AddNotesBdg.TabIndex = 5;
            this.AddNotesBdg.UseVisualStyleBackColor = false;
            // 
            // AllCountBadge
            // 
            this.AllCountBadge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.AllCountBadge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllCountBadge.FlatAppearance.BorderSize = 0;
            this.AllCountBadge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllCountBadge.Font = new System.Drawing.Font("Oxygen", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllCountBadge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.AllCountBadge.IconChar = FontAwesome.Sharp.IconChar.None;
            this.AllCountBadge.IconColor = System.Drawing.Color.Black;
            this.AllCountBadge.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AllCountBadge.Location = new System.Drawing.Point(234, 68);
            this.AllCountBadge.Name = "AllCountBadge";
            this.AllCountBadge.Size = new System.Drawing.Size(48, 44);
            this.AllCountBadge.TabIndex = 6;
            this.AllCountBadge.Text = "0";
            this.AllCountBadge.UseVisualStyleBackColor = false;
            // 
            // DraftsCountBadge
            // 
            this.DraftsCountBadge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.DraftsCountBadge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DraftsCountBadge.FlatAppearance.BorderSize = 0;
            this.DraftsCountBadge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DraftsCountBadge.Font = new System.Drawing.Font("Oxygen", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DraftsCountBadge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.DraftsCountBadge.IconChar = FontAwesome.Sharp.IconChar.None;
            this.DraftsCountBadge.IconColor = System.Drawing.Color.Black;
            this.DraftsCountBadge.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DraftsCountBadge.Location = new System.Drawing.Point(234, 118);
            this.DraftsCountBadge.Name = "DraftsCountBadge";
            this.DraftsCountBadge.Size = new System.Drawing.Size(48, 44);
            this.DraftsCountBadge.TabIndex = 7;
            this.DraftsCountBadge.Text = "0";
            this.DraftsCountBadge.UseVisualStyleBackColor = false;
            // 
            // ArchivesCountBadge
            // 
            this.ArchivesCountBadge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.ArchivesCountBadge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ArchivesCountBadge.FlatAppearance.BorderSize = 0;
            this.ArchivesCountBadge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ArchivesCountBadge.Font = new System.Drawing.Font("Oxygen", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArchivesCountBadge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.ArchivesCountBadge.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ArchivesCountBadge.IconColor = System.Drawing.Color.Black;
            this.ArchivesCountBadge.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ArchivesCountBadge.Location = new System.Drawing.Point(234, 168);
            this.ArchivesCountBadge.Name = "ArchivesCountBadge";
            this.ArchivesCountBadge.Size = new System.Drawing.Size(48, 44);
            this.ArchivesCountBadge.TabIndex = 8;
            this.ArchivesCountBadge.Text = "0";
            this.ArchivesCountBadge.UseVisualStyleBackColor = false;
            // 
            // DeletedCountBadge
            // 
            this.DeletedCountBadge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.DeletedCountBadge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeletedCountBadge.FlatAppearance.BorderSize = 0;
            this.DeletedCountBadge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeletedCountBadge.Font = new System.Drawing.Font("Oxygen", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletedCountBadge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.DeletedCountBadge.IconChar = FontAwesome.Sharp.IconChar.None;
            this.DeletedCountBadge.IconColor = System.Drawing.Color.Black;
            this.DeletedCountBadge.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DeletedCountBadge.Location = new System.Drawing.Point(234, 218);
            this.DeletedCountBadge.Name = "DeletedCountBadge";
            this.DeletedCountBadge.Size = new System.Drawing.Size(48, 44);
            this.DeletedCountBadge.TabIndex = 9;
            this.DeletedCountBadge.Text = "0";
            this.DeletedCountBadge.UseVisualStyleBackColor = false;
            // 
            // LogoBtn
            // 
            this.LogoBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoBtn.FlatAppearance.BorderSize = 0;
            this.LogoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoBtn.Font = new System.Drawing.Font("Nobile Medium", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.LogoBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.LogoBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.LogoBtn.IconColor = System.Drawing.Color.Black;
            this.LogoBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LogoBtn.Location = new System.Drawing.Point(0, 0);
            this.LogoBtn.Name = "LogoBtn";
            this.LogoBtn.Padding = new System.Windows.Forms.Padding(15, 10, 0, 0);
            this.LogoBtn.Size = new System.Drawing.Size(300, 100);
            this.LogoBtn.TabIndex = 0;
            this.LogoBtn.Text = "Polaris";
            this.LogoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoBtn.UseVisualStyleBackColor = true;
            this.LogoBtn.Click += new System.EventHandler(this.LogoBtn_Click);
            // 
            // TitlePanel
            // 
            this.TitlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.TitlePanel.Controls.Add(this.LabelText);
            this.TitlePanel.Controls.Add(this.TogglePanelBtn);
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePanel.Location = new System.Drawing.Point(300, 0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(882, 80);
            this.TitlePanel.TabIndex = 1;
            // 
            // LabelText
            // 
            this.LabelText.AutoSize = true;
            this.LabelText.Font = new System.Drawing.Font("Nobile Medium", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.LabelText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.LabelText.Location = new System.Drawing.Point(85, 30);
            this.LabelText.Name = "LabelText";
            this.LabelText.Size = new System.Drawing.Size(103, 23);
            this.LabelText.TabIndex = 1;
            this.LabelText.Text = "Overview";
            // 
            // TogglePanelBtn
            // 
            this.TogglePanelBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.TogglePanelBtn.FlatAppearance.BorderSize = 0;
            this.TogglePanelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TogglePanelBtn.IconChar = FontAwesome.Sharp.IconChar.Reorder;
            this.TogglePanelBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.TogglePanelBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.TogglePanelBtn.IconSize = 40;
            this.TogglePanelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TogglePanelBtn.Location = new System.Drawing.Point(0, 0);
            this.TogglePanelBtn.Name = "TogglePanelBtn";
            this.TogglePanelBtn.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.TogglePanelBtn.Size = new System.Drawing.Size(80, 80);
            this.TogglePanelBtn.TabIndex = 0;
            this.TogglePanelBtn.UseVisualStyleBackColor = true;
            this.TogglePanelBtn.Click += new System.EventHandler(this.TogglePanelBtn_Click);
            // 
            // EmbedPanel
            // 
            this.EmbedPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(24)))));
            this.EmbedPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmbedPanel.Location = new System.Drawing.Point(300, 80);
            this.EmbedPanel.Name = "EmbedPanel";
            this.EmbedPanel.Size = new System.Drawing.Size(882, 573);
            this.EmbedPanel.TabIndex = 2;
            // 
            // Root
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.EmbedPanel);
            this.Controls.Add(this.TitlePanel);
            this.Controls.Add(this.SidePanel);
            this.Font = new System.Drawing.Font("Nobile", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Name = "Root";
            this.ShowIcon = false;
            this.Text = "Polaris";
            this.SidePanel.ResumeLayout(false);
            this.ClassesPanel.ResumeLayout(false);
            this.TasksPanel.ResumeLayout(false);
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Panel EmbedPanel;
        private FontAwesome.Sharp.IconButton TogglePanelBtn;
        private System.Windows.Forms.Label LabelText;
        private FontAwesome.Sharp.IconButton LogoBtn;
        private System.Windows.Forms.TableLayoutPanel TasksPanel;
        private FontAwesome.Sharp.IconButton TasksBtn;
        private FontAwesome.Sharp.IconButton AllBtn;
        private FontAwesome.Sharp.IconButton DraftsBtn;
        private FontAwesome.Sharp.IconButton ArchivesBtn;
        private FontAwesome.Sharp.IconButton DeletedBtn;
        private FontAwesome.Sharp.IconButton AddNotesBdg;
        private FontAwesome.Sharp.IconButton AllCountBadge;
        private FontAwesome.Sharp.IconButton DraftsCountBadge;
        private FontAwesome.Sharp.IconButton ArchivesCountBadge;
        private FontAwesome.Sharp.IconButton DeletedCountBadge;
        private System.Windows.Forms.TableLayoutPanel ClassesPanel;
        private FontAwesome.Sharp.IconButton ClassesBtn;
        private FontAwesome.Sharp.IconButton AddClassesBdg;
    }
}

