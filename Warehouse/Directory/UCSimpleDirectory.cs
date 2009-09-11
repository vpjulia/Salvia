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
using DevExpress.XtraGrid;
using System.IO;

namespace RetailTrade
{
    public partial class UCSimpleDirectory : UserControl
    {
        DataView _changes;
        int _currentInParent;
        bool _layoutChanged;

        public UCSimpleDirectory()
        {
            InitializeComponent();
        }

        public UCSimpleDirectory(DataTable source)
        {
            InitializeComponent();
                      
            //this.bindingSource.DataSource=source;
            this.bindingSource.DataSource = new DataView(source, "ID<>0", null, DataViewRowState.CurrentRows);

            this.grid.DataSource = this.bindingSource;

            _changes = new DataView(source, "ID<>0", null, DataViewRowState.Added | DataViewRowState.Deleted | DataViewRowState.ModifiedCurrent);
            _changes.ListChanged+=new ListChangedEventHandler(_changes_ListChanged);


            this.Validating+=new CancelEventHandler(UCSimpleDirectory_Validating);
           
        }

        public UCSimpleDirectory(DataTable source,int _current )
        {
            InitializeComponent();

           // this.bindingSource.DataSource = source;
            this.bindingSource.DataSource = new DataView(source, "ID<>0", null, DataViewRowState.CurrentRows);

            
            this.grid.DataSource = this.bindingSource;
            _currentInParent = _current;
            _changes = new DataView(source, "ID<>0", null, DataViewRowState.Added | DataViewRowState.Deleted | DataViewRowState.ModifiedCurrent);
            _changes.ListChanged += new ListChangedEventHandler(_changes_ListChanged);

            this.errorProvider1.DataSource = source;
            this.errorProvider1.UpdateBinding();
          
            this.Validating += new CancelEventHandler(UCSimpleDirectory_Validating);
            this.bindingSource.CurrencyManager.Position = this.bindingSource.Find("ID", _currentInParent);
        
        }
 
        private MainForm FindMainForm(Form sender)
        {
            if ((sender as MainForm) != null)
                return (sender as MainForm);
            else
                return FindMainForm(sender.Owner);
        }

        private void UCSimpleDirectory_Load(object sender, EventArgs e)
        {
            foreach (GridView view in this.grid.ViewCollection)
            {
                string fileName = new FileInfo(Application.ExecutablePath).DirectoryName + "\\" + view.Name.ToString() + ".xml";
                if (File.Exists(fileName))
                    view.RestoreLayoutFromXml(fileName);
            } 
            _layoutChanged = false;
            this.bindingSource.CurrencyManager.Position = this.bindingSource.Find("ID", _currentInParent);
            this.ParentForm.FormClosing += new FormClosingEventHandler(ParentForm_FormClosing);
        }

       
        private void _changes_ListChanged(object sender, ListChangedEventArgs e )
        {
            if ((_changes.Count > 0))
            {
                this.btSave.Visible = true;
                this.btCancel.Visible = true;
                this.btEdit.Visible = false;
                this.btDelete.Visible = true;
            }
            else
            {
                this.btSave.Visible = false;
                this.btCancel.Visible = false;
                this.btEdit.Visible = true;
                this.btDelete.Visible = false;
            
            }

        }

        private void UCSimpleDirectory_Validating(object sender,CancelEventArgs e )
        {
            this.grid.EmbeddedNavigator.Buttons.EndEdit.DoClick();

            if (this.ValidateChildren())
            {
                if (_changes.Table.HasErrors)
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

        private void gridView_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            this.gridView.SetColumnError(this.gridView.Columns[1], e.ErrorText.ToString());
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;

        }

        private void grid_Validating(object sender, CancelEventArgs e)
        {
          //  this.bindingSource.EndEdit();
          
            this.grid.EmbeddedNavigator.Buttons.EndEdit.DoClick();

            if (this.gridView.HasColumnErrors)
                e.Cancel = true;
            else

        if (this.gridView.FocusedRowHandle == DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
            {
                this.gridView.FocusedRowHandle = 0;
                e.Cancel = true;
            }

     

        }
   
        private void grid_EditorKeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) & (this.gridView.State == GridState.Normal))
                (this.ParentForm as FormDialog).AcceptButton.PerformClick();
        }
    

        private bool SaveChange ()
        {
            this.bindingSource.EndEdit();

            if (!this.gridView.HasColumnErrors)
            {

                 if (_changes.Count>0)
                {
                         MainForm _mainForm = FindMainForm(this.ParentForm);
                        _mainForm.SaveToBaseDirectoryDeleted(_changes.Table.Select(null, null, DataViewRowState.Deleted));

                        /*сохранить изменения*/

                        _mainForm.SaveToBaseDirectoryModifed(_changes.Table.Select(null, null, DataViewRowState.ModifiedCurrent));

                        /*сохранить добавления*/
                        _mainForm.SaveToBaseDirectoryModifed(_changes.Table.Select(null, null, DataViewRowState.Added));

                      


                        _mainForm.RefreshData(_mainForm.mDataSet.Tables[_changes.Table.TableName]);

                        this.gridView.OptionsBehavior.Editable = true;  
                     return true;

                    }
           
            }
            else
                return false;

        return true;
        }

        private bool CancelChanges()
        {
           // (this.bindingSource.DataSource  as DataTable).RejectChanges();
            _changes.Table.RejectChanges();
            this.btCancel.Visible = false;
            this.btSave.Visible = false;
            return true;
        }
        


        private void btAdd_Click(object sender, EventArgs e)
        {
             
            //  this.grid.EmbeddedNavigator.Buttons.Append.DoClick();
            this.bindingSource.AddNew();  
            this.gridView.SetFocusedValue("[]");
             // this.btEdit.PerformClick();
           // this.gridView.sek  
            this.btCancel.Visible = true;
          }

        private void btEdit_Click(object sender, EventArgs e)
        {

            this.gridView.OptionsBehavior.Editable = true;
            this.grid.EmbeddedNavigator.Buttons.Edit.DoClick();
            this.btEdit.Visible = false;
            this.btDelete.Visible = true;
            this.btAdd.Visible = true;

        }

        private void btSave_Click(object sender, EventArgs e)
        {

            this.grid.EmbeddedNavigator.Buttons.EndEdit.DoClick();

            if (this.gridView.HasColumnErrors) return;

        
            this.gridView.OptionsBehavior.Editable = false;

            this.SaveChange();
        
            

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
            this.gridView.CustomizationForm.TopMost = true;
        }

       

        private void gridView_DoubleClick(object sender, EventArgs e)
        { 
            if (this.gridView.Editable==true)
            {
                this.btEdit.PerformClick();       
        
            }
            else
                if ((this.ParentForm as FormDialog)!=null)
                
                    (this.ParentForm as FormDialog).AcceptButton.PerformClick();
       
        }

      
        private void btRefresh_Click(object sender, EventArgs e)
        {
             FindMainForm(this.ParentForm).FillTable((this.bindingSource.DataSource as DataTable).TableName);
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

    
        private void toolStripButton1_Click(object sender, EventArgs e)
        {

         this.bindingSource.CurrencyManager.Position=this.bindingSource.Find("ID",_currentInParent);
            
            /*this.gridView.BeginUpdate();
            int rowHandle = this.gridView.LocateByValue(0, this.colID, _currentInParent);

            if (rowHandle != GridControl.InvalidRowHandle)
            {
                gridView.FocusedRowHandle = rowHandle;
                gridView.FocusedColumn = gridView.Columns["Name"];
            }
            this.gridView.EndUpdate();*/
        }

 
        private void btClose_Click(object sender, EventArgs e)
        {
            
            // this.bindingSource.EndEdit();


            if (_layoutChanged)
            {
                foreach (GridView view in this.grid.ViewCollection)
                {
                    string fileName = new FileInfo(Application.ExecutablePath).DirectoryName + "\\" + view.Name.ToString() + ".xml";
                    view.SaveLayoutToXml(fileName);

                }
            }

            if (this.ValidateChildren())
            {

                if (_changes.Count > 0)
                {
                    DialogResult result;
                    result = MessageBox.Show(this, "Сохранить изменения?", "Редактирование справочника", MessageBoxButtons.YesNoCancel,
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
        }

        private void ParentForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            this.bindingSource.CurrencyManager.CancelCurrentEdit();
            if (_layoutChanged)
            {
                foreach (GridView view in this.grid.ViewCollection)
                {
                    string fileName = new FileInfo(Application.ExecutablePath).DirectoryName + "\\" + view.Name.ToString() + ".xml";
                    view.SaveLayoutToXml(fileName);

                }
            }
            if (_changes.Count > 0)
            {
                DialogResult result;
                result = MessageBox.Show(this, "Сохранить изменения?", "Редактирование справочника", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                switch (result)
                {
                    case DialogResult.Yes:

                        if (!(this.SaveChange()))
                        {
                            e.Cancel = true;
                         }
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

        private void gridView_Layout(object sender, EventArgs e)
        {
            _layoutChanged = true;
        }


   
        }
    }

