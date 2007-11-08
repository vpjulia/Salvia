using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using RetailTrade.Printers;

namespace RetailTrade.Invoice
{
    public partial class InvoiceDetailEditPrintMar : UserControl
    {
       private Maria301Printer _printer;

       private MDataSet.CashDataTable _CashDataTable;

       private MainForm _mainForm;

        private bool InitDataCash()
        {


            return true;
        }

        public InvoiceDetailEditPrintMar()
        {
            InitializeComponent();
        }



        public InvoiceDetailEditPrintMar(MDataSet.InvoiceMasterRow source)
        {
            InitializeComponent();

            this.mDataSet = source.Table.DataSet as MDataSet;

            _CashDataTable = (source.Table.DataSet as MDataSet).Cash;

        //    this.RemainsBindingSource.DataSource = new DataView(this.mDataSet.Remains, "MainStockRef=" + source.MainStockRef.ToString(), null, DataViewRowState.CurrentRows);
           
            this.remainsBindingSource.DataSource = new DataView(this.mDataSet.Remains, "Quantityremains<>0 and MainStockRef=" + source.MainStockRef.ToString(), null, DataViewRowState.CurrentRows);
            this.remainsBindingSource.ResetBindings(true);

            this.invoiceMasterBindingSource.DataSource = source;
            this.invoiceMasterBindingSource.ResetBindings(true);


            this.invoiceMasterBindingSourceView.DataSource = source.Table;

            this.invoiceMasterBindingSourceView.ResetBindings(true);
            this.invoiceMasterBindingSourceView.CurrencyManager.Position = this.invoiceMasterBindingSourceView.Find("ID", source.ID);


            this.invoiceDetailBindingSource.DataSource = this.invoiceMasterBindingSourceView;
            this.invoiceDetailBindingSource.DataMember = "FK_InvoiceDetail_InvoiceMaster";
            this.invoiceDetailBindingSource.ResetBindings(true);


            

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

             this._printer.testCheck();
           
           /* _prn.OpenCheck("salvia");
            _prn.FiscalLineEx();
            _prn.CloseCheckEx();
            _prn.GetCashInfo(); 
            _prn.GetPrinterConfig(); */
         //   _prn.Done();
            

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
           
            this._printer.XReport();
        }

        private void InvoiceDetailEditPrintMar_Load(object sender, EventArgs e)
        {
            _printer = new Maria301Printer(1);
            _mainForm = (this.ParentForm as FormDialog).MainForm;

            if (_printer.HasError)
            {
                MessageBox.Show(_printer.ErrorText);
            }

            

        }



    }
}
