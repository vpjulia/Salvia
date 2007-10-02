using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;

namespace RetailTrade.Receipt
{
    public partial class ReceiptMasterStock : UserControl
    {
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
            // this.productBindingSource.DataSource = this.mDataSet.Product;
        
            _changesReceiptMaster = new DataView(this.mDataSet.ReceiptMaster, "DocumentTypeRef=1", null, DataViewRowState.Added | DataViewRowState.Deleted | DataViewRowState.ModifiedCurrent);

            _changesReceiptDetail = new DataView(this.mDataSet.ReceiptDetail, "DocumentTypeRef=1", null, DataViewRowState.Added | DataViewRowState.Deleted | DataViewRowState.ModifiedCurrent);

             _changesReceiptMaster.ListChanged+=new ListChangedEventHandler(_changes_ListChanged);
            _changesReceiptMaster.ListChanged+=new ListChangedEventHandler (_changes_ListChanged);


        }

     
        private void btClose_Click(object sender, EventArgs e)
        {
            this.receiptMasterBindingSource.EndEdit();

            if (this.Validate(true))
            {
                foreach (GridView view in this.grid.ViewCollection)
                {
                    string fileName = new FileInfo(Application.ExecutablePath).DirectoryName + "\\" + view.Name.ToString() + ".xml";
                    view.SaveLayoutToXml(fileName);
                }
                // сохранить изменения


                if ((_changesReceiptMaster.Count > 0) | (_changesReceiptDetail.Count > 0))
                {
                    DialogResult _result;

                    _result = MessageBox.Show("Сохранить изменения? ", "Сохранение приходных документов " + this.ToString(), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    switch (_result)
                    {
                        case DialogResult.Yes:
                            if (this.SaveChanges())
                                if ((this.ParentForm as MainForm) != null)
                                    (this.ParentForm as MainForm).tabControl.TabPages.Remove((this.ParentForm as MainForm).tabControl.SelectedTab);
                            break;
                        case DialogResult.No:
                            {
                                if (this.CancelChages())
                                    if ((this.ParentForm as MainForm) != null)
                                        (this.ParentForm as MainForm).tabControl.TabPages.Remove((this.ParentForm as MainForm).tabControl.SelectedTab);
                            }
                            break;
                        case DialogResult.Cancel:
                            break;
                    }
                }
                else
                {
                    if ((this.ParentForm as MainForm) != null)
                        (this.ParentForm as MainForm).tabControl.TabPages.Remove((this.ParentForm as MainForm).tabControl.SelectedTab);

                }
            } 
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

        private void btEdit_Click(object sender, EventArgs e)
        {
            this.gridViewMasterStock.OptionsBehavior.Editable = true;
            this.gridViewRecieptDetailStock.OptionsBehavior.Editable = true;
            this.btDelete.Visible = true;
            this.btEdit.Visible = false;

        }

    }
}
