namespace RetailTradeClient.Invoice.InvoiceTradePutlet
{
    partial class InvoicePrintMar
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoicePrintMar));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btPay = new System.Windows.Forms.Button();
            this.btPrintCheck = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gridRem = new DevExpress.XtraGrid.GridControl();
            this.remainsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mDataSet = new RetailTradeClient.MDataSet();
            this.gridViewInvRem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManufacturerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPricePurchase = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeries = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUseByDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantityRemains = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateLastModif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorLastModif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btReturnDoc = new System.Windows.Forms.ToolStripButton();
            this.gridDet = new DevExpress.XtraGrid.GridControl();
            this.contextMenuEditing = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewInvDet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManufacturerName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriceRetailNDS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRetailSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUseByDate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CashbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceMasterBindingSourceView = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btPayMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.productTableAdapter = new RetailTradeClient.MDataSetTableAdapters.ProductTableAdapter();
            this.flowLayoutPanel1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remainsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInvRem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDet)).BeginInit();
            this.contextMenuEditing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInvDet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CashbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceMasterBindingSourceView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btPay);
            this.flowLayoutPanel1.Controls.Add(this.btPrintCheck);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 513);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(795, 39);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btPay
            // 
            this.btPay.Image = global::RetailTradeClient.Properties.Resources.printer;
            this.btPay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPay.Location = new System.Drawing.Point(668, 3);
            this.btPay.Name = "btPay";
            this.btPay.Size = new System.Drawing.Size(124, 33);
            this.btPay.TabIndex = 0;
            this.btPay.Text = "Оплата";
            this.btPay.UseVisualStyleBackColor = true;
            this.btPay.Click += new System.EventHandler(this.btPay_Click);
            // 
            // btPrintCheck
            // 
            this.btPrintCheck.Image = global::RetailTradeClient.Properties.Resources.printer_ok;
            this.btPrintCheck.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPrintCheck.Location = new System.Drawing.Point(514, 3);
            this.btPrintCheck.Name = "btPrintCheck";
            this.btPrintCheck.Size = new System.Drawing.Size(148, 33);
            this.btPrintCheck.TabIndex = 1;
            this.btPrintCheck.Text = "Напечатать чек";
            this.btPrintCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btPrintCheck.UseVisualStyleBackColor = true;
            this.btPrintCheck.Visible = false;
            this.btPrintCheck.Click += new System.EventHandler(this.btPrintCheck_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gridRem);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridDet);
            this.splitContainer1.Size = new System.Drawing.Size(795, 513);
            this.splitContainer1.SplitterDistance = 271;
            this.splitContainer1.TabIndex = 0;
            // 
            // gridRem
            // 
            this.gridRem.DataSource = this.remainsBindingSource;
            this.gridRem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridRem.EmbeddedNavigator.Name = "";
            this.gridRem.Location = new System.Drawing.Point(0, 25);
            this.gridRem.MainView = this.gridViewInvRem;
            this.gridRem.Name = "gridRem";
            this.gridRem.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridRem.ShowOnlyPredefinedDetails = true;
            this.gridRem.Size = new System.Drawing.Size(795, 246);
            this.gridRem.TabIndex = 0;
            this.gridRem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewInvRem});
            // 
            // remainsBindingSource
            // 
            this.remainsBindingSource.DataMember = "Remains";
            this.remainsBindingSource.DataSource = this.mDataSet;
            // 
            // mDataSet
            // 
            this.mDataSet.DataSetName = "MDataSet";
            this.mDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewInvRem
            // 
            this.gridViewInvRem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductName,
            this.colManufacturerName,
            this.colPricePurchase,
            this.colSeries,
            this.colUseByDate,
            this.colQuantityRemains,
            this.colDateLastModif,
            this.colAuthorLastModif,
            this.colCountryName,
            this.colDocDate});
            this.gridViewInvRem.GridControl = this.gridRem;
            this.gridViewInvRem.Name = "gridViewInvRem";
            this.gridViewInvRem.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridViewInvRem.OptionsBehavior.Editable = false;
            this.gridViewInvRem.OptionsCustomization.AllowFilter = false;
            this.gridViewInvRem.OptionsView.ShowAutoFilterRow = true;
            this.gridViewInvRem.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colProductName, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewInvRem.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridViewInvRem_CustomDrawCell);
            this.gridViewInvRem.DoubleClick += new System.EventHandler(this.gridViewInvRem_DoubleClick);
            this.gridViewInvRem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewInvRem_KeyDown);
            // 
            // colProductName
            // 
            this.colProductName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colProductName.AppearanceCell.Options.UseFont = true;
            this.colProductName.Caption = "Наименование";
            this.colProductName.FieldName = "ProductName";
            this.colProductName.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colProductName.Name = "colProductName";
            this.colProductName.OptionsColumn.AllowEdit = false;
            this.colProductName.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText;
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 0;
            this.colProductName.Width = 170;
            // 
            // colManufacturerName
            // 
            this.colManufacturerName.Caption = "Изготовитель";
            this.colManufacturerName.FieldName = "ManufacturerName";
            this.colManufacturerName.Name = "colManufacturerName";
            this.colManufacturerName.Visible = true;
            this.colManufacturerName.VisibleIndex = 1;
            this.colManufacturerName.Width = 126;
            // 
            // colPricePurchase
            // 
            this.colPricePurchase.Caption = "Цена";
            this.colPricePurchase.FieldName = "PricePurchase";
            this.colPricePurchase.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colPricePurchase.Name = "colPricePurchase";
            this.colPricePurchase.Visible = true;
            this.colPricePurchase.VisibleIndex = 5;
            this.colPricePurchase.Width = 73;
            // 
            // colSeries
            // 
            this.colSeries.Caption = "Серия";
            this.colSeries.FieldName = "Series";
            this.colSeries.Name = "colSeries";
            this.colSeries.Visible = true;
            this.colSeries.VisibleIndex = 2;
            this.colSeries.Width = 73;
            // 
            // colUseByDate
            // 
            this.colUseByDate.Caption = "Срок";
            this.colUseByDate.FieldName = "UseByDate";
            this.colUseByDate.Name = "colUseByDate";
            this.colUseByDate.Visible = true;
            this.colUseByDate.VisibleIndex = 3;
            this.colUseByDate.Width = 81;
            // 
            // colQuantityRemains
            // 
            this.colQuantityRemains.Caption = "Остаток";
            this.colQuantityRemains.FieldName = "QuantityRemains";
            this.colQuantityRemains.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colQuantityRemains.Name = "colQuantityRemains";
            this.colQuantityRemains.Visible = true;
            this.colQuantityRemains.VisibleIndex = 6;
            this.colQuantityRemains.Width = 68;
            // 
            // colDateLastModif
            // 
            this.colDateLastModif.Caption = "Изменен";
            this.colDateLastModif.FieldName = "DateLastModif";
            this.colDateLastModif.Name = "colDateLastModif";
            // 
            // colAuthorLastModif
            // 
            this.colAuthorLastModif.Caption = "Редактор";
            this.colAuthorLastModif.FieldName = "AuthorLastModif";
            this.colAuthorLastModif.Name = "colAuthorLastModif";
            // 
            // colCountryName
            // 
            this.colCountryName.Caption = "Страна";
            this.colCountryName.FieldName = "CountryName";
            this.colCountryName.Name = "colCountryName";
            // 
            // colDocDate
            // 
            this.colDocDate.Caption = "Дата прихода";
            this.colDocDate.FieldName = "DocDate";
            this.colDocDate.Name = "colDocDate";
            this.colDocDate.Visible = true;
            this.colDocDate.VisibleIndex = 4;
            this.colDocDate.Width = 67;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DataSource = this.productBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "UnitName";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEdit1.ValueMember = "ID";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.mDataSet;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btReturnDoc});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(795, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.TabStop = true;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btReturnDoc
            // 
            this.btReturnDoc.Image = global::RetailTradeClient.Properties.Resources.document_lock;
            this.btReturnDoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btReturnDoc.Name = "btReturnDoc";
            this.btReturnDoc.Size = new System.Drawing.Size(310, 22);
            this.btReturnDoc.Text = "Закрыть как возврат ( на Центр. склад) ";
            this.btReturnDoc.Click += new System.EventHandler(this.btReturnDoc_Click);
            // 
            // gridDet
            // 
            this.gridDet.ContextMenuStrip = this.contextMenuEditing;
            this.gridDet.DataSource = this.invoiceDetailBindingSource;
            this.gridDet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDet.EmbeddedNavigator.Name = "";
            this.gridDet.Location = new System.Drawing.Point(0, 0);
            this.gridDet.MainView = this.gridViewInvDet;
            this.gridDet.Name = "gridDet";
            this.gridDet.Size = new System.Drawing.Size(795, 238);
            this.gridDet.TabIndex = 0;
            this.gridDet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewInvDet});
            // 
            // contextMenuEditing
            // 
            this.contextMenuEditing.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btDelete});
            this.contextMenuEditing.Name = "contextMenuStrip1";
            this.contextMenuEditing.Size = new System.Drawing.Size(200, 26);
            // 
            // btDelete
            // 
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(199, 22);
            this.btDelete.Text = "Удалить строку";
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // invoiceDetailBindingSource
            // 
            this.invoiceDetailBindingSource.DataMember = "FK_InvoiceDetail_InvoiceMaster";
            this.invoiceDetailBindingSource.DataSource = this.invoiceMasterBindingSource;
            // 
            // invoiceMasterBindingSource
            // 
            this.invoiceMasterBindingSource.DataMember = "InvoiceMaster";
            this.invoiceMasterBindingSource.DataSource = this.mDataSet;
            // 
            // gridViewInvDet
            // 
            this.gridViewInvDet.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductName1,
            this.colManufacturerName1,
            this.colQuantity1,
            this.colPriceRetailNDS,
            this.colRetailSum,
            this.colUseByDate1});
            this.gridViewInvDet.GridControl = this.gridDet;
            this.gridViewInvDet.Name = "gridViewInvDet";
            this.gridViewInvDet.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridViewInvDet.OptionsBehavior.Editable = false;
            this.gridViewInvDet.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewInvDet.OptionsView.ShowFooter = true;
            // 
            // colProductName1
            // 
            this.colProductName1.Caption = "Наименование";
            this.colProductName1.FieldName = "ProductName";
            this.colProductName1.Name = "colProductName1";
            this.colProductName1.Visible = true;
            this.colProductName1.VisibleIndex = 0;
            this.colProductName1.Width = 152;
            // 
            // colManufacturerName1
            // 
            this.colManufacturerName1.Caption = "Изготовитель";
            this.colManufacturerName1.FieldName = "ManufacturerName";
            this.colManufacturerName1.Name = "colManufacturerName1";
            this.colManufacturerName1.Visible = true;
            this.colManufacturerName1.VisibleIndex = 1;
            this.colManufacturerName1.Width = 101;
            // 
            // colQuantity1
            // 
            this.colQuantity1.Caption = "Количество";
            this.colQuantity1.FieldName = "Quantity";
            this.colQuantity1.Name = "colQuantity1";
            this.colQuantity1.Visible = true;
            this.colQuantity1.VisibleIndex = 2;
            this.colQuantity1.Width = 101;
            // 
            // colPriceRetailNDS
            // 
            this.colPriceRetailNDS.Caption = "Цена";
            this.colPriceRetailNDS.FieldName = "PriceRetailNDS";
            this.colPriceRetailNDS.Name = "colPriceRetailNDS";
            this.colPriceRetailNDS.Visible = true;
            this.colPriceRetailNDS.VisibleIndex = 4;
            this.colPriceRetailNDS.Width = 104;
            // 
            // colRetailSum
            // 
            this.colRetailSum.Caption = "Сумма";
            this.colRetailSum.FieldName = "RetailSum";
            this.colRetailSum.Name = "colRetailSum";
            this.colRetailSum.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colRetailSum.Visible = true;
            this.colRetailSum.VisibleIndex = 5;
            this.colRetailSum.Width = 101;
            // 
            // colUseByDate1
            // 
            this.colUseByDate1.Caption = "Срок";
            this.colUseByDate1.FieldName = "UseByDate";
            this.colUseByDate1.Name = "colUseByDate1";
            this.colUseByDate1.Visible = true;
            this.colUseByDate1.VisibleIndex = 3;
            this.colUseByDate1.Width = 101;
            // 
            // invoiceMasterBindingSourceView
            // 
            this.invoiceMasterBindingSourceView.DataMember = "InvoiceMaster";
            this.invoiceMasterBindingSourceView.DataSource = this.mDataSet;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btPayMenu});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(191, 26);
            // 
            // btPayMenu
            // 
            this.btPayMenu.Name = "btPayMenu";
            this.btPayMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.btPayMenu.Size = new System.Drawing.Size(190, 22);
            this.btPayMenu.Text = "Оплата";
            this.btPayMenu.Click += new System.EventHandler(this.btPay_Click);
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // InvoicePrintMar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 552);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(640, 540);
            this.Name = "InvoicePrintMar";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расходный документ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InvoicePrintMar_FormClosing);
            this.Load += new System.EventHandler(this.InvoicePrintMar_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridRem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remainsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInvRem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDet)).EndInit();
            this.contextMenuEditing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInvDet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CashbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceMasterBindingSourceView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl gridRem;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewInvRem;
        private DevExpress.XtraGrid.GridControl gridDet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewInvDet;
        private MDataSet mDataSet;
        private System.Windows.Forms.BindingSource remainsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colDocDate;
        private DevExpress.XtraGrid.Columns.GridColumn colSeries;
        private DevExpress.XtraGrid.Columns.GridColumn colUseByDate;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantityRemains;
        private DevExpress.XtraGrid.Columns.GridColumn colDateLastModif;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorLastModif;
        private System.Windows.Forms.BindingSource invoiceMasterBindingSource;
        private System.Windows.Forms.BindingSource invoiceDetailBindingSource;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.BindingSource CashbindingSource;
        private System.Windows.Forms.BindingSource invoiceMasterBindingSourceView;
        private DevExpress.XtraGrid.Columns.GridColumn colPricePurchase;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity1;
        private DevExpress.XtraGrid.Columns.GridColumn colRetailSum;
        private System.Windows.Forms.Button btPay;
        private System.Windows.Forms.Button btPrintCheck;
        private System.Windows.Forms.ContextMenuStrip contextMenuEditing;
        private System.Windows.Forms.ToolStripMenuItem btDelete;
        private System.Windows.Forms.ToolStripButton btReturnDoc;
        private DevExpress.XtraGrid.Columns.GridColumn colManufacturerName;
        private DevExpress.XtraGrid.Columns.GridColumn colCountryName;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName1;
        private DevExpress.XtraGrid.Columns.GridColumn colManufacturerName1;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceRetailNDS;
        private DevExpress.XtraGrid.Columns.GridColumn colUseByDate1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btPayMenu;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private RetailTradeClient.MDataSetTableAdapters.ProductTableAdapter productTableAdapter;

    }
}