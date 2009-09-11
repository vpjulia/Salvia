using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;

namespace RetailTradeClient.Receipt
{
    

    public partial class ReceiptMasterStock : UserControl
    { 
        bool _layoutChanged;
        

       

        public ReceiptMasterStock()
        {
            InitializeComponent();
        }

        public ReceiptMasterStock(MDataSet source)
        {
            InitializeComponent();

            this.mDataSet = source;
            this.receiptMasterBindingSource.DataSource = new DataView(this.mDataSet.ReceiptMaster,"DocumentTypeRef>0", null, DataViewRowState.CurrentRows);
            this.receiptMasterBindingSource.ResetBindings(false);
            // this.productBindingSource.DataSource = this.mDataSet.Product;
        
           
           
            

           this.PariodsComboBox.ComboBox.DataSource = this.mDataSet.Periods;
           this.PariodsComboBox.ComboBox.DisplayMember = "ClosedDate";

           this.PariodsComboBox.ComboBox.ValueMember = "ID";

            

        }

        private void ReceiptMasterStock_Load(object sender, EventArgs e)
        {
            foreach (GridView view in this.grid.ViewCollection)
            {
                string fileName = new FileInfo(Application.ExecutablePath).DirectoryName + "\\" + view.Name.ToString() + ".xml";
                if (File.Exists(fileName))
                    view.RestoreLayoutFromXml(fileName);
            }

            _layoutChanged = false;


          
          DateTime _begin = DateTime.Now.AddDays(-7);

          (this.ParentForm as MainForm).FillTableStockDocuments(this.mDataSet.ReceiptMaster, _begin);
              
          this.gridViewMasterStock.MasterRowGetChildList += new DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(this.gridViewMasterStock_MasterRowGetChildList);
            
        }
     
      

        private void gridViewMasterStock_MasterRowGetChildList(object sender, MasterRowGetChildListEventArgs e)
        {
            (this.ParentForm as MainForm).RefreshData((receiptMasterBindingSource.CurrencyManager.Current as DataRowView).Row as MDataSet.ReceiptMasterRow);
        }
        
        
       
        private void btField_Click(object sender, EventArgs e)
        {
            (this.grid.FocusedView as GridView).ColumnsCustomization();
        }

        private void gridViewMasterStock_Layout(object sender, EventArgs e)
        {
            _layoutChanged = true;
        }
 
        private void btClose_Click(object sender, EventArgs e)
        {
           
            if (_layoutChanged)
            {
                foreach (GridView view in this.grid.ViewCollection)
                {
                    string fileName = new FileInfo(Application.ExecutablePath).DirectoryName + "\\" + view.Name.ToString() + ".xml";
                    view.SaveLayoutToXml(fileName);

                }
            }

            (this.ParentForm as MainForm).DeleteDataTab(this.Parent as TabPage);
           
        }
        
        private void btPeriod_Click(object sender, EventArgs e)
        {

         (this.ParentForm as MainForm).FillTableStockDocuments(this.mDataSet.ReceiptMaster, Convert.ToInt32(this.PariodsComboBox.ComboBox.SelectedValue.ToString()));
              
        }

        private void btMakeNew_Click(object sender, EventArgs e)
        {

            MDataSet.ReceiptMasterRow _dr = (this.grid.FocusedView as GridView).GetDataRow((this.grid.FocusedView as GridView).FocusedRowHandle) as MDataSet.ReceiptMasterRow;
            
            if ((_dr as MDataSet.ReceiptMasterRow) != null)
            {
                if (_dr.DocumentTypeRef != 1) return;

                try
                {
                    (this.ParentForm as MainForm).receiptMasterTableAdapter.ReceiptMasterMakeToNew((_dr as MDataSet.ReceiptMasterRow).ID);
                    (this.ParentForm as MainForm).RefreshData((_dr as MDataSet.ReceiptMasterRow));
                    (this.ParentForm as MainForm).FillTableNewDocuments(this.mDataSet.ReceiptMaster);
                    (this.ParentForm as MainForm).RefreshData(this.mDataSet.Remains);
                   
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void gridViewMasterStock_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {

        }

        private void gridViewRecieptDetailStock_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
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
