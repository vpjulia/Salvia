using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;

namespace RetailTrade
{
    public partial class UCSimpleDirectory : UserControl
    {
        DataView _changes;

        public UCSimpleDirectory()
        {
            InitializeComponent();
        }

        public UCSimpleDirectory(DataTable source)
        {
            InitializeComponent();
                      
            this.bindingSource.DataSource=source;
            this.grid.DataSource = this.bindingSource;

            _changes = new DataView(source, null, null, DataViewRowState.Added | DataViewRowState.Deleted | DataViewRowState.ModifiedCurrent);
            _changes.ListChanged+=new ListChangedEventHandler(_changes_ListChanged);


            this.Validating+=new CancelEventHandler(UCSimpleDirectory_Validating);
        }

        private MainForm FindMainForm(Form sender)
        {
            if ((sender as MainForm) != null)
                return (sender as MainForm);
            else
                return FindMainForm(sender.Owner);
        }

        private void UCSimpleDirectory_Validating(object sender,CancelEventArgs e )
        {
            if (this.ValidateChildren())
            {
                if ((this.bindingSource.DataSource as DataTable).HasErrors)
                {
                    MessageBox.Show("Error");
                }
                if (_changes.Count > 0)
                {
                    DialogResult result;
                    result = MessageBox.Show(this, "Сохранить изменения?", "Редактирование справочника", MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                    switch (result)
                    {
                        case DialogResult.Yes:

                            if (!this.SaveChange())
                                e.Cancel = true;

                            break;
                        case DialogResult.No:
                            if (!this.CancelChanges())
                                e.Cancel = true;
                            break;
                        case DialogResult.Cancel:
                            e.Cancel = true;

                            break;
                    }
                }
            }
            else e.Cancel = true;

        }

        private void _changes_ListChanged(object sender, ListChangedEventArgs e )
        {
            if ((_changes.Count > 0))
            {
                this.btSave.Visible = true;
                this.btCancel.Visible = true;
                this.btEdit.Visible = false;
            }
            else
            {
                this.btSave.Visible = false;
                this.btCancel.Visible = false;
                this.btEdit.Visible = true;
            
            }

        }

        private bool SaveChange ()
        {
            this.bindingSource.EndEdit();

            if (!this.gridView.HasColumnErrors)
            {

               DataTable dt = (this.bindingSource.DataSource as DataTable);

                if (dt.GetChanges() != null)
                {
                         MainForm _mainForm = FindMainForm(this.ParentForm);
                        _mainForm.SaveToBaseDirectoryDeleted(dt.Select(null, null, DataViewRowState.Deleted));

                        /*сохранить изменения*/

                        _mainForm.SaveToBaseDirectoryModifed(dt.Select(null, null, DataViewRowState.ModifiedCurrent));

                        /*сохранить добавления*/
                        _mainForm.SaveToBaseDirectoryModifed(dt.Select(null, null, DataViewRowState.Added));

                        dt.AcceptChanges();

                        return true;

                    }
           
            }
            else
                return false;

        return true;
        }

        private bool CancelChanges()
        {
            (this.bindingSource.DataSource as DataTable).RejectChanges();
            return true;
        }
        
        private void gridView_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            this.gridView.SetColumnError(this.gridView.Columns[1], e.ErrorText.ToString());
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;

        }

        private void grid_Validating(object sender, CancelEventArgs e)
        {
            if (this.gridView.HasColumnErrors)
                e.Cancel = true;
            else

        if (this.gridView.FocusedRowHandle == DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
            {
                this.gridView.FocusedRowHandle = 0;
                e.Cancel = true;
            }
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
            this.btEdit.Visible = false;
            this.btSave.Visible= true;
            this.btDelete.Visible = true;
            this.btAdd.Visible = true;

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

                   MessageBox.Show("Невозможно удалить запись, ссылок на нее :  " + countChild.ToString(),"Удаление записи", MessageBoxButtons.OK, MessageBoxIcon.Error);
               else

                   if (MessageBox.Show(" Удалить запись? ", "Удаление записи",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                        == DialogResult.Yes)
                   {
                       this.grid.EmbeddedNavigator.Buttons.Remove.DoClick();
                       this.btSave.Enabled = true;
                   }
           }
           }

        private void btGridField_Click(object sender, EventArgs e)
        {
            this.gridView.ColumnsCustomization();
        }


        private void grid_DoubleClick(object sender, EventArgs e)
        {if  (this.ParentForm.ToString()=="FormDialog")
            (this.ParentForm as FormDialog).AcceptButton.PerformClick();
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            this.btEdit.PerformClick();
        }


        private void grid_EditorKeyDown(object sender, KeyEventArgs e)
        {
            if((e.KeyCode==Keys.Enter)&(this.gridView.State==GridState.Normal)) 
                (this.ParentForm as FormDialog).AcceptButton.PerformClick();
        }

    
        private void btRefresh_Click(object sender, EventArgs e)
        {
             FindMainForm(this.ParentForm).FillTable((this.bindingSource.DataSource as DataTable).TableName);
        }

           
        private void btClose_Click(object sender, EventArgs e)
        {
            this.bindingSource.EndEdit();

          
            if (_changes.Count>0)
            {
                DialogResult result;
                result = MessageBox.Show(this, "Сохранить изменения?", "Редактирование справочника", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                switch (result)
                {
                    case DialogResult.Yes :
              
                    if ((this.SaveChange()))
                    {
                        if ((this.ParentForm as MainForm) != null)
                            (this.ParentForm as MainForm).tabControl.TabPages.Remove((this.ParentForm as MainForm).tabControl.SelectedTab);
                    }
                    break;
                    case DialogResult.No :
                       if ( this.CancelChanges())
                            if ((this.ParentForm as MainForm) != null)
                                (this.ParentForm as MainForm).tabControl.TabPages.Remove((this.ParentForm as MainForm).tabControl.SelectedTab);
                        break;
                    case DialogResult.Cancel:
                        break;

                }
             
            }
            else
                if ((this.ParentForm as MainForm) != null)
                    (this.ParentForm as MainForm).tabControl.TabPages.Remove((this.ParentForm as MainForm).tabControl.SelectedTab);
                 
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.bindingSource.CancelEdit();
            this.CancelChanges();
        }

        private void gridView_InvalidValueException(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            MessageBox.Show("Поймали " + e.ErrorText);
        }

        private void bindingSource_DataError(object sender, BindingManagerDataErrorEventArgs e)
        {
            MessageBox.Show("Поймали bindingSource_DataError");
        }

   
        }
    }

