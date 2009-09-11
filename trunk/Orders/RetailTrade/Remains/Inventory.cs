using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;

namespace RetailTradeOrders.Remains
{
    public partial class Inventory : UserControl
    {

        private MainForm _mainForm;


        

        public Inventory(MainForm mainform)
        {
            InitializeComponent();
            _mainForm = mainform;
            
            this.mDataSet = _mainForm.mDataSet;

            this.inventoryMasterBindingSource.DataSource = this.mDataSet.inventoryMaster;
            this.inventoryMasterBindingSource.ResetBindings(false);
               
        }


        private void Inventory_Load(object sender, EventArgs e)
        {
            foreach (GridView view in this.grid.ViewCollection)
            {
                string fileName = new FileInfo(Application.ExecutablePath).DirectoryName + "\\" + view.Name.ToString() + ".xml";
                if (File.Exists(fileName))
                    view.RestoreLayoutFromXml(fileName);
            }
             foreach (GridView view in this.gridControlInventDet.ViewCollection)
            {
                string fileName = new FileInfo(Application.ExecutablePath).DirectoryName + "\\" + view.Name.ToString() + ".xml";
                if (File.Exists(fileName))
                    view.RestoreLayoutFromXml(fileName);
            }
            


            try
            {
                this.inventoryMasterTableAdapter.Fill(this.mDataSet.inventoryMaster);
                this.inventoryDetailsTableAdapter.Fill(this.mDataSet.inventoryDetails);
            //    this.inventoryMasterBindingSource.ResetBindings(false);
                
            }
            catch (Exception err)
            {
                MessageBox.Show("Не удалось обновить данные :" + err.Message);

            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
        
            MDataSet.inventoryMasterRow mastRow=(this.inventoryMasterBindingSource.AddNew() as DataRowView).Row as MDataSet.inventoryMasterRow;

            mastRow.Date = DateTime.Today;
            mastRow.Note = "[новый документ]";

            this.inventoryMasterBindingSource.EndEdit();



            try
            {
                this.inventoryMasterTableAdapter.Update(mastRow);

                this.inventoryDetailsTableAdapter.Fill(this.mDataSet.inventoryDetails);


            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                this.inventoryMasterBindingSource.CancelEdit();
                mastRow.RejectChanges();

            }



        }

       private void inventoryMasterBindingSource_PositionChanged(object sender, EventArgs e)
        {
           /* MDataSet.inventoryMasterRow mast = ((this.inventoryMasterBindingSource.Current as DataRowView).Row as MDataSet.inventoryMasterRow);

            if (mast.RowState == DataRowState.Modified)
            {
                try
                {
                
                    this.inventoryMasterTableAdapter.Update(mast);
                }
                    catch (Exception err)
            
                {
                MessageBox.Show(err.Message);
                this.inventoryMasterBindingSource.CancelEdit();
                }           
            }
                 
           if (mast.IsClose)
            {
                this.gridViewIntDet.OptionsBehavior.Editable = false;
                _mainForm.actionLabel.Text = "Просмотр инвентаризации за " + mast.Date.ToShortDateString();
            }
            else
            {
                this.gridViewIntDet.OptionsBehavior.Editable = true;
                _mainForm.actionLabel.Text = "Редактирование инвентаризации за " + mast.Date.ToShortDateString();
            }*/
        }
        

        private void inventoryMasterBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            MDataSet.inventoryMasterRow mast = ((this.inventoryMasterBindingSource.Current as DataRowView).Row as MDataSet.inventoryMasterRow);

            if (mast.RowState == DataRowState.Modified)
            {
                try
                {

                    this.inventoryMasterTableAdapter.Update(mast);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                    this.inventoryMasterBindingSource.CancelEdit();
                }
            }

            if (mast.IsClose)
            {
                this.gridViewIntDet.OptionsBehavior.Editable = false;
                _mainForm.actionLabel.Text = "Просмотр инвентаризации за " + mast.Date.ToShortDateString();
            }
            else
            {
                this.gridViewIntDet.OptionsBehavior.Editable = true;
                _mainForm.actionLabel.Text = "Редактирование инвентаризации за " + mast.Date.ToShortDateString();
            }
        }


        private void fKinventoryMasterinventoryDetailsBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            //*    сохранить  *//
            try
            {
                this.inventoryDetailsTableAdapter.Update(this.mDataSet.inventoryDetails);

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

            
            }

        }

        private void gridViewIntDet_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            MDataSet.inventoryDetailsRow det = this.gridViewIntDet.GetDataRow(e.RowHandle) as MDataSet.inventoryDetailsRow;

            if (det == null) return;


            if (det.Quantity == det.QuantityFact)
            {
                e.Appearance.Font = e.Cache.GetFont(e.Appearance.Font, FontStyle.Italic);

                e.Appearance.ForeColor = Color.Gray;

            
            }

            if (det.Quantity < det.QuantityFact)
            {
                e.Appearance.Font = e.Cache.GetFont(e.Appearance.Font, FontStyle.Bold);
            }


            
               if (det.UseByDate.AddMonths(-6) < DateTime.Today)

                   e.Appearance.ForeColor = Color.Pink;

                if (det.UseByDate.AddMonths(-2) < DateTime.Today)
                    e.Appearance.ForeColor = Color.Red;

            

        }

        private void gridViewIntDet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {

                if (gridViewIntDet.FocusedColumn == this.colProductName)
                    gridViewIntDet.FocusedColumn = this.colQuantityFact;
                else
                    gridViewIntDet.FocusedColumn = this.colProductName;
          }
        }

        private void btClose_Click(object sender, EventArgs e)
        {

            foreach (GridView view in this.grid.ViewCollection)
            {
                string fileName = new System.IO.FileInfo(Application.ExecutablePath).DirectoryName + "\\" + view.Name.ToString() + ".xml";
                view.SaveLayoutToXml(fileName);
            }

            foreach (GridView view in this.gridControlInventDet.ViewCollection)
            {
                string fileName = new System.IO.FileInfo(Application.ExecutablePath).DirectoryName + "\\" + view.Name.ToString() + ".xml";
                view.SaveLayoutToXml(fileName);
            }

            _mainForm.DeleteDataTab(this.Parent as TabPage);
        }

        private void quantityFactEdit_Validating(object sender, CancelEventArgs e)
        {
            MDataSet.inventoryDetailsRow det = this.gridViewIntDet.GetDataRow(this.gridViewIntDet.FocusedRowHandle) as MDataSet.inventoryDetailsRow;

            if (det == null) return;


              double proposedV = Convert.ToDouble( this.gridViewIntDet.ActiveEditor.Text) ;
              if (proposedV < 0)
              {
                  this.gridViewIntDet.SetColumnError(this.colQuantityFact, "Неверное значение после запятой!");
                  e.Cancel = true;
              }
            if (det.MinDivisor != 1)
            {
                double ed = (1.000 / det.MinDivisor);
                double proposed = Convert.ToDouble( this.gridViewIntDet.ActiveEditor.Text) ;
                if (Convert.ToInt32((proposed / ed) * 1000) != Convert.ToInt32(proposed / ed) * 1000)
                {
                    this.gridViewIntDet.SetColumnError(this.colQuantityFact,"Неверное значение после запятой!");
                    e.Cancel = true;
                }
                else
                    this.gridViewIntDet.SetColumnError(this.colQuantityFact, "");
                    
            }


        }

        private void gridViewIntDet_ShownEditor(object sender, EventArgs e)
        {
            MDataSet.inventoryDetailsRow det = this.gridViewIntDet.GetDataRow(this.gridViewIntDet.FocusedRowHandle) as MDataSet.inventoryDetailsRow;

            if (det == null) return;
            if (det.MinDivisor == 1)
            {
                this.quantityFactEdit.IsFloatValue = false;
            }
            else
            {
                this.quantityFactEdit.IsFloatValue = true;
                this.quantityFactEdit.Increment =Convert.ToDecimal(1.000/det.MinDivisor);
            
            }
        }

        private void gridControlInventDet_Enter(object sender, EventArgs e)
        {
            this.inventoryMasterBindingSource.EndEdit();
            MDataSet.inventoryMasterRow mast = ((this.inventoryMasterBindingSource.Current as DataRowView).Row as MDataSet.inventoryMasterRow);

            if (mast.IsClose)
            {
                this.gridViewIntDet.OptionsBehavior.Editable = false;
                _mainForm.actionLabel.Text = "Просмотр инвентаризации за " + mast.Date.ToShortDateString();
            }
            else
            {
                this.gridViewIntDet.OptionsBehavior.Editable = true;
                _mainForm.actionLabel.Text = "Редактирование инвентаризации за " + mast.Date.ToShortDateString();
            }
        }

       
    }
}
