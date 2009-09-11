using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RetailTradeOrders.Dialog
{
    public partial class DialogOfExpend : Form
    {
        private MDataSet.CashRow _cash;


        private decimal _SummExpend;

        public decimal SummExpend
        {
            get { return _SummExpend; }
            set { _SummExpend = value; }
        }

        public DialogOfExpend(MDataSet.CashRow cashrow)
        {
            InitializeComponent();
            _cash = cashrow;
            this.cashBindingSource.DataSource = _cash;
            this.cashBindingSource.ResetBindings(true);
            this.SummEdit.DataBindings.Add(new Binding("EditValue", this, "SummExpend"));

        }

        private void DialogOfExpend_Load(object sender, EventArgs e)
        {
          
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            decimal sum = (Convert.ToDecimal(this.SummEdit.Text));
  
            if ((sum <=0)| (sum > _cash.BalanceEnd))
            {
                this.errorProvider1.SetError(SummEdit,"Неверная сумма!");
                this.DialogResult = DialogResult.None;
                return;
            }

            this.DialogResult= DialogResult.OK;

        }

        private void SummEdit_Validating(object sender, CancelEventArgs e)
        {
            decimal sum = (Convert.ToDecimal(this.SummEdit.Text));

            if ((sum <= 0) | (sum > _cash.BalanceEnd))
            {
                this.errorProvider1.SetError(SummEdit, "Неверная сумма!");
                e.Cancel = true;

            }
            else
            {
                this.errorProvider1.SetError(SummEdit, "");
            
            }
        }
    }
}