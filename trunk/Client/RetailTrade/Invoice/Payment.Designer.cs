namespace RetailTradeClient.Invoice
{
    partial class Payment
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btCancel = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CashEdit = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCanges = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.invoiceMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mDataSet = new RetailTradeClient.MDataSet();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CashEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.CausesValidation = false;
            this.flowLayoutPanel1.Controls.Add(this.btCancel);
            this.flowLayoutPanel1.Controls.Add(this.btOk);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 124);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(292, 41);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btCancel
            // 
            this.btCancel.CausesValidation = false;
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Image = global::RetailTradeClient.Properties.Resources.delete2;
            this.btCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCancel.Location = new System.Drawing.Point(197, 3);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(92, 34);
            this.btCancel.TabIndex = 1;
            this.btCancel.Text = "Отмена";
            this.btCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btOk
            // 
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOk.Image = global::RetailTradeClient.Properties.Resources.check2;
            this.btOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btOk.Location = new System.Drawing.Point(103, 3);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(88, 34);
            this.btOk.TabIndex = 0;
            this.btOk.Text = "Ок";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "От клиента :";
            // 
            // CashEdit
            // 
            this.CashEdit.EnterMoveNextControl = true;
            this.errorProvider1.SetIconAlignment(this.CashEdit, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.CashEdit.Location = new System.Drawing.Point(120, 48);
            this.CashEdit.Name = "CashEdit";
            this.CashEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.CashEdit.Properties.Appearance.Options.UseFont = true;
            this.CashEdit.Properties.DisplayFormat.FormatString = "####0.00";
            this.CashEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.CashEdit.Properties.EditFormat.FormatString = "#####.00";
            this.CashEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.CashEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.CashEdit.Properties.Mask.ShowPlaceHolders = false;
            this.CashEdit.Properties.ValidateOnEnterKey = true;
            this.CashEdit.Size = new System.Drawing.Size(133, 23);
            this.CashEdit.TabIndex = 0;
            this.CashEdit.ToolTip = "Сумма, полученная от покупателя";
            this.CashEdit.Validating += new System.ComponentModel.CancelEventHandler(this.CashEdit_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Сдача :";
            // 
            // labelCanges
            // 
            this.labelCanges.AutoSize = true;
            this.labelCanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCanges.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelCanges.Location = new System.Drawing.Point(117, 86);
            this.labelCanges.Name = "labelCanges";
            this.labelCanges.Size = new System.Drawing.Size(52, 17);
            this.labelCanges.TabIndex = 3;
            this.labelCanges.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceMasterBindingSource, "Sum", true));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(117, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // invoiceMasterBindingSource
            // 
            this.invoiceMasterBindingSource.DataMember = "InvoiceMaster";
            this.invoiceMasterBindingSource.DataSource = this.mDataSet;
            // 
            // mDataSet
            // 
            this.mDataSet.DataSetName = "MDataSet";
            this.mDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(292, 165);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelCanges);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CashEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Payment";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оплата";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Payment_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CashEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit CashEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCanges;
        private System.Windows.Forms.Label label4;
        private MDataSet mDataSet;
        private System.Windows.Forms.BindingSource invoiceMasterBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}