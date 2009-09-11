using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RetailTradeOrders.Dialog
{
    public partial class FormLogon : Form
    {
        public FormLogon(MDataSet.LocalSettingRow _sourceRow)
        {
            InitializeComponent();

            this.localSettingBindingSource.DataSource = _sourceRow; 
        }

        private void FormLogon_Load(object sender, EventArgs e)
        {
          
        }

        
        private void btOk_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.None;
        }

        private void textBoxPsw_Validating(object sender, CancelEventArgs e)
        {
            if (this.textBoxPsw.Text != (this.localSettingBindingSource.DataSource as MDataSet.LocalSettingRow).Password.ToString())
            {
                this.errorProvider1.SetError(this.textBoxPsw, "Неверный пароль !");
                e.Cancel = true;
            }
        }
    }
}