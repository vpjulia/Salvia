using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using RetailTradeClient.Printers;
using System.Threading;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;

namespace RetailTradeClient.Invoice.InvoiceTradePutlet
{
    public partial class InvoiceTradePutletAll : UserControl
    {
        private DataView _changesMaster;
    
        private DataView _changesDetail;

        MainForm _mainForm;

        public Maria301Printer _printer;

        private bool InitDataCash()
        {
            if (_printer.HasError)
            {

                MessageBox.Show("Ошибка подключения принтера:" + _printer.ErrorText);

                return false;
            }

            _printer.Info.RefreshData();
            
            if (_printer.HasError)
            {

                MessageBox.Show("Ошибка подключения принтера:" + _printer.ErrorText);
             
                return false;
            }
            
            MDataSet.CashRow _cashRow;
            DataRow[] _drSelect;
 
            if (!_printer.Info.ifJustZ)
            {
                _drSelect = this.mDataSet.Cash.Select("NumZ=" + _printer.Info.NumZ.ToString());
            }
            else
            { 
                int numZ = _printer.Info.NumZ+1;

                _drSelect = this.mDataSet.Cash.Select("NumZ=" + numZ.ToString());
            
            }

            if (_drSelect.Length == 0)
            {
   
                MessageBox.Show("Ошибка инициализации принтера !" );
             
                return false;
         

            }

          
            _cashRow = _drSelect[0] as MDataSet.CashRow;
            _cashRow.Date = _printer.Info.CurrentDate;
            _cashRow.BalanceBegin = _printer.Info.BalanceBegin;
            _cashRow.OfIncome = 0;
            _cashRow.OfExpend = _printer.Info.OfExpend;
            _cashRow.Income = _printer.Info.Income;
            _cashRow.Expend = 0;
                _cashRow.BalanceEnd = _printer.Info.BalanceEnd;

                DataRow[] _modif = new DataRow[1];
                _modif[0] = _cashRow;

                if (!(this.ParentForm as MainForm).SaveToBaseDirectoryModifed(_modif))
                {
                    MainForm.Log("Не обновлена строка Z Отчета");
                    
                    return false;
                }

            _mainForm.cashBindingSource.Position = _mainForm.cashBindingSource.Find("ID", _cashRow.ID);
           
            this.cashBindingSource.DataSource = _mainForm.cashBindingSource.Current;
           
            this.cashBindingSource.ResetBindings(true);
            
          

           

            return true;

        }

        public InvoiceTradePutletAll()
        {
            InitializeComponent();
        }

        public InvoiceTradePutletAll(MDataSet source)
        {
            InitializeComponent();

            
            this.mDataSet = source;
            this.invoiceMasterBindingSource.DataSource = new DataView(this.mDataSet.InvoiceMaster," PeriodsRef=0 ", null, DataViewRowState.CurrentRows);
            this.invoiceMasterBindingSource.ResetBindings(false);
           _changesMaster = new DataView(this.mDataSet.InvoiceMaster,null , null, DataViewRowState.Added | DataViewRowState.Deleted | DataViewRowState.ModifiedCurrent);
           _changesDetail = new DataView(this.mDataSet.InvoiceDetail,null, null, DataViewRowState.Added | DataViewRowState.Deleted | DataViewRowState.ModifiedCurrent);
        }

        private void InvoiceTradePutletAll_Load(object sender, EventArgs e)
        {
            foreach (GridView view in this.grid.ViewCollection)
            {
                string fileName = new FileInfo(Application.ExecutablePath).DirectoryName + "\\" + view.Name.ToString() + ".xml";
                if (File.Exists(fileName))
                    view.RestoreLayoutFromXml(fileName);
            }

            _mainForm = (this.ParentForm as MainForm);
            this._mainForm.MariaMenu.Enabled = false;
            (this.ParentForm as MainForm).FillTableNewDocuments(this.mDataSet.InvoiceMaster);

         
           this.cashBindingSource.DataSource = (this.ParentForm as MainForm).mDataSet.Cash;

           this._printer = new Maria301Printer(this._mainForm.LocalSettingRow.Num);

           if (_printer.HasError)
           {
               MessageBox.Show("Не удалось подключится к принтеру ");
               return;
           }

              InitDataCash();


            
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                this.invoiceMasterBindingSource.EndEdit();
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message);


                MainForm.Log("btAdd_Click" +err.Message);
            
          
            }
             if (this.ValidateChildren())
            {

                if (!InitDataCash())
                    return;

                try
                {


                    InvoicePrintMar _invoiceDetail = new InvoicePrintMar(this.ParentForm as MainForm, _printer);

              if (DialogResult.OK == _invoiceDetail.ShowDialog(this))
              {
                
                  InitDataCash();
                  
                  

                  this.labelCashCustomer.Text = _invoiceDetail.CashCustomer.ToString();
                  this.LableChanges.Text = _invoiceDetail.Changes.ToString();
                  this.LabelLastSum.Text = _invoiceDetail.LastSum.ToString();
              }
              else
              {
                  this.mDataSet.InvoiceMaster.RejectChanges();
                  

                  _printer.AbortCheck();
              }
              _invoiceDetail.Dispose();

              GC.Collect();
          }
          catch (Exception err)
          {
              MessageBox.Show(err.Message);

              MainForm.Log(err.Message);


          }

          }

        }

        private void btOpen_Click(object sender, EventArgs e)
        {
        
            MDataSet.InvoiceMasterRow _row = this.gridViewInvAll.GetDataRow(this.gridViewInvAll.FocusedRowHandle) as MDataSet.InvoiceMasterRow;

            if (_row!=null)
            {

                if (_row.DocumentTypeRef == 0)
                {
                    InvoicePrintMar _invoiceDetail = new InvoicePrintMar(this.ParentForm as MainForm, _row,_printer);



                    if (DialogResult.OK == _invoiceDetail.ShowDialog(this))
                    {
                        this.labelCashCustomer.Text = _invoiceDetail.CashCustomer.ToString();
                        this.LableChanges.Text = _invoiceDetail.Changes.ToString();
                        this.LabelLastSum.Text = _invoiceDetail.LastSum.ToString();
                    }

                    _invoiceDetail.Dispose();

                    GC.Collect();

                }
            }


        }

        private void btClose_Click(object sender, EventArgs e)
        {

            _printer.Done();
            foreach (GridView view in this.grid.ViewCollection)
            {
                string fileName = new FileInfo(Application.ExecutablePath).DirectoryName + "\\" + view.Name.ToString() + ".xml";
                view.SaveLayoutToXml(fileName);
            }

            this._mainForm.MariaMenu.Enabled = true;
            this._mainForm.DeleteDataTab(this.Parent as TabPage);
         
        }

        private void gridViewInvAll_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {

            DevExpress.XtraGrid.Views.Grid.GridView   CurrentView = (sender as DevExpress.XtraGrid.Views.Grid.GridView);

            MDataSet.InvoiceMasterRow _row = CurrentView.GetDataRow(e.RowHandle) as MDataSet.InvoiceMasterRow;

            if (_row.NumCheck > 0)
            {
                 e.Appearance.Font=e.Cache.GetFont(e.Appearance.Font, FontStyle.Italic );
             
                if (e.RowHandle == CurrentView.FocusedRowHandle) return;
                
                 e.Appearance.ForeColor = Color.Gray;

            }

            if (_row.DocumentTypeRef == 4)
            {

                e.Appearance.Font = e.Cache.GetFont(e.Appearance.Font, FontStyle.Bold);

                if (e.RowHandle == CurrentView.FocusedRowHandle) return;

               // e.Appearance.ForeColor = Color.Gray;

                e.Appearance.BackColor = Color.LightPink;
           }

        }

        private void gridViewInvDetAll_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView CurrentView = (sender as DevExpress.XtraGrid.Views.Grid.GridView);

            MDataSet.InvoiceMasterRow _row = (CurrentView.GetDataRow(e.RowHandle) as MDataSet.InvoiceDetailRow).InvoiceMasterRow;

            if (_row.NumCheck > 0)
            {
                e.Appearance.Font = e.Cache.GetFont(e.Appearance.Font, FontStyle.Italic);

             //   if (e.RowHandle == CurrentView.FocusedRowHandle) return;

                e.Appearance.ForeColor = Color.Gray;

            }

            if (_row.DocumentTypeRef == 4)
            {

                e.Appearance.Font = e.Cache.GetFont(e.Appearance.Font, FontStyle.Italic);

              //  if (e.RowHandle == CurrentView.FocusedRowHandle) return;

                 e.Appearance.ForeColor = Color.Gray;

               // e.Appearance.BackColor = Color.LightPink;
            }
        }

        private void btClosePanel_Click(object sender, EventArgs e)
        {
            this.tableLayoutPanel1.Visible = false;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                MDataSet.InvoiceMasterRow master = this.gridViewInvAll.GetDataRow(this.gridViewInvAll.FocusedRowHandle) as MDataSet.InvoiceMasterRow;
                if (master == null)
                    return;

                if (master.GetInvoiceDetailRows().Length > 0)
                {
                    MessageBox.Show("Невозможно удалить документ!");

                    return;
                }



                this.invoiceMasterBindingSource.RemoveCurrent();
                this.invoiceMasterBindingSource.EndEdit();
                this._mainForm.SaveToBase(master);

            }
            catch (Exception err)

            {
                MainForm.Log(" btDelete_Click" + err.Message);

                MessageBox.Show(err.Message);


            }
        }

        private void btProductReport_Click(object sender, EventArgs e)
        {
            MDataSet.InvoiceDetailRow detRow = this.gridViewInvDetAll.GetDataRow(this.gridViewInvDetAll.FocusedRowHandle) as MDataSet.InvoiceDetailRow;
            if (detRow == null) return;

            (this.ParentForm as MainForm).ProductReport(detRow.ProductRef);

        }
   
    
    }
}
