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
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.All = new Polaris.Components.TaskMenu();
            this.Tasks = new Polaris.Components.SidebarMenu();
            this.placeholder1 = new System.Windows.Forms.Panel();
            this.border2 = new System.Windows.Forms.Panel();
            this.roundedButton1 = new Polaris.Components.RoundedButton();
            this.mainHeaderPanel = new System.Windows.Forms.Panel();
            this.toggleSidebarButton = new Polaris.Components.RoundedButton();
            this.border1 = new System.Windows.Forms.Panel();
            this.mainEmbedPanel = new System.Windows.Forms.Panel();
            this.Drafts = new Polaris.Components.TaskMenu();
            this.Archived = new Polaris.Components.TaskMenu();
            this.Deleted = new Polaris.Components.TaskMenu();
            this.placeholder = new System.Windows.Forms.Panel();
            this.border3 = new System.Windows.Forms.Panel();
            this.sidebarPanel.SuspendLayout();
            this.mainHeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.sidebarPanel.Controls.Add(this.border3);
            this.sidebarPanel.Controls.Add(this.placeholder);
            this.sidebarPanel.Controls.Add(this.Deleted);
            this.sidebarPanel.Controls.Add(this.Archived);
            this.sidebarPanel.Controls.Add(this.Drafts);
            this.sidebarPanel.Controls.Add(this.All);
            this.sidebarPanel.Controls.Add(this.Tasks);
            this.sidebarPanel.Controls.Add(this.placeholder1);
            this.sidebarPanel.Controls.Add(this.border2);
            this.sidebarPanel.Controls.Add(this.roundedButton1);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.sidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(300, 678);
            this.sidebarPanel.TabIndex = 1;
            // 
            // All
            // 
            this.All.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.All.BadgeText = "0";
            this.All.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.All.ButtonText = "  All";
            this.All.Dock = System.Windows.Forms.DockStyle.Top;
            this.All.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.All.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.All.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.All.Location = new System.Drawing.Point(0, 183);
            this.All.Name = "All";
            this.All.Size = new System.Drawing.Size(300, 50);
            this.All.TabIndex = 4;
            // 
            // Tasks
            // 
            this.Tasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.Tasks.BadgeIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.Tasks.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.Tasks.ButtonText = "  Tasks";
            this.Tasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tasks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Tasks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.Tasks.IconChar = FontAwesome.Sharp.IconChar.ListCheck;
            this.Tasks.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.Tasks.Location = new System.Drawing.Point(0, 123);
            this.Tasks.Name = "Tasks";
            this.Tasks.Size = new System.Drawing.Size(300, 60);
            this.Tasks.TabIndex = 3;
            // 
            // placeholder1
            // 
            this.placeholder1.Dock = System.Windows.Forms.DockStyle.Top;
            this.placeholder1.Location = new System.Drawing.Point(0, 113);
            this.placeholder1.Name = "placeholder1";
            this.placeholder1.Size = new System.Drawing.Size(300, 10);
            this.placeholder1.TabIndex = 2;
            // 
            // border2
            // 
            this.border2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.border2.Dock = System.Windows.Forms.DockStyle.Top;
            this.border2.Location = new System.Drawing.Point(0, 110);
            this.border2.Name = "border2";
            this.border2.Size = new System.Drawing.Size(300, 3);
            this.border2.TabIndex = 1;
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.roundedButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.roundedButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundedButton1.BorderRadius = 0;
            this.roundedButton1.BorderSize = 0;
            this.roundedButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(43)))));
            this.roundedButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.roundedButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.roundedButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.roundedButton1.IconColor = System.Drawing.Color.Black;
            this.roundedButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.roundedButton1.Location = new System.Drawing.Point(0, 0);
            this.roundedButton1.Margin = new System.Windows.Forms.Padding(0);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.roundedButton1.Size = new System.Drawing.Size(300, 110);
            this.roundedButton1.TabIndex = 0;
            this.roundedButton1.Text = "Polaris";
            this.roundedButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.roundedButton1.UseVisualStyleBackColor = false;
            // 
            // mainHeaderPanel
            // 
            this.mainHeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.mainHeaderPanel.Controls.Add(this.toggleSidebarButton);
            this.mainHeaderPanel.Controls.Add(this.border1);
            this.mainHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainHeaderPanel.Location = new System.Drawing.Point(300, 0);
            this.mainHeaderPanel.Name = "mainHeaderPanel";
            this.mainHeaderPanel.Size = new System.Drawing.Size(822, 80);
            this.mainHeaderPanel.TabIndex = 3;
            // 
            // toggleSidebarButton
            // 
            this.toggleSidebarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.toggleSidebarButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.toggleSidebarButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.toggleSidebarButton.BorderRadius = 15;
            this.toggleSidebarButton.BorderSize = 0;
            this.toggleSidebarButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleSidebarButton.FlatAppearance.BorderSize = 0;
            this.toggleSidebarButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.toggleSidebarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.toggleSidebarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toggleSidebarButton.ForeColor = System.Drawing.Color.White;
            this.toggleSidebarButton.IconChar = FontAwesome.Sharp.IconChar.Reorder;
            this.toggleSidebarButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.toggleSidebarButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.toggleSidebarButton.IconSize = 30;
            this.toggleSidebarButton.Location = new System.Drawing.Point(25, 15);
            this.toggleSidebarButton.Name = "toggleSidebarButton";
            this.toggleSidebarButton.Padding = new System.Windows.Forms.Padding(2, 4, 0, 0);
            this.toggleSidebarButton.Size = new System.Drawing.Size(50, 50);
            this.toggleSidebarButton.TabIndex = 2;
            this.toggleSidebarButton.TextColor = System.Drawing.Color.White;
            this.toggleSidebarButton.UseVisualStyleBackColor = false;
            this.toggleSidebarButton.Click += new System.EventHandler(this.toggleSidebarButton_Click);
            // 
            // border1
            // 
            this.border1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.border1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.border1.Location = new System.Drawing.Point(0, 78);
            this.border1.Name = "border1";
            this.border1.Size = new System.Drawing.Size(822, 2);
            this.border1.TabIndex = 0;
            // 
            // mainEmbedPanel
            // 
            this.mainEmbedPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.mainEmbedPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainEmbedPanel.Location = new System.Drawing.Point(300, 80);
            this.mainEmbedPanel.Name = "mainEmbedPanel";
            this.mainEmbedPanel.Size = new System.Drawing.Size(822, 598);
            this.mainEmbedPanel.TabIndex = 4;
            // 
            // Drafts
            // 
            this.Drafts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.Drafts.BadgeText = "0";
            this.Drafts.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.Drafts.ButtonText = "  Drafts";
            this.Drafts.Dock = System.Windows.Forms.DockStyle.Top;
            this.Drafts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Drafts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.Drafts.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.Drafts.Location = new System.Drawing.Point(0, 233);
            this.Drafts.Name = "Drafts";
            this.Drafts.Size = new System.Drawing.Size(300, 50);
            this.Drafts.TabIndex = 5;
            // 
            // Archived
            // 
            this.Archived.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.Archived.BadgeText = "0";
            this.Archived.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.Archived.ButtonText = "  Archived";
            this.Archived.Dock = System.Windows.Forms.DockStyle.Top;
            this.Archived.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Archived.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.Archived.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.Archived.Location = new System.Drawing.Point(0, 283);
            this.Archived.Name = "Archived";
            this.Archived.Size = new System.Drawing.Size(300, 50);
            this.Archived.TabIndex = 6;
            // 
            // Deleted
            // 
            this.Deleted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.Deleted.BadgeText = "0";
            this.Deleted.ButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.Deleted.ButtonText = "  Deleted";
            this.Deleted.Dock = System.Windows.Forms.DockStyle.Top;
            this.Deleted.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Deleted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.Deleted.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(115)))));
            this.Deleted.Location = new System.Drawing.Point(0, 333);
            this.Deleted.Name = "Deleted";
            this.Deleted.Size = new System.Drawing.Size(300, 50);
            this.Deleted.TabIndex = 7;
            // 
            // placeholder
            // 
            this.placeholder.Dock = System.Windows.Forms.DockStyle.Top;
            this.placeholder.Location = new System.Drawing.Point(0, 383);
            this.placeholder.Name = "placeholder";
            this.placeholder.Size = new System.Drawing.Size(300, 20);
            this.placeholder.TabIndex = 8;
            // 
            // border3
            // 
            this.border3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.border3.Dock = System.Windows.Forms.DockStyle.Top;
            this.border3.Location = new System.Drawing.Point(0, 403);
            this.border3.Name = "border3";
            this.border3.Size = new System.Drawing.Size(300, 3);
            this.border3.TabIndex = 9;
            // 
            // Root
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 678);
            this.Controls.Add(this.mainEmbedPanel);
            this.Controls.Add(this.mainHeaderPanel);
            this.Controls.Add(this.sidebarPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1140, 725);
            this.Name = "Root";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Polaris";
            this.sidebarPanel.ResumeLayout(false);
            this.mainHeaderPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Panel mainHeaderPanel;
        private System.Windows.Forms.Panel border1;
        private System.Windows.Forms.Panel mainEmbedPanel;
        private Components.RoundedButton toggleSidebarButton;
        private System.Windows.Forms.Panel border2;
        private Components.RoundedButton roundedButton1;
        private System.Windows.Forms.Panel placeholder1;
        private Components.SidebarMenu Tasks;
        private Components.TaskMenu All;
        private Components.TaskMenu Deleted;
        private Components.TaskMenu Archived;
        private Components.TaskMenu Drafts;
        private System.Windows.Forms.Panel border3;
        private System.Windows.Forms.Panel placeholder;
    }
}