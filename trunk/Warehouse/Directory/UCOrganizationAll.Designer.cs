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
            this.btAdd = new System.Windows.Forms.ToolStripButton();
            this.btEdit = new System.Windows.Forms.ToolStripButton();
            this.btDel = new System.Windows.Forms.ToolStripButton();
            this.btSave = new System.Windows.Forms.ToolStripButton();
            this.btClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.btField = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.organizationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mDataSet = new RetailTrade.MDataSet();
            this.gridViewOrgns = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShortName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.colDateCreate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateLastModif = new DevExpress.XtraGrid.Columns.GridColumn();
            this.organizationTableAdapter = new RetailTrade.MDataSetTableAdapters.OrganizationTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrgns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btAdd,
            this.btEdit,
            this.btDel,
            this.btSave,
            this.btClose,
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(640, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btAdd
            // 
            this.btAdd.Image = global::RetailTrade.Properties.Resources.document_add;
            this.btAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(94, 22);
            this.btAdd.Text = "Добавить";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btEdit
            // 
            this.btEdit.Image = global::RetailTrade.Properties.Resources.document_edit;
            this.btEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(95, 22);
            this.btEdit.Text = "Изменить";
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDel
            // 
            this.btDel.Image = global::RetailTrade.Properties.Resources.cut;
            this.btDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(85, 22);
            this.btDel.Text = "Удалить";
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btSave
            // 
            this.btSave.Enabled = false;
            this.btSave.Image = global::RetailTrade.Properties.Resources.document_check;
            this.btSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(101, 22);
            this.btSave.Text = "Сохранить";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btClose
            // 
            this.btClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btClose.Image = global::RetailTrade.Properties.Resources.delete2;
            this.btClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(23, 22);
            this.btClose.Text = "X";
            this.btClose.ToolTipText = "Выйти";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btField});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(16, 22);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // btField
            // 
            this.btField.Name = "btField";
            this.btField.Size = new System.Drawing.Size(208, 22);
            this.btField.Text = "Настройка полей";
            this.btField.Click += new System.EventHandler(this.btField_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 503);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(640, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // grid
            // 
            this.grid.DataSource = this.organizationBindingSource;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.EmbeddedNavigator.Name = "";
            this.grid.Location = new System.Drawing.Point(0, 25);
            this.grid.MainView = this.gridViewOrgns;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(640, 478);
            this.grid.TabIndex = 2;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewOrgns});
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
            // gridViewOrgns
            // 
            this.gridViewOrgns.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.gridViewOrgns.Appearance.FocusedRow.Options.UseFont = true;
            this.gridViewOrgns.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colShortName,
            this.colName,
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
            this.colAuthorLastModif,
            this.colDateCreate,
            this.colDateLastModif});
            this.gridViewOrgns.GridControl = this.grid;
            this.gridViewOrgns.Name = "gridViewOrgns";
            this.gridViewOrgns.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridViewOrgns.OptionsBehavior.Editable = false;
            this.gridViewOrgns.OptionsDetail.EnableMasterViewMode = false;
            this.gridViewOrgns.DoubleClick += new System.EventHandler(this.gridView_DoubleClick);
            // 
            // colID
            // 
            this.colID.Caption = "Код";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.ReadOnly = true;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 69;
            // 
            // colShortName
            // 
            this.colShortName.Caption = "Краткое";
            this.colShortName.FieldName = "ShortName";
            this.colShortName.Name = "colShortName";
            this.colShortName.Visible = true;
            this.colShortName.VisibleIndex = 2;
            this.colShortName.Width = 154;
            // 
            // colName
            // 
            this.colName.Caption = "Наименование";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 154;
            // 
            // colDirector
            // 
            this.colDirector.Caption = "Директор";
            this.colDirector.FieldName = "Director";
            this.colDirector.Name = "colDirector";
            // 
            // colAdress
            // 
            this.colAdress.Caption = "Адрес";
            this.colAdress.FieldName = "Adress";
            this.colAdress.Name = "colAdress";
            // 
            // colAddress_jur
            // 
            this.colAddress_jur.Caption = "Юридический адрес";
            this.colAddress_jur.FieldName = "Address_jur";
            this.colAddress_jur.Name = "colAddress_jur";
            // 
            // colOKPO
            // 
            this.colOKPO.Caption = "ОКПО";
            this.colOKPO.FieldName = "OKPO";
            this.colOKPO.Name = "colOKPO";
            // 
            // colBankName
            // 
            this.colBankName.Caption = "Банк";
            this.colBankName.FieldName = "BankName";
            this.colBankName.Name = "colBankName";
            // 
            // colBankMFO
            // 
            this.colBankMFO.Caption = "МФО";
            this.colBankMFO.FieldName = "BankMFO";
            this.colBankMFO.Name = "colBankMFO";
            // 
            // colINN
            // 
            this.colINN.Caption = "ИИН";
            this.colINN.FieldName = "INN";
            this.colINN.Name = "colINN";
            // 
            // colNumSvid
            // 
            this.colNumSvid.Caption = "№свидетельства";
            this.colNumSvid.FieldName = "NumSvid";
            this.colNumSvid.Name = "colNumSvid";
            // 
            // colNumSvidChp
            // 
            this.colNumSvidChp.Caption = "ЧП,Свидельство";
            this.colNumSvidChp.FieldName = "NumSvidChp";
            this.colNumSvidChp.Name = "colNumSvidChp";
            // 
            // colPassChp
            // 
            this.colPassChp.Caption = "ЧП,паспорт";
            this.colPassChp.FieldName = "PassChp";
            this.colPassChp.Name = "colPassChp";
            // 
            // colPhone
            // 
            this.colPhone.Caption = "Телефон";
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 3;
            this.colPhone.Width = 157;
            // 
            // colLicense
            // 
            this.colLicense.Caption = "Лицензия";
            this.colLicense.FieldName = "License";
            this.colLicense.Name = "colLicense";
            // 
            // colNote
            // 
            this.colNote.Caption = "Примечание";
            this.colNote.FieldName = "Note";
            this.colNote.Name = "colNote";
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
            // organizationTableAdapter
            // 
            this.organizationTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UCOrganizationAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "UCOrganizationAll";
            this.Size = new System.Drawing.Size(640, 525);
            this.Load += new System.EventHandler(this.UCOrganizationAll_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewOrgns)).EndInit();
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
        public DevExpress.XtraGrid.Views.Grid.GridView gridViewOrgns;
        private System.Windows.Forms.ToolStripButton btEdit;
        private System.Windows.Forms.ToolStripButton btAdd;
        private System.Windows.Forms.ToolStripButton btDel;
        private System.Windows.Forms.ToolStripButton btSave;
        private System.Windows.Forms.ToolStripButton btClose;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreate;
        private DevExpress.XtraGrid.Columns.GridColumn colDateLastModif;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem btField;
    }
}
