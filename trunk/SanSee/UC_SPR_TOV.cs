using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using DevExpress.XtraGrid.Views.Grid;

namespace SanSee
{
    public partial class UC_SPR_TOV : UserControl
    {
        /* private _isNewRow;
          */
        private string _NameWorkTable;

        public string NameWorkTable
        {
            get { return this._NameWorkTable; }
            set { _NameWorkTable = value; }

        }

       
        public UC_SPR_TOV()
        {
      
            InitializeComponent();
            
        }

        private void UC_SPR_TOV_Load(object sender, EventArgs e)
        {
            
//          System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal);
  //        MessageBox.Show("Local user config path: "+ config.FilePath);

            string fileName = "D:\\appearanceLayout.xml";
          
            // ...
            if (File.Exists(fileName))
            {
                grid.MainView.RestoreLayoutFromXml(fileName);
            }

            grid.DataSource = (this.ParentForm as MainForm).mDataSet.Tables[_NameWorkTable];
                
           (this.ParentForm as MainForm).FillTable(_NameWorkTable);

            (this.ParentForm as MainForm).FillTable("SPR_EI");
            this.EI_ItemLookUpEdit.DataSource = (this.ParentForm as MainForm).mDataSet.Tables["SPR_EI"];

            (this.ParentForm as MainForm).FillTable("SPR_Place_storage");
            this.PlaceItemLookUpEdit.DataSource = (this.ParentForm as MainForm).mDataSet.Tables["SPR_Place_storage"];

            (this.ParentForm as MainForm).FillTable("SPR_Form");
            this.FormItemLookUpEdit.DataSource = (this.ParentForm as MainForm).mDataSet.Tables["SPR_Form"];

            (this.ParentForm as MainForm).FillTable("SPR_Substance");
            this.SubstanceItemLookUpEdit.DataSource = (this.ParentForm as MainForm).mDataSet.Tables["SPR_Substance"];

            (this.ParentForm as MainForm).FillTable("SPR_Izg");
            this.IzgItemLookUpEdit.DataSource = (this.ParentForm as MainForm).mDataSet.Tables["SPR_Izg"];

            (this.ParentForm as MainForm).FillTable("SPR_Farm_Group");
            this.FgItemLookUpEdit.DataSource = (this.ParentForm as MainForm).mDataSet.Tables["SPR_Farm_Group"];

            (this.ParentForm as MainForm).FillTable("SPR_FarmG_level2");
            this.FG2ItemLookUpEdit.DataSource = (this.ParentForm as MainForm).mDataSet.Tables["SPR_FarmG_level2"];
       
         
            this.grid.Focus();
            this.gridView1.FocusedRowHandle = DevExpress.XtraGrid.GridControl.AutoFilterRowHandle;
            this.gridView1.FocusedColumn = this.colName_Tov;
            this.gridView1.OptionsBehavior.Editable = false;

            (this.ParentForm as MainForm).mDataSet.Tables[_NameWorkTable].RowChanged += new DataRowChangeEventHandler(OnRowChanged);
            (this.ParentForm as MainForm).mDataSet.Tables[_NameWorkTable].RowChanging += new DataRowChangeEventHandler(OnRowChanging);
           
        
        }
      
        protected /*static*/ void OnRowChanged(  object sender, DataRowChangeEventArgs args)
    
        {
         // if (args.Action != DataRowAction.Nothing)
        //    this.bSave.Enabled = true;
         
        
        }

        protected void OnRowChanging(object sender, DataRowChangeEventArgs args)
        {
            // if (args.Action != DataRowAction.Nothing)
           this.bSave.Enabled = true;

        }

      
        private void bEdit_Click(object sender, EventArgs e)
        {   this.gridView1.OptionsBehavior.Editable = true;
            this.grid.EmbeddedNavigator.Buttons.Edit.DoClick();
         }

        private void bSave_Click(object sender, EventArgs e)
        {
            this.grid.EmbeddedNavigator.Buttons.EndEdit.DoClick();
           (this.ParentForm as MainForm).SaveToBase(_NameWorkTable);
        this.gridView1.OptionsBehavior.Editable = false;
          //  MessageBox.Show("this.sPR_IzgTableAdapter");
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            this.gridView1.OptionsBehavior.Editable = true;
            this.grid.EmbeddedNavigator.Buttons.Append.DoClick();
       
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            (this.ParentForm as MainForm).RejectChanges(_NameWorkTable);
         
        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            if (this.gridView1.GetRowCellDisplayText(e.RowHandle, "Small_Name").Length == 0)
            {
                string _newVal;
               
                string _text;
               _text = this.gridView1.GetRowCellDisplayText(e.RowHandle, "Name_Tov");
               _newVal = _text.Length > 25 ? _text.Remove(25, _text.Length - 25) : _text;
               this.gridView1.SetRowCellValue(e.RowHandle, gridView1.Columns["Small_Name"], _newVal);
              }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.grid.EmbeddedNavigator.Buttons.EndEdit.DoClick();

            if  ((this.ParentForm as MainForm).mDataSet.Tables[_NameWorkTable].GetChanges()!=null)
            
              if (MessageBox.Show("Сохранить измнения?", "!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
              
                  (this.ParentForm as MainForm).SaveToBase(_NameWorkTable);
             
              else

                  (this.ParentForm as MainForm).mDataSet.Tables[_NameWorkTable].RejectChanges();
          string fileName = "D:\\appearanceLayout.xml";

             grid.MainView.SaveLayoutToXml(fileName);
            (this.ParentForm as MainForm).tabControl1.TabPages.Remove((this.ParentForm as MainForm).tabControl1.SelectedTab);
            
          

        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
          if  (this.gridView1.FocusedRowHandle!=DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
              
          {
          //   this.grid.Focus();
             this.bEdit_Click(sender,e);
          }
         
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (this.gridView1.FocusedRowHandle != DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
            {
                this.EditToolStripMenuItem.Enabled = true;

            }
            else 
                this.EditToolStripMenuItem.Enabled=false;
           

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
          // Console.Beep();
            //   this.bSave.Enabled = true;
        }

        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            this.bSave.Enabled = true;
        }

        private void настройкаПолейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.gridView1.ColumnsCustomization();
        }
       }
}