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
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Центральный склад");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Остатки товара", new System.Windows.Forms.TreeNode[] {
            treeNode10});
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.vwRemainsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mDataSet = new RetailTrade.MDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceMaterRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPricePurchase = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurchaseNDS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriceRetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRetailNDS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriceRetailNDS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLocalReceipDetailRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemoteInvoiceDetailRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorCreate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorLastModif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mainReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.invoiceDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storageConditionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receiptMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receiptDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.receiptMasterTableAdapter = new RetailTrade.MDataSetTableAdapters.ReceiptMasterTableAdapter();
            this.receiptDetailTableAdapter = new RetailTrade.MDataSetTableAdapters.ReceiptDetailTableAdapter();
            this.documentTypeTableAdapter = new RetailTrade.MDataSetTableAdapters.DocumentTypeTableAdapter();
            this.OrdersTableAdapter = new RetailTrade.MDataSetTableAdapters.OrdersTableAdapter();
            this.invoiceMasterTableAdapter = new RetailTrade.MDataSetTableAdapters.InvoiceMasterTableAdapter();
            this.invoiceDetailTableAdapter = new RetailTrade.MDataSetTableAdapters.InvoiceDetailTableAdapter();
            this.vwRemainsTableAdapter = new RetailTrade.MDataSetTableAdapters.vwRemainsTableAdapter();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRemainsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageConditionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptDetailBindingSource)).BeginInit();
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
            this.splitContainer1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainer1.Panel2.Controls.Add(this.mainReportViewer);
            this.splitContainer1.Panel2MinSize = 50;
            this.splitContainer1.Size = new System.Drawing.Size(837, 611);
            this.splitContainer1.SplitterDistance = 557;
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
            this.splitContainer2.Size = new System.Drawing.Size(837, 557);
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
            this.tabControl1.Size = new System.Drawing.Size(218, 557);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.treeView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(210, 528);
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
            treeNode1.Tag = "InvoiceMasterNew";
            treeNode1.Text = "Новые";
            treeNode1.ToolTipText = "Новые накладные";
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
            treeNode7.Tag = "ReceiptMasterStock";
            treeNode7.Text = "На складе";
            treeNode8.Name = "Node9";
            treeNode8.Text = "Приходные";
            treeNode9.Name = "Node12";
            treeNode9.Tag = "OrdersAll";
            treeNode9.Text = "Заявки";
            treeNode10.Name = "Node1";
            treeNode10.Text = "Центральный склад";
            treeNode11.Name = "Node0";
            treeNode11.Text = "Остатки товара";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode8,
            treeNode9,
            treeNode11});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(204, 522);
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
            this.tabPage2.Size = new System.Drawing.Size(210, 528);
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
            this.tabControl.Size = new System.Drawing.Size(615, 557);
            this.tabControl.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.vwRemainsBindingSource;
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(464, 13);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(400, 200);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // vwRemainsBindingSource
            // 
            this.vwRemainsBindingSource.DataMember = "vwRemains";
            this.vwRemainsBindingSource.DataSource = this.mDataSet;
            // 
            // mDataSet
            // 
            this.mDataSet.DataSetName = "MDataSet";
            this.mDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colInvoiceMaterRef,
            this.colQuantity,
            this.colPricePurchase,
            this.colPurchaseNDS,
            this.colPriceRetail,
            this.colRetailNDS,
            this.colPriceRetailNDS,
            this.colLocalReceipDetailRef,
            this.colRemoteInvoiceDetailRef,
            this.colAuthorCreate,
            this.colAuthorLastModif,
            this.colDateCreate,
            this.colRowVersion});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.ReadOnly = true;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colInvoiceMaterRef
            // 
            this.colInvoiceMaterRef.Caption = "InvoiceMaterRef";
            this.colInvoiceMaterRef.FieldName = "InvoiceMaterRef";
            this.colInvoiceMaterRef.Name = "colInvoiceMaterRef";
            this.colInvoiceMaterRef.Visible = true;
            this.colInvoiceMaterRef.VisibleIndex = 1;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Quantity";
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 2;
            // 
            // colPricePurchase
            // 
            this.colPricePurchase.Caption = "PricePurchase";
            this.colPricePurchase.FieldName = "PricePurchase";
            this.colPricePurchase.Name = "colPricePurchase";
            this.colPricePurchase.Visible = true;
            this.colPricePurchase.VisibleIndex = 3;
            // 
            // colPurchaseNDS
            // 
            this.colPurchaseNDS.Caption = "PurchaseNDS";
            this.colPurchaseNDS.FieldName = "PurchaseNDS";
            this.colPurchaseNDS.Name = "colPurchaseNDS";
            this.colPurchaseNDS.Visible = true;
            this.colPurchaseNDS.VisibleIndex = 4;
            // 
            // colPriceRetail
            // 
            this.colPriceRetail.Caption = "PriceRetail";
            this.colPriceRetail.FieldName = "PriceRetail";
            this.colPriceRetail.Name = "colPriceRetail";
            this.colPriceRetail.Visible = true;
            this.colPriceRetail.VisibleIndex = 5;
            // 
            // colRetailNDS
            // 
            this.colRetailNDS.Caption = "RetailNDS";
            this.colRetailNDS.FieldName = "RetailNDS";
            this.colRetailNDS.Name = "colRetailNDS";
            this.colRetailNDS.Visible = true;
            this.colRetailNDS.VisibleIndex = 6;
            // 
            // colPriceRetailNDS
            // 
            this.colPriceRetailNDS.Caption = "PriceRetailNDS";
            this.colPriceRetailNDS.FieldName = "PriceRetailNDS";
            this.colPriceRetailNDS.Name = "colPriceRetailNDS";
            this.colPriceRetailNDS.Visible = true;
            this.colPriceRetailNDS.VisibleIndex = 7;
            // 
            // colLocalReceipDetailRef
            // 
            this.colLocalReceipDetailRef.Caption = "LocalReceipDetailRef";
            this.colLocalReceipDetailRef.FieldName = "LocalReceipDetailRef";
            this.colLocalReceipDetailRef.Name = "colLocalReceipDetailRef";
            this.colLocalReceipDetailRef.Visible = true;
            this.colLocalReceipDetailRef.VisibleIndex = 8;
            // 
            // colRemoteInvoiceDetailRef
            // 
            this.colRemoteInvoiceDetailRef.Caption = "RemoteInvoiceDetailRef";
            this.colRemoteInvoiceDetailRef.FieldName = "RemoteInvoiceDetailRef";
            this.colRemoteInvoiceDetailRef.Name = "colRemoteInvoiceDetailRef";
            this.colRemoteInvoiceDetailRef.Visible = true;
            this.colRemoteInvoiceDetailRef.VisibleIndex = 9;
            // 
            // colAuthorCreate
            // 
            this.colAuthorCreate.Caption = "AuthorCreate";
            this.colAuthorCreate.FieldName = "AuthorCreate";
            this.colAuthorCreate.Name = "colAuthorCreate";
            this.colAuthorCreate.Visible = true;
            this.colAuthorCreate.VisibleIndex = 10;
            // 
            // colAuthorLastModif
            // 
            this.colAuthorLastModif.Caption = "AuthorLastModif";
            this.colAuthorLastModif.FieldName = "AuthorLastModif";
            this.colAuthorLastModif.Name = "colAuthorLastModif";
            this.colAuthorLastModif.Visible = true;
            this.colAuthorLastModif.VisibleIndex = 11;
            // 
            // colDateCreate
            // 
            this.colDateCreate.Caption = "DateCreate";
            this.colDateCreate.FieldName = "DateCreate";
            this.colDateCreate.Name = "colDateCreate";
            this.colDateCreate.Visible = true;
            this.colDateCreate.VisibleIndex = 12;
            // 
            // colRowVersion
            // 
            this.colRowVersion.Caption = "RowVersion";
            this.colRowVersion.FieldName = "RowVersion";
            this.colRowVersion.Name = "colRowVersion";
            this.colRowVersion.OptionsColumn.ReadOnly = true;
            this.colRowVersion.Visible = true;
            this.colRowVersion.VisibleIndex = 13;
            // 
            // mainReportViewer
            // 
            this.mainReportViewer.Location = new System.Drawing.Point(28, 4);
            this.mainReportViewer.Name = "mainReportViewer";
            this.mainReportViewer.Size = new System.Drawing.Size(400, 250);
            this.mainReportViewer.TabIndex = 0;
            this.mainReportViewer.Visible = false;
            // 
            // invoiceDetailBindingSource
            // 
            this.invoiceDetailBindingSource.DataMember = "InvoiceDetail";
            this.invoiceDetailBindingSource.DataSource = this.mDataSet;
            // 
            // invoiceMasterBindingSource
            // 
            this.invoiceMasterBindingSource.DataMember = "InvoiceMaster";
            this.invoiceMasterBindingSource.DataSource = this.mDataSet;
            // 
            // documentTypeBindingSource
            // 
            this.documentTypeBindingSource.DataMember = "DocumentType";
            this.documentTypeBindingSource.DataSource = this.mDataSet;
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
            // receiptMasterBindingSource
            // 
            this.receiptMasterBindingSource.DataMember = "ReceiptMaster";
            this.receiptMasterBindingSource.DataSource = this.mDataSet;
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
            // receiptMasterTableAdapter
            // 
            this.receiptMasterTableAdapter.ClearBeforeFill = true;
            // 
            // receiptDetailTableAdapter
            // 
            this.receiptDetailTableAdapter.ClearBeforeFill = true;
            // 
            // documentTypeTableAdapter
            // 
            this.documentTypeTableAdapter.ClearBeforeFill = true;
            // 
            // OrdersTableAdapter
            // 
            this.OrdersTableAdapter.ClearBeforeFill = true;
            // 
            // invoiceMasterTableAdapter
            // 
            this.invoiceMasterTableAdapter.ClearBeforeFill = true;
            // 
            // invoiceDetailTableAdapter
            // 
            this.invoiceDetailTableAdapter.ClearBeforeFill = true;
            // 
            // vwRemainsTableAdapter
            // 
            this.vwRemainsTableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwRemainsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageConditionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptDetailBindingSource)).EndInit();
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
        private RetailTrade.MDataSetTableAdapters.ReceiptDetailTableAdapter receiptDetailTableAdapter;
        public System.Windows.Forms.BindingSource receiptDetailBindingSource;
        public System.Windows.Forms.BindingSource receiptMasterBindingSource;
    
        public System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.BindingSource documentTypeBindingSource;
        private RetailTrade.MDataSetTableAdapters.DocumentTypeTableAdapter documentTypeTableAdapter;
       
        private RetailTrade.MDataSetTableAdapters.OrdersTableAdapter OrdersTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer mainReportViewer;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;

   
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceMaterRef;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colPricePurchase;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchaseNDS;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceRetail;
        private DevExpress.XtraGrid.Columns.GridColumn colRetailNDS;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceRetailNDS;
        private DevExpress.XtraGrid.Columns.GridColumn colLocalReceipDetailRef;
        private DevExpress.XtraGrid.Columns.GridColumn colRemoteInvoiceDetailRef;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorCreate;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorLastModif;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreate;
        private DevExpress.XtraGrid.Columns.GridColumn colRowVersion;
        private System.Windows.Forms.BindingSource invoiceMasterBindingSource;
        private RetailTrade.MDataSetTableAdapters.InvoiceMasterTableAdapter invoiceMasterTableAdapter;
        private System.Windows.Forms.BindingSource invoiceDetailBindingSource;
        private RetailTrade.MDataSetTableAdapters.InvoiceDetailTableAdapter invoiceDetailTableAdapter;
        public RetailTrade.MDataSetTableAdapters.ReceiptMasterTableAdapter receiptMasterTableAdapter;
        private System.Windows.Forms.BindingSource vwRemainsBindingSource;
        private RetailTrade.MDataSetTableAdapters.vwRemainsTableAdapter vwRemainsTableAdapter;
    }
}

