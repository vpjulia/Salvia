namespace RetailTradeOrders
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.periodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mDataSet = new RetailTradeOrders.MDataSet();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.RemainsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receiptMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receiptDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btReport = new System.Windows.Forms.ToolStripMenuItem();
            this.productTableAdapter = new RetailTradeOrders.MDataSetTableAdapters.ProductTableAdapter();
            this.receiptMasterTableAdapter = new RetailTradeOrders.MDataSetTableAdapters.ReceiptMasterTableAdapter();
            this.receiptDetailTableAdapter = new RetailTradeOrders.MDataSetTableAdapters.ReceiptDetailTableAdapter();
            this.documentTypeTableAdapter = new RetailTradeOrders.MDataSetTableAdapters.DocumentTypeTableAdapter();
            this.invoiceMasterTableAdapter = new RetailTradeOrders.MDataSetTableAdapters.InvoiceMasterTableAdapter();
            this.invoiceDetailTableAdapter = new RetailTradeOrders.MDataSetTableAdapters.InvoiceDetailTableAdapter();
            this.RemainsTableAdapter = new RetailTradeOrders.MDataSetTableAdapters.RemainsTableAdapter();
            this.periodsTableAdapter = new RetailTradeOrders.MDataSetTableAdapters.PeriodsTableAdapter();
            this.documentTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cashBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cashTableAdapter = new RetailTradeOrders.MDataSetTableAdapters.CashTableAdapter();
            this.localSettingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.localSettingTableAdapter = new RetailTradeOrders.MDataSetTableAdapters.LocalSettingTableAdapter();
            this.tabControl = new System.Windows.Forms.TabControl();
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
            this.btReport});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(775, 26);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btReport
            // 
            this.btReport.Name = "btReport";
            this.btReport.Size = new System.Drawing.Size(73, 22);
            this.btReport.Text = "Отчеты";
            this.btReport.Click += new System.EventHandler(this.btReport_Click);
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
            this.tabControl.Location = new System.Drawing.Point(0, 51);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(775, 502);
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
            this.Text = "Дефектура";
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
        private RetailTradeOrders.MDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        public MDataSet mDataSet;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem btReport;
        private RetailTradeOrders.MDataSetTableAdapters.ReceiptDetailTableAdapter receiptDetailTableAdapter;
        public System.Windows.Forms.BindingSource receiptDetailBindingSource;
        public System.Windows.Forms.BindingSource receiptMasterBindingSource;
        private RetailTradeOrders.MDataSetTableAdapters.DocumentTypeTableAdapter documentTypeTableAdapter;

        private System.Windows.Forms.BindingSource invoiceMasterBindingSource;
        private System.Windows.Forms.BindingSource invoiceDetailBindingSource;
        private RetailTradeOrders.MDataSetTableAdapters.InvoiceDetailTableAdapter invoiceDetailTableAdapter;
        public RetailTradeOrders.MDataSetTableAdapters.ReceiptMasterTableAdapter receiptMasterTableAdapter;
        private System.Windows.Forms.BindingSource RemainsBindingSource;
        private RetailTradeOrders.MDataSetTableAdapters.RemainsTableAdapter RemainsTableAdapter;
        private System.Windows.Forms.ToolStripStatusLabel LabelUser;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private System.Windows.Forms.BindingSource periodsBindingSource;
        private RetailTradeOrders.MDataSetTableAdapters.PeriodsTableAdapter periodsTableAdapter;
        public RetailTradeOrders.MDataSetTableAdapters.InvoiceMasterTableAdapter invoiceMasterTableAdapter;
        private System.Windows.Forms.BindingSource documentTypeBindingSource;
        private RetailTradeOrders.MDataSetTableAdapters.CashTableAdapter cashTableAdapter;
        private System.Windows.Forms.BindingSource localSettingBindingSource;
        private RetailTradeOrders.MDataSetTableAdapters.LocalSettingTableAdapter localSettingTableAdapter;
        public System.Windows.Forms.BindingSource cashBindingSource;
        public System.Windows.Forms.ToolStripStatusLabel actionLabel;
        public System.Windows.Forms.TabControl tabControl;
        }
}

