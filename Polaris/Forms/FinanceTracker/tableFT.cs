﻿using System.ComponentModel;
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

        private string _value = "0";
        private string _description = "Description";
        private string _createdDate = "Created Date";
        private string _modifiedDate = "Modified Date";
        private Color _color = ColorTranslator.FromHtml("#141519");

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

        private void tableFT_Load(object sender, System.EventArgs e)
        {
        }
    }
}