namespace RetailTradeOrders
{
    partial class Information
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
            this.panelInf = new System.Windows.Forms.Panel();
            this.labelAsk = new System.Windows.Forms.Label();
            this.labelHeader = new System.Windows.Forms.Label();
            this.listBoxInf = new System.Windows.Forms.ListBox();
            this.panelInf.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInf
            // 
            this.panelInf.Controls.Add(this.labelAsk);
            this.panelInf.Controls.Add(this.labelHeader);
            this.panelInf.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInf.Location = new System.Drawing.Point(0, 0);
            this.panelInf.Name = "panelInf";
            this.panelInf.Size = new System.Drawing.Size(354, 79);
            this.panelInf.TabIndex = 0;
            // 
            // labelAsk
            // 
            this.labelAsk.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelAsk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAsk.Location = new System.Drawing.Point(0, 59);
            this.labelAsk.Name = "labelAsk";
            this.labelAsk.Size = new System.Drawing.Size(354, 20);
            this.labelAsk.TabIndex = 1;
            this.labelAsk.Text = "Сохранить  изменения?";
            this.labelAsk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Location = new System.Drawing.Point(14, 19);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(46, 17);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "label1";
            // 
            // listBoxInf
            // 
            this.listBoxInf.CausesValidation = false;
            this.listBoxInf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxInf.FormattingEnabled = true;
            this.listBoxInf.HorizontalScrollbar = true;
            this.listBoxInf.ItemHeight = 16;
            this.listBoxInf.Location = new System.Drawing.Point(0, 79);
            this.listBoxInf.Name = "listBoxInf";
            this.listBoxInf.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxInf.Size = new System.Drawing.Size(354, 244);
            this.listBoxInf.TabIndex = 1;
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBoxInf);
            this.Controls.Add(this.panelInf);
            this.Name = "Information";
            this.Size = new System.Drawing.Size(354, 332);
            this.panelInf.ResumeLayout(false);
            this.panelInf.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox listBoxInf;
        public System.Windows.Forms.Label labelHeader;
        public System.Windows.Forms.Panel panelInf;
        public System.Windows.Forms.Label labelAsk;
    }
}
