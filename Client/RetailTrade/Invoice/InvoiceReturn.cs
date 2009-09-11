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
    public partial class InvoiceReturn : UserControl
    {
        public InvoiceReturn()
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

        private void InvoiceReturn_Load(object sender, EventArgs e)
        {
            foreach (GridView view in this.grid.ViewCollection)
            {
                string fileName = new FileInfo(Application.ExecutablePath).DirectoryName + "\\" + view.Name.ToString() + ".xml";
                if (File.Exists(fileName))
                    view.RestoreLayoutFromXml(fileName);
            }
        }
    }
}
