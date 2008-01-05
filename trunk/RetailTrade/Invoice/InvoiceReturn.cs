using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace RetailTrade.Invoice
{
    public partial class InvoiceReturn : UserControl
    {

        private MainForm _mainForm;

        public InvoiceReturn()
        {
            InitializeComponent();
        }

        public InvoiceReturn(MDataSet mdataset,MainForm mainform)
        {
            InitializeComponent();
            this.mDataSet = mdataset;
            _mainForm = mainform;

            this.linkedInvoiceMasterBindingSource.DataSource = this.mDataSet.LinkedInvoiceMaster;
            this.linkedInvoiceMasterBindingSource.ResetBindings(true);
            this.cbTradePutlet.ComboBox.DataSource = new DataView(this.mDataSet.TradePutlet,"Id> 0","Name",DataViewRowState.CurrentRows);
            this.cbTradePutlet.ComboBox.DisplayMember = "Name";
            this.cbTradePutlet.ComboBox.ValueMember = "ID";

            this.productBindingSource.DataSource = this.mDataSet.Product;
            this.manufacturerBindingSource.DataSource = this.mDataSet.Manufacturer;

            this.productBindingSource.ResetBindings(false);
            this.manufacturerBindingSource.ResetBindings(false);

        }

        private void btFind_Click(object sender, EventArgs e)
        {
            int tradeNum = (int)this.cbTradePutlet.ComboBox.SelectedValue;


            this.mDataSet.LinkedInvoiceDetail.Clear();
            this.mDataSet.LinkedInvoiceMaster.Clear();



            try
            {
                this.linkedInvoiceMasterTableAdapter.Fill(this.mDataSet.LinkedInvoiceMaster, tradeNum);
                this.linkedInvoiceDetailTableAdapter.Fill(this.mDataSet.LinkedInvoiceDetail, tradeNum);

            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка :" + err.Message);
                
            
            }
        }

        private void InvoiceReturn_Load(object sender, EventArgs e)
        {
          /*  this.linkedInvoiceMasterTableAdapter.Fill(this.mDataSet.LinkedInvoiceMaster);
            this.linkedInvoiceDetailTableAdapter.Fill(this.mDataSet.LinkedInvoiceDetail);
            */

        }

        private void btMove_Click(object sender, EventArgs e)
        {


            MDataSet.LinkedInvoiceMasterRow master = this.gridViewLinkMast.GetDataRow(this.gridViewLinkMast.FocusedRowHandle) as MDataSet.LinkedInvoiceMasterRow;

            if (master == null) return;

            if (MessageBox.Show("Принять на склад: " + master.Sum.ToString() + "грн ?", "Прием возвратной накладной",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                int tradeNum = master.TradePutletRef;

                try
                {
                    this.linkedInvoiceMasterTableAdapter.LinkedMoveReturnInvoice(master.TradePutletRef, master.ID);
                   
                    this.mDataSet.LinkedInvoiceDetail.Clear();
                    this.mDataSet.LinkedInvoiceMaster.Clear();

                    this.linkedInvoiceMasterTableAdapter.Fill(this.mDataSet.LinkedInvoiceMaster, tradeNum);
                    this.linkedInvoiceDetailTableAdapter.Fill(this.mDataSet.LinkedInvoiceDetail, tradeNum);



                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                
                }


            
            }


        }

        private void btClose_Click(object sender, EventArgs e)
        {
            (this.ParentForm as MainForm).DeleteDataTab(this.Parent as TabPage);
        }



    }
}
