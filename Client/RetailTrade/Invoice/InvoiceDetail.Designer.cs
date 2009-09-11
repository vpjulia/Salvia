namespace RetailTradeClient.Invoice
{
    partial class InvoiceDetail
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
            this.mDataSet = new RetailTradeClient.MDataSet();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btClose = new System.Windows.Forms.ToolStripButton();
            this.PeriodsComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.btRefresh = new System.Windows.Forms.ToolStripButton();
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.invoiceDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewDetSt = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManufacturerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeries = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUseByDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriceRetailNDS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorCreate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorLastModif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateLastModif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.invoiceDetailTableAdapter = new RetailTradeClient.MDataSetTableAdapters.InvoiceDetailTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btProductReport = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetSt)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mDataSet
            // 
            this.mDataSet.DataSetName = "MDataSet";
            this.mDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 491);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(651, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btClose,
            this.PeriodsComboBox,
            this.btRefresh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(651, 26);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btClose
            // 
            this.btClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btClose.Image = global::RetailTradeClient.Properties.Resources.delete2;
            this.btClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(23, 23);
            this.btClose.Text = "X";
            this.btClose.ToolTipText = "Закрыть";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // PeriodsComboBox
            // 
            this.PeriodsComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PeriodsComboBox.MaxDropDownItems = 10;
            this.PeriodsComboBox.Name = "PeriodsComboBox";
            this.PeriodsComboBox.Size = new System.Drawing.Size(170, 26);
            this.PeriodsComboBox.ToolTipText = "Показать продажи за дату ...";
            // 
            // btRefresh
            // 
            this.btRefresh.Image = global::RetailTradeClient.Properties.Resources.refresh;
            this.btRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(95, 23);
            this.btRefresh.Text = "Обновить";
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // grid
            // 
            this.grid.ContextMenuStrip = this.contextMenuStrip1;
            this.grid.DataSource = this.invoiceDetailBindingSource;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            this.grid.EmbeddedNavigator.Name = "";
            this.grid.Location = new System.Drawing.Point(0, 26);
            this.grid.MainView = this.gridViewDetSt;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(651, 465);
            this.grid.TabIndex = 2;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDetSt});
            // 
            // invoiceDetailBindingSource
            // 
            this.invoiceDetailBindingSource.DataMember = "InvoiceDetail";
            this.invoiceDetailBindingSource.DataSource = this.mDataSet;
            // 
            // gridViewDetSt
            // 
            this.gridViewDetSt.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDate,
            this.colNumCheck,
            this.colProductName,
            this.colManufacturerName,
            this.colCountryName,
            this.colSeries,
            this.colUseByDate,
            this.colQuantity,
            this.colPriceRetailNDS,
            this.colSalesSum,
            this.colAuthorCreate,
            this.colAuthorLastModif,
            this.colDateLastModif,
            this.colDateCreate});
            this.gridViewDetSt.GridControl = this.grid;
            this.gridViewDetSt.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RetailSum", this.colSalesSum, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "", null, "")});
            this.gridViewDetSt.Name = "gridViewDetSt";
            this.gridViewDetSt.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridViewDetSt.OptionsBehavior.Editable = false;
            this.gridViewDetSt.OptionsView.ColumnAutoWidth = false;
            this.gridViewDetSt.OptionsView.ShowAutoFilterRow = true;
            this.gridViewDetSt.OptionsView.ShowFooter = true;
            this.gridViewDetSt.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNumCheck, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colDate
            // 
            this.colDate.Caption = "Дата";
            this.colDate.FieldName = "Date";
            this.colDate.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 0;
            // 
            // colNumCheck
            // 
            this.colNumCheck.Caption = "№ чека";
            this.colNumCheck.FieldName = "NumCheck";
            this.colNumCheck.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colNumCheck.Name = "colNumCheck";
            this.colNumCheck.Visible = true;
            this.colNumCheck.VisibleIndex = 1;
            this.colNumCheck.Width = 65;
            // 
            // colProductName
            // 
            this.colProductName.Caption = "Наименование";
            this.colProductName.FieldName = "ProductName";
            this.colProductName.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colProductName.Name = "colProductName";
            this.colProductName.OptionsColumn.ReadOnly = true;
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 2;
            this.colProductName.Width = 130;
            // 
            // colManufacturerName
            // 
            this.colManufacturerName.Caption = "Изготовитель";
            this.colManufacturerName.FieldName = "ManufacturerName";
            this.colManufacturerName.Name = "colManufacturerName";
            this.colManufacturerName.Visible = true;
            this.colManufacturerName.VisibleIndex = 3;
            this.colManufacturerName.Width = 86;
            // 
            // colCountryName
            // 
            this.colCountryName.Caption = "Страна";
            this.colCountryName.FieldName = "CountryName";
            this.colCountryName.Name = "colCountryName";
            this.colCountryName.Width = 55;
            // 
            // colSeries
            // 
            this.colSeries.Caption = "Серия";
            this.colSeries.FieldName = "Series";
            this.colSeries.Name = "colSeries";
            this.colSeries.Visible = true;
            this.colSeries.VisibleIndex = 4;
            this.colSeries.Width = 104;
            // 
            // colUseByDate
            // 
            this.colUseByDate.Caption = "Срок";
            this.colUseByDate.FieldName = "UseByDate";
            this.colUseByDate.Name = "colUseByDate";
            this.colUseByDate.Visible = true;
            this.colUseByDate.VisibleIndex = 5;
            this.colUseByDate.Width = 89;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Кол-во";
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 6;
            this.colQuantity.Width = 74;
            // 
            // colPriceRetailNDS
            // 
            this.colPriceRetailNDS.Caption = "Цена";
            this.colPriceRetailNDS.FieldName = "PriceRetailNDS";
            this.colPriceRetailNDS.Name = "colPriceRetailNDS";
            this.colPriceRetailNDS.Visible = true;
            this.colPriceRetailNDS.VisibleIndex = 8;
            this.colPriceRetailNDS.Width = 114;
            // 
            // colSalesSum
            // 
            this.colSalesSum.Caption = "Сумма";
            this.colSalesSum.FieldName = "RetailSum";
            this.colSalesSum.Name = "colSalesSum";
            this.colSalesSum.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colSalesSum.Visible = true;
            this.colSalesSum.VisibleIndex = 7;
            this.colSalesSum.Width = 105;
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
            // colDateLastModif
            // 
            this.colDateLastModif.Caption = "Изменен";
            this.colDateLastModif.FieldName = "DateLastModif";
            this.colDateLastModif.Name = "colDateLastModif";
            // 
            // colDateCreate
            // 
            this.colDateCreate.Caption = "Создан";
            this.colDateCreate.FieldName = "DateCreate";
            this.colDateCreate.Name = "colDateCreate";
            // 
            // invoiceDetailTableAdapter
            // 
            this.invoiceDetailTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btProductReport});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(209, 26);
            // 
            // btProductReport
            // 
            this.btProductReport.Name = "btProductReport";
            this.btProductReport.Size = new System.Drawing.Size(208, 22);
            this.btProductReport.Text = "Карточка товара";
            this.btProductReport.Click += new System.EventHandler(this.btProductReport_Click);
            // 
            // InvoiceDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "InvoiceDetail";
            this.Size = new System.Drawing.Size(651, 513);
            this.Load += new System.EventHandler(this.InvoiceDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetSt)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private MDataSet mDataSet;
        private System.Windows.Forms.ToolStripButton btClose;
        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDetSt;
        private DevExpress.XtraGrid.Columns.GridColumn colSeries;
        private DevExpress.XtraGrid.Columns.GridColumn colUseByDate;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesSum;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colManufacturerName;
        private DevExpress.XtraGrid.Columns.GridColumn colCountryName;
        private System.Windows.Forms.ToolStripComboBox PeriodsComboBox;
        private System.Windows.Forms.ToolStripButton btRefresh;
        private System.Windows.Forms.BindingSource invoiceDetailBindingSource;
        private RetailTradeClient.MDataSetTableAdapters.InvoiceDetailTableAdapter invoiceDetailTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colNumCheck;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceRetailNDS;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorCreate;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorLastModif;
        private DevExpress.XtraGrid.Columns.GridColumn colDateLastModif;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btProductReport;
    }
}
