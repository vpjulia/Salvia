using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace RetailTrade
{
    public partial class UCOrganizationRow : UserControl
    {
        public UCOrganizationRow()
        {
            InitializeComponent();
        }

        public UCOrganizationRow(MDataSet.OrganizationRow organizationRow, MainForm.ActionDialog actionDialog)
        {
            InitializeComponent();
            this.mDataSet =organizationRow.Table.DataSet as MDataSet;
            this.organizationBindingSource.DataSource = organizationRow;
         
        }

        private void UCOrganizationRow_Load(object sender, EventArgs e)
        {
           // this.ParentForm.AcceptButton = null;
        }

        
       
        
    }
}
