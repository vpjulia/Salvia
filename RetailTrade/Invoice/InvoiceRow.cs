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
        public InvoiceRow()
        {
            InitializeComponent();
        }


        public InvoiceRow(MDataSet.InvoiceMasterRow source)
        {
            InitializeComponent();

            this.mDataSet = source.Table.DataSet as MDataSet;

            this.invoiceMasterBindingSource.DataSource = source.Table;
            this.invoiceMasterBindingSource.ResetBindings(false);
            this.invoiceMasterBindingSource.CurrencyManager.Position = this.invoiceMasterBindingSource.Find("ID", source.ID);

              this.stockBindingSource.DataSource = this.mDataSet.Stock.Select("IsLocal=0");
            /*    this.productBindingSource.DataSource = this.mDataSet.Product;
     */

            this.invoiceDetailBindingSource.DataSource = this.invoiceMasterBindingSource;
            this.invoiceDetailBindingSource.DataMember = "FK_InvoiceDetail_InvoiceMaster";
            this.invoiceDetailBindingSource.ResetBindings(true);
            this.MainStockBindingSource.DataSource = new DataView(this.mDataSet.Stock, "IsLocal=1", null, DataViewRowState.CurrentRows);

            if (source.ID < 0)
            {
                this.panelNumber.Enabled = false;
            }


            if (source.GetInvoiceDetailRows().Length>0)
            {
                this.MainStocklookUpEdit.Enabled = false;
                this.StockEdit.Enabled = false;
            }
            if (source.RemoteStockRef ==0)
            {
                this.grid.Enabled = false;
                this.btEdit.Enabled = false;
              //  this.MainStocklookUpEdit.Enabled = false;
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

        private void StockEdit_EditValueChanged(object sender, EventArgs e)
        {
            this.MainStockBindingSource.Filter="IsLocal=1 and IsNds="+this.StockEdit.GetColumnValue("IsNDS").ToString();;
            //this.MainStocklookUpEdit.d
            
       }

        private void InvoiceRow_Validating(object sender, CancelEventArgs e)
        {
            if (!this.ValidateChildren())
                MessageBox.Show("Ошибка данных!");
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            (this.ParentForm as MainForm).SaveToBase((this.invoiceMasterBindingSource.Current as DataRowView).Row as MDataSet.InvoiceMasterRow);
        }

       
    }
}
