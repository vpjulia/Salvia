using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace RetailTrade.Receipt
{
    public partial class ReceiptMasterStock : UserControl
    {
        public ReceiptMasterStock()
        {
            InitializeComponent();
        }

        public ReceiptMasterStock(MDataSet source)
        {
            InitializeComponent();

          
            this.mDataSet = source;
            this.receiptMasterBindingSource.DataSource = new DataView(this.mDataSet.ReceiptMaster, "DocumentTypeRef=1", null, DataViewRowState.CurrentRows);
            this.receiptMasterBindingSource.ResetBindings(false);
        //  this.productBindingSource.DataSource = this.mDataSet.Product;
        
        }



    }
}
