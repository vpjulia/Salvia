namespace RetailTradeClient.Invoice.InvoiceTradePutlet
{
    partial class InvoiceDetailAdd
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
            this.remainsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mDataSet = new RetailTradeClient.MDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.invoiceDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lComment = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSum = new System.Windows.Forms.Label();
            this.QuantityEdit = new DevExpress.XtraEditors.TextEdit();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelRem = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new RetailTradeClient.MDataSetTableAdapters.ProductTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.additionPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.labelPlace = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LabelRec = new System.Windows.Forms.Label();
            this.lRemFull = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.remainsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.additionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.remainsBindingSource, "ProductName", true));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "наим";
            // 
            // remainsBindingSource
            // 
            this.remainsBindingSource.DataMember = "Remains";
            this.remainsBindingSource.DataSource = this.mDataSet;
            // 
            // mDataSet
            // 
            this.mDataSet.DataSetName = "MDataSet";
            this.mDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.remainsBindingSource, "PricePurchase", true));
            this.label2.Location = new System.Drawing.Point(236, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // invoiceDetailBindingSource
            // 
            this.invoiceDetailBindingSource.DataMember = "InvoiceDetail";
            this.invoiceDetailBindingSource.DataSource = this.mDataSet;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lComment);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelSum);
            this.groupBox1.Controls.Add(this.QuantityEdit);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(4, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 93);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Продажа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "X";
            // 
            // lComment
            // 
            this.lComment.AutoSize = true;
            this.lComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lComment.Location = new System.Drawing.Point(107, 58);
            this.lComment.Name = "lComment";
            this.lComment.Size = new System.Drawing.Size(118, 17);
            this.lComment.TabIndex = 3;
            this.lComment.Text = "продажа делдим";
            this.lComment.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Количество :";
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSum.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelSum.Location = new System.Drawing.Point(257, 73);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(52, 17);
            this.labelSum.TabIndex = 2;
            this.labelSum.Text = "label4";
            // 
            // QuantityEdit
            // 
            this.QuantityEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.invoiceDetailBindingSource, "Quantity", true));
            this.QuantityEdit.EnterMoveNextControl = true;
            this.errorProvider1.SetIconAlignment(this.QuantityEdit, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.QuantityEdit.Location = new System.Drawing.Point(121, 27);
            this.QuantityEdit.Name = "QuantityEdit";
            this.QuantityEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.QuantityEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.QuantityEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.QuantityEdit.Properties.Mask.ShowPlaceHolders = false;
            this.QuantityEdit.Properties.ValidateOnEnterKey = true;
            this.QuantityEdit.Size = new System.Drawing.Size(85, 22);
            this.QuantityEdit.TabIndex = 0;
            this.QuantityEdit.Validating += new System.ComponentModel.CancelEventHandler(this.QuantityEdit_Validating);
            this.QuantityEdit.EditValueChanged += new System.EventHandler(this.QuantityEdit_EditValueChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // labelRem
            // 
            this.labelRem.AutoSize = true;
            this.labelRem.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.remainsBindingSource, "QuantityRemains", true));
            this.labelRem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRem.Location = new System.Drawing.Point(111, 80);
            this.labelRem.Name = "labelRem";
            this.labelRem.Size = new System.Drawing.Size(30, 17);
            this.labelRem.TabIndex = 3;
            this.labelRem.Text = "ост";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.remainsBindingSource, "ManufacturerName", true));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(14, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "изг";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "PackingName", true));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(14, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "форма выпу";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.mDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.remainsBindingSource, "UseByDate", true));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(261, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "label8";
            // 
            // additionPanel
            // 
            this.additionPanel.BackColor = System.Drawing.SystemColors.Info;
            this.additionPanel.Controls.Add(this.labelPlace);
            this.additionPanel.Controls.Add(this.label10);
            this.additionPanel.Controls.Add(this.LabelRec);
            this.additionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.additionPanel.Location = new System.Drawing.Point(0, 210);
            this.additionPanel.Name = "additionPanel";
            this.additionPanel.Size = new System.Drawing.Size(375, 36);
            this.additionPanel.TabIndex = 7;
            this.additionPanel.Visible = false;
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlace.Location = new System.Drawing.Point(3, 0);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(127, 17);
            this.labelPlace.TabIndex = 0;
            this.labelPlace.Text = "место хранения";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(136, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "   ";
            // 
            // LabelRec
            // 
            this.LabelRec.AutoSize = true;
            this.LabelRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelRec.Location = new System.Drawing.Point(162, 0);
            this.LabelRec.Name = "LabelRec";
            this.LabelRec.Size = new System.Drawing.Size(0, 17);
            this.LabelRec.TabIndex = 2;
            // 
            // lRemFull
            // 
            this.lRemFull.AutoSize = true;
            this.lRemFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lRemFull.Location = new System.Drawing.Point(84, 80);
            this.lRemFull.Name = "lRemFull";
            this.lRemFull.Size = new System.Drawing.Size(46, 17);
            this.lRemFull.TabIndex = 8;
            this.lRemFull.Text = "label7";
            this.lRemFull.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(11, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Остаток:";
            // 
            // InvoiceDetailAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lRemFull);
            this.Controls.Add(this.additionPanel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelRem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "InvoiceDetailAdd";
            this.Size = new System.Drawing.Size(375, 246);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.InvoiceDetailAdd_Validating);
            ((System.ComponentModel.ISupportInitialize)(this.remainsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.additionPanel.ResumeLayout(false);
            this.additionPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit QuantityEdit;
        private System.Windows.Forms.BindingSource invoiceDetailBindingSource;
        private MDataSet mDataSet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label labelRem;
        private System.Windows.Forms.BindingSource remainsBindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lComment;
        private System.Windows.Forms.BindingSource productBindingSource;
        private RetailTradeClient.MDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FlowLayoutPanel additionPanel;
        private System.Windows.Forms.Label lRemFull;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LabelRec;
    }
}
