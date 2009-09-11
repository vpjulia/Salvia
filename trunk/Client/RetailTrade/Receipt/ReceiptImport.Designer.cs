namespace RetailTradeClient.Receipt
{
    partial class ReceiptImport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiptImport));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tbPatch = new System.Windows.Forms.ToolStripTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
       
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colpharmtrade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfirm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsumall = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colndsall = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumdoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldatedoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsclcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsclname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkolvo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcena = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcenands = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsummands = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coledizm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsclmknm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colserie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltgodn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumsertf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldatsertf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumreg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldatreg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colenddatreg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladding = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnds = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsumma = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltamzav = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmaxnacenka = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnacenka = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btImport = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 419);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(619, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.tbPatch,
            this.btImport});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(619, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tbPatch
            // 
            this.tbPatch.Name = "tbPatch";
            this.tbPatch.Size = new System.Drawing.Size(100, 25);
            // 
            // splitContainer1
            // 
            this.splitContainer1.DataBindings.Add(new System.Windows.Forms.Binding("SplitterDistance", global::RetailTradeClient.Properties.Settings.Default, "impSplitDist", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.listBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grid);
            this.splitContainer1.Size = new System.Drawing.Size(619, 394);
            this.splitContainer1.SplitterDistance = global::RetailTradeClient.Properties.Settings.Default.impSplitDist;
            this.splitContainer1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(233, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 164);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "firm", true));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // bindingSource1
            // 
            // 
            // farmTrade
            // 
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(233, 164);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            this.grid.EmbeddedNavigator.Name = "";
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.MainView = this.gridView1;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(619, 226);
            this.grid.TabIndex = 2;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colpharmtrade,
            this.colfirm,
            this.colsumall,
            this.colndsall,
            this.colnumdoc,
            this.coldatedoc,
            this.colsclcode,
            this.colsclname,
            this.colkolvo,
            this.colcena,
            this.colcenands,
            this.colsummands,
            this.coledizm,
            this.colsclmknm,
            this.colserie,
            this.coltgodn,
            this.colnumsertf,
            this.coldatsertf,
            this.colnumreg,
            this.coldatreg,
            this.colenddatreg,
            this.coladding,
            this.colnds,
            this.colsumma,
            this.coltamzav,
            this.colmaxnacenka,
            this.colnacenka});
            this.gridView1.GridControl = this.grid;
            this.gridView1.Name = "gridView1";
            // 
            // colpharmtrade
            // 
            this.colpharmtrade.Caption = "pharmtrade";
            this.colpharmtrade.FieldName = "pharmtrade";
            this.colpharmtrade.Name = "colpharmtrade";
            // 
            // colfirm
            // 
            this.colfirm.Caption = "firm";
            this.colfirm.FieldName = "firm";
            this.colfirm.Name = "colfirm";
            // 
            // colsumall
            // 
            this.colsumall.Caption = "sumall";
            this.colsumall.FieldName = "sumall";
            this.colsumall.Name = "colsumall";
            // 
            // colndsall
            // 
            this.colndsall.Caption = "ndsall";
            this.colndsall.FieldName = "ndsall";
            this.colndsall.Name = "colndsall";
            // 
            // colnumdoc
            // 
            this.colnumdoc.Caption = "numdoc";
            this.colnumdoc.FieldName = "numdoc";
            this.colnumdoc.Name = "colnumdoc";
            // 
            // coldatedoc
            // 
            this.coldatedoc.Caption = "datedoc";
            this.coldatedoc.FieldName = "datedoc";
            this.coldatedoc.Name = "coldatedoc";
            // 
            // colsclcode
            // 
            this.colsclcode.Caption = "sclcode";
            this.colsclcode.FieldName = "sclcode";
            this.colsclcode.Name = "colsclcode";
            this.colsclcode.Visible = true;
            this.colsclcode.VisibleIndex = 0;
            // 
            // colsclname
            // 
            this.colsclname.Caption = "sclname";
            this.colsclname.FieldName = "sclname";
            this.colsclname.Name = "colsclname";
            this.colsclname.Visible = true;
            this.colsclname.VisibleIndex = 1;
            // 
            // colkolvo
            // 
            this.colkolvo.Caption = "kolvo";
            this.colkolvo.FieldName = "kolvo";
            this.colkolvo.Name = "colkolvo";
            this.colkolvo.Visible = true;
            this.colkolvo.VisibleIndex = 2;
            // 
            // colcena
            // 
            this.colcena.Caption = "cena";
            this.colcena.FieldName = "cena";
            this.colcena.Name = "colcena";
            this.colcena.Visible = true;
            this.colcena.VisibleIndex = 8;
            // 
            // colcenands
            // 
            this.colcenands.Caption = "cenands";
            this.colcenands.FieldName = "cenands";
            this.colcenands.Name = "colcenands";
            this.colcenands.Visible = true;
            this.colcenands.VisibleIndex = 3;
            // 
            // colsummands
            // 
            this.colsummands.Caption = "summands";
            this.colsummands.FieldName = "summands";
            this.colsummands.Name = "colsummands";
            this.colsummands.Visible = true;
            this.colsummands.VisibleIndex = 4;
            // 
            // coledizm
            // 
            this.coledizm.Caption = "edizm";
            this.coledizm.FieldName = "edizm";
            this.coledizm.Name = "coledizm";
            // 
            // colsclmknm
            // 
            this.colsclmknm.Caption = "sclmknm";
            this.colsclmknm.FieldName = "sclmknm";
            this.colsclmknm.Name = "colsclmknm";
            this.colsclmknm.Visible = true;
            this.colsclmknm.VisibleIndex = 5;
            // 
            // colserie
            // 
            this.colserie.Caption = "serie";
            this.colserie.FieldName = "serie";
            this.colserie.Name = "colserie";
            this.colserie.Visible = true;
            this.colserie.VisibleIndex = 6;
            // 
            // coltgodn
            // 
            this.coltgodn.Caption = "tgodn";
            this.coltgodn.FieldName = "tgodn";
            this.coltgodn.Name = "coltgodn";
            this.coltgodn.Visible = true;
            this.coltgodn.VisibleIndex = 7;
            // 
            // colnumsertf
            // 
            this.colnumsertf.Caption = "numsertf";
            this.colnumsertf.FieldName = "numsertf";
            this.colnumsertf.Name = "colnumsertf";
            // 
            // coldatsertf
            // 
            this.coldatsertf.Caption = "datsertf";
            this.coldatsertf.FieldName = "datsertf";
            this.coldatsertf.Name = "coldatsertf";
            // 
            // colnumreg
            // 
            this.colnumreg.Caption = "numreg";
            this.colnumreg.FieldName = "numreg";
            this.colnumreg.Name = "colnumreg";
            // 
            // coldatreg
            // 
            this.coldatreg.Caption = "datreg";
            this.coldatreg.FieldName = "datreg";
            this.coldatreg.Name = "coldatreg";
            // 
            // colenddatreg
            // 
            this.colenddatreg.Caption = "enddatreg";
            this.colenddatreg.FieldName = "enddatreg";
            this.colenddatreg.Name = "colenddatreg";
            // 
            // coladding
            // 
            this.coladding.Caption = "adding";
            this.coladding.FieldName = "adding";
            this.coladding.Name = "coladding";
            // 
            // colnds
            // 
            this.colnds.Caption = "nds";
            this.colnds.FieldName = "nds";
            this.colnds.Name = "colnds";
            // 
            // colsumma
            // 
            this.colsumma.Caption = "summa";
            this.colsumma.FieldName = "summa";
            this.colsumma.Name = "colsumma";
            this.colsumma.Visible = true;
            this.colsumma.VisibleIndex = 9;
            // 
            // coltamzav
            // 
            this.coltamzav.Caption = "tamzav";
            this.coltamzav.FieldName = "tamzav";
            this.coltamzav.Name = "coltamzav";
            // 
            // colmaxnacenka
            // 
            this.colmaxnacenka.Caption = "maxnacenka";
            this.colmaxnacenka.FieldName = "maxnacenka";
            this.colmaxnacenka.Name = "colmaxnacenka";
            // 
            // colnacenka
            // 
            this.colnacenka.Caption = "nacenka";
            this.colnacenka.FieldName = "nacenka";
            this.colnacenka.Name = "colnacenka";
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.grid;
            this.gridView2.Name = "gridView2";
            // 
            // btImport
            // 
            this.btImport.Image = ((System.Drawing.Image)(resources.GetObject("btImport.Image")));
            this.btImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(86, 22);
            this.btImport.Text = "Принять";

            // 
            // ReceiptImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Tag", global::RetailTradeClient.Properties.Settings.Default, "ImpDataSource", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Name = "ReceiptImport";
            this.Size = new System.Drawing.Size(619, 441);
            this.Tag = global::RetailTradeClient.Properties.Settings.Default.ImpDataSource;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
       
      
        private System.Windows.Forms.ToolStripTextBox tbPatch;
        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colpharmtrade;
        private DevExpress.XtraGrid.Columns.GridColumn colfirm;
        private DevExpress.XtraGrid.Columns.GridColumn colsumall;
        private DevExpress.XtraGrid.Columns.GridColumn colndsall;
        private DevExpress.XtraGrid.Columns.GridColumn colnumdoc;
        private DevExpress.XtraGrid.Columns.GridColumn coldatedoc;
        private DevExpress.XtraGrid.Columns.GridColumn colsclcode;
        private DevExpress.XtraGrid.Columns.GridColumn colsclname;
        private DevExpress.XtraGrid.Columns.GridColumn colkolvo;
        private DevExpress.XtraGrid.Columns.GridColumn colcenands;
        private DevExpress.XtraGrid.Columns.GridColumn colsummands;
        private DevExpress.XtraGrid.Columns.GridColumn coledizm;
        private DevExpress.XtraGrid.Columns.GridColumn colsclmknm;
        private DevExpress.XtraGrid.Columns.GridColumn colserie;
        private DevExpress.XtraGrid.Columns.GridColumn coltgodn;
        private DevExpress.XtraGrid.Columns.GridColumn colnumsertf;
        private DevExpress.XtraGrid.Columns.GridColumn coldatsertf;
        private DevExpress.XtraGrid.Columns.GridColumn colnumreg;
        private DevExpress.XtraGrid.Columns.GridColumn coldatreg;
        private DevExpress.XtraGrid.Columns.GridColumn colenddatreg;
        private DevExpress.XtraGrid.Columns.GridColumn coladding;
        private DevExpress.XtraGrid.Columns.GridColumn colnds;
        private DevExpress.XtraGrid.Columns.GridColumn colcena;
        private DevExpress.XtraGrid.Columns.GridColumn colsumma;
        private DevExpress.XtraGrid.Columns.GridColumn coltamzav;
        private DevExpress.XtraGrid.Columns.GridColumn colmaxnacenka;
        private DevExpress.XtraGrid.Columns.GridColumn colnacenka;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
      
        private System.Windows.Forms.ToolStripButton btImport;
     
    }
}
