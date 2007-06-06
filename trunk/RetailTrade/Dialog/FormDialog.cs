using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RetailTrade
{
    public partial class FormDialog : Form
    {
        public FormDialog()
        {
            InitializeComponent();
        }

     

        private void btOk_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
                DialogResult = DialogResult.None;

        }

        private void textBox_Validated(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
               
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.ValidateChildren();
            
        }

        private void FormDialog_Load(object sender, EventArgs e)
        {
           

        }

       
       
    }
}