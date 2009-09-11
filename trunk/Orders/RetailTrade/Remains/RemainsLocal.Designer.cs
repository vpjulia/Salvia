namespace RetailTradeOrders.Remains
{
    partial class RemainsLocal
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btClose = new System.Windows.Forms.ToolStripButton();
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.remainsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mDataSet = new RetailTradeOrders.MDataSet();
            this.gridViewRemMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManufacturerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeries = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUseByDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantityRemains = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPricePurchase = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorLastModif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateLastModif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSumRemains = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new RetailTradeOrders.MDataSetTableAdapters.ProductTableAdapter();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remainsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRemMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 484);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(707, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(707, 25);
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
            this.btClose.Size = new System.Drawing.Size(23, 22);
            this.btClose.Text = "X";
            this.btClose.ToolTipText = "Закрыть";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // grid
            // 
            this.grid.DataSource = this.remainsBindingSource;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.EmbeddedNavigator.Name = "";
            this.grid.Location = new System.Drawing.Point(0, 25);
            this.grid.MainView = this.gridViewRemMain;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ProductLookUpEdit});
            this.grid.Size = new System.Drawing.Size(707, 459);
            this.grid.TabIndex = 2;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRemMain});
            // 
            // remainsBindingSource
            // 
            this.remainsBindingSource.DataMember = "Remains";
            this.remainsBindingSource.DataSource = this.mDataSet;
            // 
            // mDataSet
            // 
            this.mDataSet.DataSetName = "MDataSet";
            this.mDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewRemMain
            // 
            this.gridViewRemMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductName,
            this.colManufacturerName,
            this.colCountryName,
            this.colSeries,
            this.colUseByDate,
            this.colQuantityRemains,
            this.colPricePurchase,
            this.colDocDate,
            this.colAuthorLastModif,
            this.colDateLastModif,
            this.colSumRemains});
            this.gridViewRemMain.GridControl = this.grid;
            this.gridViewRemMain.Name = "gridViewRemMain";
            this.gridViewRemMain.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridViewRemMain.OptionsBehavior.Editable = false;
            this.gridViewRemMain.OptionsView.ColumnAutoWidth = false;
            this.gridViewRemMain.OptionsView.ShowAutoFilterRow = true;
            this.gridViewRemMain.OptionsView.ShowFooter = true;
            this.gridViewRemMain.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridViewRemMain_CustomDrawCell);
            // 
            // colProductName
            // 
            this.colProductName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colProductName.AppearanceCell.Options.UseFont = true;
            this.colProductName.Caption = "Наименование";
            this.colProductName.FieldName = "ProductName";
            this.colProductName.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colProductName.Name = "colProductName";
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 0;
            this.colProductName.Width = 119;
            // 
            // colManufacturerName
            // 
            this.colManufacturerName.Caption = "Производитель";
            this.colManufacturerName.FieldName = "ManufacturerName";
            this.colManufacturerName.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colManufacturerName.Name = "colManufacturerName";
            this.colManufacturerName.Visible = true;
            this.colManufacturerName.VisibleIndex = 1;
            this.colManufacturerName.Width = 56;
            // 
            // colCountryName
            // 
            this.colCountryName.Caption = "Страна";
            this.colCountryName.FieldName = "CountryName";
            this.colCountryName.Name = "colCountryName";
            this.colCountryName.Visible = true;
            this.colCountryName.VisibleIndex = 2;
            this.colCountryName.Width = 53;
            // 
            // colSeries
            // 
            this.colSeries.Caption = "Серия";
            this.colSeries.FieldName = "Series";
            this.colSeries.Name = "colSeries";
            this.colSeries.Visible = true;
            this.colSeries.VisibleIndex = 6;
            this.colSeries.Width = 57;
            // 
            // colUseByDate
            // 
            this.colUseByDate.Caption = "Срок";
            this.colUseByDate.FieldName = "UseByDate";
            this.colUseByDate.Name = "colUseByDate";
            this.colUseByDate.Visible = true;
            this.colUseByDate.VisibleIndex = 7;
            this.colUseByDate.Width = 83;
            // 
            // colQuantityRemains
            // 
            this.colQuantityRemains.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colQuantityRemains.AppearanceCell.Options.UseFont = true;
            this.colQuantityRemains.Caption = "Остаток";
            this.colQuantityRemains.FieldName = "QuantityRemains";
            this.colQuantityRemains.Name = "colQuantityRemains";
            this.colQuantityRemains.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colQuantityRemains.Visible = true;
            this.colQuantityRemains.VisibleIndex = 8;
            this.colQuantityRemains.Width = 89;
            // 
            // colPricePurchase
            // 
            this.colPricePurchase.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.colPricePurchase.AppearanceCell.Options.UseFont = true;
            this.colPricePurchase.Caption = "Цена";
            this.colPricePurchase.FieldName = "PricePurchase";
            this.colPricePurchase.Name = "colPricePurchase";
            this.colPricePurchase.Visible = true;
            this.colPricePurchase.VisibleIndex = 9;
            this.colPricePurchase.Width = 49;
            // 
            // colDocDate
            // 
            this.colDocDate.Caption = "Пришел:";
            this.colDocDate.FieldName = "DocDate";
            this.colDocDate.Name = "colDocDate";
            this.colDocDate.Visible = true;
            this.colDocDate.VisibleIndex = 4;
            this.colDocDate.Width = 74;
            // 
            // colAuthorLastModif
            // 
            this.colAuthorLastModif.Caption = "Редактор";
            this.colAuthorLastModif.FieldName = "AuthorLastModif";
            this.colAuthorLastModif.Name = "colAuthorLastModif";
            this.colAuthorLastModif.Visible = true;
            this.colAuthorLastModif.VisibleIndex = 5;
            this.colAuthorLastModif.Width = 102;
            // 
            // colDateLastModif
            // 
            this.colDateLastModif.Caption = "Изменен";
            this.colDateLastModif.FieldName = "DateLastModif";
            this.colDateLastModif.Name = "colDateLastModif";
            this.colDateLastModif.Visible = true;
            this.colDateLastModif.VisibleIndex = 3;
            this.colDateLastModif.Width = 53;
            // 
            // colSumRemains
            // 
            this.colSumRemains.Caption = "Сумма";
            this.colSumRemains.FieldName = "SumRemains";
            this.colSumRemains.Name = "colSumRemains";
            this.colSumRemains.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colSumRemains.Visible = true;
            this.colSumRemains.VisibleIndex = 10;
            // 
            // ProductLookUpEdit
            // 
            this.ProductLookUpEdit.AutoHeight = false;
            this.ProductLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ProductLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 39, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.ProductLookUpEdit.DataSource = this.productBindingSource;
            this.ProductLookUpEdit.DisplayMember = "Name";
            this.ProductLookUpEdit.Name = "ProductLookUpEdit";
            this.ProductLookUpEdit.ValueMember = "ID";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.mDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // RemainsLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "RemainsLocal";
            this.Size = new System.Drawing.Size(707, 506);
            this.Load += new System.EventHandler(this.Remains_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remainsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRemMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRemMain;
        private MDataSet mDataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantityRemains;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorLastModif;
        private System.Windows.Forms.BindingSource remainsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colManufacturerName;
        private DevExpress.XtraGrid.Columns.GridColumn colCountryName;
        private DevExpress.XtraGrid.Columns.GridColumn colSeries;
        private DevExpress.XtraGrid.Columns.GridColumn colUseByDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPricePurchase;
        private DevExpress.XtraGrid.Columns.GridColumn colDateLastModif;
        private DevExpress.XtraGrid.Columns.GridColumn colDocDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ProductLookUpEdit;
        private System.Windows.Forms.BindingSource productBindingSource;
        private RetailTradeOrders.MDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colSumRemains;
        private System.Windows.Forms.ToolStripButton btClose;
    }
}
