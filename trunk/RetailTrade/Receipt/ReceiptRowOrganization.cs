using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace RetailTrade
{
    public partial class ReceiptRowOrganization : UserControl
    {
        public ReceiptRowOrganization()
        {
            InitializeComponent();
        }

        public ReceiptRowOrganization(MDataSet.ReceiptMasterRow source, int currentID)
        {

            //** receiptMasterBindingSource - таблица  *//
            InitializeComponent();

            this.mDataSet = source.Table.DataSet as MDataSet;

           this.receiptMasterBindingSource.DataSource = source;
           this.receiptMasterBindingSource.ResetBindings(false);

           this.organizationBindingSource.DataSource = this.mDataSet.Organization;
           this.organizationBindingSource.ResetBindings(false);

           this.stockBindingSource.DataSource = this.mDataSet.Stock.Select("TradePupletRef=0");
           this.productBindingSource.DataSource = this.mDataSet.Product;

           this.receiptMasterNewBindingSource.DataSource = source.Table;
         //   this.receiptMasterNewBindingSource.DataMember = "ReceiptMaster";

       //     MessageBox.Show(this.receiptMasterNewBindingSource.Find("Id", "3").ToString());
            this.receiptMasterNewBindingSource.ResetBindings(true);
           
            {
                this.receiptMasterNewBindingSource.CurrencyManager.Position = this.receiptMasterNewBindingSource.Find("ID", source.ID.ToString());

                this.receiptDetailBindingSource.DataSource = this.receiptMasterNewBindingSource;

                this.receiptDetailBindingSource.DataMember = "ReceiptMaster_ReceiptDetail";
                this.receiptDetailBindingSource.ResetBindings(true);
            }

            if (source.ID < 0)
            {
                this.panelNumber.Enabled = false;
            }

        }
       
        private void btEdit_Click(object sender, EventArgs e)
        {
            this.receiptMasterBindingSource.EndEdit();
           

            FormDialog _formDialog = new FormDialog();

            ReceiptDetailByRef _peceiptDetail = new ReceiptDetailByRef( this.receiptMasterBindingSource.DataSource as MDataSet.ReceiptMasterRow);
      
            _formDialog.panel.Controls.Add(_peceiptDetail);

            if (DialogResult.OK == _formDialog.ShowDialog(this))
            {
                MessageBox.Show("btEdit_Click");
            }


        }

        private bool SaveChange()
        {

            this.receiptMasterBindingSource.CurrencyManager.EndCurrentEdit();
            this.receiptDetailBindingSource.CurrencyManager.EndCurrentEdit();


           if (this.gridView.HasColumnErrors)
           {
               this.receiptMasterBindingSource.CancelEdit();
               return false;
           }


              if ((this.ParentForm as MainForm).SaveToBase(this.receiptMasterBindingSource.DataSource as MDataSet.ReceiptMasterRow))
            {
                this.receiptMasterBindingSource.ResetCurrentItem();
                this.Parent.Tag = "ReceiptRowOrganization" + (this.receiptMasterBindingSource.Current as MDataSet.ReceiptMasterRow).ID.ToString();
                this.Parent.Text = "№" + (this.receiptMasterBindingSource.Current as MDataSet.ReceiptMasterRow).Number.ToString() + " " + (this.receiptMasterBindingSource.Current as MDataSet.ReceiptMasterRow).OrganizationRow.ShortName.ToString();
                this.panelNumber.Enabled = true;
            }
            return true;
        }

        private void btSaveReciept_Click(object sender, EventArgs e)
        {
            this.SaveChange();
        }

       
        private void gridView1_InvalidValueException(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            MessageBox.Show(e.ErrorText);
        }

        private void gridView1_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            this.gridView.SetColumnError(this.gridView.Columns[1], e.ErrorText.ToString());
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            //
         //   this.grid.EmbeddedNavigator.Buttons.EndEdit.DoClick();

            if (this.gridView.HasColumnErrors)
            {
                this.receiptDetailBindingSource.CancelEdit();
            }
            else if (this.SaveChange())
            {
                if ((this.ParentForm as MainForm) != null)
                    (this.ParentForm as MainForm).tabControl.TabPages.Remove((this.ParentForm as MainForm).tabControl.SelectedTab);

            }
           


        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            this.btEdit.PerformClick();
        }

    }
}
