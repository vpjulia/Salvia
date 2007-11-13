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

            this.manufacturerBindingSource.DataSource = (source.Table.DataSet as MDataSet).Manufacturer;

            this.errorProvider1.DataSource = this.receiptDetailBindingSource;
            this.errorProvider1.UpdateBinding();
        }


        

        private void ReceiptDetailRowAdd_Validating(object sender, CancelEventArgs e)
        {
            string tmp = this.QuantityEdit.Text;

            this.PriceEdit.DoValidate();

            this.QuantityEdit.Text = tmp;

            this.QuantityEdit.DoValidate();

             if (!this.ValidateChildren())
                e.Cancel = true;

             /* foreach (Control ctrl in this.tableLayoutPanel1.Controls)
                if (errorProvider1.GetError(ctrl) != "")
                    {
                        ctrl.Focus();
                        e.Cancel = true;
                        break;
                   }*/

       }

        

        private void ReceiptDetailRowAdd_Load(object sender, EventArgs e)
        {
          
           
            _receiptDetailRow.ProductRef = _productRow.ID;
            _receiptDetailRow.PricePurchase = 0;
            _receiptDetailRow.Quantity = 0;
           
        }

        

        private void productBindingSource_DataError(object sender, BindingManagerDataErrorEventArgs e)
        {
            MessageBox.Show("DataError");
        }

        private void QuantityEdit_Leave(object sender, EventArgs e)
        {
           // this.QuantityEdit.DoValidate();
        }

       

       


    }
}
