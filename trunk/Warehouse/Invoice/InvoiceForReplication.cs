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
    public partial class InvoiceForReplication : UserControl
    {
        DataView _changesMaster;

        DataView _changesDetail;

        public InvoiceForReplication()
        {
            InitializeComponent();
        }

        public InvoiceForReplication(MDataSet source)
        {
          InitializeComponent();
            this.mDataSet = source;
            this.invoiceMasterBindingSource.DataSource = new DataView(this.mDataSet.InvoiceMaster, "DocumentTypeRef=3", null, DataViewRowState.CurrentRows);
            this.invoiceMasterBindingSource.ResetBindings(false);
          _changesMaster = new DataView(this.mDataSet.InvoiceMaster, "DocumentTypeRef=3", null, DataViewRowState.Added|DataViewRowState.Deleted|DataViewRowState.ModifiedCurrent);
          _changesDetail = new DataView(this.mDataSet.InvoiceDetail, "DocumentTypeRef=3", null, DataViewRowState.Added | DataViewRowState.Deleted | DataViewRowState.ModifiedCurrent);


      }
     
        private bool CancelChages()
      {
          this.invoiceMasterBindingSource.CancelEdit();
          return true;
      }

      
        private bool SaveChanges()
      {
          this.invoiceMasterBindingSource.EndEdit();
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

        private void InvoiceForReplication_Load(object sender, EventArgs e)
        {
            (this.ParentForm as MainForm).FillTableNewDocuments(this.mDataSet.InvoiceMaster);

            foreach (GridView view in this.grid.ViewCollection)
            {
                string fileName = new FileInfo(Application.ExecutablePath).DirectoryName + "\\" + view.Name.ToString() + ".xml";
                if (File.Exists(fileName))
                    view.RestoreLayoutFromXml(fileName);
            }

        }

        private void btMakeNew_Click(object sender, EventArgs e)
        {
            DataRow _dr = (this.grid.FocusedView as GridView).GetDataRow((this.grid.FocusedView as GridView).FocusedRowHandle);
            if ((_dr as MDataSet.InvoiceMasterRow) != null)
            {
                try
                {
                    (this.ParentForm as MainForm).invoiceMasterTableAdapter.InvoiceMasterMakeToNew((_dr as MDataSet.InvoiceMasterRow).ID);
                    
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
                finally
                {
                    (this.ParentForm as MainForm).RefreshData((_dr as MDataSet.InvoiceMasterRow),false);

                }

            }
        }

    }
}
