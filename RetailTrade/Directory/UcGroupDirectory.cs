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
    public partial class UcGroupDirectory : UserControl
    {

        public UcGroupDirectory()
        {
            InitializeComponent();
        }
        public UcGroupDirectory(DataTable source)
        {
            InitializeComponent();

            this.bindingSource.DataSource = source;
            this.grid.DataSource = this.bindingSource;
           this.colGroupRef.FieldName =source.Columns[2].ColumnName;
            if  (source.ParentRelations.Count>0)
              
           this.LookUpEdit.DataSource=source.ParentRelations[0].ParentTable;
        }

        private bool SaveChange()
        {
            DataTable dt = (this.bindingSource.DataSource as DataTable);

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
                        infcontr.listBoxInf.Items.Add("Изменить   " + "'" + frRow[1, DataRowVersion.Original].ToString() + "' на " + " '" + frRow[1, DataRowVersion.Current].ToString() + "'");


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

                    (this.bindingSource.DataSource as DataTable).AcceptChanges();  


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

        private void btAdd_Click(object sender, EventArgs e)
        {
            this.grid.EmbeddedNavigator.Buttons.Append.DoClick();
            this.btEdit.PerformClick();
        
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            this.gridView.OptionsBehavior.Editable = true;
            this.grid.EmbeddedNavigator.Buttons.Edit.DoClick();
            this.btEdit.Enabled = false;
            this.btSave.Enabled = true;
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            int hendl = (this.grid.FocusedView as ColumnView).FocusedRowHandle;

            if (this.gridView.IsValidRowHandle(hendl) & hendl != DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
            {
                int countChild = 0;


                DataRow[] arrRows;
                DataRow mrow = (this.grid.FocusedView as ColumnView).GetDataRow(hendl);

                foreach (DataRelation relation in (this.bindingSource.DataSource as DataTable).ChildRelations)
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
                this.bindingSource.CancelEdit();
            }
            else if (this.SaveChange())
            {
                if ((this.ParentForm as MainForm) != null)
                    (this.ParentForm as MainForm).tabControl.TabPages.Remove((this.ParentForm as MainForm).tabControl.SelectedTab);

            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            this.grid.EmbeddedNavigator.Buttons.EndEdit.DoClick();

            if (this.gridView.HasColumnErrors) return;

            this.btEdit.Enabled = true;
            this.btSave.Enabled = false;
            this.gridView.OptionsBehavior.Editable = false;


            if (this.SaveChange())
            {
                this.btEdit.Enabled = true;
                this.btSave.Enabled = false;

            }
            else
            {
                this.btEdit.Enabled = false;
                this.btSave.Enabled = true;
                this.gridView.OptionsBehavior.Editable = true;
            }

        }

    }
}
