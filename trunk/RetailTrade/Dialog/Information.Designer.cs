namespace RetailTrade
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxInf = new System.Windows.Forms.ListBox();
            this.panelInf.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInf
            // 
            this.panelInf.Controls.Add(this.label2);
            this.panelInf.Controls.Add(this.label1);
            this.panelInf.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInf.Location = new System.Drawing.Point(0, 0);
            this.panelInf.Name = "panelInf";
            this.panelInf.Size = new System.Drawing.Size(354, 79);
            this.panelInf.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сохранить  изменения?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
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

        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListBox listBoxInf;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panelInf;
    }
}
