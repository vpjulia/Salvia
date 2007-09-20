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

        private void ReceiptMasterNew_Load(object sender, EventArgs e)
        {
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
            if (this.Validate(true))
            {
                foreach (GridView view in this.grid.ViewCollection)
                {
                    string fileName = new FileInfo(Application.ExecutablePath).DirectoryName + "\\" + view.Name.ToString() + ".xml";
                    view.SaveLayoutToXml(fileName);
                }
                // сохранить изменения


                DataView _dataview = new DataView(this.mDataSet.ReceiptMaster, "DocumentTypeRef=0", null, DataViewRowState.Added | DataViewRowState.ModifiedCurrent | DataViewRowState.Deleted);
                if (_dataview.Count > 0)
                {
                    DialogResult _result;

                    _result = MessageBox.Show("Сохранить изменения? ", "Сохранение приходных документов ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    switch (_result)
                    {
                        case DialogResult.Yes:
                            if (this.SaveChanges())
                                if ((this.ParentForm as MainForm) != null)
                                    (this.ParentForm as MainForm).tabControl.TabPages.Remove((this.ParentForm as MainForm).tabControl.SelectedTab);
                            break;
                        case DialogResult.No:
                            if ((this.ParentForm as MainForm) != null)
                                (this.ParentForm as MainForm).tabControl.TabPages.Remove((this.ParentForm as MainForm).tabControl.SelectedTab);
                            break;
                        case DialogResult.Cancel:
                            break;
                    }
                }
            } 
       }

        private bool SaveChanges()
        {
            MessageBox.Show("Вызов сохранения");
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
            DataView _dataview = new DataView(this.mDataSet.ReceiptMaster, "DocumentTypeRef=0", null, DataViewRowState.Added | DataViewRowState.ModifiedCurrent | DataViewRowState.Deleted);
            if (_dataview.Count >= 0)
            {
                DialogResult _result;

                _result = MessageBox.Show("Сохранить изменения? ", "Сохранение документа ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                switch (_result)
                {
                    case DialogResult.Yes:
                        if (this.SaveChanges())
                        {
                            if ((this.ParentForm as MainForm) != null)
                                (this.ParentForm as MainForm).tabControl.TabPages.Remove((this.ParentForm as MainForm).tabControl.SelectedTab);
                        }
                        else
                        {
                            e.Cancel = true;
                        }
                        break;
                    case DialogResult.No:
                        if ((this.ParentForm as MainForm) != null)
                            (this.ParentForm as MainForm).tabControl.TabPages.Remove((this.ParentForm as MainForm).tabControl.SelectedTab);
                        break;
                    case DialogResult.Cancel:
                       e.Cancel = true;
                        break;
                }
            }
             
            
        }

    }
}
