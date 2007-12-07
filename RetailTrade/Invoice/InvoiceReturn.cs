using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace RetailTrade.Invoice
{
    public partial class InvoiceReturn : UserControl
    {

        private MainForm _mainForm;

        public InvoiceReturn()
        {
            InitializeComponent();
        }

        public InvoiceReturn(MDataSet mdataset,MainForm mainform)
        {
            InitializeComponent();
            this.mDataSet = mdataset;
            _mainForm = mainform;

            this.linkedInvoiceMasterBindingSource.DataSource = this.mDataSet.LinkedInvoiceMaster;
            this.linkedInvoiceMasterBindingSource.ResetBindings(true);
            this.cbTradePutlet.ComboBox.DataSource = new DataView(this.mDataSet.TradePutlet,"Id> 0","Name",DataViewRowState.CurrentRows);
            this.cbTradePutlet.ComboBox.DisplayMember = "Name";
            this.cbTradePutlet.ComboBox.ValueMember = "ID";


        }

        private void btFind_Click(object sender, EventArgs e)
        {

        }

        private void InvoiceReturn_Load(object sender, EventArgs e)
        {
          /*  this.linkedInvoiceMasterTableAdapter.Fill(this.mDataSet.LinkedInvoiceMaster);
            this.linkedInvoiceDetailTableAdapter.Fill(this.mDataSet.LinkedInvoiceDetail);
            */

        }



    }
}
