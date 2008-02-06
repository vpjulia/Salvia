using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;
using RetailTrade.Dialog;
using Microsoft.Reporting.WinForms;

namespace RetailTrade.Orders
{
    public partial class OrdersAll : UserControl
    {
        public OrdersAll()
        {
            InitializeComponent();
        }
        public OrdersAll(MDataSet.OrdersDataTable source)
        {
            InitializeComponent();

            this.mDataSet = source.DataSet as MDataSet;

         this.ordersBindingSource.DataSource = new DataView(source,"Quantity - Reserved- QuantityNow >0 and isClose=0",null,DataViewRowState.CurrentRows);

         this.ordersBindingSource.ResetBindings(false);

         this.ordersOldBindingSource.DataSource = new DataView(source, "Quantity - Reserved - QuantityNow <=0",null,DataViewRowState.CurrentRows);

         this.ordersBindingSourceAll.DataSource = new DataView(source, null, null, DataViewRowState.CurrentRows);


         this.tradePutletBindingSource.DataSource = this.mDataSet.TradePutlet;
         this.tradePutletBindingSource.ResetBindings(false);
         this.productBindingSource.DataSource = this.mDataSet.Product;
         this.productBindingSource.ResetBindings(false);
         this.dateEdit.Value = DateTime.Today;


       //this.TradePutletLookUpEdit.DataSource = 

        }

        private void btClose_Click(object sender, EventArgs e)

        {
            foreach (GridView view in this.grid.ViewCollection)
            {
                string fileName = new FileInfo(Application.ExecutablePath).DirectoryName + "\\" + view.Name.ToString() + ".xml";
                view.SaveLayoutToXml(fileName);
            }

            (this.ParentForm as MainForm).DeleteDataTab(this.Parent as TabPage);
        }

        private void OrdersAll_Load(object sender, EventArgs e)
        {
            this.btSave_Click(sender, e);

            this.ordersTableAdapter.Fill(this.mDataSet.Orders);

            foreach (GridView view in this.grid.ViewCollection)
            {
                string fileName = new FileInfo(Application.ExecutablePath).DirectoryName + "\\" + view.Name.ToString() + ".xml";
                if (File.Exists(fileName))
                    view.RestoreLayoutFromXml(fileName);
            }

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.ordersTableAdapter.Update(this.mDataSet.Orders);

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            
            }
        }

        private void btReport_Click(object sender, EventArgs e)
        {

            if (this.mDataSet.HasChanges())
            {
                MessageBox.Show("Есть несохраненные данные!");
                return;
            }
        

            if (this.mDataSet.Orders.HasErrors) return;

            printingControl printview = new printingControl("/ReportRetailTrade/OrdersForReport");

            FormDialog formDialog = new FormDialog();

            formDialog.panel.Controls.Add(printview);

            DateTime time = DateTime.Now;


            printview.reportViewer.RefreshReport();
           
            if (formDialog.ShowDialog(this) == DialogResult.OK)
            {

                if( MessageBox.Show("Закрыть заказанные позиции?","Закрытие заказа",MessageBoxButtons.OKCancel,MessageBoxIcon.Asterisk)==DialogResult.OK )
                {
                try
                {/*закрыть заявки*/
                    this.ordersTableAdapter.OrdersSetReservedCommand(time);
                    this.ordersTableAdapter.Fill(this.mDataSet.Orders);
                    

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                 }
                }
            }

        }

        private void btRefreshRepiod_Click(object sender, EventArgs e)
        {
            try
            {
                this.ordersTableAdapter.Update(this.mDataSet.Orders);

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

            }

            MDataSet.OrdersDataTable tmpOrders = new MDataSet.OrdersDataTable();

            
            //Перечитать за период
            try
            {
                this.ordersTableAdapter.FillByStartDate(tmpOrders, this.dateEdit.Value);

                this.mDataSet.Orders.Merge(tmpOrders);

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
   
        private void gridViewOrdersAll_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            try
            {
                MDataSet.OrdersRow _ordsRow = (sender as GridView).GetDataRow(e.RowHandle) as MDataSet.OrdersRow;

                if (_ordsRow == null) return;


                if (((_ordsRow.QuantityNow > 0) | (_ordsRow.Reserved > 0)) & !(_ordsRow.QuantityNow == _ordsRow.Quantity))
                {
                    e.Appearance.Font = e.Cache.GetFont(e.Appearance.Font, FontStyle.Italic);
                    e.Appearance.BackColor = Color.LightGreen;
                }
                else
                {
                    if ((_ordsRow.QuantityNow == _ordsRow.Quantity) | (_ordsRow.isClose))
                    {

                        e.Appearance.Font = e.Cache.GetFont(e.Appearance.Font, FontStyle.Italic);
                        e.Appearance.ForeColor = Color.Gray;
                    }
                }


                if (((_ordsRow.Quantity > _ordsRow.QuantityNow)) & _ordsRow.isClose)
                {
                    e.Appearance.Font = e.Cache.GetFont(e.Appearance.Font, FontStyle.Strikeout);
                    e.Appearance.BackColor = Color.LightGray;


                }

                if (_ordsRow.RowState != DataRowState.Unchanged)
                    e.Appearance.BackColor = Color.LightCoral;

            }
            catch 
            {
                MessageBox.Show("Ошибка прорисовки!");
            }

        }

        private void btProductReport_Click(object sender, EventArgs e)
        {

            MDataSet.OrdersRow _ordsRow = this.gridViewOrdersAll.GetDataRow(this.gridViewOrdersAll.FocusedRowHandle) as MDataSet.OrdersRow;

            if (_ordsRow != null)
            {
                (this.ParentForm as MainForm).ProductReport(_ordsRow.ProductRef);
            
            }
        }

        private void btOrdersOldReport_Click(object sender, EventArgs e)
        {

            if ((this.ordersOldBindingSource.Current as DataRowView) != null)
            { 
              int _tradePutletRef = ((this.ordersOldBindingSource.Current as DataRowView).Row as MDataSet.OrdersRow).TradePupletRef;

              FormDialog fromDialog = new FormDialog();


              printingControl preview = new printingControl("/ReportRetailTrade/OrdersOld");

              ReportParameter TradePutletRef = new ReportParameter("TradePutletRef", _tradePutletRef.ToString());

              preview.reportViewer.ShowParameterPrompts = false;
              preview.reportViewer.ServerReport.SetParameters(new ReportParameter[] { TradePutletRef });

              fromDialog.panel.Controls.Add(preview);

              preview.reportViewer.RefreshReport();


              fromDialog.ShowDialog(this);

            }



        }

        private void btNewReport_Click(object sender, EventArgs e)
        {

            if ((this.ordersBindingSource.Current as DataRowView) != null)
            {
                int _tradePutletRef = ((this.ordersBindingSource.Current as DataRowView).Row as MDataSet.OrdersRow).TradePupletRef;

                FormDialog fromDialog = new FormDialog();

                printingControl preview = new printingControl("/ReportRetailTrade/OrdersNew");

                ReportParameter TradePutletRef = new ReportParameter("TradePutletRef", _tradePutletRef.ToString());

                preview.reportViewer.ShowParameterPrompts = false;
                preview.reportViewer.ServerReport.SetParameters(new ReportParameter[] { TradePutletRef });

                fromDialog.panel.Controls.Add(preview);
                preview.reportViewer.RefreshReport();
                fromDialog.ShowDialog(this);

            }
        }

        private void btAddOrders_Click(object sender, EventArgs e)
        {
            int Ref;

            this.ordersBindingSource.EndEdit();

            MDataSet.OrdersRow ordrow =(this.ordersBindingSource.Current as DataRowView).Row as MDataSet.OrdersRow;

            if (ordrow != null) Ref = ordrow.TradePupletRef;
            else Ref = 1;


            
            this.btSave_Click(sender, e);



            this.grid.EmbeddedNavigator.Buttons.Append.DoClick();



            MDataSet.OrdersRow row = (this.ordersBindingSource.Current as DataRowView).Row as MDataSet.OrdersRow;
                               
            row.TradePupletRef = Ref;
            row.Reserved = 0;

            FormDialog formDialog = new FormDialog();
            formDialog.Text = "Добавить новый заказ ";
            formDialog.AcceptButton = null;

            OrderAdd orderAdd = new OrderAdd(row, this.ParentForm as MainForm);
            formDialog.panel.Controls.Add(orderAdd);

            if (formDialog.ShowDialog(this) == DialogResult.OK)
            {
                this.grid.EmbeddedNavigator.Buttons.EndEdit.DoClick();

                this.ordersBindingSource.EndEdit();
                
                this.btSave_Click(sender, e);
            }
            else
            {
                this.ordersBindingSource.CancelEdit();
                this.mDataSet.Orders.RejectChanges();
            }

            this.grid.Refresh();

        }
       
     
     
        
    }
}
