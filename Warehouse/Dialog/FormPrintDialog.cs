using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RetailTrade.Dialog
{
    public partial class FormPrintDialog : Form
    {
        protected FormPrintDialog()
        {
            InitializeComponent();
        }

        public FormPrintDialog(string PathServerReport)
        {
            InitializeComponent();

            this.reportViewer.ServerReport.ReportPath = PathServerReport;
            this.reportViewer.Dock = DockStyle.Fill;
        }

        private void FormPrintDialog_Load(object sender, EventArgs e)
        {
            this.reportViewer.RefreshReport();
        }


    }
}