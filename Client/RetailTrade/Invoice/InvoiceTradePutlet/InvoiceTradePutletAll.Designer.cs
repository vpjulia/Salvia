namespace RetailTrade.Invoice.InvoiceTradePutlet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceTradePutletAll));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.invoiceMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mDataSet = new RetailTrade.MDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrganisationRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocumentTypeRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemoteStockRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemoteReceiptMasterRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemoteInvoiceMasterRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsReadOnly = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNds = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorCreate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorLastModif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateLastModif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMainStockRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRecalcSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsNDS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsNDSMain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTradePupletName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 479);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(635, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btAdd});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(635, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.invoiceMasterBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(0, 25);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(635, 454);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colNumber,
            this.colDate,
            this.colOrganisationRef,
            this.colDocumentTypeRef,
            this.colRemoteStockRef,
            this.colRemoteReceiptMasterRef,
            this.colRemoteInvoiceMasterRef,
            this.colIsReadOnly,
            this.colSum,
            this.colNds,
            this.colAuthorCreate,
            this.colAuthorLastModif,
            this.colDateCreate,
            this.colRowVersion,
            this.colNote,
            this.colDateLastModif,
            this.colMainStockRef,
            this.colRecalcSum,
            this.colIsNDS,
            this.colIsNDSMain,
            this.colTradePupletName});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.ReadOnly = true;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colNumber
            // 
            this.colNumber.Caption = "Number";
            this.colNumber.FieldName = "Number";
            this.colNumber.Name = "colNumber";
            this.colNumber.Visible = true;
            this.colNumber.VisibleIndex = 1;
            // 
            // colDate
            // 
            this.colDate.Caption = "Date";
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 2;
            // 
            // colOrganisationRef
            // 
            this.colOrganisationRef.Caption = "OrganisationRef";
            this.colOrganisationRef.FieldName = "OrganisationRef";
            this.colOrganisationRef.Name = "colOrganisationRef";
            this.colOrganisationRef.Visible = true;
            this.colOrganisationRef.VisibleIndex = 3;
            // 
            // colDocumentTypeRef
            // 
            this.colDocumentTypeRef.Caption = "DocumentTypeRef";
            this.colDocumentTypeRef.FieldName = "DocumentTypeRef";
            this.colDocumentTypeRef.Name = "colDocumentTypeRef";
            this.colDocumentTypeRef.Visible = true;
            this.colDocumentTypeRef.VisibleIndex = 4;
            // 
            // colRemoteStockRef
            // 
            this.colRemoteStockRef.Caption = "RemoteStockRef";
            this.colRemoteStockRef.FieldName = "RemoteStockRef";
            this.colRemoteStockRef.Name = "colRemoteStockRef";
            this.colRemoteStockRef.Visible = true;
            this.colRemoteStockRef.VisibleIndex = 5;
            // 
            // colRemoteReceiptMasterRef
            // 
            this.colRemoteReceiptMasterRef.Caption = "RemoteReceiptMasterRef";
            this.colRemoteReceiptMasterRef.FieldName = "RemoteReceiptMasterRef";
            this.colRemoteReceiptMasterRef.Name = "colRemoteReceiptMasterRef";
            this.colRemoteReceiptMasterRef.Visible = true;
            this.colRemoteReceiptMasterRef.VisibleIndex = 6;
            // 
            // colRemoteInvoiceMasterRef
            // 
            this.colRemoteInvoiceMasterRef.Caption = "RemoteInvoiceMasterRef";
            this.colRemoteInvoiceMasterRef.FieldName = "RemoteInvoiceMasterRef";
            this.colRemoteInvoiceMasterRef.Name = "colRemoteInvoiceMasterRef";
            this.colRemoteInvoiceMasterRef.Visible = true;
            this.colRemoteInvoiceMasterRef.VisibleIndex = 7;
            // 
            // colIsReadOnly
            // 
            this.colIsReadOnly.Caption = "IsReadOnly";
            this.colIsReadOnly.FieldName = "IsReadOnly";
            this.colIsReadOnly.Name = "colIsReadOnly";
            this.colIsReadOnly.Visible = true;
            this.colIsReadOnly.VisibleIndex = 8;
            // 
            // colSum
            // 
            this.colSum.Caption = "Sum";
            this.colSum.FieldName = "Sum";
            this.colSum.Name = "colSum";
            this.colSum.Visible = true;
            this.colSum.VisibleIndex = 9;
            // 
            // colNds
            // 
            this.colNds.Caption = "Nds";
            this.colNds.FieldName = "Nds";
            this.colNds.Name = "colNds";
            this.colNds.Visible = true;
            this.colNds.VisibleIndex = 10;
            // 
            // colAuthorCreate
            // 
            this.colAuthorCreate.Caption = "AuthorCreate";
            this.colAuthorCreate.FieldName = "AuthorCreate";
            this.colAuthorCreate.Name = "colAuthorCreate";
            this.colAuthorCreate.Visible = true;
            this.colAuthorCreate.VisibleIndex = 11;
            // 
            // colAuthorLastModif
            // 
            this.colAuthorLastModif.Caption = "AuthorLastModif";
            this.colAuthorLastModif.FieldName = "AuthorLastModif";
            this.colAuthorLastModif.Name = "colAuthorLastModif";
            this.colAuthorLastModif.Visible = true;
            this.colAuthorLastModif.VisibleIndex = 12;
            // 
            // colDateCreate
            // 
            this.colDateCreate.Caption = "DateCreate";
            this.colDateCreate.FieldName = "DateCreate";
            this.colDateCreate.Name = "colDateCreate";
            this.colDateCreate.Visible = true;
            this.colDateCreate.VisibleIndex = 13;
            // 
            // colRowVersion
            // 
            this.colRowVersion.Caption = "RowVersion";
            this.colRowVersion.FieldName = "RowVersion";
            this.colRowVersion.Name = "colRowVersion";
            this.colRowVersion.OptionsColumn.ReadOnly = true;
            this.colRowVersion.Visible = true;
            this.colRowVersion.VisibleIndex = 14;
            // 
            // colNote
            // 
            this.colNote.Caption = "Note";
            this.colNote.FieldName = "Note";
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 15;
            // 
            // colDateLastModif
            // 
            this.colDateLastModif.Caption = "DateLastModif";
            this.colDateLastModif.FieldName = "DateLastModif";
            this.colDateLastModif.Name = "colDateLastModif";
            this.colDateLastModif.Visible = true;
            this.colDateLastModif.VisibleIndex = 16;
            // 
            // colMainStockRef
            // 
            this.colMainStockRef.Caption = "MainStockRef";
            this.colMainStockRef.FieldName = "MainStockRef";
            this.colMainStockRef.Name = "colMainStockRef";
            this.colMainStockRef.Visible = true;
            this.colMainStockRef.VisibleIndex = 17;
            // 
            // colRecalcSum
            // 
            this.colRecalcSum.Caption = "RecalcSum";
            this.colRecalcSum.FieldName = "RecalcSum";
            this.colRecalcSum.Name = "colRecalcSum";
            this.colRecalcSum.Visible = true;
            this.colRecalcSum.VisibleIndex = 18;
            // 
            // colIsNDS
            // 
            this.colIsNDS.Caption = "IsNDS";
            this.colIsNDS.FieldName = "IsNDS";
            this.colIsNDS.Name = "colIsNDS";
            this.colIsNDS.OptionsColumn.ReadOnly = true;
            this.colIsNDS.Visible = true;
            this.colIsNDS.VisibleIndex = 19;
            // 
            // colIsNDSMain
            // 
            this.colIsNDSMain.Caption = "IsNDSMain";
            this.colIsNDSMain.FieldName = "IsNDSMain";
            this.colIsNDSMain.Name = "colIsNDSMain";
            this.colIsNDSMain.OptionsColumn.ReadOnly = true;
            this.colIsNDSMain.Visible = true;
            this.colIsNDSMain.VisibleIndex = 20;
            // 
            // colTradePupletName
            // 
            this.colTradePupletName.Caption = "TradePupletName";
            this.colTradePupletName.FieldName = "TradePupletName";
            this.colTradePupletName.Name = "colTradePupletName";
            this.colTradePupletName.OptionsColumn.ReadOnly = true;
            this.colTradePupletName.Visible = true;
            this.colTradePupletName.VisibleIndex = 21;
            // 
            // btAdd
            // 
            this.btAdd.Image = ((System.Drawing.Image)(resources.GetObject("btAdd.Image")));
            this.btAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(72, 22);
            this.btAdd.Text = "Новый";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // InvoiceTradePutletAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "InvoiceTradePutletAll";
            this.Size = new System.Drawing.Size(635, 501);
            this.Load += new System.EventHandler(this.InvoiceTradePutletAll_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource invoiceMasterBindingSource;
        private MDataSet mDataSet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colOrganisationRef;
        private DevExpress.XtraGrid.Columns.GridColumn colDocumentTypeRef;
        private DevExpress.XtraGrid.Columns.GridColumn colRemoteStockRef;
        private DevExpress.XtraGrid.Columns.GridColumn colRemoteReceiptMasterRef;
        private DevExpress.XtraGrid.Columns.GridColumn colRemoteInvoiceMasterRef;
        private DevExpress.XtraGrid.Columns.GridColumn colIsReadOnly;
        private DevExpress.XtraGrid.Columns.GridColumn colSum;
        private DevExpress.XtraGrid.Columns.GridColumn colNds;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorCreate;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorLastModif;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreate;
        private DevExpress.XtraGrid.Columns.GridColumn colRowVersion;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraGrid.Columns.GridColumn colDateLastModif;
        private DevExpress.XtraGrid.Columns.GridColumn colMainStockRef;
        private DevExpress.XtraGrid.Columns.GridColumn colRecalcSum;
        private DevExpress.XtraGrid.Columns.GridColumn colIsNDS;
        private DevExpress.XtraGrid.Columns.GridColumn colIsNDSMain;
        private DevExpress.XtraGrid.Columns.GridColumn colTradePupletName;
        private System.Windows.Forms.ToolStripButton btAdd;
    }
}
