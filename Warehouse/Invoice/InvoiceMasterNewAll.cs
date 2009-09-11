using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;

namespace RetailTrade.Invoice
{
    public partial class InvoiceMasterNewAll : UserControl
    {
        DataView _changesMaster;
      
        DataView _changesDetail;

        public InvoiceMasterNewAll()
        {
            InitializeComponent();
        }

        public InvoiceMasterNewAll(MDataSet source)
        {
            InitializeComponent();
            this.mDataSet = source;
            this.invoiceMasterBindingSource.DataSource = new DataView(this.mDataSet.InvoiceMaster, "DocumentTypeRef=0", null, DataViewRowState.CurrentRows);
            this.invoiceMasterBindingSource.ResetBindings(false);
           //this.productBindingSource.DataSource = this.mDataSet.Product;
            _changesMaster = new DataView(this.mDataSet.InvoiceMaster, "DocumentTypeRef=0", null, DataViewRowState.Added|DataViewRowState.Deleted|DataViewRowState.ModifiedCurrent);
            _changesDetail = new DataView(this.mDataSet.InvoiceDetail, "DocumentTypeRef=0", null, DataViewRowState.Added | DataViewRowState.Deleted | DataViewRowState.ModifiedCurrent);
        }

        private void InvoiceMasterNewAll_Load(object sender, EventArgs e)
        {
            (this.ParentForm as MainForm).FillTableNewDocuments(this.mDataSet.InvoiceMaster);
        
            foreach (GridView view in this.grid.ViewCollection)
            {
                string fileName = new FileInfo(Application.ExecutablePath).DirectoryName + "\\" + view.Name.ToString() + ".xml";
                if (File.Exists(fileName))
                    view.RestoreLayoutFromXml(fileName);
            }

        
        
        }
  
        private void gridInvoiceMasterNewAll_DoubleClick(object sender, EventArgs e)
        {
              if ((this.ParentForm as MainForm) != null)

                  if (this.gridViewInvoiceMasterAll.IsValidRowHandle(this.gridViewInvoiceMasterAll.FocusedRowHandle))
                {
                    int data = Convert.ToInt32(this.gridViewInvoiceMasterAll.GetDataRow(this.gridViewInvoiceMasterAll.FocusedRowHandle)["ID"].ToString());

                    Object[] paramtrs = new Object[1] { this.mDataSet.InvoiceMaster.FindByID(data) };
                    (this.ParentForm as MainForm).ShowNewDataTab("InvoiceRow", "InvoiceRow.cs", paramtrs);

                }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if ((this.ParentForm as MainForm) != null)
            {
                this.invoiceMasterBindingSource.CurrencyManager.EndCurrentEdit();

                MDataSet.InvoiceMasterRow sourceRow = (this.invoiceMasterBindingSource.AddNew() as DataRowView).Row as MDataSet.InvoiceMasterRow;
                this.invoiceMasterBindingSource.CurrencyManager.EndCurrentEdit();

                Object[] paramtrs = new Object[1] { sourceRow };

                (this.ParentForm as MainForm).ShowNewDataTab("InvoiceRow", "Создание накладной", paramtrs);

            }

        }

      
        private bool CancelChages()
        {
            this.invoiceMasterBindingSource.CancelEdit();
            return true;
        }

        private bool SaveChanges()
        {
            this.invoiceMasterBindingSource.EndEdit();

            foreach (DataRowView _mastRow in _changesMaster)
            {
                (this.ParentForm as MainForm).SaveToBase(_mastRow.Row as MDataSet.InvoiceMasterRow);
            }
                return true;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.invoiceMasterBindingSource.EndEdit();

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

                    _result = MessageBox.Show("Сохранить изменения? ", "Сохранение приходных документов " + this.ToString(), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

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

        private void btDelete_Click(object sender, EventArgs e)
        {

            DataRow _dr = (this.grid.FocusedView as GridView).GetDataRow((this.grid.FocusedView as GridView).FocusedRowHandle);
            if ((_dr) != null)
            {
                foreach (DataRelation _relation in _dr.Table.ChildRelations)
                {
                    
                    
                    if ((_dr.GetChildRows(_relation).Length>0)&(_relation.ParentKeyConstraint!=null))
                    {
                        MessageBox.Show("Невозможно удалить строку!");
                        return;
                    }

                    if (DialogResult.OK == MessageBox.Show("Удалить строку? ", "Удаление накладной", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
                    {
                        _dr.Delete();
                        this.SaveChanges();
                    }
                }
            }
        }

        private void btField_Click(object sender, EventArgs e)
        {
            (this.grid.FocusedView as GridView).ColumnsCustomization();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                this.SaveChanges();

                (this.ParentForm as MainForm).FillTableNewDocuments(this.mDataSet.InvoiceMaster);
            }
            catch (Exception err)
            {
                 MessageBox.Show("Ошибка!" + err.Message);

            
            }
        }

        


    }
}
