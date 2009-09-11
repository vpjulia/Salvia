namespace RetailTrade.Invoice
{
    partial class InvoiceDetailRowAdd
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
            this.invoiceDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mDataSet = new RetailTrade.MDataSet();
            this.invoiceDetailTableAdapter = new RetailTrade.MDataSetTableAdapters.InvoiceDetailTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelOst = new System.Windows.Forms.Label();
            this.productTableAdapter = new RetailTrade.MDataSetTableAdapters.ProductTableAdapter();
            this.remainsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lComment = new System.Windows.Forms.Label();
            this.lnumOst = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.quantityEdit = new DevExpress.XtraEditors.CalcEdit();
            this.lQuant = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remainsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // invoiceDetailBindingSource
            // 
            this.invoiceDetailBindingSource.DataMember = "InvoiceDetail";
            this.invoiceDetailBindingSource.DataSource = this.mDataSet;
            // 
            // mDataSet
            // 
            this.mDataSet.DataSetName = "MDataSet";
            this.mDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoiceDetailTableAdapter
            // 
            this.invoiceDetailTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.DataSource = this.invoiceDetailBindingSource;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Количество:";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Name", true));
            this.lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lName.Location = new System.Drawing.Point(18, 16);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(52, 18);
            this.lName.TabIndex = 3;
            this.lName.Text = "label2";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.mDataSet;
            // 
            // labelOst
            // 
            this.labelOst.AutoSize = true;
            this.labelOst.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelOst.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOst.Location = new System.Drawing.Point(123, 96);
            this.labelOst.Name = "labelOst";
            this.labelOst.Size = new System.Drawing.Size(0, 17);
            this.labelOst.TabIndex = 4;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // remainsBindingSource
            // 
            this.remainsBindingSource.DataMember = "Remains";
            this.remainsBindingSource.DataSource = this.mDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.remainsBindingSource, "ManufacturerName", true));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(18, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "UnitName", true));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(316, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(18, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Остаток: ";
            // 
            // lComment
            // 
            this.lComment.AutoSize = true;
            this.lComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lComment.Location = new System.Drawing.Point(123, 152);
            this.lComment.Name = "lComment";
            this.lComment.Size = new System.Drawing.Size(92, 17);
            this.lComment.TabIndex = 9;
            this.lComment.Text = "{делится на}";
            this.lComment.Visible = false;
            // 
            // lnumOst
            // 
            this.lnumOst.AutoSize = true;
            this.lnumOst.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnumOst.ForeColor = System.Drawing.Color.Green;
            this.lnumOst.Location = new System.Drawing.Point(123, 68);
            this.lnumOst.Name = "lnumOst";
            this.lnumOst.Size = new System.Drawing.Size(52, 17);
            this.lnumOst.TabIndex = 10;
            this.lnumOst.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "PackingName", true));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(274, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(223, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "в уп.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "OldKol", true));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(258, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "label7";
            // 
            // quantityEdit
            // 
            this.quantityEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.invoiceDetailBindingSource, "Quantity", true));
            this.quantityEdit.Location = new System.Drawing.Point(114, 127);
            this.quantityEdit.Name = "quantityEdit";
            this.quantityEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.quantityEdit.Size = new System.Drawing.Size(115, 22);
            this.quantityEdit.TabIndex = 14;
            this.quantityEdit.ToolTip = "F4 - открыть калькулятор";
            this.quantityEdit.EditValueChanged += new System.EventHandler(this.quantityEdit_EditValueChanged);
            this.quantityEdit.Validated += new System.EventHandler(this.quantityEdit_Validated);
            // 
            // lQuant
            // 
            this.lQuant.AutoSize = true;
            this.lQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lQuant.Location = new System.Drawing.Point(236, 127);
            this.lQuant.Name = "lQuant";
            this.lQuant.Size = new System.Drawing.Size(27, 17);
            this.lQuant.TabIndex = 15;
            this.lQuant.Text = "уп.";
            // 
            // InvoiceDetailRowAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lQuant);
            this.Controls.Add(this.quantityEdit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lnumOst);
            this.Controls.Add(this.lComment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelOst);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.label1);
            this.Name = "InvoiceDetailRowAdd";
            this.Size = new System.Drawing.Size(397, 189);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.InvoiceDetailRowAdd_Validating);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remainsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource invoiceDetailBindingSource;
        private MDataSet mDataSet;
        private RetailTrade.MDataSetTableAdapters.InvoiceDetailTableAdapter invoiceDetailTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelOst;
        private System.Windows.Forms.BindingSource remainsBindingSource;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.BindingSource productBindingSource;
        private RetailTrade.MDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lComment;
        private System.Windows.Forms.Label lnumOst;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.CalcEdit quantityEdit;
        private System.Windows.Forms.Label lQuant;
    }
}
