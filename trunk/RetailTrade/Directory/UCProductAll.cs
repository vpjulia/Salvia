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
using System.Threading;
using DevExpress.XtraGrid;

namespace RetailTrade
{
    public partial class UCProductAll : UserControl
    {
        DataView _changes;

        Thread thread;

        bool _layoutChanged;

        bool _isnds;

        DataTable _product;

        public UCProductAll()
        {
            InitializeComponent();
        }
        public UCProductAll(MDataSet source)
        {
            InitializeComponent();
            productBindingSource.DataSource = source.Product;
            this.unitBindingSource.DataSource = source.Unit;
            this.storageConditionBindingSource.DataSource = source.StorageCondition;
            this.substanceBindingSource.DataSource = source.Substance;
            this.farmGroupLevel2BindingSource.DataSource = source.FarmGroupLevel2;
            this.packingBindingSource.DataSource  = source.Packing;
      
            _changes = new DataView(source.Product, null, null, DataViewRowState.Added | DataViewRowState.ModifiedCurrent | DataViewRowState.Deleted);
            _changes.ListChanged+=new ListChangedEventHandler(_changes_ListChanged);

            
        }

        public UCProductAll(FullDataSet source, bool isNds)
        {
            thread = new Thread(new ThreadStart(MainForm.DoSplash));
            thread.Start();
            Thread.Sleep(300);


            InitializeComponent();

            productBindingSource.DataSource = new DataView(source.Product, "IsNds=" + isNds.ToString()+" and ID<>0", null, DataViewRowState.CurrentRows|DataViewRowState.Added|DataViewRowState.ModifiedCurrent);

            this.unitBindingSource.DataSource = source.Unit;

            this.storageConditionBindingSource.DataSource = source.StorageCondition;
            this.substanceBindingSource.DataSource = source.Substance;
            this.farmGroupLevel2BindingSource.DataSource = source.FarmGroupLevel2;
            this.packingBindingSource.DataSource = source.Packing;
      
            
            _isnds = isNds;

            _changes = new DataView(source.Product, null, null, DataViewRowState.Added | DataViewRowState.ModifiedCurrent | DataViewRowState.Deleted);
      
            _changes.ListChanged += new ListChangedEventHandler(_changes_ListChanged);


            _product = source.Product;


        }


        private void UCProductAll_Load(object sender, EventArgs e)
        {
            foreach (GridView view in this.grid.ViewCollection)
            {
                string fileName = new FileInfo(Application.ExecutablePath).DirectoryName + "\\" + view.Name.ToString() + ".xml";
                if (File.Exists(fileName))
                    view.RestoreLayoutFromXml(fileName);
            }

            _layoutChanged = false;


            if ((this.ParentForm as MainForm) != null)
                (this.ParentForm as MainForm).FullFillTable("Product",_isnds);
            else
                (this.ParentForm as FormDialog).MainForm.FullFillTable("Product",_isnds);
           
            thread.Abort();
            Thread.Sleep(30);
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
               int res;

               try
               {
                res =  (this.ParentForm as MainForm).productTableAdapter1.Update(_product as FullDataSet.ProductDataTable);
                MessageBox.Show("Сохранено : " + res.ToString());
               }
               catch (Exception err)

               {

                   MessageBox.Show(err.Message);
                   MainForm.Log(err.Message);
                   return false;
               }

            }

           
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

            if (this.gridViewMainProduct.IsValidRowHandle(hendl) & hendl != DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
            {

            //   MDataSet.ProductRow pr = ((this.productBindingSource.CurrencyManager.Current as DataRowView).Row as MDataSet.ProductRow);
                DataRow pr = ((this.productBindingSource.CurrencyManager.Current as DataRowView).Row );
              
                FormDialog dform = new FormDialog();
                dform.Text = "Карточка товара";
                dform.panel.Controls.Add(new ucProductRow((pr as DataRow), MainForm.ActionDialog.Edit));

                if (DialogResult.OK == dform.ShowDialog(this))
                {
                    this.productBindingSource.CurrencyManager.EndCurrentEdit();
                    this.grid.Focus();
                    this.gridViewMainProduct.FocusedRowHandle = hendl;
                    
                }
                else
                {
                    this.productBindingSource.CurrencyManager.CancelCurrentEdit();
                }
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {


            DataRow ProductRow = (productBindingSource.AddNew() as DataRowView).Row ;

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

            if (this.gridViewMainProduct.IsValidRowHandle(hendl) & hendl != DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
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

                    MessageBox.Show(this,"Невозможно удалить запись, ссылок на нее :  " + countChild.ToString(),this.Tag.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                else

                    if (MessageBox.Show(" Удалить запись? " + this.gridViewMainProduct.GetFocusedRowCellDisplayText(this.gridViewMainProduct.Columns[1]), "Удаление карточки",
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

            if (this.gridViewMainProduct.HasColumnErrors) return;

            this.btEdit.Enabled = true;
            this.btSave.Enabled = false;
            this.gridViewMainProduct.OptionsBehavior.Editable = false;
          
            this.grid.EmbeddedNavigator.Buttons.EndEdit.DoClick();
        
            if (this.SaveChanges())

            {      
                     this.btSave.Enabled = false;
                     this.gridViewMainProduct.OptionsBehavior.Editable = false;
                 }
                 else
                 {
                  
                     this.btSave.Enabled = true;
                    
                 }

        }

        private void btClose_Click(object sender, EventArgs e)
        {

            this.productBindingSource.EndEdit();

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
               
                // сохранить изменения


                if (_changes.Count > 0) 
                {
                    DialogResult _result;

                    _result = MessageBox.Show("Сохранить изменения? ", "Сохранение справочника товаров " , MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

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

        private void btField_Click(object sender, EventArgs e)
        {
            this.gridViewMainProduct.ColumnsCustomization();
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            this.btEdit.PerformClick();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.productBindingSource.CancelEdit();
            this.CancelChages();
            this.gridViewMainProduct.OptionsBehavior.Editable = false;
        }

        private void UCProductAll_Validating(object sender, CancelEventArgs e)
        {
            if (_changes.Count > 0)
            {
                DialogResult _result;

                _result = MessageBox.Show("Сохранить изменения? ", "Сохранение справочника товаров " , MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                switch (_result)
                {
                    case DialogResult.Yes:
                        if (!this.SaveChanges())
                            e.Cancel = true;
                            break;
                    case DialogResult.No:
                        {
                            if (!this.CancelChages())
                                e.Cancel = true;    
                            
                            }
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }

        private void btEditGrid_Click(object sender, EventArgs e)
        {
            this.gridViewMainProduct.OptionsBehavior.Editable = true;
        }

        private void gridViewMainProduct_Layout(object sender, EventArgs e)
        {
            
            _layoutChanged = true;
            
        
        }

        private void gridViewMainProduct_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
           // if (e.RowHandle == this.grid. FocusedView.FocusedRowHandle) return;

            if( this.gridViewMainProduct.IsValidRowHandle(e.RowHandle)&(e.RowHandle!=GridControl.AutoFilterRowHandle))
            if (gridViewMainProduct.GetDataRow(e.RowHandle).RowState != DataRowState.Unchanged)
            {
                e.Appearance.BackColor = Color.LightGreen;
                e.Appearance.Font = e.Cache.GetFont(e.Appearance.Font, FontStyle.Bold);
                
           }
        }

        private void gridViewMainProduct_CalcPreviewText(object sender, CalcPreviewTextEventArgs e)
        {
            //e.PreviewText = "Item: " + e.PreviewText + "; Units: " + gridView1.GetRowCellDisplayText(e.RowHandle, gridView1.Columns["UnitsOnOrder"]) + ".";
            FullDataSet.ProductRow _row = this.gridViewMainProduct.GetDataRow(e.RowHandle) as FullDataSet.ProductRow;
            if (_row != null)
            {
                string pack = "";
                string place = "";
                string farmgr = "";
                string subst = "";
              

                if (_row.PackingRef > 0)
                    pack = _row.PackingRow.Name.ToString();

                if (_row.StorageConditionRef > 0)
                    place = _row.StorageConditionRow.Name.ToString();

                if (_row.FarmGrouplevel2Ref > 0)

                    farmgr = _row.FarmGroupLevel2Row.Name.ToString();

                if (_row.SubstanceRef > 0)
                    place = _row.SubstanceRow.Name.ToString();

              

                e.PreviewText = pack.ToString() + "   " + place + "  " + farmgr + "   " + subst ;

            }
        }

       

       
    }
}
