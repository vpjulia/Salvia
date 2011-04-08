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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LabelUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.actionLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.íîâûåToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ïðèíÿòûåToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
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
            this.ñåðâèñToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.documentTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cashBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cashTableAdapter = new RetailTradeClient.MDataSetTableAdapters.CashTableAdapter();
            this.localSettingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.localSettingTableAdapter = new RetailTradeClient.MDataSetTableAdapters.LocalSettingTableAdapter();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 554);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(775, 22);
            this.statusStrip1.TabIndex = 1;
            // 
            // LabelUser
            // 
            this.LabelUser.Font = new System.Drawing.Font("Tahoma", 8.400001F, System.Drawing.FontStyle.Italic);
            this.LabelUser.Image = ((System.Drawing.Image)(resources.GetObject("LabelUser.Image")));
            this.LabelUser.Name = "LabelUser";
            this.LabelUser.Size = new System.Drawing.Size(139, 17);
            this.LabelUser.Text = "toolStripStatusLabel1";
            // 
            // actionLabel
            // 
            this.actionLabel.Name = "actionLabel";
            this.actionLabel.Size = new System.Drawing.Size(10, 17);
            this.actionLabel.Text = " ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripSplitButton1,
            this.toolStripSeparator2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(775, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::RetailTradeClient.Properties.Resources.folder_document;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(143, 22);
            this.toolStripButton1.Tag = "InvoiceTradePutletAll";
            this.toolStripButton1.Text = "Ðàñõîäíûå äîêóìåíòû";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.íîâûåToolStripMenuItem,
            this.ïðèíÿòûåToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(157, 22);
            this.toolStripSplitButton1.Tag = "ReceiptMasterNewAll";
            this.toolStripSplitButton1.Text = "Ïðèõîäíûå äîêóìåíòû";
            this.toolStripSplitButton1.ToolTipText = "Íîâûå ïðèõîäíûå àêòû";
            this.toolStripSplitButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // íîâûåToolStripMenuItem
            // 
            this.íîâûåToolStripMenuItem.Name = "íîâûåToolStripMenuItem";
            this.íîâûåToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.íîâûåToolStripMenuItem.Tag = "ReceiptMasterNewAll";
            this.íîâûåToolStripMenuItem.Text = "Íîâûå";
            this.íîâûåToolStripMenuItem.ToolTipText = "Íîâûå äîêóìåíòû";
            this.íîâûåToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // ïðèíÿòûåToolStripMenuItem
            // 
            this.ïðèíÿòûåToolStripMenuItem.Name = "ïðèíÿòûåToolStripMenuItem";
            this.ïðèíÿòûåToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.ïðèíÿòûåToolStripMenuItem.Tag = "ReceiptMasterStock";
            this.ïðèíÿòûåToolStripMenuItem.Text = "Ïðèíÿòûå";
            this.ïðèíÿòûåToolStripMenuItem.ToolTipText = "Ïðèíÿòûå ïðèõîäû";
            this.ïðèíÿòûåToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(109, 22);
            this.toolStripButton3.Tag = "Remains";
            this.toolStripButton3.Text = "Îñòàòêè òîâàðà";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton1_Click);
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
            this.ñåðâèñToolStripMenuItem,
            this.btReportSum,
            this.MariaMenu,
            this.DatecsMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(775, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ñåðâèñToolStripMenuItem
            // 
            this.ñåðâèñToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btSettingsToolStripMenuItem,
            this.btInventory});
            this.ñåðâèñToolStripMenuItem.Name = "ñåðâèñToolStripMenuItem";
            this.ñåðâèñToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.ñåðâèñToolStripMenuItem.Text = "Ñåðâèñ";
            // 
            // btSettingsToolStripMenuItem
            // 
            this.btSettingsToolStripMenuItem.Name = "btSettingsToolStripMenuItem";
            this.btSettingsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.btSettingsToolStripMenuItem.Tag = "ProjectSettings";
            this.btSettingsToolStripMenuItem.Text = "Ïàðàìåòðû";
            this.btSettingsToolStripMenuItem.ToolTipText = "Íàñòðîêè ïðèëîæåíèÿ";
            this.btSettingsToolStripMenuItem.Visible = false;
            this.btSettingsToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // btInventory
            // 
            this.btInventory.Name = "btInventory";
            this.btInventory.Size = new System.Drawing.Size(169, 22);
            this.btInventory.Tag = "Inventory";
            this.btInventory.Text = "Èíâåíòàðèçàöèÿ";
            this.btInventory.ToolTipText = "Èíâåíòàðèçàöèîííàÿ îïèñü";
            this.btInventory.Click += new System.EventHandler(this.btInventory_Click);
            // 
            // btReportSum
            // 
            this.btReportSum.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btRepSum});
            this.btReportSum.Name = "btReportSum";
            this.btReportSum.Size = new System.Drawing.Size(59, 20);
            this.btReportSum.Text = "Îò÷åòû";
            // 
            // btRepSum
            // 
            this.btRepSum.Name = "btRepSum";
            this.btRepSum.Size = new System.Drawing.Size(137, 22);
            this.btRepSum.Tag = "RetailTradeCLReriodical";
            this.btRepSum.Text = "Çà ïåðèîä";
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
            this.MariaMenu.Size = new System.Drawing.Size(48, 20);
            this.MariaMenu.Text = "Êàññà";
            this.MariaMenu.Visible = false;
            // 
            // btMariaXreport
            // 
            this.btMariaXreport.Name = "btMariaXreport";
            this.btMariaXreport.Size = new System.Drawing.Size(152, 22);
            this.btMariaXreport.Text = "X- Îò÷åò";
            this.btMariaXreport.Click += new System.EventHandler(this.btMariaXreport_Click);
            // 
            // btMariaZReport
            // 
            this.btMariaZReport.Name = "btMariaZReport";
            this.btMariaZReport.Size = new System.Drawing.Size(152, 22);
            this.btMariaZReport.Text = "Z - Îò÷åò";
            this.btMariaZReport.Click += new System.EventHandler(this.btMariaZReport_Click);
            // 
            // btMariaOfExpend
            // 
            this.btMariaOfExpend.Name = "btMariaOfExpend";
            this.btMariaOfExpend.Size = new System.Drawing.Size(152, 22);
            this.btMariaOfExpend.Text = "Èíêàññàöèÿ";
            this.btMariaOfExpend.Click += new System.EventHandler(this.btMariaOfExpend_Click);
            // 
            // btMariaZperiodReport
            // 
            this.btMariaZperiodReport.Name = "btMariaZperiodReport";
            this.btMariaZperiodReport.Size = new System.Drawing.Size(152, 22);
            this.btMariaZperiodReport.Text = "Z çà ïåðèîä";
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
            this.DatecsMenu.Size = new System.Drawing.Size(48, 20);
            this.DatecsMenu.Text = "Êàññà";
            // 
            // btDatecsXReport
            // 
            this.btDatecsXReport.Name = "btDatecsXReport";
            this.btDatecsXReport.Size = new System.Drawing.Size(210, 22);
            this.btDatecsXReport.Text = "X- Îò÷åò";
            this.btDatecsXReport.Click += new System.EventHandler(this.btDatecsXReport_Click);
            // 
            // menuDatecsZReport
            // 
            this.menuDatecsZReport.Name = "menuDatecsZReport";
            this.menuDatecsZReport.Size = new System.Drawing.Size(210, 22);
            this.menuDatecsZReport.Text = "Z - Îò÷åò";
            this.menuDatecsZReport.Click += new System.EventHandler(this.menuDatecsZReport_Click);
            // 
            // btDatecsOfExpend
            // 
            this.btDatecsOfExpend.Name = "btDatecsOfExpend";
            this.btDatecsOfExpend.Size = new System.Drawing.Size(210, 22);
            this.btDatecsOfExpend.Text = "Èíêàññàöèÿ";
            this.btDatecsOfExpend.Click += new System.EventHandler(this.btDatecsOfExpend_Click);
            // 
            // btDatecsPeriodReport
            // 
            this.btDatecsPeriodReport.Name = "btDatecsPeriodReport";
            this.btDatecsPeriodReport.Size = new System.Drawing.Size(210, 22);
            this.btDatecsPeriodReport.Text = "Îò÷åò çà ïåðèîä";
            this.btDatecsPeriodReport.Click += new System.EventHandler(this.btDatecsPeriodReport_Click);
            // 
            // btDatecsCloseCheck
            // 
            this.btDatecsCloseCheck.Name = "btDatecsCloseCheck";
            this.btDatecsCloseCheck.Size = new System.Drawing.Size(210, 22);
            this.btDatecsCloseCheck.Text = "Çàêðûòü ÷åê";
            this.btDatecsCloseCheck.Click += new System.EventHandler(this.btDatecsCloseCheck_Click);
            // 
            // btPeriodReportByNum
            // 
            this.btPeriodReportByNum.Name = "btPeriodReportByNum";
            this.btPeriodReportByNum.Size = new System.Drawing.Size(210, 22);
            this.btPeriodReportByNum.Text = "Îò÷åò çà ïåðèîä (ïî ¹)";
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
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 49);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(775, 505);
            this.tabControl.TabIndex = 5;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(775, 576);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(200, 400);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Àïòåêà ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem ñåðâèñToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem íîâûåToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ïðèíÿòûåToolStripMenuItem;
        public System.Windows.Forms.TabControl tabControl;
        }
}

