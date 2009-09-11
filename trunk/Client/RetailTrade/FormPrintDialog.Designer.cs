namespace RetailTradeClient
{
    partial class FormPrintDialog
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
            this.ProductSelectByIdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RetailTradeClDataSet = new RetailTradeClient.RetailTradeClDataSet();
            this.ProductRemainsByDateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ProductRemainsByDateTableAdapter = new RetailTradeClient.RetailTradeClDataSetTableAdapters.ProductRemainsByDateTableAdapter();
            this.parametrsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.startDateEdit = new System.Windows.Forms.DateTimePicker();
            this.endDateEdit = new System.Windows.Forms.DateTimePicker();
            this.btRefreshReport = new System.Windows.Forms.Button();
            this.ProductSelectByIdTableAdapter = new RetailTradeClient.RetailTradeClDataSetTableAdapters.ProductSelectByIdTableAdapter();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ProductSelectByIdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetailTradeClDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductRemainsByDateBindingSource)).BeginInit();
            this.parametrsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductSelectByIdBindingSource
            // 
            this.ProductSelectByIdBindingSource.DataMember = "ProductSelectById";
            this.ProductSelectByIdBindingSource.DataSource = this.RetailTradeClDataSet;
            // 
            // RetailTradeClDataSet
            // 
            this.RetailTradeClDataSet.DataSetName = "RetailTradeClDataSet";
            this.RetailTradeClDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProductRemainsByDateBindingSource
            // 
            this.ProductRemainsByDateBindingSource.DataMember = "ProductRemainsByDate";
            this.ProductRemainsByDateBindingSource.DataSource = this.RetailTradeClDataSet;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 501);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(713, 42);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // ProductRemainsByDateTableAdapter
            // 
            this.ProductRemainsByDateTableAdapter.ClearBeforeFill = true;
            // 
            // parametrsPanel
            // 
            this.parametrsPanel.Controls.Add(this.startDateEdit);
            this.parametrsPanel.Controls.Add(this.endDateEdit);
            this.parametrsPanel.Controls.Add(this.btRefreshReport);
            this.parametrsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.parametrsPanel.Location = new System.Drawing.Point(0, 0);
            this.parametrsPanel.Name = "parametrsPanel";
            this.parametrsPanel.Size = new System.Drawing.Size(713, 28);
            this.parametrsPanel.TabIndex = 2;
            // 
            // startDateEdit
            // 
            this.startDateEdit.Location = new System.Drawing.Point(3, 3);
            this.startDateEdit.Name = "startDateEdit";
            this.startDateEdit.Size = new System.Drawing.Size(200, 22);
            this.startDateEdit.TabIndex = 0;
            // 
            // endDateEdit
            // 
            this.endDateEdit.Location = new System.Drawing.Point(209, 3);
            this.endDateEdit.Name = "endDateEdit";
            this.endDateEdit.Size = new System.Drawing.Size(200, 22);
            this.endDateEdit.TabIndex = 1;
            // 
            // btRefreshReport
            // 
            this.btRefreshReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btRefreshReport.Image = global::RetailTradeClient.Properties.Resources.refresh;
            this.btRefreshReport.Location = new System.Drawing.Point(415, 3);
            this.btRefreshReport.Name = "btRefreshReport";
            this.btRefreshReport.Size = new System.Drawing.Size(75, 23);
            this.btRefreshReport.TabIndex = 2;
            this.btRefreshReport.UseVisualStyleBackColor = true;
            // 
            // ProductSelectByIdTableAdapter
            // 
            this.ProductSelectByIdTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer.Location = new System.Drawing.Point(0, 28);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.Size = new System.Drawing.Size(713, 473);
            this.reportViewer.TabIndex = 3;
            // 
            // FormPrintDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(713, 543);
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.parametrsPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormPrintDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр отчета ";
            this.Load += new System.EventHandler(this.FormPrintDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductSelectByIdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetailTradeClDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductRemainsByDateBindingSource)).EndInit();
            this.parametrsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.BindingSource ProductRemainsByDateBindingSource;
        private RetailTradeClDataSet RetailTradeClDataSet;
        private RetailTradeClient.RetailTradeClDataSetTableAdapters.ProductRemainsByDateTableAdapter ProductRemainsByDateTableAdapter;
        private System.Windows.Forms.FlowLayoutPanel parametrsPanel;
        private System.Windows.Forms.DateTimePicker startDateEdit;
        private System.Windows.Forms.DateTimePicker endDateEdit;
        private System.Windows.Forms.Button btRefreshReport;
        private System.Windows.Forms.BindingSource ProductSelectByIdBindingSource;
        private RetailTradeClient.RetailTradeClDataSetTableAdapters.ProductSelectByIdTableAdapter ProductSelectByIdTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
    }
}