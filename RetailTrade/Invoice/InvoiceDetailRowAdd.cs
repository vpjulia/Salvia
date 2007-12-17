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

        private MDataSet.ProductRow _productRow;

        public InvoiceDetailRowAdd()
        {
            InitializeComponent();
        }

        public InvoiceDetailRowAdd(MDataSet.InvoiceDetailRow source, MDataSet.RemainsRow remain)
        {
            InitializeComponent();

             _productRow = remain.ProductRow;


             if (_productRow.MinDivisor == 1)
             {

               //  this.quantityEdt1.Visible = true;
             //    this.quantityEdit.Visible = false;

                 this.quantityEdit.Properties.DisplayFormat.FormatString = "####";
                 this.quantityEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                 this.quantityEdit.Properties.EditFormat.FormatString = "###";
                 this.quantityEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                 this.quantityEdit.Properties.Mask.EditMask = "####";
                 this.quantityEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
          


               /*  this.quantityEdit.Properties.DisplayFormat.FormatString = "#####";
                 this.quantityEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                 this.quantityEdit.Properties.EditFormat.FormatString = "#####";
                 this.quantityEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            */
             }
           /*  else
             {
                 this.quantityEdit.Properties.EditFormat.FormatString = "n3";

               //  this.quantityEdit.Properties.Mask.EditMask = "n3"; 
             
             }*/

            this.labelOst.Text = remain.QuantityRemains.ToString();
           
            this.mDataSet = source.Table.DataSet as MDataSet;
            this.invoiceDetailBindingSource.DataSource = source;
        
           this.productBindingSource.DataSource = _productRow;
           this.productBindingSource.ResetBindings(false); 
          
            if (source.LocalReceiptDetailRef==0 )  
               source.LocalReceiptDetailRef = remain.ReceiptDetailRef;

           this.remainsBindingSource.DataSource = remain;

           

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

            if (_productRow.MinDivisor != 1)
            {
                double ed;
                ed = 1.000/_productRow.MinDivisor;
                double proposed = Double.Parse(this.quantityEdit.Text);
                if (Convert.ToInt32((proposed / ed) * 1000) != Convert.ToInt32(proposed / ed) * 1000)
                {
                    this.errorProvider1.SetError(this.quantityEdit, "Неверное значение после запятой!");
                    this.quantityEdit.SelectAll();
                }

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
         /*  
             
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
            */
        }

       


    }
}
