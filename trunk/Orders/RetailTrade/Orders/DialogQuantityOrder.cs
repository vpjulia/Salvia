using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RetailTradeOrders.Orders
{
    public partial class DialogQuantityOrder : Form
    {
        private decimal _QauntityRemains;

        public decimal QauntityRemains
        {
            get { return _QauntityRemains; }
            set { _QauntityRemains = value; }
        }


        public DialogQuantityOrder()
        {
            InitializeComponent();
        }

        public DialogQuantityOrder(MDataSet.ProductRow source,MDataSet.OrdersRow newRow)
        {
            InitializeComponent();

            newRow.ProductRef = source.ID;

            this.productBindingSource.DataSource = source;

            if (source.GetRemainsRows().Length != 0)
            {
                foreach (MDataSet.RemainsRow row in source.GetRemainsRows())
                {
                    _QauntityRemains += row.QuantityRemains;
                }
            
            }

            this.ordersBindingSource.DataSource = newRow;

            this.labelRem.DataBindings.Add(new Binding("Text", this, "QauntityRemains"));
        }

        private void DialogQuantityOrder_Load(object sender, EventArgs e)
        {


        }

        private void numericUpDown_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                this.btOk.Select();

        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (QuantityEdit.Value != 0)
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}