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

        public UCOrganizationRow(MDataSet.OrganizationRow organizationRow, MainForm.ActionDialog actionDialog, MDataSet mainDataset)
        {
            InitializeComponent();
            this.mDataSet = mainDataset;
            this.organizationBindingSource.DataSource = mainDataset.Organization;
         
        }

        private void UCOrganizationRow_Load(object sender, EventArgs e)
        {
            this.ParentForm.AcceptButton = null;
        }

        private void textEdit16_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.organizationBindingSource.EndEdit();
        }

        
    }
}
