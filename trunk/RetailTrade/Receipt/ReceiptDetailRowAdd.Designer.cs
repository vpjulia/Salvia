namespace RetailTrade.Receipt
{
    partial class ReceiptDetailRowAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.receiptDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mDataSet = new RetailTrade.MDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.QuantityEdit = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.PriceEdit = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Серия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Срок годности";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.DataSource = this.receiptDetailBindingSource;
            // 
            // receiptDetailBindingSource
            // 
            this.receiptDetailBindingSource.AllowNew = false;
            this.receiptDetailBindingSource.DataMember = "ReceiptDetail";
            this.receiptDetailBindingSource.DataSource = this.mDataSet;
            // 
            // mDataSet
            // 
            this.mDataSet.DataSetName = "MDataSet";
            this.mDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(21, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 165);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.21683F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.78317F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.QuantityEdit, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textEdit1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textEdit3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.PriceEdit, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(347, 144);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 34);
            this.label6.TabIndex = 6;
            this.label6.Text = "Цена без НДС";
            // 
            // QuantityEdit
            // 
            this.QuantityEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.receiptDetailBindingSource, "Quantity", true));
            this.QuantityEdit.EnterMoveNextControl = true;
            this.QuantityEdit.Location = new System.Drawing.Point(111, 3);
            this.QuantityEdit.Name = "QuantityEdit";
            this.QuantityEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.QuantityEdit.Properties.HideSelection = false;
            this.QuantityEdit.Properties.Mask.EditMask = "0.00";
            this.QuantityEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.QuantityEdit.Properties.Mask.ShowPlaceHolders = false;
            this.QuantityEdit.Properties.NullText = "0";
            this.QuantityEdit.Properties.ValidateOnEnterKey = true;
            this.QuantityEdit.Size = new System.Drawing.Size(100, 22);
            this.QuantityEdit.TabIndex = 1;
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.receiptDetailBindingSource, "Series", true));
            this.textEdit1.EnterMoveNextControl = true;
            this.textEdit1.Location = new System.Drawing.Point(111, 65);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.HideSelection = false;
            this.textEdit1.Properties.ValidateOnEnterKey = true;
            this.textEdit1.Size = new System.Drawing.Size(100, 22);
            this.textEdit1.TabIndex = 3;
            // 
            // textEdit3
            // 
            this.textEdit3.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.receiptDetailBindingSource, "UseByDate", true));
            this.textEdit3.EnterMoveNextControl = true;
            this.textEdit3.Location = new System.Drawing.Point(111, 93);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Properties.DisplayFormat.FormatString = "d";
            this.textEdit3.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.textEdit3.Properties.EditFormat.FormatString = "d";
            this.textEdit3.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.textEdit3.Properties.Mask.EditMask = "d";
            this.textEdit3.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.textEdit3.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.textEdit3.Properties.ValidateOnEnterKey = true;
            this.textEdit3.Size = new System.Drawing.Size(100, 22);
            this.textEdit3.TabIndex = 4;
            // 
            // PriceEdit
            // 
            this.PriceEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.receiptDetailBindingSource, "PricePurchase", true));
            this.PriceEdit.EnterMoveNextControl = true;
            this.PriceEdit.Location = new System.Drawing.Point(111, 31);
            this.PriceEdit.Name = "PriceEdit";
            this.PriceEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.PriceEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.PriceEdit.Properties.HideSelection = false;
            this.PriceEdit.Properties.Mask.BeepOnError = true;
            this.PriceEdit.Properties.Mask.EditMask = "0.00###";
            this.PriceEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.PriceEdit.Properties.Mask.ShowPlaceHolders = false;
            this.PriceEdit.Properties.NullText = "-1";
            this.PriceEdit.Properties.ValidateOnEnterKey = true;
            this.PriceEdit.Size = new System.Drawing.Size(100, 22);
            this.PriceEdit.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Name", true));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(27, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "label4";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.mDataSet;
            this.productBindingSource.DataError += new System.Windows.Forms.BindingManagerDataErrorEventHandler(this.productBindingSource_DataError);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "MinDivisor", true));
            this.label5.Location = new System.Drawing.Point(27, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "label5";
            // 
            // ReceiptDetailRowAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReceiptDetailRowAdd";
            this.Size = new System.Drawing.Size(384, 252);
            this.Load += new System.EventHandler(this.ReceiptDetailRowAdd_Load);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.ReceiptDetailRowAdd_Validating);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.BindingSource receiptDetailBindingSource;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource productBindingSource;
        private MDataSet mDataSet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit QuantityEdit;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit PriceEdit;
    }
}
