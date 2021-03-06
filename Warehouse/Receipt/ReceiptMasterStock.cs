using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;
using RetailTrade.Dialog;
using Microsoft.Reporting.WinForms;

namespace RetailTrade.Receipt
{
    

    public partial class ReceiptMasterStock : UserControl
    { 
        bool _layoutChanged;
        DataView _changesReceiptMaster;

        DataView _changesReceiptDetail;

        public DataView ChangesReceiptDetail
        {
            get { return _changesReceiptDetail; }
            set { _changesReceiptDetail = value; }
        }

        public DataView ChangesReceiptMaster
        {
            get { return _changesReceiptMaster; }
            set { _changesReceiptMaster = value; }
        }

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


            this.organizationBindingSource.DataSource = this.mDataSet.Organization;

            this.organizationBindingSource.ResetBindings(false);

            // this.productBindingSource.DataSource = this.mDataSet.Product;
        
           //  ��������� 

            this.btDelete.Visible = false;
           

           this.PariodsComboBox.ComboBox.DataSource = this.mDataSet.Periods;
           this.PariodsComboBox.ComboBox.DisplayMember = "Name";

           this.PariodsComboBox.ComboBox.ValueMember = "ID";

            _changesReceiptMaster = new DataView(this.mDataSet.ReceiptMaster, "DocumentTypeRef=1", null, DataViewRowState.Added | DataViewRowState.Deleted | DataViewRowState.ModifiedCurrent);

            _changesReceiptDetail = new DataView(this.mDataSet.ReceiptDetail, "DocumentTypeRef=1", null, DataViewRowState.Added | DataViewRowState.Deleted | DataViewRowState.ModifiedCurrent);

            _changesReceiptMaster.ListChanged+=new ListChangedEventHandler(_changes_ListChanged);
            _changesReceiptDetail.ListChanged += new ListChangedEventHandler(_changes_ListChanged);


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
              
          this.ParentForm.FormClosing += new FormClosingEventHandler(ParentForm_FormClosing);
          this.gridViewMasterStock.MasterRowGetChildList += new DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(this.gridViewMasterStock_MasterRowGetChildList);
     



        }
     
        private void _changes_ListChanged(object sender, ListChangedEventArgs e)
        {
          
            if ( (this._changesReceiptMaster.Count > 0)|(this._changesReceiptDetail.Count > 0))
            {
                this.btSave.Visible = true;
                this.btCancel.Visible = true;
            }
            else
            {
                this.btSave.Visible = false;
                this.btCancel.Visible = false;
            }
        }

        private void gridViewMasterStock_MasterRowGetChildList(object sender, MasterRowGetChildListEventArgs e)
        {
            (this.ParentForm as MainForm).RefreshData((receiptMasterBindingSource.CurrencyManager.Current as DataRowView).Row as MDataSet.ReceiptMasterRow);
        }
        
        private bool CancelChages()
        {

            if (_changesReceiptDetail.Count > 0)
            {
                foreach (DataRowView _drDetail in _changesReceiptDetail)
                {
                     _drDetail.Row.RejectChanges();


                }
            } 
            
            if (this._changesReceiptMaster.Count > 0)
            {
                foreach (DataRowView _drMaster in _changesReceiptMaster)
                {
                  
                        _drMaster.Row.RejectChanges();

                   
                }
            }



            return true;
        
        
        }

        private bool SaveChanges()
        {


            if (this._changesReceiptMaster.Count > 0)
            {
                foreach (DataRowView _drMaster in _changesReceiptMaster)
                {
                 
                        (this.ParentForm as MainForm).SaveToBase(_drMaster.Row as RetailTrade.MDataSet.ReceiptMasterRow);

                  
                }
            }


            if (_changesReceiptDetail.Count > 0)
            {
                foreach (DataRowView _drDetail in _changesReceiptDetail)
                {
                        MDataSet.ReceiptMasterRow _rwMaster = (_drDetail.Row as RetailTrade.MDataSet.ReceiptDetailRow).ReceiptMasterRow;
                        (this.ParentForm as MainForm).SaveToBase(_rwMaster);
                  
                }
            }

            return true;
        
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (this.SaveChanges())
            {
                this.gridViewMasterStock.OptionsBehavior.Editable = false;
                this.gridViewRecieptDetailStock.OptionsBehavior.Editable = false;
          
                this.btEdit.Visible = true;
                this.btDelete.Visible = false;
                this.btMakeNew.Visible = false;
                this.PariodsComboBox.Visible = true;
                this.btPeriod.Visible = true;

            }

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            if (this.CancelChages())
            {
                this.gridViewMasterStock.OptionsBehavior.Editable = false;
                this.gridViewRecieptDetailStock.OptionsBehavior.Editable = false;
          
                this.btEdit.Visible = true;
                this.btDelete.Visible =false;
            
            }

        }
      
        private void btEdit_Click(object sender, EventArgs e)
        {
            this.gridViewMasterStock.OptionsBehavior.Editable = true;
            this.gridViewRecieptDetailStock.OptionsBehavior.Editable = true;
            this.btDelete.Visible = true;
            this.btEdit.Visible = false;
            this.btMakeNew.Visible = true;
            this.btDelete.Visible = false;
            this.PariodsComboBox.Visible = false;
            this.btPeriod.Visible = false;
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
            this.receiptMasterBindingSource.EndEdit();
            if (_layoutChanged)
            {
                foreach (GridView view in this.grid.ViewCollection)
                {
                    string fileName = new FileInfo(Application.ExecutablePath).DirectoryName + "\\" + view.Name.ToString() + ".xml";
                    view.SaveLayoutToXml(fileName);

                }
            }
            if (this.Validate(true))
            {
                // ��������� ���������


                if ((_changesReceiptMaster.Count > 0) | (_changesReceiptDetail.Count > 0))
                {
                    DialogResult _result;

                    _result = MessageBox.Show("��������� ���������? ", "���������� ��������� ���������� " + this.ToString(), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    switch (_result)
                    {
                        case DialogResult.Yes:
                            if (this.SaveChanges())
                            {
                                this.ParentForm.FormClosing -= new FormClosingEventHandler(ParentForm_FormClosing);
                                (this.ParentForm as MainForm).DeleteDataTab(Parent as TabPage);
                            }

                            break;
                        case DialogResult.No:
                            {
                                if (this.CancelChages())
                                {
                                    this.ParentForm.FormClosing -= new FormClosingEventHandler(ParentForm_FormClosing);
                   
                                    (this.ParentForm as MainForm).DeleteDataTab(Parent as TabPage);
                                }
                            }
                            break;
                        case DialogResult.Cancel:
                            break;
                    }
                }
                else
                {
                    this.ParentForm.FormClosing -= new  FormClosingEventHandler(ParentForm_FormClosing);
                        (this.ParentForm as MainForm).DeleteDataTab(Parent as TabPage); 

                }
            } 
        }
     
 
        void ParentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.receiptMasterBindingSource.EndEdit();
            if (this.ValidateChildren())
            {
                // ��������� ���������

                if ((_changesReceiptMaster.Count > 0) | (_changesReceiptDetail.Count > 0))
                {
                    DialogResult _result;

                    _result = MessageBox.Show("��������� ���������? ", "���������� ��������� ���������� " + this.ToString(), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    switch (_result)
                    {
                        case DialogResult.Yes:
                            if (!this.SaveChanges())
                                e.Cancel = true;   
                                break;
                        case DialogResult.No:
                            {
                                if (!this.CancelChages())

                                    e.Cancel = true;
                                }
                            break;
                        case DialogResult.Cancel:
                            e.Cancel = true;
                            break;
                    }
                }
              
                
            } 


        }

   
        private void btPeriod_Click(object sender, EventArgs e)
        {

         (this.ParentForm as MainForm).FillTableStockDocuments(this.mDataSet.ReceiptMaster, Convert.ToInt32(this.PariodsComboBox.ComboBox.SelectedValue.ToString()));
              
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DataRow _dr = (this.grid.FocusedView as GridView).GetDataRow((this.grid.FocusedView as GridView).FocusedRowHandle);
            if ((_dr as MDataSet.ReceiptDetailRow) != null)
            {
                foreach(DataRelation _relation in _dr.Table.ChildRelations)

                    if (_dr.GetChildRows(_relation) != null)
                    {
                        MessageBox.Show("���������� ������� ������!");
                        return;
                    }

                if (DialogResult.OK == MessageBox.Show("������� ������? ", "�������� ������ �������", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
                {
                    _dr.Delete();
                    this.SaveChanges();
                }
            }
     
        }

        private void btMakeNew_Click(object sender, EventArgs e)
        {
            DataRow _dr = (this.grid.FocusedView as GridView).GetDataRow((this.grid.FocusedView as GridView).FocusedRowHandle);
            if ((_dr as MDataSet.ReceiptMasterRow) != null)
            {
                try
                {
                    (this.ParentForm as MainForm).receiptMasterTableAdapter.ReceiptMasterMakeToNew((_dr as MDataSet.ReceiptMasterRow).ID);
                    (this.ParentForm as MainForm).RefreshData((_dr as MDataSet.ReceiptMasterRow));

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void gridViewRecieptDetailStock_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
           /*


            if (det.UseByDate.AddMonths(-6) < DateTime.Today)

                e.Appearance.ForeColor = Color.Pink;

            if (det.UseByDate.AddMonths(-2) < DateTime.Today)
                e.Appearance.ForeColor = Color.Red;
            */


        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

       
          private void btPrint_Click(object sender, EventArgs e)
        {

            MDataSet.ReceiptMasterRow row = (this.receiptMasterBindingSource.Current as DataRowView).Row as MDataSet.ReceiptMasterRow;


            FormPrintDialog fromDialog = new FormPrintDialog("/ReportRetailTrade/ReceiptMasterByID");


          
            ReportParameter ReceiptMasterRef = new ReportParameter("ReceiptMasterRef", row.ID.ToString());

       
            fromDialog.reportViewer.ServerReport.SetParameters(new ReportParameter[] { ReceiptMasterRef });

            fromDialog.ShowDialog(this);

        }

        private void gridViewMasterStock_MasterRowCollapsing(object sender, MasterRowCanExpandEventArgs e)
        {
            MDataSet.ReceiptMasterRow _ReceiptMasterRow = this.gridViewMasterStock.GetDataRow(e.RowHandle) as MDataSet.ReceiptMasterRow;

            if (_ReceiptMasterRow == null) return;

                  (this.ParentForm as MainForm).RefreshData(_ReceiptMasterRow);


            //
        }
       

    }
}
