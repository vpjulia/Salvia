namespace SanSee
{
    partial class UC_SPR_TOV
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
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкаПолейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_TOV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName_Tov = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Name_TovItemTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colSmall_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Small_NameItemTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colID_IZG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IzgItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colCena_IZG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDF_EI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EI_ItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colIDF_Form = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FormItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colIDF_Place = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PlaceItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colIDF_Sbc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SubstanceItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colIDF_FG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FgItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colIDF_FG2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FG2ItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.sPRFarmGlevel2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mDataSet = new SanSee.MDataSet();
            this.colIS_Recept = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIS_NDS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIS_One_Recept = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.bNew = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.sPR_FarmG_level2TableAdapter = new SanSee.MDataSetTableAdapters.SPR_FarmG_level2TableAdapter();
            this.repositoryItemMRUEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemMRUEdit();
            this.repositoryItemPopupContainerEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Name_TovItemTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Small_NameItemTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IzgItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EI_ItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlaceItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubstanceItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FgItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FG2ItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPRFarmGlevel2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMRUEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.ContextMenuStrip = this.contextMenuStrip1;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.EmbeddedNavigator.Name = "";
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.gridView1;
            this.grid.Name = "grid";
            this.grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.EI_ItemLookUpEdit,
            this.PlaceItemLookUpEdit,
            this.FormItemLookUpEdit,
            this.SubstanceItemLookUpEdit,
            this.FgItemLookUpEdit,
            this.IzgItemLookUpEdit,
            this.Name_TovItemTextEdit,
            this.Small_NameItemTextEdit,
            this.FG2ItemLookUpEdit,
            this.repositoryItemMRUEdit2,
            this.repositoryItemPopupContainerEdit2});
            this.grid.Size = new System.Drawing.Size(770, 366);
            this.grid.TabIndex = 0;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.настройкаПолейToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(173, 70);
            this.contextMenuStrip1.Text = "Close";
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.EditToolStripMenuItem.Text = "Изменить";
            this.EditToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // настройкаПолейToolStripMenuItem
            // 
            this.настройкаПолейToolStripMenuItem.Name = "настройкаПолейToolStripMenuItem";
            this.настройкаПолейToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.настройкаПолейToolStripMenuItem.Text = "Настройка полей";
            this.настройкаПолейToolStripMenuItem.Click += new System.EventHandler(this.настройкаПолейToolStripMenuItem_Click);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.FooterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_TOV,
            this.colName_Tov,
            this.colSmall_Name,
            this.colID_IZG,
            this.colCena_IZG,
            this.colIDF_EI,
            this.colIDF_Form,
            this.colIDF_Place,
            this.colIDF_Sbc,
            this.colIDF_FG,
            this.colIDF_FG2,
            this.colIS_Recept,
            this.colIS_NDS,
            this.colIS_One_Recept});
            this.gridView1.GridControl = this.grid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridView1.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView1.OptionsPrint.PrintDetails = true;
            this.gridView1.OptionsPrint.PrintFilterInfo = true;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView1_ValidateRow);
            this.gridView1.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanging);
            // 
            // colID_TOV
            // 
            this.colID_TOV.AppearanceHeader.Options.UseTextOptions = true;
            this.colID_TOV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colID_TOV.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colID_TOV.Caption = "Код  товара";
            this.colID_TOV.FieldName = "ID_TOV";
            this.colID_TOV.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colID_TOV.MinWidth = 45;
            this.colID_TOV.Name = "colID_TOV";
            this.colID_TOV.OptionsColumn.AllowEdit = false;
            this.colID_TOV.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colID_TOV.OptionsColumn.AllowSize = false;
            this.colID_TOV.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colID_TOV.OptionsColumn.FixedWidth = true;
            this.colID_TOV.OptionsColumn.ReadOnly = true;
            this.colID_TOV.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Like;
            this.colID_TOV.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedRow;
            this.colID_TOV.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.colID_TOV.Visible = true;
            this.colID_TOV.VisibleIndex = 0;
            this.colID_TOV.Width = 45;
            // 
            // colName_Tov
            // 
            this.colName_Tov.Caption = "Наименование";
            this.colName_Tov.ColumnEdit = this.Name_TovItemTextEdit;
            this.colName_Tov.FieldName = "Name_Tov";
            this.colName_Tov.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colName_Tov.MinWidth = 140;
            this.colName_Tov.Name = "colName_Tov";
            this.colName_Tov.Visible = true;
            this.colName_Tov.VisibleIndex = 1;
            this.colName_Tov.Width = 217;
            // 
            // Name_TovItemTextEdit
            // 
            this.Name_TovItemTextEdit.AutoHeight = false;
            this.Name_TovItemTextEdit.MaxLength = 50;
            this.Name_TovItemTextEdit.Name = "Name_TovItemTextEdit";
            this.Name_TovItemTextEdit.ValidateOnEnterKey = true;
            // 
            // colSmall_Name
            // 
            this.colSmall_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.colSmall_Name.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colSmall_Name.Caption = "Краткое  наименование";
            this.colSmall_Name.ColumnEdit = this.Small_NameItemTextEdit;
            this.colSmall_Name.FieldName = "Small_Name";
            this.colSmall_Name.MinWidth = 25;
            this.colSmall_Name.Name = "colSmall_Name";
            this.colSmall_Name.Visible = true;
            this.colSmall_Name.VisibleIndex = 2;
            this.colSmall_Name.Width = 86;
            // 
            // Small_NameItemTextEdit
            // 
            this.Small_NameItemTextEdit.AutoHeight = false;
            this.Small_NameItemTextEdit.MaxLength = 25;
            this.Small_NameItemTextEdit.Name = "Small_NameItemTextEdit";
            // 
            // colID_IZG
            // 
            this.colID_IZG.Caption = "Изготовитель";
            this.colID_IZG.ColumnEdit = this.IzgItemLookUpEdit;
            this.colID_IZG.FieldName = "ID_IZG";
            this.colID_IZG.Name = "colID_IZG";
            this.colID_IZG.Visible = true;
            this.colID_IZG.VisibleIndex = 12;
            this.colID_IZG.Width = 25;
            // 
            // IzgItemLookUpEdit
            // 
            this.IzgItemLookUpEdit.AutoHeight = false;
            this.IzgItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.IzgItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name_Izg", "Name_Izg", 54, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.IzgItemLookUpEdit.DisplayMember = "Name_Izg";
            this.IzgItemLookUpEdit.Name = "IzgItemLookUpEdit";
            this.IzgItemLookUpEdit.ValueMember = "ID_IZG";
            // 
            // colCena_IZG
            // 
            this.colCena_IZG.Caption = "Цена изготовителя";
            this.colCena_IZG.FieldName = "Cena_IZG";
            this.colCena_IZG.Name = "colCena_IZG";
            this.colCena_IZG.Visible = true;
            this.colCena_IZG.VisibleIndex = 3;
            this.colCena_IZG.Width = 38;
            // 
            // colIDF_EI
            // 
            this.colIDF_EI.Caption = "Ед.изм";
            this.colIDF_EI.ColumnEdit = this.EI_ItemLookUpEdit;
            this.colIDF_EI.FieldName = "IDF_EI";
            this.colIDF_EI.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colIDF_EI.MinWidth = 30;
            this.colIDF_EI.Name = "colIDF_EI";
            this.colIDF_EI.OptionsColumn.AllowIncrementalSearch = false;
            this.colIDF_EI.OptionsColumn.AllowSize = false;
            this.colIDF_EI.OptionsColumn.FixedWidth = true;
            this.colIDF_EI.Visible = true;
            this.colIDF_EI.VisibleIndex = 5;
            this.colIDF_EI.Width = 34;
            // 
            // EI_ItemLookUpEdit
            // 
            this.EI_ItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EI_ItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID_EI", "ID_EI", 46, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name_Ei", "Name_Ei", 47, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Del", "Del", 21, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RW", "RW", 23, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None)});
            this.EI_ItemLookUpEdit.DisplayMember = "Name_Ei";
            this.EI_ItemLookUpEdit.Name = "EI_ItemLookUpEdit";
            this.EI_ItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.EI_ItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.EI_ItemLookUpEdit.ValidateOnEnterKey = true;
            this.EI_ItemLookUpEdit.ValueMember = "ID_EI";
            // 
            // colIDF_Form
            // 
            this.colIDF_Form.Caption = "Форма выпуска";
            this.colIDF_Form.ColumnEdit = this.FormItemLookUpEdit;
            this.colIDF_Form.FieldName = "IDF_Form";
            this.colIDF_Form.Name = "colIDF_Form";
            this.colIDF_Form.Visible = true;
            this.colIDF_Form.VisibleIndex = 4;
            this.colIDF_Form.Width = 101;
            // 
            // FormItemLookUpEdit
            // 
            this.FormItemLookUpEdit.AutoHeight = false;
            this.FormItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FormItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name_form", "Name_form", 61, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.FormItemLookUpEdit.DisplayMember = "Name_form";
            this.FormItemLookUpEdit.Name = "FormItemLookUpEdit";
            this.FormItemLookUpEdit.ValueMember = "ID_Form";
            // 
            // colIDF_Place
            // 
            this.colIDF_Place.Caption = "Место хранения";
            this.colIDF_Place.ColumnEdit = this.PlaceItemLookUpEdit;
            this.colIDF_Place.FieldName = "IDF_Place";
            this.colIDF_Place.Name = "colIDF_Place";
            this.colIDF_Place.Visible = true;
            this.colIDF_Place.VisibleIndex = 6;
            this.colIDF_Place.Width = 25;
            // 
            // PlaceItemLookUpEdit
            // 
            this.PlaceItemLookUpEdit.AutoHeight = false;
            this.PlaceItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PlaceItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID_Place", "ID_Place", 61, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name_Place", "Name_Place", 64, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.PlaceItemLookUpEdit.DisplayMember = "Name_Place";
            this.PlaceItemLookUpEdit.Name = "PlaceItemLookUpEdit";
            this.PlaceItemLookUpEdit.ValueMember = "ID_Place";
            // 
            // colIDF_Sbc
            // 
            this.colIDF_Sbc.Caption = "Действующее вещество";
            this.colIDF_Sbc.ColumnEdit = this.SubstanceItemLookUpEdit;
            this.colIDF_Sbc.FieldName = "IDF_Sbc";
            this.colIDF_Sbc.Name = "colIDF_Sbc";
            this.colIDF_Sbc.Visible = true;
            this.colIDF_Sbc.VisibleIndex = 7;
            this.colIDF_Sbc.Width = 25;
            // 
            // SubstanceItemLookUpEdit
            // 
            this.SubstanceItemLookUpEdit.AutoHeight = false;
            this.SubstanceItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SubstanceItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME_Sbc", "NAME_Sbc", 57, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.SubstanceItemLookUpEdit.DisplayMember = "NAME_Sbc";
            this.SubstanceItemLookUpEdit.Name = "SubstanceItemLookUpEdit";
            this.SubstanceItemLookUpEdit.ValueMember = "ID_Sbc";
            // 
            // colIDF_FG
            // 
            this.colIDF_FG.Caption = "Фармгруппа";
            this.colIDF_FG.ColumnEdit = this.FgItemLookUpEdit;
            this.colIDF_FG.FieldName = "IDF_FG";
            this.colIDF_FG.Name = "colIDF_FG";
            this.colIDF_FG.Visible = true;
            this.colIDF_FG.VisibleIndex = 8;
            this.colIDF_FG.Width = 25;
            // 
            // FgItemLookUpEdit
            // 
            this.FgItemLookUpEdit.AutoHeight = false;
            this.FgItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FgItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME_FG", "NAME_FG", 53, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.FgItemLookUpEdit.DisplayMember = "NAME_FG";
            this.FgItemLookUpEdit.Name = "FgItemLookUpEdit";
            this.FgItemLookUpEdit.ValueMember = "ID_FG";
            // 
            // colIDF_FG2
            // 
            this.colIDF_FG2.Caption = "IDF_FG2";
            this.colIDF_FG2.ColumnEdit = this.repositoryItemPopupContainerEdit2;
            this.colIDF_FG2.FieldName = "IDF_FG2";
            this.colIDF_FG2.Name = "colIDF_FG2";
            this.colIDF_FG2.Visible = true;
            this.colIDF_FG2.VisibleIndex = 9;
            this.colIDF_FG2.Width = 20;
            // 
            // FG2ItemLookUpEdit
            // 
            this.FG2ItemLookUpEdit.AutoHeight = false;
            this.FG2ItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FG2ItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID_FG2", "ID_FG2", 55, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name_FG2", "Name_FG2", 58, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IDF1", "IDF1", 29, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None)});
            this.FG2ItemLookUpEdit.DataSource = this.sPRFarmGlevel2BindingSource;
            this.FG2ItemLookUpEdit.DisplayMember = "Name_FG2";
            this.FG2ItemLookUpEdit.Name = "FG2ItemLookUpEdit";
            this.FG2ItemLookUpEdit.ValueMember = "ID_FG2";
            // 
            // sPRFarmGlevel2BindingSource
            // 
            this.sPRFarmGlevel2BindingSource.DataMember = "SPR_FarmG_level2";
            this.sPRFarmGlevel2BindingSource.DataSource = this.mDataSet;
            // 
            // mDataSet
            // 
            this.mDataSet.DataSetName = "MDataSet";
            this.mDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colIS_Recept
            // 
            this.colIS_Recept.Caption = "Рецепт";
            this.colIS_Recept.FieldName = "IS_Recept";
            this.colIS_Recept.Name = "colIS_Recept";
            this.colIS_Recept.Visible = true;
            this.colIS_Recept.VisibleIndex = 10;
            this.colIS_Recept.Width = 20;
            // 
            // colIS_NDS
            // 
            this.colIS_NDS.Caption = "НДС";
            this.colIS_NDS.FieldName = "IS_NDS";
            this.colIS_NDS.Name = "colIS_NDS";
            this.colIS_NDS.Visible = true;
            this.colIS_NDS.VisibleIndex = 11;
            this.colIS_NDS.Width = 20;
            // 
            // colIS_One_Recept
            // 
            this.colIS_One_Recept.Caption = "Спец.рецепт";
            this.colIS_One_Recept.FieldName = "IS_One_Recept";
            this.colIS_One_Recept.Name = "colIS_One_Recept";
            this.colIS_One_Recept.Visible = true;
            this.colIS_One_Recept.VisibleIndex = 13;
            this.colIS_One_Recept.Width = 33;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.bNew);
            this.panel1.Controls.Add(this.bCancel);
            this.panel1.Controls.Add(this.bSave);
            this.panel1.Controls.Add(this.bEdit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 366);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 42);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(424, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Печать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bNew
            // 
            this.bNew.Location = new System.Drawing.Point(22, 12);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(75, 23);
            this.bNew.TabIndex = 3;
            this.bNew.Text = "Добавить";
            this.bNew.UseVisualStyleBackColor = true;
            this.bNew.Click += new System.EventHandler(this.bNew_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(298, 12);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 2;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bSave
            // 
            this.bSave.Enabled = false;
            this.bSave.Location = new System.Drawing.Point(197, 13);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 1;
            this.bSave.Text = "Сохранить";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bEdit
            // 
            this.bEdit.Location = new System.Drawing.Point(103, 13);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(75, 23);
            this.bEdit.TabIndex = 0;
            this.bEdit.Text = "Изменить";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // sPR_FarmG_level2TableAdapter
            // 
            this.sPR_FarmG_level2TableAdapter.ClearBeforeFill = true;
            // 
            // repositoryItemMRUEdit2
            // 
            this.repositoryItemMRUEdit2.AutoHeight = false;
            this.repositoryItemMRUEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMRUEdit2.Name = "repositoryItemMRUEdit2";
            // 
            // repositoryItemPopupContainerEdit2
            // 
            this.repositoryItemPopupContainerEdit2.AutoHeight = false;
            this.repositoryItemPopupContainerEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemPopupContainerEdit2.Name = "repositoryItemPopupContainerEdit2";
            // 
            // UC_SPR_TOV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid);
            this.Controls.Add(this.panel1);
            this.Name = "UC_SPR_TOV";
            this.Size = new System.Drawing.Size(770, 408);
            this.Load += new System.EventHandler(this.UC_SPR_TOV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Name_TovItemTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Small_NameItemTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IzgItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EI_ItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlaceItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubstanceItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FgItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FG2ItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPRFarmGlevel2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMRUEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID_TOV;
        private DevExpress.XtraGrid.Columns.GridColumn colName_Tov;
        private DevExpress.XtraGrid.Columns.GridColumn colSmall_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colCena_IZG;
        private DevExpress.XtraGrid.Columns.GridColumn colIDF_EI;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit EI_ItemLookUpEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colIDF_Form;
        private DevExpress.XtraGrid.Columns.GridColumn colIDF_Place;
        private DevExpress.XtraGrid.Columns.GridColumn colIDF_Sbc;
        private DevExpress.XtraGrid.Columns.GridColumn colIDF_FG;
        private DevExpress.XtraGrid.Columns.GridColumn colIDF_FG2;
        private DevExpress.XtraGrid.Columns.GridColumn colIS_Recept;
        private DevExpress.XtraGrid.Columns.GridColumn colIS_NDS;
        private DevExpress.XtraGrid.Columns.GridColumn colID_IZG;
        private DevExpress.XtraGrid.Columns.GridColumn colIS_One_Recept;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit PlaceItemLookUpEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit FormItemLookUpEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit SubstanceItemLookUpEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit FgItemLookUpEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit IzgItemLookUpEdit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bNew;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit Name_TovItemTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit Small_NameItemTextEdit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem настройкаПолейToolStripMenuItem;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit FG2ItemLookUpEdit;
        private System.Windows.Forms.BindingSource sPRFarmGlevel2BindingSource;
        private MDataSet mDataSet;
        private SanSee.MDataSetTableAdapters.SPR_FarmG_level2TableAdapter sPR_FarmG_level2TableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemMRUEdit repositoryItemMRUEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit repositoryItemPopupContainerEdit2;
    }
}
