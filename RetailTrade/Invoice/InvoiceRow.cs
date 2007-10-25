using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;

namespace RetailTrade.Invoice
{
    public partial class InvoiceRow : UserControl
    {

        MDataSet.InvoiceMasterRow _curentMasterRow;

        DataView _detail;


        public InvoiceRow()
        {
            InitializeComponent();
        }


        public InvoiceRow(MDataSet.InvoiceMasterRow source)
        {
            InitializeComponent();
            
            _curentMasterRow = source;

            this.mDataSet = source.Table.DataSet as MDataSet;
           
            this.invoiceMasterBindingSource.DataSource = source.Table;
            this.invoiceMasterBindingSource.ResetBindings(false);

            _detail = new DataView(this.mDataSet.InvoiceDetail, "InvoiceMasterRef=" + source.ID.ToString(), null, DataViewRowState.CurrentRows);

            this.invoiceMasterBindingSource.CurrencyManager.Position = this.invoiceMasterBindingSource.Find("ID", source.ID);

            if (_detail.Count> 0)
            {
                this.mainStocklookUpEdit.Enabled = false;
                this.stockBindingSource.DataSource = this.mDataSet.Stock.Select("IsLocal=0 and isnds="+source.IsNDS.ToString());
                this.btMove.Visible = true;
            }
            else
            {
                this.stockBindingSource.DataSource = this.mDataSet.Stock.Select("IsLocal=0");
                this.mainStocklookUpEdit.Enabled = true;
            }

            

            this.invoiceDetailBindingSource.DataSource = this.invoiceMasterBindingSource;
            this.invoiceDetailBindingSource.DataMember = "FK_InvoiceDetail_InvoiceMaster";
            this.invoiceDetailBindingSource.ResetBindings(true);
            this.MainStockBindingSource.DataSource = new DataView(this.mDataSet.Stock, "IsLocal=1 and isnds="+source.IsNDS.ToString(), null, DataViewRowState.CurrentRows);

            if (source.ID < 0)
            {
                this.panelNumber.Enabled = false;
            }


            
            if (source.RemoteStockRef ==0)
            {
                this.grid.Enabled = false;
                this.btEdit.Enabled = false;
                this.mainStocklookUpEdit.Enabled = false;
            }

            _detail.ListChanged += new ListChangedEventHandler(_detail_ListChanged);

        }

        void _detail_ListChanged(object sender, ListChangedEventArgs e)
        {

            if (_detail.Count > 0)
            {

             this.mainStocklookUpEdit.Enabled = false;
             this.stockBindingSource.DataSource= this.mDataSet.Stock.Select("IsLocal=0 and isnds=" + _curentMasterRow.IsNDS.ToString());
             this.btMove.Visible = true;

            }else
                this.btMove.Visible = false;



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

        private void InvoiceRow_Load(object sender, EventArgs e)
        {
            foreach (GridView view in this.grid.ViewCollection)
            {


                string fileName = new FileInfo(Application.ExecutablePath).DirectoryName + "\\" + view.Name.ToString() + ".xml";


                if (File.Exists(fileName))

                    view.RestoreLayoutFromXml(fileName);

            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            if (this.gridInvoiceRowView.HasColumnErrors)
            {
                this.invoiceDetailBindingSource.CancelEdit();
            }
            if ((_detail.Count == 0) & (_curentMasterRow.ID < 0))
            {
                this._curentMasterRow.RejectChanges();
                if ((this.ParentForm as MainForm) != null)
                {
                    (this.ParentForm as MainForm).tabControl.TabPages.Remove((this.ParentForm as MainForm).tabControl.SelectedTab);
                }
            }
            else if (this.SaveChange())
            {
                if ((this.ParentForm as MainForm) != null)
                    (this.ParentForm as MainForm).tabControl.TabPages.Remove((this.ParentForm as MainForm).tabControl.SelectedTab);


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
            }
        }

        private void gridInvoiceRowView_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            this.gridInvoiceRowView.SetColumnError(this.gridInvoiceRowView.Columns[1], e.ErrorText.ToString());
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;

        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            this.invoiceMasterBindingSource.EndEdit();
            if (this.ValidateChildren())
            {
                FormDialog _formDialog = new FormDialog();
                _formDialog.Text = this.Tag.ToString();

                _formDialog.AcceptButton = null;
                InvoiceDetailEdit _invoiceDetail = new InvoiceDetailEdit((this.invoiceMasterBindingSource.Current as DataRowView).Row as MDataSet.InvoiceMasterRow);

                _formDialog.panel.Controls.Add(_invoiceDetail);

                if (DialogResult.OK == _formDialog.ShowDialog(this))
                {
                    this.invoiceMasterBindingSource.EndEdit();

                }
                else

                    this.invoiceMasterBindingSource.CurrencyManager.CancelCurrentEdit();
            }
        }

        private void StockEdit_EditValueChanged(object sender, EventArgs e)
        {
            this.StockEdit.DoValidate();
            
       }

        private void InvoiceRow_Validating(object sender, CancelEventArgs e)
        {
           if (!this.ValidateChildren())
            {
                MessageBox.Show("Ошибка данных!");
                e.Cancel = true;

            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            (this.ParentForm as MainForm).SaveToBase((this.invoiceMasterBindingSource.Current as DataRowView).Row as MDataSet.InvoiceMasterRow);
        }

        private void tabControl_Validating(object sender, CancelEventArgs e)
        {
           this.invoiceMasterBindingSource.EndEdit();
            if ((this.invoiceMasterBindingSource.Current as DataRowView).Row.RowState != DataRowState.Unchanged)
            {
                if (!(this.ParentForm as MainForm).SaveToBase((this.invoiceMasterBindingSource.Current as DataRowView).Row as MDataSet.InvoiceMasterRow))
                    e.Cancel = true;
            }else
                if (!(this.ParentForm as MainForm).RefreshData(((this.invoiceMasterBindingSource.Current as DataRowView).Row as MDataSet.InvoiceMasterRow)))
                {
                e.Cancel=true;
                }
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
        //   this.mainStocklookUpEdit.ResetText();
        }

        private void StockEdit_Validated(object sender, EventArgs e)
        {
            this.invoiceMasterBindingSource.EndEdit();
            this.MainStockBindingSource.Filter = "IsLocal=1 and IsNDS =" + ((this.invoiceMasterBindingSource.Current as DataRowView).Row as MDataSet.InvoiceMasterRow).IsNDS.ToString();
           if (_detail.Count==0) 
            this.mainStocklookUpEdit.Enabled = true;
       
            this.btEdit.Enabled = true;

        }

        private void btMove_Click(object sender, EventArgs e)
        {
            this.invoiceMasterBindingSource.EndEdit();
            
            try
            {
                (this.ParentForm as MainForm).invoiceMasterTableAdapter.InvoiceMasterMove(_curentMasterRow.ID);

                (this.ParentForm as MainForm).RefreshData(_curentMasterRow);
            }
            catch
            { MessageBox.Show("Ошибка внутреннего перемещения!"); }

            finally
            {
                this.btClose.PerformClick();
            }
        }

        private void StockEdit_Popup(object sender, EventArgs e)
        {
           

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

                    }
                }

            }
        }

       
       
    }
}
