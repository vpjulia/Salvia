using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;

namespace RetailTrade
{
    public partial class UCOrganizationAll : UserControl
    {
        public UCOrganizationAll()
        {
            InitializeComponent();
        }

        public UCOrganizationAll(MDataSet source)
        {
            InitializeComponent();
            organizationBindingSource.DataSource = source.Organization;
            
        }
        private bool SaveChange()
        {
            DataTable dt = (this.organizationBindingSource.DataSource as DataTable);

            if (dt.GetChanges() != null)
            {
                FormDialog fInf = new FormDialog();
                Information infcontr = new Information();
                infcontr.Dock = DockStyle.Fill;

                DataTable tbChahgesAdd = dt.GetChanges(DataRowState.Added);
                if (tbChahgesAdd != null)
                    foreach (DataRow frRow in tbChahgesAdd.Rows)
                        infcontr.listBoxInf.Items.Add("Добавить " + "'" + frRow[1, DataRowVersion.Current].ToString() + "'");


                DataTable tbChahges = dt.GetChanges(DataRowState.Modified);
                if (tbChahges != null)
                    foreach (DataRow frRow in tbChahges.Rows)
                        infcontr.listBoxInf.Items.Add("Изменить   " + "'" + frRow[1, DataRowVersion.Original].ToString()+"'");


                DataTable tbChahgesDel = dt.GetChanges(DataRowState.Deleted);
                if (tbChahgesDel != null)
                    foreach (DataRow frRow in tbChahgesDel.Rows)
                        infcontr.listBoxInf.Items.Add("Удалить   " + "'" + frRow[1, DataRowVersion.Original].ToString() + "'");

                fInf.Size = new System.Drawing.Size((Screen.PrimaryScreen.WorkingArea.Width / 3), (Screen.PrimaryScreen.WorkingArea.Height / 2));

                fInf.panel.Controls.Add(infcontr);

                if (DialogResult.OK == fInf.ShowDialog(this.ParentForm))
                {

                    /*сохранить удаление*/
                    (this.ParentForm as MainForm).SaveToBaseDirectoryDeleted(dt.Select(null, null, DataViewRowState.Deleted));

                    /*сохранить изменения*/

                    (this.ParentForm as MainForm).SaveToBaseDirectoryModifed(dt.Select(null, null, DataViewRowState.ModifiedCurrent));
                    DataTable tbChahges1 = dt.GetChanges(DataRowState.Modified);
                    /*сохранить добавления*/
                    (this.ParentForm as MainForm).SaveToBaseDirectoryModifed(dt.Select(null, null, DataViewRowState.Added));

                    (this.organizationBindingSource.DataSource as DataTable).AcceptChanges();


                }
                else return false;
            }

            return true;
        }
        private void gridView_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            this.gridView.SetColumnError(this.gridView.Columns[1], e.ErrorText.ToString());
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;

        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            int hendl = (this.grid.FocusedView as ColumnView).FocusedRowHandle;

            if (this.gridView.IsValidRowHandle(hendl) & hendl != DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
            {
                MDataSet.OrganizationRow OrganizationRow = (organizationBindingSource.DataSource as MDataSet.OrganizationDataTable).FindByID(((int)this.gridView.GetFocusedRowCellValue(this.colID)));

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
    
          

            if (this.gridView.HasColumnErrors) return;

            this.btEdit.Enabled = true;
            this.btSave.Enabled = false;
            this.gridView.OptionsBehavior.Editable = false;


            if (this.SaveChange())
            {
              
                this.btSave.Enabled = false;

            }
            else
            {
               
                this.btSave.Enabled = true;
                this.gridView.OptionsBehavior.Editable = true;
            }

        }

        private void btDel_Click(object sender, EventArgs e)
        {
            int hendl = (this.grid.FocusedView as ColumnView).FocusedRowHandle;

            if (this.gridView.IsValidRowHandle(hendl) & hendl != DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
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

                    MessageBox.Show("Невозможно удалить запись, ссылок на нее :  " + countChild.ToString());
                else

                    if (MessageBox.Show(" Удалить запись? " + this.gridView.GetFocusedRowCellDisplayText(this.gridView.Columns[1]), "Удаление карточки",
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

            if (this.gridView.HasColumnErrors)
            {
                this.organizationBindingSource.CancelEdit();
            }
            else if (this.SaveChange())
            {
                if ((this.ParentForm as MainForm) != null)
                    (this.ParentForm as MainForm).tabControl.TabPages.Remove((this.ParentForm as MainForm).tabControl.SelectedTab);

            }
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            this.btEdit.PerformClick();
        }
        
    }
}
