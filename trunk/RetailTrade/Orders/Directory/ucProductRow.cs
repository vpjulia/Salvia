using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using DevExpress.XtraGrid;

namespace RetailTrade
{
    public partial class ucProductRow : UserControl
    {
        private MainForm.ActionDialog _state;
        

         public ucProductRow()
        {
            InitializeComponent();
        }

         public ucProductRow(MDataSet.ProductRow productRow,MainForm.ActionDialog actionDialog)
        {
       
            InitializeComponent();
            this.mDataSet = productRow.Table.DataSet as MDataSet;
            this.productBindingSource.DataSource = productRow;
            this.manufacturerBindingSource.DataSource = this.mDataSet.Manufacturer;
            this.packingBindingSource.DataSource = this.mDataSet.Packing;
            this.storageConditionBindingSource.DataSource = this.mDataSet.StorageCondition;
            this.substanceBindingSource.DataSource = this.mDataSet.Substance;
            this.farmGroupLevel2BindingSource.DataSource = this.mDataSet.FarmGroupLevel2;
            this.unitBindingSource.DataSource = this.mDataSet.Unit;
            
            _state = actionDialog;
        }


        public ucProductRow(DataRow productRow, MainForm.ActionDialog actionDialog)
        {

            InitializeComponent();

            this.dataSet = productRow.Table.DataSet;

          //  this.mDataSet = productRow.Table.DataSet as MDataSet;
            this.productBindingSource.DataSource = productRow ;
            this.manufacturerBindingSource.DataSource = this.dataSet.Tables["Manufacturer"];
            this.packingBindingSource.DataSource = this.dataSet.Tables["Packing"];
            this.storageConditionBindingSource.DataSource = this.dataSet.Tables["StorageCondition"];
            this.substanceBindingSource.DataSource = this.dataSet.Tables["Substance"];
            this.farmGroupLevel2BindingSource.DataSource = this.dataSet.Tables["FarmGroupLevel2"];
            this.unitBindingSource.DataSource = this.dataSet.Tables["Unit"];

            _state = actionDialog;
        }



         private void ucProductRow_Load(object sender, EventArgs e)
        {
           this.ParentForm.AcceptButton = null;
            if (_state == MainForm.ActionDialog.View) 
               this.tabControl.Enabled=false;

           

         }

       
         private void btSimpleDirectory_Click(object sender, EventArgs e)
        {
            FormDialog dform = new FormDialog();
            dform.Text = this.toolTip1.GetToolTip((sender as Control)).ToString();

            int _id =Convert.ToInt32( (this.Controls.Find((sender as Button).Tag.ToString()+"lookUpEdit", true)[0] as  DevExpress.XtraEditors.LookUpEdit).EditValue);


            DataTable _table = (this.productBindingSource.DataSource as DataRow).Table.DataSet.Tables[(sender as Button).Tag.ToString()];

            UCSimpleDirectory ucSimpleDirectory = new UCSimpleDirectory(_table,_id);
            ucSimpleDirectory.btClose.Visible = false;
            dform.panel.Controls.Add(ucSimpleDirectory);

            ucSimpleDirectory.bindingSource.CurrencyManager.Position = ucSimpleDirectory.bindingSource.Find("ID", _id);
         
           
            if (DialogResult.OK == dform.ShowDialog(this))
            { 
               (this.Controls.Find((sender as Button).Tag.ToString()+"lookUpEdit", true)[0] as  DevExpress.XtraEditors.LookUpEdit).EditValue = ucSimpleDirectory.gridView.GetDataRow(ucSimpleDirectory.gridView.GetSelectedRows()[0])["ID"];
            }
  
        }

         private void btUcGroupDirectory_Click(object sender, EventArgs e)
        {
            /*У сендера имя - имя_таблицы_lookupEdit */


            FormDialog dform = new FormDialog();
            dform.Text = this.toolTip1.GetToolTip((sender as Control)).ToString();

             DataTable _table = (this.productBindingSource.DataSource as DataRow).Table.DataSet.Tables[(sender as Button).Tag.ToString()];
           
             UcGroupDirectory ucGroupDirectory = new UcGroupDirectory(_table);

             ucGroupDirectory.errorProvider1.DataSource = (this.productBindingSource.DataSource as DataRow).Table.DataSet;
             ucGroupDirectory.btClose.Visible = false;
             dform.panel.Controls.Add(ucGroupDirectory);


            int rowHandle = ucGroupDirectory.gridView.LocateByValue(0, ucGroupDirectory.gridView.Columns["ID"], (this.Controls.Find((sender as Button).Tag.ToString() + "lookUpEdit", true)[0] as DevExpress.XtraEditors.LookUpEdit).EditValue);

            if (rowHandle != GridControl.InvalidRowHandle)
            {
                ucGroupDirectory.gridView.FocusedRowHandle = rowHandle;
                ucGroupDirectory.gridView.FocusedColumn = ucGroupDirectory.gridView.Columns["Name"];
            }


            if (DialogResult.OK == dform.ShowDialog(this))
            {
                (this.Controls.Find((sender as Button).Tag.ToString() + "lookUpEdit", true)[0] as DevExpress.XtraEditors.LookUpEdit).EditValue = ucGroupDirectory.gridView.GetDataRow(ucGroupDirectory.gridView.GetSelectedRows()[0])["ID"];

            }

        }

         private void ucProductRow_Validating(object sender, CancelEventArgs e)
        {
            this.productBindingSource.CurrencyManager.EndCurrentEdit();
           
        }

        
       
        
      
    }
}
