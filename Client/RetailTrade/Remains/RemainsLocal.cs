using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;

namespace RetailTradeClient.Remains
{
    public partial class RemainsLocal : UserControl
    {
        public RemainsLocal()
        {
            InitializeComponent();


        }

        public RemainsLocal(MDataSet.RemainsDataTable source)
        {
            InitializeComponent();

           
            this.remainsBindingSource.DataSource = new DataView(source,"quantityRemains<>0",null,DataViewRowState.CurrentRows);

        }

        private void Remains_Load(object sender, EventArgs e)
        {
            foreach (GridView view in this.grid.ViewCollection)
            {
                string fileName = new FileInfo(Application.ExecutablePath).DirectoryName + "\\" + view.Name.ToString() + ".xml";
                if (File.Exists(fileName))
                    view.RestoreLayoutFromXml(fileName);
            }
            (this.ParentForm as MainForm).FillTable("Remains");
        }

        private void gridViewRemMain_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            MDataSet.RemainsRow det = this.gridViewRemMain.GetDataRow(e.RowHandle) as MDataSet.RemainsRow;
            if (det == null) return;

            if (det.UseByDate.AddMonths(-6) < DateTime.Today)
            {
                e.Appearance.ForeColor = Color.Pink;
            }
            if (det.UseByDate.AddMonths(-2) < DateTime.Today)
            {
                e.Appearance.ForeColor = Color.Red;
            }

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            foreach (GridView view in this.grid.ViewCollection)
            {
                string fileName = new FileInfo(Application.ExecutablePath).DirectoryName + "\\" + view.Name.ToString() + ".xml";
                view.SaveLayoutToXml(fileName);
            }
           


            (this.ParentForm as MainForm).DeleteDataTab(this.Parent as TabPage);
        }

        private void btProductReport_Click(object sender, EventArgs e)
        {

            if (this.remainsBindingSource.Count==0)
                return;

            int _ref = ((this.remainsBindingSource.Current as DataRowView).Row as MDataSet.RemainsRow).ProductRef;

            (this.ParentForm as MainForm).ProductReport(_ref);
        }


    }
}
