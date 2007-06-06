using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace RetailTrade
{
    public partial class ReceiptMasterNewAll : UserControl
    {
        public ReceiptMasterNewAll()
        {
            InitializeComponent();
        }
        public ReceiptMasterNewAll(MDataSet source)
        {
            InitializeComponent();
            this.mDataSet = source;
            this.receiptMasterBindingSource.DataSource = this.mDataSet.ReceiptMaster;
            this.receiptMasterBindingSource.ResetBindings(false);
            
           
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if ((this.ParentForm as MainForm) != null)
        
                if (this.gridView1.IsValidRowHandle(this.gridView1.FocusedRowHandle))
                {
                    int data = Convert.ToInt32(this.gridView1.GetDataRow(this.gridView1.FocusedRowHandle)["ID"].ToString());

                    Object[] paramtrs = new Object[1] { this.mDataSet.ReceiptMaster.FindByID(data) };
                    (this.ParentForm as MainForm).ShowNewDataTab("ReceiptRowOrganization", "ReceiptRowOrganization.cs", paramtrs);

                }

    

        }

        private void ReceiptMasterNew_Load(object sender, EventArgs e)
        {
            this.receiptMasterNewBindingSource = (this.ParentForm as MainForm).receiptMasterNewBindingSource;
            this.receiptMasterNewBindingSource.ResetBindings(false);
            this.gridControl1.DataSource = this.receiptMasterNewBindingSource;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {


            if ((this.ParentForm as MainForm) != null)
              {
                 this.receiptMasterBindingSource.CurrencyManager.EndCurrentEdit();

                 MDataSet.ReceiptMasterRow sourceRow =(this.receiptMasterBindingSource.AddNew() as DataRowView).Row as MDataSet.ReceiptMasterRow;
                 this.receiptMasterBindingSource.CurrencyManager.EndCurrentEdit(); 
               
                 Object[] paramtrs = new Object[1] { (this.receiptMasterBindingSource.CurrencyManager.Current as DataRowView).Row };
                  
                (this.ParentForm as MainForm).ShowNewDataTab("ReceiptRowOrganization", "ReceiptRowOrganization.cs", paramtrs);

                }


        }
    }
}
