using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace RetailTrade
{
    public partial class UcGroupDirectory : UserControl
    {
        public UcGroupDirectory()
        {
            InitializeComponent();
        }
        public UcGroupDirectory(DataTable source)
        {
            InitializeComponent();

            this.bindingSource.DataSource = source;
            this.grid.DataSource = this.bindingSource;
            this.colGroupRef.FieldName =source.Columns[2].ColumnName;
            if  (source.ParentRelations.Count>0)
              
            this.LookUpEdit.DataSource=source.ParentRelations[0].ParentTable;
        }

        private void gridView_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            this.gridView.SetColumnError(this.gridView.Columns[1], e.ErrorText.ToString());
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;

        }



    }
}
