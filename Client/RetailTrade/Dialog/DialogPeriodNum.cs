using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RetailTradeClient.Dialog
{
    public partial class DialogPeriodNum : Form
    {
        public DialogPeriodNum()
        {
            InitializeComponent();
        }

        private void startEdir_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (!( startEdit.Value>0 & startEdit.Value<=endEdit.Value)     )
            {
            
                errorProvider1.SetError(startEdit,"Неверно задан период!");
                this.DialogResult =DialogResult.None;
                
            
            }
            else
            {
                this.DialogResult =DialogResult.OK;
            
            }
        }
    }
}