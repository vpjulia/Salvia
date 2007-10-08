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
    public partial class UCProductAll : UserControl
    {

        DataView _changes;

        public UCProductAll()
        {
            InitializeComponent();
        }
        public UCProductAll(MDataSet source)
        {
            InitializeComponent();
            productBindingSource.DataSource = source.Product;

            _changes = new DataView(source.Product, null, null, DataViewRowState.Added | DataViewRowState.ModifiedCurrent | DataViewRowState.Deleted);
            _changes.ListChanged+=new ListChangedEventHandler(_changes_ListChanged);


        }
        private void UCProductAll_Load(object sender, EventArgs e)
        {
             
        }

        private void _changes_ListChanged(object sender,ListChangedEventArgs e ) 
        {
            if (_changes.Count > 0)
            {
                this.btSave.Visible = true;
                this.btCancel.Visible = true;

            }
            else
            {
                this.btSave.Visible = false;
                this.btCancel.Visible =false;

            }


        }

        private bool SaveChanges()
        {
           if (_changes.Count>0)
            {
                     /*сохранить удаление*/
                    (this.ParentForm as MainForm).SaveToBaseDirectoryDeleted(_changes.Table.Select(null, null, DataViewRowState.Deleted));

                    /*сохранить изменени€*/

                    (this.ParentForm as MainForm).SaveToBaseDirectoryModifed(_changes.Table.Select(null, null, DataViewRowState.ModifiedCurrent));

                    /*сохранить добавлени€*/
                    (this.ParentForm as MainForm).SaveToBaseDirectoryModifed(_changes.Table.Select(null, null, DataViewRowState.Added));
                
            }

            (this.ParentForm as MainForm).RefreshData(this.mDataSet.Product);
            return true;
        }

        private bool CancelChages()
        {
            if (this._changes.Count > 0)
            {
                foreach (DataRowView dr in _changes)
                {
                    dr.Row.RejectChanges();
                }

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
                dform.Text = " арточка товара";
                dform.panel.Controls.Add(new ucProductRow(pr, MainForm.ActionDialog.Edit));

                if (DialogResult.OK == dform.ShowDialog(this))
                {
                    this.productBindingSource.CurrencyManager.EndCurrentEdit();
                
                    
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

                    MessageBox.Show(this,"Ќевозможно удалить запись, ссылок на нее :  " + countChild.ToString(),this.Tag.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                else

                    if (MessageBox.Show(" ”далить запись? " + this.gridView.GetFocusedRowCellDisplayText(this.gridView.Columns[1]), "”даление карточки",
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

            this.btEdit.Enabled = true;
            this.btSave.Enabled = false;
            this.gridView.OptionsBehavior.Editable = false;
          
            this.grid.EmbeddedNavigator.Buttons.EndEdit.DoClick();
        
            if (this.SaveChanges())

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

            this.productBindingSource.EndEdit();

        /*    if (this.ValidateChildren())
            {
                foreach (GridView view in this.grid.ViewCollection)
                {
                    string fileName = new FileInfo(Application.ExecutablePath).DirectoryName + "\\" + view.Name.ToString() + ".xml";
                    view.SaveLayoutToXml(fileName);
                }
                // сохранить изменени€


                if (_changes.Count > 0) 
                {
                    DialogResult _result;

                    _result = MessageBox.Show("—охранить изменени€? ", "—охранение приходных документов " + this.ToString(), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    switch (_result)
                    {
                        case DialogResult.Yes:
                            if (this.SaveChanges())
                                if ((this.ParentForm as MainForm) != null)
                                    (this.ParentForm as MainForm).tabControl.TabPages.Remove((this.ParentForm as MainForm).tabControl.SelectedTab);
                            break;
                        case DialogResult.No:
                            {
                                if (this.CancelChages())
                                    if ((this.ParentForm as MainForm) != null)
                                        (this.ParentForm as MainForm).tabControl.TabPages.Remove((this.ParentForm as MainForm).tabControl.SelectedTab);
                            }
                            break;
                        case DialogResult.Cancel:
                            
                            break;
                    }
                }
                else
                {
                    if ((this.ParentForm as MainForm) != null)
                        (this.ParentForm as MainForm).tabControl.TabPages.Remove((this.ParentForm as MainForm).tabControl.SelectedTab);

                }
            } 

*/
            if ((this.ParentForm as MainForm) != null)
                (this.ParentForm as MainForm).tabControl.TabPages.Remove((this.ParentForm as MainForm).tabControl.SelectedTab);


        }

        private void btField_Click(object sender, EventArgs e)
        {
            this.gridView.ColumnsCustomization();
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            this.btEdit.PerformClick();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.productBindingSource.CancelEdit();
            this.CancelChages();
        }

        private void UCProductAll_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
