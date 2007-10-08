using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Localization;
using RetailTrade.Directory;
using Microsoft.Reporting.WinForms;


using System.Threading;
using System.Data.SqlClient;
using RetailTrade.Invoice;
using RetailTrade.Receipt;
using RetailTrade.Orders;




namespace RetailTrade
{
   
    
    public partial class MainForm : Form
    {
        Thread thread;
        public MainForm()
        {
            thread = new Thread(new ThreadStart(DoSplash));
            thread.Start();
            Thread.Sleep(300);
        
            InitializeComponent();
            this.components.Add(this.productTableAdapter, "productTableAdapter");
            this.components.Add(this.manufacturerTableAdapter, "manufacturerTableAdapter");
            this.components.Add(this.farmGroupTableAdapter, "farmGroupTableAdapter");
            this.components.Add(this.farmGroupLevel2TableAdapter, "farmGroupLevel2TableAdapter");
            this.components.Add(this.packingTableAdapter, "packingTableAdapter");
            this.components.Add(this.storageConditionTableAdapter, "storageConditionTableAdapter");
            this.components.Add(this.substanceTableAdapter, "substanceTableAdapter");
            this.components.Add(this.unitTableAdapter,"unitTableAdapter");
            this.components.Add(this.countryTableAdapter,"countryTableAdapter");
            this.components.Add(this.organizationTableAdapter, "organizationTableAdapter");
            this.components.Add(this.tradePutletTableAdapter, "tradePutletTableAdapter");
            this.components.Add(this.stockTableAdapter, "stockTableAdapter");

            this.components.Add(this.receiptMasterTableAdapter, "receiptMasterTableAdapter");
            this.components.Add(this.receiptDetailTableAdapter, "receiptDetailTableAdapter");
            this.components.Add(this.documentTypeTableAdapter, "documentTypeTableAdapter");
            this.components.Add(this.OrdersTableAdapter, "OrdersTableAdapter");
            this.components.Add(this.invoiceDetailTableAdapter, "invoiceDetailTableAdapter");
            this.components.Add(this.invoiceMasterTableAdapter, "invoiceMasterTableAdapter");
            this.components.Add(this.RemainsTableAdapter, "RemainsTableAdapter");
            this.components.Add(this.pricesPurchaseTableAdapter, "pricesPurchaseTableAdapter");

          /*  FillTable("Product");
            FillTable("Organization");
        */
            FillTable("Stock");
         
            FillTable("ReceiptDetail");
            FillTable("Orders");
            FillTable("InvoiceDetail");
            FillTable("PricesPurchase");

            //this.productTableAdapter.Fill(this.mDataSet.Product);
        }
       
        
        

        private void Form1_Load(object sender, EventArgs e)
        {
           


            SanseeGridLocalizer gLocalizer = new SanseeGridLocalizer();
            GridLocalizer.Active = gLocalizer;
         
            
         
            thread.Abort();
            Thread.Sleep(30);

           

          //  System.Configuration.AppSettingsReader app = new System.Configuration.AppSettingsReader();

         //   MessageBox.Show(app.GetValue("RetailTradeConnectionString", System.Type.GetType("System.String")).ToString());

            this.mDataSet.ReceiptDetail.ColumnChanging += new DataColumnChangeEventHandler(ReceiptDetailColumn_Changing);
            this.mDataSet.InvoiceMaster.ColumnChanging += new DataColumnChangeEventHandler(InvoiceMasterColumn_Changing);
            
            this.mDataSet.InvoiceMaster.ColumnChanged += new  DataColumnChangeEventHandler (InvoiceMasterColumn_Changed);
            
            this.mDataSet.InvoiceDetail.ColumnChanging += new DataColumnChangeEventHandler(InvoiceDetailColumn_Changing);
            this.mDataSet.InvoiceDetail.ColumnChanged += new DataColumnChangeEventHandler(InvoiceDetailColumn_Changed);
            this.mDataSet.InvoiceDetail.RowDeleting += new DataRowChangeEventHandler(InvoiceDetail_RowDeleting);
            this.mDataSet.InvoiceDetail.TableNewRow+=new DataTableNewRowEventHandler(InvoiceDetail_TableNewRow);
            this.mDataSet.InvoiceDetail.RowDeleted+=new DataRowChangeEventHandler(InvoiceDetail_RowDeleted);
            this.mDataSet.InvoiceDetail.RowChanged+=new DataRowChangeEventHandler(InvoiceDetail_RowChanged);
            this.mDataSet.ReceiptDetail.RowChanged+=new DataRowChangeEventHandler(ReceiptDetail_RowChanged);
            this.mDataSet.ReceiptDetail.TableNewRow+=new DataTableNewRowEventHandler(ReceiptDetail_TableNewRow);  
            this.mDataSet.ReceiptDetail.RowDeleted+=new DataRowChangeEventHandler(ReceiptDetail_RowDeleted);
            this.mDataSet.ReceiptDetail.RowDeleting+=new DataRowChangeEventHandler(ReceiptDetail_RowDeleting);
                //+=new DataRowChangeEventHandler(ReceiptDetail_RowDeleting);
        }

      
        
        public class SanseeGridLocalizer : GridLocalizer
        {
            public override string GetLocalizedString(GridStringId id)
            {
                switch (id)
                {
                    case GridStringId.FileIsNotFoundError: return "���� �� ������!";
                    case GridStringId.ColumnViewExceptionMessage: return "ColumnViewExceptionMessage";
                    case GridStringId.CustomizationCaption: return "����� �����";
                    case GridStringId.CustomizationColumns: return "CustomizationColumns";
                    case GridStringId.CustomizationBands: return "CustomizationBands";
                    case GridStringId.PopupFilterAll: return "��� ������";
                    case GridStringId.PopupFilterCustom: return "��������� ...";
                    case GridStringId.PopupFilterBlanks: return "������ ������";
                    case GridStringId.PopupFilterNonBlanks: return "�������� ������";
                    case GridStringId.CustomFilterDialogFormCaption: return "��������� �������";
                    case GridStringId.CustomFilterDialogCaption: return "��������� �������";
                    case GridStringId.CustomFilterDialogRadioAnd: return "�";
                    case GridStringId.CustomFilterDialogRadioOr: return "���";
                    case GridStringId.CustomFilterDialogOkButton: return "�������";
                    case GridStringId.CustomFilterDialogClearFilter: return "��������";
                    case GridStringId.CustomFilterDialog2FieldCheck: return "�������";
                    case GridStringId.CustomFilterDialogCancelButton: return "������";
                    case GridStringId.CustomFilterDialogConditionEQU: return "�����";
                    case GridStringId.CustomFilterDialogConditionNEQ: return "�� �����";
                    case GridStringId.CustomFilterDialogConditionGT: return "������";
                    case GridStringId.CustomFilterDialogConditionGTE: return "������ ��� �����";
                    case GridStringId.CustomFilterDialogConditionLT: return "������";
                    case GridStringId.CustomFilterDialogConditionLTE: return "������ ��� �����";
                    case GridStringId.CustomFilterDialogConditionBlanks: return "������";
                    case GridStringId.CustomFilterDialogConditionNonBlanks: return "�� ������";
                    case GridStringId.CustomFilterDialogConditionLike: return "��������";
                    case GridStringId.CustomFilterDialogConditionNotLike: return "�� ��������";
                    case GridStringId.WindowErrorCaption: return "������!";
                    case GridStringId.MenuFooterSum: return "�����";
                    case GridStringId.MenuFooterMin: return "�������";
                    case GridStringId.MenuFooterMax: return "��������";
                    case GridStringId.MenuFooterCount: return "����������";
                    case GridStringId.MenuFooterAverage: return "�������";
                    case GridStringId.MenuFooterNone: return "���";
                    case GridStringId.MenuFooterSumFormat: return "������ �����";

                    case GridStringId.MenuFooterMinFormat: return "������ ���";
                    case GridStringId.MenuFooterMaxFormat: return "������ ����";
                    case GridStringId.MenuFooterCountFormat: return "������ ���.";
                    case GridStringId.MenuFooterAverageFormat: return "������ �����.";
                    case GridStringId.MenuColumnSortAscending: return "�� �����������";
                    case GridStringId.MenuColumnSortDescending: return "�� ��������";
                    case GridStringId.MenuColumnGroup: return "������������...";
                    case GridStringId.MenuColumnUnGroup: return "��������������...";
                    case GridStringId.MenuGroupPanelFullCollapse: return "�������� ���";
                    case GridStringId.MenuGroupPanelFullExpand: return "���������� ���";
                    case GridStringId.MenuColumnBestFitAllColumns: return "���������� �������";
                    case GridStringId.MenuColumnClearFilter: return "�������� ������";
                    case GridStringId.MenuColumnFilter: return "������";
                    case GridStringId.MenuColumnBestFit: return "���������� ������";
                    case GridStringId.MenuColumnColumnCustomization: return "��������� �����";
                    case GridStringId.MenuColumnGroupBox: return "������ �����������";
                    case GridStringId.PrintDesignerBandHeader: return "PrintDesignerBandHeader";
                    case GridStringId.PrintDesignerBandedView: return "PrintDesignerBandedView";
                    case GridStringId.PrintDesignerCardView: return "PrintDesignerCardView";
                    case GridStringId.PrintDesignerGridView: return "PrintDesignerGridView";
                    case GridStringId.MenuGroupPanelClearGrouping: return "�������� �����������";
                    case GridStringId.PrintDesignerDescription: return "PrintDesignerDescription";
                    case GridStringId.GridOutlookIntervals: return "GridOutlookIntervals";
                    case GridStringId.GridNewRowText: return "����� ������";
                    case GridStringId.GridGroupPanelText: return "������������...";
                    case GridStringId.CardViewQuickCustomizationButtonSort: return "�����������";
                    case GridStringId.CardViewQuickCustomizationButtonFilter: return "������";
                    case GridStringId.CardViewQuickCustomizationButton: return "��������";
                    case GridStringId.CardViewNewCard: return "����� ������";

                }
                return "GridString �� �������";
            }
        }


        public bool FindOpenedTabs(String TagControl)
        {
            for (int i = 0; i < tabControl.TabPages.Count; i++)
       
                if (tabControl.TabPages[i].Tag.Equals(TagControl))
                {
                    tabControl.SelectedTab = tabControl.TabPages[i];
                    return true;
                }
                   return false;
        }
        public bool ShowNewDataTab(string TagControl, string Title,params object[] list)
        {
          if (!FindOpenedTabs(TagControl))
            {
                UserControl usControl = null;
              
                switch (TagControl)
                {
                    case "UCProductAll":
                     
                       usControl = new UCProductAll(this.mDataSet);
                       usControl.Dock = DockStyle.Fill;
                       usControl.Tag = "���������� �������";
                      //  (uc as UCSPR).NameWorkTable = _NameTable;
                        //  uc.Tag = _NameTable;  
                     break;

                    case "Manufacturer":

                      usControl = new UcGroupDirectory(this.mDataSet.Tables["Manufacturer"]);
                     (usControl as   UcGroupDirectory).errorProvider1.DataSource = this.mDataSet;

                     (usControl as UcGroupDirectory).gridView.FocusedRowHandle = DevExpress.XtraGrid.GridControl.AutoFilterRowHandle;
                     (usControl as UcGroupDirectory).gridView.FocusedColumn = (usControl as UcGroupDirectory).gridView.Columns["Name"];
                     (usControl as UcGroupDirectory).Tag = "���������� �������������";
                        (usControl as UcGroupDirectory).Dock = DockStyle.Fill;
                       
                        break;
                    case "FarmGroupLevel2":
                        usControl = new UcGroupDirectory(this.mDataSet.Tables["FarmGroupLevel2"]);
                        (usControl as UcGroupDirectory).errorProvider1.DataSource = this.mDataSet;

                        (usControl as UcGroupDirectory).gridView.FocusedRowHandle = DevExpress.XtraGrid.GridControl.AutoFilterRowHandle;
                        (usControl as UcGroupDirectory).gridView.FocusedColumn = (usControl as UcGroupDirectory).gridView.Columns["Name"];
                        (usControl as UcGroupDirectory).Tag = Title;
                        (usControl as UcGroupDirectory).Dock = DockStyle.Fill;
          
                        break;

                    case "Organization":
                         usControl = new UCOrganizationAll(this.mDataSet);
                        //(usControl as UcGroupDirectory).errorProvider1.DataSource = this.mDataSet;

                         (usControl as UCOrganizationAll).gridView.FocusedRowHandle = DevExpress.XtraGrid.GridControl.AutoFilterRowHandle;
                         (usControl as UCOrganizationAll).gridView.FocusedColumn = (usControl as UCOrganizationAll).gridView.Columns["Name"];
                         (usControl as UCOrganizationAll).Tag = Title;
                        (usControl as UCOrganizationAll).Dock = DockStyle.Fill;
    
                        break;

                    case "TradePutlet":
                        usControl = new UCTradePuplet(this.mDataSet);
                        (usControl as UCTradePuplet).gridView.FocusedRowHandle = DevExpress.XtraGrid.GridControl.AutoFilterRowHandle;
                        (usControl as UCTradePuplet).gridView.FocusedColumn = (usControl as UCTradePuplet).gridView.Columns["Name"];
                        (usControl as UCTradePuplet).Dock = DockStyle.Fill;
                        (usControl as UCTradePuplet).Tag = Title;
                        break;

                    case "ReceiptMasterNewAll":

                        usControl = new ReceiptMasterNewAll(this.mDataSet);
                       (usControl as ReceiptMasterNewAll).Dock = DockStyle.Fill;
                       (usControl as ReceiptMasterNewAll).Tag = Title;
                        break;

                    case "ReceiptMasterStock":

                        usControl = new ReceiptMasterStock(this.mDataSet);
                        (usControl as ReceiptMasterStock).Dock = DockStyle.Fill;
                        (usControl as ReceiptMasterStock).Tag = Title;
                        break;



                    case "ReceiptRowOrganization":

                        if ((list[0] as MDataSet.ReceiptMasterRow) != null)
                        {
                           
                            TagControl += (list[0] as MDataSet.ReceiptMasterRow).ID.ToString();
                            if (!FindOpenedTabs(TagControl))
                            {
                                Title = "�" + (list[0] as MDataSet.ReceiptMasterRow).Number.ToString() + " " + (list[0] as MDataSet.ReceiptMasterRow).OrganizationRow.ShortName.ToString();
                                 usControl = new ReceiptRowOrganization((list[0] as MDataSet.ReceiptMasterRow), (list[0] as MDataSet.ReceiptMasterRow).ID);
                                (usControl as ReceiptRowOrganization).Tag = Title;
                                (usControl as ReceiptRowOrganization).Dock = DockStyle.Fill;
                            }
                            else
                                return  false;
                        }
                        break;
                    case "InvoiceMasterNew":
                       usControl = new InvoiceMasterNewAll(this.mDataSet);
                       (usControl as InvoiceMasterNewAll).Dock = DockStyle.Fill;
                       (usControl as InvoiceMasterNewAll).Tag = Title;
                     
                     break;

                 case "InvoiceRow":
                    

                    if ((list[0] as MDataSet.InvoiceMasterRow) != null)
                        {
                           
                            TagControl += (list[0] as MDataSet.InvoiceMasterRow).ID.ToString();
                            if (!FindOpenedTabs(TagControl))
                            {
                                 Title = "�" + (list[0] as MDataSet.InvoiceMasterRow).Number.ToString() + " " + (list[0] as MDataSet.InvoiceMasterRow).TradePupletName.ToString();
                                 usControl = new InvoiceRow((list[0] as MDataSet.InvoiceMasterRow));
                                (usControl as InvoiceRow).Tag = Title;
                                (usControl as InvoiceRow).Dock = DockStyle.Fill;
                            }
                            else
                                return  false;
                   }
                       break;
                   case "OrdersAll":
                       usControl = new OrdersAll(this.mDataSet.Orders);
                       (usControl as OrdersAll).Dock = DockStyle.Fill;
                       (usControl as OrdersAll).Tag = Title;

                       break;


                    default:
                        {
                            return false;
                        }
                }
               
                    TabPage newTab = new TabPage(Title);
                    newTab.Controls.Add(usControl);
                    tabControl.TabPages.Add(newTab);
                    tabControl.TabPages[tabControl.TabPages.Count - 1].Tag = TagControl;
                    tabControl.SelectedTab = newTab;

                    return true;
              
            }
            return false;
        }
        private bool ShowNewSimpleDirectotyTab(string TagControl, string Title, params object[] list)
        {
            if (!FindOpenedTabs(TagControl))
            {
                
            UCSimpleDirectory ucSimpleDirectory = new UCSimpleDirectory(this.mDataSet.Tables[TagControl]);
            ucSimpleDirectory.errorProvider1.DataSource = this.mDataSet;
            
            ucSimpleDirectory.gridView.FocusedRowHandle = DevExpress.XtraGrid.GridControl.AutoFilterRowHandle;
            ucSimpleDirectory.gridView.FocusedColumn = ucSimpleDirectory.gridView.Columns["Name"];
            ucSimpleDirectory.Dock = DockStyle.Fill;
            ucSimpleDirectory.Tag = Title;
            TabPage newTab = new TabPage(Title);
            newTab.Controls.Add(ucSimpleDirectory);
            tabControl.TabPages.Add(newTab);
            tabControl.TabPages[tabControl.TabCount - 1].Tag = TagControl;
            tabControl.SelectedTab = newTab;

                return true;
            }
            return false;
        }
     
        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowNewDataTab((sender as ToolStripItem).Tag.ToString(), (sender as ToolStripItem).ToolTipText.ToString());
        }

        private void SampleDirectoryMenuItem_Click(object sender, EventArgs e)
        {
            ShowNewSimpleDirectotyTab((sender as ToolStripItem).Tag.ToString(), (sender as ToolStripItem).ToolTipText.ToString());
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag!=null)
             ShowNewDataTab(e.Node.Tag.ToString(),e.Node.ToolTipText.ToString());
        }

        private void mainReportViewer_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            FormDialog _fDialog = new FormDialog();
            _fDialog.panel.Controls.Add(this.mainReportViewer);
            
            
             if (DialogResult.OK == _fDialog.ShowDialog(this))
                {
                    MessageBox.Show("ok"); 
                }
               
        }

        
    
    }
}