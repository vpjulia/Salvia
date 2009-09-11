using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;
using RetailTrade.Dialog;
using Microsoft.Reporting.WinForms;

namespace RetailTrade.Invoice
{
    public partial class InvoiceRow : UserControl
    {

        MDataSet.InvoiceMasterRow _curentMasterRow;

        MDataSet mainDataset;

        DataView _changesDetail;
        DataView _changesMaster;

        public InvoiceRow()
        {
            InitializeComponent();
        }

        public InvoiceRow(MDataSet.InvoiceMasterRow source)
        {
            InitializeComponent();

            _curentMasterRow = source;

             mainDataset= source.Table.DataSet as MDataSet;
        }
 
        
        private bool InitData()
      
        {
           try
           {
               if (!_curentMasterRow.HasVersion(DataRowVersion.Original))

                   this.invoiceMasterTableAdapter.Update(_curentMasterRow);


               this.Save();

               if (!(this.ParentForm as MainForm).RefreshData(_curentMasterRow, false))
               
                   return false;

               this.mDataSet.Stock.Merge(this.mainDataset.Stock);
               
               this.mainDataset.TradePutlet.Merge(this.mainDataset.TradePutlet);

               this.mDataSet.InvoiceMaster.ImportRow(_curentMasterRow);
            
               this.mDataSet.Remains.Merge(this.mainDataset.Remains);
             
               this.invoiceDetailTableAdapter.FillByInvoiceMasterRef(this.mDataSet.InvoiceDetail,_curentMasterRow.ID);

           }
           catch (Exception err)
           {
               DataRow[] er = this.mDataSet.InvoiceDetail.GetErrors();

               MessageBox.Show( er[1].RowError);
               MessageBox.Show(err.Message);
               return false;

           }

           return true;
        
       }
        private bool InitControls()

        {

            if (InitData())
            {
                this.invoiceMasterBindingSource.DataSource = this.mDataSet.InvoiceMaster;
                this.invoiceMasterBindingSource.ResetBindings(false);


                this.invoiceDetailBindingSource.DataSource = this.invoiceMasterBindingSource;
                this.invoiceDetailBindingSource.DataMember = "FK_InvoiceDetail_InvoiceMaster";

                this.invoiceDetailBindingSource.ResetBindings(true);


                this.productBindingSource.DataSource = this.mainDataset.Product;
                this.productBindingSource.ResetBindings(false);
                this.MainStockBindingSource.DataSource = new DataView(this.mainDataset.Stock, "isnds=" + this._curentMasterRow.IsNDS.ToString(), null, DataViewRowState.CurrentRows);
                this.invoiceMasterBindingSource.CurrencyManager.Position = this.invoiceMasterBindingSource.Find("ID", this._curentMasterRow.ID);

                _changesMaster = new DataView(this.mDataSet.InvoiceMaster, null, null, DataViewRowState.Added | DataViewRowState.Deleted | DataViewRowState.ModifiedCurrent);


                //_detail = (this.invoiceMasterBindingSource.Current as DataRowView).CreateChildView("FK_InvoiceDetail_InvoiceMaster");


                _changesDetail = new DataView(this.mDataSet.InvoiceDetail, null, null, DataViewRowState.Added | DataViewRowState.Deleted | DataViewRowState.ModifiedCurrent);

                if (this._curentMasterRow.GetInvoiceDetailRows().Length > 0)
                {
                    this.mainStocklookUpEdit.Enabled = false;
                    this.stockBindingSource.DataSource = this.mDataSet.Stock.Select("IsLocal=0 and isnds=" + this._curentMasterRow.IsNDS.ToString());

                }
                else
                {
                    
                  /*  this.stockBindingSource.DataSource = this.mDataSet.Stock.Select("IsLocal=0");*/
                    this.mainStocklookUpEdit.Enabled = true;
                }


                if (this._curentMasterRow.ID < 0)
                {
                    this.panelNumber.Enabled = false;
                }



                if (this._curentMasterRow.RemoteStockRef == 0)
                {
                    this.grid.Enabled = false;
                    this.btEdit.Enabled = false;
                    this.mainStocklookUpEdit.Enabled = false;
                }

                if (_changesDetail.Count == 0 & _changesMaster.Count == 0)
                {
                    btSave.Visible = false;
                    btMove.Visible = true;
                }
                else
                {
                    btSave.Visible = true;
                    btMove.Visible = false;

                }
                
            }

            else
            {
                this.Enabled = false;
                return false;
               
            }
            return true;
         }
     

       private void InvoiceRow_Load(object sender, EventArgs e)
        {
            foreach (GridView view in this.grid.ViewCollection)
            {


                string fileName = new FileInfo(Application.ExecutablePath).DirectoryName + "\\" + view.Name.ToString() + ".xml";


                if (File.Exists(fileName))

                    view.RestoreLayoutFromXml(fileName);

            }


           /* вычитать детаил*/



            if (InitControls())
            {
                _changesDetail.ListChanged += new ListChangedEventHandler(_detail_ListChanged);
            }
            else
            {
                this.btClose_Click(sender,e);
            
            }

        }

  
        void _detail_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (this._curentMasterRow.ID >0)
            {
                this.panelNumber.Enabled = true;
            }

            if (this._curentMasterRow.RemoteStockRef > 0)
            {
               this.grid.Enabled = true;
                        
            }
            
            if (this._curentMasterRow.GetInvoiceDetailRows().Length > 0)
            {

             this.mainStocklookUpEdit.Enabled = false;
             this.stockBindingSource.DataSource= this.mDataSet.Stock.Select("IsLocal=0 and isnds=" + _curentMasterRow.IsNDS.ToString());
            
            }


            if (_changesDetail.Count==0 & _changesMaster.Count==0) 
            {
                this.btMove.Visible = true;
                this.btSave.Visible = false;

            }
            else
            {
                this.btSave.Visible = true;
                this.btMove.Visible = false;
            }

        }

        private bool SaveChange()
        {

            this.invoiceMasterBindingSource.CurrencyManager.EndCurrentEdit();
            this.invoiceDetailBindingSource.CurrencyManager.EndCurrentEdit();

            if ((this.ParentForm as MainForm).SaveToBase((this.invoiceMasterBindingSource.Current as DataRowView).Row as MDataSet.InvoiceMasterRow))
            {
                this.invoiceMasterBindingSource.ResetCurrentItem();
                this.Parent.Tag = "InvoiceRow" + ((this.invoiceMasterBindingSource.Current as DataRowView).Row as MDataSet.InvoiceMasterRow).ID.ToString();
                this.Parent.Text = "№" /*+ ((this.receiptMasterBindingSource.Current as DataRowView).Row as MDataSet.InvoiceMasterRow).Number.ToString() + " " + ((this.invoiceMasterBindingSource.Current as DataRowView).Row as MDataSet.InvoiceMasterRow).OrganizationRow.ShortName.ToString()*/;
                this.panelNumber.Enabled = true;
            }
            return true;
        }

        private void btField_Click(object sender, EventArgs e)
        {
            (this.grid.FocusedView as GridView).ColumnsCustomization();
        }


      
        private void gridInvoiceRowView_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            this.gridInvoiceRowView.SetColumnError(this.gridInvoiceRowView.Columns[1], e.ErrorText.ToString());
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;

        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            this.invoiceMasterBindingSource.EndEdit();
            this.Save();

            

            this.mainDataset.InvoiceDetail.Merge(this.mDataSet.InvoiceDetail);

            if (this.ValidateChildren())
            {
                FormDialog _formDialog = new FormDialog();
                _formDialog.Text = this.Tag.ToString();

            //   _formDialog.WindowState = FormWindowState.Maximized;


                _formDialog.AcceptButton = null;
                InvoiceDetailEdit _invoiceDetail = new InvoiceDetailEdit(_curentMasterRow, this.mainDataset.Product,(this.ParentForm as MainForm));

              //  _invoiceDetail.Dock = DockStyle.Fill;

                _formDialog.panel.Controls.Add(_invoiceDetail);

                if (DialogResult.OK == _formDialog.ShowDialog(this))
                {
                    this.invoiceMasterBindingSource.EndEdit();

                    btRefresh_Click(sender, e);

                    this.mDataSet.Remains.Merge(this.mainDataset.Remains);

                }
                else
                {
                    this.invoiceMasterBindingSource.CurrencyManager.CancelCurrentEdit();
                    btRefresh_Click(sender, e);
                }
            }
        }

        private void StockEdit_EditValueChanged(object sender, EventArgs e)
        {
            this.StockEdit.DoValidate();

            this.Save();
            
       }

        private void InvoiceRow_Validating(object sender, CancelEventArgs e)
        {
           if (!this.ValidateChildren())
            {
                MessageBox.Show("Ошибка данных!");
                e.Cancel = true;

            }
        }

        private bool  Save()
        {

            this.invoiceMasterBindingSource.EndEdit();
            this.invoiceDetailBindingSource.EndEdit();

            try
            {

                this.invoiceDetailTableAdapter.Update(this.mDataSet.InvoiceDetail);
                this.invoiceMasterTableAdapter.Update(this.mDataSet.InvoiceMaster);


            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
                return false;

            }
            return true;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            this.Save();   
                       
        }

        private void tabControl_Validating(object sender, CancelEventArgs e)
        {
           this.invoiceMasterBindingSource.EndEdit();

            this.Save();

            if ((this.invoiceMasterBindingSource.Current as DataRowView).Row.RowState != DataRowState.Unchanged)
            {
                if (!(this.ParentForm as MainForm).SaveToBase((this.invoiceMasterBindingSource.Current as DataRowView).Row as MDataSet.InvoiceMasterRow))
                    e.Cancel = true;
            }else
                if (!(this.ParentForm as MainForm).RefreshData(((this.invoiceMasterBindingSource.Current as DataRowView).Row as MDataSet.InvoiceMasterRow),false))
                {
                e.Cancel=true;
                }
        }

      

        private void StockEdit_Validated(object sender, EventArgs e)
        {
            this.invoiceMasterBindingSource.EndEdit();
            this.MainStockBindingSource.Filter = "IsLocal=1 and IsNDS =" + ((this.invoiceMasterBindingSource.Current as DataRowView).Row as MDataSet.InvoiceMasterRow).IsNDS.ToString();
           if (this._curentMasterRow.GetInvoiceDetailRows().Length==0) 
            this.mainStocklookUpEdit.Enabled = true;
       
            this.btEdit.Enabled = true;

        }

        private void btMove_Click(object sender, EventArgs e)
        {
            this.invoiceMasterBindingSource.EndEdit();


            if (!this.Save()) return;

            if (_curentMasterRow.RemoteStockRef <= 1)
            {
                MessageBox.Show("Не указана точка!");
                return;
            
            }

            if (_curentMasterRow.Sum == 0) return;

            foreach (DataRow detrow in this._curentMasterRow.GetInvoiceDetailRows())
            {
                if ((detrow as MDataSet.InvoiceDetailRow).PriceRetailNDS == 0)

                {
                    MessageBox.Show("Есть не установленные цены!!!");
                    return;
                }
            }

            try
            {
                (this.ParentForm as MainForm).invoiceMasterTableAdapter.InvoiceMasterMove(_curentMasterRow.ID);

                (this.ParentForm as MainForm).RefreshData(_curentMasterRow,false);


            }
            catch
            { MessageBox.Show("Ошибка внутреннего перемещения!"); }

            finally
            {
                this.btClose.PerformClick();
            }
        }

        private void Del_Click(object sender, EventArgs e)
        {
            if (this.gridInvoiceRowView.IsValidRowHandle(this.gridInvoiceRowView.FocusedRowHandle) & this.gridInvoiceRowView.State == GridState.Normal & !this.gridInvoiceRowView.IsFilterRow(this.gridInvoiceRowView.FocusedRowHandle))
            {
                DataRow _dr = this.gridInvoiceRowView.GetDataRow(this.gridInvoiceRowView.FocusedRowHandle);

                if ((_dr as MDataSet.InvoiceDetailRow) != null)
                {
                    if (DialogResult.OK == MessageBox.Show("Удалить стоку?", "Изменение накладной", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                    {

                        this.invoiceDetailBindingSource.RemoveCurrent();
                        this.Save();
                        (this.ParentForm as MainForm).RefreshData(_dr as MDataSet.InvoiceDetailRow);

                    }
                }

            }
        }

        private void btSetExtr_Click(object sender, EventArgs e)
        {

            this.invoiceDetailBindingSource.EndEdit();
            this.invoiceMasterBindingSource.EndEdit();

      //      if (this._curentMasterRow.GetInvoiceDetailRows().Length == 0) return;

            FormDialog _FormDialog = new FormDialog();
            _FormDialog.Text = "Установить наценку ";

            _FormDialog.btCancel.Visible = false;

            NumericUpDown _num = new NumericUpDown ();
            Label _lab = new Label();
            _lab.Text = "Процент (%): ";
            _num.Value = 30;
            _num.Increment = 5;

            _FormDialog.panel.Controls.Add(_lab);
            _FormDialog.panel.Controls.Add(_num);
 
            _lab.Dock = DockStyle.Bottom;
            
            if (_FormDialog.ShowDialog(this.ParentForm) == DialogResult.OK)
            {
                try
                {
                    int ext = Convert.ToInt16(_num.Value); 

                    this.invoiceMasterTableAdapter.InvoiceMasterSetExtrById(ext,_curentMasterRow.ID);

                    (this.ParentForm as MainForm).RefreshData(_curentMasterRow,true);

                }
                catch (Exception err)

                {
                    MessageBox.Show(err.Message);
                }
            /*    foreach (DataRow _Row in _curentMasterRow.GetInvoiceDetailRows())
                {
                    MDataSet.InvoiceDetailRow _DetailRow = _Row as MDataSet.InvoiceDetailRow; 

                    _DetailRow.PriceRetailNDS = Decimal.Round(_DetailRow.PricePurchase * (1 + _num.Value / 100),2);
                
                }
            */
            }

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            if (this.gridInvoiceRowView.HasColumnErrors)
            {
                this.invoiceDetailBindingSource.CancelEdit();
            }
            if ((_changesDetail.Count == 0) & (_curentMasterRow.ID < 0))
            {
                this._curentMasterRow.RejectChanges();
                if ((this.ParentForm as MainForm) != null)
                {
                    (this.ParentForm as MainForm).DeleteDataTab(this.Parent as TabPage);

                }
            }
            else if (this.SaveChange())
            {
                foreach (GridView view in this.grid.ViewCollection)
                {

                    string fileName = new FileInfo(Application.ExecutablePath).DirectoryName + "\\" + view.Name.ToString() + ".xml";

                    try
                    {
                        view.SaveLayoutToXml(fileName);
                    }
                    catch
                    {
                        MessageBox.Show("Не удалось сохранить настройки");
                    }

                }
                if ((this.ParentForm as MainForm) != null)

                    (this.ParentForm as MainForm).DeleteDataTab(this.Parent as TabPage);


            }
        }

        private void btPrint_Click(object sender, EventArgs e)
        {


            FormPrintDialog fromDialog = new FormPrintDialog("/ReportRetailTrade/InvoiceMasterByID");


          
            ReportParameter ReceiptMasterRef = new ReportParameter("InvoiceMasterRef", this._curentMasterRow.ID.ToString());

            fromDialog.reportViewer.ServerReport.SetParameters(new ReportParameter[] { ReceiptMasterRef });



           


            fromDialog.ShowDialog(this);
        }

        private void btProductReport_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.gridInvoiceRowView.IsValidRowHandle(this.gridInvoiceRowView.FocusedRowHandle) & this.gridInvoiceRowView.State == GridState.Normal & !this.gridInvoiceRowView.IsFilterRow(this.gridInvoiceRowView.FocusedRowHandle))
                {
                    DataRow _dr = this.gridInvoiceRowView.GetDataRow(this.gridInvoiceRowView.FocusedRowHandle);

                    if ((_dr as MDataSet.InvoiceDetailRow).RemainsRow != null)
                    {
                        (this.ParentForm as MainForm).ProductReport((_dr as MDataSet.InvoiceDetailRow).RemainsRow.ProductRef);
                    }

                }
            }
            catch (Exception err)

            {
                MessageBox.Show(err.Message);
            }
           
        }

        private void btStockRep_Click(object sender, EventArgs e)
        {
            try
            {
                FormPrintDialog fromDialog = new FormPrintDialog("/ReportRetailTrade/InvoiceMasterByIdForStock");

                ReportParameter ReceiptMasterRef = new ReportParameter("InvoiceMasterRef", this._curentMasterRow.ID.ToString());

                fromDialog.reportViewer.ServerReport.SetParameters(new ReportParameter[] { ReceiptMasterRef });
                fromDialog.ShowDialog(this);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

            
            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {

            this.Save();
          
            if (!(this.ParentForm as MainForm).RefreshData(_curentMasterRow, false))

                return ;


            this.invoiceDetailTableAdapter.FillByInvoiceMasterRef(this.mDataSet.InvoiceDetail, _curentMasterRow.ID);


        }

        private void btDiscard_Click(object sender, EventArgs e)
        {


            this.invoiceMasterBindingSource.EndEdit();


            if (!this.Save()) return;

            if (_curentMasterRow.Sum == 0) return;

           
            try
            {
               


                    (this.ParentForm as MainForm).invoiceMasterTableAdapter.InvoiceMasterMoveDiscard(_curentMasterRow.ID);

                    (this.ParentForm as MainForm).RefreshData(_curentMasterRow, false);
            

            }
            catch
            { MessageBox.Show("Ошибка внутреннего перемещения!"); }

            finally
            {
                this.btClose.PerformClick();
            }









        }

        private void btCloseByOrganization_Click(object sender, EventArgs e)
        {
            //***/



            this.invoiceMasterBindingSource.EndEdit();


            if (!this.Save()) return;

            if (_curentMasterRow.Sum == 0) return;

            foreach (DataRow detrow in this._curentMasterRow.GetInvoiceDetailRows())
            {
                if ((detrow as MDataSet.InvoiceDetailRow).PriceRetailNDS == 0)
                {
                    MessageBox.Show("Есть не установленные цены!!!");
                    return;
                }
            }

            SelectTradePutlet _selectTradePutlet = new SelectTradePutlet();


            _selectTradePutlet.organizationBindingSource.DataSource = this.mainDataset.Organization;

            _selectTradePutlet.organizationBindingSource.ResetBindings(false);


            _selectTradePutlet.lookUpEdit.Properties.DataSource = _selectTradePutlet.organizationBindingSource;


            FormDialog _formDialog = new FormDialog();
            _formDialog.panel.Controls.Add(_selectTradePutlet);

           try
            {  int _OrganizationRef ;

            if (_formDialog.ShowDialog(this) == DialogResult.OK)
            {
                if (Convert.ToInt32(_selectTradePutlet.lookUpEdit.EditValue) == 0)
                    return;

                _OrganizationRef = Convert.ToInt32(_selectTradePutlet.lookUpEdit.EditValue);

         





           
                (this.ParentForm as MainForm).invoiceMasterTableAdapter.InvoiceMasterMoveToOrg(_curentMasterRow.ID, _OrganizationRef);

                (this.ParentForm as MainForm).RefreshData(_curentMasterRow, false);
   }

            }
            catch
            { MessageBox.Show("Ошибка внутреннего перемещения!"); }

            finally
            {
                this.btClose.PerformClick();
            }









          


        }



       
        

     
       
    }
}
