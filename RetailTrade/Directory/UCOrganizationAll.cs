using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace RetailTrade
{
    public partial class UCOrganizationAll : UserControl
    {
        public UCOrganizationAll()
        {
            InitializeComponent();
        }

        public UCOrganizationAll(MDataSet source)
        {
            InitializeComponent();
            organizationBindingSource.DataSource = source.Organization;
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            MDataSet.OrganizationRow OrganizationRow = (organizationBindingSource.DataSource as MDataSet.OrganizationDataTable).FindByID(0);

            FormDialog dform = new FormDialog();

            dform.panel.Controls.Add(new UCOrganizationRow(OrganizationRow, MainForm.ActionDialog.Edit,(MDataSet)(organizationBindingSource.DataSource as DataTable).DataSet));

            if (DialogResult.OK == dform.ShowDialog(this))
            {
                MessageBox.Show("DialogResult.OK");
            }


        }

    }
}
