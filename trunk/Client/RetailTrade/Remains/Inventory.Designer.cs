namespace RetailTradeClient.Remains
{
    partial class Inventory
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btAdd = new System.Windows.Forms.ToolStripButton();
            this.btClose = new System.Windows.Forms.ToolStripButton();
            this.mDataSet = new RetailTradeClient.MDataSet();
            this.inventoryDetailsTableAdapter = new RetailTradeClient.MDataSetTableAdapters.inventoryDetailsTableAdapter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.inventoryMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewMasterInventory = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorCreate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsClose = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorLatModif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateLastModif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControlInventDet = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btProdReport = new System.Windows.Forms.ToolStripMenuItem();
            this.fKinventoryMasterinventoryDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewIntDet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManufacturerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManufacturerRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeries = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUseByDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantityFact = new DevExpress.XtraGrid.Columns.GridColumn();
            this.quantityFactEdit = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colIsRecept = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsOneRecept = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMinDivisor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsNDS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFarmGroupName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPackingName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStorageConditionName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFarmGroupLevel2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubstanceName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOldKol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOldName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSumFact = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSumRem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorLastModif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateLastModif1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiff = new DevExpress.XtraGrid.Columns.GridColumn();
            this.inventoryMasterTableAdapter = new RetailTradeClient.MDataSetTableAdapters.inventoryMasterTableAdapter();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMasterInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlInventDet)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKinventoryMasterinventoryDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewIntDet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityFactEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btAdd,
            this.btClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(765, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btAdd
            // 
            this.btAdd.Image = global::RetailTradeClient.Properties.Resources.document_add;
            this.btAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(84, 22);
            this.btAdd.Text = "Создать";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btClose
            // 
            this.btClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btClose.Image = global::RetailTradeClient.Properties.Resources.delete2;
            this.btClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(23, 22);
            this.btClose.Text = "X";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // mDataSet
            // 
            this.mDataSet.DataSetName = "MDataSet";
            this.mDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryDetailsTableAdapter
            // 
            this.inventoryDetailsTableAdapter.ClearBeforeFill = true;
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
            this.splitContainer1.Panel1.Controls.Add(this.grid);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridControlInventDet);
            this.splitContainer1.Size = new System.Drawing.Size(765, 496);
            this.splitContainer1.SplitterDistance = 183;
            this.splitContainer1.TabIndex = 0;
            // 
            // grid
            // 
            this.grid.DataSource = this.inventoryMasterBindingSource;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.EmbeddedNavigator.Name = "";
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.gridViewMasterInventory;
            this.grid.Name = "grid";
            this.grid.ShowOnlyPredefinedDetails = true;
            this.grid.Size = new System.Drawing.Size(765, 183);
            this.grid.TabIndex = 0;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMasterInventory,
            this.gridView3});
            // 
            // inventoryMasterBindingSource
            // 
            this.inventoryMasterBindingSource.DataMember = "inventoryMaster";
            this.inventoryMasterBindingSource.DataSource = this.mDataSet;
            this.inventoryMasterBindingSource.CurrentChanged += new System.EventHandler(this.inventoryMasterBindingSource_CurrentChanged);
            // 
            // gridViewMasterInventory
            // 
            this.gridViewMasterInventory.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID1,
            this.colDate,
            this.colNote1,
            this.colAuthorCreate,
            this.colIsClose,
            this.colAuthorLatModif,
            this.colDateLastModif});
            this.gridViewMasterInventory.GridControl = this.grid;
            this.gridViewMasterInventory.Name = "gridViewMasterInventory";
            this.gridViewMasterInventory.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDate, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colID1
            // 
            this.colID1.Caption = "№";
            this.colID1.FieldName = "ID";
            this.colID1.Name = "colID1";
            this.colID1.OptionsColumn.AllowEdit = false;
            this.colID1.OptionsColumn.ReadOnly = true;
            this.colID1.OptionsFilter.AllowFilter = false;
            this.colID1.Visible = true;
            this.colID1.VisibleIndex = 0;
            this.colID1.Width = 160;
            // 
            // colDate
            // 
            this.colDate.Caption = "Дата";
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.OptionsColumn.AllowEdit = false;
            this.colDate.OptionsFilter.AllowFilter = false;
            this.colDate.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 1;
            this.colDate.Width = 181;
            // 
            // colNote1
            // 
            this.colNote1.Caption = "Основание";
            this.colNote1.FieldName = "Note";
            this.colNote1.Name = "colNote1";
            this.colNote1.OptionsFilter.AllowFilter = false;
            this.colNote1.Visible = true;
            this.colNote1.VisibleIndex = 2;
            this.colNote1.Width = 181;
            // 
            // colAuthorCreate
            // 
            this.colAuthorCreate.Caption = "Создан";
            this.colAuthorCreate.FieldName = "AuthorCreate";
            this.colAuthorCreate.Name = "colAuthorCreate";
            this.colAuthorCreate.OptionsColumn.AllowEdit = false;
            this.colAuthorCreate.Visible = true;
            this.colAuthorCreate.VisibleIndex = 3;
            this.colAuthorCreate.Width = 184;
            // 
            // colIsClose
            // 
            this.colIsClose.Caption = "Закрыт";
            this.colIsClose.FieldName = "IsClose";
            this.colIsClose.Name = "colIsClose";
            this.colIsClose.Visible = true;
            this.colIsClose.VisibleIndex = 4;
            // 
            // colAuthorLatModif
            // 
            this.colAuthorLatModif.Caption = "Редактор";
            this.colAuthorLatModif.FieldName = "AuthorLatModif";
            this.colAuthorLatModif.Name = "colAuthorLatModif";
            this.colAuthorLatModif.OptionsColumn.AllowEdit = false;
            // 
            // colDateLastModif
            // 
            this.colDateLastModif.Caption = "Изменен";
            this.colDateLastModif.FieldName = "DateLastModif";
            this.colDateLastModif.Name = "colDateLastModif";
            this.colDateLastModif.OptionsColumn.AllowEdit = false;
            this.colDateLastModif.OptionsFilter.AllowFilter = false;
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.grid;
            this.gridView3.Name = "gridView3";
            // 
            // gridControlInventDet
            // 
            this.gridControlInventDet.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControlInventDet.DataSource = this.fKinventoryMasterinventoryDetailsBindingSource;
            this.gridControlInventDet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlInventDet.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControlInventDet.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControlInventDet.EmbeddedNavigator.Buttons.EnabledAutoRepeat = false;
            this.gridControlInventDet.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControlInventDet.EmbeddedNavigator.Buttons.NextPage.Visible = false;
            this.gridControlInventDet.EmbeddedNavigator.Buttons.PrevPage.Visible = false;
            this.gridControlInventDet.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControlInventDet.EmbeddedNavigator.Name = "";
            this.gridControlInventDet.EmbeddedNavigator.TextStringFormat = "Строка  {0} из {1}";
            this.gridControlInventDet.Location = new System.Drawing.Point(0, 0);
            this.gridControlInventDet.MainView = this.gridViewIntDet;
            this.gridControlInventDet.Name = "gridControlInventDet";
            this.gridControlInventDet.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.quantityFactEdit});
            this.gridControlInventDet.ShowOnlyPredefinedDetails = true;
            this.gridControlInventDet.Size = new System.Drawing.Size(765, 309);
            this.gridControlInventDet.TabIndex = 0;
            this.gridControlInventDet.UseEmbeddedNavigator = true;
            this.gridControlInventDet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewIntDet});
            this.gridControlInventDet.Enter += new System.EventHandler(this.gridControlInventDet_Enter);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btProdReport});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(209, 26);
            // 
            // btProdReport
            // 
            this.btProdReport.Name = "btProdReport";
            this.btProdReport.Size = new System.Drawing.Size(208, 22);
            this.btProdReport.Text = "Карточка товара";
            this.btProdReport.Click += new System.EventHandler(this.btProdReport_Click);
            // 
            // fKinventoryMasterinventoryDetailsBindingSource
            // 
            this.fKinventoryMasterinventoryDetailsBindingSource.DataMember = "FK_inventoryMaster_inventoryDetails";
            this.fKinventoryMasterinventoryDetailsBindingSource.DataSource = this.inventoryMasterBindingSource;
            this.fKinventoryMasterinventoryDetailsBindingSource.CurrentChanged += new System.EventHandler(this.fKinventoryMasterinventoryDetailsBindingSource_CurrentChanged);
            // 
            // gridViewIntDet
            // 
            this.gridViewIntDet.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductName,
            this.colManufacturerName,
            this.colID,
            this.colProductRef,
            this.colManufacturerRef,
            this.colPrice,
            this.colQuantity,
            this.colSeries,
            this.colUseByDate,
            this.colQuantityFact,
            this.colIsRecept,
            this.colIsOneRecept,
            this.colMinDivisor,
            this.colIsNDS,
            this.colFarmGroupName,
            this.colPackingName,
            this.colStorageConditionName,
            this.colFarmGroupLevel2,
            this.colUnitName,
            this.colSubstanceName,
            this.colOldKol,
            this.colOldName,
            this.colNote,
            this.colSumFact,
            this.colSumRem,
            this.colAuthorLastModif,
            this.colDateLastModif1,
            this.colDiff});
            this.gridViewIntDet.GridControl = this.gridControlInventDet;
            this.gridViewIntDet.Name = "gridViewIntDet";
            this.gridViewIntDet.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridViewIntDet.OptionsView.ColumnAutoWidth = false;
            this.gridViewIntDet.OptionsView.ShowAutoFilterRow = true;
            this.gridViewIntDet.OptionsView.ShowFooter = true;
            this.gridViewIntDet.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colProductName, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewIntDet.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridViewIntDet_CustomDrawCell);
            this.gridViewIntDet.ShownEditor += new System.EventHandler(this.gridViewIntDet_ShownEditor);
            this.gridViewIntDet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewIntDet_KeyDown);
            // 
            // colProductName
            // 
            this.colProductName.Caption = "Наименование";
            this.colProductName.FieldName = "ProductName";
            this.colProductName.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colProductName.Name = "colProductName";
            this.colProductName.OptionsColumn.AllowEdit = false;
            this.colProductName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colProductName.OptionsFilter.AllowFilter = false;
            this.colProductName.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText;
            this.colProductName.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 0;
            this.colProductName.Width = 164;
            // 
            // colManufacturerName
            // 
            this.colManufacturerName.Caption = "Изготовитель";
            this.colManufacturerName.FieldName = "ManufacturerName";
            this.colManufacturerName.Name = "colManufacturerName";
            this.colManufacturerName.OptionsColumn.AllowEdit = false;
            this.colManufacturerName.OptionsFilter.AllowFilter = false;
            this.colManufacturerName.Visible = true;
            this.colManufacturerName.VisibleIndex = 6;
            this.colManufacturerName.Width = 77;
            // 
            // colID
            // 
            this.colID.Caption = "Код";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.OptionsColumn.ReadOnly = true;
            this.colID.OptionsFilter.AllowFilter = false;
            // 
            // colProductRef
            // 
            this.colProductRef.Caption = "Код товара";
            this.colProductRef.FieldName = "ProductRef";
            this.colProductRef.Name = "colProductRef";
            this.colProductRef.OptionsColumn.AllowEdit = false;
            this.colProductRef.OptionsFilter.AllowFilter = false;
            // 
            // colManufacturerRef
            // 
            this.colManufacturerRef.Caption = "Код изготовителя";
            this.colManufacturerRef.FieldName = "ManufacturerRef";
            this.colManufacturerRef.Name = "colManufacturerRef";
            this.colManufacturerRef.OptionsColumn.AllowEdit = false;
            this.colManufacturerRef.OptionsFilter.AllowFilter = false;
            // 
            // colPrice
            // 
            this.colPrice.Caption = "Цена";
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.OptionsColumn.AllowEdit = false;
            this.colPrice.OptionsFilter.AllowFilter = false;
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 3;
            this.colPrice.Width = 77;
            // 
            // colQuantity
            // 
            this.colQuantity.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colQuantity.AppearanceCell.Options.UseFont = true;
            this.colQuantity.Caption = "Остаток";
            this.colQuantity.DisplayFormat.FormatString = "###0.###";
            this.colQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.OptionsColumn.AllowEdit = false;
            this.colQuantity.OptionsFilter.AllowFilter = false;
            this.colQuantity.SummaryItem.DisplayFormat = "{0:######.00}";
            this.colQuantity.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 1;
            this.colQuantity.Width = 79;
            // 
            // colSeries
            // 
            this.colSeries.Caption = "Серия";
            this.colSeries.FieldName = "Series";
            this.colSeries.Name = "colSeries";
            this.colSeries.OptionsColumn.AllowEdit = false;
            this.colSeries.OptionsFilter.AllowFilter = false;
            this.colSeries.Visible = true;
            this.colSeries.VisibleIndex = 4;
            this.colSeries.Width = 77;
            // 
            // colUseByDate
            // 
            this.colUseByDate.Caption = "Срок";
            this.colUseByDate.FieldName = "UseByDate";
            this.colUseByDate.Name = "colUseByDate";
            this.colUseByDate.OptionsColumn.AllowEdit = false;
            this.colUseByDate.OptionsFilter.AllowFilter = false;
            this.colUseByDate.Visible = true;
            this.colUseByDate.VisibleIndex = 5;
            this.colUseByDate.Width = 85;
            // 
            // colQuantityFact
            // 
            this.colQuantityFact.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colQuantityFact.AppearanceCell.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.colQuantityFact.AppearanceCell.Options.UseFont = true;
            this.colQuantityFact.AppearanceCell.Options.UseForeColor = true;
            this.colQuantityFact.Caption = "Факт";
            this.colQuantityFact.ColumnEdit = this.quantityFactEdit;
            this.colQuantityFact.DisplayFormat.FormatString = "####.###";
            this.colQuantityFact.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQuantityFact.FieldName = "QuantityFact";
            this.colQuantityFact.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colQuantityFact.Name = "colQuantityFact";
            this.colQuantityFact.SummaryItem.DisplayFormat = "{0:######.00}";
            this.colQuantityFact.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colQuantityFact.Visible = true;
            this.colQuantityFact.VisibleIndex = 14;
            this.colQuantityFact.Width = 128;
            // 
            // quantityFactEdit
            // 
            this.quantityFactEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.quantityFactEdit.Appearance.Options.UseFont = true;
            this.quantityFactEdit.AutoHeight = false;
            this.quantityFactEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.quantityFactEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.quantityFactEdit.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.quantityFactEdit.DisplayFormat.FormatString = "#####.###";
            this.quantityFactEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.quantityFactEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.quantityFactEdit.IsFloatValue = false;
            this.quantityFactEdit.Mask.EditMask = "N00";
            this.quantityFactEdit.Name = "quantityFactEdit";
            this.quantityFactEdit.UseCtrlIncrement = true;
            this.quantityFactEdit.ValidateOnEnterKey = true;
            this.quantityFactEdit.Validating += new System.ComponentModel.CancelEventHandler(this.quantityFactEdit_Validating);
            // 
            // colIsRecept
            // 
            this.colIsRecept.Caption = "Рецепт";
            this.colIsRecept.FieldName = "IsRecept";
            this.colIsRecept.Name = "colIsRecept";
            this.colIsRecept.OptionsColumn.AllowEdit = false;
            this.colIsRecept.OptionsFilter.AllowFilter = false;
            // 
            // colIsOneRecept
            // 
            this.colIsOneRecept.Caption = "Один на рецепте";
            this.colIsOneRecept.FieldName = "IsOneRecept";
            this.colIsOneRecept.Name = "colIsOneRecept";
            this.colIsOneRecept.OptionsColumn.AllowEdit = false;
            this.colIsOneRecept.OptionsFilter.AllowFilter = false;
            // 
            // colMinDivisor
            // 
            this.colMinDivisor.Caption = "Делитель";
            this.colMinDivisor.FieldName = "MinDivisor";
            this.colMinDivisor.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.colMinDivisor.Name = "colMinDivisor";
            this.colMinDivisor.OptionsColumn.AllowEdit = false;
            this.colMinDivisor.OptionsFilter.AllowFilter = false;
            this.colMinDivisor.Visible = true;
            this.colMinDivisor.VisibleIndex = 13;
            // 
            // colIsNDS
            // 
            this.colIsNDS.Caption = "НДС";
            this.colIsNDS.FieldName = "IsNDS";
            this.colIsNDS.Name = "colIsNDS";
            this.colIsNDS.OptionsColumn.AllowEdit = false;
            this.colIsNDS.OptionsFilter.AllowFilter = false;
            // 
            // colFarmGroupName
            // 
            this.colFarmGroupName.Caption = "Фармгруппа";
            this.colFarmGroupName.FieldName = "FarmGroupName";
            this.colFarmGroupName.Name = "colFarmGroupName";
            this.colFarmGroupName.OptionsColumn.AllowEdit = false;
            this.colFarmGroupName.OptionsFilter.AllowFilter = false;
            // 
            // colPackingName
            // 
            this.colPackingName.Caption = "Форма выпуска";
            this.colPackingName.FieldName = "PackingName";
            this.colPackingName.Name = "colPackingName";
            this.colPackingName.OptionsColumn.AllowEdit = false;
            this.colPackingName.OptionsFilter.AllowFilter = false;
            // 
            // colStorageConditionName
            // 
            this.colStorageConditionName.Caption = "Место хранения";
            this.colStorageConditionName.FieldName = "StorageConditionName";
            this.colStorageConditionName.Name = "colStorageConditionName";
            this.colStorageConditionName.OptionsColumn.AllowEdit = false;
            this.colStorageConditionName.OptionsFilter.AllowFilter = false;
            // 
            // colFarmGroupLevel2
            // 
            this.colFarmGroupLevel2.Caption = "Фармгруппа (2)";
            this.colFarmGroupLevel2.FieldName = "FarmGroupLevel2";
            this.colFarmGroupLevel2.Name = "colFarmGroupLevel2";
            this.colFarmGroupLevel2.OptionsColumn.AllowEdit = false;
            this.colFarmGroupLevel2.OptionsFilter.AllowFilter = false;
            // 
            // colUnitName
            // 
            this.colUnitName.Caption = "Ед.изм";
            this.colUnitName.FieldName = "UnitName";
            this.colUnitName.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colUnitName.Name = "colUnitName";
            this.colUnitName.OptionsColumn.AllowEdit = false;
            this.colUnitName.OptionsFilter.AllowFilter = false;
            this.colUnitName.Visible = true;
            this.colUnitName.VisibleIndex = 2;
            this.colUnitName.Width = 95;
            // 
            // colSubstanceName
            // 
            this.colSubstanceName.Caption = "Действ. вещ-во";
            this.colSubstanceName.FieldName = "SubstanceName";
            this.colSubstanceName.Name = "colSubstanceName";
            this.colSubstanceName.OptionsColumn.AllowEdit = false;
            this.colSubstanceName.OptionsFilter.AllowFilter = false;
            // 
            // colOldKol
            // 
            this.colOldKol.Caption = "Кол.в упаковке";
            this.colOldKol.FieldName = "OldKol";
            this.colOldKol.Name = "colOldKol";
            this.colOldKol.OptionsColumn.AllowEdit = false;
            this.colOldKol.OptionsFilter.AllowAutoFilter = false;
            // 
            // colOldName
            // 
            this.colOldName.Caption = "Наименование произ.";
            this.colOldName.FieldName = "OldName";
            this.colOldName.Name = "colOldName";
            this.colOldName.OptionsColumn.AllowEdit = false;
            this.colOldName.OptionsFilter.AllowFilter = false;
            // 
            // colNote
            // 
            this.colNote.Caption = "Прим.";
            this.colNote.FieldName = "Note";
            this.colNote.Name = "colNote";
            this.colNote.OptionsFilter.AllowFilter = false;
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 7;
            this.colNote.Width = 63;
            // 
            // colSumFact
            // 
            this.colSumFact.Caption = "Сумма фактич.";
            this.colSumFact.FieldName = "SumFact";
            this.colSumFact.Name = "colSumFact";
            this.colSumFact.OptionsColumn.AllowEdit = false;
            this.colSumFact.OptionsFilter.AllowFilter = false;
            this.colSumFact.SummaryItem.DisplayFormat = "{0:##.00}";
            this.colSumFact.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colSumFact.Visible = true;
            this.colSumFact.VisibleIndex = 8;
            // 
            // colSumRem
            // 
            this.colSumRem.Caption = "Сумма остатка";
            this.colSumRem.FieldName = "SumRem";
            this.colSumRem.Name = "colSumRem";
            this.colSumRem.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colSumRem.Visible = true;
            this.colSumRem.VisibleIndex = 9;
            // 
            // colAuthorLastModif
            // 
            this.colAuthorLastModif.Caption = "Редактор";
            this.colAuthorLastModif.FieldName = "AuthorLastModif";
            this.colAuthorLastModif.Name = "colAuthorLastModif";
            this.colAuthorLastModif.Visible = true;
            this.colAuthorLastModif.VisibleIndex = 10;
            // 
            // colDateLastModif1
            // 
            this.colDateLastModif1.Caption = "Изменен";
            this.colDateLastModif1.FieldName = "DateLastModif";
            this.colDateLastModif1.Name = "colDateLastModif1";
            this.colDateLastModif1.Visible = true;
            this.colDateLastModif1.VisibleIndex = 11;
            // 
            // colDiff
            // 
            this.colDiff.Caption = "Разница";
            this.colDiff.DisplayFormat.FormatString = "#####.##";
            this.colDiff.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDiff.FieldName = "Diff";
            this.colDiff.Name = "colDiff";
            this.colDiff.Visible = true;
            this.colDiff.VisibleIndex = 12;
            // 
            // inventoryMasterTableAdapter
            // 
            this.inventoryMasterTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Inventory";
            this.Size = new System.Drawing.Size(765, 521);
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMasterInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlInventDet)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fKinventoryMasterinventoryDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewIntDet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityFactEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private MDataSet mDataSet;
        private RetailTradeClient.MDataSetTableAdapters.inventoryDetailsTableAdapter inventoryDetailsTableAdapter;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl grid;
        private System.Windows.Forms.BindingSource inventoryMasterBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMasterInventory;
        private DevExpress.XtraGrid.Columns.GridColumn colID1;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colNote1;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorCreate;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.GridControl gridControlInventDet;
        private System.Windows.Forms.BindingSource fKinventoryMasterinventoryDetailsBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewIntDet;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colManufacturerName;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colProductRef;
        private DevExpress.XtraGrid.Columns.GridColumn colManufacturerRef;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colSeries;
        private DevExpress.XtraGrid.Columns.GridColumn colUseByDate;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantityFact;
        private DevExpress.XtraGrid.Columns.GridColumn colIsRecept;
        private DevExpress.XtraGrid.Columns.GridColumn colIsOneRecept;
        private DevExpress.XtraGrid.Columns.GridColumn colMinDivisor;
        private DevExpress.XtraGrid.Columns.GridColumn colIsNDS;
        private DevExpress.XtraGrid.Columns.GridColumn colFarmGroupName;
        private DevExpress.XtraGrid.Columns.GridColumn colPackingName;
        private DevExpress.XtraGrid.Columns.GridColumn colStorageConditionName;
        private DevExpress.XtraGrid.Columns.GridColumn colFarmGroupLevel2;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitName;
        private DevExpress.XtraGrid.Columns.GridColumn colSubstanceName;
        private DevExpress.XtraGrid.Columns.GridColumn colOldKol;
        private DevExpress.XtraGrid.Columns.GridColumn colOldName;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private RetailTradeClient.MDataSetTableAdapters.inventoryMasterTableAdapter inventoryMasterTableAdapter;
        private System.Windows.Forms.ToolStripButton btAdd;
        private DevExpress.XtraGrid.Columns.GridColumn colIsClose;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorLatModif;
        private DevExpress.XtraGrid.Columns.GridColumn colDateLastModif;
        private DevExpress.XtraGrid.Columns.GridColumn colSumFact;
        private DevExpress.XtraGrid.Columns.GridColumn colSumRem;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorLastModif;
        private DevExpress.XtraGrid.Columns.GridColumn colDateLastModif1;
        private System.Windows.Forms.ToolStripButton btClose;
        private DevExpress.XtraGrid.Columns.GridColumn colDiff;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit quantityFactEdit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btProdReport;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
    }
}
