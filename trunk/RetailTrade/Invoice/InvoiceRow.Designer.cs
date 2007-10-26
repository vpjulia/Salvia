namespace RetailTrade.Invoice
{
    partial class InvoiceRow
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
            System.Windows.Forms.Label numberLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceRow));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btEdit = new System.Windows.Forms.ToolStripButton();
            this.btClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.btField = new System.Windows.Forms.ToolStripMenuItem();
            this.btRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.btMove = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.invoiceMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mDataSet = new RetailTrade.MDataSet();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mainStocklookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.MainStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StockEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelNumber = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fieldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridInvoiceRowView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManufacturerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPricePurchase = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRetailNDS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriceRetailNDS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorCreate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorLastModif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateLastModif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.invoiceMasterTableAdapter = new RetailTrade.MDataSetTableAdapters.InvoiceMasterTableAdapter();
            this.invoiceDetailTableAdapter = new RetailTrade.MDataSetTableAdapters.InvoiceDetailTableAdapter();
            this.stockTableAdapter = new RetailTrade.MDataSetTableAdapters.StockTableAdapter();
            numberLabel = new System.Windows.Forms.Label();
            this.toolStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainStocklookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            this.panelNumber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridInvoiceRowView)).BeginInit();
            this.SuspendLayout();
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Location = new System.Drawing.Point(6, 8);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new System.Drawing.Size(26, 17);
            numberLabel.TabIndex = 0;
            numberLabel.Text = "№:";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btEdit,
            this.btClose,
            this.toolStripSplitButton1,
            this.btMove});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(797, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // btEdit
            // 
            this.btEdit.Image = ((System.Drawing.Image)(resources.GetObject("btEdit.Image")));
            this.btEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(95, 22);
            this.btEdit.Text = "Изменить";
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
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
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btField,
            this.btRefresh});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(16, 22);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            this.toolStripSplitButton1.ButtonClick += new System.EventHandler(this.toolStripSplitButton1_ButtonClick);
            // 
            // btField
            // 
            this.btField.Name = "btField";
            this.btField.Size = new System.Drawing.Size(208, 22);
            this.btField.Text = "Настройка полей";
            this.btField.Click += new System.EventHandler(this.btField_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(208, 22);
            this.btRefresh.Text = "Обновить";
            // 
            // btMove
            // 
            this.btMove.Image = ((System.Drawing.Image)(resources.GetObject("btMove.Image")));
            this.btMove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btMove.Name = "btMove";
            this.btMove.Size = new System.Drawing.Size(148, 22);
            this.btMove.Text = "Готов к отправке";
            this.btMove.Visible = false;
            this.btMove.Click += new System.EventHandler(this.btMove_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 541);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(797, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 25);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(797, 516);
            this.tabControl.TabIndex = 2;
            this.tabControl.Validating += new System.ComponentModel.CancelEventHandler(this.tabControl_Validating);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(789, 487);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Отгрузка";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.panelNumber);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grid);
            this.splitContainer1.Size = new System.Drawing.Size(783, 481);
            this.splitContainer1.SplitterDistance = 171;
            this.splitContainer1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(783, 119);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceMasterBindingSource, "MainStockRef", true));
            this.label2.Location = new System.Drawing.Point(163, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 617F));
            this.tableLayoutPanel1.Controls.Add(this.mainStocklookUpEdit, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.StockEdit, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(777, 76);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // mainStocklookUpEdit
            // 
            this.mainStocklookUpEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mainStocklookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.invoiceMasterBindingSource, "MainStockRef", true));
            this.mainStocklookUpEdit.EnterMoveNextControl = true;
            this.mainStocklookUpEdit.Location = new System.Drawing.Point(163, 31);
            this.mainStocklookUpEdit.Name = "mainStocklookUpEdit";
            this.mainStocklookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.mainStocklookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 50, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TradePupletName", "TradePupletName", 30, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.mainStocklookUpEdit.Properties.DataSource = this.MainStockBindingSource;
            this.mainStocklookUpEdit.Properties.DisplayMember = "Name";
            this.mainStocklookUpEdit.Properties.ShowHeader = false;
            this.mainStocklookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.mainStocklookUpEdit.Properties.ValueMember = "ID";
            this.mainStocklookUpEdit.Size = new System.Drawing.Size(220, 22);
            this.mainStocklookUpEdit.TabIndex = 4;
            // 
            // MainStockBindingSource
            // 
            this.MainStockBindingSource.DataMember = "Stock";
            this.MainStockBindingSource.DataSource = this.mDataSet;
            // 
            // StockEdit
            // 
            this.StockEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.StockEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.invoiceMasterBindingSource, "RemoteStockRef", true));
            this.StockEdit.EnterMoveNextControl = true;
            this.StockEdit.Location = new System.Drawing.Point(163, 3);
            this.StockEdit.Name = "StockEdit";
            this.StockEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.StockEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.StockEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 50, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TradePupletName", "TradePupletName", 30, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.StockEdit.Properties.DataSource = this.stockBindingSource;
            this.StockEdit.Properties.DisplayMember = "Name";
            this.StockEdit.Properties.HideSelection = false;
            this.StockEdit.Properties.ShowHeader = false;
            this.StockEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.StockEdit.Properties.UseCtrlScroll = true;
            this.StockEdit.Properties.ValidateOnEnterKey = true;
            this.StockEdit.Properties.ValueMember = "ID";
            this.StockEdit.Size = new System.Drawing.Size(220, 22);
            this.StockEdit.TabIndex = 2;
            this.StockEdit.EditValueChanged += new System.EventHandler(this.StockEdit_EditValueChanged);
            this.StockEdit.Popup += new System.EventHandler(this.StockEdit_Popup);
            this.StockEdit.Validated += new System.EventHandler(this.StockEdit_Validated);
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.mDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "На склад:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Со склада:";
            // 
            // panelNumber
            // 
            this.panelNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNumber.Controls.Add(this.label5);
            this.panelNumber.Controls.Add(this.dateTimePicker1);
            this.panelNumber.Controls.Add(this.label1);
            this.panelNumber.Controls.Add(numberLabel);
            this.panelNumber.Controls.Add(this.numberTextBox);
            this.panelNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNumber.Location = new System.Drawing.Point(0, 0);
            this.panelNumber.Name = "panelNumber";
            this.panelNumber.Size = new System.Drawing.Size(783, 40);
            this.panelNumber.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceMasterBindingSource, "RemoteStockRef", true));
            this.label5.Location = new System.Drawing.Point(338, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "label5";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceMasterBindingSource, "Date", true));
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoiceMasterBindingSource, "Date", true));
            this.dateTimePicker1.Location = new System.Drawing.Point(173, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 22);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2007, 6, 18, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "от";
            // 
            // numberTextBox
            // 
            this.numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceMasterBindingSource, "Number", true));
            this.numberTextBox.Location = new System.Drawing.Point(38, 7);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(100, 22);
            this.numberTextBox.TabIndex = 1;
            // 
            // grid
            // 
            this.grid.ContextMenuStrip = this.contextMenuStrip;
            this.grid.DataSource = this.invoiceDetailBindingSource;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.EmbeddedNavigator.Name = "";
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.gridInvoiceRowView;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(783, 306);
            this.grid.TabIndex = 0;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridInvoiceRowView});
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DelToolStripMenuItem,
            this.editToolStripMenuItem,
            this.fieldToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(209, 70);
            // 
            // DelToolStripMenuItem
            // 
            this.DelToolStripMenuItem.Name = "DelToolStripMenuItem";
            this.DelToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.DelToolStripMenuItem.Text = "Удалить строку";
            this.DelToolStripMenuItem.Click += new System.EventHandler(this.Del_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.editToolStripMenuItem.Text = "Изменить";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // fieldToolStripMenuItem
            // 
            this.fieldToolStripMenuItem.Name = "fieldToolStripMenuItem";
            this.fieldToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.fieldToolStripMenuItem.Text = "Настройка полей";
            this.fieldToolStripMenuItem.Click += new System.EventHandler(this.btField_Click);
            // 
            // invoiceDetailBindingSource
            // 
            this.invoiceDetailBindingSource.DataMember = "InvoiceDetail";
            this.invoiceDetailBindingSource.DataSource = this.mDataSet;
            // 
            // gridInvoiceRowView
            // 
            this.gridInvoiceRowView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colProductName,
            this.colManufacturerName,
            this.colQuantity,
            this.colPricePurchase,
            this.colRetailNDS,
            this.colPriceRetailNDS,
            this.colAuthorCreate,
            this.colAuthorLastModif,
            this.colDateCreate,
            this.colDateLastModif,
            this.colNote});
            this.gridInvoiceRowView.GridControl = this.grid;
            this.gridInvoiceRowView.Name = "gridInvoiceRowView";
            this.gridInvoiceRowView.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gridInvoiceRowView_InvalidRowException);
            // 
            // colID
            // 
            this.colID.Caption = "Код";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.ReadOnly = true;
            this.colID.Width = 43;
            // 
            // colProductName
            // 
            this.colProductName.Caption = "Наименование";
            this.colProductName.FieldName = "ProductName";
            this.colProductName.Name = "colProductName";
            this.colProductName.OptionsColumn.AllowEdit = false;
            this.colProductName.OptionsColumn.AllowFocus = false;
            this.colProductName.OptionsColumn.ReadOnly = true;
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 0;
            this.colProductName.Width = 120;
            // 
            // colManufacturerName
            // 
            this.colManufacturerName.Caption = "Изготовитель";
            this.colManufacturerName.FieldName = "ManufacturerName";
            this.colManufacturerName.Name = "colManufacturerName";
            this.colManufacturerName.OptionsColumn.AllowEdit = false;
            this.colManufacturerName.OptionsColumn.AllowFocus = false;
            this.colManufacturerName.OptionsColumn.ReadOnly = true;
            this.colManufacturerName.OptionsFilter.AllowAutoFilter = false;
            this.colManufacturerName.OptionsFilter.AllowFilter = false;
            this.colManufacturerName.Visible = true;
            this.colManufacturerName.VisibleIndex = 1;
            this.colManufacturerName.Width = 120;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Количество";
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 2;
            this.colQuantity.Width = 62;
            // 
            // colPricePurchase
            // 
            this.colPricePurchase.Caption = "Цена закупочная";
            this.colPricePurchase.FieldName = "PricePurchase";
            this.colPricePurchase.Name = "colPricePurchase";
            this.colPricePurchase.Visible = true;
            this.colPricePurchase.VisibleIndex = 3;
            this.colPricePurchase.Width = 78;
            // 
            // colRetailNDS
            // 
            this.colRetailNDS.Caption = "в т.ч. НДС";
            this.colRetailNDS.FieldName = "RetailNDS";
            this.colRetailNDS.Name = "colRetailNDS";
            this.colRetailNDS.Visible = true;
            this.colRetailNDS.VisibleIndex = 4;
            this.colRetailNDS.Width = 57;
            // 
            // colPriceRetailNDS
            // 
            this.colPriceRetailNDS.Caption = "Цена с НДС";
            this.colPriceRetailNDS.FieldName = "PriceRetailNDS";
            this.colPriceRetailNDS.Name = "colPriceRetailNDS";
            this.colPriceRetailNDS.Visible = true;
            this.colPriceRetailNDS.VisibleIndex = 5;
            this.colPriceRetailNDS.Width = 91;
            // 
            // colAuthorCreate
            // 
            this.colAuthorCreate.Caption = "Автор";
            this.colAuthorCreate.FieldName = "AuthorCreate";
            this.colAuthorCreate.Name = "colAuthorCreate";
            this.colAuthorCreate.Width = 39;
            // 
            // colAuthorLastModif
            // 
            this.colAuthorLastModif.Caption = "Редактор";
            this.colAuthorLastModif.FieldName = "AuthorLastModif";
            this.colAuthorLastModif.Name = "colAuthorLastModif";
            this.colAuthorLastModif.Width = 39;
            // 
            // colDateCreate
            // 
            this.colDateCreate.Caption = "Создан";
            this.colDateCreate.FieldName = "DateCreate";
            this.colDateCreate.Name = "colDateCreate";
            this.colDateCreate.Width = 39;
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
            this.colNote.VisibleIndex = 6;
            this.colNote.Width = 82;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(789, 487);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Заявки";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // invoiceMasterTableAdapter
            // 
            this.invoiceMasterTableAdapter.ClearBeforeFill = true;
            // 
            // invoiceDetailTableAdapter
            // 
            this.invoiceDetailTableAdapter.ClearBeforeFill = true;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // InvoiceRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Name = "InvoiceRow";
            this.Size = new System.Drawing.Size(797, 563);
            this.Load += new System.EventHandler(this.InvoiceRow_Load);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.InvoiceRow_Validating);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainStocklookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            this.panelNumber.ResumeLayout(false);
            this.panelNumber.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridInvoiceRowView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.LookUpEdit StockEdit;
        private System.Windows.Forms.Panel panelNumber;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberTextBox;
        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridInvoiceRowView;
        private System.Windows.Forms.BindingSource invoiceMasterBindingSource;
        private MDataSet mDataSet;
        private RetailTrade.MDataSetTableAdapters.InvoiceMasterTableAdapter invoiceMasterTableAdapter;

        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colPricePurchase;
        private DevExpress.XtraGrid.Columns.GridColumn colRetailNDS;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceRetailNDS;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorCreate;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorLastModif;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreate;
        private System.Windows.Forms.BindingSource invoiceDetailBindingSource;
        private RetailTrade.MDataSetTableAdapters.InvoiceDetailTableAdapter invoiceDetailTableAdapter;
        private System.Windows.Forms.ToolStripButton btEdit;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem btField;
        private System.Windows.Forms.ToolStripMenuItem btRefresh;
        private System.Windows.Forms.ToolStripButton btClose;
        private DevExpress.XtraGrid.Columns.GridColumn colDateLastModif;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colManufacturerName;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private RetailTrade.MDataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private System.Windows.Forms.BindingSource MainStockBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.LookUpEdit mainStocklookUpEdit;
        private System.Windows.Forms.ToolStripButton btMove;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem DelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fieldToolStripMenuItem;
       
    }
}
