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

            this.ordersBindingSource.DataSource = source;
            this.ordersBindingSource.ResetBindings(false);

        }
    }
}
