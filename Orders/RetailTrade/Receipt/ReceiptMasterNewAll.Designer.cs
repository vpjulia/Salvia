namespace RetailTradeOrders
{
    partial class ReceiptMasterNewAll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiptMasterNewAll));
            this.gridViewRecDet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManufacturerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeries = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUseByDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.receiptMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mDataSet = new RetailTradeOrders.MDataSet();
            this.gridViewRecMast = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesNDS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorCreate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateLastModif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorLastModif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.productLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btRefresh = new System.Windows.Forms.ToolStripButton();
            this.btMove = new System.Windows.Forms.ToolStripButton();
            this.btClose = new System.Windows.Forms.ToolStripButton();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRecDet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRecMast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridViewRecDet
            // 
            this.gridViewRecDet.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductName,
            this.colManufacturerName,
            this.colCountryName,
            this.colSeries,
            this.colUseByDate,
            this.colQuantity,
            this.colSalesPrice,
            this.colNote1});
            this.gridViewRecDet.GridControl = this.grid;
            this.gridViewRecDet.Name = "gridViewRecDet";
            this.gridViewRecDet.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridViewRecDet.OptionsBehavior.Editable = false;
            this.gridViewRecDet.OptionsDetail.AllowOnlyOneMasterRowExpanded = true;
            this.gridViewRecDet.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridViewRecDet.OptionsFilter.AllowMRUFilterList = false;
            this.gridViewRecDet.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewRecDet.OptionsView.ShowChildrenInGroupPanel = true;
            this.gridViewRecDet.OptionsView.ShowGroupedColumns = true;
            this.gridViewRecDet.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridViewRecDet_CustomDrawCell);
            // 
            // colProductName
            // 
            this.colProductName.Caption = "Наименование";
            this.colProductName.FieldName = "ProductName";
            this.colProductName.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colProductName.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colProductName.Name = "colProductName";
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 0;
            this.colProductName.Width = 173;
            // 
            // colManufacturerName
            // 
            this.colManufacturerName.Caption = "Изготовитель";
            this.colManufacturerName.FieldName = "ManufacturerName";
            this.colManufacturerName.Name = "colManufacturerName";
            this.colManufacturerName.OptionsFilter.AllowAutoFilter = false;
            this.colManufacturerName.OptionsFilter.AllowFilter = false;
            this.colManufacturerName.Visible = true;
            this.colManufacturerName.VisibleIndex = 1;
            this.colManufacturerName.Width = 112;
            // 
            // colCountryName
            // 
            this.colCountryName.Caption = "Страна";
            this.colCountryName.FieldName = "CountryName";
            this.colCountryName.Name = "colCountryName";
            this.colCountryName.OptionsFilter.AllowAutoFilter = false;
            this.colCountryName.OptionsFilter.AllowFilter = false;
            this.colCountryName.Width = 85;
            // 
            // colSeries
            // 
            this.colSeries.Caption = "Серия";
            this.colSeries.FieldName = "Series";
            this.colSeries.Name = "colSeries";
            this.colSeries.OptionsFilter.AllowAutoFilter = false;
            this.colSeries.OptionsFilter.AllowFilter = false;
            this.colSeries.Visible = true;
            this.colSeries.VisibleIndex = 2;
            this.colSeries.Width = 90;
            // 
            // colUseByDate
            // 
            this.colUseByDate.Caption = "Срок";
            this.colUseByDate.FieldName = "UseByDate";
            this.colUseByDate.Name = "colUseByDate";
            this.colUseByDate.OptionsFilter.AllowAutoFilter = false;
            this.colUseByDate.OptionsFilter.AllowFilter = false;
            this.colUseByDate.Visible = true;
            this.colUseByDate.VisibleIndex = 3;
            this.colUseByDate.Width = 80;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Кол-во";
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.OptionsFilter.AllowAutoFilter = false;
            this.colQuantity.OptionsFilter.AllowFilter = false;
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 4;
            this.colQuantity.Width = 80;
            // 
            // colSalesPrice
            // 
            this.colSalesPrice.Caption = "Цена";
            this.colSalesPrice.FieldName = "SalesPrice";
            this.colSalesPrice.Name = "colSalesPrice";
            this.colSalesPrice.OptionsFilter.AllowAutoFilter = false;
            this.colSalesPrice.OptionsFilter.AllowFilter = false;
            this.colSalesPrice.Visible = true;
            this.colSalesPrice.VisibleIndex = 5;
            this.colSalesPrice.Width = 87;
            // 
            // colNote1
            // 
            this.colNote1.Caption = "Примечание";
            this.colNote1.FieldName = "Note";
            this.colNote1.Name = "colNote1";
            this.colNote1.OptionsFilter.AllowAutoFilter = false;
            this.colNote1.OptionsFilter.AllowFilter = false;
            // 
            // grid
            // 
            this.grid.DataSource = this.receiptMasterBindingSource;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.EmbeddedNavigator.Name = "";
            gridLevelNode1.LevelTemplate = this.gridViewRecDet;
            gridLevelNode1.RelationName = "FK_ReceiptDetail_ReceiptMaster";
            this.grid.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grid.Location = new System.Drawing.Point(0, 25);
            this.grid.MainView = this.gridViewRecMast;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.productLookUpEdit});
            this.grid.Size = new System.Drawing.Size(638, 478);
            this.grid.TabIndex = 2;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRecMast,
            this.gridViewRecDet});
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
            // gridViewRecMast
            // 
            this.gridViewRecMast.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNumber,
            this.colNote,
            this.colDocDate,
            this.colSalesSum,
            this.colSalesNDS,
            this.colAuthorCreate,
            this.colDateLastModif,
            this.colAuthorLastModif,
            this.colDateCreate});
            this.gridViewRecMast.GridControl = this.grid;
            this.gridViewRecMast.Name = "gridViewRecMast";
            this.gridViewRecMast.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridViewRecMast.OptionsBehavior.Editable = false;
            this.gridViewRecMast.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewRecMast.OptionsView.ShowFooter = true;
            this.gridViewRecMast.MasterRowExpanding += new DevExpress.XtraGrid.Views.Grid.MasterRowCanExpandEventHandler(this.gridViewRecMast_MasterRowExpanding);
            // 
            // colNumber
            // 
            this.colNumber.Caption = "№";
            this.colNumber.FieldName = "Number";
            this.colNumber.Name = "colNumber";
            this.colNumber.OptionsFilter.AllowAutoFilter = false;
            this.colNumber.OptionsFilter.AllowFilter = false;
            this.colNumber.Visible = true;
            this.colNumber.VisibleIndex = 0;
            this.colNumber.Width = 107;
            // 
            // colNote
            // 
            this.colNote.Caption = "Основание";
            this.colNote.FieldName = "Note";
            this.colNote.Name = "colNote";
            this.colNote.OptionsFilter.AllowAutoFilter = false;
            this.colNote.OptionsFilter.AllowFilter = false;
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 1;
            this.colNote.Width = 127;
            // 
            // colDocDate
            // 
            this.colDocDate.Caption = "Дата";
            this.colDocDate.FieldName = "DocDate";
            this.colDocDate.Name = "colDocDate";
            this.colDocDate.Visible = true;
            this.colDocDate.VisibleIndex = 2;
            this.colDocDate.Width = 127;
            // 
            // colSalesSum
            // 
            this.colSalesSum.Caption = "Сумма";
            this.colSalesSum.FieldName = "SalesSum";
            this.colSalesSum.Name = "colSalesSum";
            this.colSalesSum.OptionsFilter.AllowAutoFilter = false;
            this.colSalesSum.OptionsFilter.AllowFilter = false;
            this.colSalesSum.SummaryItem.DisplayFormat = "(Итого : {0},{0.00})";
            this.colSalesSum.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colSalesSum.Visible = true;
            this.colSalesSum.VisibleIndex = 3;
            this.colSalesSum.Width = 127;
            // 
            // colSalesNDS
            // 
            this.colSalesNDS.Caption = "в т.ч НДС";
            this.colSalesNDS.FieldName = "SalesNDS";
            this.colSalesNDS.Name = "colSalesNDS";
            this.colSalesNDS.OptionsFilter.AllowAutoFilter = false;
            this.colSalesNDS.OptionsFilter.AllowFilter = false;
            this.colSalesNDS.Visible = true;
            this.colSalesNDS.VisibleIndex = 4;
            this.colSalesNDS.Width = 136;
            // 
            // colAuthorCreate
            // 
            this.colAuthorCreate.Caption = "Создан";
            this.colAuthorCreate.FieldName = "AuthorCreate";
            this.colAuthorCreate.Name = "colAuthorCreate";
            this.colAuthorCreate.Width = 23;
            // 
            // colDateLastModif
            // 
            this.colDateLastModif.Caption = "Изменен";
            this.colDateLastModif.FieldName = "DateLastModif";
            this.colDateLastModif.Name = "colDateLastModif";
            this.colDateLastModif.Width = 23;
            // 
            // colAuthorLastModif
            // 
            this.colAuthorLastModif.Caption = "Автор";
            this.colAuthorLastModif.FieldName = "AuthorLastModif";
            this.colAuthorLastModif.Name = "colAuthorLastModif";
            this.colAuthorLastModif.Width = 23;
            // 
            // colDateCreate
            // 
            this.colDateCreate.Caption = "Создан";
            this.colDateCreate.FieldName = "DateCreate";
            this.colDateCreate.Name = "colDateCreate";
            this.colDateCreate.Width = 23;
            // 
            // productLookUpEdit
            // 
            this.productLookUpEdit.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.productLookUpEdit.AutoHeight = false;
            this.productLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.productLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 31, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 39, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SmallName", "SmallName", 71, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PriceManufact", "PriceManufact", 86, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UnitRef", "UnitRef", 47, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PackingRef", "PackingRef", 68, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StorageConditionRef", "StorageConditionRef", 123, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubstanceRef", "SubstanceRef", 84, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FarmGrouplevel2Ref", "FarmGrouplevel2Ref", 122, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IsRecept", "IsRecept", 55, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IsOneRecept", "IsOneRecept", 78, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IsHide", "IsHide", 41, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MinDivisor", "MinDivisor", 64, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IsNDS", "IsNDS", 40, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AuthorCreate", "AuthorCreate", 82, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AuthorLastModif", "AuthorLastModif", 98, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DateCreate", "DateCreate", 70, DevExpress.Utils.FormatType.DateTime, "dd.MM.yyyy", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RowVersion", "RowVersion", 74, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FarmGroupName", "FarmGroupName", 103, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PackingName", "PackingName", 82, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StorageConditionName", "StorageConditionName", 137, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FarmGroupLevel2", "FarmGroupLevel2", 106, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UnitName", "UnitName", 61, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SubstanceName", "SubstanceName", 98, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DateLastModif", "DateLastModif", 86, DevExpress.Utils.FormatType.DateTime, "dd.MM.yyyy", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Note", "Note", 32, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("OldName", "OldName", 58, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("OldKod", "OldKod", 46, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("OldKol", "OldKol", 42, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None)});
            this.productLookUpEdit.DataSource = this.productBindingSource;
            this.productLookUpEdit.DisplayMember = "Name";
            this.productLookUpEdit.Name = "productLookUpEdit";
            this.productLookUpEdit.ValueMember = "ID";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.mDataSet;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 503);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(638, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btRefresh,
            this.btClose,
            this.btMove});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(638, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btRefresh
            // 
            this.btRefresh.Image = global::RetailTradeOrders.Properties.Resources.server_client_exchange;
            this.btRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(95, 22);
            this.btRefresh.Text = "Обновить";
            this.btRefresh.Click += new System.EventHandler(this.ReceiptMasterNewAll_Load);
            // 
            // btMove
            // 
            this.btMove.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btMove.Image = global::RetailTradeOrders.Properties.Resources.download;
            this.btMove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btMove.Name = "btMove";
            this.btMove.Size = new System.Drawing.Size(150, 22);
            this.btMove.Text = "Принять на склад";
            this.btMove.Click += new System.EventHandler(this.btMove_Click);
            // 
            // btClose
            // 
            this.btClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btClose.Image = ((System.Drawing.Image)(resources.GetObject("btClose.Image")));
            this.btClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(23, 22);
            this.btClose.Text = "X";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // ReceiptMasterNewAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "ReceiptMasterNewAll";
            this.Size = new System.Drawing.Size(638, 525);
            this.Load += new System.EventHandler(this.ReceiptMasterNewAll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRecDet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRecMast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.BindingSource receiptMasterBindingSource;
        private MDataSet mDataSet;
        private System.Windows.Forms.ToolStripButton btMove;
        private System.Windows.Forms.ToolStripButton btRefresh;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.ToolStripButton btClose;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit productLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRecDet;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colManufacturerName;
        private DevExpress.XtraGrid.Columns.GridColumn colCountryName;
        private DevExpress.XtraGrid.Columns.GridColumn colSeries;
        private DevExpress.XtraGrid.Columns.GridColumn colUseByDate;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colNote1;
        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRecMast;
        private DevExpress.XtraGrid.Columns.GridColumn colNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraGrid.Columns.GridColumn colDocDate;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesSum;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesNDS;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorCreate;
        private DevExpress.XtraGrid.Columns.GridColumn colDateLastModif;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorLastModif;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreate;

        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}
