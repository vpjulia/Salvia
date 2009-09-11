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

            this.mDataSet = (source.Table.DataSet as MDataSet);
            this.receiptDetailBindingSource.DataSource = _receiptDetailRow;
            this.productBindingSource.DataSource = _productRow;

            this.productBindingSource.ResetBindings(false);
            this.receiptDetailBindingSource.ResetBindings(true);

            this.manufacturerBindingSource.DataSource = this.mDataSet.Manufacturer;

            this.errorProvider1.DataSource = this.receiptDetailBindingSource;
            this.errorProvider1.UpdateBinding();
        }


        

        private void ReceiptDetailRowAdd_Validating(object sender, CancelEventArgs e)
        {

           
            this.receiptDetailBindingSource.EndEdit();


          
           

            this.receiptDetailBindingSource.EndEdit();

             if (!this.ValidateChildren())
                e.Cancel = true;

            foreach (Control ctrl in this.tableLayoutPanel1.Controls)
                if (errorProvider1.GetError(ctrl) != "")
                    {
                        ctrl.Focus();
                        e.Cancel = true;
                        return;
                   }

       }

        

        private void ReceiptDetailRowAdd_Load(object sender, EventArgs e)
        {
          
           
            _receiptDetailRow.ProductRef = _productRow.ID;
            _receiptDetailRow.PricePurchase = 0;
         //   _receiptDetailRow.Quantity = 0;
            this.QuantityEdit.DoValidate();


        }

        

        private void productBindingSource_DataError(object sender, BindingManagerDataErrorEventArgs e)
        {
            MessageBox.Show("DataError");
        }

        private void QuantityEdit_Leave(object sender, EventArgs e)
        {
           // this.QuantityEdit.DoValidate();
        }

        private void btManRefresh_Click(object sender, EventArgs e)
        {
            string name = this.ManufacturerlookUpEdit.Text;

            if (name.Length == 0) return;

            if (name.Length > 3)
                name = name.Substring(0, 3);
            
            try
            {
                MDataSet.ManufacturerDataTable _tmp = new MDataSet.ManufacturerDataTable();

                (this.ParentForm as FormDialog).MainForm.manufacturerTableAdapter.FillByName(_tmp,name);
                this.mDataSet.Manufacturer.Merge(_tmp);
             }

            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
            
        }

        private void ManufacturerlookUpEdit_GetNotInListValue(object sender, DevExpress.XtraEditors.Controls.GetNotInListValueEventArgs e)
        {
            MessageBox.Show("Запись не найдена");
        }

        private void QuantityEdit_Validating(object sender, CancelEventArgs e)
        {
            if (Convert.ToDecimal(this.QuantityEdit.EditValue) <= 0)
            {
                this.errorProvider1.SetError(this.QuantityEdit, "Неверное кол-во");
                e.Cancel=true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.receiptDetailBindingSource.EndEdit();
        }

       
       

       


    }
}
