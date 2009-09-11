namespace RetailTrade.Dialog
{
    partial class SelectTradePutlet
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
            this.lookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.tradePutletBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mDataSet = new RetailTrade.MDataSet();
            this.organizationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradePutletBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lookUpEdit
            // 
            this.lookUpEdit.Location = new System.Drawing.Point(24, 42);
            this.lookUpEdit.Name = "lookUpEdit";
            this.lookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.lookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 39, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEdit.Properties.DataSource = this.tradePutletBindingSource;
            this.lookUpEdit.Properties.DisplayMember = "Name";
            this.lookUpEdit.Properties.NullText = "[]";
            this.lookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEdit.Properties.ValueMember = "ID";
            this.lookUpEdit.Size = new System.Drawing.Size(228, 22);
            this.lookUpEdit.TabIndex = 0;
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
            // organizationBindingSource
            // 
            this.organizationBindingSource.DataMember = "Organization";
            this.organizationBindingSource.DataSource = this.mDataSet;
            // 
            // SelectTradePutlet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lookUpEdit);
            this.Name = "SelectTradePutlet";
            this.Size = new System.Drawing.Size(280, 100);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tradePutletBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MDataSet mDataSet;
        public System.Windows.Forms.BindingSource tradePutletBindingSource;
        public DevExpress.XtraEditors.LookUpEdit lookUpEdit;
        public System.Windows.Forms.BindingSource organizationBindingSource;
    }
}
