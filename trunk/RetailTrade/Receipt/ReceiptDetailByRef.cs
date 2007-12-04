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
using DevExpress.XtraGrid;

namespace RetailTrade
{
    public partial class ReceiptDetailByRef : UserControl
    {
        private bool _isNds;

        DataTable _productTable;
        MainForm _mainForm;

        public ReceiptDetailByRef()
        {
            InitializeComponent();
        }

        public ReceiptDetailByRef(MDataSet.ReceiptMasterRow source,DataTable tableProduct,MainForm mainform)
        {
           
            InitializeComponent();

            _mainForm = mainform;

            _productTable = tableProduct;


            _isNds = source.StockRowByFK_ReceiptMaster_Stock.IsNDS;

            this.mDataSet = source.Table.DataSet as MDataSet;
            
            

            this.productBindingSource.DataSource = new DataView(_productTable, "IsNds=" + _isNds.ToString(),"Name",DataViewRowState.Unchanged);
           
            this.productBindingSource.ResetBindings(true);
     //      this.productBindingSource.DataSource = this.mDataSet.Product.Select("IsNds=" + source.StockRowByFK_ReceiptMaster_Stock.IsNDS.ToString() );
  
            this.receiptMasterBindingSource.DataSource = source;
            this.receiptMasterBindingSource.ResetBindings(true);

            this.receiptMasterBindingSourceView.DataSource = source.Table;
       
            this.receiptMasterBindingSourceView.ResetBindings(true);
            this.receiptMasterBindingSourceView.CurrencyManager.Position= this.receiptMasterBindingSourceView.Find("ID", source.ID);
              
            this.receiptDetailBindingSource.DataSource = this.receiptMasterBindingSourceView;
            this.receiptDetailBindingSource.DataMember = "ReceiptMaster_ReceiptDetail";
            this.receiptDetailBindingSource.ResetBindings(true);
        }

        private void ReceiptDetailByRef_Load(object sender, EventArgs e)
        {
            try
            {
                FullDataSet.ProductDataTable _pr = new FullDataSet.ProductDataTable();

                _mainForm.productTableAdapter1.FillByName(_pr, "А");
                _productTable.Merge(_pr);

                this.productBindingSource.ResetBindings(false);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void gridViewProduct_Click(object sender, EventArgs e)
      
            /*создать новую строку, указатель на нее в ReceiptDetailRowAdd для редактирования*/
       
        {
            if (this.gridViewProduct.IsValidRowHandle(this.gridViewProduct.FocusedRowHandle) & this.gridViewProduct.State == GridState.Normal & !this.gridViewProduct.IsFilterRow(this.gridViewProduct.FocusedRowHandle))
            {
                FormDialog _formDialog = new FormDialog();
                _formDialog.AcceptButton = null;
                _formDialog.Text = "Добавить стоку";

               MDataSet.ReceiptDetailRow sourceRow = ((this.receiptDetailBindingSource.AddNew() as DataRowView).Row as MDataSet.ReceiptDetailRow);
 
                int _idproduct = Convert.ToInt32(((this.productBindingSource.CurrencyManager.Current as DataRowView).Row as DataRow)["ID"]);

                 MDataSet.ProductRow productRow = this.mDataSet.Product.FindByID(_idproduct);

                 if (productRow==null)
                 {
                     ((this.productBindingSource.CurrencyManager.Current as DataRowView).Row  as FullDataSet.ProductRow).SetModified();

                     this.mDataSet.Product.Merge(_productTable.GetChanges());

                     ((this.productBindingSource.CurrencyManager.Current as DataRowView).Row as FullDataSet.ProductRow).AcceptChanges();
              
                     productRow = this.mDataSet.Product.FindByID(_idproduct);

                    }

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
                _formDialog.Text = "Изменить стоку";
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
                    if (relation.ChildKeyConstraint != null)//если  внешний ключ
                    {
                        if (mrow.GetChildRows(relation) != null)
                        {
                            arrRows = mrow.GetChildRows(relation);

                            countChild += arrRows.Length;
                        }
                    }
                }

                if (countChild != 0)

                    MessageBox.Show("Невозможно удалить запись, ссылок на нее :  " + countChild.ToString(), this.Tag.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                else

                    if (MessageBox.Show(" Удалить запись? ","Редактирование приходного акта",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                         == DialogResult.Yes)
                 
                        this.gridReceiptDetail.EmbeddedNavigator.Buttons.Remove.DoClick();
                 }
        }

        private void gridViewReceiptDetail_InvalidRowException(object sender, InvalidRowExceptionEventArgs e)
        {
            this.gridViewReceiptDetail.SetColumnError(this.gridViewReceiptDetail.Columns[1], e.ErrorText.ToString());
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
      
        }

        private void gridViewProduct_CalcPreviewText(object sender, CalcPreviewTextEventArgs e)
        {
            FullDataSet.ProductRow _row = this.gridViewProduct.GetDataRow(e.RowHandle) as FullDataSet.ProductRow;
            if (_row != null)
            {
                string pack = "";
                string place = "";
                string farmgr = "";
                string subst = "";
                string country = "";

                if (_row.PackingRef > 0)
                    pack = _row.PackingRow.Name.ToString();

                if (_row.StorageConditionRef > 0)
                    place = _row.StorageConditionRow.Name.ToString();

                if (_row.FarmGrouplevel2Ref > 0)

                    farmgr = _row.FarmGroupLevel2Row.Name.ToString();

                if (_row.SubstanceRef > 0)
                    place = _row.SubstanceRow.Name.ToString();

                if (_row.ManufacturerRef > 0)
                    country = _row.ManufacturerRow.CountryRow.Name.ToString();


                e.PreviewText = pack.ToString() + "   " + place + "  " + farmgr + "   " + subst + "  " + country;
            }
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            string name = this.gridViewProduct.GetRowCellDisplayText(GridControl.AutoFilterRowHandle, this.colName);

            if (name.Length == 0) return;


            try
            {
                FullDataSet.ProductDataTable _pr = new FullDataSet.ProductDataTable();

                _mainForm.productTableAdapter1.FillByName(_pr, name);
                _productTable.Merge(_pr);

                this.productBindingSource.ResetBindings(false);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
