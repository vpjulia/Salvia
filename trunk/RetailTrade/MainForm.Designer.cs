namespace RetailTrade
{
    partial class MainForm
    {
        public enum ActionDialog {View,Edit,Append }

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Новые");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("К отправке");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Отправленные");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Возвратные");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Накладные", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Новые");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("На складе");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Приходные", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Заявки");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.mainReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.storageConditionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mDataSet = new RetailTrade.MDataSet();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReceiptMaterRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeries = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUseByDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPricePurchase = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurchaseNDS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRetailNDS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriceRetailNDS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceDetailRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorCreate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorLastModif1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowVersion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.receiptMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receiptDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receiptMasterNewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tradePutletBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.organizationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.substanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.packingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manufacturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.документыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateAktToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReceiptMasterNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сервисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.OrganisationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ManufacturerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SubstanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FarmGroupLevel2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StorageConditionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PackingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UnitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CountryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типовДокументаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TradePutletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.складовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productTableAdapter = new RetailTrade.MDataSetTableAdapters.ProductTableAdapter();
            this.manufacturerTableAdapter = new RetailTrade.MDataSetTableAdapters.ManufacturerTableAdapter();
            this.farmGroupTableAdapter = new RetailTrade.MDataSetTableAdapters.FarmGroupTableAdapter();
            this.farmGroupLevel2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmGroupLevel2TableAdapter = new RetailTrade.MDataSetTableAdapters.FarmGroupLevel2TableAdapter();
            this.packingTableAdapter = new RetailTrade.MDataSetTableAdapters.PackingTableAdapter();
            this.storageConditionTableAdapter = new RetailTrade.MDataSetTableAdapters.StorageConditionTableAdapter();
            this.substanceTableAdapter = new RetailTrade.MDataSetTableAdapters.SubstanceTableAdapter();
            this.unitTableAdapter = new RetailTrade.MDataSetTableAdapters.UnitTableAdapter();
            this.countryTableAdapter = new RetailTrade.MDataSetTableAdapters.CountryTableAdapter();
            this.organizationTableAdapter = new RetailTrade.MDataSetTableAdapters.OrganizationTableAdapter();
            this.tradePutletTableAdapter = new RetailTrade.MDataSetTableAdapters.TradePutletTableAdapter();
            this.stockTableAdapter = new RetailTrade.MDataSetTableAdapters.StockTableAdapter();
            this.receiptMasterNewTableAdapter = new RetailTrade.MDataSetTableAdapters.ReceiptMasterNewTableAdapter();
            this.receiptMasterTableAdapter = new RetailTrade.MDataSetTableAdapters.ReceiptMasterTableAdapter();
            this.receiptDetailTableAdapter = new RetailTrade.MDataSetTableAdapters.ReceiptDetailTableAdapter();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageConditionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptMasterNewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradePutletBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.substanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.farmGroupLevel2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 662);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(837, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 26);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(837, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 51);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1MinSize = 50;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.mainReportViewer);
            this.splitContainer1.Panel2.Controls.Add(this.gridControl2);
            this.splitContainer1.Panel2MinSize = 50;
            this.splitContainer1.Size = new System.Drawing.Size(837, 611);
            this.splitContainer1.SplitterDistance = 411;
            this.splitContainer1.TabIndex = 3;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControl);
            this.splitContainer2.Size = new System.Drawing.Size(837, 411);
            this.splitContainer2.SplitterDistance = 218;
            this.splitContainer2.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(218, 411);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.treeView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(210, 382);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "новые";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "NodeRecieptNew";
            treeNode1.Text = "Новые";
            treeNode2.Name = "Node6";
            treeNode2.Text = "К отправке";
            treeNode3.Name = "Node7";
            treeNode3.Text = "Отправленные";
            treeNode4.Name = "Node8";
            treeNode4.Text = "Возвратные";
            treeNode5.Name = "NodeReciept";
            treeNode5.Tag = "";
            treeNode5.Text = "Накладные";
            treeNode6.Name = "Node10";
            treeNode6.Tag = "ReceiptMasterNewAll";
            treeNode6.Text = "Новые";
            treeNode6.ToolTipText = "Новые приходные акты";
            treeNode7.Name = "Node11";
            treeNode7.Text = "На складе";
            treeNode8.Name = "Node9";
            treeNode8.Text = "Приходные";
            treeNode9.Name = "Node12";
            treeNode9.Text = "Заявки";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode8,
            treeNode9});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(204, 376);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "CASGEBBI.jpg");
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(210, 382);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "все";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(615, 411);
            this.tabControl.TabIndex = 0;
            // 
            // mainReportViewer
            // 
            this.mainReportViewer.AutoScroll = true;
            this.mainReportViewer.Dock = System.Windows.Forms.DockStyle.Right;
            this.mainReportViewer.Location = new System.Drawing.Point(356, 0);
            this.mainReportViewer.Name = "mainReportViewer";
            this.mainReportViewer.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.mainReportViewer.ServerReport.ReportPath = "/ReportRatailTrade/ReceiptMasterByID";
            this.mainReportViewer.ServerReport.ReportServerUrl = new System.Uri("http://server/reportserver", System.UriKind.Absolute);
            this.mainReportViewer.ShowCredentialPrompts = false;
            this.mainReportViewer.ShowParameterPrompts = false;
            this.mainReportViewer.Size = new System.Drawing.Size(481, 196);
            this.mainReportViewer.TabIndex = 1;
            this.mainReportViewer.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            this.mainReportViewer.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.mainReportViewer_MouseDoubleClick);
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.storageConditionBindingSource;
            // 
            // 
            // 
            this.gridControl2.EmbeddedNavigator.Name = "";
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(350, 182);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // storageConditionBindingSource
            // 
            this.storageConditionBindingSource.DataMember = "StorageCondition";
            this.storageConditionBindingSource.DataSource = this.mDataSetBindingSource;
            // 
            // mDataSetBindingSource
            // 
            this.mDataSetBindingSource.DataSource = this.mDataSet;
            this.mDataSetBindingSource.Position = 0;
            // 
            // mDataSet
            // 
            this.mDataSet.DataSetName = "MDataSet";
            this.mDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID1,
            this.colReceiptMaterRef,
            this.colProductRef,
            this.colSeries,
            this.colUseByDate,
            this.colQuantity,
            this.colPricePurchase,
            this.colPurchaseNDS,
            this.colRetailNDS,
            this.colPriceRetailNDS,
            this.colInvoiceDetailRef,
            this.colAuthorCreate1,
            this.colAuthorLastModif1,
            this.colDateCreate1,
            this.colRowVersion1});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // colID1
            // 
            this.colID1.Caption = "ID";
            this.colID1.FieldName = "ID";
            this.colID1.Name = "colID1";
            this.colID1.OptionsColumn.ReadOnly = true;
            this.colID1.Visible = true;
            this.colID1.VisibleIndex = 0;
            this.colID1.Width = 46;
            // 
            // colReceiptMaterRef
            // 
            this.colReceiptMaterRef.Caption = "ReceiptMaterRef";
            this.colReceiptMaterRef.FieldName = "ReceiptMaterRef";
            this.colReceiptMaterRef.Name = "colReceiptMaterRef";
            this.colReceiptMaterRef.Visible = true;
            this.colReceiptMaterRef.VisibleIndex = 1;
            this.colReceiptMaterRef.Width = 150;
            // 
            // colProductRef
            // 
            this.colProductRef.Caption = "ProductRef";
            this.colProductRef.FieldName = "ProductRef";
            this.colProductRef.Name = "colProductRef";
            this.colProductRef.Visible = true;
            this.colProductRef.VisibleIndex = 2;
            this.colProductRef.Width = 38;
            // 
            // colSeries
            // 
            this.colSeries.Caption = "Series";
            this.colSeries.FieldName = "Series";
            this.colSeries.Name = "colSeries";
            this.colSeries.Visible = true;
            this.colSeries.VisibleIndex = 3;
            this.colSeries.Width = 38;
            // 
            // colUseByDate
            // 
            this.colUseByDate.Caption = "UseByDate";
            this.colUseByDate.FieldName = "UseByDate";
            this.colUseByDate.Name = "colUseByDate";
            this.colUseByDate.Visible = true;
            this.colUseByDate.VisibleIndex = 4;
            this.colUseByDate.Width = 38;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Quantity";
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 5;
            this.colQuantity.Width = 38;
            // 
            // colPricePurchase
            // 
            this.colPricePurchase.Caption = "PricePurchase";
            this.colPricePurchase.FieldName = "PricePurchase";
            this.colPricePurchase.Name = "colPricePurchase";
            this.colPricePurchase.Visible = true;
            this.colPricePurchase.VisibleIndex = 6;
            this.colPricePurchase.Width = 38;
            // 
            // colPurchaseNDS
            // 
            this.colPurchaseNDS.Caption = "PurchaseNDS";
            this.colPurchaseNDS.FieldName = "PurchaseNDS";
            this.colPurchaseNDS.Name = "colPurchaseNDS";
            this.colPurchaseNDS.Visible = true;
            this.colPurchaseNDS.VisibleIndex = 7;
            this.colPurchaseNDS.Width = 38;
            // 
            // colRetailNDS
            // 
            this.colRetailNDS.Caption = "RetailNDS";
            this.colRetailNDS.FieldName = "RetailNDS";
            this.colRetailNDS.Name = "colRetailNDS";
            this.colRetailNDS.Visible = true;
            this.colRetailNDS.VisibleIndex = 8;
            this.colRetailNDS.Width = 38;
            // 
            // colPriceRetailNDS
            // 
            this.colPriceRetailNDS.Caption = "PriceRetailNDS";
            this.colPriceRetailNDS.FieldName = "PriceRetailNDS";
            this.colPriceRetailNDS.Name = "colPriceRetailNDS";
            this.colPriceRetailNDS.Visible = true;
            this.colPriceRetailNDS.VisibleIndex = 9;
            this.colPriceRetailNDS.Width = 38;
            // 
            // colInvoiceDetailRef
            // 
            this.colInvoiceDetailRef.Caption = "InvoiceDetailRef";
            this.colInvoiceDetailRef.FieldName = "InvoiceDetailRef";
            this.colInvoiceDetailRef.Name = "colInvoiceDetailRef";
            this.colInvoiceDetailRef.Visible = true;
            this.colInvoiceDetailRef.VisibleIndex = 10;
            this.colInvoiceDetailRef.Width = 38;
            // 
            // colAuthorCreate1
            // 
            this.colAuthorCreate1.Caption = "AuthorCreate";
            this.colAuthorCreate1.FieldName = "AuthorCreate";
            this.colAuthorCreate1.Name = "colAuthorCreate1";
            this.colAuthorCreate1.Visible = true;
            this.colAuthorCreate1.VisibleIndex = 11;
            this.colAuthorCreate1.Width = 38;
            // 
            // colAuthorLastModif1
            // 
            this.colAuthorLastModif1.Caption = "AuthorLastModif";
            this.colAuthorLastModif1.FieldName = "AuthorLastModif";
            this.colAuthorLastModif1.Name = "colAuthorLastModif1";
            this.colAuthorLastModif1.Visible = true;
            this.colAuthorLastModif1.VisibleIndex = 12;
            this.colAuthorLastModif1.Width = 38;
            // 
            // colDateCreate1
            // 
            this.colDateCreate1.Caption = "DateCreate";
            this.colDateCreate1.FieldName = "DateCreate";
            this.colDateCreate1.Name = "colDateCreate1";
            this.colDateCreate1.Visible = true;
            this.colDateCreate1.VisibleIndex = 13;
            this.colDateCreate1.Width = 38;
            // 
            // colRowVersion1
            // 
            this.colRowVersion1.Caption = "RowVersion";
            this.colRowVersion1.FieldName = "RowVersion";
            this.colRowVersion1.Name = "colRowVersion1";
            this.colRowVersion1.OptionsColumn.ReadOnly = true;
            this.colRowVersion1.Visible = true;
            this.colRowVersion1.VisibleIndex = 14;
            this.colRowVersion1.Width = 43;
            // 
            // receiptMasterBindingSource
            // 
            this.receiptMasterBindingSource.DataMember = "ReceiptMaster";
            this.receiptMasterBindingSource.DataSource = this.mDataSet;
            // 
            // receiptDetailBindingSource
            // 
            this.receiptDetailBindingSource.AllowNew = true;
            this.receiptDetailBindingSource.DataMember = "ReceiptMasterNew_ReceiptDetail";
            this.receiptDetailBindingSource.DataSource = this.receiptMasterNewBindingSource;
            // 
            // receiptMasterNewBindingSource
            // 
            this.receiptMasterNewBindingSource.DataMember = "ReceiptMasterNew";
            this.receiptMasterNewBindingSource.DataSource = this.mDataSet;
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.mDataSet;
            // 
            // tradePutletBindingSource
            // 
            this.tradePutletBindingSource.DataMember = "TradePutlet";
            this.tradePutletBindingSource.DataSource = this.mDataSet;
            // 
            // organizationBindingSource
            // 
            this.organizationBindingSource.DataMember = "Organization";
            this.organizationBindingSource.DataSource = this.mDataSet;
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataMember = "Country";
            this.countryBindingSource.DataSource = this.mDataSet;
            // 
            // unitBindingSource
            // 
            this.unitBindingSource.DataMember = "Unit";
            this.unitBindingSource.DataSource = this.mDataSetBindingSource;
            // 
            // substanceBindingSource
            // 
            this.substanceBindingSource.DataMember = "Substance";
            this.substanceBindingSource.DataSource = this.mDataSetBindingSource;
            // 
            // packingBindingSource
            // 
            this.packingBindingSource.DataMember = "Packing";
            this.packingBindingSource.DataSource = this.mDataSetBindingSource;
            // 
            // farmGroupBindingSource
            // 
            this.farmGroupBindingSource.DataMember = "FarmGroup";
            this.farmGroupBindingSource.DataSource = this.mDataSetBindingSource;
            // 
            // manufacturerBindingSource
            // 
            this.manufacturerBindingSource.DataMember = "Manufacturer";
            this.manufacturerBindingSource.DataSource = this.mDataSetBindingSource;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.mDataSetBindingSource;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.документыToolStripMenuItem,
            this.сервисToolStripMenuItem,
            this.toolStripMenuItem1,
            this.отчетыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(837, 26);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // документыToolStripMenuItem
            // 
            this.документыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateAktToolStripMenuItem,
            this.ReceiptMasterNewToolStripMenuItem});
            this.документыToolStripMenuItem.Name = "документыToolStripMenuItem";
            this.документыToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.документыToolStripMenuItem.Text = "Документы";
            // 
            // CreateAktToolStripMenuItem
            // 
            this.CreateAktToolStripMenuItem.Name = "CreateAktToolStripMenuItem";
            this.CreateAktToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.CreateAktToolStripMenuItem.Text = "Создать приходный акт";
            // 
            // ReceiptMasterNewToolStripMenuItem
            // 
            this.ReceiptMasterNewToolStripMenuItem.Name = "ReceiptMasterNewToolStripMenuItem";
            this.ReceiptMasterNewToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.ReceiptMasterNewToolStripMenuItem.Tag = "ReceiptMasterNew";
            this.ReceiptMasterNewToolStripMenuItem.Text = "Приходные новые";
            this.ReceiptMasterNewToolStripMenuItem.ToolTipText = "Новые приходные акты";
            this.ReceiptMasterNewToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // сервисToolStripMenuItem
            // 
            this.сервисToolStripMenuItem.Name = "сервисToolStripMenuItem";
            this.сервисToolStripMenuItem.Size = new System.Drawing.Size(68, 22);
            this.сервисToolStripMenuItem.Text = "Сервис";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btProduct,
            this.OrganisationToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripMenuItem2});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.toolStripMenuItem1.Text = "Справочники";
            // 
            // btProduct
            // 
            this.btProduct.Name = "btProduct";
            this.btProduct.Size = new System.Drawing.Size(180, 22);
            this.btProduct.Tag = "UCProductAll";
            this.btProduct.Text = "Товаров";
            this.btProduct.ToolTipText = "Справочник товаров";
            this.btProduct.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // OrganisationToolStripMenuItem
            // 
            this.OrganisationToolStripMenuItem.Name = "OrganisationToolStripMenuItem";
            this.OrganisationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OrganisationToolStripMenuItem.Tag = "Organization";
            this.OrganisationToolStripMenuItem.Text = "Организаций";
            this.OrganisationToolStripMenuItem.ToolTipText = "Справочник организаций";
            this.OrganisationToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManufacturerToolStripMenuItem,
            this.SubstanceToolStripMenuItem,
            this.FarmGroupLevel2ToolStripMenuItem,
            this.StorageConditionToolStripMenuItem,
            this.PackingToolStripMenuItem,
            this.UnitToolStripMenuItem,
            this.CountryToolStripMenuItem,
            this.типовДокументаToolStripMenuItem,
            this.toolStripSeparator2,
            this.TradePutletToolStripMenuItem,
            this.складовToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "Служебные";
            // 
            // ManufacturerToolStripMenuItem
            // 
            this.ManufacturerToolStripMenuItem.Name = "ManufacturerToolStripMenuItem";
            this.ManufacturerToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.ManufacturerToolStripMenuItem.Tag = "Manufacturer";
            this.ManufacturerToolStripMenuItem.Text = "Изготовителей";
            this.ManufacturerToolStripMenuItem.ToolTipText = "Справочник изготовителей";
            this.ManufacturerToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // SubstanceToolStripMenuItem
            // 
            this.SubstanceToolStripMenuItem.Name = "SubstanceToolStripMenuItem";
            this.SubstanceToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.SubstanceToolStripMenuItem.Tag = "Substance";
            this.SubstanceToolStripMenuItem.Text = "Действующих веществ";
            this.SubstanceToolStripMenuItem.ToolTipText = "Справочник действующих веществ";
            this.SubstanceToolStripMenuItem.Click += new System.EventHandler(this.SampleDirectoryMenuItem_Click);
            // 
            // FarmGroupLevel2ToolStripMenuItem
            // 
            this.FarmGroupLevel2ToolStripMenuItem.Name = "FarmGroupLevel2ToolStripMenuItem";
            this.FarmGroupLevel2ToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.FarmGroupLevel2ToolStripMenuItem.Tag = "FarmGroupLevel2";
            this.FarmGroupLevel2ToolStripMenuItem.Text = "Фармгрупп";
            this.FarmGroupLevel2ToolStripMenuItem.ToolTipText = "Справочник фармгрупп";
            this.FarmGroupLevel2ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // StorageConditionToolStripMenuItem
            // 
            this.StorageConditionToolStripMenuItem.Name = "StorageConditionToolStripMenuItem";
            this.StorageConditionToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.StorageConditionToolStripMenuItem.Tag = "StorageCondition";
            this.StorageConditionToolStripMenuItem.Text = "Мест хранения";
            this.StorageConditionToolStripMenuItem.ToolTipText = "Справочник мест хранения";
            this.StorageConditionToolStripMenuItem.Click += new System.EventHandler(this.SampleDirectoryMenuItem_Click);
            // 
            // PackingToolStripMenuItem
            // 
            this.PackingToolStripMenuItem.Name = "PackingToolStripMenuItem";
            this.PackingToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.PackingToolStripMenuItem.Tag = "Packing";
            this.PackingToolStripMenuItem.Text = "Форм выпуска";
            this.PackingToolStripMenuItem.ToolTipText = "Справочник форм выпуска";
            this.PackingToolStripMenuItem.Click += new System.EventHandler(this.SampleDirectoryMenuItem_Click);
            // 
            // UnitToolStripMenuItem
            // 
            this.UnitToolStripMenuItem.Name = "UnitToolStripMenuItem";
            this.UnitToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.UnitToolStripMenuItem.Tag = "Unit";
            this.UnitToolStripMenuItem.Text = "Едениц измерения";
            this.UnitToolStripMenuItem.ToolTipText = "Справочник едениц измерения";
            this.UnitToolStripMenuItem.Click += new System.EventHandler(this.SampleDirectoryMenuItem_Click);
            // 
            // CountryToolStripMenuItem
            // 
            this.CountryToolStripMenuItem.Name = "CountryToolStripMenuItem";
            this.CountryToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.CountryToolStripMenuItem.Tag = "Country";
            this.CountryToolStripMenuItem.Text = "Стран";
            this.CountryToolStripMenuItem.ToolTipText = "Справочник стран";
            this.CountryToolStripMenuItem.Click += new System.EventHandler(this.SampleDirectoryMenuItem_Click);
            // 
            // типовДокументаToolStripMenuItem
            // 
            this.типовДокументаToolStripMenuItem.Name = "типовДокументаToolStripMenuItem";
            this.типовДокументаToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.типовДокументаToolStripMenuItem.Text = "Типов документа";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(250, 6);
            // 
            // TradePutletToolStripMenuItem
            // 
            this.TradePutletToolStripMenuItem.Name = "TradePutletToolStripMenuItem";
            this.TradePutletToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.TradePutletToolStripMenuItem.Tag = "TradePutlet";
            this.TradePutletToolStripMenuItem.Text = "Торговых точек";
            this.TradePutletToolStripMenuItem.ToolTipText = "Справочник торговых точек";
            this.TradePutletToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // складовToolStripMenuItem
            // 
            this.складовToolStripMenuItem.Name = "складовToolStripMenuItem";
            this.складовToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.складовToolStripMenuItem.Text = "Складов";
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(73, 22);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // manufacturerTableAdapter
            // 
            this.manufacturerTableAdapter.ClearBeforeFill = true;
            // 
            // farmGroupTableAdapter
            // 
            this.farmGroupTableAdapter.ClearBeforeFill = true;
            // 
            // farmGroupLevel2BindingSource
            // 
            this.farmGroupLevel2BindingSource.DataMember = "FarmGroupLevel2";
            this.farmGroupLevel2BindingSource.DataSource = this.mDataSetBindingSource;
            // 
            // farmGroupLevel2TableAdapter
            // 
            this.farmGroupLevel2TableAdapter.ClearBeforeFill = true;
            // 
            // packingTableAdapter
            // 
            this.packingTableAdapter.ClearBeforeFill = true;
            // 
            // storageConditionTableAdapter
            // 
            this.storageConditionTableAdapter.ClearBeforeFill = true;
            // 
            // substanceTableAdapter
            // 
            this.substanceTableAdapter.ClearBeforeFill = true;
            // 
            // unitTableAdapter
            // 
            this.unitTableAdapter.ClearBeforeFill = true;
            // 
            // countryTableAdapter
            // 
            this.countryTableAdapter.ClearBeforeFill = true;
            // 
            // organizationTableAdapter
            // 
            this.organizationTableAdapter.ClearBeforeFill = true;
            // 
            // tradePutletTableAdapter
            // 
            this.tradePutletTableAdapter.ClearBeforeFill = true;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // receiptMasterNewTableAdapter
            // 
            this.receiptMasterNewTableAdapter.ClearBeforeFill = true;
            // 
            // receiptMasterTableAdapter
            // 
            this.receiptMasterTableAdapter.ClearBeforeFill = true;
            // 
            // receiptDetailTableAdapter
            // 
            this.receiptDetailTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(837, 684);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageConditionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptMasterNewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradePutletBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.substanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.farmGroupLevel2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem btProduct;
        private System.Windows.Forms.BindingSource mDataSetBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource;
        private RetailTrade.MDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        public MDataSet mDataSet;
        private System.Windows.Forms.BindingSource manufacturerBindingSource;
        private RetailTrade.MDataSetTableAdapters.ManufacturerTableAdapter manufacturerTableAdapter;
        private System.Windows.Forms.BindingSource farmGroupBindingSource;
        private RetailTrade.MDataSetTableAdapters.FarmGroupTableAdapter farmGroupTableAdapter;
        private System.Windows.Forms.BindingSource farmGroupLevel2BindingSource;
        private RetailTrade.MDataSetTableAdapters.FarmGroupLevel2TableAdapter farmGroupLevel2TableAdapter;
        private System.Windows.Forms.BindingSource packingBindingSource;
        private RetailTrade.MDataSetTableAdapters.PackingTableAdapter packingTableAdapter;
        private System.Windows.Forms.BindingSource storageConditionBindingSource;
        private RetailTrade.MDataSetTableAdapters.StorageConditionTableAdapter storageConditionTableAdapter;
        private System.Windows.Forms.BindingSource substanceBindingSource;
        private RetailTrade.MDataSetTableAdapters.SubstanceTableAdapter substanceTableAdapter;
        private System.Windows.Forms.BindingSource unitBindingSource;
        private RetailTrade.MDataSetTableAdapters.UnitTableAdapter unitTableAdapter;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private RetailTrade.MDataSetTableAdapters.CountryTableAdapter countryTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ManufacturerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SubstanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FarmGroupLevel2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StorageConditionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CountryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UnitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PackingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OrganisationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem типовДокументаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TradePutletToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem складовToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem документыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сервисToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.BindingSource organizationBindingSource;
        private RetailTrade.MDataSetTableAdapters.OrganizationTableAdapter organizationTableAdapter;
        private System.Windows.Forms.BindingSource tradePutletBindingSource;
        private RetailTrade.MDataSetTableAdapters.TradePutletTableAdapter tradePutletTableAdapter;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private RetailTrade.MDataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem CreateAktToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReceiptMasterNewToolStripMenuItem;
        private RetailTrade.MDataSetTableAdapters.ReceiptMasterNewTableAdapter receiptMasterNewTableAdapter;
        private RetailTrade.MDataSetTableAdapters.ReceiptMasterTableAdapter receiptMasterTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private RetailTrade.MDataSetTableAdapters.ReceiptDetailTableAdapter receiptDetailTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID1;
        private DevExpress.XtraGrid.Columns.GridColumn colReceiptMaterRef;
        private DevExpress.XtraGrid.Columns.GridColumn colProductRef;
        private DevExpress.XtraGrid.Columns.GridColumn colSeries;
        private DevExpress.XtraGrid.Columns.GridColumn colUseByDate;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colPricePurchase;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchaseNDS;
        private DevExpress.XtraGrid.Columns.GridColumn colRetailNDS;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceRetailNDS;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceDetailRef;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorCreate1;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorLastModif1;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreate1;
        private DevExpress.XtraGrid.Columns.GridColumn colRowVersion1;
        public System.Windows.Forms.BindingSource receiptDetailBindingSource;
        public System.Windows.Forms.BindingSource receiptMasterBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer mainReportViewer;
        public System.Windows.Forms.BindingSource receiptMasterNewBindingSource;
        public System.Windows.Forms.TabControl tabControl;
    }
}

