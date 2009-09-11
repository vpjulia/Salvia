namespace RetailTrade.Orders
{
    partial class OrderAdd
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
            this.tradePutletlookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mDataSet = new RetailTrade.MDataSet();
            this.tradePutletBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productlookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.quantityEdit = new DevExpress.XtraEditors.TextEdit();
            this.noteEdit = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ordersTableAdapter = new RetailTrade.MDataSetTableAdapters.OrdersTableAdapter();
            this.tradePutletTableAdapter = new RetailTrade.MDataSetTableAdapters.TradePutletTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.fullDataSet = new RetailTrade.FullDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new RetailTrade.FullDataSetTableAdapters.ProductTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tradePutletlookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradePutletBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productlookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tradePutletlookUpEdit
            // 
            this.tradePutletlookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ordersBindingSource, "TradePupletRef", true));
            this.tradePutletlookUpEdit.EnterMoveNextControl = true;
            this.tradePutletlookUpEdit.Location = new System.Drawing.Point(145, 51);
            this.tradePutletlookUpEdit.Name = "tradePutletlookUpEdit";
            this.tradePutletlookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.tradePutletlookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tradePutletlookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 39, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.tradePutletlookUpEdit.Properties.DataSource = this.tradePutletBindingSource;
            this.tradePutletlookUpEdit.Properties.DisplayMember = "Name";
            this.tradePutletlookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.tradePutletlookUpEdit.Properties.ValidateOnEnterKey = true;
            this.tradePutletlookUpEdit.Properties.ValueMember = "ID";
            this.tradePutletlookUpEdit.Size = new System.Drawing.Size(241, 22);
            this.tradePutletlookUpEdit.TabIndex = 0;
            this.tradePutletlookUpEdit.Validating += new System.ComponentModel.CancelEventHandler(this.tradePutletlookUpEdit_Validating);
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.mDataSet;
            // 
            // mDataSet
            // 
            this.mDataSet.DataSetName = "MDataSet";
            this.mDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tradePutletBindingSource
            // 
            this.tradePutletBindingSource.DataMember = "TradePutlet";
            this.tradePutletBindingSource.DataSource = this.mDataSet;
            // 
            // productlookUpEdit
            // 
            this.productlookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ordersBindingSource, "ProductRef", true));
            this.productlookUpEdit.EnterMoveNextControl = true;
            this.productlookUpEdit.Location = new System.Drawing.Point(145, 91);
            this.productlookUpEdit.Name = "productlookUpEdit";
            this.productlookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.productlookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "Найти", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null)});
            this.productlookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 39, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.productlookUpEdit.Properties.DataSource = this.productBindingSource;
            this.productlookUpEdit.Properties.DisplayMember = "Name";
            this.productlookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.productlookUpEdit.Properties.ValueMember = "ID";
            this.productlookUpEdit.Size = new System.Drawing.Size(241, 22);
            this.productlookUpEdit.TabIndex = 1;
            this.productlookUpEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.productlookUpEdit_ButtonClick);
            // 
            // quantityEdit
            // 
            this.quantityEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ordersBindingSource, "Quantity", true));
            this.quantityEdit.EnterMoveNextControl = true;
            this.quantityEdit.Location = new System.Drawing.Point(145, 136);
            this.quantityEdit.Name = "quantityEdit";
            this.quantityEdit.Properties.DisplayFormat.FormatString = "####";
            this.quantityEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.quantityEdit.Properties.EditFormat.FormatString = "####";
            this.quantityEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.quantityEdit.Properties.Mask.EditMask = "####";
            this.quantityEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.quantityEdit.Size = new System.Drawing.Size(100, 22);
            this.quantityEdit.TabIndex = 2;
            // 
            // noteEdit
            // 
            this.noteEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ordersBindingSource, "Note", true));
            this.noteEdit.EnterMoveNextControl = true;
            this.noteEdit.Location = new System.Drawing.Point(145, 183);
            this.noteEdit.Name = "noteEdit";
            this.noteEdit.Size = new System.Drawing.Size(198, 22);
            this.noteEdit.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Торговая точка:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Наименование:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Количество:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Примечание:";
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // tradePutletTableAdapter
            // 
            this.tradePutletTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.DataSource = this.ordersBindingSource;
            // 
            // fullDataSet
            // 
            this.fullDataSet.DataSetName = "FullDataSet";
            this.fullDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.fullDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // OrderAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noteEdit);
            this.Controls.Add(this.quantityEdit);
            this.Controls.Add(this.productlookUpEdit);
            this.Controls.Add(this.tradePutletlookUpEdit);
            this.Name = "OrderAdd";
            this.Size = new System.Drawing.Size(479, 253);
            this.Validated += new System.EventHandler(this.OrderAdd_Validated);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.OrderAdd_Validating);
            ((System.ComponentModel.ISupportInitialize)(this.tradePutletlookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradePutletBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productlookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit tradePutletlookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit productlookUpEdit;
        private DevExpress.XtraEditors.TextEdit quantityEdit;
        private DevExpress.XtraEditors.TextEdit noteEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private MDataSet mDataSet;
        private RetailTrade.MDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.BindingSource tradePutletBindingSource;
        private RetailTrade.MDataSetTableAdapters.TradePutletTableAdapter tradePutletTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private FullDataSet fullDataSet;
        private RetailTrade.FullDataSetTableAdapters.ProductTableAdapter productTableAdapter;
    }
}
