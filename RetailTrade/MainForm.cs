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
using RetailTrade.Remains;




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
           /*Fulldataset*/

            this.components.Add(this.manufacturerTableAdapter1, "manufacturerTableAdapter1");
       
            
            this.components.Add(this.productTableAdapter1, "productTableAdapter1");

            this.components.Add(this.farmGroupTableAdapter1, "farmGroupTableAdapter1");
            this.components.Add(this.farmGroupLevel2TableAdapter1, "farmGroupLevel2TableAdapter1");
            this.components.Add(this.packingTableAdapter1, "packingTableAdapter1");
            this.components.Add(this.storageConditionTableAdapter1, "storageConditionTableAdapter1");
            this.components.Add(this.substanceTableAdapter1, "substanceTableAdapter1");
            this.components.Add(this.unitTableAdapter1, "unitTableAdapter1");
            this.components.Add(this.countryTableAdapter1, "countryTableAdapter1");
            this.components.Add(this.periodsTableAdapter, "periodsTableAdapter");
            
            /*  FillTable("Product");
            FillTable("Organization");
        */
         
            
        }
     
        private void MainForm_Load(object sender, EventArgs e)
        {
              try
            {

                FillTable("Stock");
                FillTable("Periods");
                FillTable("Product");
                FillTable("Organization");
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }


           /* FillTable("Orders");
            FillTable("InvoiceDetail");
            FillTable("PricesPurchase");
            */


            SanseeGridLocalizer gLocalizer = new SanseeGridLocalizer();
            GridLocalizer.Active = gLocalizer;
         
            
         
            thread.Abort();
            Thread.Sleep(30);

         /*   this.Size = Properties.Settings.Default.MySize;

            this.Location = Properties.Settings.Default.MyLoc;

            this.WindowState = Properties.Settings.Default.MyState;
            */
            
           
          //  System.Configuration.AppSettingsReader app = new System.Configuration.AppSettingsReader();

         //   MessageBox.Show(app.GetValue("RetailTradeConnectionString", System.Type.GetType("System.String")).ToString());

            this.mDataSet.ReceiptDetail.ColumnChanging += new DataColumnChangeEventHandler(ReceiptDetailColumn_Changing);
            this.mDataSet.ReceiptDetail.RowChanged+=new DataRowChangeEventHandler(ReceiptDetail_RowChanged);
            this.mDataSet.ReceiptDetail.TableNewRow+=new DataTableNewRowEventHandler(ReceiptDetail_TableNewRow);  
            this.mDataSet.ReceiptDetail.RowDeleted+=new DataRowChangeEventHandler(ReceiptDetail_RowDeleted);
            this.mDataSet.ReceiptDetail.RowDeleting+=new DataRowChangeEventHandler(ReceiptDetail_RowDeleting);



            this.mDataSet.InvoiceMaster.ColumnChanging += new DataColumnChangeEventHandler(InvoiceMasterColumn_Changing);
            
            this.mDataSet.InvoiceMaster.ColumnChanged += new  DataColumnChangeEventHandler (InvoiceMasterColumn_Changed);
       
            this.mDataSet.InvoiceDetail.ColumnChanging += new DataColumnChangeEventHandler(InvoiceDetailColumn_Changing);
            this.mDataSet.InvoiceDetail.ColumnChanged += new DataColumnChangeEventHandler(InvoiceDetailColumn_Changed);
            this.mDataSet.InvoiceDetail.RowDeleting += new DataRowChangeEventHandler(InvoiceDetail_RowDeleting);
            this.mDataSet.InvoiceDetail.TableNewRow+=new DataTableNewRowEventHandler(InvoiceDetail_TableNewRow);
            this.mDataSet.InvoiceDetail.RowDeleted+=new DataRowChangeEventHandler(InvoiceDetail_RowDeleted);
            this.mDataSet.InvoiceDetail.RowChanged+=new DataRowChangeEventHandler(InvoiceDetail_RowChanged);
            
              
        }
           
       
        public class SanseeGridLocalizer : GridLocalizer
        {
            public override string GetLocalizedString(GridStringId id)
            {
                switch (id)
                {
                    case GridStringId.FileIsNotFoundError: return "Файл не найден!";
                    case GridStringId.ColumnViewExceptionMessage: return "ColumnViewExceptionMessage";
                    case GridStringId.CustomizationCaption: return "Выбор полей";
                    case GridStringId.CustomizationColumns: return "CustomizationColumns";
                    case GridStringId.CustomizationBands: return "CustomizationBands";
                    case GridStringId.PopupFilterAll: return "Все записи";
                    case GridStringId.PopupFilterCustom: return "Настройка ...";
                    case GridStringId.PopupFilterBlanks: return "Пустые записи";
                    case GridStringId.PopupFilterNonBlanks: return "Непустые записи";
                    case GridStringId.CustomFilterDialogFormCaption: return "Настройка фильтра";
                    case GridStringId.CustomFilterDialogCaption: return "Параметры фильтра";
                    case GridStringId.CustomFilterDialogRadioAnd: return "И";
                    case GridStringId.CustomFilterDialogRadioOr: return "ИЛИ";
                    case GridStringId.CustomFilterDialogOkButton: return "Принять";
                    case GridStringId.CustomFilterDialogClearFilter: return "Очистить";
                    case GridStringId.CustomFilterDialog2FieldCheck: return "Выбрать";
                    case GridStringId.CustomFilterDialogCancelButton: return "Отмена";
                    case GridStringId.CustomFilterDialogConditionEQU: return "Равно";
                    case GridStringId.CustomFilterDialogConditionNEQ: return "Не равно";
                    case GridStringId.CustomFilterDialogConditionGT: return "Больше";
                    case GridStringId.CustomFilterDialogConditionGTE: return "Больше или равно";
                    case GridStringId.CustomFilterDialogConditionLT: return "Меньше";
                    case GridStringId.CustomFilterDialogConditionLTE: return "Меньше или равно";
                    case GridStringId.CustomFilterDialogConditionBlanks: return "пустое";
                    case GridStringId.CustomFilterDialogConditionNonBlanks: return "не пустое";
                    case GridStringId.CustomFilterDialogConditionLike: return "Содержит";
                    case GridStringId.CustomFilterDialogConditionNotLike: return "Не содержит";
                    case GridStringId.WindowErrorCaption: return "Ошибка!";
                    case GridStringId.MenuFooterSum: return "Сумма";
                    case GridStringId.MenuFooterMin: return "Минимум";
                    case GridStringId.MenuFooterMax: return "Максимум";
                    case GridStringId.MenuFooterCount: return "Количество";
                    case GridStringId.MenuFooterAverage: return "Среднее";
                    case GridStringId.MenuFooterNone: return "Нет";
                    case GridStringId.MenuFooterSumFormat: return "Формат суммы";

                    case GridStringId.MenuFooterMinFormat: return "Формат мин";
                    case GridStringId.MenuFooterMaxFormat: return "Формат макс";
                    case GridStringId.MenuFooterCountFormat: return "Формат кол.";
                    case GridStringId.MenuFooterAverageFormat: return "Формат средн.";
                    case GridStringId.MenuColumnSortAscending: return "По возрастанию";
                    case GridStringId.MenuColumnSortDescending: return "По убыванию";
                    case GridStringId.MenuColumnGroup: return "Группировать...";
                    case GridStringId.MenuColumnUnGroup: return "Разгуппировать...";
                    case GridStringId.MenuGroupPanelFullCollapse: return "Свернуть все";
                    case GridStringId.MenuGroupPanelFullExpand: return "Развернуть все";
                    case GridStringId.MenuColumnBestFitAllColumns: return "Автоформат таблицы";
                    case GridStringId.MenuColumnClearFilter: return "Очистить фильтр";
                    case GridStringId.MenuColumnFilter: return "Фильтр";
                    case GridStringId.MenuColumnBestFit: return "Автоподбор ширины";
                    case GridStringId.MenuColumnColumnCustomization: return "Настройка полей";
                    case GridStringId.MenuColumnGroupBox: return "Панель группировки";
                    case GridStringId.PrintDesignerBandHeader: return "PrintDesignerBandHeader";
                    case GridStringId.PrintDesignerBandedView: return "PrintDesignerBandedView";
                    case GridStringId.PrintDesignerCardView: return "PrintDesignerCardView";
                    case GridStringId.PrintDesignerGridView: return "PrintDesignerGridView";
                    case GridStringId.MenuGroupPanelClearGrouping: return "Отменить группировку";
                    case GridStringId.PrintDesignerDescription: return "PrintDesignerDescription";
                    case GridStringId.GridOutlookIntervals: return "GridOutlookIntervals";
                    case GridStringId.GridNewRowText: return "Новая строка";
                    case GridStringId.GridGroupPanelText: return "Группировать...";
                    case GridStringId.CardViewQuickCustomizationButtonSort: return "Сортировать";
                    case GridStringId.CardViewQuickCustomizationButtonFilter: return "Фильтр";
                    case GridStringId.CardViewQuickCustomizationButton: return "Натройка";
                    case GridStringId.CardViewNewCard: return "Новая запись";

                }
                return "GridString не найдена";
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



                        if (Title.Contains("НДС"))
                        {
                            TagControl += "NDS";
                            if (!FindOpenedTabs(TagControl))
                            {
                                usControl = new UCProductAll(this.fullDataSet, true);
                            }
                            else
                                return false;

                        }
                        else
                        {
                            TagControl += "outNDS";
                            if (!FindOpenedTabs(TagControl))
                            {
                                usControl = new UCProductAll(this.fullDataSet, false);
                            }
                            else
                                return false;
                        
                        }
                       usControl.Dock = DockStyle.Fill;

                       usControl.Tag = Title;
                      
                    
                     break;

                    case "Manufacturer":

                      usControl = new UcGroupDirectory(this.mDataSet.Tables["Manufacturer"]);
                     (usControl as   UcGroupDirectory).errorProvider1.DataSource = this.mDataSet;

                     (usControl as UcGroupDirectory).gridView.FocusedRowHandle = DevExpress.XtraGrid.GridControl.AutoFilterRowHandle;
                     (usControl as UcGroupDirectory).gridView.FocusedColumn = (usControl as UcGroupDirectory).gridView.Columns["Name"];
                     (usControl as UcGroupDirectory).Tag = "Справочник изготовителей";
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
                                Title = "№" + (list[0] as MDataSet.ReceiptMasterRow).Number.ToString() + " " + (list[0] as MDataSet.ReceiptMasterRow).OrganizationRow.ShortName.ToString();
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
                                 Title = "№" + (list[0] as MDataSet.InvoiceMasterRow).Number.ToString() + " " + (list[0] as MDataSet.InvoiceMasterRow).TradePupletName.ToString();
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
                   case "Remains":
                       usControl = new RemainsLocal(this.mDataSet.Remains);
                       (usControl as RemainsLocal).Dock = DockStyle.Fill;
                       (usControl as RemainsLocal).Tag = Title;

                       break;

                   case "ReceiptImport":
                       usControl = new ReceiptImport();
                       (usControl as ReceiptImport).Dock = DockStyle.Fill;
                       (usControl as ReceiptImport).Tag = Title;

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

        public void DeleteDataTab(TabPage tagPage)
        {

            tabControl.TabPages.Remove(tagPage);
       
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

        /*    FormDialog _fDialog = new FormDialog();
            _fDialog.panel.Controls.Add(this.mainReportViewer);
            
            
             if (DialogResult.OK == _fDialog.ShowDialog(this))
                {
                    MessageBox.Show("ok"); 
                }
               */
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            Properties.Settings.Default.MyState = this.WindowState;

            if (this.WindowState == FormWindowState.Normal)
            {

                Properties.Settings.Default.MySize = this.Size;

                Properties.Settings.Default.MyLoc = this.Location;

            }

            else
            {

                Properties.Settings.Default.MySize = this.RestoreBounds.Size;

                Properties.Settings.Default.MyLoc = this.RestoreBounds.Location;

            }
  
            Properties.Settings.Default.Save();

        }

        private void btAddProduct_Click(object sender, EventArgs e)
        { 
            DataRow res = this.AddProduct();
            if( res.RowState== DataRowState.Added)
            {

            Label _name = new Label();
            TextBox _id = new TextBox();
            _id.ReadOnly = true;
            _id.SelectAll();
 
            _name.AutoSize = true;
            _name.DataBindings.Add(new Binding ("Text",res,"Name"));
            
 
            _id.DataBindings.Add(new Binding("Text", res, "Id"));
            
   
           _id.Location = new Point(5,25);
          

            _name.Location = new Point(5, 5);
           
            FormDialog _frmDialog = new FormDialog();
            _frmDialog.btCancel.Visible = false;
            _frmDialog.Text = "Добавлен товар ";
            _frmDialog.panel.Controls.Add(_name);
           

            _frmDialog.panel.Controls.Add(_id);
            _frmDialog.ShowDialog(this);
            
            }


        
        }

       

        
    
    }
}