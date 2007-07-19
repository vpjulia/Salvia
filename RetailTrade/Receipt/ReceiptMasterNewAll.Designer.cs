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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiptMasterNewAll));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btAdd = new System.Windows.Forms.ToolStripButton();
            this.btEdit = new System.Windows.Forms.ToolStripButton();
            this.btDel = new System.Windows.Forms.ToolStripButton();
            this.BtClose = new System.Windows.Forms.ToolStripButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.receiptMasterNewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mDataSet = new RetailTrade.MDataSet();
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
            this.receiptMasterNewTableAdapter = new RetailTrade.MDataSetTableAdapters.ReceiptMasterNewTableAdapter();
            this.receiptMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receiptMasterTableAdapter = new RetailTrade.MDataSetTableAdapters.ReceiptMasterTableAdapter();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptMasterNewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptMasterBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.BtClose});
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
            this.btAdd.Size = new System.Drawing.Size(72, 22);
            this.btAdd.Text = "Новый";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
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
            // btDel
            // 
            this.btDel.Image = ((System.Drawing.Image)(resources.GetObject("btDel.Image")));
            this.btDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(85, 22);
            this.btDel.Text = "Удалить";
            // 
            // BtClose
            // 
            this.BtClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtClose.Image = ((System.Drawing.Image)(resources.GetObject("BtClose.Image")));
            this.BtClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtClose.Name = "BtClose";
            this.BtClose.Size = new System.Drawing.Size(23, 22);
            this.BtClose.Text = "х";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.receiptMasterNewBindingSource;
            // 
            // 
            // 
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(0, 25);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(734, 296);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // receiptMasterNewBindingSource
            // 
            this.receiptMasterNewBindingSource.DataMember = "ReceiptMasterNew";
            this.receiptMasterNewBindingSource.DataSource = this.mDataSet;
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
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colNumber
            // 
            this.colNumber.Caption = "№";
            this.colNumber.FieldName = "Number";
            this.colNumber.Name = "colNumber";
            this.colNumber.Visible = true;
            this.colNumber.VisibleIndex = 0;
            this.colNumber.Width = 70;
            // 
            // colDocDate
            // 
            this.colDocDate.Caption = "Дата";
            this.colDocDate.FieldName = "DocDate";
            this.colDocDate.Name = "colDocDate";
            this.colDocDate.Visible = true;
            this.colDocDate.VisibleIndex = 1;
            this.colDocDate.Width = 59;
            // 
            // colNote
            // 
            this.colNote.Caption = "Основание";
            this.colNote.FieldName = "Note";
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 4;
            this.colNote.Width = 54;
            // 
            // colOrganizationName
            // 
            this.colOrganizationName.Caption = "Поставщик";
            this.colOrganizationName.FieldName = "OrganizationName";
            this.colOrganizationName.Name = "colOrganizationName";
            this.colOrganizationName.Visible = true;
            this.colOrganizationName.VisibleIndex = 5;
            this.colOrganizationName.Width = 54;
            // 
            // colStockName
            // 
            this.colStockName.Caption = "Склад";
            this.colStockName.FieldName = "StockName";
            this.colStockName.Name = "colStockName";
            this.colStockName.Visible = true;
            this.colStockName.VisibleIndex = 6;
            this.colStockName.Width = 54;
            // 
            // colDocumentTypeName
            // 
            this.colDocumentTypeName.Caption = "Тип документа";
            this.colDocumentTypeName.FieldName = "DocumentTypeName";
            this.colDocumentTypeName.Name = "colDocumentTypeName";
            this.colDocumentTypeName.Visible = true;
            this.colDocumentTypeName.VisibleIndex = 7;
            this.colDocumentTypeName.Width = 54;
            // 
            // colIsNDS
            // 
            this.colIsNDS.Caption = "НДС";
            this.colIsNDS.FieldName = "IsNDS";
            this.colIsNDS.Name = "colIsNDS";
            this.colIsNDS.Visible = true;
            this.colIsNDS.VisibleIndex = 8;
            this.colIsNDS.Width = 54;
            // 
            // colTradePutletName
            // 
            this.colTradePutletName.Caption = "Торговая точка";
            this.colTradePutletName.FieldName = "TradePutletName";
            this.colTradePutletName.Name = "colTradePutletName";
            this.colTradePutletName.Visible = true;
            this.colTradePutletName.VisibleIndex = 9;
            this.colTradePutletName.Width = 54;
            // 
            // colFullAuthorModif
            // 
            this.colFullAuthorModif.Caption = "Изменен";
            this.colFullAuthorModif.FieldName = "FullAuthorModif";
            this.colFullAuthorModif.Name = "colFullAuthorModif";
            this.colFullAuthorModif.Visible = true;
            this.colFullAuthorModif.VisibleIndex = 10;
            this.colFullAuthorModif.Width = 54;
            // 
            // colFullAuthorCreate
            // 
            this.colFullAuthorCreate.Caption = "Создан";
            this.colFullAuthorCreate.FieldName = "FullAuthorCreate";
            this.colFullAuthorCreate.Name = "colFullAuthorCreate";
            this.colFullAuthorCreate.Visible = true;
            this.colFullAuthorCreate.VisibleIndex = 11;
            this.colFullAuthorCreate.Width = 59;
            // 
            // colPurchSum
            // 
            this.colPurchSum.Caption = "Сумма без НДС";
            this.colPurchSum.FieldName = "PurchSum";
            this.colPurchSum.Name = "colPurchSum";
            this.colPurchSum.Visible = true;
            this.colPurchSum.VisibleIndex = 2;
            this.colPurchSum.Width = 99;
            // 
            // colPurchNDS
            // 
            this.colPurchNDS.Caption = "НДС";
            this.colPurchNDS.FieldName = "PurchNDS";
            this.colPurchNDS.Name = "colPurchNDS";
            this.colPurchNDS.Visible = true;
            this.colPurchNDS.VisibleIndex = 3;
            this.colPurchNDS.Width = 55;
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
            // ReceiptMasterNewAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "ReceiptMasterNewAll";
            this.Size = new System.Drawing.Size(740, 361);
            this.Load += new System.EventHandler(this.ReceiptMasterNew_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptMasterNewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptMasterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private DevExpress.XtraGrid.GridControl gridControl1;
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
    }
}
