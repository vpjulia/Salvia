using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;
using RetailTrade.Dialog;
using Microsoft.Reporting.WinForms;

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

           this.receiptMasterBindingSource.DataSource = source.Table;
           this.receiptMasterBindingSource.ResetBindings(false);
           this.receiptMasterBindingSource.CurrencyManager.Position = this.receiptMasterBindingSource.Find("ID", currentID);
           this.organizationBindingSource.DataSource = this.mDataSet.Organization;
           this.organizationBindingSource.ResetBindings(false);

           this.stockBindingSource.DataSource = this.mDataSet.Stock.Select("TradePupletRef=0");
           this.productBindingSource.DataSource = this.mDataSet.Product;

          this.receiptDetailBindingSource.DataSource = this.receiptMasterBindingSource;
                this.receiptDetailBindingSource.DataMember = "ReceiptMaster_ReceiptDetail";
                this.receiptDetailBindingSource.ResetBindings(true);
         

            if (source.ID < 0)
            {
                this.panelNumber.Enabled = false;
            }

            this.CountLabel.Text ="Строк : "+this.receiptDetailBindingSource.Count.ToString();
            
            this.sumLabel.Text = "на сумму :" + ((this.receiptMasterBindingSource.CurrencyManager.Current as DataRowView).Row as MDataSet.ReceiptMasterRow).PurchSum.ToString();
            this.AuthorLabel.Text = "Автор :" + ((this.receiptMasterBindingSource.CurrencyManager.Current as DataRowView).Row as MDataSet.ReceiptMasterRow).AuthorCreate.ToString();

        }
       
        private void btEdit_Click(object sender, EventArgs e)
        {
            this.receiptMasterBindingSource.EndEdit();
           

            FormDialog _formDialog = new FormDialog();
            _formDialog.Text = this.Tag.ToString();
            _formDialog.AcceptButton = null;
            ReceiptDetailByRef _peceiptDetail = new ReceiptDetailByRef(( this.receiptMasterBindingSource.Current as DataRowView).Row as MDataSet.ReceiptMasterRow);
      
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


           if (this.gridViewReceiptRowMain.HasColumnErrors)
           {
               this.receiptMasterBindingSource.CancelEdit();
               return false;
           }


              if ((this.ParentForm as MainForm).SaveToBase((this.receiptMasterBindingSource.Current as DataRowView ).Row as MDataSet.ReceiptMasterRow))
            {
                this.receiptMasterBindingSource.ResetCurrentItem();
                this.Parent.Tag = "ReceiptRowOrganization" + ((this.receiptMasterBindingSource.Current as DataRowView).Row as MDataSet.ReceiptMasterRow).ID.ToString();
                this.Parent.Text = "№" + ((this.receiptMasterBindingSource.Current as DataRowView).Row as MDataSet.ReceiptMasterRow).Number.ToString() + " " + ((this.receiptMasterBindingSource.Current as DataRowView).Row  as MDataSet.ReceiptMasterRow).OrganizationRow.ShortName.ToString();
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
            this.gridViewReceiptRowMain.SetColumnError(this.gridViewReceiptRowMain.Columns[1], e.ErrorText.ToString());
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            //
         //   this.grid.EmbeddedNavigator.Buttons.EndEdit.DoClick();

            if (this.gridViewReceiptRowMain.HasColumnErrors)
            {
                this.receiptDetailBindingSource.CancelEdit();
            }
            else if (this.SaveChange())
            {
                if ((this.ParentForm as MainForm) != null)
                    (this.ParentForm as MainForm).tabControl.TabPages.Remove((this.ParentForm as MainForm).tabControl.SelectedTab);
              
                
                foreach (GridView view in this.grid.ViewCollection)
                {

                    string fileName = new FileInfo(Application.ExecutablePath).DirectoryName + "\\" + view.Name.ToString() + ".xml";

                    try
                    {
                        view.SaveLayoutToXml(fileName);
                    }
                    catch
                    {
                        MessageBox.Show("Не удалось сохранить настройки");
                    }

                }
            }
 
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            this.btEdit.PerformClick();
        }

        private void ReceiptRowOrganization_Load(object sender, EventArgs e)
        {
            foreach (GridView view in this.grid.ViewCollection)
            {
                string fileName = new FileInfo(Application.ExecutablePath).DirectoryName + "\\" + view.Name.ToString() + ".xml";
                if (File.Exists(fileName))
                    view.RestoreLayoutFromXml(fileName);
            }

            

        }

        private void btField_Click(object sender, EventArgs e)
        {
            (this.grid.FocusedView as GridView).ColumnsCustomization();
      
        }

        private void StockEdit_QueryPopUp(object sender, CancelEventArgs e)
        {
            if (this.receiptDetailBindingSource.Count != 0)
                e.Cancel = true;
        }

        private void btPrintAkt_Click(object sender, EventArgs e)
        {
            ReportParameter p = new ReportParameter("ID", ((this.receiptMasterBindingSource.CurrencyManager.Current as DataRowView).Row as MDataSet.ReceiptMasterRow).ID.ToString());
            FormDialog formdialog = new FormDialog();
            printingControl print = new printingControl();
            formdialog.Text = "Печать приходного акта";
            formdialog.btOk.Visible = false;
            formdialog.panel.Controls.Add(print);

            print.reportViewer.ServerReport.ReportPath = "/ReportRatailTrade/ReceiptMasterByID";
       
            print.reportViewer.ServerReport.SetParameters(new ReportParameter[] { p });

            print.reportViewer.RefreshReport();
            formdialog.ShowDialog(this);
                  


        }

        private void btMove_Click(object sender, EventArgs e)
        {
           /* try
            {*/
                (this.ParentForm as MainForm).receiptMasterTableAdapter.ReceiptMasterMove(((this.receiptMasterBindingSource.CurrencyManager.Current as DataRowView).Row as MDataSet.ReceiptMasterRow).ID);
          /*  }
            catch
            { MessageBox.Show("Ошибка внутреннего перемещения!"); }

            finally
            { }*/

        }

       

    }
}
