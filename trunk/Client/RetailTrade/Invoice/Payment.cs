using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RetailTradeClient.Invoice
{
    public partial class Payment : Form
    {
        MDataSet.InvoiceMasterRow _sourceRow;
        private decimal _CashCustomer;
        private decimal _Change;

        public decimal Change
        {
            get { 
                _Change = _CashCustomer - _sourceRow.Sum;
                return _Change ;
            }
            set { _Change = _CashCustomer - _sourceRow.Sum; }
        }

        public decimal CashCustomer
        {
            get { return _CashCustomer; }
            set { _CashCustomer = value; }
        }

       

        public Payment()
        {
            InitializeComponent();
        }

        public Payment(MDataSet.InvoiceMasterRow sourceRow)
        {
            InitializeComponent();
            _sourceRow = sourceRow;
        //    _CashCustomer = 0;
            this.invoiceMasterBindingSource.DataSource = _sourceRow;

            CashEdit.DataBindings.Add(new Binding("Text",this,"CashCustomer"));

            labelCanges.DataBindings.Add(new Binding("Text", this, "Change"));
        }

        private void Payment_Load(object sender, EventArgs e)
        {
           
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                DialogResult = DialogResult.None;
            else
                DialogResult = DialogResult.OK;
        }

        

        private void CashEdit_Validating(object sender, CancelEventArgs e)
        {
//
            if (Convert.ToDecimal(CashEdit.Text) < _sourceRow.Sum)
            {
                CashEdit.ErrorText = "Неверная сумма";
                e.Cancel = true;
            }
           
        }


    }
}