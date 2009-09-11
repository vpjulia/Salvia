namespace RetailTradeClient
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
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("На складе");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Приходные", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("За период");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Возвратные документы");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Расходные документы", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Остатки товара");
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LabelUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.actionLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.periodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mDataSet = new RetailTradeClient.MDataSet();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.RemainsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receiptMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receiptDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сервисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.btReportSum = new System.Windows.Forms.ToolStripMenuItem();
            this.btRepSum = new System.Windows.Forms.ToolStripMenuItem();
            this.MariaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btMariaXreport = new System.Windows.Forms.ToolStripMenuItem();
            this.btMariaZReport = new System.Windows.Forms.ToolStripMenuItem();
            this.btMariaOfExpend = new System.Windows.Forms.ToolStripMenuItem();
            this.btMariaZperiodReport = new System.Windows.Forms.ToolStripMenuItem();
            this.DatecsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btDatecsXReport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDatecsZReport = new System.Windows.Forms.ToolStripMenuItem();
            this.btDatecsOfExpend = new System.Windows.Forms.ToolStripMenuItem();
            this.btDatecsPeriodReport = new System.Windows.Forms.ToolStripMenuItem();
            this.btDatecsCloseCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.btPeriodReportByNum = new System.Windows.Forms.ToolStripMenuItem();
            this.productTableAdapter = new RetailTradeClient.MDataSetTableAdapters.ProductTableAdapter();
            this.receiptMasterTableAdapter = new RetailTradeClient.MDataSetTableAdapters.ReceiptMasterTableAdapter();
            this.receiptDetailTableAdapter = new RetailTradeClient.MDataSetTableAdapters.ReceiptDetailTableAdapter();
            this.documentTypeTableAdapter = new RetailTradeClient.MDataSetTableAdapters.DocumentTypeTableAdapter();
            this.invoiceMasterTableAdapter = new RetailTradeClient.MDataSetTableAdapters.InvoiceMasterTableAdapter();
            this.invoiceDetailTableAdapter = new RetailTradeClient.MDataSetTableAdapters.InvoiceDetailTableAdapter();
            this.RemainsTableAdapter = new RetailTradeClient.MDataSetTableAdapters.RemainsTableAdapter();
            this.periodsTableAdapter = new RetailTradeClient.MDataSetTableAdapters.PeriodsTableAdapter();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.documentTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cashBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cashTableAdapter = new RetailTradeClient.MDataSetTableAdapters.CashTableAdapter();
            this.localSettingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.localSettingTableAdapter = new RetailTradeClient.MDataSetTableAdapters.LocalSettingTableAdapter();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.periodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemainsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localSettingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LabelUser,
            this.actionLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 553);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(775, 23);
            this.statusStrip1.TabIndex = 1;
            // 
            // LabelUser
            // 
            this.LabelUser.Font = new System.Drawing.Font("Tahoma", 8.400001F, System.Drawing.FontStyle.Italic);
            this.LabelUser.Image = ((System.Drawing.Image)(resources.GetObject("LabelUser.Image")));
            this.LabelUser.Name = "LabelUser";
            this.LabelUser.Size = new System.Drawing.Size(157, 18);
            this.LabelUser.Text = "toolStripStatusLabel1";
            // 
            // actionLabel
            // 
            this.actionLabel.Name = "actionLabel";
            this.actionLabel.Size = new System.Drawing.Size(13, 18);
            this.actionLabel.Text = " ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 26);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(775, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder_closed.png");
            this.imageList1.Images.SetKeyName(1, "folder.png");
            this.imageList1.Images.SetKeyName(2, "folder_document.png");
            this.imageList1.Images.SetKeyName(3, "folder_network.png");
            this.imageList1.Images.SetKeyName(4, "folder_into.png");
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
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.mDataSetBindingSource;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сервисToolStripMenuItem,
            this.btReportSum,
            this.MariaMenu,
            this.DatecsMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(775, 26);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сервисToolStripMenuItem
            // 
            this.сервисToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btSettingsToolStripMenuItem,
            this.btInventory});
            this.сервисToolStripMenuItem.Name = "сервисToolStripMenuItem";
            this.сервисToolStripMenuItem.Size = new System.Drawing.Size(68, 22);
            this.сервисToolStripMenuItem.Text = "Сервис";
            // 
            // btSettingsToolStripMenuItem
            // 
            this.btSettingsToolStripMenuItem.Name = "btSettingsToolStripMenuItem";
            this.btSettingsToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.btSettingsToolStripMenuItem.Tag = "ProjectSettings";
            this.btSettingsToolStripMenuItem.Text = "Параметры";
            this.btSettingsToolStripMenuItem.ToolTipText = "Настроки приложения";
            this.btSettingsToolStripMenuItem.Visible = false;
            this.btSettingsToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // btInventory
            // 
            this.btInventory.Name = "btInventory";
            this.btInventory.Size = new System.Drawing.Size(205, 22);
            this.btInventory.Tag = "Inventory";
            this.btInventory.Text = "Инвентаризация";
            this.btInventory.ToolTipText = "Инвентаризационная опись";
            this.btInventory.Click += new System.EventHandler(this.btInventory_Click);
            // 
            // btReportSum
            // 
            this.btReportSum.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btRepSum});
            this.btReportSum.Name = "btReportSum";
            this.btReportSum.Size = new System.Drawing.Size(73, 22);
            this.btReportSum.Text = "Отчеты";
            // 
            // btRepSum
            // 
            this.btRepSum.Name = "btRepSum";
            this.btRepSum.Size = new System.Drawing.Size(160, 22);
            this.btRepSum.Tag = "RetailTradeCLReriodical";
            this.btRepSum.Text = "За период";
            this.btRepSum.Click += new System.EventHandler(this.btReportSum_Click);
            // 
            // MariaMenu
            // 
            this.MariaMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btMariaXreport,
            this.btMariaZReport,
            this.btMariaOfExpend,
            this.btMariaZperiodReport});
            this.MariaMenu.Name = "MariaMenu";
            this.MariaMenu.Size = new System.Drawing.Size(59, 22);
            this.MariaMenu.Text = "Касса";
            // 
            // btMariaXreport
            // 
            this.btMariaXreport.Name = "btMariaXreport";
            this.btMariaXreport.Size = new System.Drawing.Size(172, 22);
            this.btMariaXreport.Text = "X- Отчет";
            this.btMariaXreport.Click += new System.EventHandler(this.btMariaXreport_Click);
            // 
            // btMariaZReport
            // 
            this.btMariaZReport.Name = "btMariaZReport";
            this.btMariaZReport.Size = new System.Drawing.Size(172, 22);
            this.btMariaZReport.Text = "Z - Отчет";
            this.btMariaZReport.Click += new System.EventHandler(this.btMariaZReport_Click);
            // 
            // btMariaOfExpend
            // 
            this.btMariaOfExpend.Name = "btMariaOfExpend";
            this.btMariaOfExpend.Size = new System.Drawing.Size(172, 22);
            this.btMariaOfExpend.Text = "Инкассация";
            this.btMariaOfExpend.Click += new System.EventHandler(this.btMariaOfExpend_Click);
            // 
            // btMariaZperiodReport
            // 
            this.btMariaZperiodReport.Name = "btMariaZperiodReport";
            this.btMariaZperiodReport.Size = new System.Drawing.Size(172, 22);
            this.btMariaZperiodReport.Text = "Z за период";
            this.btMariaZperiodReport.Click += new System.EventHandler(this.btMariaZperiodReport_Click);
            // 
            // DatecsMenu
            // 
            this.DatecsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btDatecsXReport,
            this.menuDatecsZReport,
            this.btDatecsOfExpend,
            this.btDatecsPeriodReport,
            this.btDatecsCloseCheck,
            this.btPeriodReportByNum});
            this.DatecsMenu.Name = "DatecsMenu";
            this.DatecsMenu.Size = new System.Drawing.Size(59, 22);
            this.DatecsMenu.Text = "Касса";
            // 
            // btDatecsXReport
            // 
            this.btDatecsXReport.Name = "btDatecsXReport";
            this.btDatecsXReport.Size = new System.Drawing.Size(262, 22);
            this.btDatecsXReport.Text = "X- Отчет";
            this.btDatecsXReport.Click += new System.EventHandler(this.btDatecsXReport_Click);
            // 
            // menuDatecsZReport
            // 
            this.menuDatecsZReport.Name = "menuDatecsZReport";
            this.menuDatecsZReport.Size = new System.Drawing.Size(262, 22);
            this.menuDatecsZReport.Text = "Z - Отчет";
            this.menuDatecsZReport.Click += new System.EventHandler(this.menuDatecsZReport_Click);
            // 
            // btDatecsOfExpend
            // 
            this.btDatecsOfExpend.Name = "btDatecsOfExpend";
            this.btDatecsOfExpend.Size = new System.Drawing.Size(262, 22);
            this.btDatecsOfExpend.Text = "Инкассация";
            this.btDatecsOfExpend.Click += new System.EventHandler(this.btDatecsOfExpend_Click);
            // 
            // btDatecsPeriodReport
            // 
            this.btDatecsPeriodReport.Name = "btDatecsPeriodReport";
            this.btDatecsPeriodReport.Size = new System.Drawing.Size(262, 22);
            this.btDatecsPeriodReport.Text = "Отчет за период";
            this.btDatecsPeriodReport.Click += new System.EventHandler(this.btDatecsPeriodReport_Click);
            // 
            // btDatecsCloseCheck
            // 
            this.btDatecsCloseCheck.Name = "btDatecsCloseCheck";
            this.btDatecsCloseCheck.Size = new System.Drawing.Size(262, 22);
            this.btDatecsCloseCheck.Text = "Закрыть чек";
            this.btDatecsCloseCheck.Click += new System.EventHandler(this.btDatecsCloseCheck_Click);
            // 
            // btPeriodReportByNum
            // 
            this.btPeriodReportByNum.Name = "btPeriodReportByNum";
            this.btPeriodReportByNum.Size = new System.Drawing.Size(262, 22);
            this.btPeriodReportByNum.Text = "Отчет за период (по №)";
            this.btPeriodReportByNum.Click += new System.EventHandler(this.btPeriodReportByNum_Click);
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
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
            // periodsTableAdapter
            // 
            this.periodsTableAdapter.ClearBeforeFill = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.DataBindings.Add(new System.Windows.Forms.Binding("SplitterDistance", global::RetailTradeClient.Properties.Settings.Default, "MainSplitDist", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 51);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControl);
            this.splitContainer2.Size = new System.Drawing.Size(775, 502);
            this.splitContainer2.SplitterDistance = 245;
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
            this.tabControl1.Size = new System.Drawing.Size(245, 502);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.treeView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(237, 473);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "новые";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node10";
            treeNode1.Tag = "ReceiptMasterNewAll";
            treeNode1.Text = "Новые";
            treeNode1.ToolTipText = "Новые приходные акты";
            treeNode2.Name = "Node11";
            treeNode2.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode2.Tag = "ReceiptMasterStock";
            treeNode2.Text = "На складе";
            treeNode2.ToolTipText = "Приходные документы";
            treeNode3.ImageKey = "folder_closed.png";
            treeNode3.Name = "Node9";
            treeNode3.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode3.SelectedImageIndex = 1;
            treeNode3.Text = "Приходные";
            treeNode4.Name = "Node1";
            treeNode4.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode4.Tag = "InvoiceDetail";
            treeNode4.Text = "За период";
            treeNode4.ToolTipText = "За период";
            treeNode5.Name = "Node0";
            treeNode5.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode5.Tag = "InvoiceReturn";
            treeNode5.Text = "Возвратные документы";
            treeNode5.ToolTipText = "Возвратные документы";
            treeNode6.Name = "Node0";
            treeNode6.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode6.Tag = "InvoiceTradePutletAll";
            treeNode6.Text = "Расходные документы";
            treeNode6.ToolTipText = "Кассовые чеки ";
            treeNode7.Name = "Node0";
            treeNode7.Tag = "Remains";
            treeNode7.Text = "Остатки товара";
            treeNode7.ToolTipText = "Остатки товара";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6,
            treeNode7});
            this.treeView1.SelectedImageIndex = 2;
            this.treeView1.Size = new System.Drawing.Size(231, 467);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(237, 473);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "все";
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(526, 502);
            this.tabControl.TabIndex = 0;
            // 
            // documentTypeBindingSource
            // 
            this.documentTypeBindingSource.DataMember = "DocumentType";
            this.documentTypeBindingSource.DataSource = this.mDataSet;
            // 
            // cashBindingSource
            // 
            this.cashBindingSource.DataMember = "Cash";
            this.cashBindingSource.DataSource = this.mDataSet;
            // 
            // cashTableAdapter
            // 
            this.cashTableAdapter.ClearBeforeFill = true;
            // 
            // localSettingBindingSource
            // 
            this.localSettingBindingSource.DataMember = "LocalSetting";
            this.localSettingBindingSource.DataSource = this.mDataSet;
            // 
            // localSettingTableAdapter
            // 
            this.localSettingTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(775, 576);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(200, 400);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аптека ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.periodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemainsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localSettingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.BindingSource mDataSetBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource;
        private RetailTradeClient.MDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        public MDataSet mDataSet;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem сервисToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btReportSum;
        private RetailTradeClient.MDataSetTableAdapters.ReceiptDetailTableAdapter receiptDetailTableAdapter;
        public System.Windows.Forms.BindingSource receiptDetailBindingSource;
        public System.Windows.Forms.BindingSource receiptMasterBindingSource;
        private RetailTradeClient.MDataSetTableAdapters.DocumentTypeTableAdapter documentTypeTableAdapter;

        private System.Windows.Forms.BindingSource invoiceMasterBindingSource;
        private System.Windows.Forms.BindingSource invoiceDetailBindingSource;
        public RetailTradeClient.MDataSetTableAdapters.ReceiptMasterTableAdapter receiptMasterTableAdapter;
        private System.Windows.Forms.BindingSource RemainsBindingSource;
        private RetailTradeClient.MDataSetTableAdapters.RemainsTableAdapter RemainsTableAdapter;
        private System.Windows.Forms.ToolStripStatusLabel LabelUser;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private System.Windows.Forms.BindingSource periodsBindingSource;
        private RetailTradeClient.MDataSetTableAdapters.PeriodsTableAdapter periodsTableAdapter;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.TabControl tabControl;
        public RetailTradeClient.MDataSetTableAdapters.InvoiceMasterTableAdapter invoiceMasterTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem btSettingsToolStripMenuItem;
        private System.Windows.Forms.BindingSource documentTypeBindingSource;
        private RetailTradeClient.MDataSetTableAdapters.CashTableAdapter cashTableAdapter;
        private System.Windows.Forms.BindingSource localSettingBindingSource;
        private RetailTradeClient.MDataSetTableAdapters.LocalSettingTableAdapter localSettingTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem btMariaXreport;
        private System.Windows.Forms.ToolStripMenuItem btMariaZReport;
        private System.Windows.Forms.ToolStripMenuItem btMariaOfExpend;
        private System.Windows.Forms.ToolStripMenuItem btMariaZperiodReport;
        private System.Windows.Forms.ToolStripMenuItem DatecsMenu;
        private System.Windows.Forms.ToolStripMenuItem btDatecsXReport;
        private System.Windows.Forms.ToolStripMenuItem menuDatecsZReport;
        private System.Windows.Forms.ToolStripMenuItem btDatecsOfExpend;
        private System.Windows.Forms.ToolStripMenuItem btDatecsPeriodReport;
        public System.Windows.Forms.BindingSource cashBindingSource;
        public System.Windows.Forms.ToolStripMenuItem MariaMenu;
        private System.Windows.Forms.ToolStripMenuItem btInventory;
        public System.Windows.Forms.ToolStripStatusLabel actionLabel;
        private System.Windows.Forms.ToolStripMenuItem btDatecsCloseCheck;
        private System.Windows.Forms.ToolStripMenuItem btPeriodReportByNum;
        private System.Windows.Forms.ToolStripMenuItem btRepSum;
        public RetailTradeClient.MDataSetTableAdapters.InvoiceDetailTableAdapter invoiceDetailTableAdapter;
        }
}

