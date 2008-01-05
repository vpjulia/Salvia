using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace RetailTrade.Orders
{
    public partial class OrdersAll : UserControl
    {
        public OrdersAll()
        {
            InitializeComponent();
        }
        public OrdersAll(MDataSet.OrdersDataTable source)
        {
            InitializeComponent();

            this.mDataSet = source.DataSet as MDataSet;

         this.ordersBindingSource.DataSource = source;
         this.ordersBindingSource.ResetBindings(false);
       
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            (this.ParentForm as MainForm).DeleteDataTab(this.Parent as TabPage);
        }

        private void OrdersAll_Load(object sender, EventArgs e)
        {
            this.ordersTableAdapter.Fill(this.mDataSet.Orders);
        }
    }
}
