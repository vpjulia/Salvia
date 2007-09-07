namespace RetailTrade.Receipt
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode3 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiptMasterStock));
            this.gridViewRecieptDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManufacturerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPricePurchase = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCalcPurchSum1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeries = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUseByDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorCreate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorLastModif1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateLastModif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.receiptMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mDataSet = new RetailTrade.MDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrganizationRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OrganizationLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.organizationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCalcPurchSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurchNDS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsReadOnly = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorCreate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorLastModif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridViewRecInvDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTradePupletName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumber1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriceRetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridViewRecDetPrices = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOrganizationName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPricePurchase1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btClose = new System.Windows.Forms.ToolStripButton();
            this.organizationTableAdapter = new RetailTrade.MDataSetTableAdapters.OrganizationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRecieptDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrganizationLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRecInvDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRecDetPrices)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridViewRecieptDetail
            // 
            this.gridViewRecieptDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductName,
            this.colManufacturerName,
            this.colQuantity,
            this.colPricePurchase,
            this.colCalcPurchSum1,
            this.colSeries,
            this.colUseByDate,
            this.colNote1,
            this.colAuthorCreate1,
            this.colAuthorLastModif1,
            this.colDateCreate1,
            this.colDateLastModif});
            this.gridViewRecieptDetail.GridControl = this.gridControl1;
            this.gridViewRecieptDetail.Name = "gridViewRecieptDetail";
            this.gridViewRecieptDetail.OptionsDetail.AllowExpandEmptyDetails = true;
            this.gridViewRecieptDetail.OptionsDetail.AllowOnlyOneMasterRowExpanded = true;
            this.gridViewRecieptDetail.OptionsDetail.SmartDetailExpandButton = false;
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
            // colPricePurchase
            // 
            this.colPricePurchase.Caption = "Цена без НДС";
            this.colPricePurchase.DisplayFormat.FormatString = "#.#####";
            this.colPricePurchase.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPricePurchase.FieldName = "PricePurchase";
            this.colPricePurchase.Name = "colPricePurchase";
            this.colPricePurchase.Visible = true;
            this.colPricePurchase.VisibleIndex = 3;
            // 
            // colCalcPurchSum1
            // 
            this.colCalcPurchSum1.Caption = "Сумма без НДС";
            this.colCalcPurchSum1.DisplayFormat.FormatString = "#0.00###";
            this.colCalcPurchSum1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCalcPurchSum1.FieldName = "CalcPurchSum";
            this.colCalcPurchSum1.Name = "colCalcPurchSum1";
            this.colCalcPurchSum1.OptionsColumn.AllowEdit = false;
            this.colCalcPurchSum1.OptionsColumn.AllowFocus = false;
            this.colCalcPurchSum1.OptionsColumn.ReadOnly = true;
            this.colCalcPurchSum1.OptionsFilter.AllowAutoFilter = false;
            this.colCalcPurchSum1.OptionsFilter.AllowFilter = false;
            this.colCalcPurchSum1.Visible = true;
            this.colCalcPurchSum1.VisibleIndex = 4;
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
            // gridControl1
            // 
            this.gridControl1.DataSource = this.receiptMasterBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Name = "";
            gridLevelNode1.LevelTemplate = this.gridViewRecieptDetail;
            gridLevelNode2.LevelTemplate = this.gridViewRecInvDetail;
            gridLevelNode2.RelationName = "ReceiptDetail_InvoiceDetail";
            gridLevelNode3.LevelTemplate = this.gridViewRecDetPrices;
            gridLevelNode3.RelationName = "ReceiptDetail_PricesPurchase";
            gridLevelNode1.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2,
            gridLevelNode3});
            gridLevelNode1.RelationName = "ReceiptMaster_ReceiptDetail";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(0, 25);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.OrganizationLookUpEdit});
            this.gridControl1.ShowOnlyPredefinedDetails = true;
            this.gridControl1.Size = new System.Drawing.Size(679, 411);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridViewRecInvDetail,
            this.gridViewRecDetPrices,
            this.gridViewRecieptDetail});
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
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNumber,
            this.colDocDate,
            this.colOrganizationRef,
            this.colNote,
            this.colCalcPurchSum,
            this.colPurchNDS,
            this.colIsReadOnly,
            this.colAuthorCreate,
            this.colAuthorLastModif,
            this.colDateCreate});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.AllowOnlyOneMasterRowExpanded = true;
            this.gridView1.OptionsView.ShowFooter = true;
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
            // colOrganizationRef
            // 
            this.colOrganizationRef.Caption = "Поставщик";
            this.colOrganizationRef.ColumnEdit = this.OrganizationLookUpEdit;
            this.colOrganizationRef.FieldName = "OrganizationRef";
            this.colOrganizationRef.Name = "colOrganizationRef";
            this.colOrganizationRef.Visible = true;
            this.colOrganizationRef.VisibleIndex = 3;
            // 
            // OrganizationLookUpEdit
            // 
            this.OrganizationLookUpEdit.AutoHeight = false;
            this.OrganizationLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.OrganizationLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ShortName", "ShortName", 70, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.OrganizationLookUpEdit.DataSource = this.organizationBindingSource;
            this.OrganizationLookUpEdit.DisplayMember = "ShortName";
            this.OrganizationLookUpEdit.Name = "OrganizationLookUpEdit";
            this.OrganizationLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.OrganizationLookUpEdit.ValueMember = "ID";
            // 
            // organizationBindingSource
            // 
            this.organizationBindingSource.DataMember = "Organization";
            this.organizationBindingSource.DataSource = this.mDataSet;
            // 
            // colNote
            // 
            this.colNote.Caption = "Примечание";
            this.colNote.FieldName = "Note";
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 1;
            // 
            // colCalcPurchSum
            // 
            this.colCalcPurchSum.Caption = "Сумма без НДС";
            this.colCalcPurchSum.FieldName = "CalcPurchSum";
            this.colCalcPurchSum.Name = "colCalcPurchSum";
            this.colCalcPurchSum.OptionsColumn.AllowEdit = false;
            this.colCalcPurchSum.OptionsColumn.AllowFocus = false;
            this.colCalcPurchSum.OptionsColumn.ReadOnly = true;
            this.colCalcPurchSum.Visible = true;
            this.colCalcPurchSum.VisibleIndex = 5;
            // 
            // colPurchNDS
            // 
            this.colPurchNDS.Caption = "НДС";
            this.colPurchNDS.FieldName = "PurchNDS";
            this.colPurchNDS.Name = "colPurchNDS";
            this.colPurchNDS.OptionsColumn.AllowEdit = false;
            this.colPurchNDS.OptionsColumn.AllowFocus = false;
            this.colPurchNDS.OptionsColumn.ReadOnly = true;
            this.colPurchNDS.Visible = true;
            this.colPurchNDS.VisibleIndex = 4;
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
            // gridViewRecInvDetail
            // 
            this.gridViewRecInvDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTradePupletName,
            this.colNumber1,
            this.colDate,
            this.colQuantity1,
            this.colPriceRetail,
            this.colNote2});
            this.gridViewRecInvDetail.GridControl = this.gridControl1;
            this.gridViewRecInvDetail.Name = "gridViewRecInvDetail";
            this.gridViewRecInvDetail.OptionsBehavior.Editable = false;
            this.gridViewRecInvDetail.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewRecInvDetail.ViewCaption = "Продажи";
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
            // colPriceRetail
            // 
            this.colPriceRetail.Caption = "Цена розничная";
            this.colPriceRetail.DisplayFormat.FormatString = "#.##";
            this.colPriceRetail.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPriceRetail.FieldName = "PriceRetail";
            this.colPriceRetail.Name = "colPriceRetail";
            this.colPriceRetail.Visible = true;
            this.colPriceRetail.VisibleIndex = 4;
            this.colPriceRetail.Width = 132;
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
            this.gridViewRecDetPrices.GridControl = this.gridControl1;
            this.gridViewRecDetPrices.Name = "gridViewRecDetPrices";
            this.gridViewRecDetPrices.OptionsBehavior.Editable = false;
            this.gridViewRecDetPrices.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewRecDetPrices.OptionsView.ShowChildrenInGroupPanel = true;
            this.gridViewRecDetPrices.ViewCaption = "Цены";
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
            this.statusStrip.Location = new System.Drawing.Point(0, 436);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(679, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(679, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btClose
            // 
            this.btClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btClose.Image = ((System.Drawing.Image)(resources.GetObject("btClose.Image")));
            this.btClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(23, 22);
            this.btClose.Text = "x";
            // 
            // organizationTableAdapter
            // 
            this.organizationTableAdapter.ClearBeforeFill = true;
            // 
            // ReceiptMasterStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip);
            this.Name = "ReceiptMasterStock";
            this.Size = new System.Drawing.Size(679, 458);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRecieptDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrganizationLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource organizationBindingSource;
        private RetailTrade.MDataSetTableAdapters.OrganizationTableAdapter organizationTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRecieptDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRecInvDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRecDetPrices;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraGrid.Columns.GridColumn colDocDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchNDS;
        private DevExpress.XtraGrid.Columns.GridColumn colIsReadOnly;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorCreate;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorLastModif;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreate;
        private DevExpress.XtraGrid.Columns.GridColumn colCalcPurchSum;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colManufacturerName;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colPricePurchase;
        private DevExpress.XtraGrid.Columns.GridColumn colCalcPurchSum1;
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
        private DevExpress.XtraGrid.Columns.GridColumn colPriceRetail;
        private DevExpress.XtraGrid.Columns.GridColumn colNote2;
        private DevExpress.XtraGrid.Columns.GridColumn colOrganizationName1;
        private DevExpress.XtraGrid.Columns.GridColumn colDate1;
        private DevExpress.XtraGrid.Columns.GridColumn colPricePurchase1;
        private DevExpress.XtraGrid.Columns.GridColumn colOrganizationRef;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit OrganizationLookUpEdit;
        private System.Windows.Forms.ToolStripButton btClose;
    }
}
