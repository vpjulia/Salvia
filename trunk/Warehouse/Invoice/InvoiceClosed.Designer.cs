namespace RetailTrade.Invoice
{
    partial class InvoiceClosed
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
            this.gridViewInvClosdDet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManufacturerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriceRetailNDS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCalcSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.invoiceMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mDataSet = new RetailTrade.MDataSet();
            this.gridViewInvClosd = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrganisationRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.organizationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTradePupletName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNds = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorCreate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorLastModif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateLastModif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btMakeToNew = new System.Windows.Forms.ToolStripButton();
            this.PeriodsComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.btPeriod = new System.Windows.Forms.ToolStripButton();
            this.btClose = new System.Windows.Forms.ToolStripButton();
            this.btPrint = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.invoiceMasterTableAdapter = new RetailTrade.MDataSetTableAdapters.InvoiceMasterTableAdapter();
            this.organizationTableAdapter = new RetailTrade.MDataSetTableAdapters.OrganizationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInvClosdDet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInvClosd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridViewInvClosdDet
            // 
            this.gridViewInvClosdDet.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductName,
            this.colManufacturerName,
            this.colQuantity,
            this.colPriceRetailNDS,
            this.colCalcSum});
            this.gridViewInvClosdDet.GridControl = this.grid;
            this.gridViewInvClosdDet.Name = "gridViewInvClosdDet";
            this.gridViewInvClosdDet.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridViewInvClosdDet.OptionsBehavior.Editable = false;
            this.gridViewInvClosdDet.OptionsView.ColumnAutoWidth = false;
            this.gridViewInvClosdDet.OptionsView.ShowFooter = true;
            // 
            // colProductName
            // 
            this.colProductName.Caption = "������������";
            this.colProductName.FieldName = "ProductName";
            this.colProductName.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colProductName.Name = "colProductName";
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 0;
            this.colProductName.Width = 220;
            // 
            // colManufacturerName
            // 
            this.colManufacturerName.Caption = "������������";
            this.colManufacturerName.FieldName = "ManufacturerName";
            this.colManufacturerName.Name = "colManufacturerName";
            this.colManufacturerName.Visible = true;
            this.colManufacturerName.VisibleIndex = 1;
            this.colManufacturerName.Width = 162;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "���-��";
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 2;
            // 
            // colPriceRetailNDS
            // 
            this.colPriceRetailNDS.Caption = "����";
            this.colPriceRetailNDS.FieldName = "PriceRetailNDS";
            this.colPriceRetailNDS.Name = "colPriceRetailNDS";
            this.colPriceRetailNDS.Visible = true;
            this.colPriceRetailNDS.VisibleIndex = 3;
            this.colPriceRetailNDS.Width = 95;
            // 
            // colCalcSum
            // 
            this.colCalcSum.Caption = "�����";
            this.colCalcSum.FieldName = "CalcSum";
            this.colCalcSum.Name = "colCalcSum";
            this.colCalcSum.Visible = true;
            this.colCalcSum.VisibleIndex = 4;
            this.colCalcSum.Width = 113;
            // 
            // grid
            // 
            this.grid.DataSource = this.invoiceMasterBindingSource;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.grid.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.grid.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.grid.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.grid.EmbeddedNavigator.Buttons.NextPage.Visible = false;
            this.grid.EmbeddedNavigator.Buttons.PrevPage.Visible = false;
            this.grid.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.grid.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.grid.EmbeddedNavigator.Name = "";
            this.grid.EmbeddedNavigator.TextStringFormat = "������  {0} ��  {1}";
            gridLevelNode1.LevelTemplate = this.gridViewInvClosdDet;
            gridLevelNode1.RelationName = "FK_InvoiceDetail_InvoiceMaster";
            this.grid.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grid.Location = new System.Drawing.Point(0, 26);
            this.grid.MainView = this.gridViewInvClosd;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.grid.ShowOnlyPredefinedDetails = true;
            this.grid.Size = new System.Drawing.Size(676, 596);
            this.grid.TabIndex = 2;
            this.grid.UseEmbeddedNavigator = true;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewInvClosd,
            this.gridViewInvClosdDet});
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
            // gridViewInvClosd
            // 
            this.gridViewInvClosd.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.colOrganisationRef,
            this.colNumber,
            this.colDate,
            this.colTradePupletName,
            this.colSum,
            this.colNds,
            this.colAuthorCreate,
            this.colAuthorLastModif,
            this.colDateCreate,
            this.colNote,
            this.colDateLastModif});
            this.gridViewInvClosd.GridControl = this.grid;
            this.gridViewInvClosd.Name = "gridViewInvClosd";
            this.gridViewInvClosd.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridViewInvClosd.OptionsBehavior.Editable = false;
            this.gridViewInvClosd.OptionsView.ShowAutoFilterRow = true;
            this.gridViewInvClosd.OptionsView.ShowFooter = true;
            this.gridViewInvClosd.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDate, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // ID
            // 
            this.ID.Caption = "���";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.OptionsColumn.ReadOnly = true;
            // 
            // colOrganisationRef
            // 
            this.colOrganisationRef.Caption = "�����������";
            this.colOrganisationRef.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colOrganisationRef.FieldName = "OrganisationRef";
            this.colOrganisationRef.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colOrganisationRef.Name = "colOrganisationRef";
            this.colOrganisationRef.Visible = true;
            this.colOrganisationRef.VisibleIndex = 9;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 39, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEdit1.DataSource = this.organizationBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "Name";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEdit1.ValueMember = "ID";
            // 
            // organizationBindingSource
            // 
            this.organizationBindingSource.DataMember = "Organization";
            this.organizationBindingSource.DataSource = this.mDataSet;
            // 
            // colNumber
            // 
            this.colNumber.Caption = "�";
            this.colNumber.FieldName = "Number";
            this.colNumber.Name = "colNumber";
            this.colNumber.Visible = true;
            this.colNumber.VisibleIndex = 0;
            // 
            // colDate
            // 
            this.colDate.Caption = "����";
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 1;
            // 
            // colTradePupletName
            // 
            this.colTradePupletName.Caption = "�������� �����";
            this.colTradePupletName.FieldName = "TradePupletName";
            this.colTradePupletName.Name = "colTradePupletName";
            this.colTradePupletName.OptionsColumn.ReadOnly = true;
            this.colTradePupletName.Visible = true;
            this.colTradePupletName.VisibleIndex = 8;
            // 
            // colSum
            // 
            this.colSum.Caption = "�����";
            this.colSum.FieldName = "Sum";
            this.colSum.Name = "colSum";
            this.colSum.SummaryItem.DisplayFormat = "{0:##0.00}";
            this.colSum.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colSum.Visible = true;
            this.colSum.VisibleIndex = 2;
            // 
            // colNds
            // 
            this.colNds.Caption = "� �.�. ���";
            this.colNds.FieldName = "Nds";
            this.colNds.Name = "colNds";
            this.colNds.SummaryItem.DisplayFormat = "{0:##0.00}";
            this.colNds.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colNds.Visible = true;
            this.colNds.VisibleIndex = 3;
            // 
            // colAuthorCreate
            // 
            this.colAuthorCreate.Caption = "�����";
            this.colAuthorCreate.FieldName = "AuthorCreate";
            this.colAuthorCreate.Name = "colAuthorCreate";
            // 
            // colAuthorLastModif
            // 
            this.colAuthorLastModif.Caption = "��������";
            this.colAuthorLastModif.FieldName = "AuthorLastModif";
            this.colAuthorLastModif.Name = "colAuthorLastModif";
            this.colAuthorLastModif.Visible = true;
            this.colAuthorLastModif.VisibleIndex = 4;
            // 
            // colDateCreate
            // 
            this.colDateCreate.Caption = "������";
            this.colDateCreate.FieldName = "DateCreate";
            this.colDateCreate.Name = "colDateCreate";
            this.colDateCreate.Visible = true;
            this.colDateCreate.VisibleIndex = 5;
            // 
            // colNote
            // 
            this.colNote.Caption = "����.";
            this.colNote.FieldName = "Note";
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 6;
            // 
            // colDateLastModif
            // 
            this.colDateLastModif.Caption = "�������";
            this.colDateLastModif.FieldName = "DateLastModif";
            this.colDateLastModif.Name = "colDateLastModif";
            this.colDateLastModif.Visible = true;
            this.colDateLastModif.VisibleIndex = 7;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btMakeToNew,
            this.PeriodsComboBox,
            this.btPeriod,
            this.btClose,
            this.btPrint});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(676, 26);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btMakeToNew
            // 
            this.btMakeToNew.Image = global::RetailTrade.Properties.Resources.document_stop;
            this.btMakeToNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btMakeToNew.Name = "btMakeToNew";
            this.btMakeToNew.Size = new System.Drawing.Size(149, 23);
            this.btMakeToNew.Text = "������� �� �����";
            this.btMakeToNew.Click += new System.EventHandler(this.btMakeToNew_Click);
            // 
            // PeriodsComboBox
            // 
            this.PeriodsComboBox.Name = "PeriodsComboBox";
            this.PeriodsComboBox.Size = new System.Drawing.Size(121, 26);
            // 
            // btPeriod
            // 
            this.btPeriod.Image = global::RetailTrade.Properties.Resources.refresh;
            this.btPeriod.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btPeriod.Name = "btPeriod";
            this.btPeriod.Size = new System.Drawing.Size(97, 23);
            this.btPeriod.Text = "�� ������";
            this.btPeriod.Click += new System.EventHandler(this.btPeriod_Click);
            // 
            // btClose
            // 
            this.btClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btClose.Image = global::RetailTrade.Properties.Resources.delete2;
            this.btClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(23, 23);
            this.btClose.Text = "X";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btPrint
            // 
            this.btPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btPrint.Image = global::RetailTrade.Properties.Resources.view;
            this.btPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(23, 23);
            this.btPrint.Text = "��������";
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 622);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(676, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // invoiceMasterTableAdapter
            // 
            this.invoiceMasterTableAdapter.ClearBeforeFill = true;
            // 
            // organizationTableAdapter
            // 
            this.organizationTableAdapter.ClearBeforeFill = true;
            // 
            // InvoiceClosed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "InvoiceClosed";
            this.Size = new System.Drawing.Size(676, 644);
            this.Load += new System.EventHandler(this.InvoiceClosed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInvClosdDet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewInvClosd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox PeriodsComboBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewInvClosd;
        private System.Windows.Forms.ToolStripButton btPeriod;
        private System.Windows.Forms.BindingSource invoiceMasterBindingSource;
        private MDataSet mDataSet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewInvClosdDet;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
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
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colManufacturerName;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceRetailNDS;
        private DevExpress.XtraGrid.Columns.GridColumn colCalcSum;
        private System.Windows.Forms.ToolStripButton btPrint;
        private System.Windows.Forms.ToolStripButton btMakeToNew;
        private DevExpress.XtraGrid.Columns.GridColumn colOrganisationRef;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private System.Windows.Forms.BindingSource organizationBindingSource;
        private RetailTrade.MDataSetTableAdapters.OrganizationTableAdapter organizationTableAdapter;
    }
}
