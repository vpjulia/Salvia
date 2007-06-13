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

         /*   if (_productRow.MinDivisor == 1)
                this.QuantityEdit.Properties.Mask.EditMask = "D";
            else
           */
            
            this.QuantityEdit.Properties.Mask.EditMask = "#####0.000";

       //     source.BeginEdit();

        }


        private void button1_Click(object sender, EventArgs e)
        {
          this.ValidateChildren();   
           //    this.receiptDetailBindingSource.EndEdit();
         
        }

        private void ReceiptDetailRowAdd_Validating(object sender, CancelEventArgs e)
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

        private void textEdit1_Validating(object sender, CancelEventArgs e)
        {
            
       //  if (this.QuantityEdit.Properties.Mask.ToString()!= "D")

            
        }

       


    }
}
