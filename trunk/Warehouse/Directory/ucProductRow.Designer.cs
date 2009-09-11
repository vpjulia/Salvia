using System.Data;
namespace RetailTrade
{
    partial class ucProductRow
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mDataSet = new RetailTrade.MDataSet();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ceIsRecept = new DevExpress.XtraEditors.CheckEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NametextEdit = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.PackinglookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.packingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UnitlookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.unitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FarmGroupLevel2lookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.farmGroupLevel2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StorageConditionlookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.storageConditionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SubstancelookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.substanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btPaking = new System.Windows.Forms.Button();
            this.btUnit = new System.Windows.Forms.Button();
            this.btFarmGroupLevel2 = new System.Windows.Forms.Button();
            this.btPlace = new System.Windows.Forms.Button();
            this.btSubstance = new System.Windows.Forms.Button();
            this.ceIsOneRecept = new DevExpress.XtraEditors.CheckEdit();
            this.ceIsHide = new DevExpress.XtraEditors.CheckEdit();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.ceISNDS = new DevExpress.XtraEditors.CheckEdit();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SamallNameEdit = new DevExpress.XtraEditors.TextEdit();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.productTableAdapter = new RetailTrade.MDataSetTableAdapters.ProductTableAdapter();
            this.packingTableAdapter = new RetailTrade.MDataSetTableAdapters.PackingTableAdapter();
            this.storageConditionTableAdapter = new RetailTrade.MDataSetTableAdapters.StorageConditionTableAdapter();
            this.substanceTableAdapter = new RetailTrade.MDataSetTableAdapters.SubstanceTableAdapter();
            this.farmGroupLevel2TableAdapter = new RetailTrade.MDataSetTableAdapters.FarmGroupLevel2TableAdapter();
            this.unitTableAdapter = new RetailTrade.MDataSetTableAdapters.UnitTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceIsRecept.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NametextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PackinglookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitlookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FarmGroupLevel2lookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmGroupLevel2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StorageConditionlookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageConditionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubstancelookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.substanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceIsOneRecept.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceIsHide.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceISNDS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SamallNameEdit.Properties)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(554, 452);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl.TabIndex = 0;
            this.tabControl.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textEdit1);
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(546, 423);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Товар";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ID", true));
            this.textEdit1.EnterMoveNextControl = true;
            this.textEdit1.Location = new System.Drawing.Point(219, 0);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit1.Properties.MaxLength = 25;
            this.textEdit1.Properties.ValidateOnEnterKey = true;
            this.textEdit1.Size = new System.Drawing.Size(133, 22);
            this.textEdit1.TabIndex = 0;
            this.textEdit1.Tag = "";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.mDataSet;
            // 
            // mDataSet
            // 
            this.mDataSet.DataSetName = "MDataSet";
            this.mDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.Controls.Add(this.ceIsRecept, 0, 17);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.NametextEdit, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.PackinglookUpEdit, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.UnitlookUpEdit, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.FarmGroupLevel2lookUpEdit, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.StorageConditionlookUpEdit, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.SubstancelookUpEdit, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.btPaking, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.btUnit, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.btFarmGroupLevel2, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.btPlace, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.btSubstance, 2, 10);
            this.tableLayoutPanel1.Controls.Add(this.ceIsOneRecept, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.ceIsHide, 1, 17);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown1, 1, 13);
            this.tableLayoutPanel1.Controls.Add(this.ceISNDS, 1, 14);
            this.tableLayoutPanel1.Controls.Add(this.label12, 2, 18);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 18);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SamallNameEdit, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 19);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 18);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 19);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 20;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(540, 417);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ceIsRecept
            // 
            this.ceIsRecept.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource, "IsRecept", true));
            this.ceIsRecept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ceIsRecept.Location = new System.Drawing.Point(3, 279);
            this.ceIsRecept.Name = "ceIsRecept";
            this.ceIsRecept.Properties.Caption = "по рецепту";
            this.ceIsRecept.Size = new System.Drawing.Size(207, 21);
            this.ceIsRecept.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 28);
            this.label1.TabIndex = 22;
            this.label1.Text = "Наименование";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(3, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 28);
            this.label2.TabIndex = 11;
            this.label2.Text = "Краткое";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NametextEdit
            // 
            this.NametextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource, "Name", true));
            this.NametextEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Name", true));
            this.NametextEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NametextEdit.EnterMoveNextControl = true;
            this.NametextEdit.Location = new System.Drawing.Point(216, 23);
            this.NametextEdit.Name = "NametextEdit";
            this.NametextEdit.Properties.MaxLength = 255;
            this.NametextEdit.Size = new System.Drawing.Size(264, 22);
            this.NametextEdit.TabIndex = 1;
            this.NametextEdit.Tag = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 29);
            this.label7.TabIndex = 17;
            this.label7.Text = "Единица измерения";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Форма выпуска";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Фармгруппа";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Место хранения";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Действующее вещество";
            // 
            // PackinglookUpEdit
            // 
            this.PackinglookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource, "PackingRef", true));
            this.PackinglookUpEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PackinglookUpEdit.EnterMoveNextControl = true;
            this.PackinglookUpEdit.Location = new System.Drawing.Point(216, 79);
            this.PackinglookUpEdit.Name = "PackinglookUpEdit";
            this.PackinglookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PackinglookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Наименование", 39, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.PackinglookUpEdit.Properties.DataSource = this.packingBindingSource;
            this.PackinglookUpEdit.Properties.DisplayMember = "Name";
            this.PackinglookUpEdit.Properties.ShowHeader = false;
            this.PackinglookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.PackinglookUpEdit.Properties.ValueMember = "ID";
            this.PackinglookUpEdit.Size = new System.Drawing.Size(264, 22);
            this.PackinglookUpEdit.TabIndex = 4;
            this.PackinglookUpEdit.Tag = "Packing";
            // 
            // packingBindingSource
            // 
            this.packingBindingSource.DataMember = "Packing";
            this.packingBindingSource.DataSource = this.mDataSet;
            // 
            // UnitlookUpEdit
            // 
            this.UnitlookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource, "UnitRef", true));
            this.UnitlookUpEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UnitlookUpEdit.EnterMoveNextControl = true;
            this.UnitlookUpEdit.Location = new System.Drawing.Point(216, 108);
            this.UnitlookUpEdit.Name = "UnitlookUpEdit";
            this.UnitlookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UnitlookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Наименование", 39, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.UnitlookUpEdit.Properties.DataSource = this.unitBindingSource;
            this.UnitlookUpEdit.Properties.DisplayMember = "Name";
            this.UnitlookUpEdit.Properties.ShowHeader = false;
            this.UnitlookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.UnitlookUpEdit.Properties.ValueMember = "ID";
            this.UnitlookUpEdit.Size = new System.Drawing.Size(264, 22);
            this.UnitlookUpEdit.TabIndex = 5;
            // 
            // unitBindingSource
            // 
            this.unitBindingSource.DataMember = "Unit";
            this.unitBindingSource.DataSource = this.mDataSet;
            // 
            // FarmGroupLevel2lookUpEdit
            // 
            this.FarmGroupLevel2lookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource, "FarmGrouplevel2Ref", true));
            this.FarmGroupLevel2lookUpEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FarmGroupLevel2lookUpEdit.EnterMoveNextControl = true;
            this.FarmGroupLevel2lookUpEdit.Location = new System.Drawing.Point(216, 137);
            this.FarmGroupLevel2lookUpEdit.Name = "FarmGroupLevel2lookUpEdit";
            this.FarmGroupLevel2lookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FarmGroupLevel2lookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 39, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.FarmGroupLevel2lookUpEdit.Properties.DataSource = this.farmGroupLevel2BindingSource;
            this.FarmGroupLevel2lookUpEdit.Properties.DisplayMember = "Name";
            this.FarmGroupLevel2lookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.FarmGroupLevel2lookUpEdit.Properties.ValueMember = "ID";
            this.FarmGroupLevel2lookUpEdit.Size = new System.Drawing.Size(264, 22);
            this.FarmGroupLevel2lookUpEdit.TabIndex = 6;
            // 
            // farmGroupLevel2BindingSource
            // 
            this.farmGroupLevel2BindingSource.DataMember = "FarmGroupLevel2";
            this.farmGroupLevel2BindingSource.DataSource = this.mDataSet;
            // 
            // StorageConditionlookUpEdit
            // 
            this.StorageConditionlookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource, "StorageConditionRef", true));
            this.StorageConditionlookUpEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StorageConditionlookUpEdit.EnterMoveNextControl = true;
            this.StorageConditionlookUpEdit.Location = new System.Drawing.Point(216, 166);
            this.StorageConditionlookUpEdit.Name = "StorageConditionlookUpEdit";
            this.StorageConditionlookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.StorageConditionlookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 39, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.StorageConditionlookUpEdit.Properties.DataSource = this.storageConditionBindingSource;
            this.StorageConditionlookUpEdit.Properties.DisplayMember = "Name";
            this.StorageConditionlookUpEdit.Properties.ShowHeader = false;
            this.StorageConditionlookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.StorageConditionlookUpEdit.Properties.ValueMember = "ID";
            this.StorageConditionlookUpEdit.Size = new System.Drawing.Size(264, 22);
            this.StorageConditionlookUpEdit.TabIndex = 7;
            // 
            // storageConditionBindingSource
            // 
            this.storageConditionBindingSource.DataMember = "StorageCondition";
            this.storageConditionBindingSource.DataSource = this.mDataSet;
            // 
            // SubstancelookUpEdit
            // 
            this.SubstancelookUpEdit.AllowDrop = true;
            this.SubstancelookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource, "SubstanceRef", true));
            this.SubstancelookUpEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubstancelookUpEdit.EnterMoveNextControl = true;
            this.SubstancelookUpEdit.Location = new System.Drawing.Point(216, 195);
            this.SubstancelookUpEdit.Name = "SubstancelookUpEdit";
            this.SubstancelookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SubstancelookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 39, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.SubstancelookUpEdit.Properties.DataSource = this.substanceBindingSource;
            this.SubstancelookUpEdit.Properties.DisplayMember = "Name";
            this.SubstancelookUpEdit.Properties.ShowHeader = false;
            this.SubstancelookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.SubstancelookUpEdit.Properties.ValueMember = "ID";
            this.SubstancelookUpEdit.Size = new System.Drawing.Size(264, 22);
            this.SubstancelookUpEdit.TabIndex = 8;
            // 
            // substanceBindingSource
            // 
            this.substanceBindingSource.DataMember = "Substance";
            this.substanceBindingSource.DataSource = this.mDataSet;
            // 
            // btPaking
            // 
            this.btPaking.Location = new System.Drawing.Point(486, 79);
            this.btPaking.Name = "btPaking";
            this.btPaking.Size = new System.Drawing.Size(51, 23);
            this.btPaking.TabIndex = 25;
            this.btPaking.TabStop = false;
            this.btPaking.Tag = "Packing";
            this.btPaking.Text = "...";
            this.toolTip1.SetToolTip(this.btPaking, "Форма выпуска");
            this.btPaking.UseVisualStyleBackColor = true;
            this.btPaking.Click += new System.EventHandler(this.btSimpleDirectory_Click);
            // 
            // btUnit
            // 
            this.btUnit.Location = new System.Drawing.Point(486, 108);
            this.btUnit.Name = "btUnit";
            this.btUnit.Size = new System.Drawing.Size(51, 23);
            this.btUnit.TabIndex = 26;
            this.btUnit.TabStop = false;
            this.btUnit.Tag = "Unit";
            this.btUnit.Text = "...";
            this.toolTip1.SetToolTip(this.btUnit, "Справочник единиц измерения");
            this.btUnit.UseVisualStyleBackColor = true;
            this.btUnit.Click += new System.EventHandler(this.btSimpleDirectory_Click);
            // 
            // btFarmGroupLevel2
            // 
            this.btFarmGroupLevel2.Location = new System.Drawing.Point(486, 137);
            this.btFarmGroupLevel2.Name = "btFarmGroupLevel2";
            this.btFarmGroupLevel2.Size = new System.Drawing.Size(51, 23);
            this.btFarmGroupLevel2.TabIndex = 27;
            this.btFarmGroupLevel2.TabStop = false;
            this.btFarmGroupLevel2.Tag = "FarmGroupLevel2";
            this.btFarmGroupLevel2.Text = "...";
            this.toolTip1.SetToolTip(this.btFarmGroupLevel2, "Справочник фармгрупп");
            this.btFarmGroupLevel2.UseVisualStyleBackColor = true;
            this.btFarmGroupLevel2.Click += new System.EventHandler(this.btUcGroupDirectory_Click);
            // 
            // btPlace
            // 
            this.btPlace.Location = new System.Drawing.Point(486, 166);
            this.btPlace.Name = "btPlace";
            this.btPlace.Size = new System.Drawing.Size(51, 23);
            this.btPlace.TabIndex = 28;
            this.btPlace.TabStop = false;
            this.btPlace.Tag = "StorageCondition";
            this.btPlace.Text = "...";
            this.toolTip1.SetToolTip(this.btPlace, "Места хранения");
            this.btPlace.UseVisualStyleBackColor = true;
            this.btPlace.Click += new System.EventHandler(this.btSimpleDirectory_Click);
            // 
            // btSubstance
            // 
            this.btSubstance.Location = new System.Drawing.Point(486, 195);
            this.btSubstance.Name = "btSubstance";
            this.btSubstance.Size = new System.Drawing.Size(51, 23);
            this.btSubstance.TabIndex = 29;
            this.btSubstance.TabStop = false;
            this.btSubstance.Tag = "Substance";
            this.btSubstance.Text = "...";
            this.toolTip1.SetToolTip(this.btSubstance, "Действующее вещество");
            this.btSubstance.UseVisualStyleBackColor = true;
            this.btSubstance.Click += new System.EventHandler(this.btSimpleDirectory_Click);
            // 
            // ceIsOneRecept
            // 
            this.ceIsOneRecept.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource, "IsOneRecept", true));
            this.ceIsOneRecept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ceIsOneRecept.Location = new System.Drawing.Point(3, 252);
            this.ceIsOneRecept.Name = "ceIsOneRecept";
            this.ceIsOneRecept.Properties.Caption = "один на рецепте";
            this.ceIsOneRecept.Size = new System.Drawing.Size(207, 21);
            this.ceIsOneRecept.TabIndex = 31;
            // 
            // ceIsHide
            // 
            this.ceIsHide.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource, "IsHide", true));
            this.ceIsHide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ceIsHide.Location = new System.Drawing.Point(216, 279);
            this.ceIsHide.Name = "ceIsHide";
            this.ceIsHide.Properties.Caption = "скрывать";
            this.ceIsHide.Size = new System.Drawing.Size(264, 21);
            this.ceIsHide.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(3, 221);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(207, 28);
            this.label11.TabIndex = 30;
            this.label11.Text = "Делить на:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "MinDivisor", true));
            this.numericUpDown1.Location = new System.Drawing.Point(216, 224);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(45, 22);
            this.numericUpDown1.TabIndex = 9;
            // 
            // ceISNDS
            // 
            this.ceISNDS.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource, "IsNDS", true));
            this.ceISNDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ceISNDS.Location = new System.Drawing.Point(216, 252);
            this.ceISNDS.Name = "ceISNDS";
            this.ceISNDS.Properties.Caption = "НДС";
            this.ceISNDS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ceISNDS.Size = new System.Drawing.Size(264, 21);
            this.ceISNDS.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "OldKod", true));
            this.label12.Location = new System.Drawing.Point(486, 321);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 22);
            this.label12.TabIndex = 34;
            this.label12.Text = "label12";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "OldName", true));
            this.label3.Location = new System.Drawing.Point(216, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "label3";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "OldKol", true));
            this.textBox1.Location = new System.Drawing.Point(3, 346);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(207, 20);
            this.label13.TabIndex = 36;
            this.label13.Text = "Код";
            // 
            // SamallNameEdit
            // 
            this.SamallNameEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.productBindingSource, "SmallName", true));
            this.SamallNameEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "SmallName", true));
            this.SamallNameEdit.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.productBindingSource, "SmallName", true));
            this.SamallNameEdit.Location = new System.Drawing.Point(216, 51);
            this.SamallNameEdit.Name = "SamallNameEdit";
            this.SamallNameEdit.Properties.MaxLength = 25;
            this.SamallNameEdit.Properties.ValidateOnEnterKey = true;
            this.SamallNameEdit.Size = new System.Drawing.Size(100, 22);
            this.SamallNameEdit.TabIndex = 37;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(546, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Регистрация";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Цена производителя";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(546, 423);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Серии";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.DataSource = this.productBindingSource;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // packingTableAdapter
            // 
            this.packingTableAdapter.ClearBeforeFill = true;
            // 
            // storageConditionTableAdapter
            // 
            this.storageConditionTableAdapter.ClearBeforeFill = true;
            // 
            // substanceTableAdapter
            // 
            this.substanceTableAdapter.ClearBeforeFill = true;
            // 
            // farmGroupLevel2TableAdapter
            // 
            this.farmGroupLevel2TableAdapter.ClearBeforeFill = true;
            // 
            // unitTableAdapter
            // 
            this.unitTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "Ко-ло Фарм трейд";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "OldName", true));
            this.textBox2.Location = new System.Drawing.Point(216, 346);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(264, 22);
            this.textBox2.TabIndex = 41;
            // 
            // ucProductRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.tabControl);
            this.Name = "ucProductRow";
            this.Size = new System.Drawing.Size(554, 452);
            this.Tag = "4";
            this.Load += new System.EventHandler(this.ucProductRow_Load);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.ucProductRow_Validating);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceIsRecept.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NametextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PackinglookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitlookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FarmGroupLevel2lookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmGroupLevel2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StorageConditionlookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageConditionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubstancelookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.substanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceIsOneRecept.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceIsHide.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceISNDS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SamallNameEdit.Properties)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.BindingSource productBindingSource;
        private MDataSet mDataSet;
        private DataSet dataSet;

        private RetailTrade.MDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit NametextEdit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.CheckEdit ceIsHide;
        private DevExpress.XtraEditors.CheckEdit ceISNDS;
        private DevExpress.XtraEditors.LookUpEdit PackinglookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit UnitlookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit FarmGroupLevel2lookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit StorageConditionlookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit SubstancelookUpEdit;
        private System.Windows.Forms.Button btPaking;
        private System.Windows.Forms.Button btUnit;
        private System.Windows.Forms.Button btFarmGroupLevel2;
        private System.Windows.Forms.Button btPlace;
        private System.Windows.Forms.Button btSubstance;
        private System.Windows.Forms.BindingSource packingBindingSource;
        private RetailTrade.MDataSetTableAdapters.PackingTableAdapter packingTableAdapter;
        private System.Windows.Forms.BindingSource storageConditionBindingSource;
        private RetailTrade.MDataSetTableAdapters.StorageConditionTableAdapter storageConditionTableAdapter;
        private System.Windows.Forms.BindingSource substanceBindingSource;
        private RetailTrade.MDataSetTableAdapters.SubstanceTableAdapter substanceTableAdapter;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.BindingSource farmGroupLevel2BindingSource;
        private RetailTrade.MDataSetTableAdapters.FarmGroupLevel2TableAdapter farmGroupLevel2TableAdapter;
        private System.Windows.Forms.BindingSource unitBindingSource;
        private RetailTrade.MDataSetTableAdapters.UnitTableAdapter unitTableAdapter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private DevExpress.XtraEditors.CheckEdit ceIsRecept;
        private DevExpress.XtraEditors.CheckEdit ceIsOneRecept;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label13;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit SamallNameEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
    }
}
