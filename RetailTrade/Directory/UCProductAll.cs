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
    public partial class UCProductAll : UserControl
    {
        public UCProductAll()
        {
            InitializeComponent();
        }
        public UCProductAll(MDataSet source)
        {
            InitializeComponent();
            productBindingSource.DataSource = source.Product; 
        }
        private void UCProductAll_Load(object sender, EventArgs e)
        {
             
        }



        private void btEdit_Click(object sender, EventArgs e)
        {

            int hendl = (this.grid.FocusedView as ColumnView).FocusedRowHandle;

            if (this.gridView.IsValidRowHandle(hendl) & hendl != DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
            {

                MDataSet.ProductRow pr = ((this.productBindingSource.CurrencyManager.Current as DataRowView).Row as MDataSet.ProductRow);

                FormDialog dform = new FormDialog();

                dform.panel.Controls.Add(new ucProductRow(pr, MainForm.ActionDialog.Edit));

                if (DialogResult.OK == dform.ShowDialog(this))
                {
                    MessageBox.Show("DialogResult.OK");
                }
                else
                {
                    this.productBindingSource.CurrencyManager.CancelCurrentEdit();
                }
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            MDataSet.ProductRow ProductRow = (productBindingSource.AddNew() as DataRowView).Row as MDataSet.ProductRow;

            FormDialog dform = new FormDialog();

            dform.panel.Controls.Add(new ucProductRow(ProductRow, MainForm.ActionDialog.Edit));

            if (DialogResult.OK == dform.ShowDialog(this))
            {
                this.productBindingSource.EndEdit();
            }
            else
            {
                productBindingSource.CurrencyManager.CancelCurrentEdit();
               
            }
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            int hendl = (this.grid.FocusedView as ColumnView).FocusedRowHandle;

            if (this.gridView.IsValidRowHandle(hendl) & hendl != DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
            {
                int countChild = 0;


                DataRow[] arrRows;
                DataRow mrow = (this.grid.FocusedView as ColumnView).GetDataRow(hendl);

                foreach (DataRelation relation in (this.productBindingSource.DataSource as DataTable).ChildRelations)
                {

                    if (mrow.GetChildRows(relation) != null)
                    {
                        arrRows = mrow.GetChildRows(relation);

                        countChild += arrRows.Length;
                    }

                }

                if (countChild != 0)

                    MessageBox.Show("Невозможно удалить запись, ссылок на нее :  " + countChild.ToString());
                else

                    if (MessageBox.Show(" Удалить запись? " + this.gridView.GetFocusedRowCellDisplayText(this.gridView.Columns[1]), "Удаление карточки",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                         == DialogResult.Yes)
                    {
                        this.grid.EmbeddedNavigator.Buttons.Remove.DoClick();


                        /*Удаление на сервере*/

                        this.btSave.Enabled = true;
                    }
            }
        }
    }
}
