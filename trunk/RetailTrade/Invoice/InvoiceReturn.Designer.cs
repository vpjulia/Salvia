namespace RetailTrade.Invoice
{
    partial class InvoiceReturn
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
            this.gridViewLinkDet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLocalReceiptDetailRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriceRetailNDS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRetailSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mDataSet = new RetailTrade.MDataSet();
            this.colManufacturerRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.manufacturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.linkedInvoiceMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewLinkMast = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNds = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorCreate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorLastModif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.linkedInvoiceDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btFind = new System.Windows.Forms.ToolStripButton();
            this.cbTradePutlet = new System.Windows.Forms.ToolStripComboBox();
            this.btMove = new System.Windows.Forms.ToolStripButton();
            this.btClose = new System.Windows.Forms.ToolStripButton();
            this.linkedInvoiceMasterTableAdapter = new RetailTrade.MDataSetTableAdapters.LinkedInvoiceMasterTableAdapter();
            this.linkedInvoiceDetailTableAdapter = new RetailTrade.MDataSetTableAdapters.LinkedInvoiceDetailTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btApMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btDeleteRow = new System.Windows.Forms.ToolStripMenuItem();
            this.productTableAdapter = new RetailTrade.MDataSetTableAdapters.ProductTableAdapter();
            this.farmGroupLevel2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmGroupLevel2TableAdapter = new RetailTrade.MDataSetTableAdapters.FarmGroupLevel2TableAdapter();
            this.manufacturerTableAdapter = new RetailTrade.MDataSetTableAdapters.ManufacturerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLinkDet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkedInvoiceMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLinkMast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkedInvoiceDetailBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.farmGroupLevel2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewLinkDet
            // 
            this.gridViewLinkDet.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colQuantity,
            this.colLocalReceiptDetailRef,
            this.colPriceRetailNDS,
            this.colRetailSum,
            this.colProductRef,
            this.colManufacturerRef});
            this.gridViewLinkDet.GridControl = this.gridControl1;
            this.gridViewLinkDet.Name = "gridViewLinkDet";
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Quantity";
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 0;
            // 
            // colLocalReceiptDetailRef
            // 
            this.colLocalReceiptDetailRef.Caption = "LocalReceiptDetailRef";
            this.colLocalReceiptDetailRef.FieldName = "LocalReceiptDetailRef";
            this.colLocalReceiptDetailRef.Name = "colLocalReceiptDetailRef";
            this.colLocalReceiptDetailRef.Visible = true;
            this.colLocalReceiptDetailRef.VisibleIndex = 1;
            // 
            // colPriceRetailNDS
            // 
            this.colPriceRetailNDS.Caption = "PriceRetailNDS";
            this.colPriceRetailNDS.FieldName = "PriceRetailNDS";
            this.colPriceRetailNDS.Name = "colPriceRetailNDS";
            this.colPriceRetailNDS.Visible = true;
            this.colPriceRetailNDS.VisibleIndex = 2;
            // 
            // colRetailSum
            // 
            this.colRetailSum.Caption = "RetailSum";
            this.colRetailSum.FieldName = "RetailSum";
            this.colRetailSum.Name = "colRetailSum";
            this.colRetailSum.Visible = true;
            this.colRetailSum.VisibleIndex = 3;
            // 
            // colProductRef
            // 
            this.colProductRef.Caption = "ProductRef";
            this.colProductRef.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colProductRef.FieldName = "ProductRef";
            this.colProductRef.Name = "colProductRef";
            this.colProductRef.Visible = true;
            this.colProductRef.VisibleIndex = 4;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DataSource = this.productBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "Name";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "ID";
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
            // colManufacturerRef
            // 
            this.colManufacturerRef.Caption = "ManufacturerRef";
            this.colManufacturerRef.ColumnEdit = this.repositoryItemLookUpEdit2;
            this.colManufacturerRef.FieldName = "ManufacturerRef";
            this.colManufacturerRef.Name = "colManufacturerRef";
            this.colManufacturerRef.Visible = true;
            this.colManufacturerRef.VisibleIndex = 5;
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.DataSource = this.manufacturerBindingSource;
            this.repositoryItemLookUpEdit2.DisplayMember = "Name";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.ValueMember = "ID";
            // 
            // manufacturerBindingSource
            // 
            this.manufacturerBindingSource.DataMember = "Manufacturer";
            this.manufacturerBindingSource.DataSource = this.mDataSet;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.linkedInvoiceMasterBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Name = "";
            gridLevelNode1.LevelTemplate = this.gridViewLinkDet;
            gridLevelNode1.RelationName = "LinkedInvoiceMaster_LinkedInvoiceDetail";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(0, 26);
            this.gridControl1.MainView = this.gridViewLinkMast;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2});
            this.gridControl1.Size = new System.Drawing.Size(723, 539);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewLinkMast,
            this.gridView3,
            this.gridViewLinkDet});
            // 
            // linkedInvoiceMasterBindingSource
            // 
            this.linkedInvoiceMasterBindingSource.DataMember = "LinkedInvoiceMaster";
            this.linkedInvoiceMasterBindingSource.DataSource = this.mDataSet;
            // 
            // gridViewLinkMast
            // 
            this.gridViewLinkMast.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNumber,
            this.colDate,
            this.colSum,
            this.colNds,
            this.colNote,
            this.colAuthorCreate,
            this.colAuthorLastModif,
            this.colDateCreate});
            this.gridViewLinkMast.GridControl = this.gridControl1;
            this.gridViewLinkMast.Name = "gridViewLinkMast";
            this.gridViewLinkMast.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridViewLinkMast.OptionsBehavior.Editable = false;
            this.gridViewLinkMast.OptionsDetail.AllowOnlyOneMasterRowExpanded = true;
            this.gridViewLinkMast.OptionsView.ShowFooter = true;
            // 
            // colNumber
            // 
            this.colNumber.Caption = "№";
            this.colNumber.FieldName = "Number";
            this.colNumber.Name = "colNumber";
            this.colNumber.Visible = true;
            this.colNumber.VisibleIndex = 0;
            this.colNumber.Width = 115;
            // 
            // colDate
            // 
            this.colDate.Caption = "Дата";
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 1;
            this.colDate.Width = 78;
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
            this.colSum.Width = 81;
            // 
            // colNds
            // 
            this.colNds.Caption = "в т.ч. НДС";
            this.colNds.FieldName = "Nds";
            this.colNds.Name = "colNds";
            this.colNds.SummaryItem.DisplayFormat = "{0: ######.00}";
            this.colNds.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colNds.Visible = true;
            this.colNds.VisibleIndex = 4;
            this.colNds.Width = 81;
            // 
            // colNote
            // 
            this.colNote.Caption = "Прим.";
            this.colNote.FieldName = "Note";
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 2;
            this.colNote.Width = 102;
            // 
            // colAuthorCreate
            // 
            this.colAuthorCreate.Caption = "Автор";
            this.colAuthorCreate.FieldName = "AuthorCreate";
            this.colAuthorCreate.Name = "colAuthorCreate";
            this.colAuthorCreate.Visible = true;
            this.colAuthorCreate.VisibleIndex = 5;
            this.colAuthorCreate.Width = 81;
            // 
            // colAuthorLastModif
            // 
            this.colAuthorLastModif.Caption = "Редактор";
            this.colAuthorLastModif.FieldName = "AuthorLastModif";
            this.colAuthorLastModif.Name = "colAuthorLastModif";
            this.colAuthorLastModif.Visible = true;
            this.colAuthorLastModif.VisibleIndex = 6;
            this.colAuthorLastModif.Width = 81;
            // 
            // colDateCreate
            // 
            this.colDateCreate.Caption = "Создан";
            this.colDateCreate.FieldName = "DateCreate";
            this.colDateCreate.Name = "colDateCreate";
            this.colDateCreate.Visible = true;
            this.colDateCreate.VisibleIndex = 7;
            this.colDateCreate.Width = 90;
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gridControl1;
            this.gridView3.Name = "gridView3";
            // 
            // linkedInvoiceDetailBindingSource
            // 
            this.linkedInvoiceDetailBindingSource.DataMember = "LinkedInvoiceMaster_LinkedInvoiceDetail";
            this.linkedInvoiceDetailBindingSource.DataSource = this.linkedInvoiceMasterBindingSource;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 565);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(723, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbTradePutlet,
            this.btFind,
            this.btMove,
            this.btClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(723, 26);
            this.toolStrip1.TabIndex = 1;
            // 
            // btFind
            // 
            this.btFind.Image = global::RetailTrade.Properties.Resources.earth_find;
            this.btFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(70, 23);
            this.btFind.Text = "Найти";
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // cbTradePutlet
            // 
            this.cbTradePutlet.Name = "cbTradePutlet";
            this.cbTradePutlet.Size = new System.Drawing.Size(250, 26);
            // 
            // btMove
            // 
            this.btMove.Image = global::RetailTrade.Properties.Resources.download;
            this.btMove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btMove.Name = "btMove";
            this.btMove.Size = new System.Drawing.Size(86, 23);
            this.btMove.Text = "Принять";
            this.btMove.Click += new System.EventHandler(this.btMove_Click);
            // 
            // btClose
            // 
            this.btClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btClose.Image = global::RetailTrade.Properties.Resources.delete2;
            this.btClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(23, 23);
            this.btClose.Text = "toolStripButton1";
            this.btClose.ToolTipText = "Закрыть";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // linkedInvoiceMasterTableAdapter
            // 
            this.linkedInvoiceMasterTableAdapter.ClearBeforeFill = true;
            // 
            // linkedInvoiceDetailTableAdapter
            // 
            this.linkedInvoiceDetailTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btApMenu,
            this.btDeleteRow});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(200, 48);
            // 
            // btApMenu
            // 
            this.btApMenu.Image = global::RetailTrade.Properties.Resources.download;
            this.btApMenu.Name = "btApMenu";
            this.btApMenu.Size = new System.Drawing.Size(199, 22);
            this.btApMenu.Text = "Принять";
            // 
            // btDeleteRow
            // 
            this.btDeleteRow.Image = global::RetailTrade.Properties.Resources.cut;
            this.btDeleteRow.Name = "btDeleteRow";
            this.btDeleteRow.Size = new System.Drawing.Size(199, 22);
            this.btDeleteRow.Text = "Удалить строку";
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // farmGroupLevel2BindingSource
            // 
            this.farmGroupLevel2BindingSource.DataMember = "FarmGroupLevel2";
            this.farmGroupLevel2BindingSource.DataSource = this.mDataSet;
            // 
            // farmGroupLevel2TableAdapter
            // 
            this.farmGroupLevel2TableAdapter.ClearBeforeFill = true;
            // 
            // manufacturerTableAdapter
            // 
            this.manufacturerTableAdapter.ClearBeforeFill = true;
            // 
            // InvoiceReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "InvoiceReturn";
            this.Size = new System.Drawing.Size(723, 587);
            this.Load += new System.EventHandler(this.InvoiceReturn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLinkDet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkedInvoiceMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLinkMast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkedInvoiceDetailBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.farmGroupLevel2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox cbTradePutlet;
        private MDataSet mDataSet;
        private System.Windows.Forms.ToolStripButton btFind;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource linkedInvoiceMasterBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewLinkMast;
        private DevExpress.XtraGrid.Columns.GridColumn colNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colSum;
        private DevExpress.XtraGrid.Columns.GridColumn colNds;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorCreate;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorLastModif;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreate;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewLinkDet;
        private RetailTrade.MDataSetTableAdapters.LinkedInvoiceMasterTableAdapter linkedInvoiceMasterTableAdapter;
        private System.Windows.Forms.BindingSource linkedInvoiceDetailBindingSource;
        private RetailTrade.MDataSetTableAdapters.LinkedInvoiceDetailTableAdapter linkedInvoiceDetailTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colLocalReceiptDetailRef;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceRetailNDS;
        private DevExpress.XtraGrid.Columns.GridColumn colRetailSum;
        private System.Windows.Forms.ToolStripButton btMove;
        private System.Windows.Forms.ToolStripButton btClose;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btApMenu;
        private System.Windows.Forms.ToolStripMenuItem btDeleteRow;
        private DevExpress.XtraGrid.Columns.GridColumn colProductRef;
        private DevExpress.XtraGrid.Columns.GridColumn colManufacturerRef;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private System.Windows.Forms.BindingSource manufacturerBindingSource;
        private RetailTrade.MDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.BindingSource farmGroupLevel2BindingSource;
        private RetailTrade.MDataSetTableAdapters.FarmGroupLevel2TableAdapter farmGroupLevel2TableAdapter;
        private RetailTrade.MDataSetTableAdapters.ManufacturerTableAdapter manufacturerTableAdapter;
    }
}
