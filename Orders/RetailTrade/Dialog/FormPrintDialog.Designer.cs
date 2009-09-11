namespace RetailTradeOrders.Dialog
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ProductRemainsByDateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RetailTradeClDataSet = new RetailTradeOrders.RetailTradeClDataSet();
            this.parametrsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.startDateEdit = new System.Windows.Forms.DateTimePicker();
            this.endDateEdit = new System.Windows.Forms.DateTimePicker();
            this.btRefreshReport = new System.Windows.Forms.Button();
            this.ProductSelectByIdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProductSelectByIdTableAdapter = new RetailTradeOrders.RetailTradeClDataSetTableAdapters.ProductSelectByIdTableAdapter();
            this.ProductRemainsByDateTableAdapter = new RetailTradeOrders.RetailTradeClDataSetTableAdapters.ProductRemainsByDateTableAdapter();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ProductRemainsByDateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetailTradeClDataSet)).BeginInit();
            this.parametrsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductSelectByIdBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductRemainsByDateBindingSource
            // 
            this.ProductRemainsByDateBindingSource.DataMember = "ProductRemainsByDate";
            this.ProductRemainsByDateBindingSource.DataSource = this.RetailTradeClDataSet;
            // 
            // RetailTradeClDataSet
            // 
            this.RetailTradeClDataSet.DataSetName = "RetailTradeClDataSet";
            this.RetailTradeClDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parametrsPanel
            // 
            this.parametrsPanel.Controls.Add(this.startDateEdit);
            this.parametrsPanel.Controls.Add(this.endDateEdit);
            this.parametrsPanel.Controls.Add(this.btRefreshReport);
            this.parametrsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.parametrsPanel.Location = new System.Drawing.Point(0, 0);
            this.parametrsPanel.Name = "parametrsPanel";
            this.parametrsPanel.Size = new System.Drawing.Size(787, 28);
            this.parametrsPanel.TabIndex = 3;
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
            this.btRefreshReport.Image = global::RetailTradeOrders.Properties.Resources.refresh;
            this.btRefreshReport.Location = new System.Drawing.Point(415, 3);
            this.btRefreshReport.Name = "btRefreshReport";
            this.btRefreshReport.Size = new System.Drawing.Size(75, 23);
            this.btRefreshReport.TabIndex = 2;
            this.btRefreshReport.UseVisualStyleBackColor = true;
            // 
            // ProductSelectByIdBindingSource
            // 
            this.ProductSelectByIdBindingSource.DataMember = "ProductSelectById";
            this.ProductSelectByIdBindingSource.DataSource = this.RetailTradeClDataSet;
            // 
            // ProductSelectByIdTableAdapter
            // 
            this.ProductSelectByIdTableAdapter.ClearBeforeFill = true;
            // 
            // ProductRemainsByDateTableAdapter
            // 
            this.ProductRemainsByDateTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "RetailTradeClDataSet_ProductRemainsByDate";
            reportDataSource1.Value = this.ProductRemainsByDateBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "RetailTradeOrders.Resources.ProductReport.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 28);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.Size = new System.Drawing.Size(787, 530);
            this.reportViewer.TabIndex = 4;
            // 
            // FormPrintDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 558);
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.parametrsPanel);
            this.Name = "FormPrintDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр отчета";
            this.Load += new System.EventHandler(this.FormPrintDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductRemainsByDateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetailTradeClDataSet)).EndInit();
            this.parametrsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductSelectByIdBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel parametrsPanel;
        private System.Windows.Forms.DateTimePicker startDateEdit;
        private System.Windows.Forms.DateTimePicker endDateEdit;
        private System.Windows.Forms.Button btRefreshReport;
        private System.Windows.Forms.BindingSource ProductSelectByIdBindingSource;
        private RetailTradeClDataSet RetailTradeClDataSet;
        private RetailTradeOrders.RetailTradeClDataSetTableAdapters.ProductSelectByIdTableAdapter ProductSelectByIdTableAdapter;
        private System.Windows.Forms.BindingSource ProductRemainsByDateBindingSource;
        private RetailTradeOrders.RetailTradeClDataSetTableAdapters.ProductRemainsByDateTableAdapter ProductRemainsByDateTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
    }
}