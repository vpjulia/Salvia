using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RetailTradeOrders
{
    public partial class FormDialog : Form
    {
        private MainForm _MainForm;

        public MainForm MainForm
        {
            get { return _MainForm; }
            set { _MainForm = value; }
        }


        public FormDialog()
        {
            InitializeComponent();

            
        }

        public  MainForm FindMainForm(Form sender)
        {
            if ((sender as MainForm) != null)
                return (sender as MainForm);
            else
                return FindMainForm(sender.Owner);
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
                DialogResult = DialogResult.None;

        }

        private void FormDialog_Load(object sender, EventArgs e)
        {
            _MainForm = FindMainForm(this);
        }

    }
}