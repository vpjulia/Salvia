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

           
            this.remainsBindingSource.DataSource = source;

        }

        private void Remains_Load(object sender, EventArgs e)
        {

            (this.ParentForm as MainForm).FillTable("Remains");
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            (this.ParentForm as MainForm).DeleteDataTab(this.Parent as TabPage);
        }


    }
}
