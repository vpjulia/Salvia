using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace RetailTrade.Directory
{
    public partial class UCTradePuplet : UserControl
    {
        public UCTradePuplet()
        {
            InitializeComponent();
        }

        public UCTradePuplet(MDataSet source)
        {
            InitializeComponent();
            this.tradePutletBindingSource.DataSource = source.TradePutlet;

        }


    }
}
