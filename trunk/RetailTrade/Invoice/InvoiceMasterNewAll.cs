using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace RetailTrade.Invoice
{
    public partial class InvoiceMasterNewAll : UserControl
    {
        public InvoiceMasterNewAll()
        {
            InitializeComponent();
        }
        public InvoiceMasterNewAll(MDataSet source)
        {
            InitializeComponent();
            this.mDataSet = source;
            this.invoiceMasterBindingSource.DataSource = new DataView(this.mDataSet.InvoiceMaster, "DocumentTypeRef=0", null, DataViewRowState.CurrentRows);
            this.invoiceMasterBindingSource.ResetBindings(false);
           //this.productBindingSource.DataSource = this.mDataSet.Product;
       
        }

        

        private void gridInvoiceMasterNewAll_DoubleClick(object sender, EventArgs e)
        {
              if ((this.ParentForm as MainForm) != null)

                  if (this.gridViewInvoiceMasterAll.IsValidRowHandle(this.gridViewInvoiceMasterAll.FocusedRowHandle))
                {
                    int data = Convert.ToInt32(this.gridViewInvoiceMasterAll.GetDataRow(this.gridViewInvoiceMasterAll.FocusedRowHandle)["ID"].ToString());

                    Object[] paramtrs = new Object[1] { this.mDataSet.InvoiceMaster.FindByID(data) };
                    (this.ParentForm as MainForm).ShowNewDataTab("InvoiceRow", "InvoiceRow.cs", paramtrs);

                }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if ((this.ParentForm as MainForm) != null)
            {
                this.invoiceMasterBindingSource.CurrencyManager.EndCurrentEdit();

                MDataSet.InvoiceMasterRow sourceRow = (this.invoiceMasterBindingSource.AddNew() as DataRowView).Row as MDataSet.InvoiceMasterRow;
                this.invoiceMasterBindingSource.CurrencyManager.EndCurrentEdit();

                Object[] paramtrs = new Object[1] { sourceRow };

                (this.ParentForm as MainForm).ShowNewDataTab("InvoiceRow", "Создание накладной", paramtrs);

            }

        }
    }
}
