namespace RetailTrade.Receipt
{
    partial class ReceiptImport
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
            this.btFind = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.farmTrade = new RetailTrade.FarmTrade();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colpharmtrade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfirm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsclcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsclname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkolvo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcena = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcenands = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colserie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltgodn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsclcode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fullDataSet = new RetailTrade.FullDataSet();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.productTableAdapter = new RetailTrade.FullDataSetTableAdapters.ProductTableAdapter();
            this.colsclname1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.toolStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmTrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 419);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(619, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btFind});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(619, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btFind
            // 
            this.btFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(38, 22);
            this.btFind.Text = "Find";
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.DataBindings.Add(new System.Windows.Forms.Binding("SplitterDistance", global::RetailTrade.Properties.Settings.Default, "impSplitDist", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.listBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grid);
            this.splitContainer1.Size = new System.Drawing.Size(619, 394);
            this.splitContainer1.SplitterDistance = global::RetailTrade.Properties.Settings.Default.impSplitDist;
            this.splitContainer1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(233, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 164);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "firm", true));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "1";
            this.bindingSource1.DataSource = this.farmTrade;
            // 
            // farmTrade
            // 
            this.farmTrade.DataSetName = "FarmTrade";
            this.farmTrade.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(233, 164);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // grid
            // 
            this.grid.DataSource = this.bindingSource1;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.EmbeddedNavigator.Name = "";
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.gridView1;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ProductLookUpEdit,
            this.repositoryItemLookUpEdit1});
            this.grid.Size = new System.Drawing.Size(619, 226);
            this.grid.TabIndex = 2;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colpharmtrade,
            this.colfirm,
            this.colsclcode,
            this.colsclname,
            this.colkolvo,
            this.colcena,
            this.colcenands,
            this.colserie,
            this.coltgodn,
            this.colsclcode1,
            this.colsclname1});
            this.gridView1.GridControl = this.grid;
            this.gridView1.Name = "gridView1";
            // 
            // colpharmtrade
            // 
            this.colpharmtrade.Caption = "pharmtrade";
            this.colpharmtrade.FieldName = "pharmtrade";
            this.colpharmtrade.Name = "colpharmtrade";
            this.colpharmtrade.Visible = true;
            this.colpharmtrade.VisibleIndex = 4;
            // 
            // colfirm
            // 
            this.colfirm.Caption = "firm";
            this.colfirm.FieldName = "firm";
            this.colfirm.Name = "colfirm";
            this.colfirm.Visible = true;
            this.colfirm.VisibleIndex = 5;
            // 
            // colsclcode
            // 
            this.colsclcode.Caption = "sclcode";
            this.colsclcode.FieldName = "sclcode";
            this.colsclcode.Name = "colsclcode";
            this.colsclcode.Visible = true;
            this.colsclcode.VisibleIndex = 0;
            // 
            // colsclname
            // 
            this.colsclname.Caption = "sclname";
            this.colsclname.FieldName = "sclname";
            this.colsclname.Name = "colsclname";
            this.colsclname.Visible = true;
            this.colsclname.VisibleIndex = 1;
            // 
            // colkolvo
            // 
            this.colkolvo.Caption = "kolvo";
            this.colkolvo.FieldName = "kolvo";
            this.colkolvo.Name = "colkolvo";
            this.colkolvo.Visible = true;
            this.colkolvo.VisibleIndex = 2;
            // 
            // colcena
            // 
            this.colcena.Caption = "cena";
            this.colcena.FieldName = "cena";
            this.colcena.Name = "colcena";
            this.colcena.Visible = true;
            this.colcena.VisibleIndex = 3;
            // 
            // colcenands
            // 
            this.colcenands.Caption = "cenands";
            this.colcenands.FieldName = "cenands";
            this.colcenands.Name = "colcenands";
            // 
            // colserie
            // 
            this.colserie.Caption = "serie";
            this.colserie.FieldName = "serie";
            this.colserie.Name = "colserie";
            // 
            // coltgodn
            // 
            this.coltgodn.Caption = "tgodn";
            this.coltgodn.FieldName = "tgodn";
            this.coltgodn.Name = "coltgodn";
            // 
            // colsclcode1
            // 
            this.colsclcode1.Caption = "sclcode";
            this.colsclcode1.ColumnEdit = this.ProductLookUpEdit;
            this.colsclcode1.FieldName = "sclcode";
            this.colsclcode1.Name = "colsclcode1";
            this.colsclcode1.Visible = true;
            this.colsclcode1.VisibleIndex = 6;
            // 
            // ProductLookUpEdit
            // 
            this.ProductLookUpEdit.AutoHeight = false;
            this.ProductLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ProductLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 39, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("OldKol", "OldKol", 42, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("OldName", "OldName", 58, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.ProductLookUpEdit.DataSource = this.productBindingSource;
            this.ProductLookUpEdit.DisplayMember = "OldName";
            this.ProductLookUpEdit.Name = "ProductLookUpEdit";
            this.ProductLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.ProductLookUpEdit.ValidateOnEnterKey = true;
            this.ProductLookUpEdit.ValueMember = "ID";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.fullDataSet;
            // 
            // fullDataSet
            // 
            this.fullDataSet.DataSetName = "FullDataSet";
            this.fullDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.grid;
            this.gridView2.Name = "gridView2";
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // colsclname1
            // 
            this.colsclname1.Caption = "sclname";
            this.colsclname1.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colsclname1.FieldName = "sclname";
            this.colsclname1.Name = "colsclname1";
            this.colsclname1.Visible = true;
            this.colsclname1.VisibleIndex = 7;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 39, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("OldKol", "OldKol", 42, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("OldName", "OldName", 58, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEdit1.DataSource = this.productBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "Name";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "OldName";
            // 
            // ReceiptImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Tag", global::RetailTrade.Properties.Settings.Default, "ImpDataSource", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Name = "ReceiptImport";
            this.Size = new System.Drawing.Size(619, 441);
            this.Tag = global::RetailTrade.Properties.Settings.Default.ImpDataSource;
            this.Load += new System.EventHandler(this.ReceiptImport_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmTrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox listBox1;
        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colpharmtrade;
        private DevExpress.XtraGrid.Columns.GridColumn colfirm;
        private DevExpress.XtraGrid.Columns.GridColumn colsclcode;
        private DevExpress.XtraGrid.Columns.GridColumn colsclname;
        private DevExpress.XtraGrid.Columns.GridColumn colkolvo;
        private DevExpress.XtraGrid.Columns.GridColumn colcenands;
        private DevExpress.XtraGrid.Columns.GridColumn colserie;
        private DevExpress.XtraGrid.Columns.GridColumn coltgodn;
        private DevExpress.XtraGrid.Columns.GridColumn colcena;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private FarmTrade farmTrade;
        private DevExpress.XtraGrid.Columns.GridColumn colsclcode1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ProductLookUpEdit;
        private System.Windows.Forms.BindingSource productBindingSource;
        private FullDataSet fullDataSet;
        private RetailTrade.FullDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.ToolStripButton btFind;
        private DevExpress.XtraGrid.Columns.GridColumn colsclname1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
     
    }
}
