using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace RetailTrade.Orders
{
    public partial class OrderAdd : UserControl
    {

        MainForm _mainForm;
        DataTable _product;

        public OrderAdd()
        {
            InitializeComponent();
        }


        public OrderAdd(MDataSet.OrdersRow source, MainForm mainForm)
        {
           
            InitializeComponent();
            _mainForm = mainForm;
            this.mDataSet =source.Table.DataSet as MDataSet;

            this.ordersBindingSource.DataSource = source;
            
            this.errorProvider1.DataSource = this.ordersBindingSource.DataSource;
            
            this.tradePutletBindingSource.DataSource =new DataView( this.mDataSet.TradePutlet, "ID>0",null,DataViewRowState.CurrentRows);
            
            this.tradePutletBindingSource.ResetBindings(false);

            _product = _mainForm.fullDataSet.Product;

            this.productBindingSource.DataSource = _mainForm.fullDataSet.Product;

            this.productBindingSource.ResetBindings(false);

        
        }

        private void OrderAdd_Validating(object sender, CancelEventArgs e)
        {

            if (Convert.ToInt32(this.quantityEdit.EditValue.ToString()) == 0)
            {
                this.errorProvider1.SetError(this.quantityEdit, "¬ведите значение!");
                e.Cancel = true;
            
            }

            if (Convert.ToInt32(this.productlookUpEdit.EditValue.ToString()) ==0)

            {

                this.errorProvider1.SetError(this.productlookUpEdit, "¬ведите значение!");
                e.Cancel = true;
            
            }


            if (this.noteEdit.EditValue.ToString() == "")
            {
                this.errorProvider1.SetError(this.noteEdit, "¬ведите значение!");
                e.Cancel = true;
            }

        }

        private void tradePutletlookUpEdit_Validating(object sender, CancelEventArgs e)
        {
            if (this.tradePutletlookUpEdit.EditValue.ToString() == "")
            {
                this.errorProvider1.SetError(sender as Control, "¬ведите значение!");
                e.Cancel = true;
            }
           

        }

        private void OrderAdd_Validated(object sender, EventArgs e)
        {
            this.ordersBindingSource.EndEdit();
        }

        private void Find_Click(object sender, EventArgs e)
        {
            string name = this.productlookUpEdit.Text;

            if (name.Length == 0) return;
            try
            {
                FullDataSet.ProductDataTable _pr = new FullDataSet.ProductDataTable();

                _mainForm.productTableAdapter1.FillByName(_pr, name);
                _product.Merge(_pr);

                this.productBindingSource.ResetBindings(false);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void productlookUpEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button == this.productlookUpEdit.Properties.Buttons[1])
            {
                this.Find_Click(sender, e);
            
            }
        }

    }
}
