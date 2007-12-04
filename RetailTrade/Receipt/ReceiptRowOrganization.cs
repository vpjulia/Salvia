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
        
        MDataSet.ReceiptMasterRow _curentReceiptMasterRow;
        DataView _viewChangesReceiptDetail;

        DataView _viewModifedOriginal;

        public MDataSet.ReceiptMasterRow CurentReceiptMasterRow
        {
            get { return _curentReceiptMasterRow; }
            set { _curentReceiptMasterRow = value; }
        }           

        public DataView ViewChangesReceiptDetail
{
  get { return _viewChangesReceiptDetail; }
  set { _viewChangesReceiptDetail = value; }
}


         // constructor
        public ReceiptRowOrganization()
        {
            InitializeComponent();
        }
        public ReceiptRowOrganization(MDataSet.ReceiptMasterRow source, int currentID)
        {
            
            //** receiptMasterBindingSource - таблица  *//
          
            InitializeComponent();

           _curentReceiptMasterRow = source;

           this.mDataSet = source.Table.DataSet as MDataSet;

           this.receiptMasterBindingSource.DataSource =new DataView(source.Table,"ID="+_curentReceiptMasterRow.ID.ToString(),null,DataViewRowState.CurrentRows);

           this.receiptMasterBindingSource.ResetBindings(false);


           _viewModifedOriginal = new DataView(source.Table, "ID=" + _curentReceiptMasterRow.ID.ToString(), null, DataViewRowState.ModifiedOriginal);
           _viewModifedOriginal.ListChanged += new ListChangedEventHandler(_viewModifedOriginal_ListChanged);
 
            _viewChangesReceiptDetail = new DataView(this.mDataSet.ReceiptDetail, "ReceiptMasterRef=" + _curentReceiptMasterRow.ID.ToString(), null, DataViewRowState.Added | DataViewRowState.Deleted | DataViewRowState.ModifiedCurrent);
         
            _viewChangesReceiptDetail.ListChanged+=new ListChangedEventHandler(_viewChangesReceiptDetail_ListChanged);

            
            (this.receiptMasterBindingSource.DataSource as DataView).ListChanged += new ListChangedEventHandler(_viewChangesReceiptDetail_ListChanged);

        
           this.organizationBindingSource.DataSource = this.mDataSet.Organization;
           this.organizationBindingSource.ResetBindings(false);

           this.stockBindingSource.DataSource = this.mDataSet.Stock;
          
           this.productBindingSource.DataSource = this.mDataSet.Product;

           this.receiptDetailBindingSource.DataSource = this.receiptMasterBindingSource;
           this.receiptDetailBindingSource.DataMember = "ReceiptMaster_ReceiptDetail";
           this.receiptDetailBindingSource.ResetBindings(true);
         
           
          

            if (source.ID < 0)
            {
                this.panelNumber.Enabled = false;
                this.btMove.Visible = false;
            }
            if (_curentReceiptMasterRow.GetReceiptDetailRows().Length == 0)
            {
                this.btMove.Visible = false;
            //    this.btPrintAkt.Visible = false;
            }




            this.AuthorLabel.Text = "Автор :" + _curentReceiptMasterRow.AuthorCreate.ToString();
      
          
        }

    


        private void ReceiptRowOrganization_Load(object sender, EventArgs e)
        {
            foreach (GridView view in this.grid.ViewCollection)
            {
                string fileName = new FileInfo(Application.ExecutablePath).DirectoryName + "\\" + view.Name.ToString() + ".xml";
                if (File.Exists(fileName))
                    view.RestoreLayoutFromXml(fileName);
            }

     
            if (_curentReceiptMasterRow.HasVersion(DataRowVersion.Original))
            {
                (this.ParentForm as MainForm).RefreshData(_curentReceiptMasterRow);
                _curentReceiptMasterRow.RejectChanges();
                
            }
           

            this.ParentForm.FormClosing += new FormClosingEventHandler(ParentForm_FormClosing);


        }
    
        private void _viewChangesReceiptDetail_ListChanged(object sender, ListChangedEventArgs e) 
        {
            
            if (_viewChangesReceiptDetail.Count > 0)
            {
                this.btMove.Visible = false;
              
                this.btCancel.Visible = true;
                this.btSaveReciept.Enabled = true;
            }
            else
            {
                
                this.btCancel.Visible =false;
                this.btSaveReciept.Enabled = false;
               if ( _curentReceiptMasterRow.HasVersion(DataRowVersion.Original))
               {
                if (_curentReceiptMasterRow.GetReceiptDetailRows().Length == 0)
                    this.btMove.Visible = false;
                else
                    this.btMove.Visible = true;
               }
            }
 

        }

        void _viewModifedOriginal_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (_viewModifedOriginal.Count >0)
            {
            
                if ((_viewModifedOriginal[0].Row as MDataSet.ReceiptMasterRow).RowVersion != _curentReceiptMasterRow.RowVersion)
                {
                    this.modifedStripStatusLabel.Text = (_viewModifedOriginal[0].Row as MDataSet.ReceiptMasterRow).AuthorLastModif.ToString();
                }

          
            }


        }
 //
        private bool SaveChanges()
        {
            this.receiptMasterBindingSource.CurrencyManager.EndCurrentEdit();
            this.receiptDetailBindingSource.CurrencyManager.EndCurrentEdit();


           if (this.gridViewReceiptRowMain.HasColumnErrors)
           {
               this.receiptMasterBindingSource.CancelEdit();
               return false;
           }


              if ((this.ParentForm as MainForm).SaveToBase(_curentReceiptMasterRow))
            {
                this.receiptMasterBindingSource.DataSource = new DataView(_curentReceiptMasterRow.Table, "ID=" + _curentReceiptMasterRow.ID.ToString(), null, DataViewRowState.CurrentRows);

                this.receiptMasterBindingSource.ResetBindings(false);
                this.receiptDetailBindingSource.ResetBindings(true);
              
                this.Parent.Tag = "ReceiptRowOrganization" + _curentReceiptMasterRow.ID.ToString();
                this.Parent.Text = "№" + _curentReceiptMasterRow.Number.ToString() + " " + _curentReceiptMasterRow.OrganizationRow.ShortName.ToString();
                this.panelNumber.Enabled = true;
            }
            return true;
        }

      
        private bool CancelChanges()
        { 
            this.receiptDetailBindingSource.CancelEdit();
            this.receiptMasterBindingSource.CancelEdit();
            foreach (DataRowView _datarow in _viewChangesReceiptDetail)
            {
              
                         
                _datarow.Row.RejectChanges();

            }

            _curentReceiptMasterRow.RejectChanges();

            if ((_curentReceiptMasterRow.RowState == (DataRowState.Detached) | (_curentReceiptMasterRow.RowState == DataRowState.Added)))
            {
                if ((this.ParentForm as MainForm) != null)
                    (this.ParentForm as MainForm).DeleteDataTab(this.Parent as TabPage);      
                
            }
            
            return true;
        }
         
        //

       
        //

        private void gridView1_InvalidValueException(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            MessageBox.Show(e.ErrorText);
        }

        private void gridView1_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            this.gridViewReceiptRowMain.SetColumnError(this.gridViewReceiptRowMain.Columns[1], e.ErrorText.ToString());
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;

        }
       
        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            this.btEdit.PerformClick();
        }
  //
       
        private void btEdit_Click(object sender, EventArgs e)
        {
            this.receiptMasterBindingSource.EndEdit();
           
            FormDialog _formDialog = new FormDialog();
            _formDialog.Text = "№ " + _curentReceiptMasterRow.Number.ToString() + "  " + _curentReceiptMasterRow.OrganizationRow.ShortName.ToString();
            _formDialog.AcceptButton = null;
            ReceiptDetailByRef _peceiptDetail = new ReceiptDetailByRef(_curentReceiptMasterRow,(this.ParentForm as MainForm).fullDataSet.Product,(this.ParentForm as MainForm));
      
            _formDialog.panel.Controls.Add(_peceiptDetail);

            if (DialogResult.Cancel == _formDialog.ShowDialog(this))
            {
                this.receiptDetailBindingSource.CancelEdit();
            }
        }


 

        private void btSaveReciept_Click(object sender, EventArgs e)
        {
            this.SaveChanges();
        }

       
        private void btCancel_Click(object sender, EventArgs e)
        {
            this.CancelChanges(); 
          

        }

      
        private void btField_Click(object sender, EventArgs e)
        {
            (this.grid.FocusedView as GridView).ColumnsCustomization();
      
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
 
        private void StockEdit_QueryPopUp(object sender, CancelEventArgs e)
        {
            if (this.receiptDetailBindingSource.Count != 0)
            {
                e.Cancel = true;
            }
            else
            {

                this.stockBindingSource.Filter = "IsLocal=true";
            }

        }

    
        private void btMove_Click(object sender, EventArgs e)
        {
          try
          {
            (this.ParentForm as MainForm).receiptMasterTableAdapter.ReceiptMasterMove(_curentReceiptMasterRow.ID);
          
            (this.ParentForm as MainForm).RefreshData(this.mDataSet.ReceiptMaster as DataTable);
          }
            catch
            { MessageBox.Show("Ошибка внутреннего перемещения!"); }

            finally
            {
              this.btClose.PerformClick();  
            }
        }
    
       
       
      
        private void ReceiptRowOrganization_Validating(object sender, CancelEventArgs e)
        {
            this.receiptMasterBindingSource.EndEdit();
            this.receiptDetailBindingSource.EndEdit();
        }
   
        private void btClose_Click(object sender, EventArgs e)
        {
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

            this.receiptMasterBindingSource.EndEdit();
            this.receiptDetailBindingSource.EndEdit();


            if (this.gridViewReceiptRowMain.HasColumnErrors)
            {
                MessageBox.Show("Ошибка в данных!");

            }
            else
            {

                if ((_viewChangesReceiptDetail.Count > 0)|(_curentReceiptMasterRow.RowState!=DataRowState.Unchanged)) 
                {
                    DialogResult _result;

                    _result = MessageBox.Show("Сохранить изменения? ", "Сохранение приходного акта "+this.ToString(), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    switch (_result)
                    {
                        case DialogResult.Yes:
                            if (this.SaveChanges())
                            {
                                if ((this.ParentForm as MainForm) != null)
                                    (this.ParentForm as MainForm).DeleteDataTab(this.Parent as TabPage); 
                            }
                           break;
                        case DialogResult.No:
                           this.CancelChanges(); 
                             if ((this.ParentForm as MainForm) != null)
                                 (this.ParentForm as MainForm).DeleteDataTab(this.Parent as TabPage); 
                            break;
                        case DialogResult.Cancel:
        
                            break;
                    } 

                }
                else
                    if ((this.ParentForm as MainForm) != null)
                        (this.ParentForm as MainForm).DeleteDataTab(this.Parent as TabPage); 

                }
 
        }

        private void ParentForm_FormClosing(object sender, FormClosingEventArgs e) 
        {

           


        }

    }
}
