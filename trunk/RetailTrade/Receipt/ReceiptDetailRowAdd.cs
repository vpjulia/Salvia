using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace RetailTrade.Receipt
{
    public partial class ReceiptDetailRowAdd : UserControl
    {

        private MDataSet.ProductRow _productRow;
        private MDataSet.ReceiptDetailRow _receiptDetailRow;


        public ReceiptDetailRowAdd()
        {
            InitializeComponent();
        }

        public ReceiptDetailRowAdd(MDataSet.ReceiptDetailRow source,MDataSet.ProductRow product)
        {
            InitializeComponent();
            _receiptDetailRow = source;
            _productRow = product;

            this.receiptDetailBindingSource.DataSource = _receiptDetailRow;
            this.productBindingSource.DataSource = _productRow;

            this.productBindingSource.ResetBindings(false);
            this.receiptDetailBindingSource.ResetBindings(true);

            _receiptDetailRow.ProductRef = _productRow.ID;

            
            _receiptDetailRow.ProductRef = _productRow.ID;
    

            this.errorProvider1.DataSource = this.receiptDetailBindingSource;
            this.errorProvider1.UpdateBinding();
        }


        

        private void ReceiptDetailRowAdd_Validating(object sender, CancelEventArgs e)
        {
            
          //  this.receiptDetailBindingSource.CurrencyManager.EndCurrentEdit();
          if (this.ValidateChildren())
            {
              foreach (Control ctrl in this.tableLayoutPanel1.Controls)
                {
                    ctrl.Focus();
                    if (errorProvider1.GetError(ctrl) != "")
                    {
                        e.Cancel = true;

                        break;
                    }
                }
            }
        }

        

        private void ReceiptDetailRowAdd_Load(object sender, EventArgs e)
        {
          // this.QuantityEdit.EditValue = 0;
           
            _receiptDetailRow.ProductRef = _productRow.ID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.receiptDetailBindingSource.CurrencyManager.EndCurrentEdit();
         
        }

        private void productBindingSource_DataError(object sender, BindingManagerDataErrorEventArgs e)
        {
            MessageBox.Show("DataError");
        }

       


    }
}