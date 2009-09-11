namespace RetailTradeClient.Invoice.InvoiceTradePutlet
{
    partial class InvoiceTradePutletAll
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
            this.gridViewInvDetAll = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeries = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUseByDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriceRetailNDS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRetailNDS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRetailSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManufacturerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cbAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.btDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mDataSet = new RetailTradeClient.MDataSet();
            this.gridViewInvAll = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNds = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorCreate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorLastModif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateLastModif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.LabelLastSum = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelCashCustomer = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.LableChanges = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btAdd = new System.Windows.Forms.ToolStripButton();
            this.btOpen = new System.Windows.Forms.ToolStripButton();
            this.btClose = new System.Windows.Forms.ToolStripButton();
            this.cashBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cashTableAdapter = new RetailTradeClient.MDataSetTableAdapters.CashTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btClosePanel = new System.Windows.Forms.Button();
            this.btProductReport = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInvDetAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInvAll)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridViewInvDetAll
            // 
            this.gridViewInvDetAll.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductName,
            this.colSeries,
            this.colUseByDate,
            this.colQuantity,
            this.colPriceRetailNDS,
            this.colRetailNDS,
            this.colRetailSum,
            this.colManufacturerName});
            this.gridViewInvDetAll.GridControl = this.grid;
            this.gridViewInvDetAll.Name = "gridViewInvDetAll";
            this.gridViewInvDetAll.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridViewInvDetAll.OptionsBehavior.Editable = false;
            this.gridViewInvDetAll.OptionsView.ShowFooter = true;
            this.gridViewInvDetAll.OptionsView.ShowGroupPanel = false;
            this.gridViewInvDetAll.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridViewInvDetAll_CustomDrawCell);
            // 
            // colProductName
            // 
            this.colProductName.Caption = "Наименование";
            this.colProductName.FieldName = "ProductName";
            this.colProductName.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colProductName.Name = "colProductName";
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 0;
            this.colProductName.Width = 156;
            // 
            // colSeries
            // 
            this.colSeries.Caption = "Series";
            this.colSeries.FieldName = "Series";
            this.colSeries.Name = "colSeries";
            this.colSeries.Width = 69;
            // 
            // colUseByDate
            // 
            this.colUseByDate.Caption = "UseByDate";
            this.colUseByDate.FieldName = "UseByDate";
            this.colUseByDate.Name = "colUseByDate";
            this.colUseByDate.Visible = true;
            this.colUseByDate.VisibleIndex = 3;
            this.colUseByDate.Width = 85;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Кол-во";
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 2;
            this.colQuantity.Width = 79;
            // 
            // colPriceRetailNDS
            // 
            this.colPriceRetailNDS.Caption = "Цена";
            this.colPriceRetailNDS.FieldName = "PriceRetailNDS";
            this.colPriceRetailNDS.Name = "colPriceRetailNDS";
            this.colPriceRetailNDS.Visible = true;
            this.colPriceRetailNDS.VisibleIndex = 4;
            this.colPriceRetailNDS.Width = 79;
            // 
            // colRetailNDS
            // 
            this.colRetailNDS.Caption = "НДС";
            this.colRetailNDS.FieldName = "RetailNDS";
            this.colRetailNDS.Name = "colRetailNDS";
            this.colRetailNDS.Visible = true;
            this.colRetailNDS.VisibleIndex = 5;
            this.colRetailNDS.Width = 79;
            // 
            // colRetailSum
            // 
            this.colRetailSum.Caption = "Сумма";
            this.colRetailSum.FieldName = "RetailSum";
            this.colRetailSum.Name = "colRetailSum";
            this.colRetailSum.SummaryItem.DisplayFormat = "{0:#####.00}";
            this.colRetailSum.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colRetailSum.Visible = true;
            this.colRetailSum.VisibleIndex = 6;
            this.colRetailSum.Width = 86;
            // 
            // colManufacturerName
            // 
            this.colManufacturerName.Caption = "Изготовитель";
            this.colManufacturerName.FieldName = "ManufacturerName";
            this.colManufacturerName.Name = "colManufacturerName";
            this.colManufacturerName.Visible = true;
            this.colManufacturerName.VisibleIndex = 1;
            this.colManufacturerName.Width = 150;
            // 
            // grid
            // 
            this.grid.ContextMenuStrip = this.contextMenuStrip1;
            this.grid.DataSource = this.invoiceMasterBindingSource;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            this.grid.EmbeddedNavigator.Name = "";
            gridLevelNode1.LevelTemplate = this.gridViewInvDetAll;
            gridLevelNode1.RelationName = "FK_InvoiceDetail_InvoiceMaster";
            this.grid.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grid.Location = new System.Drawing.Point(0, 25);
            this.grid.MainView = this.gridViewInvAll;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(730, 441);
            this.grid.TabIndex = 2;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewInvAll,
            this.gridViewInvDetAll});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbAdd,
            this.btDelete,
            this.btProductReport});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(209, 92);
            // 
            // cbAdd
            // 
            this.cbAdd.Image = global::RetailTradeClient.Properties.Resources.document_add;
            this.cbAdd.Name = "cbAdd";
            this.cbAdd.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this.cbAdd.Size = new System.Drawing.Size(208, 22);
            this.cbAdd.Text = "Новый";
            this.cbAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btDelete
            // 
            this.btDelete.Image = global::RetailTradeClient.Properties.Resources.document_delete;
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(208, 22);
            this.btDelete.Text = "Удалить";
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // invoiceMasterBindingSource
            // 
            this.invoiceMasterBindingSource.DataMember = "InvoiceMaster";
            this.invoiceMasterBindingSource.DataSource = this.mDataSet;
            // 
            // mDataSet
            // 
            this.mDataSet.DataSetName = "MDataSet";
            this.mDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewInvAll
            // 
            this.gridViewInvAll.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNumber,
            this.colNumCheck,
            this.colDate,
            this.colSum,
            this.colNds,
            this.colAuthorCreate,
            this.colAuthorLastModif,
            this.colDateCreate,
            this.colDateLastModif,
            this.colNote});
            this.gridViewInvAll.GridControl = this.grid;
            this.gridViewInvAll.Name = "gridViewInvAll";
            this.gridViewInvAll.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridViewInvAll.OptionsBehavior.Editable = false;
            this.gridViewInvAll.OptionsDetail.AllowOnlyOneMasterRowExpanded = true;
            this.gridViewInvAll.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewInvAll.OptionsView.ShowFooter = true;
            this.gridViewInvAll.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridViewInvAll_CustomDrawCell);
            // 
            // colNumber
            // 
            this.colNumber.Caption = "№";
            this.colNumber.FieldName = "Number";
            this.colNumber.Name = "colNumber";
            this.colNumber.Visible = true;
            this.colNumber.VisibleIndex = 0;
            // 
            // colNumCheck
            // 
            this.colNumCheck.Caption = "№ чека";
            this.colNumCheck.FieldName = "NumCheck";
            this.colNumCheck.Name = "colNumCheck";
            this.colNumCheck.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            this.colNumCheck.Visible = true;
            this.colNumCheck.VisibleIndex = 1;
            // 
            // colDate
            // 
            this.colDate.Caption = "Дата";
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 2;
            // 
            // colSum
            // 
            this.colSum.Caption = "Сумма";
            this.colSum.FieldName = "Sum";
            this.colSum.Name = "colSum";
            this.colSum.SummaryItem.DisplayFormat = "{0:#####.00}";
            this.colSum.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colSum.Visible = true;
            this.colSum.VisibleIndex = 3;
            // 
            // colNds
            // 
            this.colNds.Caption = "в т.ч НДС";
            this.colNds.FieldName = "Nds";
            this.colNds.Name = "colNds";
            this.colNds.Visible = true;
            this.colNds.VisibleIndex = 4;
            // 
            // colAuthorCreate
            // 
            this.colAuthorCreate.Caption = "Автор";
            this.colAuthorCreate.FieldName = "AuthorCreate";
            this.colAuthorCreate.Name = "colAuthorCreate";
            // 
            // colAuthorLastModif
            // 
            this.colAuthorLastModif.Caption = "Редактор";
            this.colAuthorLastModif.FieldName = "AuthorLastModif";
            this.colAuthorLastModif.Name = "colAuthorLastModif";
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
            // colNote
            // 
            this.colNote.Caption = "Примечание";
            this.colNote.FieldName = "Note";
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 5;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.LabelLastSum,
            this.toolStripStatusLabel2,
            this.labelCashCustomer,
            this.toolStripStatusLabel3,
            this.LableChanges});
            this.statusStrip1.Location = new System.Drawing.Point(0, 491);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(730, 23);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Tahoma", 8.400001F, System.Drawing.FontStyle.Italic);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(119, 18);
            this.toolStripStatusLabel1.Text = "Последний чек: ";
            // 
            // LabelLastSum
            // 
            this.LabelLastSum.Font = new System.Drawing.Font("Tahoma", 8.400001F, System.Drawing.FontStyle.Bold);
            this.LabelLastSum.Name = "LabelLastSum";
            this.LabelLastSum.Size = new System.Drawing.Size(12, 18);
            this.LabelLastSum.Text = " ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Tahoma", 8.400001F, System.Drawing.FontStyle.Italic);
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(94, 18);
            this.toolStripStatusLabel2.Text = "Наличность:";
            // 
            // labelCashCustomer
            // 
            this.labelCashCustomer.Font = new System.Drawing.Font("Tahoma", 8.400001F, System.Drawing.FontStyle.Bold);
            this.labelCashCustomer.Name = "labelCashCustomer";
            this.labelCashCustomer.Size = new System.Drawing.Size(12, 18);
            this.labelCashCustomer.Text = " ";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Tahoma", 8.400001F, System.Drawing.FontStyle.Italic);
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(54, 18);
            this.toolStripStatusLabel3.Text = "Сдача:";
            // 
            // LableChanges
            // 
            this.LableChanges.Font = new System.Drawing.Font("Tahoma", 8.400001F, System.Drawing.FontStyle.Bold);
            this.LableChanges.Name = "LableChanges";
            this.LableChanges.Size = new System.Drawing.Size(12, 18);
            this.LableChanges.Text = " ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btAdd,
            this.btOpen,
            this.btClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(730, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btAdd
            // 
            this.btAdd.Image = global::RetailTradeClient.Properties.Resources.document_add;
            this.btAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(72, 22);
            this.btAdd.Text = "Новый";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btOpen
            // 
            this.btOpen.Image = global::RetailTradeClient.Properties.Resources.document_down;
            this.btOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(88, 22);
            this.btOpen.Text = "Открыть";
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
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
            this.btClose.ToolTipText = "Выйти";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 466);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 25);
            this.panel1.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Info;
            this.tableLayoutPanel1.ColumnCount = 11;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label10, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.btClosePanel, 10, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(728, 23);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Z";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cashBindingSource, "NumZ", true));
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(76, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "На начало дня:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cashBindingSource, "BalanceBegin", true));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(176, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "label10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Получено:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cashBindingSource, "Income", true));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(308, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(361, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Инкассация:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cashBindingSource, "OfExpend", true));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(446, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(499, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "В кассе:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cashBindingSource, "BalanceEnd", true));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(558, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "label9";
            // 
            // btClosePanel
            // 
            this.btClosePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btClosePanel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClosePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btClosePanel.Location = new System.Drawing.Point(704, 3);
            this.btClosePanel.Name = "btClosePanel";
            this.btClosePanel.Size = new System.Drawing.Size(21, 17);
            this.btClosePanel.TabIndex = 10;
            this.btClosePanel.Text = "X";
            this.btClosePanel.UseVisualStyleBackColor = true;
            this.btClosePanel.Click += new System.EventHandler(this.btClosePanel_Click);
            // 
            // btProductReport
            // 
            this.btProductReport.Name = "btProductReport";
            this.btProductReport.Size = new System.Drawing.Size(208, 22);
            this.btProductReport.Text = "Карточка товара";
            this.btProductReport.Click += new System.EventHandler(this.btProductReport_Click);
            // 
            // InvoiceTradePutletAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "InvoiceTradePutletAll";
            this.Size = new System.Drawing.Size(730, 514);
            this.Load += new System.EventHandler(this.InvoiceTradePutletAll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInvDetAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInvAll)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private DevExpress.XtraGrid.GridControl grid;
        private System.Windows.Forms.BindingSource invoiceMasterBindingSource;
        private MDataSet mDataSet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewInvAll;
        private DevExpress.XtraGrid.Columns.GridColumn colNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colSum;
        private DevExpress.XtraGrid.Columns.GridColumn colNds;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorCreate;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorLastModif;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreate;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private System.Windows.Forms.ToolStripButton btAdd;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewInvDetAll;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceRetailNDS;
        private DevExpress.XtraGrid.Columns.GridColumn colRetailNDS;
        private DevExpress.XtraGrid.Columns.GridColumn colRetailSum;
        private DevExpress.XtraGrid.Columns.GridColumn colNumCheck;
        private System.Windows.Forms.BindingSource cashBindingSource;
        private RetailTradeClient.MDataSetTableAdapters.CashTableAdapter cashTableAdapter;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        public System.Windows.Forms.ToolStripStatusLabel LabelLastSum;
        public System.Windows.Forms.ToolStripStatusLabel labelCashCustomer;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        public System.Windows.Forms.ToolStripStatusLabel LableChanges;
        private System.Windows.Forms.ToolStripButton btOpen;
        private System.Windows.Forms.ToolStripButton btClose;
        private DevExpress.XtraGrid.Columns.GridColumn colDateLastModif;
        private DevExpress.XtraGrid.Columns.GridColumn colSeries;
        private DevExpress.XtraGrid.Columns.GridColumn colUseByDate;
        private DevExpress.XtraGrid.Columns.GridColumn colManufacturerName;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btClosePanel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cbAdd;
        private System.Windows.Forms.ToolStripMenuItem btDelete;
        private System.Windows.Forms.ToolStripMenuItem btProductReport;
    }
}
