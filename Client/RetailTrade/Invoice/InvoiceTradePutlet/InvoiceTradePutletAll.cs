using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace RetailTrade.Invoice.InvoiceTradePutlet
{
    public partial class InvoiceTradePutletAll : UserControl
    {
        private DataView _changesMaster;
        private DataView _changesDetail;


        public InvoiceTradePutletAll()
        {
            InitializeComponent();
        }

        public InvoiceTradePutletAll(MDataSet source)
        {
            InitializeComponent();

            
            this.mDataSet = source;
            this.invoiceMasterBindingSource.DataSource = new DataView(this.mDataSet.InvoiceMaster,null /*"DocumentTypeRef=0 or DocumentTypeRef = 1 "*/, null, DataViewRowState.CurrentRows);
            this.invoiceMasterBindingSource.ResetBindings(false);
            //this.productBindingSource.DataSource = this.mDataSet.Product;
            _changesMaster = new DataView(this.mDataSet.InvoiceMaster, "DocumentTypeRef=0", null, DataViewRowState.Added | DataViewRowState.Deleted | DataViewRowState.ModifiedCurrent);
            _changesDetail = new DataView(this.mDataSet.InvoiceDetail, "DocumentTypeRef=0", null, DataViewRowState.Added | DataViewRowState.Deleted | DataViewRowState.ModifiedCurrent);
        }

        private void InvoiceTradePutletAll_Load(object sender, EventArgs e)
        {
           (this.ParentForm as MainForm).FillTableNewDocuments(this.mDataSet.InvoiceMaster);

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            this.invoiceMasterBindingSource.EndEdit();

            MDataSet.InvoiceMasterRow _newRow = (this.invoiceMasterBindingSource.AddNew() as DataRowView).Row as MDataSet.InvoiceMasterRow; 
            if (this.ValidateChildren())
            {
                FormDialog _formDialog = new FormDialog();
                _formDialog.Text = this.Tag.ToString();

                _formDialog.AcceptButton = null;

                InvoiceDetailEditPrintMar _invoiceDetail = new InvoiceDetailEditPrintMar((this.invoiceMasterBindingSource.Current as DataRowView).Row as MDataSet.InvoiceMasterRow);

                _formDialog.panel.Controls.Add(_invoiceDetail);

                if (DialogResult.OK == _formDialog.ShowDialog(this))
                {
                    this.invoiceMasterBindingSource.EndEdit();

                }
                else

                    this.invoiceMasterBindingSource.CurrencyManager.CancelCurrentEdit();
            }

        }
    }
}
