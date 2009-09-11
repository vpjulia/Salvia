using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;

namespace RetailTradeClient.Invoice
{
    public partial class InvoiceDetail : UserControl
    {



        public InvoiceDetail()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {

            foreach (DevExpress.XtraGrid.Views.Grid.GridView view in this.grid.ViewCollection)
            {
                string fileName = new System.IO.FileInfo(Application.ExecutablePath).DirectoryName + "\\" + view.Name.ToString() + ".xml";
                view.SaveLayoutToXml(fileName);

            }

            (this.ParentForm as MainForm).DeleteDataTab(this.Parent as TabPage);


        }

        private void InvoiceDetail_Load(object sender, EventArgs e)

        {

            this.mDataSet = (this.ParentForm as MainForm).mDataSet;
            this.invoiceDetailBindingSource.DataSource = this.mDataSet.InvoiceDetail;
            this.PeriodsComboBox.ComboBox.DataSource = new DataView(this.mDataSet.Periods,"id>0","Id DESC",DataViewRowState.CurrentRows);
            this.PeriodsComboBox.ComboBox.DisplayMember = "ClosedDate";
            this.PeriodsComboBox.ComboBox.ValueMember = "ID";

            foreach (GridView view in this.grid.ViewCollection)
            {
                string fileName = new FileInfo(Application.ExecutablePath).DirectoryName + "\\" + view.Name.ToString() + ".xml";
                if (File.Exists(fileName))
                    view.RestoreLayoutFromXml(fileName);
            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            (this.ParentForm as MainForm).FillTableStockDocuments(this.mDataSet.InvoiceMaster, Convert.ToInt32(this.PeriodsComboBox.ComboBox.SelectedValue.ToString()));
        }

        private void btProductReport_Click(object sender, EventArgs e)
        {
            if (this.invoiceDetailBindingSource.Count == 0) return;

            int _ref = ((this.invoiceDetailBindingSource.Current as DataRowView).Row as MDataSet.InvoiceDetailRow).ProductRef;
            (this.ParentForm as MainForm).ProductReport(_ref);
        }
    }
}
