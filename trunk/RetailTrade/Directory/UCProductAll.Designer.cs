namespace RetailTrade
{
    partial class UCProductAll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCProductAll));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btAdd = new System.Windows.Forms.ToolStripButton();
            this.btEdit = new System.Windows.Forms.ToolStripButton();
            this.btDel = new System.Windows.Forms.ToolStripButton();
            this.btSave = new System.Windows.Forms.ToolStripButton();
            this.btClose = new System.Windows.Forms.ToolStripButton();
            this.mDataSet = new RetailTrade.MDataSet();
            this.productTableAdapter = new RetailTrade.MDataSetTableAdapters.ProductTableAdapter();
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSmallName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriceManufact = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManufacturerRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsRecept = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsNDS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPackingRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStorageConditionRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubstanceRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFarmGroupRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFarmGrouplevel2Ref = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsOneRecept = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsVisible = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMinDivisor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorCreate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorLastModif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btAdd,
            this.btEdit,
            this.btDel,
            this.btSave,
            this.btClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(732, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btAdd
            // 
            this.btAdd.Image = ((System.Drawing.Image)(resources.GetObject("btAdd.Image")));
            this.btAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(94, 22);
            this.btAdd.Text = "Добавить";
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
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btSave
            // 
            this.btSave.Image = ((System.Drawing.Image)(resources.GetObject("btSave.Image")));
            this.btSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(101, 22);
            this.btSave.Text = "Сохранить";
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
            // 
            // mDataSet
            // 
            this.mDataSet.DataSetName = "MDataSet";
            this.mDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // grid
            // 
            this.grid.DataSource = this.productBindingSource;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            this.grid.EmbeddedNavigator.Name = "";
            this.errorProvider1.SetError(this.grid, "jj");
            this.grid.Location = new System.Drawing.Point(0, 25);
            this.grid.MainView = this.gridView;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(732, 530);
            this.grid.TabIndex = 1;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.mDataSet;
            // 
            // gridView
            // 
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colName,
            this.colSmallName,
            this.colPriceManufact,
            this.colManufacturerRef,
            this.colIsRecept,
            this.colIsNDS,
            this.colUnitRef,
            this.colPackingRef,
            this.colStorageConditionRef,
            this.colSubstanceRef,
            this.colFarmGroupRef,
            this.colFarmGrouplevel2Ref,
            this.colIsOneRecept,
            this.colIsVisible,
            this.colMinDivisor,
            this.colAuthorCreate,
            this.colAuthorLastModif,
            this.colDateCreate,
            this.colRowVersion});
            this.gridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView.GridControl = this.grid;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridView.OptionsView.ShowAutoFilterRow = true;
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colID.OptionsColumn.ReadOnly = true;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 44;
            // 
            // colName
            // 
            this.colName.Caption = "Name";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 118;
            // 
            // colSmallName
            // 
            this.colSmallName.Caption = "SmallName";
            this.colSmallName.FieldName = "SmallName";
            this.colSmallName.Name = "colSmallName";
            this.colSmallName.Visible = true;
            this.colSmallName.VisibleIndex = 2;
            this.colSmallName.Width = 38;
            // 
            // colPriceManufact
            // 
            this.colPriceManufact.Caption = "PriceManufact";
            this.colPriceManufact.FieldName = "PriceManufact";
            this.colPriceManufact.Name = "colPriceManufact";
            this.colPriceManufact.Visible = true;
            this.colPriceManufact.VisibleIndex = 3;
            this.colPriceManufact.Width = 38;
            // 
            // colManufacturerRef
            // 
            this.colManufacturerRef.Caption = "ManufacturerRef";
            this.colManufacturerRef.FieldName = "ManufacturerRef";
            this.colManufacturerRef.Name = "colManufacturerRef";
            this.colManufacturerRef.Visible = true;
            this.colManufacturerRef.VisibleIndex = 10;
            this.colManufacturerRef.Width = 38;
            // 
            // colIsRecept
            // 
            this.colIsRecept.Caption = "IsRecept";
            this.colIsRecept.FieldName = "IsRecept";
            this.colIsRecept.Name = "colIsRecept";
            this.colIsRecept.Visible = true;
            this.colIsRecept.VisibleIndex = 11;
            this.colIsRecept.Width = 38;
            // 
            // colIsNDS
            // 
            this.colIsNDS.Caption = "IsNDS";
            this.colIsNDS.FieldName = "IsNDS";
            this.colIsNDS.Name = "colIsNDS";
            this.colIsNDS.Visible = true;
            this.colIsNDS.VisibleIndex = 15;
            this.colIsNDS.Width = 60;
            // 
            // colUnitRef
            // 
            this.colUnitRef.Caption = "UnitRef";
            this.colUnitRef.FieldName = "UnitRef";
            this.colUnitRef.Name = "colUnitRef";
            this.colUnitRef.Visible = true;
            this.colUnitRef.VisibleIndex = 4;
            this.colUnitRef.Width = 38;
            // 
            // colPackingRef
            // 
            this.colPackingRef.Caption = "PackingRef";
            this.colPackingRef.FieldName = "PackingRef";
            this.colPackingRef.Name = "colPackingRef";
            this.colPackingRef.Visible = true;
            this.colPackingRef.VisibleIndex = 5;
            this.colPackingRef.Width = 38;
            // 
            // colStorageConditionRef
            // 
            this.colStorageConditionRef.Caption = "StorageConditionRef";
            this.colStorageConditionRef.FieldName = "StorageConditionRef";
            this.colStorageConditionRef.Name = "colStorageConditionRef";
            this.colStorageConditionRef.Visible = true;
            this.colStorageConditionRef.VisibleIndex = 6;
            this.colStorageConditionRef.Width = 38;
            // 
            // colSubstanceRef
            // 
            this.colSubstanceRef.Caption = "SubstanceRef";
            this.colSubstanceRef.FieldName = "SubstanceRef";
            this.colSubstanceRef.Name = "colSubstanceRef";
            this.colSubstanceRef.Visible = true;
            this.colSubstanceRef.VisibleIndex = 7;
            this.colSubstanceRef.Width = 38;
            // 
            // colFarmGroupRef
            // 
            this.colFarmGroupRef.Caption = "FarmGroupRef";
            this.colFarmGroupRef.FieldName = "FarmGroupRef";
            this.colFarmGroupRef.Name = "colFarmGroupRef";
            this.colFarmGroupRef.Visible = true;
            this.colFarmGroupRef.VisibleIndex = 8;
            this.colFarmGroupRef.Width = 38;
            // 
            // colFarmGrouplevel2Ref
            // 
            this.colFarmGrouplevel2Ref.Caption = "FarmGrouplevel2Ref";
            this.colFarmGrouplevel2Ref.FieldName = "FarmGrouplevel2Ref";
            this.colFarmGrouplevel2Ref.Name = "colFarmGrouplevel2Ref";
            this.colFarmGrouplevel2Ref.Visible = true;
            this.colFarmGrouplevel2Ref.VisibleIndex = 9;
            this.colFarmGrouplevel2Ref.Width = 38;
            // 
            // colIsOneRecept
            // 
            this.colIsOneRecept.Caption = "IsOneRecept";
            this.colIsOneRecept.FieldName = "IsOneRecept";
            this.colIsOneRecept.Name = "colIsOneRecept";
            this.colIsOneRecept.Visible = true;
            this.colIsOneRecept.VisibleIndex = 12;
            this.colIsOneRecept.Width = 38;
            // 
            // colIsVisible
            // 
            this.colIsVisible.Caption = "IsVisible";
            this.colIsVisible.FieldName = "IsVisible";
            this.colIsVisible.Name = "colIsVisible";
            this.colIsVisible.Visible = true;
            this.colIsVisible.VisibleIndex = 13;
            this.colIsVisible.Width = 38;
            // 
            // colMinDivisor
            // 
            this.colMinDivisor.Caption = "MinDivisor";
            this.colMinDivisor.FieldName = "MinDivisor";
            this.colMinDivisor.Name = "colMinDivisor";
            this.colMinDivisor.Visible = true;
            this.colMinDivisor.VisibleIndex = 14;
            this.colMinDivisor.Width = 38;
            // 
            // colAuthorCreate
            // 
            this.colAuthorCreate.Caption = "AuthorCreate";
            this.colAuthorCreate.FieldName = "AuthorCreate";
            this.colAuthorCreate.Name = "colAuthorCreate";
            // 
            // colAuthorLastModif
            // 
            this.colAuthorLastModif.Caption = "AuthorLastModif";
            this.colAuthorLastModif.FieldName = "AuthorLastModif";
            this.colAuthorLastModif.Name = "colAuthorLastModif";
            // 
            // colDateCreate
            // 
            this.colDateCreate.Caption = "DateCreate";
            this.colDateCreate.FieldName = "DateCreate";
            this.colDateCreate.Name = "colDateCreate";
            // 
            // colRowVersion
            // 
            this.colRowVersion.Caption = "RowVersion";
            this.colRowVersion.FieldName = "RowVersion";
            this.colRowVersion.Name = "colRowVersion";
            this.colRowVersion.OptionsColumn.ReadOnly = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.DataSource = this.productBindingSource;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btRefresh});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 555);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(732, 25);
            this.bindingNavigator1.TabIndex = 3;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 24);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btRefresh
            // 
            this.btRefresh.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btRefresh.Image")));
            this.btRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(23, 22);
            this.btRefresh.Text = "Обновить";
            // 
            // UCProductAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "UCProductAll";
            this.Size = new System.Drawing.Size(732, 580);
            this.Load += new System.EventHandler(this.UCProductAll_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private MDataSet mDataSet;
        private RetailTrade.MDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colSmallName;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceManufact;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitRef;
        private DevExpress.XtraGrid.Columns.GridColumn colPackingRef;
        private DevExpress.XtraGrid.Columns.GridColumn colStorageConditionRef;
        private DevExpress.XtraGrid.Columns.GridColumn colSubstanceRef;
        private DevExpress.XtraGrid.Columns.GridColumn colFarmGroupRef;
        private DevExpress.XtraGrid.Columns.GridColumn colFarmGrouplevel2Ref;
        private DevExpress.XtraGrid.Columns.GridColumn colManufacturerRef;
        private DevExpress.XtraGrid.Columns.GridColumn colIsRecept;
        private DevExpress.XtraGrid.Columns.GridColumn colIsOneRecept;
        private DevExpress.XtraGrid.Columns.GridColumn colIsVisible;
        private DevExpress.XtraGrid.Columns.GridColumn colMinDivisor;
        private DevExpress.XtraGrid.Columns.GridColumn colIsNDS;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorCreate;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorLastModif;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreate;
        private DevExpress.XtraGrid.Columns.GridColumn colRowVersion;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripButton btAdd;
        private System.Windows.Forms.ToolStripButton btEdit;
        private System.Windows.Forms.ToolStripButton btDel;
        private System.Windows.Forms.ToolStripButton btSave;
        private System.Windows.Forms.ToolStripButton btClose;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btRefresh;
    }
}
