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

        MDataSet.RemainsRow _remainsRow;


        MDataSet.InvoiceDetailRow _row;

        public InvoiceDetailRowAdd()
        {
            InitializeComponent();
        }

        public InvoiceDetailRowAdd(MDataSet.InvoiceDetailRow source, MDataSet.RemainsRow remain, MDataSet.ProductRow productRow)
        {
            InitializeComponent();

            _productRow = productRow;

            _remainsRow = remain;
            _row = source;

            if (_productRow.MinDivisor == 1)
            {


                this.quantityEdit.Properties.DisplayFormat.FormatString = "####";
                this.quantityEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                this.quantityEdit.Properties.EditFormat.FormatString = "###";
                this.quantityEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                this.quantityEdit.Properties.Mask.EditMask = "####";
                this.quantityEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;


            }

            this.lnumOst.Text = _remainsRow.QuantityRemains.ToString();

                 //количество целых упаковок : 

            if (_productRow.OldKol != 1)
                {

                    int rem = Convert.ToInt32(_remainsRow.QuantityRemains + _row.Quantity);

                    int q = (int)rem / _productRow.OldKol;
               
                    if (q != 0)
                    {

                        this.labelOst.Text = q.ToString() + " целых уп.";

                    }
                    //количество едениц

                    int c = (int)(rem - q * _productRow.OldKol);

                    if (c != 0)
                    {

                        if (this.labelOst.Text.Length == 0)
                        {
                            this.labelOst.Text = c.ToString() + _productRow.UnitName;
                        }
                        else
                        {
                            this.labelOst.Text += "+ " + c.ToString() + _productRow.UnitName;
                        }
                    }
                  
                   this.labelOst.Visible = true;
                }
            
            else
            {
                this.lComment.Text = "{в упаковке " + _productRow.MinDivisor.ToString() + " шт}";
                this.lComment.Visible = true;

            }

               

           
           
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
            try
            {
                if (Decimal.Parse(this.quantityEdit.Text) <= 0)
                {
                    errorProvider1.SetError((sender as Control), "Ќеверное количество");

                    this.quantityEdit.SelectAll();
                }

                if (_productRow.MinDivisor != 1)
                {
                    double ed;
                    ed = 1.000 / _productRow.MinDivisor;
                    double proposed = Double.Parse(this.quantityEdit.Text);
                    if (Convert.ToInt32((proposed / ed) * 1000) != Convert.ToInt32(proposed / ed) * 1000)
                    {
                        this.errorProvider1.SetError(this.quantityEdit, "Ќеверное значение после зап€той!");
                        this.quantityEdit.SelectAll();
                    }

                }
            }
            catch (Exception err)

            {
            MessageBox.Show (err.Message);


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
             errorProvider1.SetError((sender as Control), "¬ведите цену!");
            
                this.quantityEdit.SelectAll();
            }
            else

            if (Decimal.Parse(this.priceEdit.Text) <= 0)
            {
                errorProvider1.SetError((sender as Control), "¬ведите нормальную цену!");
                this.quantityEdit.SelectAll();
           
            } 
            */
        }

        private void quantityEdit_EditValueChanged(object sender, EventArgs e)
        {
            int rem;

            try
            {
                rem = Convert.ToInt32(this.quantityEdit.EditValue);
                    
            }
            catch 
            {
            return;
            }

            this.lQuant.Text = "";

            {
                

                int q = (int)rem / _productRow.OldKol;

                if (q != 0)
                {

                    this.lQuant.Text = q.ToString() + " целых уп.";

                }
                //количество едениц

                int c = (int)(rem - q * _productRow.OldKol);

                if (c != 0)
                {

                    if (this.lQuant.Text.Length == 0)
                    {
                        this.lQuant.Text = c.ToString() + _productRow.UnitName;
                    }
                    else
                    {
                        this.lQuant.Text += "+ " + c.ToString() + _productRow.UnitName;
                    }
                }

                
            }



        }

       


    }
}
