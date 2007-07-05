using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;

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

        private void btEdit_Click(object sender, EventArgs e)
        {
            int hendl = (this.grid.FocusedView as ColumnView).FocusedRowHandle;

            if (this.gridView.IsValidRowHandle(hendl) & hendl != DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
            {
                MDataSet.OrganizationRow OrganizationRow = (organizationBindingSource.DataSource as MDataSet.OrganizationDataTable).FindByID(((int)this.gridView.GetFocusedRowCellValue(this.colID)));

                FormDialog dform = new FormDialog();

                dform.panel.Controls.Add(new UCOrganizationRow(OrganizationRow, MainForm.ActionDialog.Edit) );

                if (DialogResult.OK == dform.ShowDialog(this))
                {
                    this.organizationBindingSource.EndEdit();
                }
                else
                {
                    OrganizationRow.RejectChanges();
                }
                

            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            MDataSet.OrganizationRow OrganizationRow = (organizationBindingSource.AddNew() as DataRowView).Row as MDataSet.OrganizationRow;

           FormDialog dform = new FormDialog();

            dform.panel.Controls.Add(new UCOrganizationRow(OrganizationRow, MainForm.ActionDialog.Edit));

            if (DialogResult.OK == dform.ShowDialog(this))
            {
                this.organizationBindingSource.EndEdit();
            }
            else
            {
                organizationBindingSource.CurrencyManager.CancelCurrentEdit();
             //  OrganizationRow.RejectChanges();
            }
           
        }
    }
}
