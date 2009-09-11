using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace RetailTrade.Remains
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
            this.remainsBindingSource.DataSource = new DataView(source, "QuantityRemains>0",null,DataViewRowState.CurrentRows);

        }

        private void Remains_Load(object sender, EventArgs e)
        {

            (this.ParentForm as MainForm).FillTable("Remains");
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            (this.ParentForm as MainForm).DeleteDataTab(this.Parent as TabPage);
        }

        private void btExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Exel files|*.xls";
            saveFileDialog1.Title = "Сохранить в Exel";
            saveFileDialog1.ShowDialog();


            if (saveFileDialog1.FileName != "")
            {
                try
                {
                    this.grid.MainView.ExportToExcel(saveFileDialog1.FileName);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);

                }
            }
        }


    }
}
