using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SanSee
{
    public partial class UCSPR : UserControl
    {
        private string _NameWorkTable;

        public string NameWorkTable {
            get { return this._NameWorkTable; }
            set {_NameWorkTable=value;}
    
    }


        public UCSPR()
        {
            InitializeComponent();
        }

        private bool SetCaptionFields()
        {
            foreach (DataColumn it in (grid.DataSource as DataTable).Columns)
            {
                this.gridView1.Columns[it.ColumnName].Caption = it.Caption;
          
                if (it.AutoIncrement)
                {
                    this.gridView1.Columns[it.ColumnName].OptionsColumn.AllowEdit = false;
                    this.gridView1.Columns[it.ColumnName].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
                   // this.gridView1.Columns[it.ColumnName].OptionsFilter.AllowAutoFilter = false;
                }
                else
                {
                  //  this.gridView1.Columns[it.ColumnName].FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
                    if (it.ColumnName == "RW")
                    {
                        this.gridView1.Columns[it.ColumnName].Visible = false;
                    }
                  //  if (it.ReadOnly)
                    //    this.gridView1.Columns[it.ColumnName].Visible = false;
                   
  
                    //  this.gridView1.Columns[it.ColumnName].OptionsColumn.AllowEdit = false;
                }
            }
            return true;
        }
        
        private void UCSPR_Load(object sender, EventArgs e)
        {
            grid.DataSource = (this.ParentForm as MainForm).mDataSet.Tables[_NameWorkTable];
           (this.ParentForm as MainForm).FillTable(_NameWorkTable);

           if (_NameWorkTable == "SPR_Izg")
             {
                if ((this.ParentForm as MainForm).mDataSet.SPR_Country.Rows.Count==0)
                    (this.ParentForm as MainForm).FillTable("SPR_Country");
               this.LUCountry.DataSource = (this.ParentForm as MainForm).mDataSet.Tables["SPR_Country"];
               this.gridView1.Columns["IDF_Country"].ColumnEdit = LUCountry;
           }

           if (_NameWorkTable == "SPR_FarmG_level2")
           {
               if ((this.ParentForm as MainForm).mDataSet.SPR_Farm_Group.Rows.Count == 0)
                   (this.ParentForm as MainForm).FillTable("SPR_Farm_Group");
               this.LUpFarm_Group.DataSource = (this.ParentForm as MainForm).mDataSet.Tables["SPR_Farm_Group"];
               this.gridView1.Columns["IDF1"].ColumnEdit = LUpFarm_Group;
           }
         SetCaptionFields();
         this.grid.Focus();
         this.gridView1.FocusedRowHandle = DevExpress.XtraGrid.GridControl.AutoFilterRowHandle;
         this.gridView1.FocusedColumn = this.gridView1.Columns[1];
        }

        private void tSClose_Click(object sender, EventArgs e)
        {
            this.grid.EmbeddedNavigator.Buttons.EndEdit.DoClick();

            if ((this.ParentForm as MainForm).mDataSet.Tables[_NameWorkTable].GetChanges() != null)

                if (MessageBox.Show("Сохранить измнения?", "!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

                    (this.ParentForm as MainForm).SaveToBase(_NameWorkTable);

                else

                    (this.ParentForm as MainForm).mDataSet.Tables[_NameWorkTable].RejectChanges();
            
            (this.ParentForm as MainForm).tabControl1.TabPages.Remove((this.ParentForm as MainForm).tabControl1.SelectedTab);
          
        }

        private void tbAdd_Click(object sender, EventArgs e)
        {
            this.gridView1.OptionsBehavior.Editable = true;
            this.grid.EmbeddedNavigator.Buttons.Append.DoClick();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void tBEdit_Click(object sender, EventArgs e)
        {
            this.gridView1.OptionsBehavior.Editable = true;
            this.grid.EmbeddedNavigator.Buttons.Edit.DoClick();
          
        }

        private void tbSave_Click(object sender, EventArgs e)
        {
            this.grid.EmbeddedNavigator.Buttons.EndEdit.DoClick();
            (this.ParentForm as MainForm).SaveToBase(_NameWorkTable);
            this.gridView1.OptionsBehavior.Editable = false;
   
        }

        private void tBCancel_Click(object sender, EventArgs e)
        {
            (this.ParentForm as MainForm).RejectChanges(_NameWorkTable);
        }

        
    }
}
