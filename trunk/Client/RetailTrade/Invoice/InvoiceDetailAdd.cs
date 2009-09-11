using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace RetailTradeClient.Invoice.InvoiceTradePutlet
{
    public partial class InvoiceDetailAdd : UserControl
    {
        MDataSet.InvoiceDetailRow _row;
        MDataSet.ProductRow _prodRow;
        
        MainForm _mainForm;

        

        public decimal SumRow
        {
            get
            {
                if (this.QuantityEdit.Text.Length == 0)
                {
                    return 0;
                }
                else
                {
                    decimal res;
                    try
                    { 
                    res = Convert.ToDecimal(this.QuantityEdit.Text) * _remainsRow.PricePurchase;
                    return res;
                    }
                    catch
                    {
                        return 0;
                    }

                    
                      
                }
; }
           
        }


        private decimal _QuantityRemains;


        public Decimal QuantityRemains
        {
            get
            {
                return _QuantityRemains;

                // return _remainsRow.QuantityRemains; }
            }
        }

        MDataSet.RemainsRow _remainsRow;

        public InvoiceDetailAdd()
        {
            InitializeComponent();
        }

        public InvoiceDetailAdd(MDataSet.InvoiceDetailRow source, MDataSet.RemainsRow remainsRow, MainForm mainForm)
        {
            InitializeComponent();
            _row = source;
            _mainForm = mainForm;
            _remainsRow = remainsRow;

            _QuantityRemains = remainsRow.QuantityRemains;

            _prodRow = remainsRow.ProductRow;

     //       _mainForm.RefreshData(_remainsRow);

            this.productBindingSource.DataSource = _prodRow;
            
            this.productBindingSource.ResetBindings(true);

            _row.LocalReceiptDetailRef = _remainsRow.ReceiptDetailRef;

            
            if (QuantityRemains >= 1)
                _row.Quantity = 1;
            else
                _row.Quantity = QuantityRemains;



            if (_prodRow.MinDivisor == 1)
            {
                this.QuantityEdit.Properties.DisplayFormat.FormatString = "####0";
                this.QuantityEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                this.QuantityEdit.Properties.EditFormat.FormatString = "###0";
                this.QuantityEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                this.QuantityEdit.Properties.Mask.EditMask = "####0";
                this.QuantityEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                this.lRemFull.Text = "";
                // написать кол-во в блистерах или целых упаковках

                //количество целых упаковок : 

               if (_prodRow.OldKol != 1)
                {

                    int rem = Convert.ToInt32(_remainsRow.QuantityRemains + _row.Quantity);

                   int q =(int) rem / _prodRow.OldKol;
               
                    if (q != 0)
                    {

                        this.lRemFull.Text = q.ToString() + " целых уп.";

                    }
                    //количество едениц

                    int c = (int)(rem - q * _prodRow.OldKol);

                    if (c != 0)
                    {

                        if (this.lRemFull.Text.Length == 0)
                        {
                            this.lRemFull.Text = c.ToString() + _prodRow.UnitName;
                        }
                        else
                        {
                            this.lRemFull.Text += "+ " + c.ToString() + _prodRow.UnitName;
                        }
                    }
                   this.labelRem.Visible = false;
                   this.lRemFull.Visible = true;
                }
            }
            else
            {
                this.lComment.Text = "{в упаковке " + _prodRow.MinDivisor.ToString() +" шт}";
                this.lComment.Visible = true;
            }



            if ((_prodRow.StorageConditionRef > 0))
            {

                this.additionPanel.Visible = true;

                this.labelPlace.Text = this._prodRow.StorageConditionName;
             
            }


            _row.PriceRetailNDS = _remainsRow.PricePurchase;

            this.remainsBindingSource.DataSource = _remainsRow;

            this.invoiceDetailBindingSource.DataSource = source;
           
            this.labelRem.DataBindings.Clear();
            this.labelRem.DataBindings.Add(new Binding("Text",this,"QuantityRemains"));

            this.labelSum.Text = this.SumRow.ToString();
        }

        private void QuantityEdit_Validating(object sender, CancelEventArgs e)
        {

            if (this.QuantityEdit.Text.Length == 0)
            {
                this.errorProvider1.SetError(this.QuantityEdit, "¬ведите кол-во!");
                e.Cancel = true;
            }

           if (Convert.ToDecimal(this.QuantityEdit.Text)> QuantityRemains)
            {
                this.errorProvider1.SetError(this.QuantityEdit, "ќстаток товара меньше!");
                e.Cancel = true;

            }

            if (_prodRow.MinDivisor!=1)
            {
                double ed = (1.000/_prodRow.MinDivisor);
                double proposed =Convert.ToDouble(this.QuantityEdit.Text);
                if (Convert.ToInt32((proposed/ed) * 1000) != Convert.ToInt32(proposed / ed) * 1000)
                {
                    this.errorProvider1.SetError(this.QuantityEdit, "Ќеверное значение после зап€той!");
                    e.Cancel = true;
                }
            
            }



            if (e.Cancel == false)

            { 
             this.QuantityEdit.ErrorText="";
             this.errorProvider1.Clear();
            }

            this.labelSum.Text = this.SumRow.ToString();

        }

        private void QuantityEdit_EditValueChanged(object sender, EventArgs e)
        {
            this.labelSum.Text = this.SumRow.ToString();
        }

        private void InvoiceDetailAdd_Validating(object sender, CancelEventArgs e)
        {
            if (this.errorProvider1.GetError(this.QuantityEdit).Length!=0)
                e.Cancel=true;
        }
        
    }
}
