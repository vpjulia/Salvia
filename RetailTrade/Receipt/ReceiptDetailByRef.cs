using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using RetailTrade.Receipt;

namespace RetailTrade
{
    public partial class ReceiptDetailByRef : UserControl
    {
     

        public ReceiptDetailByRef()
        {
            InitializeComponent();
        }

        public ReceiptDetailByRef(MDataSet.ReceiptMasterRow source)
        {

            // this.receiptMasterBindingSource таблица//

            InitializeComponent();


            this.mDataSet = source.Table.DataSet as MDataSet;

            this.productBindingSource.DataSource = this.mDataSet.Product;
            

            this.receiptMasterBindingSource.DataSource = source;
            this.receiptMasterBindingSource.ResetBindings(true);

            this.receiptMasterBindingSourceView.DataSource = source.Table;
          //  this.receiptMasterBindingSourceView.DataMember = "ReceiptMaster";
           this.receiptMasterBindingSourceView.ResetBindings(true);
           this.receiptMasterBindingSourceView.CurrencyManager.Position= this.receiptMasterBindingSourceView.Find("ID", source.ID);
               //Filter="ID="+ source.ID.ToString();

           this.receiptDetailBindingSource.DataSource = this.receiptMasterBindingSourceView;
           this.receiptDetailBindingSource.DataMember = "ReceiptMaster_ReceiptDetail";

            this.receiptDetailBindingSource.ResetBindings(true);
             
           
           
            this.tabPage1.Text = this.receiptMasterBindingSource.CurrencyManager.Position.ToString();
           
        }




        private void gridViewProduct_Click(object sender, EventArgs e)
      
            /*создать новую строку, указатель на нее в ReceiptDetailRowAdd для редактирования*/
       
        {
            if (this.gridViewProduct.IsValidRowHandle(this.gridViewProduct.FocusedRowHandle))
            {

                FormDialog _formDialog = new FormDialog();
                _formDialog.AcceptButton = null;

                


                 MDataSet.ReceiptDetailRow sourceRow =((this.receiptDetailBindingSource.AddNew() as DataRowView).Row  as MDataSet.ReceiptDetailRow) ;

                 this.receiptDetailBindingSource.EndEdit();

                 ReceiptDetailRowAdd _receiptDetailRowAdd = new ReceiptDetailRowAdd(sourceRow, (MDataSet.ProductRow)this.gridViewProduct.GetDataRow(this.gridViewProduct.FocusedRowHandle));
           
                _formDialog.panel.Controls.Add(_receiptDetailRowAdd);
               
              
                if (DialogResult.OK == _formDialog.ShowDialog(this))
                {
                    this.receiptDetailBindingSource.EndEdit();
                }
                else
                {
                    this.receiptDetailBindingSource.CancelEdit();
               }
           }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.tabPage1.Text = this.receiptMasterBindingSource.CurrencyManager.Position.ToString();
        ///  MessageBox.Show( this.receiptMasterBindingSourceView.Find("ID", source.ID).ToString());
        }

       
        private void ReceiptDetailByRef_Load(object sender, EventArgs e)
        {
           
        }
    }
}
