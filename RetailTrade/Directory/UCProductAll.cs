using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

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

        private void button1_Click(object sender, EventArgs e)
        {
            MDataSet.ProductRow pr = (this.ParentForm as MainForm).mDataSet.Product.FindByID(17);

            FormDialog dform = new FormDialog();
          
            dform.panel.Controls.Add(new ucProductRow(pr, MainForm.ActionDialog.Edit, (this.ParentForm as MainForm).mDataSet));

            if (DialogResult.OK == dform.ShowDialog(this))
            {
                MessageBox.Show("DialogResult.OK");
            }
        }
    }
}
