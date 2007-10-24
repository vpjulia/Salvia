using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;

namespace RetailTrade
{
    public partial class UCOrganizationAll : UserControl
    {

        DataView _changes;

        public UCOrganizationAll()
        {
            InitializeComponent();
        }

        public UCOrganizationAll(MDataSet source)
        {
            InitializeComponent();
            organizationBindingSource.DataSource = source.Organization;
            _changes = new DataView(source.Organization,null,null,DataViewRowState.ModifiedCurrent);
        }
        private bool SaveChange()
        {
            DataTable dt = (this.organizationBindingSource.DataSource as DataTable);

            if (dt.GetChanges() != null)
            {
               
               

                    /*сохранить удаление*/
                    (this.ParentForm as MainForm).SaveToBaseDirectoryDeleted(dt.Select(null, null, DataViewRowState.Deleted));

                    /*сохранить изменени€*/

                    (this.ParentForm as MainForm).SaveToBaseDirectoryModifed(dt.Select(null, null, DataViewRowState.ModifiedCurrent));
                    DataTable tbChahges1 = dt.GetChanges(DataRowState.Modified);
                    /*сохранить добавлени€*/
                    (this.ParentForm as MainForm).SaveToBaseDirectoryModifed(dt.Select(null, null, DataViewRowState.Added));

                    (this.organizationBindingSource.DataSource as DataTable).AcceptChanges();

               
               
            }

            return true;
        }
        private bool CancelChanges()
        {
            (this.organizationBindingSource.DataSource as DataTable).RejectChanges();
            return true;
        }

        private void gridView_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            this.gridViewOrgns.SetColumnError(this.gridViewOrgns.Columns[1], e.ErrorText.ToString());
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;

        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            int hendl = (this.grid.FocusedView as ColumnView).FocusedRowHandle;

            if (this.gridViewOrgns.IsValidRowHandle(hendl) & hendl != DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
            {
                MDataSet.OrganizationRow OrganizationRow = (organizationBindingSource.DataSource as MDataSet.OrganizationDataTable).FindByID(((int)this.gridViewOrgns.GetFocusedRowCellValue(this.colID)));

                FormDialog dform = new FormDialog();

                dform.panel.Controls.Add(new UCOrganizationRow(OrganizationRow, MainForm.ActionDialog.Edit) );

                if (DialogResult.OK == dform.ShowDialog(this))
                {
                    this.organizationBindingSource.EndEdit();

                 
                    this.btSave.Enabled = true;

                }
                else
                {
                    OrganizationRow.RejectChanges();
                }
                

            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            MDataSet.OrganizationRow OrganizationRow = (organizationBindingSource.AddNew() as DataRowView).Row as MDataSet.OrganizationRow;

           FormDialog dform = new FormDialog();

            dform.panel.Controls.Add(new UCOrganizationRow(OrganizationRow, MainForm.ActionDialog.Edit));

            if (DialogResult.OK == dform.ShowDialog(this))
            {
                this.organizationBindingSource.EndEdit();
           
                this.btSave.Enabled = true;

            }
            else
            {
                organizationBindingSource.CurrencyManager.CancelCurrentEdit();
           
            }
           
        }

        private void btSave_Click(object sender, EventArgs e)
        {
    
          

            if (this.gridViewOrgns.HasColumnErrors) return;

            this.btEdit.Enabled = true;
            this.btSave.Enabled = false;
            this.gridViewOrgns.OptionsBehavior.Editable = false;


            if (this.SaveChange())
            {
              
                this.btSave.Enabled = false;

            }
            else
            {
               
                this.btSave.Enabled = true;
                this.gridViewOrgns.OptionsBehavior.Editable = true;
            }

        }

        private void btDel_Click(object sender, EventArgs e)
        {
            int hendl = (this.grid.FocusedView as ColumnView).FocusedRowHandle;

            if (this.gridViewOrgns.IsValidRowHandle(hendl) & hendl != DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
            {
                int countChild = 0;


                DataRow[] arrRows;
                DataRow mrow = (this.grid.FocusedView as ColumnView).GetDataRow(hendl);

                foreach (DataRelation relation in (this.organizationBindingSource.DataSource as DataTable).ChildRelations)
                {

                    if (mrow.GetChildRows(relation) != null)
                    {
                        arrRows = mrow.GetChildRows(relation);

                        countChild += arrRows.Length;
                    }

                }

                if (countChild != 0)

                    MessageBox.Show("Ќевозможно удалить запись, ссылок на нее :  " + countChild.ToString());
                else

                    if (MessageBox.Show(" ”далить запись? " + this.gridViewOrgns.GetFocusedRowCellDisplayText(this.gridViewOrgns.Columns[1]), "”даление карточки",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                         == DialogResult.Yes)
                    {
                        this.grid.EmbeddedNavigator.Buttons.Remove.DoClick();
                        this.btSave.Enabled = true;
                    }
            }

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.grid.EmbeddedNavigator.Buttons.EndEdit.DoClick();

            if (this.gridViewOrgns.HasColumnErrors)
            {
                this.organizationBindingSource.CancelEdit();
            }
            foreach (GridView view in this.grid.ViewCollection)
            {
                string fileName = new FileInfo(Application.ExecutablePath).DirectoryName + "\\" + view.Name.ToString() + ".xml";
                view.SaveLayoutToXml(fileName);

            }
            if (_changes.Count > 0)
            {
                
                   
                        DialogResult result;
                        result = MessageBox.Show(this, "—охранить изменени€?", "–едактирование справочника", MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                        switch (result)
                        {
                            case DialogResult.Yes:

                                if ((this.SaveChange()))
                                {
                                    if ((this.ParentForm as MainForm) != null)
                                        (this.ParentForm as MainForm).DeleteDataTab(this.Parent as TabPage);

                                }
                                break;
                            case DialogResult.No:
                                if (this.CancelChanges())
                                    if ((this.ParentForm as MainForm) != null)
                                        (this.ParentForm as MainForm).DeleteDataTab(this.Parent as TabPage);
                                break;
                            case DialogResult.Cancel:
                                break;


                    }
            }
                    else
                        if ((this.ParentForm as MainForm) != null)
                            (this.ParentForm as MainForm).DeleteDataTab(this.Parent as TabPage);

                

            

           
           
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            this.btEdit.PerformClick();
        }

        private void btField_Click(object sender, EventArgs e)
        {
            (this.grid.FocusedView as GridView).ColumnsCustomization();
            
        }

        private void UCOrganizationAll_Load(object sender, EventArgs e)
        {
            foreach (GridView view in this.grid.ViewCollection)
            {
                string fileName = new FileInfo(Application.ExecutablePath).DirectoryName + "\\" + view.Name.ToString() + ".xml";
                if (File.Exists(fileName))
                    view.RestoreLayoutFromXml(fileName);
            } 
        }
        
    }
}
