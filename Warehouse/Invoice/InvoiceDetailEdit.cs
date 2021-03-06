using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;

namespace RetailTrade.Invoice
{
    public partial class InvoiceDetailEdit : UserControl



    {

        MainForm _mainForm;
        
        public InvoiceDetailEdit()
        {
            InitializeComponent();
        }


        public InvoiceDetailEdit(MDataSet.InvoiceMasterRow source,MDataSet.ProductDataTable product,MainForm mainForm)
        {
            InitializeComponent();

            _mainForm = mainForm;

            this.mDataSet = source.Table.DataSet as MDataSet;

            this.productBindingSource.DataSource = product;
            
            this.productBindingSource.ResetBindings(false);



        //    this.RemainsBindingSource.DataSource = new DataView(this.mDataSet.Remains, "MainStockRef=" + source.MainStockRef.ToString(), null, DataViewRowState.CurrentRows);
           
            this.RemainsBindingSource.DataSource = new DataView(this.mDataSet.Remains, "Quantityremains<>0 and MainStockRef=" + source.MainStockRef.ToString(),"ProductName", DataViewRowState.CurrentRows);
            this.RemainsBindingSource.ResetBindings(true);

            this.invoiceMasterBindingSource.DataSource = source;
            this.invoiceMasterBindingSource.ResetBindings(true);


            this.invoiceMasterBindingSourceView.DataSource = source.Table;

            this.invoiceMasterBindingSourceView.ResetBindings(true);
            this.invoiceMasterBindingSourceView.CurrencyManager.Position = this.invoiceMasterBindingSourceView.Find("ID", source.ID);


            this.invoiceDetailBindingSource.DataSource = this.invoiceMasterBindingSourceView;
            this.invoiceDetailBindingSource.DataMember = "FK_InvoiceDetail_InvoiceMaster";
            this.invoiceDetailBindingSource.ResetBindings(true);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            /*������� ����� ������, ��������� �� ��� �  ��� ��������������*/
            MDataSet.RemainsRow _rems = this.gridViewRemainsInvDetEdt.GetDataRow(this.gridViewRemainsInvDetEdt.FocusedRowHandle) as MDataSet.RemainsRow;
            if (_rems == null) return;

            

                    FormDialog _formDialog = new FormDialog();
                    _formDialog.AcceptButton = _formDialog.btOk;
                    _formDialog.Text = "�������� ������";

                    MDataSet.InvoiceDetailRow sourceRow = ((this.invoiceDetailBindingSource.AddNew() as DataRowView).Row as MDataSet.InvoiceDetailRow);
                 
                    MDataSet.RemainsRow remainsRow = ((this.RemainsBindingSource.CurrencyManager.Current as DataRowView).Row as  MDataSet.RemainsRow);

                    MDataSet.ProductRow _productRow = (this.productBindingSource.DataSource as MDataSet.ProductDataTable).FindByID(remainsRow.ProductRef);


                    if ((sourceRow != null) & (remainsRow != null))
                    {
                        InvoiceDetailRowAdd _invoiceDetailRowAdd = new InvoiceDetailRowAdd(sourceRow, remainsRow,_productRow);
                        _formDialog.panel.Controls.Add(_invoiceDetailRowAdd);

                        if (DialogResult.OK == _formDialog.ShowDialog(this))
                        {  
                            remainsRow.AcceptChanges();
                            this.invoiceDetailBindingSource.EndEdit();
                          
                        }
                        else
                        {
                            this.invoiceDetailBindingSource.CancelEdit();
                            remainsRow.RejectChanges();
                        }
                    }
       }

        private void gridRemains_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void gridViewinvDet_DoubleClick(object sender, EventArgs e)
        {

            if (this.gridViewinvDet.IsValidRowHandle(this.gridViewinvDet.FocusedRowHandle) & this.gridViewinvDet.State == GridState.Normal & !this.gridViewinvDet.IsFilterRow(this.gridViewinvDet.FocusedRowHandle))
            {
                FormDialog _formDialog = new FormDialog();
                _formDialog.AcceptButton = null;
                _formDialog.Text = "�������� ������";

                MDataSet.InvoiceDetailRow sourceRow = ((this.invoiceDetailBindingSource.CurrencyManager.Current as DataRowView).Row as MDataSet.InvoiceDetailRow);
               
                if ((sourceRow != null) )
                {
                    MDataSet.ProductRow productRow = (this.productBindingSource.DataSource as MDataSet.ProductDataTable).FindByID(sourceRow.ProductRef);

                    if (productRow == null)
                    {
                        MessageBox.Show("������ ������ ������");
                        return;
                    }

                    InvoiceDetailRowAdd _invoiceDetailRowAdd = new InvoiceDetailRowAdd(sourceRow, sourceRow.RemainsRow,productRow);
                    _formDialog.panel.Controls.Add(_invoiceDetailRowAdd);

                    if (DialogResult.OK == _formDialog.ShowDialog(this))

                        this.invoiceDetailBindingSource.EndEdit();

                    else

                        this.invoiceDetailBindingSource.CancelEdit();

                }
            }
        }

        private void gridViewinvDet_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            this.gridViewinvDet.SetColumnError(this.gridViewinvDet.Columns[1], e.ErrorText.ToString());
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        private MainForm FindMainForm(Form sender)
        {
            if ((sender as MainForm) != null)
                return (sender as MainForm);
            else
                return FindMainForm(sender.Owner);
        }

        private bool SaveChange()
        {

                this.invoiceMasterBindingSource.ResetCurrentItem();
                this.Parent.Tag = "InvoiceRow" + (this.invoiceMasterBindingSource.Current  as MDataSet.InvoiceMasterRow).ID.ToString();
                this.Parent.Text = "�" /*+ ((this.receiptMasterBindingSource.Current as DataRowView).Row as MDataSet.InvoiceMasterRow).Number.ToString() + " " + ((this.invoiceMasterBindingSource.Current as DataRowView).Row as MDataSet.InvoiceMasterRow).OrganizationRow.ShortName.ToString()*/;
              //  this.panelNumber.Enabled = true;

                return true;
           
        }

        private void InvoiceDetailEdit_Validating(object sender, CancelEventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("������ � ������!");
                e.Cancel = true;
            }
           
        }

        private void gridViewinvDet_InvalidValueException(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
           //
        }

        private void InvoiceDetailEdit_Load(object sender, EventArgs e)
        {
            this.FindMainForm(this.ParentForm).RefreshData(this.mDataSet.Remains as DataTable);
            this.ParentForm.FormClosing+=new FormClosingEventHandler(ParentForm_FormClosing);
        }


        private void ParentForm_FormClosing(Object sender, CancelEventArgs e)
        {
          //  if ((this.mDataSet.InvoiceDetail.Select("InvoiceMasterRef=" + (this.invoiceMasterBindingSource.Current as MDataSet.InvoiceMasterRow).ID,null,DataViewRowState.Deleted).Length > 0)
                
            
                    
             /*   {    DialogResult dlg= MessageBox.Show("��������� ���������?", "��������� ���������", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                         
                    if(dlg==DialogResult.Cancel)
                        e.Cancel = true;

                    if (dlg == DialogResult.Yes)
                        if (! this.Validate())
                           e.Cancel = true;
              
                    if (dlg == DialogResult.No)

                        foreach (MDataSet.InvoiceDetailRow invDetailCanc in this.mDataSet.InvoiceDetail.Select("InvoiceMasterRef=" + (this.invoiceMasterBindingSource.Current as MDataSet.InvoiceMasterRow).ID, null, DataViewRowState.Deleted))
                
                          invDetailCanc.RejectChanges();
             
                   
                }*/

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if ((this.invoiceDetailBindingSource.Current as DataRowView)==null)

                return;

           MDataSet.RemainsRow rem = ((this.invoiceDetailBindingSource.Current as DataRowView).Row as MDataSet.InvoiceDetailRow).RemainsRow;
       
            if (this.gridViewinvDet.IsValidRowHandle(this.gridViewinvDet.FocusedRowHandle) & this.gridViewinvDet.State == GridState.Normal & !this.gridViewinvDet.IsFilterRow(this.gridViewinvDet.FocusedRowHandle))
             if (DialogResult.OK== MessageBox.Show("������� �����?", "��������� ���������", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
              {

              this.invoiceDetailBindingSource.RemoveCurrent();

              _mainForm.RefreshData(rem);
             }

        }

        private void btField_Click(object sender, EventArgs e)
        {
            (this.gridInvoiceDetail.FocusedView as GridView).ColumnsCustomization();
            (this.gridInvoiceDetail.FocusedView as GridView).CustomizationForm.TopMost = true;
           
        }

        private void btFieldRem_Click(object sender, EventArgs e)
        {
            (this.gridRemains.FocusedView as GridView).ColumnsCustomization();
            (this.gridRemains.FocusedView as GridView).CustomizationForm.TopMost = true;
           
        }

        private void gridViewRemainsInvDetEdt_KeyDown(object sender, KeyEventArgs e)
        {
          if (e.KeyCode == Keys.Enter)
            {
                MDataSet.RemainsRow _rems = this.gridViewRemainsInvDetEdt.GetDataRow(this.gridViewRemainsInvDetEdt.FocusedRowHandle) as MDataSet.RemainsRow;
               
                if (_rems!=null)
                this.btAdd_Click(sender, e);

            }
        }

        private void btFilter_Click(object sender, EventArgs e)
        {


            this.gridViewRemainsInvDetEdt.FocusedColumn=this.colProductRef1;
            this.gridViewRemainsInvDetEdt.FocusedRowHandle=GridControl.AutoFilterRowHandle;
        }
        
    }

}
