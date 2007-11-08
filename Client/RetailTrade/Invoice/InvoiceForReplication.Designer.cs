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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceForReplication));
            this.gridViewInvRepDet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManufacturerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriceRetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorCreate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorLastModif1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateLastModif1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRetailNDS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.invoiceMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mDataSet = new RetailTrade.MDataSet();
            this.gridViewInvRepl = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.colDateLastModif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMainStockRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRecalcSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsNDS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsNDSMain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTradePupletName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
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
            this.colPriceRetail,
            this.colAuthorCreate1,
            this.colAuthorLastModif1,
            this.colDateCreate1,
            this.colDateLastModif1,
            this.colNote1,
            this.colRetailNDS});
            this.gridViewInvRepDet.GridControl = this.grid;
            this.gridViewInvRepDet.Name = "gridViewInvRepDet";
            // 
            // colProductName
            // 
            this.colProductName.Caption = "ProductName";
            this.colProductName.FieldName = "ProductName";
            this.colProductName.Name = "colProductName";
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 0;
            // 
            // colManufacturerName
            // 
            this.colManufacturerName.Caption = "ManufacturerName";
            this.colManufacturerName.FieldName = "ManufacturerName";
            this.colManufacturerName.Name = "colManufacturerName";
            this.colManufacturerName.Visible = true;
            this.colManufacturerName.VisibleIndex = 1;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Quantity";
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 2;
            // 
            // colPriceRetail
            // 
            this.colPriceRetail.Caption = "PriceRetail";
            this.colPriceRetail.FieldName = "PriceRetail";
            this.colPriceRetail.Name = "colPriceRetail";
            this.colPriceRetail.Visible = true;
            this.colPriceRetail.VisibleIndex = 3;
            // 
            // colAuthorCreate1
            // 
            this.colAuthorCreate1.Caption = "AuthorCreate";
            this.colAuthorCreate1.FieldName = "AuthorCreate";
            this.colAuthorCreate1.Name = "colAuthorCreate1";
            this.colAuthorCreate1.Visible = true;
            this.colAuthorCreate1.VisibleIndex = 4;
            // 
            // colAuthorLastModif1
            // 
            this.colAuthorLastModif1.Caption = "AuthorLastModif";
            this.colAuthorLastModif1.FieldName = "AuthorLastModif";
            this.colAuthorLastModif1.Name = "colAuthorLastModif1";
            this.colAuthorLastModif1.Visible = true;
            this.colAuthorLastModif1.VisibleIndex = 5;
            // 
            // colDateCreate1
            // 
            this.colDateCreate1.Caption = "DateCreate";
            this.colDateCreate1.FieldName = "DateCreate";
            this.colDateCreate1.Name = "colDateCreate1";
            this.colDateCreate1.Visible = true;
            this.colDateCreate1.VisibleIndex = 6;
            // 
            // colDateLastModif1
            // 
            this.colDateLastModif1.Caption = "DateLastModif";
            this.colDateLastModif1.FieldName = "DateLastModif";
            this.colDateLastModif1.Name = "colDateLastModif1";
            this.colDateLastModif1.Visible = true;
            this.colDateLastModif1.VisibleIndex = 7;
            // 
            // colNote1
            // 
            this.colNote1.Caption = "Note";
            this.colNote1.FieldName = "Note";
            this.colNote1.Name = "colNote1";
            this.colNote1.Visible = true;
            this.colNote1.VisibleIndex = 8;
            // 
            // colRetailNDS
            // 
            this.colRetailNDS.Caption = "RetailNDS";
            this.colRetailNDS.FieldName = "RetailNDS";
            this.colRetailNDS.Name = "colRetailNDS";
            this.colRetailNDS.Visible = true;
            this.colRetailNDS.VisibleIndex = 9;
            // 
            // grid
            // 
            this.grid.DataSource = this.invoiceMasterBindingSource;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            this.grid.EmbeddedNavigator.Name = "";
            gridLevelNode1.LevelTemplate = this.gridViewInvRepDet;
            gridLevelNode1.RelationName = "FK_InvoiceDetail_InvoiceMaster";
            this.grid.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grid.Location = new System.Drawing.Point(0, 25);
            this.grid.MainView = this.gridViewInvRepl;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(742, 483);
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
            this.colDateLastModif,
            this.colNote,
            this.colMainStockRef,
            this.colRecalcSum,
            this.colIsNDS,
            this.colIsNDSMain,
            this.colTradePupletName});
            this.gridViewInvRepl.GridControl = this.grid;
            this.gridViewInvRepl.Name = "gridViewInvRepl";
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.ReadOnly = true;
            this.colID.OptionsColumn.ShowInCustomizationForm = false;
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
            // colOrganisationRef
            // 
            this.colOrganisationRef.Caption = "OrganisationRef";
            this.colOrganisationRef.FieldName = "OrganisationRef";
            this.colOrganisationRef.Name = "colOrganisationRef";
            this.colOrganisationRef.Visible = true;
            this.colOrganisationRef.VisibleIndex = 2;
            // 
            // colDocumentTypeRef
            // 
            this.colDocumentTypeRef.Caption = "DocumentTypeRef";
            this.colDocumentTypeRef.FieldName = "DocumentTypeRef";
            this.colDocumentTypeRef.Name = "colDocumentTypeRef";
            this.colDocumentTypeRef.Visible = true;
            this.colDocumentTypeRef.VisibleIndex = 3;
            // 
            // colRemoteStockRef
            // 
            this.colRemoteStockRef.Caption = "RemoteStockRef";
            this.colRemoteStockRef.FieldName = "RemoteStockRef";
            this.colRemoteStockRef.Name = "colRemoteStockRef";
            this.colRemoteStockRef.Visible = true;
            this.colRemoteStockRef.VisibleIndex = 4;
            // 
            // colRemoteReceiptMasterRef
            // 
            this.colRemoteReceiptMasterRef.Caption = "RemoteReceiptMasterRef";
            this.colRemoteReceiptMasterRef.FieldName = "RemoteReceiptMasterRef";
            this.colRemoteReceiptMasterRef.Name = "colRemoteReceiptMasterRef";
            this.colRemoteReceiptMasterRef.Visible = true;
            this.colRemoteReceiptMasterRef.VisibleIndex = 5;
            // 
            // colRemoteInvoiceMasterRef
            // 
            this.colRemoteInvoiceMasterRef.Caption = "RemoteInvoiceMasterRef";
            this.colRemoteInvoiceMasterRef.FieldName = "RemoteInvoiceMasterRef";
            this.colRemoteInvoiceMasterRef.Name = "colRemoteInvoiceMasterRef";
            this.colRemoteInvoiceMasterRef.Visible = true;
            this.colRemoteInvoiceMasterRef.VisibleIndex = 6;
            // 
            // colIsReadOnly
            // 
            this.colIsReadOnly.Caption = "IsReadOnly";
            this.colIsReadOnly.FieldName = "IsReadOnly";
            this.colIsReadOnly.Name = "colIsReadOnly";
            this.colIsReadOnly.Visible = true;
            this.colIsReadOnly.VisibleIndex = 7;
            // 
            // colSum
            // 
            this.colSum.Caption = "Сумма";
            this.colSum.FieldName = "Sum";
            this.colSum.Name = "colSum";
            this.colSum.Visible = true;
            this.colSum.VisibleIndex = 8;
            // 
            // colNds
            // 
            this.colNds.Caption = "НДС";
            this.colNds.FieldName = "Nds";
            this.colNds.Name = "colNds";
            this.colNds.Visible = true;
            this.colNds.VisibleIndex = 9;
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
            // colMainStockRef
            // 
            this.colMainStockRef.Caption = "MainStockRef";
            this.colMainStockRef.FieldName = "MainStockRef";
            this.colMainStockRef.Name = "colMainStockRef";
            // 
            // colRecalcSum
            // 
            this.colRecalcSum.Caption = "RecalcSum";
            this.colRecalcSum.FieldName = "RecalcSum";
            this.colRecalcSum.Name = "colRecalcSum";
            // 
            // colIsNDS
            // 
            this.colIsNDS.Caption = "IsNDS";
            this.colIsNDS.FieldName = "IsNDS";
            this.colIsNDS.Name = "colIsNDS";
            this.colIsNDS.OptionsColumn.ReadOnly = true;
            // 
            // colIsNDSMain
            // 
            this.colIsNDSMain.Caption = "IsNDSMain";
            this.colIsNDSMain.FieldName = "IsNDSMain";
            this.colIsNDSMain.Name = "colIsNDSMain";
            this.colIsNDSMain.OptionsColumn.ReadOnly = true;
            // 
            // colTradePupletName
            // 
            this.colTradePupletName.Caption = "Торговая точка";
            this.colTradePupletName.FieldName = "TradePupletName";
            this.colTradePupletName.Name = "colTradePupletName";
            this.colTradePupletName.OptionsColumn.ReadOnly = true;
            this.colTradePupletName.Visible = true;
            this.colTradePupletName.VisibleIndex = 10;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 508);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(742, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
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
            this.btClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btClose.Image = ((System.Drawing.Image)(resources.GetObject("btClose.Image")));
            this.btClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(23, 22);
            this.btClose.Text = "X";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btMakeNew
            // 
            this.btMakeNew.Image = ((System.Drawing.Image)(resources.GetObject("btMakeNew.Image")));
            this.btMakeNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btMakeNew.Name = "btMakeNew";
            this.btMakeNew.Size = new System.Drawing.Size(85, 22);
            this.btMakeNew.Text = "Удалить";
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
            this.Controls.Add(this.statusStrip1);
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

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private DevExpress.XtraGrid.GridControl grid;
        private System.Windows.Forms.BindingSource invoiceMasterBindingSource;
        private MDataSet mDataSet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewInvRepDet;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colManufacturerName;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceRetail;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorCreate1;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorLastModif1;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreate1;
        private DevExpress.XtraGrid.Columns.GridColumn colDateLastModif1;
        private DevExpress.XtraGrid.Columns.GridColumn colNote1;
        private DevExpress.XtraGrid.Columns.GridColumn colRetailNDS;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewInvRepl;
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
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraGrid.Columns.GridColumn colDateLastModif;
        private DevExpress.XtraGrid.Columns.GridColumn colMainStockRef;
        private DevExpress.XtraGrid.Columns.GridColumn colRecalcSum;
        private DevExpress.XtraGrid.Columns.GridColumn colIsNDS;
        private DevExpress.XtraGrid.Columns.GridColumn colIsNDSMain;
        private DevExpress.XtraGrid.Columns.GridColumn colTradePupletName;
        private RetailTrade.MDataSetTableAdapters.InvoiceMasterTableAdapter invoiceMasterTableAdapter;
        private System.Windows.Forms.ToolStripButton btClose;
        private System.Windows.Forms.ToolStripButton btMakeNew;
    }
}
