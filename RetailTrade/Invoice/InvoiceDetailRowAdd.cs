using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace RetailTrade.Invoice
{
    public partial class InvoiceDetailRowAdd : UserControl
    {
        private decimal _quantytiStock;

        public InvoiceDetailRowAdd()
        {
            InitializeComponent();
        }

        public InvoiceDetailRowAdd(MDataSet.InvoiceDetailRow source, MDataSet.RemainsRow remain)
        {
            InitializeComponent();
          
            this.invoiceDetailBindingSource.DataSource = source;

         //   this.productBindingSource.DataSource = remain;
            // this.productBindingSource.ResetBindings(false); 
            
            source.LocalReceiptDetailRef = remain.ReceiptDetailRef;
        //    source.Quantity = remain.QuantityRemains;
            _quantytiStock = remain.QuantityRemains;
            
          
            this.invoiceDetailBindingSource.ResetBindings(true);

           

            this.errorProvider1.DataSource = this.invoiceDetailBindingSource;
            this.errorProvider1.UpdateBinding();
            source.EndEdit();
        }

       
        private void quantityEdit_Validated(object sender, EventArgs e)
        {
            if (Decimal.Parse(this.quantityEdit.Text)<=0)
            { 
                errorProvider1.SetError((sender as Control), "Неверное количество");
             
                this.quantityEdit.SelectAll();
            } 
           
       }

        private void InvoiceDetailRowAdd_Validating(object sender, CancelEventArgs e)
        {
            if  (this.ValidateChildren())        
              foreach (Control ctrl in this.Controls)           
                    if (errorProvider1.GetError(ctrl) != "")
                    { 
                        ctrl.Focus();
                        e.Cancel = true;

                        break;
                    }
        }

        private void priceEdit_Validated(object sender, EventArgs e)
        {

            if (this.priceEdit.Text.Length == 0)
            { 
             errorProvider1.SetError((sender as Control), "Введите цену!");
            
                this.quantityEdit.SelectAll();
            }
            else

            if (Decimal.Parse(this.priceEdit.Text) <= 0)
            {
                errorProvider1.SetError((sender as Control), "Введите нормальную цену!");
                this.quantityEdit.SelectAll();
           
            } 
        }

       


    }
}
