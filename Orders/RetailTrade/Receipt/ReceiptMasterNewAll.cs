using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;

namespace RetailTradeOrders
{
    public partial class ReceiptMasterNewAll : UserControl
    {
        MDataSet.ReceiptMasterDataTable _table;

        public ReceiptMasterNewAll()
        {
            InitializeComponent();
        }

        public ReceiptMasterNewAll(MDataSet source)
        {
            InitializeComponent();
            _table = source.ReceiptMaster;
            mDataSet = source;
            this.receiptMasterBindingSource.DataSource = new DataView(_table, "DocumentTypeRef = 0", null, DataViewRowState.CurrentRows);
            this.productBindingSource.DataSource = source.Product;
            this.productBindingSource.ResetBindings(true);

           
        }

        private void ReceiptMasterNewAll_Load(object sender, EventArgs e)
        {
            foreach (GridView view in this.grid.ViewCollection)
            {
                string fileName = new FileInfo(Application.ExecutablePath).DirectoryName + "\\" + view.Name.ToString() + ".xml";
                if (File.Exists(fileName))
                    view.RestoreLayoutFromXml(fileName);
            }

            (this.ParentForm as MainForm).FillTableNewDocuments(_table);
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            (this.ParentForm as MainForm).FillTableNewDocuments(_table);
        }

        private void btMove_Click(object sender, EventArgs e)
        {

           

            MDataSet.ReceiptMasterRow _mastRow = this.gridViewRecMast.GetDataRow(this.gridViewRecMast.FocusedRowHandle) as MDataSet.ReceiptMasterRow;

            

            if (_mastRow!=null)
            {
                

                foreach (MDataSet.ReceiptDetailRow _detRow in _mastRow.GetReceiptDetailRows())
                {
                    if (_detRow.ProductRow == null)
                       if (!(this.ParentForm as MainForm).RefreshData(mDataSet.Product, _detRow.ProductRef))
                        {
                            _mastRow.RowError = "Выполните синхронизацию!";
                        }
                }


                if (_mastRow.RowError != "")
                {
                    MessageBox.Show(_mastRow.RowError);
                    return;
                }
            
            
              if (DialogResult.OK == MessageBox.Show("Переместить выбранный документ?", "Приходные документы", MessageBoxButtons.OKCancel))
                {
                    try
                    {
                        (this.ParentForm as MainForm).receiptMasterTableAdapter.ReceiptMasterMove(_mastRow.ID);

                        (this.ParentForm as MainForm).RefreshData(this.mDataSet.ReceiptMaster as DataTable);
                        (this.ParentForm as MainForm).RefreshData(this.mDataSet.Remains as DataTable);

                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка внутреннего перемещения!  "+ err.Message);

                    }

                    (this.ParentForm as MainForm).FillTableNewDocuments(_table);
                }
            }      
        }

        private void gridViewRecMast_MasterRowExpanding(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowCanExpandEventArgs e)
        {
            MDataSet.ReceiptMasterRow _mastRow = this.gridViewRecMast.GetDataRow(e.RowHandle) as MDataSet.ReceiptMasterRow;
            if (_mastRow != null)
            {
                foreach (MDataSet.ReceiptDetailRow _detRow in _mastRow.GetReceiptDetailRows())
                {
                    if (_detRow.ProductRow == null)
                    
                        if (!(this.ParentForm as MainForm).RefreshData(mDataSet.Product, _detRow.ProductRef))
                        {
                            _mastRow.RowError = "Выполните синхронизацию!";
                        }


                }
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            foreach (GridView view in this.grid.ViewCollection)
            {
                string fileName = new FileInfo(Application.ExecutablePath).DirectoryName + "\\" + view.Name.ToString() + ".xml";
                view.SaveLayoutToXml(fileName);
            }
           


            (this.ParentForm as MainForm).DeleteDataTab(this.Parent as TabPage); 
        }

        private void gridViewRecDet_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "UseByDate")
            {
                if (DateTime.Parse(e.DisplayText).AddMonths(-6) < DateTime.Today)
                {
                    e.Appearance.ForeColor = Color.Pink;
                }
                if (DateTime.Parse(e.DisplayText).AddMonths(-2) < DateTime.Today)
                {
                    e.Appearance.ForeColor = Color.Red;
                }
            }
        }

    

       
    }
}
