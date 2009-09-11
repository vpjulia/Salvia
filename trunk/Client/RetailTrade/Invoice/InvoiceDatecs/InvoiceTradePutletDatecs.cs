using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using RetailTradeClient.Printers;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;

namespace RetailTradeClient.Invoice.InvoiceDatecs
{
    public partial class InvoiceTradePutletDatecs : UserControl
    {
        private DataView _changesMaster;

        private DataView _changesDetail;

        private MainForm _mainForm;

        private MDataSet.CashRow _cashRow;


        private bool InitDataCash()
        {
            Datecs _printer = new Datecs();

            if (_printer.HasError)
            {
                MessageBox.Show("Ошибка принтера :" + _printer.ErrorText);
                _printer.Close();
                return false;
            }
           

          DataRow[] _dr = this.mDataSet.Cash.Select("NumZ= -1");

            if (_dr.Length == 0)
            {
                MessageBox.Show("Не найдена строка для Z отчета");
                MainForm.Log("Не найдена строка для Z отчета");
                _printer.Close();
                return false;
            
            }
             
            else
                _cashRow = _dr[0] as MDataSet.CashRow;

                 _cashRow.Date = DateTime.Today;
                _cashRow.BalanceBegin = _printer.printerCashInfo.BalanceBegin;
                _cashRow.OfIncome = 0;
                _cashRow.OfExpend = _printer.printerCashInfo.OfExpend;
                _cashRow.Income = _printer.printerCashInfo.Income;
                _cashRow.Expend = 0;
                _cashRow.BalanceEnd = _printer.printerCashInfo.BalanceEnd;

                           
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
            


          /*  this.cashBindingSource.DataSource = _cashRow;
            this.cashBindingSource.ResetBindings(true);
            */

            _printer.Close();
            return true;
        }


        public InvoiceTradePutletDatecs()
        {
            InitializeComponent();
        }

        public InvoiceTradePutletDatecs(MDataSet source)
        {
            InitializeComponent();
            this.mDataSet = source;

            this.mDataSet = source;
            this.invoiceMasterBindingSource.DataSource = new DataView(this.mDataSet.InvoiceMaster, " PeriodsRef=0 ", null, DataViewRowState.CurrentRows);
            this.invoiceMasterBindingSource.ResetBindings(false);
            //this.productBindingSource.DataSource = this.mDataSet.Product;
            _changesMaster = new DataView(this.mDataSet.InvoiceMaster, "DocumentTypeRef=0", null, DataViewRowState.Added | DataViewRowState.Deleted | DataViewRowState.ModifiedCurrent);
            _changesDetail = new DataView(this.mDataSet.InvoiceDetail, "DocumentTypeRef=0", null, DataViewRowState.Added | DataViewRowState.Deleted | DataViewRowState.ModifiedCurrent);
      

        }

        private void InvoiceTradePutletDatecs_Load(object sender, EventArgs e)
        {
            _mainForm = (this.ParentForm as MainForm);

            _mainForm.FillTableNewDocuments(this.mDataSet.InvoiceMaster);


            InitDataCash();

            foreach (GridView view in this.gridControlDatInMast.ViewCollection)
            {
                string fileName = new FileInfo(Application.ExecutablePath).DirectoryName + "\\" + view.Name.ToString() + ".xml";
                if (File.Exists(fileName))
                    view.RestoreLayoutFromXml(fileName);
            } 
            
        }

        private void btAdd_Click(object sender, EventArgs e)
        {

            if (!InitDataCash())
            {

                MessageBox.Show("Ошибка принтера :InitDataCash false");
                return;
            }
         
            InvoiceDetailDatecs _InvoiceDetailDatecs = new InvoiceDetailDatecs(this.ParentForm as MainForm);
           _InvoiceDetailDatecs.Text = "Новый расходный документ";



            if (DialogResult.OK == _InvoiceDetailDatecs.ShowDialog(this))
            {
                if (!InitDataCash())
                {

                    MessageBox.Show("Ошибка принтера :InitDataCash false");
                    return;
                }
            }
            else
            {
                this.mDataSet.InvoiceMaster.RejectChanges();
                this.mDataSet.ReceiptRemains.RejectChanges();

            }

            _InvoiceDetailDatecs.Dispose();
            _InvoiceDetailDatecs = null; 
            GC.Collect();
        }

       
        private void btOpen_Click(object sender, EventArgs e)
        {
          
            
           /* if (_)
            {

                MessageBox.Show("Ошибка принтера :InitDataCash false");
                return;
            }*/

            MDataSet.InvoiceMasterRow _master = this.gridViewInvDatAll.GetDataRow(this.gridViewInvDatAll.FocusedRowHandle) as MDataSet.InvoiceMasterRow;


            if (_master == null) return;

            if (_master.DocumentTypeRef != 0)
            {
                MessageBox.Show("Документ закрыт!");
                return;
           
            }

            InvoiceDetailDatecs _InvoiceDetailDatecs = new InvoiceDetailDatecs(this.ParentForm as MainForm, _master);
           
            _InvoiceDetailDatecs.Text = "Открыть расходный документ";



            if (DialogResult.OK == _InvoiceDetailDatecs.ShowDialog(this))
            {
                if (!InitDataCash())
                {

                    MessageBox.Show("Ошибка принтера :InitDataCash false");
                    return;
                }
            }
            else
            {
                this.mDataSet.InvoiceMaster.RejectChanges();
            }
            _InvoiceDetailDatecs.Free();
            _InvoiceDetailDatecs = null;
            GC.Collect();

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            foreach (GridView view in this.gridControlDatInMast.ViewCollection)
            {
                string fileName = new FileInfo(Application.ExecutablePath).DirectoryName + "\\" + view.Name.ToString() + ".xml";
                view.SaveLayoutToXml(fileName);
            } 
            _mainForm.DeleteDataTab(this.Parent as TabPage);
       }

        private void btDelete_Click(object sender, EventArgs e)
        {

            try
            {
                //удалить пустую строку
                MDataSet.InvoiceMasterRow mast = this.gridViewInvDatAll.GetDataRow(this.gridViewInvDatAll.FocusedRowHandle) as MDataSet.InvoiceMasterRow;

                if (mast == null) return;

                if (mast.GetInvoiceDetailRows().Length == 0)
                {

                    this.invoiceMasterBindingSource.RemoveCurrent();
                    this.invoiceMasterBindingSource.EndEdit();
                    this._mainForm.SaveToBase(mast);

                }
                else
                {
                    MessageBox.Show("Документ не пустой!");
                }
            }

            catch (Exception err)
            {
                MainForm.Log("btDelete_Click" + err.Message);
                MessageBox.Show("Ошибка : "+ err.Message);
            }


        }

        private void gridViewInvDatAll_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView CurrentView = (sender as DevExpress.XtraGrid.Views.Grid.GridView);

            MDataSet.InvoiceMasterRow _row = CurrentView.GetDataRow(e.RowHandle) as MDataSet.InvoiceMasterRow;

            if (_row.NumCheck > 0)
            {
                e.Appearance.Font = e.Cache.GetFont(e.Appearance.Font, FontStyle.Italic);

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

        private void gridViewInvDetDatAll_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
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

        private void btProductReport_Click(object sender, EventArgs e)
        {

            MDataSet.InvoiceDetailRow detRow = this.gridViewInvDetDatAll.GetDataRow(this.gridViewInvDetDatAll.FocusedRowHandle) as MDataSet.InvoiceDetailRow;
            if (detRow == null) return;

            (this.ParentForm as MainForm).ProductReport(detRow.ProductRef);

        }
    }
}
