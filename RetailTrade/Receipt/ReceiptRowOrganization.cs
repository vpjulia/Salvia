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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           
         //   this.receiptMasterBindingSource.EndEdit();
            //EndCurrentEdit();
            this.receiptMasterBindingSource.ResetCurrentItem();            
             // MessageBox.Show(this.receiptMasterBindingSource.CurrencyManager.Position.ToString());
        }

        private void btSaveReciept_Click(object sender, EventArgs e)
        {
            this.receiptMasterBindingSource.CurrencyManager.EndCurrentEdit();

            if ((this.ParentForm as MainForm).SaveToBase(this.receiptMasterBindingSource.DataSource as MDataSet.ReceiptMasterRow))
            {
                this.receiptMasterBindingSource.ResetCurrentItem();
                this.Parent.Tag = "ReceiptRowOrganization" + (this.receiptMasterBindingSource.Current as MDataSet.ReceiptMasterRow).ID.ToString();
                this.Parent.Text = "№" + (this.receiptMasterBindingSource.Current as MDataSet.ReceiptMasterRow).Number.ToString() + " " + (this.receiptMasterBindingSource.Current as MDataSet.ReceiptMasterRow).OrganizationRow.ShortName.ToString();
                this.panelNumber.Enabled = true;
            }
        

        }

    }
}
