using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;

namespace RetailTrade
{
    public partial class ReceiptMasterNewAll : UserControl
    {

        DataView _changesMaster;

        DataView _changesDetail;

        public DataView ChangesReceiptDetail
        {
            get { return _changesDetail; }
            set { _changesDetail = value; }
        }


        public DataView ChangesMaster
    
        {  get { return _changesMaster; }
           set { _changesMaster = value; }
        }




        public ReceiptMasterNewAll()
        {
            InitializeComponent();
        }
        public ReceiptMasterNewAll(MDataSet source)
        {
         
            InitializeComponent();



            this.mDataSet = source;


            this.receiptMasterBindingSource.DataSource = new DataView(this.mDataSet.ReceiptMaster, "DocumentTypeRef=0", null, DataViewRowState.CurrentRows);
            this.receiptMasterBindingSource.ResetBindings(false);
            this.productBindingSource.DataSource = this.mDataSet.Product;
            this.organizationBindingSource.DataSource = this.mDataSet.Organization;


          
        //    _viewChangesReceiptDetail.ListChanged += new ListChangedEventHandler(_viewChangesReceiptDetail_ListChanged);

            _changesMaster = new DataView(this.mDataSet.ReceiptMaster, "DocumentTypeRef=0", null,  DataViewRowState.Added | DataViewRowState.Deleted | DataViewRowState.ModifiedCurrent);

            _changesDetail = new DataView(this.mDataSet.ReceiptDetail,"DocumentTypeRef=0", null, DataViewRowState.Added | DataViewRowState.Deleted | DataViewRowState.ModifiedCurrent);

            _changesMaster.ListChanged+=new ListChangedEventHandler(_changesMaster_ListChanged);
            _changesDetail.ListChanged += new ListChangedEventHandler(_changesMaster_ListChanged);
           
            //  (this.receiptMasterBindingSource.DataSource as DataView).ListChanged += new ListChangedEventHandler(_viewChangesReceiptDetail_ListChanged);

        }
  
        private void ReceiptMasterNew_Load(object sender, EventArgs e)
        {


            //вычитать с сервера новые документы

            (this.ParentForm as MainForm).FillTableNewDocuments(this.mDataSet.ReceiptMaster);


            foreach (GridView view in this.grid.ViewCollection)
            {
                string fileName = new FileInfo(Application.ExecutablePath).DirectoryName + "\\" + view.Name.ToString() + ".xml";
                if (File.Exists(fileName))
                    view.RestoreLayoutFromXml(fileName);
            }

            this.receiptMasterNewBindingSource.DataSource = new DataView(this.mDataSet.ReceiptMaster, "DocumentTypeRef=0", null, DataViewRowState.CurrentRows);
            this.receiptMasterNewBindingSource.ResetBindings(false);
            this.grid.DataSource = this.receiptMasterNewBindingSource;
            this.ParentForm.FormClosing += new FormClosingEventHandler(ParentForm_FormClosing);
      
        }



        private void _changesMaster_ListChanged(object sender, ListChangedEventArgs e)
        {
            if ((sender as DataView).Count > 0)
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
            if ((this.ParentForm as MainForm) != null)

                if (this.gridViewMain.IsValidRowHandle(this.gridViewMain.FocusedRowHandle))
                {
                    int data = Convert.ToInt32(this.gridViewMain.GetDataRow(this.gridViewMain.FocusedRowHandle)["ID"].ToString());

                    Object[] paramtrs = new Object[1] { this.mDataSet.ReceiptMaster.FindByID(data) };
                    (this.ParentForm as MainForm).ShowNewDataTab("ReceiptRowOrganization", "ReceiptRowOrganization.cs", paramtrs);

                }
        }

     
        private void btAdd_Click(object sender, EventArgs e)
        {


            if ((this.ParentForm as MainForm) != null)
            {
                this.receiptMasterBindingSource.CurrencyManager.EndCurrentEdit();

                MDataSet.ReceiptMasterRow sourceRow = (this.receiptMasterBindingSource.AddNew() as DataRowView).Row as MDataSet.ReceiptMasterRow;
                this.receiptMasterBindingSource.CurrencyManager.EndCurrentEdit();

                Object[] paramtrs = new Object[1] { (this.receiptMasterBindingSource.CurrencyManager.Current as DataRowView).Row };

                (this.ParentForm as MainForm).ShowNewDataTab("ReceiptRowOrganization", "ReceiptRowOrganization.cs", paramtrs);
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            this.btEdit.PerformClick();
        }

        private void btField_Click(object sender, EventArgs e)
        {
            (this.grid.FocusedView as GridView).ColumnsCustomization();
        }

        private void BtClose_Click(object sender, EventArgs e)
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


                if ((_changesMaster.Count > 0) | (_changesDetail.Count > 0))
                {
                    DialogResult _result;

                    _result = MessageBox.Show("Сохранить изменения? ", "Сохранение приходных документов "+this.ToString(), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    switch (_result)
                    {
                        case DialogResult.Yes:
                            if (this.SaveChanges())
                                if ((this.ParentForm as MainForm) != null)
                                    (this.ParentForm as MainForm).DeleteDataTab(this.Parent as TabPage);
                              
                            break;
                        case DialogResult.No:
                            {
                                if (this.CancelChages())
                                    if ((this.ParentForm as MainForm) != null)
                                        (this.ParentForm as MainForm).DeleteDataTab(this.Parent as TabPage);
                            }
                            break;
                        case DialogResult.Cancel:
                            break;
                    }
                }
                else
                {
                    if ((this.ParentForm as MainForm) != null)
                        (this.ParentForm as MainForm).DeleteDataTab(this.Parent as TabPage);
                }
            } 
       }

        private bool CancelChages()
        {
            if (this._changesMaster.Count > 0)
            {
                foreach (DataRowView _drMaster in _changesMaster)
                {
                    string _tag = "ReceiptRowOrganization" + (_drMaster.Row as MDataSet.ReceiptMasterRow).ID.ToString();

                    if (!(this.ParentForm as MainForm).FindOpenedTabs(_tag))
                    {
                        _drMaster.Row.RejectChanges();
                        
                    }
                    else
                    {
                        MessageBox.Show("Завершите работу с документом", "Отмена изменений", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return false;
                    }
                }
            }
           
         
            if (_changesDetail.Count > 0)
            {
                foreach (DataRowView _drDetail in _changesDetail)
                {
                    string _tag = "ReceiptRowOrganization"+(_drDetail.Row as MDataSet.ReceiptDetailRow).ReceiptMasterRef.ToString();

                    if (!(this.ParentForm as MainForm).FindOpenedTabs(_tag))
                    {
                         _drDetail.Row.RejectChanges();
                        
                    }
                    else
                    {
                        MessageBox.Show("Завершите работу с документом ", "Отмена изменений", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return false;
                    }
         
                    
                }
            }
           
             return true;
        }

        private bool SaveChanges()
        {

            if (this._changesMaster.Count > 0)
            {
                foreach (DataRowView _drMaster in _changesMaster)
                {
                    string _tag = "ReceiptRowOrganization" + (_drMaster.Row as MDataSet.ReceiptMasterRow).ID.ToString();

                    if (!(this.ParentForm as MainForm).FindOpenedTabs(_tag))
                    {
                        (this.ParentForm as MainForm).SaveToBase(_drMaster.Row as RetailTrade.MDataSet.ReceiptMasterRow );
                        
                    }
                    else
                    {
                        MessageBox.Show("Завершите работу с документом", "Сохранение изменений", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return false;
                    }
                }
            }


            if (_changesDetail.Count > 0)
            {
                foreach (DataRowView _drDetail in _changesDetail)
                {
                    
                    string _tag = "ReceiptRowOrganization" + (_drDetail.Row as MDataSet.ReceiptDetailRow).ReceiptMasterRef.ToString();

                    if (!(this.ParentForm as MainForm).FindOpenedTabs(_tag))
                    {
                        MDataSet.ReceiptMasterRow _rwMaster = (_drDetail.Row as RetailTrade.MDataSet.ReceiptDetailRow).ReceiptMasterRow;
                       (this.ParentForm as MainForm).SaveToBase(_rwMaster);
                    
                    }
                    else
                    {
                        MessageBox.Show("Завершите работу с документом ", "Сохранение изменений", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return false;
                    }
                }
            }


            return true;
        }

        private void ReceiptMasterNewAll_Validating(object sender, CancelEventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Ошибка в данных!");
                e.Cancel = true;
            }
                  
        }

        private void gridViewMain_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            this.gridViewMain.SetColumnError(this.gridViewMain.Columns[1], e.ErrorText.ToString());
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (this.Validate(true))
            {
                this.SaveChanges();   
            }
        }

        private void ParentForm_FormClosing(object sender ,FormClosingEventArgs e)
        {
            if ((_changesMaster.Count > 0) | (_changesDetail.Count > 0))
            
           
            {
                DialogResult _result;

                _result = MessageBox.Show("Сохранить изменения? ParentForm_FormClosing", "Сохранение документа " + this.ToString(), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                switch (_result)
                {
                    case DialogResult.Yes:
                        if (!this.SaveChanges())
                        {
                            e.Cancel = true;
    
                        }
                      
                        break;
                    case DialogResult.No:
                        if (!this.CancelChages())
                            e.Cancel = true;
                          break;
                    case DialogResult.Cancel:
                       e.Cancel = true;
                        break;
                }
            }
             
            
        }

        private void gridViewMain_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
           
        }

        private void gridViewMain_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (gridViewMain.GetDataRow(e.RowHandle).RowState != DataRowState.Unchanged)
            {
                if (e.Column.Name == "colDocDate")
                    e.Appearance.Font = e.Cache.GetFont(e.Appearance.Font, FontStyle.Bold);
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.CancelChages();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            (this.ParentForm as MainForm).FillTableNewDocuments(this.mDataSet.ReceiptMaster);

        }

        

    }
}
