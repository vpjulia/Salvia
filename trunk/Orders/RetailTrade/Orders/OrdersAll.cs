using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;
using RetailTradeOrders.Dialog;

namespace RetailTradeOrders.Orders
{
    public partial class OrdersAll : UserControl
    {
        public OrdersAll()
        {
            InitializeComponent();

             }

        public OrdersAll(MDataSet source)
        {
            InitializeComponent();
            this.mDataSet = source;

            this.ordersBindingSource.DataSource = this.mDataSet.Orders;

            this.productBindingSource.DataSource = this.mDataSet.Product;
            
            this.productBindingSource.ResetBindings(true);

        }

        private void OrdersAll_Load(object sender, EventArgs e)
        {
          
            foreach (GridView view in this.gridProduct.ViewCollection)
            {
                string fileName = new FileInfo(Application.ExecutablePath).DirectoryName + "\\" + view.Name.ToString() + ".xml";
                if (File.Exists(fileName))
                    view.RestoreLayoutFromXml(fileName);
            }
            foreach (GridView view in this.gridOrders.ViewCollection)
            {
                string fileName = new FileInfo(Application.ExecutablePath).DirectoryName + "\\" + view.Name.ToString() + ".xml";
                if (File.Exists(fileName))
                    view.RestoreLayoutFromXml(fileName);
            }
            

        }


        private void btRefreshData_Click(object sender, EventArgs e)
        {

            int res;
            try
            {

                res = this.ordersTableAdapter.Update(this.mDataSet.Orders);
                MessageBox.Show("Сохранено: " + res.ToString()); 
           
            }
            catch (DBConcurrencyException dbcx)
            {

                MessageBox.Show("Не удалось сохранить 1 строку!");
                dbcx.Row.RejectChanges();

                this.ordersTableAdapter.Update(this.mDataSet.Orders);
               
                
            }

            catch (Exception err)
            {

                MessageBox.Show("Не удалось сохранить данные!");
                MessageBox.Show(err.Message);

                return;
            }

            this.ordersBindingSource.ResetBindings(false);

            try {
                MDataSet.ProductDataTable _prodTmp = new MDataSet.ProductDataTable();
             
                
                this.ordersTableAdapter.OrdersAuto();


                this.productTableAdapter.FillOrders(_prodTmp);


                this.mDataSet.Product.Merge(_prodTmp);

                if (this.dateTimeEdit.Value.Date == DateTime.Today.Date)
                {
                    this.ordersTableAdapter.Fill(this.mDataSet.Orders);
                }
                else
                {
                    this.ordersTableAdapter.FillByStartPeriod(this.mDataSet.Orders, this.dateTimeEdit.Value.Date);
                }

                this.ordersBindingSource.ResetBindings(false);
             

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
                MainForm.Log("btRefreshData_Click" + err.Message);
            }
        }


        private bool SaveOrdersRow(MDataSet.OrdersRow row)
        {
            try
            {
              

                this.ordersTableAdapter.Update(row);
            }

            catch (Exception err)
            {
                MessageBox.Show("Не удалось сохранить данные!");
                MessageBox.Show(err.Message);
                return false;
            }
            finally
            { 
            
            
            }

            return true;
        }

    
        private void btProdAll_Click(object sender, EventArgs e)
        {

            MDataSet.ProductDataTable _prodTmp = new MDataSet.ProductDataTable();


            this.productTableAdapter.FillAll(_prodTmp);
            this.mDataSet.Product.Merge(_prodTmp);
            this.productBindingSource.ResetBindings(false);

        }

        private void btAdd_Click(object sender, EventArgs e)
        {

           
            MDataSet.ProductRow _prod = this.gridViewProd.GetDataRow(this.gridViewProd.FocusedRowHandle) as MDataSet.ProductRow;

            if (_prod != null)
            {
                try
                {

                    MDataSet.OrdersRow _ord = (this.ordersBindingSource.AddNew() as DataRowView).Row as MDataSet.OrdersRow;

                    DialogQuantityOrder _DialogQuantityOrder = new DialogQuantityOrder(_prod, _ord);

                    if (_DialogQuantityOrder.ShowDialog(this) == DialogResult.OK)
                    {
                        try
                        {

                            this.ordersBindingSource.EndEdit();

                            this.ordersBindingSource.ResetBindings(false);
                        
                            MainForm.Log(" this.ordersBindingSource.EndEdit успешно");
                        }
                        catch (Exception err)
                        {

                            MessageBox.Show(err.Message);

                            MainForm.Log(err.Message);
                        
                        }
                    }
                    else
                    {
                        this.ordersBindingSource.CancelEdit();
                    }
                }
                catch (Exception err)

                {
                    MessageBox.Show(err.Message);

                    MainForm.Log("btAdd_Click" + err.Message);
                }


            }
           

        
        }

        private void gridViewProd_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            MDataSet.ProductRow prodRow = this.gridViewProd.GetDataRow(e.RowHandle) as MDataSet.ProductRow;

            if (prodRow == null) return;


            if (prodRow.GetRemainsRows().Length == 0)
            {
                e.Appearance.Font = e.Cache.GetFont(e.Appearance.Font, FontStyle.Italic);
                e.Appearance.ForeColor = Color.Gray;
            }


        }

        private void gridViewOrders_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            try
            {
                MDataSet.OrdersRow _ordsRow = this.gridViewOrders.GetDataRow(e.RowHandle) as MDataSet.OrdersRow;

                if (_ordsRow == null) 
                {

                    return;    
                  
               };


                if ((_ordsRow.QuantityNow > 0) | (_ordsRow.Reserved > 0))
                {


                    e.Appearance.Font = e.Cache.GetFont(e.Appearance.Font, FontStyle.Italic);
                    e.Appearance.BackColor = Color.LightGreen;
                }
                else
                {

                    if (_ordsRow.isClose)
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
            }
            catch (Exception err )
           {
               MessageBox.Show(err.Message);

               MainForm.Log("gridViewOrders_CustomDrawCell" + err.Message);

            return;
           }

        }

        private void productBindingSource_PositionChanged(object sender, EventArgs e)
        {
            
        }

        private void ordersBindingSource_PositionChanged(object sender, EventArgs e)
        {
            
         try
            {

          if ( productBindingSource.Current ==null) return;

            MDataSet.ProductRow _product = (productBindingSource.Current as DataRowView).Row as MDataSet.ProductRow;


            if (ordersBindingSource.Current == null) return;

           
                MDataSet.OrdersRow _orders = (ordersBindingSource.Current as DataRowView).Row as MDataSet.OrdersRow;

                if (_orders.ProductRow == null) return;

                if ((_orders == null) | (_product == null)) return;

                if (_product.ID != _orders.ProductRef)
                {
                    this.productBindingSource.Position = this.productBindingSource.Find("Id", _orders.ProductRef);

                }
                MainForm.Log(" rdersBindingSource_PositionChanged успешно");
                      

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                MainForm.Log(err.Message);
            }

        }

        private void gridViewOrders_DoubleClick(object sender, EventArgs e)
        {

            try
            {
                MDataSet.OrdersRow _ordsRow = this.gridViewOrders.GetDataRow(this.gridViewOrders.FocusedRowHandle) as MDataSet.OrdersRow;



                if (_ordsRow == null) return;

                if (_ordsRow.Reserved > 0)
                {
                    MessageBox.Show("Этот товар уже для вас зарезервирован: " + _ordsRow.Reserved.ToString());

                    return;
                }

                if (_ordsRow.QuantityNow > 0)
                {
                    MessageBox.Show("Этот товар вам уже отгружен! ");

                    return;
                }


                if (_ordsRow.isClose)
                {
                    MessageBox.Show("Заявка была закрыта : " + _ordsRow.AuthorLastModif);

                    return;
                }


                DialogQuantityOrder _DialogQuantityOrder = new DialogQuantityOrder(_ordsRow.ProductRow, _ordsRow);

                if (_DialogQuantityOrder.ShowDialog(this) == DialogResult.OK)
                {

                    this.SaveOrdersRow(_ordsRow);

                }
                else
                    _ordsRow.RejectChanges();
            }
            catch (Exception err)

            {
            MessageBox.Show (err.Message);

                MainForm.Log ("gridViewOrders_DoubleClick" + err.Message);
            }
                
        }

        private void btDelete_Click(object sender, EventArgs e)
        {

            MDataSet.OrdersRow _ordsRow = this.gridViewOrders.GetDataRow(this.gridViewOrders.FocusedRowHandle) as MDataSet.OrdersRow;

            if (_ordsRow == null) return;


            if (_ordsRow.Reserved > 0)
            {
                MessageBox.Show("Этот товар уже для вас зарезервирован: " + _ordsRow.Reserved.ToString());

                return;
            }

            if (_ordsRow.QuantityNow >0)
            {
                MessageBox.Show("Этот товар вам уже отгружен");

                return;
            }


            if (_ordsRow.isClose)
            {
                MessageBox.Show("Заявка была закрыта : " + _ordsRow.AuthorLastModif);

                return;
            }

            if (MessageBox.Show("Удалить : " + _ordsRow.ProductRow.Name + " ?") == DialogResult.OK)
            {

                _ordsRow.Delete();

                this.SaveOrdersRow(_ordsRow);
            }

        }

        private void gridProduct_Click(object sender, EventArgs e)
        {

        }

       
   
        private void btClose_Click(object sender, EventArgs e)
        {
            foreach (GridView view in this.gridOrders.ViewCollection)
            {
                string fileName = new FileInfo(Application.ExecutablePath).DirectoryName + "\\" + view.Name.ToString() + ".xml";
                view.SaveLayoutToXml(fileName);
            }
            foreach (GridView view in this.gridProduct.ViewCollection)
            {
                string fileName = new FileInfo(Application.ExecutablePath).DirectoryName + "\\" + view.Name.ToString() + ".xml";
                view.SaveLayoutToXml(fileName);
            }
           

            (this.ParentForm as MainForm).DeleteDataTab(this.Parent as TabPage);
        
        }

        private void gridViewProd_DoubleClick(object sender, EventArgs e)
        {
            this.btAdd_Click(sender, e);
        }

        private void gridViewProd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData== Keys.Enter)
            {
                this.btAdd_Click(sender, e);
            } 
        }

        private void btOrdersNew_Click(object sender, EventArgs e)
        {
            try
            {
                FormPrintDialog formPrintDialog = new FormPrintDialog("OrdersNew");
                formPrintDialog.TradePutletRef = (this.ParentForm as MainForm).LocalSettingRow.MainTradePutletRef;

                formPrintDialog.ShowDialog(this);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

            }

        }

        private void btProdRep_Click(object sender, EventArgs e)
        {
            if (this.ordersBindingSource.Count == 0) return;
            int _ref = ((this.ordersBindingSource.Current as DataRowView).Row as MDataSet.OrdersRow).ProductRef;
            (this.ParentForm as MainForm).ProductReport(_ref);

        }

        private void btProduct_Click(object sender, EventArgs e)
        {
            if (this.productBindingSource.Count == 0) return;
            int _ref = ((this.productBindingSource.Current as DataRowView).Row as MDataSet.ProductRow).ID;
            (this.ParentForm as MainForm).ProductReport(_ref);

        }

        private void btOrdersOld_Click(object sender, EventArgs e)
        {
            try
            {
                FormPrintDialog formPrintDialog = new FormPrintDialog("OrdersOld");
                formPrintDialog.TradePutletRef = (this.ParentForm as MainForm).LocalSettingRow.MainTradePutletRef;

                formPrintDialog.ShowDialog(this);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

            }
        }

        private void repositoryItemLookUpEdit1_GetNotInListValue(object sender, DevExpress.XtraEditors.Controls.GetNotInListValueEventArgs e)
        {
            MainForm.Log("repositoryItemLookUpEdit1_GetNotInListValue");
            MessageBox.Show("repositoryItemLookUpEdit1_GetNotInListValue");
        }



       
    }
}
