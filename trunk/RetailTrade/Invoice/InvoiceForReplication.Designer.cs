namespace RetailTrade.Invoice
{
    partial class InvoiceForReplication
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
            this.gridViewInvRepDet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManufacturerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriceRetailNDS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRetailNDS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCalcSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.invoiceMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mDataSet = new RetailTrade.MDataSet();
            this.gridViewInvRepl = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNds = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorCreate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorLastModif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateLastModif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTradePupletName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btClose = new System.Windows.Forms.ToolStripButton();
            this.btMakeNew = new System.Windows.Forms.ToolStripButton();
            this.invoiceMasterTableAdapter = new RetailTrade.MDataSetTableAdapters.InvoiceMasterTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInvRepDet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInvRepl)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridViewInvRepDet
            // 
            this.gridViewInvRepDet.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductName,
            this.colManufacturerName,
            this.colQuantity,
            this.colPriceRetailNDS,
            this.colNote1,
            this.colRetailNDS,
            this.colCalcSum});
            this.gridViewInvRepDet.GridControl = this.grid;
            this.gridViewInvRepDet.Name = "gridViewInvRepDet";
            this.gridViewInvRepDet.OptionsView.ColumnAutoWidth = false;
            this.gridViewInvRepDet.OptionsView.ShowFooter = true;
            this.gridViewInvRepDet.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colProductName, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colProductName
            // 
            this.colProductName.Caption = "Наименование";
            this.colProductName.FieldName = "ProductName";
            this.colProductName.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colProductName.Name = "colProductName";
            this.colProductName.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText;
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 0;
            // 
            // colManufacturerName
            // 
            this.colManufacturerName.Caption = "Изготовитель";
            this.colManufacturerName.FieldName = "ManufacturerName";
            this.colManufacturerName.Name = "colManufacturerName";
            this.colManufacturerName.Visible = true;
            this.colManufacturerName.VisibleIndex = 1;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Кол-во";
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 2;
            // 
            // colPriceRetailNDS
            // 
            this.colPriceRetailNDS.Caption = "Цена";
            this.colPriceRetailNDS.FieldName = "PriceRetailNDS";
            this.colPriceRetailNDS.Name = "colPriceRetailNDS";
            this.colPriceRetailNDS.Visible = true;
            this.colPriceRetailNDS.VisibleIndex = 6;
            this.colPriceRetailNDS.Width = 235;
            // 
            // colNote1
            // 
            this.colNote1.Caption = "Note";
            this.colNote1.FieldName = "Note";
            this.colNote1.Name = "colNote1";
            this.colNote1.Visible = true;
            this.colNote1.VisibleIndex = 3;
            // 
            // colRetailNDS
            // 
            this.colRetailNDS.Caption = "в т.ч. НДС";
            this.colRetailNDS.FieldName = "RetailNDS";
            this.colRetailNDS.Name = "colRetailNDS";
            this.colRetailNDS.SummaryItem.DisplayFormat = "{0:##0.00}";
            this.colRetailNDS.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colRetailNDS.Visible = true;
            this.colRetailNDS.VisibleIndex = 4;
            this.colRetailNDS.Width = 128;
            // 
            // colCalcSum
            // 
            this.colCalcSum.Caption = "Сумма";
            this.colCalcSum.FieldName = "CalcSum";
            this.colCalcSum.Name = "colCalcSum";
            this.colCalcSum.SummaryItem.DisplayFormat = "{0:##0.00}";
            this.colCalcSum.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colCalcSum.Visible = true;
            this.colCalcSum.VisibleIndex = 5;
            this.colCalcSum.Width = 156;
            // 
            // grid
            // 
            this.grid.DataSource = this.invoiceMasterBindingSource;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.EmbeddedNavigator.Name = "";
            gridLevelNode1.LevelTemplate = this.gridViewInvRepDet;
            gridLevelNode1.RelationName = "FK_InvoiceDetail_InvoiceMaster";
            this.grid.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grid.Location = new System.Drawing.Point(0, 25);
            this.grid.MainView = this.gridViewInvRepl;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(742, 505);
            this.grid.TabIndex = 2;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewInvRepl,
            this.gridViewInvRepDet});
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
            // gridViewInvRepl
            // 
            this.gridViewInvRepl.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNumber,
            this.colDate,
            this.colSum,
            this.colNds,
            this.colAuthorCreate,
            this.colAuthorLastModif,
            this.colDateCreate,
            this.colDateLastModif,
            this.colNote,
            this.colTradePupletName});
            this.gridViewInvRepl.GridControl = this.grid;
            this.gridViewInvRepl.Name = "gridViewInvRepl";
            this.gridViewInvRepl.OptionsView.ShowFooter = true;
            // 
            // colNumber
            // 
            this.colNumber.Caption = "№";
            this.colNumber.FieldName = "Number";
            this.colNumber.Name = "colNumber";
            this.colNumber.Visible = true;
            this.colNumber.VisibleIndex = 0;
            // 
            // colDate
            // 
            this.colDate.Caption = "Дата";
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 1;
            // 
            // colSum
            // 
            this.colSum.Caption = "Сумма";
            this.colSum.FieldName = "Sum";
            this.colSum.Name = "colSum";
            this.colSum.SummaryItem.DisplayFormat = "{0:##0.00}";
            this.colSum.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colSum.Visible = true;
            this.colSum.VisibleIndex = 3;
            // 
            // colNds
            // 
            this.colNds.Caption = "НДС";
            this.colNds.FieldName = "Nds";
            this.colNds.Name = "colNds";
            this.colNds.SummaryItem.DisplayFormat = "{0:##0.00}";
            this.colNds.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
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
            // 
            // colTradePupletName
            // 
            this.colTradePupletName.Caption = "Торговая точка";
            this.colTradePupletName.FieldName = "TradePupletName";
            this.colTradePupletName.Name = "colTradePupletName";
            this.colTradePupletName.OptionsColumn.ReadOnly = true;
            this.colTradePupletName.Visible = true;
            this.colTradePupletName.VisibleIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btClose,
            this.btMakeNew});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(742, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btClose
            // 
            this.btClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btClose.Image = global::RetailTrade.Properties.Resources.delete2;
            this.btClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(23, 22);
            this.btClose.Text = "X";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btMakeNew
            // 
            this.btMakeNew.Image = global::RetailTrade.Properties.Resources.document_stop;
            this.btMakeNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btMakeNew.Name = "btMakeNew";
            this.btMakeNew.Size = new System.Drawing.Size(149, 22);
            this.btMakeNew.Text = "Вернуть на склад";
            this.btMakeNew.ToolTipText = "Отменить готов к отправке";
            this.btMakeNew.Click += new System.EventHandler(this.btMakeNew_Click);
            // 
            // invoiceMasterTableAdapter
            // 
            this.invoiceMasterTableAdapter.ClearBeforeFill = true;
            // 
            // InvoiceForReplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Controls.Add(this.toolStrip1);
            this.Name = "InvoiceForReplication";
            this.Size = new System.Drawing.Size(742, 530);
            this.Load += new System.EventHandler(this.InvoiceForReplication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInvRepDet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInvRepl)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private DevExpress.XtraGrid.GridControl grid;
        private System.Windows.Forms.BindingSource invoiceMasterBindingSource;
        private MDataSet mDataSet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewInvRepDet;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colManufacturerName;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colNote1;
        private DevExpress.XtraGrid.Columns.GridColumn colRetailNDS;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewInvRepl;
        private DevExpress.XtraGrid.Columns.GridColumn colNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colSum;
        private DevExpress.XtraGrid.Columns.GridColumn colNds;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorCreate;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorLastModif;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreate;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraGrid.Columns.GridColumn colDateLastModif;
        private DevExpress.XtraGrid.Columns.GridColumn colTradePupletName;
        private RetailTrade.MDataSetTableAdapters.InvoiceMasterTableAdapter invoiceMasterTableAdapter;
        private System.Windows.Forms.ToolStripButton btClose;
        private System.Windows.Forms.ToolStripButton btMakeNew;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceRetailNDS;
        private DevExpress.XtraGrid.Columns.GridColumn colCalcSum;
    }
}
