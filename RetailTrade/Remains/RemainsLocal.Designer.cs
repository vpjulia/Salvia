namespace RetailTrade.Remains
{
    partial class RemainsLocal
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.remainsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mDataSet = new RetailTrade.MDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colReceiptDetailRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantityReceipt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantityRemains = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorCreate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorLastModif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRowVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remainsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 484);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(707, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(707, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // grid
            // 
            this.grid.DataSource = this.remainsBindingSource;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            this.grid.EmbeddedNavigator.Name = "";
            this.grid.Location = new System.Drawing.Point(0, 25);
            this.grid.MainView = this.gridView1;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(707, 459);
            this.grid.TabIndex = 2;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // remainsBindingSource
            // 
            this.remainsBindingSource.DataMember = "Remains";
            this.remainsBindingSource.DataSource = this.mDataSet;
            // 
            // mDataSet
            // 
            this.mDataSet.DataSetName = "MDataSet";
            this.mDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colReceiptDetailRef,
            this.colQuantityReceipt,
            this.colQuantityRemains,
            this.colAuthorCreate,
            this.colAuthorLastModif,
            this.colDateCreate,
            this.colRowVersion});
            this.gridView1.GridControl = this.grid;
            this.gridView1.Name = "gridView1";
            // 
            // colReceiptDetailRef
            // 
            this.colReceiptDetailRef.Caption = "ReceiptDetailRef";
            this.colReceiptDetailRef.FieldName = "ReceiptDetailRef";
            this.colReceiptDetailRef.Name = "colReceiptDetailRef";
            this.colReceiptDetailRef.Visible = true;
            this.colReceiptDetailRef.VisibleIndex = 0;
            // 
            // colQuantityReceipt
            // 
            this.colQuantityReceipt.Caption = "QuantityReceipt";
            this.colQuantityReceipt.FieldName = "QuantityReceipt";
            this.colQuantityReceipt.Name = "colQuantityReceipt";
            this.colQuantityReceipt.Visible = true;
            this.colQuantityReceipt.VisibleIndex = 1;
            // 
            // colQuantityRemains
            // 
            this.colQuantityRemains.Caption = "QuantityRemains";
            this.colQuantityRemains.FieldName = "QuantityRemains";
            this.colQuantityRemains.Name = "colQuantityRemains";
            this.colQuantityRemains.Visible = true;
            this.colQuantityRemains.VisibleIndex = 2;
            // 
            // colAuthorCreate
            // 
            this.colAuthorCreate.Caption = "AuthorCreate";
            this.colAuthorCreate.FieldName = "AuthorCreate";
            this.colAuthorCreate.Name = "colAuthorCreate";
            this.colAuthorCreate.Visible = true;
            this.colAuthorCreate.VisibleIndex = 3;
            // 
            // colAuthorLastModif
            // 
            this.colAuthorLastModif.Caption = "AuthorLastModif";
            this.colAuthorLastModif.FieldName = "AuthorLastModif";
            this.colAuthorLastModif.Name = "colAuthorLastModif";
            this.colAuthorLastModif.Visible = true;
            this.colAuthorLastModif.VisibleIndex = 4;
            // 
            // colDateCreate
            // 
            this.colDateCreate.Caption = "DateCreate";
            this.colDateCreate.FieldName = "DateCreate";
            this.colDateCreate.Name = "colDateCreate";
            this.colDateCreate.Visible = true;
            this.colDateCreate.VisibleIndex = 5;
            // 
            // colRowVersion
            // 
            this.colRowVersion.Caption = "RowVersion";
            this.colRowVersion.FieldName = "RowVersion";
            this.colRowVersion.Name = "colRowVersion";
            this.colRowVersion.OptionsColumn.ReadOnly = true;
            this.colRowVersion.Visible = true;
            this.colRowVersion.VisibleIndex = 6;
            // 
            // Remains
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Remains";
            this.Size = new System.Drawing.Size(707, 506);
            this.Load += new System.EventHandler(this.Remains_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remainsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private MDataSet mDataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colReceiptDetailRef;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantityReceipt;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantityRemains;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorCreate;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorLastModif;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreate;
        private DevExpress.XtraGrid.Columns.GridColumn colRowVersion;
        private System.Windows.Forms.BindingSource remainsBindingSource;
    }
}
