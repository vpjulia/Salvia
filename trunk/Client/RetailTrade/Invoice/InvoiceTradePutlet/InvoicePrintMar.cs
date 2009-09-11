using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RetailTradeClient.Printers;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;

namespace RetailTradeClient.Invoice.InvoiceTradePutlet
{
    public partial class InvoicePrintMar : Form
    {
       public Maria301Printer _printer;
      

        private MainForm _mainForm;

        private MDataSet.InvoiceMasterRow _invmasterRow;
        public void Free()
        {
            Dispose(true);
        }

        private decimal _LastSum;

        public decimal LastSum
        {
            get { return _invmasterRow.Sum; }
           
        }

        private decimal _cashCustomer;

        public decimal CashCustomer
        {
            get { return _cashCustomer; }
           
        }

        private decimal _Changes;

        public decimal Changes
        {
            get { return _Changes; }
            set { _Changes = value; }
        }


        public InvoicePrintMar()
        {
            InitializeComponent();
            _printer = new Maria301Printer(1);
        }

        public InvoicePrintMar(MainForm mainForm, Maria301Printer printer)
      {
            InitializeComponent();

            this.mDataSet =mainForm.mDataSet;
         
            _mainForm = mainForm;

            _printer = printer;

           this.remainsBindingSource.DataSource = new DataView(this.mDataSet.Remains, "QuantityRemains >0 " , null, DataViewRowState.CurrentRows);
    
          

    }

        public InvoicePrintMar(MainForm mainForm, MDataSet.InvoiceMasterRow source, Maria301Printer printer)
        {
            InitializeComponent();

            this.mDataSet = mainForm.mDataSet;
          
            _mainForm = mainForm;

            _printer = printer;

            this.remainsBindingSource.DataSource = new DataView(this.mDataSet.Remains, "QuantityRemains >0 ", null, DataViewRowState.CurrentRows);

            _invmasterRow = source;
        }
      
        private void InvoicePrintMar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mDataSet.Product' table. You can move, or remove it, as needed.
         //   this.productTableAdapter.Fill(this.mDataSet.Product);
            _printer.Info.RefreshData();



            if (_printer.HasError)
            {
                MessageBox.Show(_printer.ErrorText);
               
                this.DialogResult = DialogResult.Abort;
            
                return;

            }
            else
            {
              


                this.invoiceMasterBindingSourceView.DataSource = mDataSet.InvoiceMaster;

                this.invoiceMasterBindingSourceView.ResetBindings(true);


                // если новый документ
                if (_invmasterRow == null)
                {
                    _invmasterRow = (invoiceMasterBindingSourceView.AddNew() as DataRowView).Row as MDataSet.InvoiceMasterRow;


                    this.invoiceMasterBindingSourceView.EndEdit();

                    this.btDelete.Visible = false;
                    _printer.OpenCheck(_mainForm.LocalSettingRow.MainTradePutletRef.ToString());

                }
                else
                //если открыть
                {
                    this.invoiceMasterBindingSourceView.Position = this.invoiceMasterBindingSourceView.Find("Id", _invmasterRow.ID);
                    this.gridRem.Enabled = false;
                    this.btPay.Visible = false;
                    this.btPrintCheck.Visible = true;
                    this.btDelete.Visible = true;
                    this.btPayMenu.Enabled = false;
                }

                this._mainForm.SaveToBase(_invmasterRow);

                this.invoiceMasterBindingSource.DataSource = _invmasterRow;

                this.invoiceMasterBindingSource.ResetBindings(true);

                this.invoiceDetailBindingSource.DataSource = this.invoiceMasterBindingSourceView;
                this.invoiceDetailBindingSource.DataMember = "FK_InvoiceDetail_InvoiceMaster";

                this.invoiceDetailBindingSource.ResetBindings(true);
              
                
                foreach (GridView view in this.gridRem.ViewCollection)
                {
                    string fileName = new FileInfo(Application.ExecutablePath).DirectoryName + "\\" + view.Name.ToString() + ".xml";
                    if (File.Exists(fileName))
                        view.RestoreLayoutFromXml(fileName);
                }

                foreach (GridView view in this.gridDet.ViewCollection)
                {
                    string fileName = new FileInfo(Application.ExecutablePath).DirectoryName + "\\" + view.Name.ToString() + ".xml";
                    if (File.Exists(fileName))
                        view.RestoreLayoutFromXml(fileName);
                }

            }
        }

        private bool SaleInvoiceDetail(MDataSet.InvoiceDetailRow row)
        {
            Decimal res; 

            try
            {
                string name = row.RemainsRow.ProductRow.SmallName;

                bool isnds = row.RemainsRow.ProductRow.IsNDS;

            res = _printer.FiscalLine(name, row.Quantity, row.PriceRetailNDS, isnds);

            if (res != 0)
                 this._mainForm.SaveToBase(_invmasterRow);
             this.invoiceDetailBindingSource.ResetBindings(true);

            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка!!");
                MainForm.Log("SaleInvoiceDetail" + err.Message + " " + _printer.ErrorText);
                this.Close();
                return false;


            }
              

            return true;
        }
        





















































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































        private bool CloseCeck(decimal CashCustomer)
        {
          

            _printer.Info.RefreshData();

            if (_printer.HasError)

            {
                MessageBox.Show("Ошибка принетра!!!" + _printer.Info.ErrorText);
                return false;
                            
            }


            decimal res = _printer.CloseCheckEx(CashCustomer);

            if (res == 0)
            {
                MessageBox.Show("Ошибка закрытия чека!" + _printer.ErrorText);
                return false;
            }
            else
            {

                _invmasterRow.NumCheck = _printer.Info.LastCheck;
    
              if (this._mainForm.CloseCheck(_invmasterRow))
              {
                  return true;
              }
              else
              { return false;}
           }

        }


        private void gridViewInvRem_DoubleClick(object sender, EventArgs e)
        {
            MDataSet.RemainsRow _rem = this.gridViewInvRem.GetDataRow(this.gridViewInvRem.FocusedRowHandle) as MDataSet.RemainsRow;

            if (_rem != null)
            {
                MDataSet.InvoiceDetailRow _newRow = (this.invoiceDetailBindingSource.AddNew() as DataRowView).Row as MDataSet.InvoiceDetailRow;

                InvoiceDetailAdd _invoceDetailAdd = new InvoiceDetailAdd(_newRow, _rem,_mainForm);

                FormDialog formDialog = new FormDialog();
                formDialog.Text = "Добавить строку";
                formDialog.AcceptButton = null;

                formDialog.panel.Controls.Add(_invoceDetailAdd);

                if (DialogResult.OK == formDialog.ShowDialog(this))
                {
                    this.invoiceDetailBindingSource.EndEdit();

                    this.SaleInvoiceDetail(_newRow);
                }
                else
                {
                    this.invoiceDetailBindingSource.CancelEdit();
                    this.mDataSet.ReceiptRemains.RejectChanges();
                }


            }
        }
  
       
        private void InvoicePrintMar_FormClosing(object sender, FormClosingEventArgs e)
        {
            _mainForm.RefreshData(_invmasterRow);
            
            foreach (GridView view in this.gridRem.ViewCollection)
            {
                string fileName = new FileInfo(Application.ExecutablePath).DirectoryName + "\\" + view.Name.ToString() + ".xml";
                view.SaveLayoutToXml(fileName);
            } 
            foreach (GridView view in this.gridDet.ViewCollection)
            {
                string fileName = new FileInfo(Application.ExecutablePath).DirectoryName + "\\" + view.Name.ToString() + ".xml";
                view.SaveLayoutToXml(fileName);
            }


        }

        private void btPay_Click(object sender, EventArgs e)
        {
            _mainForm.RefreshData(_invmasterRow);

            Payment _frmPay = new Payment(_invmasterRow);
            if (DialogResult.OK == _frmPay.ShowDialog(this))
            {
                _Changes = _frmPay.Change;
                _cashCustomer = _frmPay.CashCustomer;
                
            if ( this.CloseCeck(Convert.ToDecimal(_frmPay.CashCustomer.ToString())))

            {
                this.DialogResult = DialogResult.OK;
            }

           }


        }

        private void btPrintCheck_Click(object sender, EventArgs e)
        {
            _mainForm.RefreshData(_invmasterRow);

            if (_printer.HasError)
            {
                MessageBox.Show("Ошибка принтера:" + _printer.ErrorText);
                return;
            }

            if (_invmasterRow.GetInvoiceDetailRows().Length != 0)
            {
                if (!_printer.OpenCheck("1"))
                {
                    MessageBox.Show("Ошибка открытия чека:" + _printer.ErrorText);
                    return;
                }


                foreach (MDataSet.InvoiceDetailRow _detRow in _invmasterRow.GetInvoiceDetailRows())
                {
                    this.SaleInvoiceDetail(_detRow);
                               
                }

                if (_printer.HasError)
                {
                    MessageBox.Show("Ошибка принтера:" + _printer.ErrorText);
                    return;
                }

                if (this.CloseCeck(_invmasterRow.Sum+1))
                {
                    this.DialogResult = DialogResult.OK;
                }

            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            MDataSet.InvoiceDetailRow _detRow = this.gridViewInvDet.GetDataRow(this.gridViewInvDet.FocusedRowHandle) as MDataSet.InvoiceDetailRow;

            if (_detRow != null)
            { 

            
                if (DialogResult.OK== MessageBox.Show(this,"Удалить "+ _detRow.Quantity.ToString(),"Удаление строки ",MessageBoxButtons.OKCancel,MessageBoxIcon.Question))
                {
                    MDataSet.RemainsRow rem = _detRow.RemainsRow;

                    this._mainForm.SaveToBase(_invmasterRow);

                    this.invoiceDetailBindingSource.RemoveCurrent();

                    _mainForm.invoiceDetailTableAdapter.Update(_detRow);

                    _mainForm.RefreshData(_invmasterRow);

                    this._mainForm.RefreshData(rem);
                 
                }

            }



        }

        private void btReturnDoc_Click(object sender, EventArgs e)
        {

            _mainForm.RefreshData(_invmasterRow);

           if (_invmasterRow.GetInvoiceDetailRows().Length==0)
               return;


            
            FormDialog _fdlg = new FormDialog();
            TextBox _tb = new TextBox();
                    _fdlg.Text = "Закрытие чека: ";
    

                        _tb.Text = "Возврат : ...";
                    

                    _tb.Width = _fdlg.panel.Width;
                    // _tb.Dock = DockStyle.Fill;
                    _tb.SelectAll();

                    _fdlg.panel.Controls.Add(_tb);

                    if (DialogResult.OK == _fdlg.ShowDialog(this))
                    {

                        _invmasterRow.Note = _tb.Text;

                        if (!_mainForm.SaveToBase(_invmasterRow))
                        {
                            MessageBox.Show("Ошибка обновления!");
                            return;

                        } 
                        this._mainForm.MakeToReturn(_invmasterRow);

                        _invmasterRow.SetModified();

                        if (!_mainForm.SaveToBase(_invmasterRow))
                        {
                            MessageBox.Show("Ошибка обновления!");
                            return;

                        } 
                        

                        this.Close();
                    }
        }

        private void gridViewInvRem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                MDataSet.RemainsRow rem = this.gridViewInvRem.GetDataRow(this.gridViewInvRem.FocusedRowHandle) as MDataSet.RemainsRow;
                if (rem != null)
                {

                    this.gridViewInvRem_DoubleClick(sender, e);
                }
            
            }
        }

        private void gridViewInvRem_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            MDataSet.RemainsRow det = this.gridViewInvRem.GetDataRow(e.RowHandle) as MDataSet.RemainsRow;
            if (det == null) return;

            if (det.UseByDate.AddMonths(-6) < DateTime.Today)
            {
                e.Appearance.ForeColor = Color.Pink;
            }
            if (det.UseByDate.AddMonths(-2) < DateTime.Today)
            {
                e.Appearance.ForeColor = Color.Red;
            }
        }
        
    }
}