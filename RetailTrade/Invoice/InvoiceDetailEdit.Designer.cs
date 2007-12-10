namespace RetailTrade.Invoice
{
    partial class InvoiceDetailEdit
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gridRemains = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStripRemains = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btFieldRem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemainsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mDataSet = new RetailTrade.MDataSet();
            this.gridViewRemainsInvDetEdt = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManufacturerName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeries = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUseByDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPricePurchase = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantityRemains = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReceiptDetailRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateLastModif1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorLastModif1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridInvoiceDetail = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStripInvoice = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.btDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btField = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewinvDet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManufacturerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPricePurchase1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriceRetailNDS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorCreate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorLastModif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateLastModif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLocalReceiptDetailRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCalcSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExtraPercent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.invoiceMasterBindingSourceView = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colExtra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRemains)).BeginInit();
            this.contextMenuStripRemains.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RemainsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRemainsInvDetEdt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridInvoiceDetail)).BeginInit();
            this.contextMenuStripInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewinvDet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceMasterBindingSourceView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceMasterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(680, 535);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(672, 506);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Накладная";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 2);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gridRemains);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridInvoiceDetail);
            this.splitContainer1.Size = new System.Drawing.Size(666, 502);
            this.splitContainer1.SplitterDistance = 273;
            this.splitContainer1.TabIndex = 0;
            // 
            // gridRemains
            // 
            this.gridRemains.ContextMenuStrip = this.contextMenuStripRemains;
            this.gridRemains.DataSource = this.RemainsBindingSource;
            this.gridRemains.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            this.gridRemains.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridRemains.EmbeddedNavigator.Name = "";
            this.gridRemains.Location = new System.Drawing.Point(0, 0);
            this.gridRemains.MainView = this.gridViewRemainsInvDetEdt;
            this.gridRemains.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridRemains.Name = "gridRemains";
            this.gridRemains.Size = new System.Drawing.Size(666, 273);
            this.gridRemains.TabIndex = 0;
            this.gridRemains.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRemainsInvDetEdt});
            this.gridRemains.DoubleClick += new System.EventHandler(this.btAdd_Click);
            this.gridRemains.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridRemains_KeyDown);
            // 
            // contextMenuStripRemains
            // 
            this.contextMenuStripRemains.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btFieldRem});
            this.contextMenuStripRemains.Name = "contextMenuStripRemains";
            this.contextMenuStripRemains.Size = new System.Drawing.Size(209, 26);
            // 
            // btFieldRem
            // 
            this.btFieldRem.Name = "btFieldRem";
            this.btFieldRem.Size = new System.Drawing.Size(208, 22);
            this.btFieldRem.Text = "Настройка полей";
            this.btFieldRem.Click += new System.EventHandler(this.btFieldRem_Click);
            // 
            // RemainsBindingSource
            // 
            this.RemainsBindingSource.DataMember = "Remains";
            this.RemainsBindingSource.DataSource = this.mDataSet;
            // 
            // mDataSet
            // 
            this.mDataSet.DataSetName = "MDataSet";
            this.mDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewRemainsInvDetEdt
            // 
            this.gridViewRemainsInvDetEdt.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductName1,
            this.colManufacturerName1,
            this.colSeries,
            this.colUseByDate,
            this.colPricePurchase,
            this.colQuantityRemains,
            this.colReceiptDetailRef,
            this.colDocDate,
            this.colDateLastModif1,
            this.colAuthorLastModif1,
            this.colProductRef});
            this.gridViewRemainsInvDetEdt.GridControl = this.gridRemains;
            this.gridViewRemainsInvDetEdt.Name = "gridViewRemainsInvDetEdt";
            this.gridViewRemainsInvDetEdt.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridViewRemainsInvDetEdt.OptionsBehavior.Editable = false;
            this.gridViewRemainsInvDetEdt.OptionsFilter.UseNewCustomFilterDialog = true;
            this.gridViewRemainsInvDetEdt.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewRemainsInvDetEdt.OptionsView.ShowAutoFilterRow = true;
            // 
            // colProductName1
            // 
            this.colProductName1.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colProductName1.AppearanceCell.Options.UseFont = true;
            this.colProductName1.Caption = "Наименование";
            this.colProductName1.FieldName = "ProductName";
            this.colProductName1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colProductName1.Name = "colProductName1";
            this.colProductName1.OptionsFilter.AllowFilter = false;
            this.colProductName1.Visible = true;
            this.colProductName1.VisibleIndex = 0;
            this.colProductName1.Width = 135;
            // 
            // colManufacturerName1
            // 
            this.colManufacturerName1.Caption = "Изготовитель";
            this.colManufacturerName1.FieldName = "ManufacturerName";
            this.colManufacturerName1.Name = "colManufacturerName1";
            this.colManufacturerName1.Visible = true;
            this.colManufacturerName1.VisibleIndex = 1;
            this.colManufacturerName1.Width = 132;
            // 
            // colSeries
            // 
            this.colSeries.Caption = "Серия";
            this.colSeries.FieldName = "Series";
            this.colSeries.Name = "colSeries";
            this.colSeries.OptionsFilter.AllowFilter = false;
            this.colSeries.Visible = true;
            this.colSeries.VisibleIndex = 2;
            this.colSeries.Width = 62;
            // 
            // colUseByDate
            // 
            this.colUseByDate.Caption = "Срок";
            this.colUseByDate.DisplayFormat.FormatString = "MMM.yyyy";
            this.colUseByDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colUseByDate.FieldName = "UseByDate";
            this.colUseByDate.Name = "colUseByDate";
            this.colUseByDate.OptionsFilter.AllowFilter = false;
            this.colUseByDate.Visible = true;
            this.colUseByDate.VisibleIndex = 3;
            this.colUseByDate.Width = 62;
            // 
            // colPricePurchase
            // 
            this.colPricePurchase.Caption = "Цена закупочная";
            this.colPricePurchase.DisplayFormat.FormatString = "##.#####";
            this.colPricePurchase.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPricePurchase.FieldName = "PricePurchase";
            this.colPricePurchase.Name = "colPricePurchase";
            this.colPricePurchase.OptionsColumn.AllowEdit = false;
            this.colPricePurchase.OptionsColumn.ReadOnly = true;
            this.colPricePurchase.OptionsFilter.AllowFilter = false;
            this.colPricePurchase.Visible = true;
            this.colPricePurchase.VisibleIndex = 4;
            this.colPricePurchase.Width = 62;
            // 
            // colQuantityRemains
            // 
            this.colQuantityRemains.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colQuantityRemains.AppearanceCell.Options.UseFont = true;
            this.colQuantityRemains.Caption = "Остаток";
            this.colQuantityRemains.DisplayFormat.FormatString = "#.###";
            this.colQuantityRemains.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQuantityRemains.FieldName = "QuantityRemains";
            this.colQuantityRemains.Name = "colQuantityRemains";
            this.colQuantityRemains.OptionsColumn.AllowEdit = false;
            this.colQuantityRemains.OptionsFilter.AllowFilter = false;
            this.colQuantityRemains.Visible = true;
            this.colQuantityRemains.VisibleIndex = 5;
            this.colQuantityRemains.Width = 62;
            // 
            // colReceiptDetailRef
            // 
            this.colReceiptDetailRef.Caption = "ReceiptDetailRef";
            this.colReceiptDetailRef.FieldName = "ReceiptDetailRef";
            this.colReceiptDetailRef.Name = "colReceiptDetailRef";
            this.colReceiptDetailRef.OptionsColumn.ShowInCustomizationForm = false;
            this.colReceiptDetailRef.Width = 97;
            // 
            // colDocDate
            // 
            this.colDocDate.Caption = "Дата прихода";
            this.colDocDate.FieldName = "DocDate";
            this.colDocDate.Name = "colDocDate";
            this.colDocDate.Visible = true;
            this.colDocDate.VisibleIndex = 6;
            this.colDocDate.Width = 82;
            // 
            // colDateLastModif1
            // 
            this.colDateLastModif1.Caption = "Изменен";
            this.colDateLastModif1.FieldName = "DateLastModif";
            this.colDateLastModif1.Name = "colDateLastModif1";
            this.colDateLastModif1.OptionsColumn.ReadOnly = true;
            // 
            // colAuthorLastModif1
            // 
            this.colAuthorLastModif1.Caption = "Редактор";
            this.colAuthorLastModif1.FieldName = "AuthorLastModif";
            this.colAuthorLastModif1.Name = "colAuthorLastModif1";
            this.colAuthorLastModif1.OptionsColumn.AllowEdit = false;
            this.colAuthorLastModif1.OptionsColumn.ReadOnly = true;
            // 
            // colProductRef
            // 
            this.colProductRef.Caption = "Код";
            this.colProductRef.FieldName = "ProductRef";
            this.colProductRef.Name = "colProductRef";
            this.colProductRef.OptionsColumn.AllowEdit = false;
            this.colProductRef.OptionsColumn.ReadOnly = true;
            this.colProductRef.OptionsFilter.AllowFilter = false;
            this.colProductRef.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Like;
            this.colProductRef.Width = 73;
            // 
            // gridInvoiceDetail
            // 
            this.gridInvoiceDetail.ContextMenuStrip = this.contextMenuStripInvoice;
            this.gridInvoiceDetail.DataSource = this.invoiceDetailBindingSource;
            this.gridInvoiceDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            this.gridInvoiceDetail.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridInvoiceDetail.EmbeddedNavigator.Name = "";
            this.gridInvoiceDetail.Location = new System.Drawing.Point(0, 0);
            this.gridInvoiceDetail.MainView = this.gridViewinvDet;
            this.gridInvoiceDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridInvoiceDetail.Name = "gridInvoiceDetail";
            this.gridInvoiceDetail.Size = new System.Drawing.Size(666, 225);
            this.gridInvoiceDetail.TabIndex = 0;
            this.gridInvoiceDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewinvDet});
            // 
            // contextMenuStripInvoice
            // 
            this.contextMenuStripInvoice.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btEdit,
            this.btDelete,
            this.btField});
            this.contextMenuStripInvoice.Name = "contextMenuStrip";
            this.contextMenuStripInvoice.Size = new System.Drawing.Size(209, 70);
            // 
            // btEdit
            // 
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(208, 22);
            this.btEdit.Text = "Изменить";
            this.btEdit.Click += new System.EventHandler(this.gridViewinvDet_DoubleClick);
            // 
            // btDelete
            // 
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(208, 22);
            this.btDelete.Text = "Удалить строку";
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btField
            // 
            this.btField.Name = "btField";
            this.btField.Size = new System.Drawing.Size(208, 22);
            this.btField.Text = "Настройка полей";
            this.btField.Click += new System.EventHandler(this.btField_Click);
            // 
            // invoiceDetailBindingSource
            // 
            this.invoiceDetailBindingSource.DataMember = "InvoiceDetail";
            this.invoiceDetailBindingSource.DataSource = this.mDataSet;
            // 
            // gridViewinvDet
            // 
            this.gridViewinvDet.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductName,
            this.colManufacturerName,
            this.colPricePurchase1,
            this.colQuantity,
            this.colPriceRetailNDS,
            this.colNote,
            this.colAuthorCreate,
            this.colAuthorLastModif,
            this.colDateCreate,
            this.colDateLastModif,
            this.colLocalReceiptDetailRef,
            this.colCalcSum,
            this.colExtraPercent,
            this.colExtra});
            this.gridViewinvDet.GridControl = this.gridInvoiceDetail;
            this.gridViewinvDet.Name = "gridViewinvDet";
            this.gridViewinvDet.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridViewinvDet.OptionsDetail.EnableMasterViewMode = false;
            this.gridViewinvDet.OptionsView.ShowDetailButtons = false;
            this.gridViewinvDet.OptionsView.ShowFooter = true;
            this.gridViewinvDet.DoubleClick += new System.EventHandler(this.gridViewinvDet_DoubleClick);
            this.gridViewinvDet.InvalidValueException += new DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(this.gridViewinvDet_InvalidValueException);
            this.gridViewinvDet.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gridViewinvDet_InvalidRowException);
            // 
            // colProductName
            // 
            this.colProductName.Caption = "Наименование";
            this.colProductName.FieldName = "ProductName";
            this.colProductName.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colProductName.Name = "colProductName";
            this.colProductName.SummaryItem.DisplayFormat = "{Строк :{0}}";
            this.colProductName.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 0;
            this.colProductName.Width = 139;
            // 
            // colManufacturerName
            // 
            this.colManufacturerName.Caption = "Изготовитель";
            this.colManufacturerName.FieldName = "ManufacturerName";
            this.colManufacturerName.Name = "colManufacturerName";
            this.colManufacturerName.OptionsColumn.AllowEdit = false;
            this.colManufacturerName.OptionsColumn.AllowFocus = false;
            this.colManufacturerName.OptionsFilter.AllowFilter = false;
            this.colManufacturerName.Visible = true;
            this.colManufacturerName.VisibleIndex = 1;
            this.colManufacturerName.Width = 137;
            // 
            // colPricePurchase1
            // 
            this.colPricePurchase1.Caption = "Закупочная";
            this.colPricePurchase1.FieldName = "PricePurchase";
            this.colPricePurchase1.Name = "colPricePurchase1";
            this.colPricePurchase1.OptionsColumn.AllowEdit = false;
            this.colPricePurchase1.OptionsColumn.AllowFocus = false;
            this.colPricePurchase1.OptionsColumn.ReadOnly = true;
            this.colPricePurchase1.OptionsFilter.AllowAutoFilter = false;
            this.colPricePurchase1.OptionsFilter.AllowFilter = false;
            this.colPricePurchase1.Visible = true;
            this.colPricePurchase1.VisibleIndex = 2;
            this.colPricePurchase1.Width = 90;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Кол-во";
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.OptionsFilter.AllowFilter = false;
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 3;
            this.colQuantity.Width = 137;
            // 
            // colPriceRetailNDS
            // 
            this.colPriceRetailNDS.Caption = "Цена";
            this.colPriceRetailNDS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPriceRetailNDS.FieldName = "PriceRetailNDS";
            this.colPriceRetailNDS.Name = "colPriceRetailNDS";
            this.colPriceRetailNDS.OptionsFilter.AllowFilter = false;
            this.colPriceRetailNDS.Visible = true;
            this.colPriceRetailNDS.VisibleIndex = 4;
            this.colPriceRetailNDS.Width = 149;
            // 
            // colNote
            // 
            this.colNote.Caption = "Примечание";
            this.colNote.FieldName = "Note";
            this.colNote.Name = "colNote";
            // 
            // colAuthorCreate
            // 
            this.colAuthorCreate.Caption = "Автор";
            this.colAuthorCreate.FieldName = "AuthorCreate";
            this.colAuthorCreate.Name = "colAuthorCreate";
            this.colAuthorCreate.OptionsColumn.AllowEdit = false;
            this.colAuthorCreate.OptionsColumn.AllowFocus = false;
            this.colAuthorCreate.OptionsColumn.ReadOnly = true;
            this.colAuthorCreate.OptionsFilter.AllowAutoFilter = false;
            this.colAuthorCreate.OptionsFilter.AllowFilter = false;
            // 
            // colAuthorLastModif
            // 
            this.colAuthorLastModif.Caption = "Редактор";
            this.colAuthorLastModif.FieldName = "AuthorLastModif";
            this.colAuthorLastModif.Name = "colAuthorLastModif";
            this.colAuthorLastModif.OptionsColumn.AllowEdit = false;
            this.colAuthorLastModif.OptionsColumn.AllowFocus = false;
            this.colAuthorLastModif.OptionsColumn.ReadOnly = true;
            this.colAuthorLastModif.OptionsFilter.AllowAutoFilter = false;
            this.colAuthorLastModif.OptionsFilter.AllowFilter = false;
            // 
            // colDateCreate
            // 
            this.colDateCreate.Caption = "Создан";
            this.colDateCreate.FieldName = "DateCreate";
            this.colDateCreate.Name = "colDateCreate";
            this.colDateCreate.OptionsColumn.AllowEdit = false;
            this.colDateCreate.OptionsColumn.AllowFocus = false;
            this.colDateCreate.OptionsColumn.ReadOnly = true;
            // 
            // colDateLastModif
            // 
            this.colDateLastModif.Caption = "Изменен";
            this.colDateLastModif.FieldName = "DateLastModif";
            this.colDateLastModif.Name = "colDateLastModif";
            this.colDateLastModif.OptionsColumn.AllowEdit = false;
            this.colDateLastModif.OptionsColumn.AllowFocus = false;
            this.colDateLastModif.OptionsColumn.ReadOnly = true;
            this.colDateLastModif.OptionsFilter.AllowAutoFilter = false;
            this.colDateLastModif.OptionsFilter.AllowFilter = false;
            // 
            // colLocalReceiptDetailRef
            // 
            this.colLocalReceiptDetailRef.Caption = "LocalReceiptDetailRef";
            this.colLocalReceiptDetailRef.FieldName = "LocalReceiptDetailRef";
            this.colLocalReceiptDetailRef.Name = "colLocalReceiptDetailRef";
            this.colLocalReceiptDetailRef.OptionsColumn.AllowEdit = false;
            this.colLocalReceiptDetailRef.OptionsColumn.AllowFocus = false;
            this.colLocalReceiptDetailRef.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colCalcSum
            // 
            this.colCalcSum.Caption = "Cумма";
            this.colCalcSum.FieldName = "CalcSum";
            this.colCalcSum.Name = "colCalcSum";
            this.colCalcSum.OptionsColumn.AllowEdit = false;
            this.colCalcSum.OptionsColumn.AllowFocus = false;
            this.colCalcSum.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCalcSum.OptionsFilter.AllowFilter = false;
            this.colCalcSum.SummaryItem.DisplayFormat = "{0:#0.00}";
            this.colCalcSum.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colCalcSum.Visible = true;
            this.colCalcSum.VisibleIndex = 5;
            // 
            // colExtraPercent
            // 
            this.colExtraPercent.Caption = "% наценки";
            this.colExtraPercent.FieldName = "ExtraPercent";
            this.colExtraPercent.Name = "colExtraPercent";
            this.colExtraPercent.OptionsColumn.AllowEdit = false;
            this.colExtraPercent.OptionsColumn.AllowFocus = false;
            this.colExtraPercent.Visible = true;
            this.colExtraPercent.VisibleIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(672, 506);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Цены";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(672, 506);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Заказы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // invoiceMasterBindingSourceView
            // 
            this.invoiceMasterBindingSourceView.DataMember = "InvoiceMaster";
            this.invoiceMasterBindingSourceView.DataSource = this.mDataSet;
            // 
            // invoiceMasterBindingSource
            // 
            this.invoiceMasterBindingSource.DataMember = "InvoiceMaster";
            this.invoiceMasterBindingSource.DataSource = this.mDataSet;
            // 
            // colExtra
            // 
            this.colExtra.Caption = "Наценка";
            this.colExtra.FieldName = "Extra";
            this.colExtra.Name = "colExtra";
            this.colExtra.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colExtra.Visible = true;
            this.colExtra.VisibleIndex = 7;
            // 
            // InvoiceDetailEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InvoiceDetailEdit";
            this.Size = new System.Drawing.Size(680, 535);
            this.Load += new System.EventHandler(this.InvoiceDetailEdit_Load);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.InvoiceDetailEdit_Validating);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridRemains)).EndInit();
            this.contextMenuStripRemains.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RemainsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRemainsInvDetEdt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridInvoiceDetail)).EndInit();
            this.contextMenuStripInvoice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewinvDet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceMasterBindingSourceView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceMasterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabPage tabPage2;
        private DevExpress.XtraGrid.GridControl gridRemains;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRemainsInvDetEdt;
        private DevExpress.XtraGrid.GridControl gridInvoiceDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewinvDet;
        private System.Windows.Forms.BindingSource RemainsBindingSource;
        private MDataSet mDataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colProductRef;
        private DevExpress.XtraGrid.Columns.GridColumn colSeries;
        private DevExpress.XtraGrid.Columns.GridColumn colUseByDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPricePurchase;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantityRemains;
        private DevExpress.XtraGrid.Columns.GridColumn colReceiptDetailRef;
        private System.Windows.Forms.BindingSource invoiceDetailBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colPricePurchase1;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceRetailNDS;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorCreate;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorLastModif;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreate;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraGrid.Columns.GridColumn colDateLastModif;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.BindingSource invoiceMasterBindingSourceView;
        private System.Windows.Forms.BindingSource invoiceMasterBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colLocalReceiptDetailRef;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colManufacturerName;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName1;
        private DevExpress.XtraGrid.Columns.GridColumn colManufacturerName1;
        private DevExpress.XtraGrid.Columns.GridColumn colDocDate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripInvoice;
        private System.Windows.Forms.ToolStripMenuItem btDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colCalcSum;
        private DevExpress.XtraGrid.Columns.GridColumn colDateLastModif1;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorLastModif1;
        private System.Windows.Forms.ToolStripMenuItem btEdit;
        private System.Windows.Forms.ToolStripMenuItem btField;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripRemains;
        private System.Windows.Forms.ToolStripMenuItem btFieldRem;
        private DevExpress.XtraGrid.Columns.GridColumn colExtraPercent;
        private DevExpress.XtraGrid.Columns.GridColumn colExtra;
    }
}
