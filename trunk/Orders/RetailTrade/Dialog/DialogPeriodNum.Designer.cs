namespace RetailTradeOrders.Dialog
{
    partial class DialogPeriodNum
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btOk = new System.Windows.Forms.Button();
            this.startEdit = new System.Windows.Forms.NumericUpDown();
            this.endEdit = new System.Windows.Forms.NumericUpDown();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.startEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "С :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "по :";
            // 
            // btOk
            // 
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOk.Image = global::RetailTradeOrders.Properties.Resources.check2;
            this.btOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btOk.Location = new System.Drawing.Point(165, 118);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(86, 32);
            this.btOk.TabIndex = 4;
            this.btOk.Text = "Ок";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // startEdit
            // 
            this.startEdit.Location = new System.Drawing.Point(78, 32);
            this.startEdit.Name = "startEdit";
            this.startEdit.Size = new System.Drawing.Size(120, 22);
            this.startEdit.TabIndex = 5;
            this.startEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // endEdit
            // 
            this.endEdit.Location = new System.Drawing.Point(78, 74);
            this.endEdit.Name = "endEdit";
            this.endEdit.Size = new System.Drawing.Size(120, 22);
            this.endEdit.TabIndex = 6;
            this.endEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DialogPeriodNum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 162);
            this.Controls.Add(this.endEdit);
            this.Controls.Add(this.startEdit);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogPeriodNum";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ответ за период по номеру";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.startEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.NumericUpDown startEdit;
        public System.Windows.Forms.NumericUpDown endEdit;
    }
}