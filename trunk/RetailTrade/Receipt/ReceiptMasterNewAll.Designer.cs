namespace RetailTrade
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
            this.gridViewReceiptDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.productLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mDataSet = new RetailTrade.MDataSet();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPricePurchase = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurchSum1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurchNDS1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeries = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUseByDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorLastModif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.receiptMasterNewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrganizationName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStockName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocumentTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsNDS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTradePutletName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullAuthorModif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullAuthorCreate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurchSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurchNDS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btAdd = new System.Windows.Forms.ToolStripButton();
            this.btEdit = new System.Windows.Forms.ToolStripButton();
            this.btDel = new System.Windows.Forms.ToolStripButton();
            this.BtClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.btField = new System.Windows.Forms.ToolStripMenuItem();
            this.Ó·ÌÓ‚ËÚ¸ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receiptMasterNewTableAdapter = new RetailTrade.MDataSetTableAdapters.ReceiptMasterNewTableAdapter();
            this.receiptMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receiptMasterTableAdapter = new RetailTrade.MDataSetTableAdapters.ReceiptMasterTableAdapter();
            this.productTableAdapter = new RetailTrade.MDataSetTableAdapters.ProductTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewReceiptDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptMasterNewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receiptMasterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewReceiptDetail
            // 
            this.gridViewReceiptDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductRef,
            this.colQuantity,
            this.colPricePurchase,
            this.colPurchSum1,
            this.colPurchNDS1,
            this.colSeries,
            this.colUseByDate,
            this.colAuthorLastModif});
            this.gridViewReceiptDetail.GridControl = this.grid;
            this.gridViewReceiptDetail.Name = "gridViewReceiptDetail";
            this.gridViewReceiptDetail.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridViewReceiptDetail.OptionsBehavior.Editable = false;
            this.gridViewReceiptDetail.OptionsView.ShowGroupPanel = false;
            // 
            // colProductRef
            // 
            this.colProductRef.Caption = "Õ‡ËÏÂÌÓ‚‡ÌËÂ";
            this.colProductRef.ColumnEdit = this.productLookUpEdit;
            this.colProductRef.FieldName = "ProductRef";
            this.colProductRef.Name = "colProductRef";
            this.colProductRef.OptionsColumn.AllowEdit = false;
            this.colProductRef.OptionsColumn.AllowFocus = false;
            this.colProductRef.OptionsColumn.ReadOnly = true;
            this.colProductRef.Visible = true;
            this.colProductRef.VisibleIndex = 0;
            this.colProductRef.Width = 259;
            // 
            // productLookUpEdit
            // 
            this.productLookUpEdit.AutoHeight = false;
            this.productLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.productLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Õ‡ËÏÂÌÓ‚‡ÌËÂ", 39, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
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
            // mDataSet
            // 
            this.mDataSet.DataSetName = "MDataSet";
            this.mDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = " ÓÎ-‚Ó";
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 1;
            this.colQuantity.Width = 98;
            // 
            // colPricePurchase
            // 
            this.colPricePurchase.Caption = "÷ÂÌ‡";
            this.colPricePurchase.FieldName = "PricePurchase";
            this.colPricePurchase.Name = "colPricePurchase";
            this.colPricePurchase.Visible = true;
            this.colPricePurchase.VisibleIndex = 2;
            this.colPricePurchase.Width = 154;
            // 
            // colPurchSum1
            // 
            this.colPurchSum1.Caption = "—ÛÏÏ‡";
            this.colPurchSum1.FieldName = "PurchSum";
            this.colPurchSum1.Name = "colPurchSum1";
            this.colPurchSum1.OptionsColumn.ReadOnly = true;
            this.colPurchSum1.Visible = true;
            this.colPurchSum1.VisibleIndex = 3;
            this.colPurchSum1.Width = 209;
            // 
            // colPurchNDS1
            // 
            this.colPurchNDS1.Caption = "Õƒ—";
            this.colPurchNDS1.FieldName = "PurchNDS";
            this.colPurchNDS1.Name = "colPurchNDS1";
            this.colPurchNDS1.OptionsColumn.ReadOnly = true;
            // 
            // colSeries
            // 
            this.colSeries.Caption = "—ÂËˇ";
            this.colSeries.FieldName = "Series";
            this.colSeries.Name = "colSeries";
            // 
            // colUseByDate
            // 
            this.colUseByDate.Caption = "—ÓÍ";
            this.colUseByDate.FieldName = "UseByDate";
            this.colUseByDate.Name = "colUseByDate";
            // 
            // colAuthorLastModif
            // 
            this.colAuthorLastModif.Caption = "–Â‰‡ÍÚÓ";
            this.colAuthorLastModif.FieldName = "AuthorLastModif";
            this.colAuthorLastModif.Name = "colAuthorLastModif";
            this.colAuthorLastModif.OptionsColumn.ReadOnly = true;
            // 
            // grid
            // 
            this.grid.DataSource = this.receiptMasterNewBindingSource;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.EmbeddedNavigator.Name = "";
            gridLevelNode1.LevelTemplate = this.gridViewReceiptDetail;
            gridLevelNode1.RelationName = "ReceiptMasterNew_ReceiptDetail";
            this.grid.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grid.Location = new System.Drawing.Point(0, 25);
            this.grid.MainView = this.gridView1;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.productLookUpEdit});
            this.grid.Size = new System.Drawing.Size(740, 314);
            this.grid.TabIndex = 2;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridViewReceiptDetail});
            // 
            // receiptMasterNewBindingSource
            // 
            this.receiptMasterNewBindingSource.DataMember = "ReceiptMasterNew";
            this.receiptMasterNewBindingSource.DataSource = this.mDataSet;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNumber,
            this.colDocDate,
            this.colNote,
            this.colOrganizationName,
            this.colStockName,
            this.colDocumentTypeName,
            this.colIsNDS,
            this.colTradePutletName,
            this.colFullAuthorModif,
            this.colFullAuthorCreate,
            this.colPurchSum,
            this.colPurchNDS});
            this.gridView1.GridControl = this.grid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colNumber
            // 
            this.colNumber.Caption = "π";
            this.colNumber.FieldName = "Number";
            this.colNumber.Name = "colNumber";
            this.colNumber.Visible = true;
            this.colNumber.VisibleIndex = 0;
            this.colNumber.Width = 70;
            // 
            // colDocDate
            // 
            this.colDocDate.Caption = "ƒ‡Ú‡";
            this.colDocDate.FieldName = "DocDate";
            this.colDocDate.Name = "colDocDate";
            this.colDocDate.Visible = true;
            this.colDocDate.VisibleIndex = 1;
            this.colDocDate.Width = 98;
            // 
            // colNote
            // 
            this.colNote.Caption = "ŒÒÌÓ‚‡ÌËÂ";
            this.colNote.FieldName = "Note";
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 4;
            this.colNote.Width = 70;
            // 
            // colOrganizationName
            // 
            this.colOrganizationName.Caption = "œÓÒÚ‡‚˘ËÍ";
            this.colOrganizationName.FieldName = "OrganizationName";
            this.colOrganizationName.Name = "colOrganizationName";
            this.colOrganizationName.Visible = true;
            this.colOrganizationName.VisibleIndex = 5;
            this.colOrganizationName.Width = 59;
            // 
            // colStockName
            // 
            this.colStockName.Caption = "—ÍÎ‡‰";
            this.colStockName.FieldName = "StockName";
            this.colStockName.Name = "colStockName";
            this.colStockName.Visible = true;
            this.colStockName.VisibleIndex = 6;
            this.colStockName.Width = 68;
            // 
            // colDocumentTypeName
            // 
            this.colDocumentTypeName.Caption = "“ËÔ ‰ÓÍÛÏÂÌÚ‡";
            this.colDocumentTypeName.FieldName = "DocumentTypeName";
            this.colDocumentTypeName.Name = "colDocumentTypeName";
            this.colDocumentTypeName.Visible = true;
            this.colDocumentTypeName.VisibleIndex = 7;
            this.colDocumentTypeName.Width = 63;
            // 
            // colIsNDS
            // 
            this.colIsNDS.Caption = "Õƒ—";
            this.colIsNDS.FieldName = "IsNDS";
            this.colIsNDS.Name = "colIsNDS";
            this.colIsNDS.Visible = true;
            this.colIsNDS.VisibleIndex = 8;
            this.colIsNDS.Width = 33;
            // 
            // colTradePutletName
            // 
            this.colTradePutletName.Caption = "“Ó„Ó‚‡ˇ ÚÓ˜Í‡";
            this.colTradePutletName.FieldName = "TradePutletName";
            this.colTradePutletName.Name = "colTradePutletName";
            this.colTradePutletName.Visible = true;
            this.colTradePutletName.VisibleIndex = 9;
            this.colTradePutletName.Width = 33;
            // 
            // colFullAuthorModif
            // 
            this.colFullAuthorModif.Caption = "»ÁÏÂÌÂÌ";
            this.colFullAuthorModif.FieldName = "FullAuthorModif";
            this.colFullAuthorModif.Name = "colFullAuthorModif";
            this.colFullAuthorModif.Visible = true;
            this.colFullAuthorModif.VisibleIndex = 10;
            this.colFullAuthorModif.Width = 33;
            // 
            // colFullAuthorCreate
            // 
            this.colFullAuthorCreate.Caption = "—ÓÁ‰‡Ì";
            this.colFullAuthorCreate.FieldName = "FullAuthorCreate";
            this.colFullAuthorCreate.Name = "colFullAuthorCreate";
            this.colFullAuthorCreate.Visible = true;
            this.colFullAuthorCreate.VisibleIndex = 11;
            this.colFullAuthorCreate.Width = 50;
            // 
            // colPurchSum
            // 
            this.colPurchSum.Caption = "—ÛÏÏ‡ ·ÂÁ Õƒ—";
            this.colPurchSum.FieldName = "PurchSum";
            this.colPurchSum.Name = "colPurchSum";
            this.colPurchSum.Visible = true;
            this.colPurchSum.VisibleIndex = 2;
            this.colPurchSum.Width = 92;
            // 
            // colPurchNDS
            // 
            this.colPurchNDS.Caption = "Õƒ—";
            this.colPurchNDS.FieldName = "PurchNDS";
            this.colPurchNDS.Name = "colPurchNDS";
            this.colPurchNDS.Visible = true;
            this.colPurchNDS.VisibleIndex = 3;
            this.colPurchNDS.Width = 51;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 339);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(740, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btAdd,
            this.btEdit,
            this.btDel,
            this.BtClose,
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(740, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btAdd
            // 
            this.btAdd.Image = ((System.Drawing.Image)(resources.GetObject("btAdd.Image")));
            this.btAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(94, 22);
            this.btAdd.Text = "ƒÓ·‡‚ËÚ¸";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btEdit
            // 
            this.btEdit.Image = ((System.Drawing.Image)(resources.GetObject("btEdit.Image")));
            this.btEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(95, 22);
            this.btEdit.Text = "»ÁÏÂÌËÚ¸";
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDel
            // 
            this.btDel.Image = ((System.Drawing.Image)(resources.GetObject("btDel.Image")));
            this.btDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(85, 22);
            this.btDel.Text = "”‰‡ÎËÚ¸";
            // 
            // BtClose
            // 
            this.BtClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtClose.Image = ((System.Drawing.Image)(resources.GetObject("BtClose.Image")));
            this.BtClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtClose.Name = "BtClose";
            this.BtClose.Size = new System.Drawing.Size(23, 22);
            this.BtClose.Text = "ı";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btField,
            this.Ó·ÌÓ‚ËÚ¸ToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // btField
            // 
            this.btField.Name = "btField";
            this.btField.Size = new System.Drawing.Size(208, 22);
            this.btField.Text = "Õ‡ÒÚÓÈÍ‡ ÔÓÎÂÈ";
            this.btField.Click += new System.EventHandler(this.btField_Click);
            // 
            // Ó·ÌÓ‚ËÚ¸ToolStripMenuItem
            // 
            this.Ó·ÌÓ‚ËÚ¸ToolStripMenuItem.Name = "Ó·ÌÓ‚ËÚ¸ToolStripMenuItem";
            this.Ó·ÌÓ‚ËÚ¸ToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.Ó·ÌÓ‚ËÚ¸ToolStripMenuItem.Text = "Œ·ÌÓ‚ËÚ¸";
            // 
            // receiptMasterNewTableAdapter
            // 
            this.receiptMasterNewTableAdapter.ClearBeforeFill = true;
            // 
            // receiptMasterBindingSource
            // 
            this.receiptMasterBindingSource.DataMember = "ReceiptMaster";
            this.receiptMasterBindingSource.DataSource = this.mDataSet;
            // 
            // receiptMasterTableAdapter
            // 
            this.receiptMasterTableAdapter.ClearBeforeFill = true;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // ReceiptMasterNewAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "ReceiptMasterNewAll";
            this.Size = new System.Drawing.Size(740, 361);
            this.Load += new System.EventHandler(this.ReceiptMasterNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewReceiptDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptMasterNewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receiptMasterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource receiptMasterNewBindingSource;
        private MDataSet mDataSet;
        private RetailTrade.MDataSetTableAdapters.ReceiptMasterNewTableAdapter receiptMasterNewTableAdapter;
        private System.Windows.Forms.ToolStripButton btEdit;
        private System.Windows.Forms.ToolStripButton btAdd;
        private System.Windows.Forms.BindingSource receiptMasterBindingSource;
        private RetailTrade.MDataSetTableAdapters.ReceiptMasterTableAdapter receiptMasterTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colDocDate;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraGrid.Columns.GridColumn colOrganizationName;
        private DevExpress.XtraGrid.Columns.GridColumn colStockName;
        private DevExpress.XtraGrid.Columns.GridColumn colDocumentTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colIsNDS;
        private DevExpress.XtraGrid.Columns.GridColumn colTradePutletName;
        private DevExpress.XtraGrid.Columns.GridColumn colFullAuthorModif;
        private DevExpress.XtraGrid.Columns.GridColumn colFullAuthorCreate;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchSum;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchNDS;
        private System.Windows.Forms.ToolStripButton btDel;
        private System.Windows.Forms.ToolStripButton BtClose;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewReceiptDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colProductRef;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colPricePurchase;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchSum1;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchNDS1;
        private DevExpress.XtraGrid.Columns.GridColumn colSeries;
        private DevExpress.XtraGrid.Columns.GridColumn colUseByDate;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorLastModif;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem btField;
        private System.Windows.Forms.ToolStripMenuItem Ó·ÌÓ‚ËÚ¸ToolStripMenuItem;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit productLookUpEdit;
        private System.Windows.Forms.BindingSource productBindingSource;
        private RetailTrade.MDataSetTableAdapters.ProductTableAdapter productTableAdapter;
    }
}
