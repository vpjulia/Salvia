namespace SanSee
{
    partial class UCSPR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCSPR));
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tSClose = new System.Windows.Forms.ToolStripButton();
            this.tBEdit = new System.Windows.Forms.ToolStripButton();
            this.tbSave = new System.Windows.Forms.ToolStripButton();
            this.tBCancel = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новаяЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mDataSet = new SanSee.MDataSet();
            this.sPRCountryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPR_CountryTableAdapter = new SanSee.MDataSetTableAdapters.SPR_CountryTableAdapter();
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LUCountry = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.LUpFarm_Group = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.sPRFarmGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sPR_Farm_GroupTableAdapter = new SanSee.MDataSetTableAdapters.SPR_Farm_GroupTableAdapter();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPRCountryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUpFarm_Group)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPRFarmGroupBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 295);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 40);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbAdd,
            this.toolStripSeparator1,
            this.tSClose,
            this.tBEdit,
            this.tbSave,
            this.tBCancel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(390, 39);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbAdd
            // 
            this.tbAdd.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tbAdd.Image")));
            this.tbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbAdd.Name = "tbAdd";
            this.tbAdd.Size = new System.Drawing.Size(93, 36);
            this.tbAdd.Text = "Добавить";
            this.tbAdd.ToolTipText = "Добавить запись";
            this.tbAdd.Click += new System.EventHandler(this.tbAdd_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // tSClose
            // 
            this.tSClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tSClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSClose.Image = ((System.Drawing.Image)(resources.GetObject("tSClose.Image")));
            this.tSClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSClose.Name = "tSClose";
            this.tSClose.Size = new System.Drawing.Size(36, 36);
            this.tSClose.Text = "toolStripButton1";
            this.tSClose.Click += new System.EventHandler(this.tSClose_Click);
            // 
            // tBEdit
            // 
            this.tBEdit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tBEdit.Image = ((System.Drawing.Image)(resources.GetObject("tBEdit.Image")));
            this.tBEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBEdit.Name = "tBEdit";
            this.tBEdit.Size = new System.Drawing.Size(91, 36);
            this.tBEdit.Text = "Изменить";
            this.tBEdit.ToolTipText = "Редактировать справочник";
            this.tBEdit.Click += new System.EventHandler(this.tBEdit_Click);
            // 
            // tbSave
            // 
            this.tbSave.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tbSave.Image = ((System.Drawing.Image)(resources.GetObject("tbSave.Image")));
            this.tbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbSave.Name = "tbSave";
            this.tbSave.Size = new System.Drawing.Size(98, 36);
            this.tbSave.Text = "Сохранить";
            this.tbSave.ToolTipText = "Сохранить изменения";
            this.tbSave.Click += new System.EventHandler(this.tbSave_Click);
            // 
            // tBCancel
            // 
            this.tBCancel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tBCancel.Image = ((System.Drawing.Image)(resources.GetObject("tBCancel.Image")));
            this.tBCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBCancel.Name = "tBCancel";
            this.tBCancel.Size = new System.Drawing.Size(81, 36);
            this.tBCancel.Text = "Отмена";
            this.tBCancel.ToolTipText = "Отменить изменения";
            this.tBCancel.Click += new System.EventHandler(this.tBCancel_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменитьToolStripMenuItem,
            this.новаяЗаписьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(154, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.tBEdit_Click);
            // 
            // новаяЗаписьToolStripMenuItem
            // 
            this.новаяЗаписьToolStripMenuItem.Name = "новаяЗаписьToolStripMenuItem";
            this.новаяЗаписьToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.новаяЗаписьToolStripMenuItem.Text = "Новая запись";
            this.новаяЗаписьToolStripMenuItem.Click += new System.EventHandler(this.tbAdd_Click);
            // 
            // mDataSet
            // 
            this.mDataSet.DataSetName = "MDataSet";
            this.mDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPRCountryBindingSource
            // 
            this.sPRCountryBindingSource.DataMember = "SPR_Country";
            this.sPRCountryBindingSource.DataSource = this.mDataSet;
            // 
            // sPR_CountryTableAdapter
            // 
            this.sPR_CountryTableAdapter.ClearBeforeFill = true;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.EmbeddedNavigator.Name = "";
            this.grid.Location = new System.Drawing.Point(0, 39);
            this.grid.MainView = this.gridView1;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.LUCountry,
            this.LUpFarm_Group});
            this.grid.Size = new System.Drawing.Size(390, 256);
            this.grid.TabIndex = 3;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gridView1.GridControl = this.grid;
            this.gridView1.GroupPanelText = "Группировать";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // LUCountry
            // 
            this.LUCountry.AutoHeight = false;
            this.LUCountry.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUCountry.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name_country", "Name_country", 76, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.LUCountry.DisplayMember = "Name_country";
            this.LUCountry.Name = "LUCountry";
            this.LUCountry.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.LUCountry.ValueMember = "ID_country";
            // 
            // LUpFarm_Group
            // 
            this.LUpFarm_Group.AutoHeight = false;
            this.LUpFarm_Group.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUpFarm_Group.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME_FG", "NAME_FG", 53, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.LUpFarm_Group.DisplayMember = "NAME_FG";
            this.LUpFarm_Group.Name = "LUpFarm_Group";
            this.LUpFarm_Group.ValueMember = "ID_FG";
            // 
            // sPRFarmGroupBindingSource
            // 
            this.sPRFarmGroupBindingSource.DataMember = "SPR_Farm_Group";
            this.sPRFarmGroupBindingSource.DataSource = this.mDataSet;
            // 
            // sPR_Farm_GroupTableAdapter
            // 
            this.sPR_Farm_GroupTableAdapter.ClearBeforeFill = true;
            // 
            // UCSPR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "UCSPR";
            this.Size = new System.Drawing.Size(390, 335);
            this.Load += new System.EventHandler(this.UCSPR_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPRCountryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUpFarm_Group)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPRFarmGroupBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tSClose;
        private System.Windows.Forms.ToolStripButton tBEdit;
        private System.Windows.Forms.ToolStripButton tbSave;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новаяЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tBCancel;
        private MDataSet mDataSet;
        private System.Windows.Forms.BindingSource sPRCountryBindingSource;
        private SanSee.MDataSetTableAdapters.SPR_CountryTableAdapter sPR_CountryTableAdapter;
        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LUCountry;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LUpFarm_Group;
        private System.Windows.Forms.BindingSource sPRFarmGroupBindingSource;
        private SanSee.MDataSetTableAdapters.SPR_Farm_GroupTableAdapter sPR_Farm_GroupTableAdapter;
    }
}
