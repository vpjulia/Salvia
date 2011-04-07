using System;

using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Localization;



using System.Threading;
//using System.Data.SqlClient;
using RetailTradeClient.Invoice;
using RetailTradeClient.Receipt;

using RetailTradeClient.Remains;
using System.IO;
using RetailTradeClient.Invoice.InvoiceTradePutlet;
using RetailTradeClient.Invoice.InvoiceDatecs;
using RetailTradeClient.Printers;
using RetailTradeClient.Dialog;

using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;




namespace RetailTradeClient
{
   
    
    public partial class MainForm : Form
    {
        Thread thread;

        

        public static void Log(String logMessage )
        {

            string datefile = DateTime.Now.Year.ToString() + '_' + DateTime.Now.Month.ToString() + '_' + DateTime.Now.Day.ToString();


            string path = (Application.StartupPath +"\\log_" + datefile + ".txt");

            TextWriter w;

            if (!File.Exists(path))
                w = File.CreateText(path);
            else
                w = File.AppendText(path);


           
            w.Write("\r\nLog Entry : ");
            w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                DateTime.Now.ToLongDateString());
            w.WriteLine("  :");
            w.WriteLine("  :{0}", logMessage);
            w.WriteLine("-------------------------------");
            
            w.Flush();
            w.Close();
        }

        public static void DeleteOldLogs()
        {

            DirectoryInfo dir = new DirectoryInfo(Application.StartupPath);
            foreach (FileInfo f in dir.GetFiles("log*.txt"))
            {
                String name = f.Name;
                long size = f.Length;
                DateTime creationTime = f.CreationTime;
                if( creationTime < DateTime.Now.AddDays(-7))
                   File.Delete(f.Name);


            }


        }


      

        public MDataSet.LocalSettingRow LocalSettingRow
        {
            get
            {
                if (this.localSettingBindingSource.Current != null)
                    return (this.localSettingBindingSource.Current as DataRowView).Row as MDataSet.LocalSettingRow;

                else
                    return null;
            }
        }


        public MainForm()
        {
            thread = new Thread(new ThreadStart(DoSplash));
            thread.Start();
            Thread.Sleep(300);
          
            DeleteOldLogs();
        
            InitializeComponent();
 
            this.components.Add(this.productTableAdapter, "productTableAdapter");
           
            this.components.Add(this.receiptMasterTableAdapter, "receiptMasterTableAdapter");
            this.components.Add(this.receiptDetailTableAdapter, "receiptDetailTableAdapter");
            this.components.Add(this.documentTypeTableAdapter, "documentTypeTableAdapter");
            this.components.Add(this.invoiceDetailTableAdapter, "invoiceDetailTableAdapter");
            this.components.Add(this.invoiceMasterTableAdapter, "invoiceMasterTableAdapter");
            this.components.Add(this.RemainsTableAdapter, "RemainsTableAdapter");
            this.components.Add(this.localSettingTableAdapter, "localSettingTableAdapter");
            /*Fulldataset*/

            this.components.Add(this.cashTableAdapter, "cashTableAdapter");
            
           
            this.components.Add(this.periodsTableAdapter, "periodsTableAdapter");
            Log("InitializeComponent true");
            /*  FillTable("Product");
            FillTable("Organization");
        */
         
            
        }
     



        private void MainForm_Load(object sender, EventArgs e)
        {
            
            try
            {
                FillTable("LocalSetting");
                FillTable("Periods");
                FillTable("Cash");
                FillTable("Product");
                FillTable("Remains");
            }

            catch (Exception err)
            {
                MessageBox.Show("MainForm_Load ERROR " + err.Message);
                Log("MainForm_Load ERROR " + err.Message + " " + err.Source + err.InnerException.Message);
            }
            finally
            {
                Log("MainForm_Load   finally");
            
            }


            
            //FormLogon _logon = new FormLogon(LocalSettingRow);

            //if (DialogResult.OK != _logon.ShowDialog(this))
            //{
            //    Application.Exit();
            //    return;
            //}

            //this.LabelUser.Text = LocalSettingRow.FullName;
            //this.Text += " : " + LocalSettingRow.Name; 

            
            
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
         

            _changesInvoiceDetail = new DataView(this.mDataSet.InvoiceDetail,null,null,DataViewRowState.Added | DataViewRowState.ModifiedCurrent|DataViewRowState.Deleted);

            //if (this.LocalSettingRow.Printer == "Maria")
            //{
            //    this.MariaMenu.Visible = true;
            //    this.DatecsMenu.Visible = false;

            //}
            //else
            //{
            //    this.MariaMenu.Visible = false;
            //    this.DatecsMenu.Visible = true;

            //}

            Log("MainForm_Load True ");
           
              
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

       
     /*    private UserControl Init(ref String TagControl, ref string Title)
        {
            UserControl usControl;
            return usControl;
        
        }

     */
        private UserControl InitReceiptImport(ref String TagControl, ref string Title)
        {
            UserControl usControl;

            usControl = new ReceiptImport();
            (usControl as ReceiptImport).Dock = DockStyle.Fill;
            (usControl as ReceiptImport).Tag = Title;


            return usControl;

        }
        private UserControl InitRemains(ref String TagControl, ref string Title)
        {
            UserControl usControl;
            usControl = new RemainsLocal(this.mDataSet.Remains);
            (usControl as RemainsLocal).Dock = DockStyle.Fill;
            (usControl as RemainsLocal).Tag = Title;



            return usControl;

        }
        

      /*  private UserControl InitInvoiceRow(ref string TagControl, ref string Title, params object[] list)
        {
            UserControl usControl;

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
                            {
                                return null;
                            }
                            return usControl;

                   }

            return null;
        }*/
       
     
        private UserControl InitReceiptMasterStock(ref String TagControl, ref string Title)
        {
            UserControl usControl;
            usControl = new ReceiptMasterStock(this.mDataSet);
            (usControl as ReceiptMasterStock).Dock = DockStyle.Fill;
            (usControl as ReceiptMasterStock).Tag = Title;


            return usControl;

        }
        private UserControl InitReceiptMasterNewAll(ref String TagControl, ref string Title)
        {
            UserControl usControl;


                        usControl = new ReceiptMasterNewAll(this.mDataSet);
                       (usControl as ReceiptMasterNewAll).Dock = DockStyle.Fill;
                       (usControl as ReceiptMasterNewAll).Tag = Title;
                        


            return usControl;

        }
        
       

       

        private UserControl InitProjectSettings(ref String TagControl, ref string Title)
        {
            UserControl usControl;

            usControl = new ProjectSettings();
            (usControl as ProjectSettings).Dock = DockStyle.Fill;
            (usControl as ProjectSettings).Tag = Title;

            return usControl;

        }



        private UserControl InitInvoiceDetail(ref String TagControl, ref string Title)
        {
            UserControl usControl;

            usControl = new InvoiceDetail();
            (usControl as InvoiceDetail).Dock = DockStyle.Fill;
            (usControl as InvoiceDetail).Tag = Title;

            return usControl;

        }

        private UserControl InitInvoiceReturn(ref String TagControl, ref string Title)
        {
            UserControl usControl;

            usControl = new InvoiceReturn();
            (usControl as InvoiceReturn).Dock = DockStyle.Fill;
            (usControl as InvoiceReturn).Tag = Title;

            return usControl;

        }

       
        
        private UserControl InitInvoiceTradePutletAll(ref String TagControl, ref string Title)
        {
            UserControl usControl;

            MDataSet.LocalSettingRow _localset = (this.localSettingBindingSource.CurrencyManager.Current as DataRowView).Row as MDataSet.LocalSettingRow;

            if (_localset.Printer == "Maria")
            {

                usControl = new InvoiceTradePutletAll(this.mDataSet);

                (usControl as InvoiceTradePutletAll).Dock = DockStyle.Fill;

                (usControl as InvoiceTradePutletAll).Tag = Title;

            }

            else
            {
                usControl = new InvoiceTradePutletDatecs(this.mDataSet);

                (usControl as InvoiceTradePutletDatecs).Dock = DockStyle.Fill;

                (usControl as InvoiceTradePutletDatecs).Tag = Title;

            
            
            }
          
            return usControl;

        }

        private UserControl InitInventory(ref String TagControl, ref string Title)
        {
            UserControl usControl;

            usControl = new Inventory(this);
            (usControl as Inventory).Dock = DockStyle.Fill;
            (usControl as Inventory).Tag = Title;

            return usControl;

        }

        
        
        public bool ShowNewDataTab(String TagControl, string Title,params object[] list)
        {
          if (!FindOpenedTabs(TagControl))
            {
                UserControl usControl = null;
              
                switch (TagControl)
                {
                   
                    case "ReceiptMasterNewAll":

                        usControl = InitReceiptMasterNewAll(ref TagControl, ref Title);

                        if (usControl == null)
                            return false;
                                                
                        break;

                    case "ReceiptMasterStock":

                        usControl = InitReceiptMasterStock(ref TagControl, ref Title);

                        if (usControl == null)
                            return false;

                        break;

                   case "Remains":
                       usControl = InitRemains(ref TagControl, ref Title);

                       if (usControl == null)
                           return false;
                       break;

                   case "ReceiptImport":

                       usControl = InitReceiptImport(ref TagControl, ref Title);

                       if (usControl == null)
                           return false;
                     
                       break;

                   

                  
                   case "ProjectSettings":

                       usControl = InitProjectSettings(ref TagControl, ref Title);

                       if (usControl == null)
                           return false;

                       break;

                   case "InvoiceTradePutletAll":

                       usControl = InitInvoiceTradePutletAll(ref TagControl, ref Title);

                       if (usControl == null)
                           return false;

                       break;

                   case "InvoiceDetail":

                       usControl = InitInvoiceDetail(ref TagControl, ref Title);

                       if (usControl == null)
                           return false;

                       break;

                   case "InvoiceReturn":

                       usControl = InitInvoiceReturn(ref TagControl, ref Title);

                       if (usControl == null)
                           return false;

                       break;

                  
                   case "Inventory":

                       usControl = InitInventory(ref TagControl, ref Title);

                       if (usControl == null)
                           return false;

                       break;
                    
                    default:
                        {
                            return false;
                        }
                }
                    TabPage newTab = new TabPage(Title);
                    newTab.Tag = TagControl;
                    newTab.Controls.Add(usControl);
                    tabControl.TabPages.Add(newTab);
                  //  tabControl.TabPages[tabControl.TabPages.Count - 1].Tag = TagControl;
                    tabControl.SelectedTab = newTab;

                    return true;
              
            }
            return false;
        }






        public void DeleteDataTab(TabPage tabPage)
        {
            
                
            
            

            tabControl.TabPages.Remove(tabPage);
            GC.Collect();
        }
        
       
        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowNewDataTab((sender as ToolStripItem).Tag.ToString(), (sender as ToolStripItem).ToolTipText.ToString());
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

       

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Log("MainForm_FormClosed : " + e.CloseReason.ToString());
        }

        private void btMariaXreport_Click(object sender, EventArgs e)
        {
            Maria301Printer _printer = new Maria301Printer(1);
           
            if (_printer.HasError)
            {
                MessageBox.Show("������ ������������� �������� ");
                _printer.Done();
                return;
            }


            if (DialogResult.OK == MessageBox.Show(this, "��������� ���� � ��������� � ����� ", "������ � ������", MessageBoxButtons.OKCancel, MessageBoxIcon.Information))
            {
                _printer.XReport();
            
            }

            while (_printer.KeyPosition != Maria301Printer.KeyPositions.Work)
            {
                MessageBox.Show("��������� ���� � ������� ���������!", "������ ������ ���������");
            }



            _printer.Done();




        }

        private void btMariaZReport_Click(object sender, EventArgs e)
        {

            Maria301Printer _printer = new Maria301Printer(1);

            if (_printer.HasError)
            {
                MessageBox.Show("������ ������������� �������� ");
                _printer.Done();
                return;
            }

             /* ���� ��� ������*/

                MDataSet.CashRow _firstRow;

                DataRow[] dataRowsInTable = this.mDataSet.Cash.Select("NumZ = " + _printer.Info.NumZ.ToString());

                if (dataRowsInTable.Length == 0)
                {
                    dataRowsInTable = this.mDataSet.Cash.Select("NumZ = -1");
                    if (dataRowsInTable.Length != 0)
                    {
                        _firstRow = (dataRowsInTable[0] as MDataSet.CashRow);
                        _firstRow.NumZ = _printer.Info.NumZ;
                    }
                    else
                    {
                        _firstRow = (this.cashBindingSource.AddNew()as DataRowView).Row as MDataSet.CashRow;

                        _firstRow.NumZ = _printer.Info.NumZ;
                        _firstRow.Date = DateTime.Today;
                        _firstRow.BalanceBegin = _printer.Info.BalanceBegin;
                        _firstRow.BalanceEnd = _printer.Info.BalanceEnd;
                        _firstRow.OfIncome = 0;
                        _firstRow.OfExpend = _printer.Info.OfExpend;
                        _firstRow.Income = _printer.Info.Income;
                        _firstRow.Expend = 0;
                        this.cashBindingSource.EndEdit();
                        this.cashTableAdapter.Update(_firstRow);
                    }
                }
                else
                {
                    _firstRow = null;
                }
            



            if ((_printer.Info.ifJustZ)&_firstRow!=null)
            {
                  _firstRow.NumZ += 1;




                  DataRow[] _forSave = new DataRow[1];
                  _forSave[0] = _firstRow;

                  this.SaveToBaseDirectoryModifed(_forSave);
             
                _printer.Done();

                MessageBox.Show("Z ����� ��� ����!");
                return;
            }

    
            this.cashBindingSource.Position = this.cashBindingSource.Find("NumZ", _printer.Info.NumZ);
           
            MDataSet.CashRow _cashRow = (this.cashBindingSource.Current as DataRowView).Row as MDataSet.CashRow;
            
            if (_cashRow == null)
            {
                MessageBox.Show("�� ����������������� �����!");
                return;
            }

            int newZ = _printer.Info.NumZ + 1;

            _cashRow.NumZ = _printer.Info.NumZ;
            _cashRow.Date = DateTime.Today;
            _cashRow.BalanceBegin = _printer.Info.BalanceBegin;
            _cashRow.OfIncome = 0;
            _cashRow.OfExpend = _printer.Info.OfExpend;
            _cashRow.Income = _printer.Info.Income;
            _cashRow.Expend = 0;
            _cashRow.BalanceEnd = _printer.Info.BalanceEnd;


            DataRow[] _modif1 = new DataRow[1];
            _modif1[0] = _cashRow;

            if (!this.SaveToBaseDirectoryModifed(_modif1))
            {
                _printer.Done();

                return;
            }


            if (DialogResult.OK == MessageBox.Show(this, "��������� ���� � ��������� Z ����� ", "������ Z �������� ������", MessageBoxButtons.OKCancel, MessageBoxIcon.Information))
            {
                _printer.ZReport();

            }


            try
            {
                this.cashTableAdapter.ClosePeriod(newZ);
                this.cashTableAdapter.Fill(this.mDataSet.Cash);
                this.FillTableNewDocuments(this.mDataSet.InvoiceMaster);

         
            }

            catch (Exception err)
            {
                Log("Zreport" + err.Message);
                MessageBox.Show("������!!! " + err.Message);

            }

            finally
            {

                this.cashBindingSource.Position = this.cashBindingSource.Find("NumZ", newZ);

            }





            while (_printer.KeyPosition != Maria301Printer.KeyPositions.Work)
            {
                MessageBox.Show("��������� ���� � ������� ���������!", "������ �������������� ������ ���������");
            }


            MessageBox.Show("������� � ����� : " + _printer.Info.BalanceEnd.ToString(), "������ �������� ������ (Z-�����)");

            _printer.Done();

        }

        
        private void btMariaZperiodReport_Click(object sender, EventArgs e)
        {

            Maria301Printer _printer = new Maria301Printer(1);

            if (_printer.HasError)
            {
                MessageBox.Show("������ ������������� �������� ");
                _printer.Done();
                return;
            }

            

            if (DialogResult.OK == MessageBox.Show(this, "��������� ���� � ��������� Z ����� ", "������ ������ �� ������", MessageBoxButtons.OKCancel, MessageBoxIcon.Information))
            {
                if (_printer.KeyPosition != Maria301Printer.KeyPositions.ZReport)
                {
                    _printer.Done();
                    return;
                }


                DialogPeriod _DialogPeriod = new DialogPeriod();

                if (_DialogPeriod.ShowDialog(this) == DialogResult.OK)
                {

                    if (!_printer.ZPeriodReport(_DialogPeriod.StartDate, _DialogPeriod.EndDate))
                    {
                        MessageBox.Show("������ ������ �� ���������");

                    }
                }
            }
        

            while (_printer.KeyPosition != Maria301Printer.KeyPositions.Work)
            {
                MessageBox.Show("��������� ���� � ������� ���������!","������ �������������� Z ������ ���������");
            }
            _printer.Done();


        }

        private void btDatecsXReport_Click(object sender, EventArgs e)
        {
            Datecs _printer = new Datecs();

            if (_printer.HasError)
            {
            
                MessageBox.Show("������ �������� : " + _printer.ErrorText);
                _printer.Close();
            
                return;
            }


            _printer.XReport();

          
                if (_printer.HasError)
                {

                    MessageBox.Show("������ �������� : " + _printer.ErrorText);
                    _printer.Close();

                    return;
                }



               MessageBox.Show("���������� : " + _printer.printerCashInfo.Income.ToString(),"������ �������� ������ (�-�����)");

               _printer.Close();

        }

        private void menuDatecsZReport_Click(object sender, EventArgs e)
        {
            Datecs _printer = new Datecs();
            MDataSet.CashRow _cashRow;
            if (_printer.HasError)
            {

                MessageBox.Show("������ �������� : " + _printer.ErrorText);
                _printer.Close();

                return;
            }
       
            //�������� ������ ���� ���
          
            this.cashBindingSource.Position= this.cashBindingSource.Find("NumZ", -1);

            if (this.cashBindingSource.Current != null)
            {
                _cashRow = (this.cashBindingSource.Current as DataRowView).Row as MDataSet.CashRow;
            }

            else
            {

                _cashRow = (this.cashBindingSource.AddNew() as DataRowView).Row as MDataSet.CashRow;
                 _cashRow.Date = DateTime.Today;
                _cashRow.BalanceBegin = _printer.printerCashInfo.BalanceBegin;
                _cashRow.OfIncome = 0;
                _cashRow.OfExpend = _printer.printerCashInfo.OfExpend;
                _cashRow.Income = _printer.printerCashInfo.Income;
                _cashRow.Expend = 0;
                _cashRow.BalanceEnd = _printer.printerCashInfo.BalanceEnd;

                 DataRow[] _modifnew = new DataRow[1];
                _modifnew[0] = _cashRow;

               if (!this.SaveToBaseDirectoryModifed(_modifnew))
                {
                    _printer.Close();
                   
                    return;
                }

            }

            if (_cashRow == null)
            {
                MessageBox.Show("�� ����������������� �����!");
                return;
            }


            if (DialogResult.Cancel == MessageBox.Show(this, "����� Z ����� � ���������� ? ", "������ Z ������", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
            {
                return;
            }
            
            
                _cashRow.Date = DateTime.Today;
                _cashRow.BalanceBegin = _printer.printerCashInfo.BalanceBegin;
                _cashRow.OfIncome = 0;
                _cashRow.OfExpend = _printer.printerCashInfo.OfExpend;
                _cashRow.Income = _printer.printerCashInfo.Income;
                _cashRow.Expend = 0;
                _cashRow.BalanceEnd = _printer.printerCashInfo.BalanceEnd;


                DataRow[] _modif1 = new DataRow[1];
                _modif1[0] = _cashRow;

               if (!this.SaveToBaseDirectoryModifed(_modif1))
                {
                    _printer.Close();
                   
                    return;
                }

                _cashRow.NumZ =  _printer.ZReport();
                                   
                DataRow[] _modif = new DataRow[1];
                _modif[0] = _cashRow;

                if (!this.SaveToBaseDirectoryModifed(_modif))
                {
                    MessageBox.Show("�� ������� �������� ������!");

                    Log(" ������ Z ������ :(!this.SaveToBaseDirectoryModifed(_modif)) ");

                    _printer.Close();

                    return ;
                }

                try
                {
                    this.cashTableAdapter.ClosePeriod(-1);

                    MDataSet.CashDataTable _cash = new MDataSet.CashDataTable();


                    this.cashTableAdapter.Fill(_cash);

                    this.mDataSet.Cash.Merge(_cash);
                }

                catch ( Exception err)

                {
                    Log("Zreport" + err.Message);
                    MessageBox.Show("������!!! " + err.Message);
                   
                }

                finally
                {

                   this.cashBindingSource.Position = this.cashBindingSource.Find("NumZ", -1);
  
                }
        
            MessageBox.Show("������� � ����� : " + _printer.printerCashInfo.BalanceEnd.ToString(), "������ �������� ������ (Z-�����)");

            _printer.Close();


        }

        private void btMariaOfExpend_Click(object sender, EventArgs e)
        {
            Maria301Printer _printer = new Maria301Printer(this.LocalSettingRow.Num);

            if (_printer.HasError)
            {
                _printer.Done();
                
                MessageBox.Show("������ ��������: " + _printer.ErrorText);
                
                
                return;
            }

            if (_printer.Info.ifJustZ)
            {
               
                _printer.Done();

                MessageBox.Show(" ��� ���� Z �����! ");
                return;
            }


            this.cashBindingSource.Position = this.cashBindingSource.Find("NumZ", _printer.Info.NumZ);

            MDataSet.CashRow _cashRow = (this.cashBindingSource.Current as DataRowView).Row as MDataSet.CashRow;

            if (_cashRow == null)
            {
                MessageBox.Show("�� ����������������� �����!");
                _printer.Done();
                return;
            }

         
            _cashRow.NumZ = _printer.Info.NumZ;
            _cashRow.Date = DateTime.Today;
            _cashRow.BalanceBegin = _printer.Info.BalanceBegin;
            _cashRow.OfIncome = 0;
            _cashRow.OfExpend = _printer.Info.OfExpend;
            _cashRow.Income = _printer.Info.Income;
            _cashRow.Expend = 0;
            _cashRow.BalanceEnd = _printer.Info.BalanceEnd;

            
            DialogOfExpend _DialogOfExpend = new DialogOfExpend(_cashRow);

            if (DialogResult.OK==_DialogOfExpend.ShowDialog(this))
            {
                if (!_printer.OfExpend(_DialogOfExpend.SummExpend))
                {
                    MessageBox.Show("�� ������� ������ ����� !");
                    _printer.Done();
                    return;
                
                }
   
            _cashRow.NumZ = _printer.Info.NumZ;
            _cashRow.Date = DateTime.Today;
            _cashRow.BalanceBegin = _printer.Info.BalanceBegin;
            _cashRow.OfIncome = 0;
            _cashRow.OfExpend = _printer.Info.OfExpend;
            _cashRow.Income = _printer.Info.Income;
            _cashRow.Expend = 0;
            _cashRow.BalanceEnd = _printer.Info.BalanceEnd;


            DataRow[] _modif1 = new DataRow[1];
            _modif1[0] = _cashRow;

            if (!this.SaveToBaseDirectoryModifed(_modif1))
            {
                _printer.Done();

                return;
            }
            }
 
            _printer.Done();

        }

        private void btInventory_Click(object sender, EventArgs e)
        {
            this.ShowNewDataTab(this.btInventory.Tag.ToString(), this.btInventory.ToolTipText);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void btDatecsCloseCheck_Click(object sender, EventArgs e)
        {
            Datecs _printer = new Datecs();
            _printer.CancelCheck("������!!!");

            _printer.CloseCheck(10000, 0,1000);
            _printer.Close();
        }

        private void btDatecsPeriodReport_Click(object sender, EventArgs e)
        {
           
            Datecs _printer = new Datecs();

            if (_printer.HasError)
            {

                MessageBox.Show("������ �������� :" + _printer.ErrorText);
                _printer.Close();
                return;
            }

            DialogPeriod _DialogPeriod = new DialogPeriod();

            if (_DialogPeriod.ShowDialog(this) == DialogResult.OK)
            {

                if (!_printer.ZPeriodReport(_DialogPeriod.StartDate, _DialogPeriod.EndDate))
                {
                    MessageBox.Show("������ ������ �� ���������");

                }
            }
            _printer.Close();

        }

        private void btDatecsOfExpend_Click(object sender, EventArgs e)
        { 
            
            Datecs _printer = new Datecs();

            if (_printer.HasError)
            {

                MessageBox.Show("������ �������� :" + _printer.ErrorText);
                _printer.Close();
                return;
            }
           
            this.cashBindingSource.Position = this.cashBindingSource.Find("NumZ", -1);

            MDataSet.CashRow _cashRow = (this.cashBindingSource.Current as DataRowView).Row as MDataSet.CashRow;

            if (_cashRow == null)
            {
                MessageBox.Show("�� ����������������� �����!");
                _printer.Close();
                return;
            }


            _cashRow.NumZ = _printer.printerCashInfo.NumZ;
            _cashRow.Date = DateTime.Today;
            _cashRow.BalanceBegin = _printer.printerCashInfo.BalanceBegin;
            _cashRow.OfIncome = 0;
            _cashRow.OfExpend = _printer.printerCashInfo.OfExpend;
            _cashRow.Income = _printer.printerCashInfo.Income;
            _cashRow.Expend = 0;
            _cashRow.BalanceEnd = _printer.printerCashInfo.BalanceEnd;


            DialogOfExpend _DialogOfExpend = new DialogOfExpend(_cashRow);

            if (DialogResult.OK == _DialogOfExpend.ShowDialog(this))
            {
                if (!_printer.OfExpend((double)_DialogOfExpend.SummExpend))
                {
                    MessageBox.Show("�� ������� ������ ����� !");
                    _printer.Close();
                    return;

                }

                _cashRow.NumZ = _printer.printerCashInfo.NumZ;
                _cashRow.Date = DateTime.Today;
                _cashRow.BalanceBegin = _printer.printerCashInfo.BalanceBegin;
                _cashRow.OfIncome = 0;
                _cashRow.OfExpend = _printer.printerCashInfo.OfExpend;
                _cashRow.Income = _printer.printerCashInfo.Income;
                _cashRow.Expend = 0;
                _cashRow.BalanceEnd = _printer.printerCashInfo.BalanceEnd;


                DataRow[] _modif1 = new DataRow[1];
                _modif1[0] = _cashRow;

                if (!this.SaveToBaseDirectoryModifed(_modif1))
                {
                    _printer.Close();

                    return;
                }
            }

            _printer.Close();



        }

        private void btPeriodReportByNum_Click(object sender, EventArgs e)
        {
            Datecs _printer = new Datecs();
            if (_printer.HasError)
            {

                MessageBox.Show("������ �������� :" + _printer.ErrorText);
                _printer.Close();
                return;
            }

            DialogPeriodNum dialogPeriodNum = new DialogPeriodNum();

            if (dialogPeriodNum.ShowDialog(this.ParentForm) == DialogResult.OK)
            {

                _printer.ZPeriodReport((int)dialogPeriodNum.startEdit.Value, (int)dialogPeriodNum.endEdit.Value);

            }
            _printer.Close();
        }

        public void ProductReport(int productRef)
        {
            try
            {
                FormPrintDialog formPrintDialog = new FormPrintDialog("RetailTrade.Resources.ProductReport.rdlc");
                formPrintDialog.ProductRef = productRef;
                formPrintDialog.ShowDialog(this);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public void PeriodSumReport(string name)
        {
            try
            {
                FormPrintDialog formPrintDialog = new FormPrintDialog(name);
                formPrintDialog.TradePutletRef= this.LocalSettingRow.MainTradePutletRef;

                formPrintDialog.ShowDialog(this);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

            }

        }

        private void btReportSum_Click(object sender, EventArgs e)
        {
            this.PeriodSumReport("RetailTradeCLReriodical");
        }

     }
}