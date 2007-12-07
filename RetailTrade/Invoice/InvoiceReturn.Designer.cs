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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceReturn));
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLocalReceiptDetailRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriceRetailNDS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRetailSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.linkedInvoiceMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mDataSet = new RetailTrade.MDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNds = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorCreate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorLastModif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTradePutletRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.linkedInvoiceDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cbTradePutlet = new System.Windows.Forms.ToolStripComboBox();
            this.btFind = new System.Windows.Forms.ToolStripButton();
            this.btDeleteRow = new System.Windows.Forms.ToolStripButton();
            this.linkedInvoiceMasterTableAdapter = new RetailTrade.MDataSetTableAdapters.LinkedInvoiceMasterTableAdapter();
            this.linkedInvoiceDetailTableAdapter = new RetailTrade.MDataSetTableAdapters.LinkedInvoiceDetailTableAdapter();
            this.btMove = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkedInvoiceMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkedInvoiceDetailBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colQuantity,
            this.colLocalReceiptDetailRef,
            this.colPriceRetailNDS,
            this.colRetailSum});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
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
            // gridControl1
            // 
            this.gridControl1.DataSource = this.linkedInvoiceMasterBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            this.gridControl1.EmbeddedNavigator.Name = "";
            gridLevelNode1.LevelTemplate = this.gridView2;
            gridLevelNode1.RelationName = "LinkedInvoiceMaster_LinkedInvoiceDetail";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(0, 26);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(723, 539);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView3,
            this.gridView2});
            // 
            // linkedInvoiceMasterBindingSource
            // 
            this.linkedInvoiceMasterBindingSource.DataMember = "LinkedInvoiceMaster";
            this.linkedInvoiceMasterBindingSource.DataSource = this.mDataSet;
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
            this.colDate,
            this.colSum,
            this.colNds,
            this.colNote,
            this.colAuthorCreate,
            this.colAuthorLastModif,
            this.colDateCreate,
            this.colTradePutletRef});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colNumber
            // 
            this.colNumber.Caption = "Number";
            this.colNumber.FieldName = "Number";
            this.colNumber.Name = "colNumber";
            this.colNumber.Visible = true;
            this.colNumber.VisibleIndex = 0;
            this.colNumber.Width = 100;
            // 
            // colDate
            // 
            this.colDate.Caption = "Date";
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 1;
            this.colDate.Width = 68;
            // 
            // colSum
            // 
            this.colSum.Caption = "Sum";
            this.colSum.FieldName = "Sum";
            this.colSum.Name = "colSum";
            this.colSum.Visible = true;
            this.colSum.VisibleIndex = 2;
            this.colSum.Width = 74;
            // 
            // colNds
            // 
            this.colNds.Caption = "Nds";
            this.colNds.FieldName = "Nds";
            this.colNds.Name = "colNds";
            this.colNds.Visible = true;
            this.colNds.VisibleIndex = 3;
            this.colNds.Width = 74;
            // 
            // colNote
            // 
            this.colNote.Caption = "Note";
            this.colNote.FieldName = "Note";
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 4;
            this.colNote.Width = 74;
            // 
            // colAuthorCreate
            // 
            this.colAuthorCreate.Caption = "AuthorCreate";
            this.colAuthorCreate.FieldName = "AuthorCreate";
            this.colAuthorCreate.Name = "colAuthorCreate";
            this.colAuthorCreate.Visible = true;
            this.colAuthorCreate.VisibleIndex = 5;
            this.colAuthorCreate.Width = 74;
            // 
            // colAuthorLastModif
            // 
            this.colAuthorLastModif.Caption = "AuthorLastModif";
            this.colAuthorLastModif.FieldName = "AuthorLastModif";
            this.colAuthorLastModif.Name = "colAuthorLastModif";
            this.colAuthorLastModif.Visible = true;
            this.colAuthorLastModif.VisibleIndex = 6;
            this.colAuthorLastModif.Width = 74;
            // 
            // colDateCreate
            // 
            this.colDateCreate.Caption = "DateCreate";
            this.colDateCreate.FieldName = "DateCreate";
            this.colDateCreate.Name = "colDateCreate";
            this.colDateCreate.Visible = true;
            this.colDateCreate.VisibleIndex = 7;
            this.colDateCreate.Width = 74;
            // 
            // colTradePutletRef
            // 
            this.colTradePutletRef.Caption = "TradePutletRef";
            this.colTradePutletRef.FieldName = "TradePutletRef";
            this.colTradePutletRef.Name = "colTradePutletRef";
            this.colTradePutletRef.Visible = true;
            this.colTradePutletRef.VisibleIndex = 8;
            this.colTradePutletRef.Width = 97;
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
            this.btDeleteRow,
            this.btMove});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(723, 26);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cbTradePutlet
            // 
            this.cbTradePutlet.Name = "cbTradePutlet";
            this.cbTradePutlet.Size = new System.Drawing.Size(121, 26);
            // 
            // btFind
            // 
            this.btFind.Image = ((System.Drawing.Image)(resources.GetObject("btFind.Image")));
            this.btFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(70, 23);
            this.btFind.Text = "Найти";
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // btDeleteRow
            // 
            this.btDeleteRow.Image = ((System.Drawing.Image)(resources.GetObject("btDeleteRow.Image")));
            this.btDeleteRow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btDeleteRow.Name = "btDeleteRow";
            this.btDeleteRow.Size = new System.Drawing.Size(136, 23);
            this.btDeleteRow.Text = "Удалить строку";
            // 
            // linkedInvoiceMasterTableAdapter
            // 
            this.linkedInvoiceMasterTableAdapter.ClearBeforeFill = true;
            // 
            // linkedInvoiceDetailTableAdapter
            // 
            this.linkedInvoiceDetailTableAdapter.ClearBeforeFill = true;
            // 
            // btMove
            // 
            this.btMove.Image = ((System.Drawing.Image)(resources.GetObject("btMove.Image")));
            this.btMove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btMove.Name = "btMove";
            this.btMove.Size = new System.Drawing.Size(86, 23);
            this.btMove.Text = "Принять";
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
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkedInvoiceMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkedInvoiceDetailBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colSum;
        private DevExpress.XtraGrid.Columns.GridColumn colNds;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorCreate;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorLastModif;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreate;
        private DevExpress.XtraGrid.Columns.GridColumn colTradePutletRef;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private RetailTrade.MDataSetTableAdapters.LinkedInvoiceMasterTableAdapter linkedInvoiceMasterTableAdapter;
        private System.Windows.Forms.BindingSource linkedInvoiceDetailBindingSource;
        private RetailTrade.MDataSetTableAdapters.LinkedInvoiceDetailTableAdapter linkedInvoiceDetailTableAdapter;
        private System.Windows.Forms.ToolStripButton btDeleteRow;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colLocalReceiptDetailRef;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceRetailNDS;
        private DevExpress.XtraGrid.Columns.GridColumn colRetailSum;
        private System.Windows.Forms.ToolStripButton btMove;
    }
}
