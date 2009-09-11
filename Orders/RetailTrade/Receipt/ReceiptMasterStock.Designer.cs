namespace RetailTradeOrders.Receipt
{
    partial class ReceiptMasterStock
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiptMasterStock));
            this.gridViewRecieptDetailStock = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManufacturerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeries = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUseByDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorCreate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorLastModif1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateLastModif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesSum1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesNDS1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.receiptMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mDataSet = new RetailTradeOrders.MDataSet();
            this.gridViewMasterStock = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsReadOnly = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorCreate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorLastModif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesNDS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridViewRecInvDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTradePupletName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumber1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridViewRecDetPrices = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOrganizationName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPricePurchase1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btClose = new System.Windows.Forms.ToolStripButton();
            this.btMakeNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.PariodsComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.btField = new System.Windows.Forms.ToolStripMenuItem();
            this.btPeriod = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRecieptDetailStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMasterStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRecInvDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRecDetPrices)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridViewRecieptDetailStock
            // 
            this.gridViewRecieptDetailStock.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductName,
            this.colManufacturerName,
            this.colQuantity,
            this.colSeries,
            this.colUseByDate,
            this.colNote1,
            this.colAuthorCreate1,
            this.colAuthorLastModif1,
            this.colDateCreate1,
            this.colDateLastModif,
            this.colSalesPrice,
            this.colSalesSum1,
            this.colSalesNDS1});
            this.gridViewRecieptDetailStock.GridControl = this.grid;
            this.gridViewRecieptDetailStock.Name = "gridViewRecieptDetailStock";
            this.gridViewRecieptDetailStock.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridViewRecieptDetailStock.OptionsBehavior.Editable = false;
            this.gridViewRecieptDetailStock.OptionsDetail.AllowExpandEmptyDetails = true;
            this.gridViewRecieptDetailStock.OptionsDetail.AllowOnlyOneMasterRowExpanded = true;
            this.gridViewRecieptDetailStock.OptionsDetail.SmartDetailExpandButton = false;
            this.gridViewRecieptDetailStock.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colProductName, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewRecieptDetailStock.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridViewRecieptDetailStock_CustomDrawCell);
            this.gridViewRecieptDetailStock.Layout += new System.EventHandler(this.gridViewMasterStock_Layout);
            // 
            // colProductName
            // 
            this.colProductName.Caption = "Наименование";
            this.colProductName.FieldName = "ProductName";
            this.colProductName.Name = "colProductName";
            this.colProductName.OptionsColumn.AllowEdit = false;
            this.colProductName.OptionsColumn.AllowFocus = false;
            this.colProductName.OptionsColumn.ReadOnly = true;
            this.colProductName.OptionsFilter.AllowAutoFilter = false;
            this.colProductName.OptionsFilter.AllowFilter = false;
            this.colProductName.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText;
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 0;
            // 
            // colManufacturerName
            // 
            this.colManufacturerName.Caption = "Производитель";
            this.colManufacturerName.FieldName = "ManufacturerName";
            this.colManufacturerName.Name = "colManufacturerName";
            this.colManufacturerName.OptionsColumn.AllowEdit = false;
            this.colManufacturerName.OptionsColumn.AllowFocus = false;
            this.colManufacturerName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colManufacturerName.OptionsFilter.AllowAutoFilter = false;
            this.colManufacturerName.OptionsFilter.AllowFilter = false;
            this.colManufacturerName.Visible = true;
            this.colManufacturerName.VisibleIndex = 1;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Кол-во";
            this.colQuantity.DisplayFormat.FormatString = "#.###";
            this.colQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 2;
            // 
            // colSeries
            // 
            this.colSeries.Caption = "Серия";
            this.colSeries.FieldName = "Series";
            this.colSeries.Name = "colSeries";
            // 
            // colUseByDate
            // 
            this.colUseByDate.Caption = "Срок";
            this.colUseByDate.FieldName = "UseByDate";
            this.colUseByDate.Name = "colUseByDate";
            // 
            // colNote1
            // 
            this.colNote1.Caption = "Примечание";
            this.colNote1.FieldName = "Note";
            this.colNote1.Name = "colNote1";
            // 
            // colAuthorCreate1
            // 
            this.colAuthorCreate1.Caption = "Автор";
            this.colAuthorCreate1.FieldName = "AuthorCreate";
            this.colAuthorCreate1.Name = "colAuthorCreate1";
            this.colAuthorCreate1.OptionsColumn.AllowEdit = false;
            this.colAuthorCreate1.OptionsColumn.AllowFocus = false;
            this.colAuthorCreate1.OptionsColumn.ReadOnly = true;
            this.colAuthorCreate1.OptionsFilter.AllowAutoFilter = false;
            this.colAuthorCreate1.OptionsFilter.AllowFilter = false;
            // 
            // colAuthorLastModif1
            // 
            this.colAuthorLastModif1.Caption = "Редактор";
            this.colAuthorLastModif1.FieldName = "AuthorLastModif";
            this.colAuthorLastModif1.Name = "colAuthorLastModif1";
            // 
            // colDateCreate1
            // 
            this.colDateCreate1.Caption = "Создан";
            this.colDateCreate1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDateCreate1.FieldName = "DateCreate";
            this.colDateCreate1.Name = "colDateCreate1";
            this.colDateCreate1.OptionsColumn.AllowEdit = false;
            this.colDateCreate1.OptionsColumn.AllowFocus = false;
            this.colDateCreate1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDateCreate1.OptionsColumn.ReadOnly = true;
            this.colDateCreate1.OptionsFilter.AllowAutoFilter = false;
            this.colDateCreate1.OptionsFilter.AllowFilter = false;
            // 
            // colDateLastModif
            // 
            this.colDateLastModif.Caption = "Изменен";
            this.colDateLastModif.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDateLastModif.FieldName = "DateLastModif";
            this.colDateLastModif.Name = "colDateLastModif";
            this.colDateLastModif.OptionsColumn.AllowEdit = false;
            this.colDateLastModif.OptionsColumn.AllowFocus = false;
            this.colDateLastModif.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDateLastModif.OptionsColumn.ReadOnly = true;
            this.colDateLastModif.OptionsFilter.AllowAutoFilter = false;
            this.colDateLastModif.OptionsFilter.AllowFilter = false;
            // 
            // colSalesPrice
            // 
            this.colSalesPrice.Caption = "Цена";
            this.colSalesPrice.FieldName = "SalesPrice";
            this.colSalesPrice.Name = "colSalesPrice";
            this.colSalesPrice.Visible = true;
            this.colSalesPrice.VisibleIndex = 3;
            // 
            // colSalesSum1
            // 
            this.colSalesSum1.Caption = "Сумма";
            this.colSalesSum1.FieldName = "SalesSum";
            this.colSalesSum1.Name = "colSalesSum1";
            this.colSalesSum1.Visible = true;
            this.colSalesSum1.VisibleIndex = 4;
            // 
            // colSalesNDS1
            // 
            this.colSalesNDS1.Caption = "в т.ч НДС";
            this.colSalesNDS1.FieldName = "SalesNDS";
            this.colSalesNDS1.Name = "colSalesNDS1";
            this.colSalesNDS1.Visible = true;
            this.colSalesNDS1.VisibleIndex = 5;
            // 
            // grid
            // 
            this.grid.DataSource = this.receiptMasterBindingSource;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            this.grid.EmbeddedNavigator.Name = "";
            gridLevelNode1.LevelTemplate = this.gridViewRecieptDetailStock;
            gridLevelNode1.RelationName = "FK_ReceiptDetail_ReceiptMaster";
            this.grid.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grid.Location = new System.Drawing.Point(0, 26);
            this.grid.MainView = this.gridViewMasterStock;
            this.grid.Name = "grid";
            this.grid.ShowOnlyPredefinedDetails = true;
            this.grid.Size = new System.Drawing.Size(781, 481);
            this.grid.TabIndex = 2;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMasterStock,
            this.gridViewRecInvDetail,
            this.gridViewRecDetPrices,
            this.gridViewRecieptDetailStock});
            // 
            // receiptMasterBindingSource
            // 
            this.receiptMasterBindingSource.DataMember = "ReceiptMaster";
            this.receiptMasterBindingSource.DataSource = this.mDataSet;
            // 
            // mDataSet
            // 
            this.mDataSet.DataSetName = "MDataSet";
            this.mDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewMasterStock
            // 
            this.gridViewMasterStock.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNumber,
            this.colDocDate,
            this.colNote,
            this.colIsReadOnly,
            this.colAuthorCreate,
            this.colAuthorLastModif,
            this.colDateCreate,
            this.colSalesNDS,
            this.colSalesSum});
            this.gridViewMasterStock.GridControl = this.grid;
            this.gridViewMasterStock.Name = "gridViewMasterStock";
            this.gridViewMasterStock.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridViewMasterStock.OptionsBehavior.Editable = false;
            this.gridViewMasterStock.OptionsDetail.AllowExpandEmptyDetails = true;
            this.gridViewMasterStock.OptionsDetail.AllowOnlyOneMasterRowExpanded = true;
            this.gridViewMasterStock.OptionsDetail.SmartDetailExpand = false;
            this.gridViewMasterStock.OptionsDetail.SmartDetailExpandButton = false;
            this.gridViewMasterStock.OptionsDetail.SmartDetailHeight = true;
            this.gridViewMasterStock.OptionsView.ShowChildrenInGroupPanel = true;
            this.gridViewMasterStock.OptionsView.ShowFooter = true;
            this.gridViewMasterStock.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridViewMasterStock_CustomDrawCell);
            this.gridViewMasterStock.MasterRowGetChildList += new DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(this.gridViewMasterStock_MasterRowGetChildList);
            this.gridViewMasterStock.Layout += new System.EventHandler(this.gridViewMasterStock_Layout);
            // 
            // colNumber
            // 
            this.colNumber.Caption = "№";
            this.colNumber.FieldName = "Number";
            this.colNumber.Name = "colNumber";
            this.colNumber.Visible = true;
            this.colNumber.VisibleIndex = 0;
            // 
            // colDocDate
            // 
            this.colDocDate.Caption = "Дата";
            this.colDocDate.FieldName = "DocDate";
            this.colDocDate.Name = "colDocDate";
            this.colDocDate.Visible = true;
            this.colDocDate.VisibleIndex = 2;
            // 
            // colNote
            // 
            this.colNote.Caption = "Примечание";
            this.colNote.FieldName = "Note";
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 1;
            // 
            // colIsReadOnly
            // 
            this.colIsReadOnly.Caption = "Закрыт";
            this.colIsReadOnly.FieldName = "IsReadOnly";
            this.colIsReadOnly.Name = "colIsReadOnly";
            // 
            // colAuthorCreate
            // 
            this.colAuthorCreate.Caption = "Автор";
            this.colAuthorCreate.FieldName = "AuthorCreate";
            this.colAuthorCreate.Name = "colAuthorCreate";
            this.colAuthorCreate.OptionsColumn.AllowEdit = false;
            this.colAuthorCreate.OptionsColumn.AllowFocus = false;
            this.colAuthorCreate.OptionsColumn.ReadOnly = true;
            // 
            // colAuthorLastModif
            // 
            this.colAuthorLastModif.Caption = "Редактор";
            this.colAuthorLastModif.FieldName = "AuthorLastModif";
            this.colAuthorLastModif.Name = "colAuthorLastModif";
            this.colAuthorLastModif.OptionsColumn.AllowEdit = false;
            this.colAuthorLastModif.OptionsColumn.AllowFocus = false;
            this.colAuthorLastModif.OptionsColumn.ReadOnly = true;
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
            // colSalesNDS
            // 
            this.colSalesNDS.Caption = "в т.ч НДС";
            this.colSalesNDS.FieldName = "SalesNDS";
            this.colSalesNDS.Name = "colSalesNDS";
            this.colSalesNDS.Visible = true;
            this.colSalesNDS.VisibleIndex = 4;
            // 
            // colSalesSum
            // 
            this.colSalesSum.Caption = "Сумма";
            this.colSalesSum.FieldName = "SalesSum";
            this.colSalesSum.Name = "colSalesSum";
            this.colSalesSum.Visible = true;
            this.colSalesSum.VisibleIndex = 3;
            // 
            // gridViewRecInvDetail
            // 
            this.gridViewRecInvDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTradePupletName,
            this.colNumber1,
            this.colDate,
            this.colQuantity1,
            this.colNote2});
            this.gridViewRecInvDetail.GridControl = this.grid;
            this.gridViewRecInvDetail.Name = "gridViewRecInvDetail";
            this.gridViewRecInvDetail.OptionsBehavior.Editable = false;
            this.gridViewRecInvDetail.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewRecInvDetail.ViewCaption = "Продажи";
            this.gridViewRecInvDetail.Layout += new System.EventHandler(this.gridViewMasterStock_Layout);
            // 
            // colTradePupletName
            // 
            this.colTradePupletName.Caption = "Торговая точка";
            this.colTradePupletName.FieldName = "TradePupletName";
            this.colTradePupletName.Name = "colTradePupletName";
            this.colTradePupletName.Visible = true;
            this.colTradePupletName.VisibleIndex = 0;
            this.colTradePupletName.Width = 211;
            // 
            // colNumber1
            // 
            this.colNumber1.Caption = "№";
            this.colNumber1.FieldName = "Number";
            this.colNumber1.Name = "colNumber1";
            this.colNumber1.Visible = true;
            this.colNumber1.VisibleIndex = 1;
            this.colNumber1.Width = 68;
            // 
            // colDate
            // 
            this.colDate.Caption = "Дата";
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 2;
            this.colDate.Width = 127;
            // 
            // colQuantity1
            // 
            this.colQuantity1.Caption = "Кол-во";
            this.colQuantity1.DisplayFormat.FormatString = "#.###";
            this.colQuantity1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQuantity1.FieldName = "Quantity";
            this.colQuantity1.Name = "colQuantity1";
            this.colQuantity1.Visible = true;
            this.colQuantity1.VisibleIndex = 3;
            this.colQuantity1.Width = 127;
            // 
            // colNote2
            // 
            this.colNote2.Caption = "Примечание";
            this.colNote2.FieldName = "Note";
            this.colNote2.Name = "colNote2";
            // 
            // gridViewRecDetPrices
            // 
            this.gridViewRecDetPrices.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOrganizationName1,
            this.colDate1,
            this.colPricePurchase1});
            this.gridViewRecDetPrices.GridControl = this.grid;
            this.gridViewRecDetPrices.Name = "gridViewRecDetPrices";
            this.gridViewRecDetPrices.OptionsBehavior.Editable = false;
            this.gridViewRecDetPrices.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewRecDetPrices.OptionsView.ShowChildrenInGroupPanel = true;
            this.gridViewRecDetPrices.ViewCaption = "Цены";
            this.gridViewRecDetPrices.Layout += new System.EventHandler(this.gridViewMasterStock_Layout);
            // 
            // colOrganizationName1
            // 
            this.colOrganizationName1.Caption = "Поставщик";
            this.colOrganizationName1.FieldName = "OrganizationName";
            this.colOrganizationName1.Name = "colOrganizationName1";
            this.colOrganizationName1.Visible = true;
            this.colOrganizationName1.VisibleIndex = 0;
            // 
            // colDate1
            // 
            this.colDate1.Caption = "Дата";
            this.colDate1.FieldName = "Date";
            this.colDate1.Name = "colDate1";
            this.colDate1.Visible = true;
            this.colDate1.VisibleIndex = 1;
            // 
            // colPricePurchase1
            // 
            this.colPricePurchase1.Caption = "Цена";
            this.colPricePurchase1.FieldName = "PricePurchase";
            this.colPricePurchase1.Name = "colPricePurchase1";
            this.colPricePurchase1.Visible = true;
            this.colPricePurchase1.VisibleIndex = 2;
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 507);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(781, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btClose,
            this.btMakeNew,
            this.toolStripSeparator1,
            this.PariodsComboBox,
            this.toolStripSplitButton1,
            this.btPeriod});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(781, 26);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btClose
            // 
            this.btClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btClose.Image = global::RetailTradeOrders.Properties.Resources.delete2;
            this.btClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(23, 23);
            this.btClose.Text = "x";
            this.btClose.ToolTipText = "Закрыть";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btMakeNew
            // 
            this.btMakeNew.Image = ((System.Drawing.Image)(resources.GetObject("btMakeNew.Image")));
            this.btMakeNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btMakeNew.Name = "btMakeNew";
            this.btMakeNew.Size = new System.Drawing.Size(148, 23);
            this.btMakeNew.Text = "Убрать со склада";
            this.btMakeNew.Visible = false;
            this.btMakeNew.Click += new System.EventHandler(this.btMakeNew_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 26);
            // 
            // PariodsComboBox
            // 
            this.PariodsComboBox.CausesValidation = false;
            this.PariodsComboBox.Name = "PariodsComboBox";
            this.PariodsComboBox.Size = new System.Drawing.Size(170, 26);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btField});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(16, 23);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // btField
            // 
            this.btField.Name = "btField";
            this.btField.Size = new System.Drawing.Size(208, 22);
            this.btField.Text = "Настройка полей";
            this.btField.Click += new System.EventHandler(this.btField_Click);
            // 
            // btPeriod
            // 
            this.btPeriod.Image = global::RetailTradeOrders.Properties.Resources.refresh;
            this.btPeriod.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btPeriod.Name = "btPeriod";
            this.btPeriod.Size = new System.Drawing.Size(97, 23);
            this.btPeriod.Text = "За период";
            this.btPeriod.Click += new System.EventHandler(this.btPeriod_Click);
            // 
            // ReceiptMasterStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip);
            this.Name = "ReceiptMasterStock";
            this.Size = new System.Drawing.Size(781, 529);
            this.Load += new System.EventHandler(this.ReceiptMasterStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRecieptDetailStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMasterStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRecInvDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRecDetPrices)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.BindingSource receiptMasterBindingSource;
        private MDataSet mDataSet;
      
        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRecieptDetailStock;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRecInvDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRecDetPrices;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMasterStock;
        private DevExpress.XtraGrid.Columns.GridColumn colNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraGrid.Columns.GridColumn colDocDate;
        private DevExpress.XtraGrid.Columns.GridColumn colIsReadOnly;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorCreate;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorLastModif;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreate;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colManufacturerName;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colSeries;
        private DevExpress.XtraGrid.Columns.GridColumn colUseByDate;
        private DevExpress.XtraGrid.Columns.GridColumn colNote1;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorCreate1;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorLastModif1;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreate1;
        private DevExpress.XtraGrid.Columns.GridColumn colDateLastModif;
        private DevExpress.XtraGrid.Columns.GridColumn colTradePupletName;
        private DevExpress.XtraGrid.Columns.GridColumn colNumber1;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity1;
        private DevExpress.XtraGrid.Columns.GridColumn colNote2;
        private DevExpress.XtraGrid.Columns.GridColumn colOrganizationName1;
        private DevExpress.XtraGrid.Columns.GridColumn colDate1;
        private DevExpress.XtraGrid.Columns.GridColumn colPricePurchase1;

        private System.Windows.Forms.ToolStripButton btClose;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem btField;
        private System.Windows.Forms.ToolStripButton btPeriod;
        private System.Windows.Forms.ToolStripComboBox PariodsComboBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btMakeNew;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesSum1;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesNDS1;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesNDS;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesSum;
    }
}
