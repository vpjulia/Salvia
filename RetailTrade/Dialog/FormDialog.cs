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

       

        

       
       
       
    }
}