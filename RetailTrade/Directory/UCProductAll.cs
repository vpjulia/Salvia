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
    public partial class UCProductAll : UserControl
    {
        public UCProductAll()
        {
            InitializeComponent();
        }
        public UCProductAll(MDataSet source)
        {
            InitializeComponent();
            productBindingSource.DataSource = source.Product; 
        }
        private void UCProductAll_Load(object sender, EventArgs e)
        {
             
        }

        private bool SaveChange()
        {
           

            DataTable dt = (this.productBindingSource.DataSource as DataTable);

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
                {  /*сохранить удаление*/
                    (this.ParentForm as MainForm).SaveToBaseDirectoryDeleted(dt.Select(null, null, DataViewRowState.Deleted));

                    /*сохранить изменения*/

                    (this.ParentForm as MainForm).SaveToBaseDirectoryModifed(dt.Select(null, null, DataViewRowState.ModifiedCurrent));

                    /*сохранить добавления*/
                    (this.ParentForm as MainForm).SaveToBaseDirectoryModifed(dt.Select(null, null, DataViewRowState.Added));




                    dt.AcceptChanges();
                    return true;
                }
                else return false;
            }
            return true;
        }

        private void btEdit_Click(object sender, EventArgs e)
        {

            int hendl = (this.grid.FocusedView as ColumnView).FocusedRowHandle;

            if (this.gridView.IsValidRowHandle(hendl) & hendl != DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
            {

                MDataSet.ProductRow pr = ((this.productBindingSource.CurrencyManager.Current as DataRowView).Row as MDataSet.ProductRow);

                FormDialog dform = new FormDialog();

                dform.panel.Controls.Add(new ucProductRow(pr, MainForm.ActionDialog.Edit));

                if (DialogResult.OK == dform.ShowDialog(this))
                {
                    this.productBindingSource.EndEdit();
                    this.btSave.Enabled = true;
                }
                else
                {
                    this.productBindingSource.CurrencyManager.CancelCurrentEdit();
                }
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            MDataSet.ProductRow ProductRow = (productBindingSource.AddNew() as DataRowView).Row as MDataSet.ProductRow;

            FormDialog dform = new FormDialog();

            dform.panel.Controls.Add(new ucProductRow(ProductRow, MainForm.ActionDialog.Edit));

            if (DialogResult.OK == dform.ShowDialog(this))
            {
                this.productBindingSource.EndEdit(); 
                this.btSave.Enabled = true;
            }
            else
            {
                productBindingSource.CurrencyManager.CancelCurrentEdit();
               
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

                foreach (DataRelation relation in (this.productBindingSource.DataSource as DataTable).ChildRelations)
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


                        /*Удаление на сервере*/

                        this.btSave.Enabled = true;
                    }
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
          this.grid.EmbeddedNavigator.Buttons.EndEdit.DoClick();

            if (this.gridView.HasColumnErrors) return;

            this.btEdit.Enabled = true;
            this.btSave.Enabled = false;
            this.gridView.OptionsBehavior.Editable = false;
           


            this.grid.EmbeddedNavigator.Buttons.EndEdit.DoClick();
        
            if (this.SaveChange())

            {      
                     this.btSave.Enabled = false;

                 }
                 else
                 {
                  
                     this.btSave.Enabled = true;
                    
                 }

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.grid.EmbeddedNavigator.Buttons.EndEdit.DoClick();

            if (this.gridView.HasColumnErrors)
            {
                this.productBindingSource.CancelEdit();
            }
            else if (this.SaveChange())
            {
                if ((this.ParentForm as MainForm) != null)
                    (this.ParentForm as MainForm).tabControl.TabPages.Remove((this.ParentForm as MainForm).tabControl.SelectedTab);

            }
        }

        private void btField_Click(object sender, EventArgs e)
        {
            this.gridView.ColumnsCustomization();
        }
    }
}
