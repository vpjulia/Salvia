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
    public partial class InvoiceClosed : UserControl
    {


        public InvoiceClosed()
        {
            InitializeComponent();
        }

        public InvoiceClosed(MDataSet source)
        {
            InitializeComponent();
            this.mDataSet = source;
            this.invoiceMasterBindingSource.DataSource = new DataView(source.InvoiceMaster,"DocumentTypeRef=1",null,DataViewRowState.CurrentRows);


            this.PeriodsComboBox.ComboBox.DataSource = this.mDataSet.Periods;
            this.PeriodsComboBox.ComboBox.DisplayMember = "Name";
            this.PeriodsComboBox.ComboBox.ValueMember = "ID";

        }

        private void InvoiceClosed_Load(object sender, EventArgs e)
        {

            
            foreach (GridView view in this.grid.ViewCollection)
            {
                string fileName = new FileInfo(Application.ExecutablePath).DirectoryName + "\\" + view.Name.ToString() + ".xml";
                if (File.Exists(fileName))
                    view.RestoreLayoutFromXml(fileName);
            }

            DateTime _beg = DateTime.Now.AddDays(-7);

            (this.ParentForm as MainForm).FillTableStockDocuments(this.mDataSet.InvoiceMaster, _beg);


        }

        private void btPeriod_Click(object sender, EventArgs e)
        {
            int _id = Convert.ToInt32(this.PeriodsComboBox.ComboBox.SelectedValue.ToString());
            (this.ParentForm as MainForm).FillTableStockDocuments(this.mDataSet.InvoiceMaster, _id);


        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.invoiceMasterBindingSource.EndEdit();
                    if ((this.ParentForm as MainForm) != null)
                        (this.ParentForm as MainForm).DeleteDataTab(this.Parent as TabPage);
                          
        }



    }
}
