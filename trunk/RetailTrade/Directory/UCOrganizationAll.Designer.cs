namespace RetailTrade
{
    partial class UCOrganizationAll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCOrganizationAll));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.organizationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mDataSet = new RetailTrade.MDataSet();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShortName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDirector = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress_jur = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOKPO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankMFO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumSvid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumSvidChp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassChp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLicense = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorCreate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthorLastModif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.organizationTableAdapter = new RetailTrade.MDataSetTableAdapters.OrganizationTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(410, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 313);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(410, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // grid
            // 
            this.grid.DataSource = this.organizationBindingSource;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            this.grid.EmbeddedNavigator.Name = "";
            this.grid.Location = new System.Drawing.Point(0, 25);
            this.grid.MainView = this.gridView;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(410, 288);
            this.grid.TabIndex = 2;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // organizationBindingSource
            // 
            this.organizationBindingSource.DataMember = "Organization";
            this.organizationBindingSource.DataSource = this.mDataSet;
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
            this.colShortName,
            this.colDirector,
            this.colAdress,
            this.colAddress_jur,
            this.colOKPO,
            this.colBankName,
            this.colBankMFO,
            this.colINN,
            this.colNumSvid,
            this.colNumSvidChp,
            this.colPassChp,
            this.colPhone,
            this.colLicense,
            this.colNote,
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
            // colShortName
            // 
            this.colShortName.Caption = "ShortName";
            this.colShortName.FieldName = "ShortName";
            this.colShortName.Name = "colShortName";
            this.colShortName.Visible = true;
            this.colShortName.VisibleIndex = 2;
            // 
            // colDirector
            // 
            this.colDirector.Caption = "Director";
            this.colDirector.FieldName = "Director";
            this.colDirector.Name = "colDirector";
            this.colDirector.Visible = true;
            this.colDirector.VisibleIndex = 3;
            // 
            // colAdress
            // 
            this.colAdress.Caption = "Adress";
            this.colAdress.FieldName = "Adress";
            this.colAdress.Name = "colAdress";
            this.colAdress.Visible = true;
            this.colAdress.VisibleIndex = 4;
            // 
            // colAddress_jur
            // 
            this.colAddress_jur.Caption = "Address_jur";
            this.colAddress_jur.FieldName = "Address_jur";
            this.colAddress_jur.Name = "colAddress_jur";
            this.colAddress_jur.Visible = true;
            this.colAddress_jur.VisibleIndex = 5;
            // 
            // colOKPO
            // 
            this.colOKPO.Caption = "OKPO";
            this.colOKPO.FieldName = "OKPO";
            this.colOKPO.Name = "colOKPO";
            this.colOKPO.Visible = true;
            this.colOKPO.VisibleIndex = 6;
            // 
            // colBankName
            // 
            this.colBankName.Caption = "BankName";
            this.colBankName.FieldName = "BankName";
            this.colBankName.Name = "colBankName";
            this.colBankName.Visible = true;
            this.colBankName.VisibleIndex = 7;
            // 
            // colBankMFO
            // 
            this.colBankMFO.Caption = "BankMFO";
            this.colBankMFO.FieldName = "BankMFO";
            this.colBankMFO.Name = "colBankMFO";
            this.colBankMFO.Visible = true;
            this.colBankMFO.VisibleIndex = 8;
            // 
            // colINN
            // 
            this.colINN.Caption = "INN";
            this.colINN.FieldName = "INN";
            this.colINN.Name = "colINN";
            this.colINN.Visible = true;
            this.colINN.VisibleIndex = 9;
            // 
            // colNumSvid
            // 
            this.colNumSvid.Caption = "NumSvid";
            this.colNumSvid.FieldName = "NumSvid";
            this.colNumSvid.Name = "colNumSvid";
            this.colNumSvid.Visible = true;
            this.colNumSvid.VisibleIndex = 10;
            // 
            // colNumSvidChp
            // 
            this.colNumSvidChp.Caption = "NumSvidChp";
            this.colNumSvidChp.FieldName = "NumSvidChp";
            this.colNumSvidChp.Name = "colNumSvidChp";
            this.colNumSvidChp.Visible = true;
            this.colNumSvidChp.VisibleIndex = 11;
            // 
            // colPassChp
            // 
            this.colPassChp.Caption = "PassChp";
            this.colPassChp.FieldName = "PassChp";
            this.colPassChp.Name = "colPassChp";
            this.colPassChp.Visible = true;
            this.colPassChp.VisibleIndex = 12;
            // 
            // colPhone
            // 
            this.colPhone.Caption = "Phone";
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 13;
            // 
            // colLicense
            // 
            this.colLicense.Caption = "License";
            this.colLicense.FieldName = "License";
            this.colLicense.Name = "colLicense";
            this.colLicense.Visible = true;
            this.colLicense.VisibleIndex = 14;
            // 
            // colNote
            // 
            this.colNote.Caption = "Note";
            this.colNote.FieldName = "Note";
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 15;
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
            // organizationTableAdapter
            // 
            this.organizationTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // UCOrganizationAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "UCOrganizationAll";
            this.Size = new System.Drawing.Size(410, 335);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.BindingSource organizationBindingSource;
        private MDataSet mDataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colShortName;
        private DevExpress.XtraGrid.Columns.GridColumn colDirector;
        private DevExpress.XtraGrid.Columns.GridColumn colAdress;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress_jur;
        private DevExpress.XtraGrid.Columns.GridColumn colOKPO;
        private DevExpress.XtraGrid.Columns.GridColumn colBankName;
        private DevExpress.XtraGrid.Columns.GridColumn colBankMFO;
        private DevExpress.XtraGrid.Columns.GridColumn colINN;
        private DevExpress.XtraGrid.Columns.GridColumn colNumSvid;
        private DevExpress.XtraGrid.Columns.GridColumn colNumSvidChp;
        private DevExpress.XtraGrid.Columns.GridColumn colPassChp;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colLicense;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorCreate;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthorLastModif;
        private RetailTrade.MDataSetTableAdapters.OrganizationTableAdapter organizationTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public DevExpress.XtraGrid.GridControl grid;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}
