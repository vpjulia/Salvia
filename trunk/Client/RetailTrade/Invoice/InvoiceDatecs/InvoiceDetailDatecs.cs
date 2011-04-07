using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RetailTradeClient.Printers;
using RetailTradeClient.Invoice.InvoiceTradePutlet;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;

namespace RetailTradeClient.Invoice.InvoiceDatecs
{
    public partial class InvoiceDetailDatecs : Form
    {
        private Datecs _printer;
        private MDataSet.CashDataTable _CashDataTable;

        public void Free()
        {
            Dispose(true);
        }
      
        private string causeError;
        private bool isError= false;

        private MDataSet.InvoiceMasterRow _invmasterRow;

        private decimal _Changes ;
        private decimal _cashCustomer ;


        private MainForm _mainForm;

        public InvoiceDetailDatecs()
        {
            InitializeComponent();
        }

        public InvoiceDetailDatecs(MainForm mainForm)
        {
            InitializeComponent();

            this.mDataSet = mainForm.mDataSet;
          
            _mainForm = mainForm;
            this.CashBindingSource.DataSource = _mainForm.cashBindingSource.Current  as MDataSet.CashRow;

            this.productBindingSource.DataSource = _mainForm.mDataSet.Product;
            this.productBindingSource.ResetBindings(false);

            this.remainsBindingSource.DataSource = new DataView(this.mDataSet.Remains, "QuantityRemains >0 ", null, DataViewRowState.CurrentRows);

            if (_mainForm.LocalSettingRow.PrDiscount != 0)
            {
                btPayDiscount.Visible = true;
            
            }

        }
        public InvoiceDetailDatecs(MainForm mainForm, MDataSet.InvoiceMasterRow sourcerow)
        {
            InitializeComponent();

            this.mDataSet = mainForm.mDataSet;

            _mainForm = mainForm;

            _invmasterRow = sourcerow;

            this.CashBindingSource.DataSource = _mainForm.cashBindingSource.Current as MDataSet.CashRow;

            this.remainsBindingSource.DataSource = new DataView(this.mDataSet.Remains, "QuantityRemains >0 ", null, DataViewRowState.CurrentRows);

            if (_mainForm.LocalSettingRow.PrDiscount != 0)
            {
                btPayDiscount.Visible = true;

            }

        }

        private void InvoiceDetailDatecs_Load(object sender, EventArgs e)
        {
             _printer = new Datecs();

            if (_printer.HasError)
            {
                MessageBox.Show(_printer.ErrorText);
                _printer.Close();

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

                    _printer.OpenCheck(_mainForm.LocalSettingRow.Num);

                }
                else
                //если открыть
                {
                    this.invoiceMasterBindingSourceView.Position = this.invoiceMasterBindingSourceView.Find("Id", _invmasterRow.ID);
                    this.gridRem.Enabled = false;
                    
                    this.btPay.Visible = false;
                    
                    this.btPayDiscount.Visible = false;

                    this.btDeleteInСheck.Visible = false;

                    this.btPrintCheck.Visible = true;
                    
                    this.btDelete.Visible = true;

                    this.btPayMenu.Enabled = false;

                }

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

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int focused = this.gridViewInvRem.FocusedRowHandle;

                MDataSet.RemainsRow _rem = this.gridViewInvRem.GetDataRow(this.gridViewInvRem.FocusedRowHandle) as MDataSet.RemainsRow;
              
                _mainForm.RefreshData(_rem);

                if (_rem != null)
                {
                    MDataSet.InvoiceDetailRow _newRow = (this.invoiceDetailBindingSource.AddNew() as DataRowView).Row as MDataSet.InvoiceDetailRow;

                    InvoiceDetailAdd _invoceDetailAdd = new InvoiceDetailAdd(_newRow, _rem, _mainForm);

                    FormDialog formDialog = new FormDialog();
                    formDialog.Text = "Добавить строку";
                    formDialog.panel.Controls.Add(_invoceDetailAdd);

                    if (DialogResult.OK == formDialog.ShowDialog(this))
                    {
                      
                        this.invoiceDetailBindingSource.EndEdit();

                        this.SaleInvoiceDetail(_newRow);

                        _mainForm.RefreshData(_newRow);



                    }
                    else
                    {
                        this.gridViewInvRem.BeginDataUpdate();
                        this.invoiceDetailBindingSource.CancelEdit();
                        _rem.RejectChanges();
                        this.gridViewInvRem.EndDataUpdate();
                       
                        this.gridRem.Focus();
                        this.gridViewInvRem.FocusedRowHandle = focused;
                        return;


                    }
                    
                    _invoceDetailAdd.Dispose();

                    GC.Collect();

                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                 MainForm.Log("gridControl1_DoubleClick " + err.Message);
            }

        }

        private bool SaleInvoiceDetail(MDataSet.InvoiceDetailRow row)
        {
          try{

                string name = row.RemainsRow.ProductRow.SmallName;

                if (name.Length == 0)
                    throw new ArgumentNullException("SmallName");
                  bool isnds = row.RemainsRow.ProductRow.IsNDS;

                row.Article = _printer.SaleArticle(isnds,(double)row.Quantity,(double)row.PriceRetailNDS,name);

                if (row.Article > 0)

                    this._mainForm.SaveToBase(_invmasterRow);


                else
                {

                    MessageBox.Show("Ошибка печати строки!!!");
                    MainForm.Log("SaleInvoiceDetail" + _printer.ErrorText);

                    this.mDataSet.InvoiceDetail.RejectChanges();
                    this.isError = true;
               
                    this.Close();
                    return false;
                }

            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка!!");
               
                MainForm.Log(err.Message);
                this.isError = true; 
                this.Close();
                return false;


            }
         

            return true;  
  
        }


        private bool CloseCeck(decimal CashCustomer,decimal discount)
        {


            _mainForm.RefreshData(_invmasterRow);

            decimal controlsum = _invmasterRow.Sum;
           
            if ((_printer.HasError)||(isError)||_invmasterRow.HasErrors)
            {
                MessageBox.Show("Ошибка принетра!!!" + _printer.ErrorText);
                return false;

            }

            if (controlsum==0)
            {
                MessageBox.Show("Cумма в базе нулевая!!!");
                return false;

            }

            int res = _printer.CloseCheck((double)CashCustomer,(double)discount,controlsum);

            if (res <0)
            {
                MessageBox.Show("Ошибка закрытия чека!" + _printer.ErrorText);
                return false;
            }
            else
            {

                _invmasterRow.NumCheck = res;
                _invmasterRow.Discount = 0 - discount;           

              if ((this._mainForm.CloseCheck(_invmasterRow)))
                {
                   return true;
                }
                else
                {
                    return false; 
                 }
            }

        }
        private void btPay_Click(object sender, EventArgs e)
        {
            /*if (_invmasterRow.RowState == DataRowState.Unchanged)

                _invmasterRow.SetModified();
            */
           if (!( _mainForm.RefreshData(_invmasterRow)))
            
           {
               MessageBox.Show("Ошибка сохранения данных!");
               return;
           }
           if ( this.isError)
           {
               MessageBox.Show("Ошибка  данных!");
               return;
           }

            if (_invmasterRow.Sum == 0)
            {
                MessageBox.Show("Нулевая сумма чека !!!","Ошибка оплаты",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                return;
            }



            Payment _frmPay = new Payment(_invmasterRow);
            if (DialogResult.OK == _frmPay.ShowDialog(this))
            {
                _Changes = _frmPay.Change;
                _cashCustomer = _frmPay.CashCustomer;

                decimal baseSum = _invmasterRow.Sum;
                if (this.CloseCeck(Convert.ToDecimal(_frmPay.CashCustomer.ToString()),0))
                {
                    this.DialogResult = DialogResult.OK;
                }

            }
        }

        
        private void btPayDiscount_Click(object sender, EventArgs e)
        {

            _mainForm.RefreshData(_invmasterRow);

            if (!_mainForm.SaveToBase(_invmasterRow))
            {
                return;
            }

            
            decimal disc;

            decimal pr = _mainForm.LocalSettingRow.PrDiscount;

            disc = Decimal.Round(_invmasterRow.Sum*(pr/100),2);
            //посчитать скидку

            if (disc == 0)
            {
                MessageBox.Show("Оплата со скидкой не возможна!");
                return;
            
            }


            _invmasterRow.Sum -= disc;
            

          
            Payment _frmPay = new Payment(_invmasterRow);
            if (DialogResult.OK == _frmPay.ShowDialog(this))
            {
                _Changes = _frmPay.Change;
                _cashCustomer = _frmPay.CashCustomer;

                _invmasterRow.Discount = disc;


               
                if (this.CloseCeck(Convert.ToDecimal(_frmPay.CashCustomer.ToString()), 0 - disc))
                {

                    this._mainForm.SaveToBase(_invmasterRow);

                    this.DialogResult = DialogResult.OK;
                }



            }
            else
            {
                _invmasterRow.RejectChanges();
            }
       
        }

        private void btDeleteInСheck_Click(object sender, EventArgs e)
        {
            MDataSet.InvoiceDetailRow _detRow = this.gridViewInvDet.GetDataRow(this.gridViewInvDet.FocusedRowHandle) as MDataSet.InvoiceDetailRow;

            if (_detRow != null)
            {

                if (DialogResult.OK == MessageBox.Show(this, "Удалить " + _detRow.Quantity.ToString(), "Удаление строки ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {
                    this.gridViewInvRem.BeginDataUpdate();
                    this.ReturnInvoiceDetail(_detRow);
                    
                   this.gridViewInvRem.EndDataUpdate();
                }

            }
         

        }

        private bool ReturnInvoiceDetail(MDataSet.InvoiceDetailRow row)
        {


            try
            {
                string name = row.RemainsRow.ProductRow.SmallName;

                bool isnds = row.RemainsRow.ProductRow.IsNDS;

                int Article = row.Article;

                bool res  = _printer.ReturnArticle(Article, isnds, (double)row.Quantity, (double)row.PriceRetailNDS, name);

                if (res)
                {
                    MDataSet.RemainsRow rem = row.RemainsRow; 


                    this.invoiceDetailBindingSource.RemoveCurrent();

                    this._mainForm.SaveToBase(_invmasterRow);
                    this._mainForm.RefreshData(rem);
                }
                else

                    MessageBox.Show("Невозможно удалить строку!");
            }
            catch
            {
                MessageBox.Show("Ошибка!!");
                return false;


            }


            return true;



        }

       private void btResetErr_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btRecetReturn_Click(object sender, EventArgs e)
        {
            this.causeError = "Возврат : ... ";

            this._mainForm.MakeToReturn(_invmasterRow);
           
            this.Close();
        }
  
        private void InvoiceDetailDatecs_FormClosing(object sender, FormClosingEventArgs e)
        {



            _mainForm.RefreshData(_invmasterRow);

             //проверить если выход по ошибке


            if ((_invmasterRow.NumCheck==0)&(_invmasterRow.GetInvoiceDetailRows().Length > 0))
            {
              
                
                    FormDialog _fdlg = new FormDialog();
                    TextBox _tb = new TextBox();
                    _fdlg.Text = "Аннуляция чека: ";


                    if (this.causeError ==null)

                        _tb.Text = "Ошибочный чек ...";
                    else

                        _tb.Text = this.causeError;


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

                        _printer.CancelCheck("ОТМЕНА:" + _tb.Text);
                    }
                    else
                        e.Cancel = true;
                  }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {

                MDataSet.InvoiceDetailRow _detRow = this.gridViewInvDet.GetDataRow(this.gridViewInvDet.FocusedRowHandle) as MDataSet.InvoiceDetailRow;

                if (_detRow != null)
                {

                    MDataSet.RemainsRow rem = _detRow.RemainsRow;

                    this._mainForm.SaveToBase(_invmasterRow);

                    this.invoiceDetailBindingSource.RemoveCurrent();

                    _mainForm.invoiceDetailTableAdapter.Update(_detRow);

                    _mainForm.RefreshData(_invmasterRow);
                    
                    this._mainForm.RefreshData(rem);
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                MainForm.Log("btDelete_Click " + err.Message);
                           
            }
        }

        private void btPrintCheck_Click(object sender, EventArgs e)
        {
            if (_printer.HasError) 
            {    MessageBox.Show("Ошибка принтера" + _printer.ErrorText);
                return;
             }

             if (_invmasterRow.GetInvoiceDetailRows().Length == 0)
             {
                 MessageBox.Show("Нечего печатать");
                 return;
             }



            _printer.OpenCheck(_mainForm.LocalSettingRow.Num);

            this.gridRem.Enabled = false;

            this.gridRem.Enabled = false;

            this.btDelete.Enabled = false;

            foreach (MDataSet.InvoiceDetailRow detrow in _invmasterRow.GetInvoiceDetailRows())
            {
                this.SaleInvoiceDetail(detrow);



            }

            if (_printer.HasError) return;

            this.btPay_Click(sender, e);

        }

        private void InvoiceDetailDatecs_FormClosed(object sender, FormClosedEventArgs e)
        {  
            _printer.Close();

            foreach (GridView view in this.gridDet.ViewCollection)
            {
                string fileName = new FileInfo(Application.ExecutablePath).DirectoryName + "\\" + view.Name.ToString() + ".xml";
                view.SaveLayoutToXml(fileName);
            }
            foreach (GridView view in this.gridRem.ViewCollection)
            {
                string fileName = new FileInfo(Application.ExecutablePath).DirectoryName + "\\" + view.Name.ToString() + ".xml";
                view.SaveLayoutToXml(fileName);
            }
           
        }

        private void gridViewInvRem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.gridControl1_DoubleClick(sender, e as EventArgs);
            
            }
        }

        private void gridViewInvRem_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            try
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
            catch (Exception err)

            {
                MessageBox.Show(err.Message);
            }


        }


    }
}