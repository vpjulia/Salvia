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
            this.quantityEdit = new DevExpress.XtraEditors.TextEdit();
            this.priceEdit = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceEdit.Properties)).BeginInit();
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
            // quantityEdit
            // 
            this.quantityEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.invoiceDetailBindingSource, "Quantity", true));
            this.quantityEdit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceDetailBindingSource, "Quantity", true));
            this.quantityEdit.EnterMoveNextControl = true;
            this.quantityEdit.Location = new System.Drawing.Point(110, 54);
            this.quantityEdit.Name = "quantityEdit";
            this.quantityEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.quantityEdit.Properties.DisplayFormat.FormatString = "#.###";
            this.quantityEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.quantityEdit.Properties.EditFormat.FormatString = "n3";
            this.quantityEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.quantityEdit.Properties.HideSelection = false;
            this.quantityEdit.Properties.Mask.BeepOnError = true;
            this.quantityEdit.Properties.ValidateOnEnterKey = true;
            this.quantityEdit.Size = new System.Drawing.Size(92, 22);
            this.quantityEdit.TabIndex = 0;
            this.quantityEdit.Validated += new System.EventHandler(this.quantityEdit_Validated);
            // 
            // priceEdit
            // 
            this.priceEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.invoiceDetailBindingSource, "PriceRetailNDS", true));
            this.priceEdit.EnterMoveNextControl = true;
            this.priceEdit.Location = new System.Drawing.Point(110, 91);
            this.priceEdit.Name = "priceEdit";
            this.priceEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.priceEdit.Properties.DisplayFormat.FormatString = "#.##";
            this.priceEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.priceEdit.Properties.EditFormat.FormatString = "#0.00";
            this.priceEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.priceEdit.Properties.ValidateOnEnterKey = true;
            this.priceEdit.Size = new System.Drawing.Size(92, 22);
            this.priceEdit.TabIndex = 1;
            this.priceEdit.Validated += new System.EventHandler(this.priceEdit_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Количество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Цена";
            // 
            // InvoiceDetailRowAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.priceEdit);
            this.Controls.Add(this.quantityEdit);
            this.Name = "InvoiceDetailRowAdd";
            this.Size = new System.Drawing.Size(253, 158);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.InvoiceDetailRowAdd_Validating);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource invoiceDetailBindingSource;
        private MDataSet mDataSet;
        private RetailTrade.MDataSetTableAdapters.InvoiceDetailTableAdapter invoiceDetailTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraEditors.TextEdit priceEdit;
        private DevExpress.XtraEditors.TextEdit quantityEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
