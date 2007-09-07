using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using RetailTrade.Receipt;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

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

          /*  !!!!!  this.productBindingSource.DataSource = this.mDataSet.Product.Select("IsNds=" + source.StockRow.IsNDS.ToString() );
            */

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
           
           
        }




        private void gridViewProduct_Click(object sender, EventArgs e)
      
            /*создать новую строку, указатель на нее в ReceiptDetailRowAdd дл€ редактировани€*/
       
        {
            if (this.gridViewProduct.IsValidRowHandle(this.gridViewProduct.FocusedRowHandle) & this.gridViewProduct.State == GridState.Normal & !this.gridViewProduct.IsFilterRow(this.gridViewProduct.FocusedRowHandle))
            {
                FormDialog _formDialog = new FormDialog();
                _formDialog.AcceptButton = null;
                _formDialog.Text = "ƒобавить стоку";
               MDataSet.ReceiptDetailRow sourceRow = ((this.receiptDetailBindingSource.AddNew() as DataRowView).Row as MDataSet.ReceiptDetailRow);
               MDataSet.ProductRow productRow =(this.productBindingSource.CurrencyManager.Current as MDataSet.ProductRow) ;
                
                if ((sourceRow != null)&(productRow!=null))
                {
                    ReceiptDetailRowAdd _receiptDetailRowAdd = new ReceiptDetailRowAdd(sourceRow, productRow);
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
        }

       

       
        private void ReceiptDetailByRef_Load(object sender, EventArgs e)
        {
           
        }

        private void gridProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) & (this.gridViewProduct.IsValidRowHandle(this.gridViewProduct.FocusedRowHandle)))
                this.gridViewProduct_Click(sender,e);
    
        }

        private void gridViewReceiptDetail_Click(object sender, EventArgs e)
        {
            if (this.gridViewReceiptDetail.IsValidRowHandle(this.gridViewReceiptDetail.FocusedRowHandle) & this.gridViewReceiptDetail.State == GridState.Normal & !this.gridViewReceiptDetail.IsFilterRow(this.gridViewReceiptDetail.FocusedRowHandle))
            {
                FormDialog _formDialog = new FormDialog();
                _formDialog.AcceptButton = null;
                _formDialog.Text = "»зменить стоку";
                MDataSet.ReceiptDetailRow sourceRow = ((this.receiptDetailBindingSource.CurrencyManager.Current as DataRowView).Row as MDataSet.ReceiptDetailRow);
                ReceiptDetailRowAdd _receiptDetailRowAdd = new ReceiptDetailRowAdd(sourceRow, (sourceRow.GetParentRow("Product_ReceiptDetail") as MDataSet.ProductRow));
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

        private void fieldMenuItem_Click(object sender, EventArgs e)
        {
            this.gridViewReceiptDetail.ColumnsCustomization();
            this.gridViewReceiptDetail.CustomizationForm.TopMost = true;
          //  this.gridViewReceiptDetail.CustomizationForm.Opacity = 0.7;
          //  this.gridViewReceiptDetail.CustomizationForm.FormBorderStyle = FormBorderStyle.FixedDialog;

        }

        private void DeleteMenuItem_Click(object sender, EventArgs e)
        {
            int hendl = (this.gridReceiptDetail.FocusedView as ColumnView).FocusedRowHandle;

            if (this.gridViewReceiptDetail.IsValidRowHandle(hendl) & hendl != DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
            {
                int countChild = 0;


                DataRow[] arrRows;
               DataRow mrow = (this.gridReceiptDetail.FocusedView as ColumnView).GetDataRow(hendl);

                foreach (DataRelation relation in mrow.Table.ChildRelations)
                {

                    if (mrow.GetChildRows(relation) != null)
                    {
                        arrRows = mrow.GetChildRows(relation);

                        countChild += arrRows.Length;
                    }

                }

                if (countChild != 0)

                    MessageBox.Show("Ќевозможно удалить запись, ссылок на нее :  " + countChild.ToString(), this.Tag.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                else

                    if (MessageBox.Show(" ”далить запись? ","–едактирование приходного акта",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                         == DialogResult.Yes)
                 
                        this.gridReceiptDetail.EmbeddedNavigator.Buttons.Remove.DoClick();
                       
                 }
        }
    }
}
