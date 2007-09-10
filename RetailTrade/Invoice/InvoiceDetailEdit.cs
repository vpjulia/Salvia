using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;

namespace RetailTrade.Invoice
{
    public partial class InvoiceDetailEdit : UserControl
    {
        public InvoiceDetailEdit()
        {
            InitializeComponent();
        }


        public InvoiceDetailEdit(MDataSet.InvoiceMasterRow source)
        {
            InitializeComponent();

            this.mDataSet = source.Table.DataSet as MDataSet;

            this.vwRemainsBindingSource.DataSource = new DataView(this.mDataSet.vwRemains, "MainStockRef=" + source.MainStockRef.ToString(), null, DataViewRowState.CurrentRows);
           
           // this.vwRemainsBindingSource.DataSource = new DataView(this.mDataSet.vwRemains, "Quantityremains<>0 and MainStockRef=" + source.MainStockRef.ToString(), null, DataViewRowState.CurrentRows);
            this.vwRemainsBindingSource.ResetBindings(true);

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

          
                if (this.gridViewRemainsInvDetEdt.IsValidRowHandle(this.gridViewRemainsInvDetEdt.FocusedRowHandle) & this.gridViewRemainsInvDetEdt.State == GridState.Normal & !this.gridViewRemainsInvDetEdt.IsFilterRow(this.gridViewRemainsInvDetEdt.FocusedRowHandle))
                {
                    FormDialog _formDialog = new FormDialog();
                    _formDialog.AcceptButton = null;
                    _formDialog.Text = "�������� ������";

                    MDataSet.InvoiceDetailRow sourceRow = ((this.invoiceDetailBindingSource.AddNew() as DataRowView).Row as MDataSet.InvoiceDetailRow);
                    MDataSet.vwRemainsRow remainsRow = ((this.vwRemainsBindingSource.CurrencyManager.Current as DataRowView).Row as  MDataSet.vwRemainsRow);

                    if ((sourceRow != null) & (remainsRow != null))
                    {
                        InvoiceDetailRowAdd _invoiceDetailRowAdd = new InvoiceDetailRowAdd(sourceRow, remainsRow);
                        _formDialog.panel.Controls.Add(_invoiceDetailRowAdd);

                        if (DialogResult.OK == _formDialog.ShowDialog(this))
                        {
                            this.invoiceDetailBindingSource.EndEdit();
                         
                        }
                        else
                        {
                            this.invoiceDetailBindingSource.CancelEdit();
                            remainsRow.CancelEdit();
                        }
                    }
                }
           
        }

        private void gridRemains_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) & (this.gridViewRemainsInvDetEdt.IsValidRowHandle(this.gridViewRemainsInvDetEdt.FocusedRowHandle))& this.gridViewRemainsInvDetEdt.State == GridState.Normal & !this.gridViewRemainsInvDetEdt.IsFilterRow(this.gridViewRemainsInvDetEdt.FocusedRowHandle))
                this.btAdd_Click(sender, e);
    
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
                    InvoiceDetailRowAdd _invoiceDetailRowAdd = new InvoiceDetailRowAdd(sourceRow, sourceRow.vwRemainsRow);
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

            this.invoiceMasterBindingSource.CurrencyManager.EndCurrentEdit();

            this.invoiceDetailBindingSource.CurrencyManager.EndCurrentEdit();

            (this.invoiceMasterBindingSource.Current as MDataSet.InvoiceMasterRow).SetModified();

            if (FindMainForm(this.ParentForm).SaveToBase((this.invoiceMasterBindingSource.Current as MDataSet.InvoiceMasterRow)))
            {
                this.invoiceMasterBindingSource.ResetCurrentItem();
                this.Parent.Tag = "InvoiceRow" + (this.invoiceMasterBindingSource.Current  as MDataSet.InvoiceMasterRow).ID.ToString();
                this.Parent.Text = "�" /*+ ((this.receiptMasterBindingSource.Current as DataRowView).Row as MDataSet.InvoiceMasterRow).Number.ToString() + " " + ((this.invoiceMasterBindingSource.Current as DataRowView).Row as MDataSet.InvoiceMasterRow).OrganizationRow.ShortName.ToString()*/;
              //  this.panelNumber.Enabled = true;
                actionLabel.Text = "��������� ������";
                return true;
            }
            return false;
        }
        private void InvoiceDetailEdit_Validating(object sender, CancelEventArgs e)
        {
            if (!this.ValidateChildren())

                MessageBox.Show("������ � ������!");

           /* else
                this.SaveChange();
            */
        }

        private void gridViewinvDet_InvalidValueException(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
           //
        }

        private void InvoiceDetailEdit_Load(object sender, EventArgs e)
        {
            this.ParentForm.FormClosing+=new FormClosingEventHandler(ParentForm_FormClosing);
        }


        private void ParentForm_FormClosing(Object sender, CancelEventArgs e)
        {
          //  if ((this.mDataSet.InvoiceDetail.Select("InvoiceMasterRef=" + (this.invoiceMasterBindingSource.Current as MDataSet.InvoiceMasterRow).ID,null,DataViewRowState.Deleted).Length > 0)
                
            {
                    
                    DialogResult dlg= MessageBox.Show("��������� ���������?", "��������� ���������", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                         
                    if(dlg==DialogResult.Cancel)
                        e.Cancel = true;

                    if (dlg == DialogResult.Yes)
                        if (! this./*ParentForm.*/Validate())
                           e.Cancel = true;
                 
                    if (dlg == DialogResult.No)

                        foreach (MDataSet.InvoiceDetailRow invDetailCanc in this.mDataSet.InvoiceDetail.Select("InvoiceMasterRef=" + (this.invoiceMasterBindingSource.Current as MDataSet.InvoiceMasterRow).ID, null, DataViewRowState.Deleted))
                
                          invDetailCanc.RejectChanges();
                
                   
                }

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
           if (this.gridViewinvDet.IsValidRowHandle(this.gridViewinvDet.FocusedRowHandle) & this.gridViewinvDet.State == GridState.Normal & !this.gridViewinvDet.IsFilterRow(this.gridViewinvDet.FocusedRowHandle))
             if (DialogResult.OK== MessageBox.Show("������� �����?", "��������� ���������", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
              {

              this.invoiceDetailBindingSource.RemoveCurrent();
         
             }

        }

       

       

        
    }

}
