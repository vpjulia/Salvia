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
        DataView _changes;

        public UcGroupDirectory()
        {
            InitializeComponent();
        }
        public UcGroupDirectory(DataTable source)
        {
            InitializeComponent();

            this.bindingSource.DataSource =new DataView(source,"ID<>0",null,DataViewRowState.CurrentRows);
            this.grid.DataSource = this.bindingSource;
            this.colGroupRef.FieldName =source.Columns[2].ColumnName;
            if  (source.ParentRelations.Count>0)
            _changes = new DataView(source, null, null, DataViewRowState.Added | DataViewRowState.Deleted | DataViewRowState.ModifiedCurrent);
            _changes.ListChanged += new ListChangedEventHandler(_changes_ListChanged);

     

           this.LookUpEdit.DataSource=source.ParentRelations[0].ParentTable;
        }

        private MainForm FindMainForm(Form sender)
        { 
             if ((sender as MainForm)!=null)
            return (sender as MainForm);
            else 
               return  FindMainForm (sender.Owner); 
        }
  
        private bool SaveChange()
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

                    _mainForm.RefreshData(_changes.Table);

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

        private void UcGroupDirectory_Load(object sender, EventArgs e)
        {
            this.ParentForm.FormClosing += new FormClosingEventHandler(ParentForm_FormClosing);


        }

       
        private void _changes_ListChanged(object sender, ListChangedEventArgs e)
        {
            if ((_changes.Count > 0))
            {
               this.btEdit.Visible = false;
               this.btAdd.Visible = true;
               this.btSave.Visible = true;
               this.btCancel.Visible = true;
               this.btDel.Visible = true;
               this.btViewDict.Visible = true;
            }
            else
            {
                this.btSave.Visible = false;
                this.btAdd.Visible = false;
                this.btCancel.Visible = false;
                this.btEdit.Visible = true;
                this.btDel.Visible = false;
                this.btViewDict.Visible = false;
                this.gridView.OptionsBehavior.Editable = false;
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
           
            this.btCancel.Visible = true;
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            this.gridView.OptionsBehavior.Editable = true;
            this.grid.EmbeddedNavigator.Buttons.Edit.DoClick();
            this.btEdit.Visible = false;
  
            this.btDel.Visible = true;
            this.btViewDict.Visible = true;
            this.btAdd.Visible = true;

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

                    MessageBox.Show("Невозможно удалить запись, ссылок на нее :  " + countChild.ToString(),"Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else

                    if (MessageBox.Show(" Удалить запись? " , "Удаление записи",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                         == DialogResult.Yes)
                    {
                        this.grid.EmbeddedNavigator.Buttons.Remove.DoClick();
                        this.btSave.Enabled = true;
                    }
            }


        }

     
        private void btSave_Click(object sender, EventArgs e)
        {
            this.grid.EmbeddedNavigator.Buttons.EndEdit.DoClick();

            if (this.gridView.HasColumnErrors) return;
 
            this.gridView.OptionsBehavior.Editable = false;
 
            if (this.SaveChange())
            {
                this.btEdit.Visible = false;
            }
            else
            {
                this.btEdit.Visible = true;       
                this.gridView.OptionsBehavior.Editable = true;
            }

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.bindingSource.CancelEdit();
            this.CancelChanges();
        }


        private void btViewDict_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                FormDialog dform = new FormDialog();
                dform.Text = "Справочник : группы";

                UCSimpleDirectory ucSimpleDirectory = new UCSimpleDirectory((this.bindingSource.DataSource as DataView).Table.ParentRelations[0].ParentTable);

                dform.panel.Controls.Add(ucSimpleDirectory);


                if (DialogResult.OK == dform.ShowDialog(this))
                {
                    MessageBox.Show(ucSimpleDirectory.gridView.GetDataRow(ucSimpleDirectory.gridView.GetSelectedRows()[0])["ID"].ToString());
                    //  (this.Controls.Find((sender as Button).Tag.ToString() + "lookUpEdit", true)[0] as DevExpress.XtraEditors.LookUpEdit).EditValue = ucSimpleDirectory.gridView.GetDataRow(ucSimpleDirectory.gridView.GetSelectedRows()[0])["ID"];
                }
            }
        }


        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            if (this.gridView.Editable == true)
            {
                this.btEdit.PerformClick();

            }
            else
                if ((this.ParentForm as FormDialog) != null)

                    (this.ParentForm as FormDialog).AcceptButton.PerformClick();
       
        }

        private void btField_Click(object sender, EventArgs e)
        {
            this.gridView.ColumnsCustomization();
            this.gridView.CustomizationForm.TopMost = true;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
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
                                (this.ParentForm as MainForm).tabControl.TabPages.Remove((this.ParentForm as MainForm).tabControl.SelectedTab);
                        }
                        break;
                    case DialogResult.No:
                        if (this.CancelChanges())
                            if ((this.ParentForm as MainForm) != null)
                                (this.ParentForm as MainForm).tabControl.TabPages.Remove((this.ParentForm as MainForm).tabControl.SelectedTab);
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;

                }

            }
        }

        private void UcGroupDirectory_Validating(object sender, CancelEventArgs e)
        {
            this.bindingSource.EndEdit();

            if (!this.gridView.HasColumnErrors)
            {
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
                            e.Cancel=true;
                            break;

                    }

                }
                
            }
        
        else  
            {
               e.Cancel=true;
            }
        }

    }
}
