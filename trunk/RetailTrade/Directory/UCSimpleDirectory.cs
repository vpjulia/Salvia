using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace RetailTrade
{
    public partial class UCSimpleDirectory : UserControl
    {
        public UCSimpleDirectory()
        {
            InitializeComponent();
        }

        public UCSimpleDirectory(DataTable source)
        {
            InitializeComponent();
                      
            this.bindingSource.DataSource=source;
            this.grid.DataSource = this.bindingSource;
        }


        private bool SaveChange ()
        { 
             DataTable dt = (this.bindingSource.DataSource as DataTable);

            if (dt.GetChanges()!= null)
            {
               FormDialog fInf = new FormDialog();
               Information infcontr = new Information();
               infcontr.Dock = DockStyle.Fill;

              DataTable tbChahgesAdd = dt.GetChanges(DataRowState.Added);
              if (tbChahgesAdd != null)
                  foreach (DataRow frRow in tbChahgesAdd.Rows)
                      infcontr.listBoxInf.Items.Add("Добавить " + "'" + frRow[1, DataRowVersion.Current].ToString()+ "'");
          

               DataTable tbChahges = dt.GetChanges(DataRowState.Modified);
               if (tbChahges!=null)
                  foreach(DataRow frRow in tbChahges.Rows)
                      infcontr.listBoxInf.Items.Add("Изменить   " + "'" + frRow[1, DataRowVersion.Original].ToString() + "' на " + " '" + frRow[1, DataRowVersion.Current].ToString() + "'");


              DataTable tbChahgesDel = dt.GetChanges(DataRowState.Deleted);
              if (tbChahgesDel != null)
                  foreach (DataRow frRow in tbChahgesDel.Rows)
                      infcontr.listBoxInf.Items.Add("Удалить   " + "'" + frRow[1, DataRowVersion.Original].ToString() + "'");

                fInf.Size = new System.Drawing.Size((Screen.PrimaryScreen.WorkingArea.Width / 3), (Screen.PrimaryScreen.WorkingArea.Height/2));
              
                 fInf.panel.Controls.Add(infcontr);

                 if (DialogResult.OK == fInf.ShowDialog(this.ParentForm))
                 {  /*сохранить удаление*/
                     (this.ParentForm as MainForm).SaveToBaseDirectoryDeleted(dt.Select(null, null, DataViewRowState.Deleted));
                  
                     /*сохранить изменения*/ 
                     
                     (this.ParentForm as MainForm).SaveToBaseDirectoryModifed(dt.Select(null, null, DataViewRowState.ModifiedCurrent));
                      
                       /*сохранить добавления*/
                     (this.ParentForm as MainForm).SaveToBaseDirectoryModifed(dt.Select(null, null, DataViewRowState.Added));
    
                       

                                                      
                     dt.AcceptChanges();

                 }
                 else return false;
        }

        return true;
        }

        private void grid_Validating(object sender, CancelEventArgs e)
        {
           if (this.gridView.FocusedRowHandle == DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
            {
                this.gridView.FocusedRowHandle = 0;
                e.Cancel = true;
            }
        }


        private void btEdit_Click(object sender, EventArgs e)
        {

            this.gridView.OptionsBehavior.Editable = true;
            this.grid.EmbeddedNavigator.Buttons.Edit.DoClick();
            this.btEdit.Enabled = false;
            this.btSave.Enabled = true;

        }

        private void bindingSource_CurrentChanged(object sender, EventArgs e)
        {
          //  this.btEdit.Enabled = true;
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

            {        this.btEdit.Enabled = true;
                     this.btSave.Enabled = false;

                 }
                 else
                 {
                     this.btEdit.Enabled = false;
                     this.btSave.Enabled = true;
                     this.gridView.OptionsBehavior.Editable = true;
                 }

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

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            this.grid.EmbeddedNavigator.Buttons.Append.DoClick();
        
        }

        private void grid_DoubleClick(object sender, EventArgs e)
        {if  (this.ParentForm.ToString()=="FormDialog")
            (this.ParentForm as FormDialog).AcceptButton.PerformClick();
        }

        private void grid_EditorKeyDown(object sender, KeyEventArgs e)
        {
            if((e.KeyCode==Keys.Enter)&(this.gridView.State==GridState.Normal)) 
                (this.ParentForm as FormDialog).AcceptButton.PerformClick();
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
                if ((this.ParentForm as MainForm)!=null)
                (this.ParentForm as MainForm).tabControl.TabPages.Remove((this.ParentForm as MainForm).tabControl.SelectedTab);

            }
           

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
          
           int hendl = (this.grid.FocusedView as ColumnView).FocusedRowHandle;

           if (this.gridView.IsValidRowHandle(hendl) & hendl != DevExpress.XtraGrid.GridControl.AutoFilterRowHandle )
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

        private void UCSimpleDirectory_Validated(object sender, EventArgs e)
        {
             if (this.SaveChange())

            {        this.btEdit.Enabled = true;
                     this.btSave.Enabled = false;

                 }
                 else
                 {
                     this.btEdit.Enabled = false;
                     this.btSave.Enabled = true;
                     this.gridView.OptionsBehavior.Editable = true;
                 }

            }

        private void UCSimpleDirectory_Validating(object sender, CancelEventArgs e)
        {
            MessageBox.Show("UCSimpleDirectory_Validating");
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            (this.ParentForm as MainForm).FillTable((this.bindingSource.DataSource as DataTable).TableName);
        }

        private void btGridField_Click(object sender, EventArgs e)
        {
            this.gridView.ColumnsCustomization();
        }

        }
    }

