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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Новые");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("К отправке");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Отправленные");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Возвратные");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Списание");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Накладные", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Новые");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("На складе");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Приходные", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Центральный склад");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Остатки товара", new System.Windows.Forms.TreeNode[] {
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Заявки");
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.actionStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.periodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mDataSet = new RetailTrade.MDataSet();
            this.substanceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fullDataSet = new RetailTrade.FullDataSet();
            this.unitBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pricesPurchaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RemainsBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.btAddProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.сервисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btFarmTrade = new System.Windows.Forms.ToolStripMenuItem();
            this.btSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.btProductMed = new System.Windows.Forms.ToolStripMenuItem();
            this.btProductNds = new System.Windows.Forms.ToolStripMenuItem();
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
            this.RemainsTableAdapter = new RetailTrade.MDataSetTableAdapters.RemainsTableAdapter();
            this.pricesPurchaseTableAdapter = new RetailTrade.MDataSetTableAdapters.PricesPurchaseTableAdapter();
            this.productTableAdapter1 = new RetailTrade.FullDataSetTableAdapters.ProductTableAdapter();
            this.countryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.countryTableAdapter1 = new RetailTrade.FullDataSetTableAdapters.CountryTableAdapter();
            this.farmGroupBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.farmGroupTableAdapter1 = new RetailTrade.FullDataSetTableAdapters.FarmGroupTableAdapter();
            this.farmGroupLevel2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.farmGroupLevel2TableAdapter1 = new RetailTrade.FullDataSetTableAdapters.FarmGroupLevel2TableAdapter();
            this.manufacturerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.manufacturerTableAdapter1 = new RetailTrade.FullDataSetTableAdapters.ManufacturerTableAdapter();
            this.packingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.packingTableAdapter1 = new RetailTrade.FullDataSetTableAdapters.PackingTableAdapter();
            this.storageConditionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.storageConditionTableAdapter1 = new RetailTrade.FullDataSetTableAdapters.StorageConditionTableAdapter();
            this.unitTableAdapter1 = new RetailTrade.FullDataSetTableAdapters.UnitTableAdapter();
            this.substanceTableAdapter1 = new RetailTrade.FullDataSetTableAdapters.SubstanceTableAdapter();
            this.periodsTableAdapter = new RetailTrade.MDataSetTableAdapters.PeriodsTableAdapter();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.periodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.substanceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricesPurchaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemainsBindingSource)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmGroupBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmGroupLevel2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packingBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageConditionBindingSource1)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 561);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(779, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // actionStatusLabel
            // 
            this.actionStatusLabel.Name = "actionStatusLabel";
            this.actionStatusLabel.Size = new System.Drawing.Size(109, 17);
            this.actionStatusLabel.Text = "toolStripStatusLabel1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(779, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "CASGEBBI.jpg");
            // 
            // periodsBindingSource
            // 
            this.periodsBindingSource.DataMember = "Periods";
            this.periodsBindingSource.DataSource = this.mDataSet;
            // 
            // mDataSet
            // 
            this.mDataSet.DataSetName = "MDataSet";
            this.mDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // substanceBindingSource1
            // 
            this.substanceBindingSource1.DataMember = "Substance";
            this.substanceBindingSource1.DataSource = this.fullDataSet;
            // 
            // fullDataSet
            // 
            this.fullDataSet.DataSetName = "FullDataSet";
            this.fullDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // unitBindingSource1
            // 
            this.unitBindingSource1.DataMember = "Unit";
            this.unitBindingSource1.DataSource = this.fullDataSet;
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataMember = "Product";
            this.productBindingSource1.DataSource = this.fullDataSet;
            // 
            // pricesPurchaseBindingSource
            // 
            this.pricesPurchaseBindingSource.DataMember = "PricesPurchase";
            this.pricesPurchaseBindingSource.DataSource = this.mDataSet;
            // 
            // RemainsBindingSource
            // 
            this.RemainsBindingSource.DataMember = "Remains";
            this.RemainsBindingSource.DataSource = this.mDataSet;
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
            this.menuStrip1.Size = new System.Drawing.Size(779, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // документыToolStripMenuItem
            // 
            this.документыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateAktToolStripMenuItem,
            this.ReceiptMasterNewToolStripMenuItem,
            this.btAddProduct});
            this.документыToolStripMenuItem.Name = "документыToolStripMenuItem";
            this.документыToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.документыToolStripMenuItem.Text = "Документы";
            // 
            // CreateAktToolStripMenuItem
            // 
            this.CreateAktToolStripMenuItem.Name = "CreateAktToolStripMenuItem";
            this.CreateAktToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.CreateAktToolStripMenuItem.Text = "Создать приходный акт";
            // 
            // ReceiptMasterNewToolStripMenuItem
            // 
            this.ReceiptMasterNewToolStripMenuItem.Name = "ReceiptMasterNewToolStripMenuItem";
            this.ReceiptMasterNewToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.ReceiptMasterNewToolStripMenuItem.Tag = "ReceiptMasterNew";
            this.ReceiptMasterNewToolStripMenuItem.Text = "Приходные новые";
            this.ReceiptMasterNewToolStripMenuItem.ToolTipText = "Новые приходные акты";
            this.ReceiptMasterNewToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // btAddProduct
            // 
            this.btAddProduct.Name = "btAddProduct";
            this.btAddProduct.Size = new System.Drawing.Size(209, 22);
            this.btAddProduct.Text = "Добавить товар";
            this.btAddProduct.Click += new System.EventHandler(this.btAddProduct_Click);
            // 
            // сервисToolStripMenuItem
            // 
            this.сервисToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btFarmTrade,
            this.btSettingsToolStripMenuItem});
            this.сервисToolStripMenuItem.Name = "сервисToolStripMenuItem";
            this.сервисToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.сервисToolStripMenuItem.Text = "Сервис";
            // 
            // btFarmTrade
            // 
            this.btFarmTrade.Name = "btFarmTrade";
            this.btFarmTrade.Size = new System.Drawing.Size(194, 22);
            this.btFarmTrade.Tag = "ReceiptImport";
            this.btFarmTrade.Text = "Импорт с Фарм-Трейд";
            this.btFarmTrade.ToolTipText = "Импорт приходных документов";
            this.btFarmTrade.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // btSettingsToolStripMenuItem
            // 
            this.btSettingsToolStripMenuItem.Name = "btSettingsToolStripMenuItem";
            this.btSettingsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.btSettingsToolStripMenuItem.Tag = "ProjectSettings";
            this.btSettingsToolStripMenuItem.Text = "Параметры";
            this.btSettingsToolStripMenuItem.ToolTipText = "Настроки приложения";
            this.btSettingsToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btProduct,
            this.OrganisationToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripMenuItem2});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(86, 20);
            this.toolStripMenuItem1.Text = "Справочники";
            // 
            // btProduct
            // 
            this.btProduct.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btProductMed,
            this.btProductNds});
            this.btProduct.Name = "btProduct";
            this.btProduct.Size = new System.Drawing.Size(151, 22);
            this.btProduct.Tag = "UCProductAll";
            this.btProduct.Text = "Товаров";
            this.btProduct.ToolTipText = "Справочник товаров";
            // 
            // btProductMed
            // 
            this.btProductMed.Name = "btProductMed";
            this.btProductMed.Size = new System.Drawing.Size(248, 22);
            this.btProductMed.Tag = "UCProductAll";
            this.btProductMed.Text = "Товары без НДС (медикаменты)";
            this.btProductMed.ToolTipText = "Справочник товаров (медикаменты)";
            this.btProductMed.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // btProductNds
            // 
            this.btProductNds.Name = "btProductNds";
            this.btProductNds.Size = new System.Drawing.Size(248, 22);
            this.btProductNds.Tag = "UCProductAll";
            this.btProductNds.Text = "Товары с НДС (прочие)";
            this.btProductNds.ToolTipText = "Справочник товаров с НДС";
            this.btProductNds.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // OrganisationToolStripMenuItem
            // 
            this.OrganisationToolStripMenuItem.Name = "OrganisationToolStripMenuItem";
            this.OrganisationToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.OrganisationToolStripMenuItem.Tag = "Organization";
            this.OrganisationToolStripMenuItem.Text = "Организаций";
            this.OrganisationToolStripMenuItem.ToolTipText = "Справочник организаций";
            this.OrganisationToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(148, 6);
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
            this.toolStripMenuItem2.Size = new System.Drawing.Size(151, 22);
            this.toolStripMenuItem2.Text = "Служебные";
            // 
            // ManufacturerToolStripMenuItem
            // 
            this.ManufacturerToolStripMenuItem.Name = "ManufacturerToolStripMenuItem";
            this.ManufacturerToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.ManufacturerToolStripMenuItem.Tag = "Manufacturer";
            this.ManufacturerToolStripMenuItem.Text = "Изготовителей";
            this.ManufacturerToolStripMenuItem.ToolTipText = "Справочник изготовителей";
            this.ManufacturerToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // SubstanceToolStripMenuItem
            // 
            this.SubstanceToolStripMenuItem.Name = "SubstanceToolStripMenuItem";
            this.SubstanceToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.SubstanceToolStripMenuItem.Tag = "Substance";
            this.SubstanceToolStripMenuItem.Text = "Действующих веществ";
            this.SubstanceToolStripMenuItem.ToolTipText = "Справочник действующих веществ";
            this.SubstanceToolStripMenuItem.Click += new System.EventHandler(this.SampleDirectoryMenuItem_Click);
            // 
            // FarmGroupLevel2ToolStripMenuItem
            // 
            this.FarmGroupLevel2ToolStripMenuItem.Name = "FarmGroupLevel2ToolStripMenuItem";
            this.FarmGroupLevel2ToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.FarmGroupLevel2ToolStripMenuItem.Tag = "FarmGroupLevel2";
            this.FarmGroupLevel2ToolStripMenuItem.Text = "Фармгрупп";
            this.FarmGroupLevel2ToolStripMenuItem.ToolTipText = "Справочник фармгрупп";
            this.FarmGroupLevel2ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // StorageConditionToolStripMenuItem
            // 
            this.StorageConditionToolStripMenuItem.Name = "StorageConditionToolStripMenuItem";
            this.StorageConditionToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.StorageConditionToolStripMenuItem.Tag = "StorageCondition";
            this.StorageConditionToolStripMenuItem.Text = "Мест хранения";
            this.StorageConditionToolStripMenuItem.ToolTipText = "Справочник мест хранения";
            this.StorageConditionToolStripMenuItem.Click += new System.EventHandler(this.SampleDirectoryMenuItem_Click);
            // 
            // PackingToolStripMenuItem
            // 
            this.PackingToolStripMenuItem.Name = "PackingToolStripMenuItem";
            this.PackingToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.PackingToolStripMenuItem.Tag = "Packing";
            this.PackingToolStripMenuItem.Text = "Форм выпуска";
            this.PackingToolStripMenuItem.ToolTipText = "Справочник форм выпуска";
            this.PackingToolStripMenuItem.Click += new System.EventHandler(this.SampleDirectoryMenuItem_Click);
            // 
            // UnitToolStripMenuItem
            // 
            this.UnitToolStripMenuItem.Name = "UnitToolStripMenuItem";
            this.UnitToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.UnitToolStripMenuItem.Tag = "Unit";
            this.UnitToolStripMenuItem.Text = "Едениц измерения";
            this.UnitToolStripMenuItem.ToolTipText = "Справочник едениц измерения";
            this.UnitToolStripMenuItem.Click += new System.EventHandler(this.SampleDirectoryMenuItem_Click);
            // 
            // CountryToolStripMenuItem
            // 
            this.CountryToolStripMenuItem.Name = "CountryToolStripMenuItem";
            this.CountryToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.CountryToolStripMenuItem.Tag = "Country";
            this.CountryToolStripMenuItem.Text = "Стран";
            this.CountryToolStripMenuItem.ToolTipText = "Справочник стран";
            this.CountryToolStripMenuItem.Click += new System.EventHandler(this.SampleDirectoryMenuItem_Click);
            // 
            // типовДокументаToolStripMenuItem
            // 
            this.типовДокументаToolStripMenuItem.Name = "типовДокументаToolStripMenuItem";
            this.типовДокументаToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.типовДокументаToolStripMenuItem.Text = "Типов документа";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(202, 6);
            // 
            // TradePutletToolStripMenuItem
            // 
            this.TradePutletToolStripMenuItem.Name = "TradePutletToolStripMenuItem";
            this.TradePutletToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.TradePutletToolStripMenuItem.Tag = "TradePutlet";
            this.TradePutletToolStripMenuItem.Text = "Торговых точек";
            this.TradePutletToolStripMenuItem.ToolTipText = "Справочник торговых точек";
            this.TradePutletToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // складовToolStripMenuItem
            // 
            this.складовToolStripMenuItem.Name = "складовToolStripMenuItem";
            this.складовToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.складовToolStripMenuItem.Text = "Складов";
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
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
            // RemainsTableAdapter
            // 
            this.RemainsTableAdapter.ClearBeforeFill = true;
            // 
            // pricesPurchaseTableAdapter
            // 
            this.pricesPurchaseTableAdapter.ClearBeforeFill = true;
            // 
            // productTableAdapter1
            // 
            this.productTableAdapter1.ClearBeforeFill = true;
            // 
            // countryBindingSource1
            // 
            this.countryBindingSource1.DataMember = "Country";
            this.countryBindingSource1.DataSource = this.fullDataSet;
            // 
            // countryTableAdapter1
            // 
            this.countryTableAdapter1.ClearBeforeFill = true;
            // 
            // farmGroupBindingSource1
            // 
            this.farmGroupBindingSource1.DataMember = "FarmGroup";
            this.farmGroupBindingSource1.DataSource = this.fullDataSet;
            // 
            // farmGroupTableAdapter1
            // 
            this.farmGroupTableAdapter1.ClearBeforeFill = true;
            // 
            // farmGroupLevel2BindingSource1
            // 
            this.farmGroupLevel2BindingSource1.DataMember = "FarmGroupLevel2";
            this.farmGroupLevel2BindingSource1.DataSource = this.fullDataSet;
            // 
            // farmGroupLevel2TableAdapter1
            // 
            this.farmGroupLevel2TableAdapter1.ClearBeforeFill = true;
            // 
            // manufacturerBindingSource1
            // 
            this.manufacturerBindingSource1.DataMember = "Manufacturer";
            this.manufacturerBindingSource1.DataSource = this.fullDataSet;
            // 
            // manufacturerTableAdapter1
            // 
            this.manufacturerTableAdapter1.ClearBeforeFill = true;
            // 
            // packingBindingSource1
            // 
            this.packingBindingSource1.DataMember = "Packing";
            this.packingBindingSource1.DataSource = this.fullDataSet;
            // 
            // packingTableAdapter1
            // 
            this.packingTableAdapter1.ClearBeforeFill = true;
            // 
            // storageConditionBindingSource1
            // 
            this.storageConditionBindingSource1.DataMember = "StorageCondition";
            this.storageConditionBindingSource1.DataSource = this.fullDataSet;
            // 
            // storageConditionTableAdapter1
            // 
            this.storageConditionTableAdapter1.ClearBeforeFill = true;
            // 
            // unitTableAdapter1
            // 
            this.unitTableAdapter1.ClearBeforeFill = true;
            // 
            // substanceTableAdapter1
            // 
            this.substanceTableAdapter1.ClearBeforeFill = true;
            // 
            // periodsTableAdapter
            // 
            this.periodsTableAdapter.ClearBeforeFill = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.DataBindings.Add(new System.Windows.Forms.Binding("SplitterDistance", global::RetailTrade.Properties.Settings.Default, "MainSplitDist", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 49);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControl);
            this.splitContainer2.Size = new System.Drawing.Size(779, 512);
            this.splitContainer2.SplitterDistance = 259;
            this.splitContainer2.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(259, 512);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.treeView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(251, 486);
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
            treeNode2.Tag = "InvoiceForReplication";
            treeNode2.Text = "К отправке";
            treeNode2.ToolTipText = "Документы к отправке";
            treeNode3.Name = "Node7";
            treeNode3.Tag = "InvoiceClosed";
            treeNode3.Text = "Отправленные";
            treeNode3.ToolTipText = "Отправленные документы";
            treeNode4.Name = "Node8";
            treeNode4.Tag = "InvoiceReturn";
            treeNode4.Text = "Возвратные";
            treeNode4.ToolTipText = "Возвратные документы";
            treeNode5.Name = "Node0";
            treeNode5.Tag = "InvoiceAkt";
            treeNode5.Text = "Списание";
            treeNode5.ToolTipText = "Документы списания";
            treeNode6.Name = "NodeReciept";
            treeNode6.Tag = "";
            treeNode6.Text = "Накладные";
            treeNode7.Name = "Node10";
            treeNode7.Tag = "ReceiptMasterNewAll";
            treeNode7.Text = "Новые";
            treeNode7.ToolTipText = "Новые приходные акты";
            treeNode8.Name = "Node11";
            treeNode8.Tag = "ReceiptMasterStock";
            treeNode8.Text = "На складе";
            treeNode8.ToolTipText = "Приходные документы";
            treeNode9.Name = "Node9";
            treeNode9.Text = "Приходные";
            treeNode10.Name = "Node1";
            treeNode10.Tag = "Remains";
            treeNode10.Text = "Центральный склад";
            treeNode10.ToolTipText = "Отстатки - центр. склад";
            treeNode11.Name = "Node0";
            treeNode11.Text = "Остатки товара";
            treeNode12.Name = "Node12";
            treeNode12.Tag = "OrdersAll";
            treeNode12.Text = "Заявки";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode9,
            treeNode11,
            treeNode12});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(245, 480);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(251, 483);
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
            this.tabControl.Size = new System.Drawing.Size(516, 512);
            this.tabControl.TabIndex = 0;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(779, 583);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(200, 400);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Торговля-склад";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.periodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.substanceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricesPurchaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemainsBindingSource)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmGroupBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmGroupLevel2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packingBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageConditionBindingSource1)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem btProduct;
        private System.Windows.Forms.BindingSource mDataSetBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource;
        public RetailTrade.MDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        public MDataSet mDataSet;
        private System.Windows.Forms.BindingSource manufacturerBindingSource;
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
        private System.Windows.Forms.ToolStripMenuItem документыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сервисToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
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
        private System.Windows.Forms.BindingSource documentTypeBindingSource;
        private RetailTrade.MDataSetTableAdapters.DocumentTypeTableAdapter documentTypeTableAdapter;

        private RetailTrade.MDataSetTableAdapters.OrdersTableAdapter OrdersTableAdapter;
        private System.Windows.Forms.BindingSource invoiceMasterBindingSource;
        private System.Windows.Forms.BindingSource invoiceDetailBindingSource;
        private RetailTrade.MDataSetTableAdapters.InvoiceDetailTableAdapter invoiceDetailTableAdapter;
        public RetailTrade.MDataSetTableAdapters.ReceiptMasterTableAdapter receiptMasterTableAdapter;
        private System.Windows.Forms.BindingSource RemainsBindingSource;
        private RetailTrade.MDataSetTableAdapters.RemainsTableAdapter RemainsTableAdapter;
        private System.Windows.Forms.BindingSource pricesPurchaseBindingSource;
        private RetailTrade.MDataSetTableAdapters.PricesPurchaseTableAdapter pricesPurchaseTableAdapter;
        private System.Windows.Forms.ToolStripStatusLabel actionStatusLabel;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private System.Windows.Forms.BindingSource countryBindingSource1;
        private RetailTrade.FullDataSetTableAdapters.CountryTableAdapter countryTableAdapter1;
        private System.Windows.Forms.BindingSource farmGroupBindingSource1;
        private RetailTrade.FullDataSetTableAdapters.FarmGroupTableAdapter farmGroupTableAdapter1;
        private System.Windows.Forms.BindingSource farmGroupLevel2BindingSource1;
        private RetailTrade.FullDataSetTableAdapters.FarmGroupLevel2TableAdapter farmGroupLevel2TableAdapter1;
        private System.Windows.Forms.BindingSource manufacturerBindingSource1;
        private RetailTrade.FullDataSetTableAdapters.ManufacturerTableAdapter manufacturerTableAdapter1;
        private System.Windows.Forms.BindingSource packingBindingSource1;
        private RetailTrade.FullDataSetTableAdapters.PackingTableAdapter packingTableAdapter1;
        private System.Windows.Forms.BindingSource storageConditionBindingSource1;
        private RetailTrade.FullDataSetTableAdapters.StorageConditionTableAdapter storageConditionTableAdapter1;
        private System.Windows.Forms.BindingSource unitBindingSource1;
        private RetailTrade.FullDataSetTableAdapters.UnitTableAdapter unitTableAdapter1;
        private System.Windows.Forms.BindingSource substanceBindingSource1;
        private RetailTrade.FullDataSetTableAdapters.SubstanceTableAdapter substanceTableAdapter1;
        private System.Windows.Forms.ToolStripMenuItem btProductMed;
        private System.Windows.Forms.ToolStripMenuItem btProductNds;
        private System.Windows.Forms.ToolStripMenuItem btAddProduct;
        public FullDataSet fullDataSet;
        private System.Windows.Forms.BindingSource periodsBindingSource;
        private RetailTrade.MDataSetTableAdapters.PeriodsTableAdapter periodsTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem btFarmTrade;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.TabControl tabControl;
        public RetailTrade.MDataSetTableAdapters.InvoiceMasterTableAdapter invoiceMasterTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem btSettingsToolStripMenuItem;
        public RetailTrade.MDataSetTableAdapters.ManufacturerTableAdapter manufacturerTableAdapter;
        public RetailTrade.FullDataSetTableAdapters.ProductTableAdapter productTableAdapter1;
        }
}

