namespace RetailTrade.Directory
{
    partial class UCTradePuplet
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
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsNDS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsLocal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTradePupletRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorCreate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorLastModif1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.tradePutletBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mDataSet = new RetailTrade.MDataSet();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorCreate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorLastModif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradePutletBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID1,
            this.colName1,
            this.colIsNDS,
            this.colIsLocal,
            this.colTradePupletRef,
            this.colAuthorCreate1,
            this.colAuthorLastModif1,
            this.colDateCreate,
            this.colRowVersion});
            this.gridView2.GridControl = this.grid;
            this.gridView2.Name = "gridView2";
            // 
            // colID1
            // 
            this.colID1.Caption = "ID";
            this.colID1.FieldName = "ID";
            this.colID1.Name = "colID1";
            this.colID1.OptionsColumn.ReadOnly = true;
            this.colID1.Visible = true;
            this.colID1.VisibleIndex = 0;
            // 
            // colName1
            // 
            this.colName1.Caption = "Name";
            this.colName1.FieldName = "Name";
            this.colName1.Name = "colName1";
            this.colName1.Visible = true;
            this.colName1.VisibleIndex = 1;
            // 
            // colIsNDS
            // 
            this.colIsNDS.Caption = "IsNDS";
            this.colIsNDS.FieldName = "IsNDS";
            this.colIsNDS.Name = "colIsNDS";
            this.colIsNDS.Visible = true;
            this.colIsNDS.VisibleIndex = 2;
            // 
            // colIsLocal
            // 
            this.colIsLocal.Caption = "IsLocal";
            this.colIsLocal.FieldName = "IsLocal";
            this.colIsLocal.Name = "colIsLocal";
            // 
            // colTradePupletRef
            // 
            this.colTradePupletRef.Caption = "TradePupletRef";
            this.colTradePupletRef.FieldName = "TradePupletRef";
            this.colTradePupletRef.Name = "colTradePupletRef";
            // 
            // colAuthorCreate1
            // 
            this.colAuthorCreate1.Caption = "AuthorCreate";
            this.colAuthorCreate1.FieldName = "AuthorCreate";
            this.colAuthorCreate1.Name = "colAuthorCreate1";
            // 
            // colAuthorLastModif1
            // 
            this.colAuthorLastModif1.Caption = "AuthorLastModif";
            this.colAuthorLastModif1.FieldName = "AuthorLastModif";
            this.colAuthorLastModif1.Name = "colAuthorLastModif1";
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
            // grid
            // 
            this.grid.DataSource = this.tradePutletBindingSource;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            this.grid.EmbeddedNavigator.Name = "";
            gridLevelNode1.LevelTemplate = this.gridView2;
            gridLevelNode1.RelationName = "TradePutlet_Stock";
            this.grid.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grid.Location = new System.Drawing.Point(0, 25);
            this.grid.MainView = this.gridView;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(558, 450);
            this.grid.TabIndex = 2;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView,
            this.gridView2});
            // 
            // tradePutletBindingSource
            // 
            this.tradePutletBindingSource.DataMember = "TradePutlet";
            this.tradePutletBindingSource.DataSource = this.mDataSet;
            // 
            // mDataSet
            // 
            this.mDataSet.DataSetName = "MDataSet";
            this.mDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colName,
            this.colAdress,
            this.colIP,
            this.colAuthorCreate,
            this.colAuthorLastModif});
            this.gridView.GridControl = this.grid;
            this.gridView.Name = "gridView";
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
            // colName
            // 
            this.colName.Caption = "Name";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // colAdress
            // 
            this.colAdress.Caption = "Adress";
            this.colAdress.FieldName = "Adress";
            this.colAdress.Name = "colAdress";
            this.colAdress.Visible = true;
            this.colAdress.VisibleIndex = 3;
            // 
            // colIP
            // 
            this.colIP.Caption = "IP";
            this.colIP.FieldName = "IP";
            this.colIP.Name = "colIP";
            this.colIP.Visible = true;
            this.colIP.VisibleIndex = 2;
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
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 475);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(558, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(558, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // UCTradePuplet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "UCTradePuplet";
            this.Size = new System.Drawing.Size(558, 497);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradePutletBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.BindingSource tradePutletBindingSource;
        private MDataSet mDataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colID1;
        private DevExpress.XtraGrid.Columns.GridColumn colName1;
        private DevExpress.XtraGrid.Columns.GridColumn colIsNDS;
        private DevExpress.XtraGrid.Columns.GridColumn colTradePupletRef;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorCreate1;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorLastModif1;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreate;
        private DevExpress.XtraGrid.Columns.GridColumn colRowVersion;
        private DevExpress.XtraGrid.Columns.GridColumn colIsLocal;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colAdress;
        private DevExpress.XtraGrid.Columns.GridColumn colIP;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorCreate;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorLastModif;
        public DevExpress.XtraGrid.GridControl grid;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView;
    }
}
