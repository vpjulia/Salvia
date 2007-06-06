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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.mDataSet = new RetailTrade.MDataSet();
            this.productTableAdapter = new RetailTrade.MDataSetTableAdapters.ProductTableAdapter();
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(732, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
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
            this.grid.MainView = this.gridView1;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(732, 555);
            this.grid.TabIndex = 1;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.mDataSet;
            // 
            // gridView1
            // 
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
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
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.GridControl = this.grid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.DataSource = this.productBindingSource;
            // 
            // UCProductAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.toolStrip1);
            this.Name = "UCProductAll";
            this.Size = new System.Drawing.Size(732, 580);
            this.Load += new System.EventHandler(this.UCProductAll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private MDataSet mDataSet;
        private RetailTrade.MDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
