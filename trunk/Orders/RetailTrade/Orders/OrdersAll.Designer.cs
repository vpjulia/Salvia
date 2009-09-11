namespace RetailTradeOrders.Orders
{
    partial class OrdersAll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersAll));
            this.gridViewProdRem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colManufacturerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeries = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUseByDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPricePurchase = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantityRemains = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridProduct = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mDataSet = new RetailTradeOrders.MDataSet();
            this.gridViewProd = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPackingName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubstanceName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStorageConditionName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btAdd = new System.Windows.Forms.ToolStripButton();
            this.btProdAll = new System.Windows.Forms.ToolStripButton();
            this.btClose = new System.Windows.Forms.ToolStripButton();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new RetailTradeOrders.MDataSetTableAdapters.OrdersTableAdapter();
            this.productTableAdapter = new RetailTradeOrders.MDataSetTableAdapters.ProductTableAdapter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gridOrders = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btProdRep = new System.Windows.Forms.ToolStripMenuItem();
            this.gridViewOrders = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colProductRef1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colDateOrder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReserved = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantityNow = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorCreate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorLastModif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateLastModif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btRefreshOrders = new System.Windows.Forms.Button();
            this.dateTimeEdit = new System.Windows.Forms.DateTimePicker();
            this.btOrdersNew = new System.Windows.Forms.Button();
            this.btOrdersOld = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProdRem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProd)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridViewProdRem
            // 
            this.gridViewProdRem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colManufacturerName,
            this.colSeries,
            this.colUseByDate,
            this.colPricePurchase,
            this.colQuantityRemains});
            this.gridViewProdRem.GridControl = this.gridProduct;
            this.gridViewProdRem.Name = "gridViewProdRem";
            this.gridViewProdRem.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridViewProdRem.OptionsBehavior.Editable = false;
            this.gridViewProdRem.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewProdRem.OptionsView.ShowGroupPanel = false;
            // 
            // colManufacturerName
            // 
            this.colManufacturerName.Caption = "Изготовитель";
            this.colManufacturerName.FieldName = "ManufacturerName";
            this.colManufacturerName.Name = "colManufacturerName";
            this.colManufacturerName.Visible = true;
            this.colManufacturerName.VisibleIndex = 0;
            // 
            // colSeries
            // 
            this.colSeries.Caption = "Серия";
            this.colSeries.FieldName = "Series";
            this.colSeries.Name = "colSeries";
            this.colSeries.Visible = true;
            this.colSeries.VisibleIndex = 1;
            // 
            // colUseByDate
            // 
            this.colUseByDate.Caption = "Срок";
            this.colUseByDate.FieldName = "UseByDate";
            this.colUseByDate.Name = "colUseByDate";
            this.colUseByDate.Visible = true;
            this.colUseByDate.VisibleIndex = 2;
            // 
            // colPricePurchase
            // 
            this.colPricePurchase.Caption = "Цена";
            this.colPricePurchase.FieldName = "PricePurchase";
            this.colPricePurchase.Name = "colPricePurchase";
            this.colPricePurchase.Visible = true;
            this.colPricePurchase.VisibleIndex = 4;
            // 
            // colQuantityRemains
            // 
            this.colQuantityRemains.Caption = "Остаток";
            this.colQuantityRemains.FieldName = "QuantityRemains";
            this.colQuantityRemains.Name = "colQuantityRemains";
            this.colQuantityRemains.Visible = true;
            this.colQuantityRemains.VisibleIndex = 3;
            // 
            // gridProduct
            // 
            this.gridProduct.ContextMenuStrip = this.contextMenuStrip2;
            this.gridProduct.DataSource = this.productBindingSource;
            this.gridProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProduct.EmbeddedNavigator.Name = "";
            gridLevelNode1.LevelTemplate = this.gridViewProdRem;
            gridLevelNode1.RelationName = "Product_Remains";
            this.gridProduct.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridProduct.Location = new System.Drawing.Point(0, 0);
            this.gridProduct.MainView = this.gridViewProd;
            this.gridProduct.Name = "gridProduct";
            this.gridProduct.ShowOnlyPredefinedDetails = true;
            this.gridProduct.Size = new System.Drawing.Size(727, 230);
            this.gridProduct.TabIndex = 0;
            this.gridProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProd,
            this.gridViewProdRem});
            this.gridProduct.Click += new System.EventHandler(this.gridProduct_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btProduct});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(209, 26);
            // 
            // btProduct
            // 
            this.btProduct.Name = "btProduct";
            this.btProduct.Size = new System.Drawing.Size(208, 22);
            this.btProduct.Text = "Карточка товара";
            this.btProduct.Click += new System.EventHandler(this.btProduct_Click);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.mDataSet;
            this.productBindingSource.PositionChanged += new System.EventHandler(this.productBindingSource_PositionChanged);
            // 
            // mDataSet
            // 
            this.mDataSet.DataSetName = "MDataSet";
            this.mDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewProd
            // 
            this.gridViewProd.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colPackingName,
            this.colUnitName,
            this.colSubstanceName,
            this.colStorageConditionName});
            this.gridViewProd.GridControl = this.gridProduct;
            this.gridViewProd.Name = "gridViewProd";
            this.gridViewProd.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridViewProd.OptionsBehavior.Editable = false;
            this.gridViewProd.OptionsDetail.AllowOnlyOneMasterRowExpanded = true;
            this.gridViewProd.OptionsView.ShowAutoFilterRow = true;
            this.gridViewProd.OptionsView.ShowGroupPanel = false;
            this.gridViewProd.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridViewProd_CustomDrawCell);
            this.gridViewProd.DoubleClick += new System.EventHandler(this.gridViewProd_DoubleClick);
            this.gridViewProd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewProd_KeyDown);
            // 
            // colName
            // 
            this.colName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colName.AppearanceCell.Options.UseFont = true;
            this.colName.Caption = "Наименование";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsFilter.AllowFilter = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 214;
            // 
            // colPackingName
            // 
            this.colPackingName.Caption = "Форма выпуска";
            this.colPackingName.FieldName = "PackingName";
            this.colPackingName.Name = "colPackingName";
            this.colPackingName.Visible = true;
            this.colPackingName.VisibleIndex = 1;
            this.colPackingName.Width = 194;
            // 
            // colUnitName
            // 
            this.colUnitName.Caption = "Ед.изм";
            this.colUnitName.FieldName = "UnitName";
            this.colUnitName.Name = "colUnitName";
            this.colUnitName.Visible = true;
            this.colUnitName.VisibleIndex = 2;
            this.colUnitName.Width = 155;
            // 
            // colSubstanceName
            // 
            this.colSubstanceName.Caption = "Действ.вещ-во";
            this.colSubstanceName.FieldName = "SubstanceName";
            this.colSubstanceName.Name = "colSubstanceName";
            this.colSubstanceName.Width = 150;
            // 
            // colStorageConditionName
            // 
            this.colStorageConditionName.Caption = "Место хранения";
            this.colStorageConditionName.FieldName = "StorageConditionName";
            this.colStorageConditionName.Name = "colStorageConditionName";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 553);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(727, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btAdd,
            this.btProdAll,
            this.btClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(727, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btAdd
            // 
            this.btAdd.Image = ((System.Drawing.Image)(resources.GetObject("btAdd.Image")));
            this.btAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(94, 22);
            this.btAdd.Text = "Добавить";
            this.btAdd.Visible = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btProdAll
            // 
            this.btProdAll.Image = global::RetailTradeOrders.Properties.Resources.refresh;
            this.btProdAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btProdAll.Name = "btProdAll";
            this.btProdAll.Size = new System.Drawing.Size(143, 22);
            this.btProdAll.Text = "Весь справочник";
            this.btProdAll.Click += new System.EventHandler(this.btProdAll_Click);
            // 
            // btClose
            // 
            this.btClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btClose.Image = global::RetailTradeOrders.Properties.Resources.delete2;
            this.btClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(23, 22);
            this.btClose.Text = "X";
            this.btClose.ToolTipText = "Закрыть";
            this.btClose.Visible = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.mDataSet;
            this.ordersBindingSource.PositionChanged += new System.EventHandler(this.ordersBindingSource_PositionChanged);
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gridProduct);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridOrders);
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(727, 528);
            this.splitContainer1.SplitterDistance = 230;
            this.splitContainer1.TabIndex = 2;
            // 
            // gridOrders
            // 
            this.gridOrders.ContextMenuStrip = this.contextMenuStrip1;
            this.gridOrders.DataSource = this.ordersBindingSource;
            this.gridOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridOrders.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridOrders.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridOrders.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridOrders.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridOrders.EmbeddedNavigator.Buttons.NextPage.Visible = false;
            this.gridOrders.EmbeddedNavigator.Buttons.PrevPage.Visible = false;
            this.gridOrders.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.gridOrders.EmbeddedNavigator.Name = "";
            this.gridOrders.EmbeddedNavigator.TextStringFormat = "Строка  {0} из  {1}";
            this.gridOrders.Location = new System.Drawing.Point(0, 42);
            this.gridOrders.MainView = this.gridViewOrders;
            this.gridOrders.Name = "gridOrders";
            this.gridOrders.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2});
            this.gridOrders.Size = new System.Drawing.Size(727, 252);
            this.gridOrders.TabIndex = 0;
            this.gridOrders.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewOrders});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btDelete,
            this.btProdRep});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(209, 48);
            // 
            // btDelete
            // 
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(208, 22);
            this.btDelete.Text = "Удалить";
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btProdRep
            // 
            this.btProdRep.Name = "btProdRep";
            this.btProdRep.Size = new System.Drawing.Size(208, 22);
            this.btProdRep.Text = "Карточка товара";
            this.btProdRep.Click += new System.EventHandler(this.btProdRep_Click);
            // 
            // gridViewOrders
            // 
            this.gridViewOrders.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductRef,
            this.colProductRef1,
            this.colDateOrder,
            this.colQuantity,
            this.colReserved,
            this.colQuantityNow,
            this.colNote,
            this.colAuthorCreate,
            this.colAuthorLastModif,
            this.colDateCreate,
            this.colDateLastModif});
            this.gridViewOrders.GridControl = this.gridOrders;
            this.gridViewOrders.Name = "gridViewOrders";
            this.gridViewOrders.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridViewOrders.OptionsBehavior.Editable = false;
            this.gridViewOrders.OptionsLayout.StoreDataSettings = false;
            this.gridViewOrders.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewOrders.OptionsView.ShowAutoFilterRow = true;
            this.gridViewOrders.OptionsView.ShowFooter = true;
            this.gridViewOrders.OptionsView.ShowGroupPanel = false;
            this.gridViewOrders.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDateOrder, DevExpress.Data.ColumnSortOrder.Descending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colProductRef, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewOrders.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridViewOrders_CustomDrawCell);
            this.gridViewOrders.DoubleClick += new System.EventHandler(this.gridViewOrders_DoubleClick);
            // 
            // colProductRef
            // 
            this.colProductRef.Caption = "Наименование";
            this.colProductRef.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colProductRef.FieldName = "ProductRef";
            this.colProductRef.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colProductRef.Name = "colProductRef";
            this.colProductRef.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText;
            this.colProductRef.SummaryItem.DisplayFormat = "{0:0}";
            this.colProductRef.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            this.colProductRef.Visible = true;
            this.colProductRef.VisibleIndex = 0;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 39, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEdit1.DataSource = this.productBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "Name";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEdit1.ValueMember = "ID";
            this.repositoryItemLookUpEdit1.GetNotInListValue += new DevExpress.XtraEditors.Controls.GetNotInListValueEventHandler(this.repositoryItemLookUpEdit1_GetNotInListValue);
            // 
            // colProductRef1
            // 
            this.colProductRef1.Caption = "Ед.изм";
            this.colProductRef1.ColumnEdit = this.repositoryItemLookUpEdit2;
            this.colProductRef1.FieldName = "ProductRef";
            this.colProductRef1.Name = "colProductRef1";
            this.colProductRef1.OptionsColumn.AllowEdit = false;
            this.colProductRef1.Visible = true;
            this.colProductRef1.VisibleIndex = 7;
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UnitName", "UnitName", 61, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEdit2.DataSource = this.productBindingSource;
            this.repositoryItemLookUpEdit2.DisplayMember = "UnitName";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEdit2.ValueMember = "ID";
            // 
            // colDateOrder
            // 
            this.colDateOrder.Caption = "Дата";
            this.colDateOrder.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDateOrder.FieldName = "DateOrder";
            this.colDateOrder.Name = "colDateOrder";
            this.colDateOrder.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.colDateOrder.Visible = true;
            this.colDateOrder.VisibleIndex = 1;
            this.colDateOrder.Width = 98;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Количество";
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 2;
            this.colQuantity.Width = 88;
            // 
            // colReserved
            // 
            this.colReserved.Caption = "Заререзвировано";
            this.colReserved.FieldName = "Reserved";
            this.colReserved.Name = "colReserved";
            this.colReserved.Width = 79;
            // 
            // colQuantityNow
            // 
            this.colQuantityNow.Caption = "Отгружено:";
            this.colQuantityNow.FieldName = "QuantityNow";
            this.colQuantityNow.Name = "colQuantityNow";
            this.colQuantityNow.Visible = true;
            this.colQuantityNow.VisibleIndex = 3;
            this.colQuantityNow.Width = 101;
            // 
            // colNote
            // 
            this.colNote.Caption = "Примечание";
            this.colNote.FieldName = "Note";
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 4;
            this.colNote.Width = 104;
            // 
            // colAuthorCreate
            // 
            this.colAuthorCreate.Caption = "Автор";
            this.colAuthorCreate.FieldName = "AuthorCreate";
            this.colAuthorCreate.Name = "colAuthorCreate";
            this.colAuthorCreate.Visible = true;
            this.colAuthorCreate.VisibleIndex = 5;
            this.colAuthorCreate.Width = 63;
            // 
            // colAuthorLastModif
            // 
            this.colAuthorLastModif.Caption = "Редактор";
            this.colAuthorLastModif.FieldName = "AuthorLastModif";
            this.colAuthorLastModif.Name = "colAuthorLastModif";
            this.colAuthorLastModif.Visible = true;
            this.colAuthorLastModif.VisibleIndex = 6;
            this.colAuthorLastModif.Width = 114;
            // 
            // colDateCreate
            // 
            this.colDateCreate.Caption = "Создан";
            this.colDateCreate.FieldName = "DateCreate";
            this.colDateCreate.Name = "colDateCreate";
            // 
            // colDateLastModif
            // 
            this.colDateLastModif.Caption = "Изменен";
            this.colDateLastModif.FieldName = "DateLastModif";
            this.colDateLastModif.Name = "colDateLastModif";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btRefreshOrders);
            this.flowLayoutPanel1.Controls.Add(this.dateTimeEdit);
            this.flowLayoutPanel1.Controls.Add(this.btOrdersNew);
            this.flowLayoutPanel1.Controls.Add(this.btOrdersOld);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(727, 42);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // btRefreshOrders
            // 
            this.btRefreshOrders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btRefreshOrders.Image = global::RetailTradeOrders.Properties.Resources.server_client_exchange;
            this.btRefreshOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRefreshOrders.Location = new System.Drawing.Point(3, 3);
            this.btRefreshOrders.Name = "btRefreshOrders";
            this.btRefreshOrders.Size = new System.Drawing.Size(114, 33);
            this.btRefreshOrders.TabIndex = 3;
            this.btRefreshOrders.Text = "Обновить";
            this.btRefreshOrders.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btRefreshOrders.UseVisualStyleBackColor = true;
            this.btRefreshOrders.Click += new System.EventHandler(this.btRefreshData_Click);
            // 
            // dateTimeEdit
            // 
            this.dateTimeEdit.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimeEdit.Location = new System.Drawing.Point(123, 3);
            this.dateTimeEdit.Name = "dateTimeEdit";
            this.dateTimeEdit.Size = new System.Drawing.Size(200, 22);
            this.dateTimeEdit.TabIndex = 2;
            // 
            // btOrdersNew
            // 
            this.btOrdersNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btOrdersNew.Image = global::RetailTradeOrders.Properties.Resources.view;
            this.btOrdersNew.Location = new System.Drawing.Point(329, 3);
            this.btOrdersNew.Name = "btOrdersNew";
            this.btOrdersNew.Size = new System.Drawing.Size(75, 33);
            this.btOrdersNew.TabIndex = 4;
            this.btOrdersNew.UseVisualStyleBackColor = true;
            this.btOrdersNew.Click += new System.EventHandler(this.btOrdersNew_Click);
            // 
            // btOrdersOld
            // 
            this.btOrdersOld.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btOrdersOld.Image = global::RetailTradeOrders.Properties.Resources.view_next;
            this.btOrdersOld.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btOrdersOld.Location = new System.Drawing.Point(410, 3);
            this.btOrdersOld.Name = "btOrdersOld";
            this.btOrdersOld.Size = new System.Drawing.Size(106, 33);
            this.btOrdersOld.TabIndex = 5;
            this.btOrdersOld.Text = "В заказе";
            this.btOrdersOld.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btOrdersOld.UseVisualStyleBackColor = true;
            this.btOrdersOld.Click += new System.EventHandler(this.btOrdersOld_Click);
            // 
            // OrdersAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "OrdersAll";
            this.Size = new System.Drawing.Size(727, 575);
            this.Load += new System.EventHandler(this.OrdersAll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProdRem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduct)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProd)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private MDataSet mDataSet;
        private RetailTradeOrders.MDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.BindingSource productBindingSource;
        private RetailTradeOrders.MDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.ToolStripButton btAdd;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl gridProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProd;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colPackingName;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitName;
        private DevExpress.XtraGrid.Columns.GridColumn colSubstanceName;
        private DevExpress.XtraGrid.GridControl gridOrders;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewOrders;
        private DevExpress.XtraGrid.Columns.GridColumn colDateOrder;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colReserved;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantityNow;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorCreate;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorLastModif;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreate;
        private DevExpress.XtraGrid.Columns.GridColumn colDateLastModif;
        private DevExpress.XtraGrid.Columns.GridColumn colStorageConditionName;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProdRem;
        private DevExpress.XtraGrid.Columns.GridColumn colManufacturerName;
        private DevExpress.XtraGrid.Columns.GridColumn colSeries;
        private DevExpress.XtraGrid.Columns.GridColumn colUseByDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPricePurchase;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantityRemains;
        private System.Windows.Forms.ToolStripButton btClose;
        private System.Windows.Forms.ToolStripButton btProdAll;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btDelete;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DateTimePicker dateTimeEdit;
        private System.Windows.Forms.Button btRefreshOrders;
        private System.Windows.Forms.Button btOrdersNew;
        private System.Windows.Forms.Button btOrdersOld;
        private System.Windows.Forms.ToolStripMenuItem btProdRep;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem btProduct;
        private DevExpress.XtraGrid.Columns.GridColumn colProductRef;
        private DevExpress.XtraGrid.Columns.GridColumn colProductRef1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
    }
}
