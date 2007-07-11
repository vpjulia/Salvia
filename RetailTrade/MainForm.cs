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
            this.components.Add(this.receiptMasterNewTableAdapter, "receiptMasterNewTableAdapter");
            FillTable("Product");
            FillTable("Organization");
           // FillTable("TradePuplet");
            FillTable("Stock");
            FillTable("ReceiptMasterNew");
            //this.productTableAdapter.Fill(this.mDataSet.Product);
        }
       
        
        private void DoSplash()
        {

            SplashScreen sp = new SplashScreen();
            sp.label.Text = Environment.UserDomainName;
            sp.ShowDialog();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
          /*  Properties.Settings settings = Properties.Settings.Default;
            settings["RetailTradeConnectionString"]="новая строка";
            settings.Save();
            */
            this.receiptMasterTableAdapter.Fill(this.mDataSet.ReceiptMaster);
      
            // TODO: This line of code loads data into the 'mDataSet.ReceiptDetail' table. You can move, or remove it, as needed.
            this.receiptDetailTableAdapter.Fill(this.mDataSet.ReceiptDetail);
           

// TODO: This line of code loads data into the 'mDataSet.ReceiptMaster' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'mDataSet.ReceiptMasterNew' table. You can move, or remove it, as needed.
           
         this.receiptMasterNewTableAdapter.Fill(this.mDataSet.ReceiptMasterNew);
            // TODO: This line of code loads data into the 'mDataSet.Stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.mDataSet.Stock);
       
            SanseeGridLocalizer gLocalizer = new SanseeGridLocalizer();
            GridLocalizer.Active = gLocalizer;
         
            
            ReportParameter p = new   ReportParameter("ID", "0");

            this.mainReportViewer.ServerReport.SetParameters(new ReportParameter[] {p});
            this.mainReportViewer.RefreshReport();
              thread.Abort();
            Thread.Sleep(30);

            this.receiptMasterNewBindingSource.PositionChanged += new System.EventHandler(this.receiptMasterNewBindingSource_PositionChanged);
           

          //  System.Configuration.AppSettingsReader app = new System.Configuration.AppSettingsReader();

         //   MessageBox.Show(app.GetValue("RetailTradeConnectionString", System.Type.GetType("System.String")).ToString());
          
        
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

        public void FillTable(string NameTable)
        {
            Type tp = this.components.Components[NameTable+"TableAdapter"].GetType();
            Object[] args = new Object[1];
            args[0]=this.mDataSet.Tables[NameTable];
            foreach (DataRelation relation in this.mDataSet.Tables[NameTable].ParentRelations)
                    FillTable(relation.ParentTable.ToString());
            tp.GetMethod("Fill").Invoke(this.components.Components[NameTable+"TableAdapter"],args);
            
       }

        /******************Модификация справочников ******************/


       public bool SaveToBaseDirectoryModifed(DataRow[] dataRows)
       {
      
           if (dataRows.Length == 0) return false;
              Type tp = this.components.Components[dataRows[0].Table.TableName + "TableAdapter"].GetType();
               Object[] _args = new Object[1];
               _args[0] = dataRows;
               Type[] types = new Type[1];
               types[0] = dataRows.GetType();

                //**Новые данные**//     
                 Object[] _argsFill = new Object[2];
                   _argsFill[0] = dataRows[0].Table.Clone();
                   _argsFill[1] = dataRows[0]["DateUpdate"];
                   tp.GetMethod("FillNew").Invoke(this.components.Components[dataRows[0].Table.TableName + "TableAdapter"], _argsFill);
   
           try
               {
   
                   tp.GetMethod("Update", types).Invoke(this.components.Components[dataRows[0].Table.TableName + "TableAdapter"], _args);
               }
               catch (SqlException SqlErr)
               {
                   foreach (DataRow dataRow in dataRows)
                       if (dataRow.HasErrors)
                           MessageBox.Show(SqlErr.Message);
               }
               catch (Exception err)
               {   
                   
                   FormDialog formDialog = new FormDialog();
                   formDialog.btCancel.Enabled = false;
                   Information ctlInform = new Information();
                   formDialog.panel.Controls.Add(ctlInform);

                   foreach (DataRow dataRow in dataRows)
                
                       if (dataRow.HasErrors)
                       {
                           if ((_argsFill[0] as DataTable).Rows.Find(dataRow["Id"]) != null)
                           {
                               ctlInform.labelHeader.Text = "Запись была изменена пользователем: ";
                               ctlInform.labelAsk.Text = (_argsFill[0] as DataTable).Rows.Find(dataRow["Id"])["AuthorLastModif"].ToString();
                           }
                           else
                           {
                               ctlInform.labelHeader.Text = "Ошибка совмесного доступа";
                               ctlInform.labelAsk.Text = "Запись не найдена! Обновление не возможно ";
                           }

                           if (DialogResult.OK == formDialog.ShowDialog(this.ParentForm))
                  
                               dataRow.RejectChanges();
                        }
              }
           finally
              {   dataRows[0].Table.Merge(_argsFill[0] as DataTable,false);   
                  tp.GetMethod("FillNew").Invoke(this.components.Components[dataRows[0].Table.TableName + "TableAdapter"], _argsFill);
                  dataRows[0].Table.Merge(_argsFill[0] as DataTable, false); 
                  
           }
           return true;
       }

        public bool SaveToBaseDirectoryDeleted(DataRow[] dataRows)
        {
            if (dataRows.Length == 0) return false;
            Type tp = this.components.Components[dataRows[0].Table.TableName + "TableAdapter"].GetType();
            Object[] args = new Object[1];
            args[0] = dataRows;
            Type[] types = new Type[1];
            types[0] = dataRows.GetType();
            try
            {
                tp.GetMethod("Update", types).Invoke(this.components.Components[dataRows[0].Table.TableName + "TableAdapter"], args);
            }
            catch
            {
                return false;
            }
            finally
            {
                Object[] _argsFill = new Object[2];
                _argsFill[0] = dataRows[0].Table.Clone();
                _argsFill[1] = DateTime.Now;
                tp.GetMethod("FillNew").Invoke(this.components.Components[dataRows[0].Table.TableName + "TableAdapter"], _argsFill);
                dataRows[0].Table.Merge(_argsFill[0] as DataTable, false); 
           }
            return true;
        }
       public bool SaveToBase(MDataSet.ReceiptMasterRow sourceRow)
        {
          try
            {
               this.receiptMasterTableAdapter.Update(sourceRow);

               DataRow[] dr = sourceRow.GetReceiptDetailRows();

                this.receiptDetailTableAdapter.Update(dr);
                
            }
              catch 
            {
                
                  return false;

            }
           finally
            {
                this.receiptMasterNewTableAdapter.Fill(this.mDataSet.ReceiptMasterNew);
                
            } 
            return true;        
        }




        private bool FindOpenedTabs(String TagControl)
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
                      //  (uc as UCSPR).NameWorkTable = _NameTable;
                        //  uc.Tag = _NameTable;  
                     break;

                    case "Manufacturer":

                      usControl = new UcGroupDirectory(this.mDataSet.Tables["Manufacturer"]);
                     (usControl as   UcGroupDirectory).errorProvider1.DataSource = this.mDataSet;

                     (usControl as UcGroupDirectory).gridView.FocusedRowHandle = DevExpress.XtraGrid.GridControl.AutoFilterRowHandle;
                     (usControl as UcGroupDirectory).gridView.FocusedColumn = (usControl as UcGroupDirectory).gridView.Columns["Name"];
                     (usControl as UcGroupDirectory).Dock = DockStyle.Fill;
                       
                        break;
                    case "FarmGroupLevel2":
                        usControl = new UcGroupDirectory(this.mDataSet.Tables["FarmGroupLevel2"]);
                        (usControl as UcGroupDirectory).errorProvider1.DataSource = this.mDataSet;

                        (usControl as UcGroupDirectory).gridView.FocusedRowHandle = DevExpress.XtraGrid.GridControl.AutoFilterRowHandle;
                        (usControl as UcGroupDirectory).gridView.FocusedColumn = (usControl as UcGroupDirectory).gridView.Columns["Name"];
                        (usControl as UcGroupDirectory).Dock = DockStyle.Fill;
                     


                        break;

                    case "Organization":
                         usControl = new UCOrganizationAll(this.mDataSet);
                        //(usControl as UcGroupDirectory).errorProvider1.DataSource = this.mDataSet;

                         (usControl as UCOrganizationAll).gridView.FocusedRowHandle = DevExpress.XtraGrid.GridControl.AutoFilterRowHandle;
                         (usControl as UCOrganizationAll).gridView.FocusedColumn = (usControl as UCOrganizationAll).gridView.Columns["Name"];
                         (usControl as UCOrganizationAll).Dock = DockStyle.Fill;
    
                        break;

                    case "TradePutlet":
                        usControl = new UCTradePuplet(this.mDataSet);
                        (usControl as UCTradePuplet).gridView.FocusedRowHandle = DevExpress.XtraGrid.GridControl.AutoFilterRowHandle;
                        (usControl as UCTradePuplet).gridView.FocusedColumn = (usControl as UCTradePuplet).gridView.Columns["Name"];
                        (usControl as UCTradePuplet).Dock = DockStyle.Fill;

                        break;

                    case "ReceiptMasterNewAll":

                        usControl = new ReceiptMasterNewAll(this.mDataSet);
                       (usControl as ReceiptMasterNewAll).Dock = DockStyle.Fill;
                        break;
                    case "ReceiptRowOrganization":

                        if ((list[0] as MDataSet.ReceiptMasterRow) != null)
                        {
                            TagControl += (list[0] as MDataSet.ReceiptMasterRow).ID.ToString();
                            if (!FindOpenedTabs(TagControl))
                            {
                                Title = "№" + (list[0] as MDataSet.ReceiptMasterRow).Number.ToString() + " " + (list[0] as MDataSet.ReceiptMasterRow).OrganizationRow.ShortName.ToString();


                                usControl = new ReceiptRowOrganization((list[0] as MDataSet.ReceiptMasterRow), (list[0] as MDataSet.ReceiptMasterRow).ID);

                                (usControl as ReceiptRowOrganization).Dock = DockStyle.Fill;
                            }
                            else
                                return  false;
                        }


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

        

        private void receiptMasterNewBindingSource_PositionChanged(object sender, EventArgs e)
        {
          
           
         /*  ReportParameter p = new ReportParameter("ID", ((this.receiptMasterNewBindingSource.CurrencyManager.Current as DataRowView).Row as MDataSet.ReceiptMasterNewRow).ID.ToString());
            this.reportViewer1.ServerReport.SetParameters(new ReportParameter[] { p });
            this.reportViewer1.RefreshReport();
       
        */
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