
namespace RetailTradeOrders
{
   using System.Data;
    using System.Windows.Forms;
    using System;
    using System.Data.SqlClient;
    using System.Reflection;
    using System.Security; 
    partial class MainForm
    {
        private DataView _changesInvoiceDetail;
        public static void DoSplash()
        {
            SplashScreen sp = new SplashScreen();
            sp.label.Text = System.Environment.UserDomainName +"\\"+ System.Environment.UserName ;
            sp.ShowDialog();
        }

        //  --------  event

        private void ReceiptDetail_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            (e.Row as MDataSet.ReceiptDetailRow).DateLastModif = DateTime.Now;

        }
      
        private void ReceiptDetailColumn_Changing(object sender, DataColumnChangeEventArgs e)
        {
            if (e.Column == mDataSet.ReceiptDetail.PricePurchaseColumn)
            {
            //  MessageBox.Show(e.ProposedValue.ToString());
            }
           
            if (e.Column == mDataSet.ReceiptDetail.QuantityColumn)
            {
                MDataSet.RemainsRow remainsRow = (e.Row as MDataSet.ReceiptDetailRow).RemainsRow;

                    if (((e.Row as MDataSet.ReceiptDetailRow).Quantity - remainsRow.QuantityRemains) > ((decimal)e.ProposedValue))
                    {
                        MessageBox.Show("������ ��� ������� ������!");

                        e.ProposedValue = (e.Row as MDataSet.ReceiptDetailRow).Quantity;
                    }
                    else
                        remainsRow.QuantityRemains += (decimal)e.ProposedValue - (e.Row as MDataSet.ReceiptDetailRow).Quantity;
            }
        }

        private void ReceiptDetail_RowChanged(object sender, DataRowChangeEventArgs e)
        {
           
        }

        private void ReceiptDetail_RowDeleted(object sender, DataRowChangeEventArgs e) 
        {
         //  if (e.Row.HasVersion(DataRowVersion.Original))
          // {

        //       MessageBox.Show((e.Row as RetailTrade.MDataSet.ReceiptDetailRow).ReceiptMasterRef.ToString());
                 //.ReceiptMasterRow.RecalcSum = true;
          // }
        }

        private void ReceiptDetail_RowDeleting(object sender, DataRowChangeEventArgs e)
        {
            if (e.Row.HasVersion(DataRowVersion.Original))
                (e.Row as RetailTradeOrders.MDataSet.ReceiptDetailRow).ReceiptMasterRow.SetModified();
        }

        // InvoiceMaster

        private void InvoiceMasterColumn_Changing(object sender, DataColumnChangeEventArgs e)
        {
            //
        }

        private void InvoiceMasterColumn_Changed(object sender, DataColumnChangeEventArgs e)
        {
            
          //
        }


        //  -------- InvoiceDetail

        private void InvoiceDetail_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
      //
        }

        private void InvoiceDetailColumn_Changing(object sender, DataColumnChangeEventArgs e)
        {
             //��������� ���-�� � ����, 
          if (e.Column == mDataSet.InvoiceDetail.QuantityColumn)
            {

             this.RefreshData((e.Row as MDataSet.InvoiceDetailRow).RemainsRow);
             
              if ((decimal)e.ProposedValue != (e.Row as MDataSet.InvoiceDetailRow).Quantity)
                {

                    decimal _newQuantityRemains = (e.Row as MDataSet.InvoiceDetailRow).RemainsRow.QuantityRemains + (e.Row as MDataSet.InvoiceDetailRow).Quantity;

                    if ((decimal)e.ProposedValue <= 0)
                        throw new ArgumentException("���������� �� ����� ���� �������!");
                    else
                        if ((decimal)e.ProposedValue > _newQuantityRemains)

                            throw new ArgumentException("������� �� ������ ������!");
                        else
                            (e.Row as MDataSet.InvoiceDetailRow).RemainsRow.QuantityRemains -= (decimal)e.ProposedValue;// -(e.Row as MDataSet.InvoiceDetailRow).Quantity;
                }
            }
           
        }

        private void InvoiceDetailColumn_Changed(object sender, DataColumnChangeEventArgs e)
        { 
            /*��� ���������� ���������� ���-�� == ������� �� �������*/

           if ((e.Column == mDataSet.InvoiceDetail.LocalReceiptDetailRefColumn)
               &(!e.Row.HasVersion(DataRowVersion.Original)))
            {
                this.RefreshData((e.Row as MDataSet.InvoiceDetailRow).RemainsRow);
                (e.Row as MDataSet.InvoiceDetailRow).Quantity = (e.Row as MDataSet.InvoiceDetailRow).RemainsRow.QuantityRemains;

            }

        }

        private void InvoiceDetail_RowDeleting(object sender, DataRowChangeEventArgs e)
        {
      
        }

        private void InvoiceDetail_RowDeleted(object sender, DataRowChangeEventArgs e)
        {
           
        }

        private void InvoiceDetail_RowChanged(object sender, DataRowChangeEventArgs e)
        {
  //          if ((e.Action==DataRowAction.Change) | (e.Action==DataRowAction.Add))
   //        SaveToBase(e.Row as MDataSet.InvoiceDetailRow);
  
          
        }

        //---------SAVE 
      
        public bool SaveToBaseDirectoryModifed(DataRow[] dataRows)
        {
           

            if (dataRows.Length == 0) return false;
            Type tp = this.components.Components[dataRows[0].Table.TableName + "TableAdapter"].GetType();
            Object[] _args = new Object[1];
            _args[0] = dataRows;
            Type[] types = new Type[1];
            types[0] = dataRows.GetType();

            //**����� ������**//     


           
            try
            {

                tp.GetMethod("Update", types).Invoke(this.components.Components[dataRows[0].Table.TableName + "TableAdapter"], _args);
            }
            catch (DBConcurrencyException dbcx)
            {
                this.onDirectoryDBCError(dbcx);
                Log("SaveToBaseDirectoryModifed" + dbcx.Message);
                return false;
            }

            catch (SqlException sqlerr)
            {
                if (sqlerr.Class < 17)
                {
                    MessageBox.Show("�� ���������� ������"+sqlerr.Message);
                    Log("SaveToBaseDirectoryModifed SQLERROR" + sqlerr.Message);
                }
                else

                    caughtGlobalError(sqlerr);
                return false;


            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                Log("SaveToBaseDirectoryModifed ERROR" + err.Message + " " + err.Source + err.InnerException.Message);                
                return false;
            }

           
            finally
            {
                Log("SaveToBaseDirectoryModifed successful;");                
           
            }
            return true;
        }

       
        public bool SaveToBaseDirectoryDeleted(DataRow[] dataRows)
        {
            if (dataRows.Length == 0) return false;
            Type tp = this.components.Components[dataRows[0].Table.TableName + "TableAdapter"].GetType();
            Object[] args = new Object[1];
            args[0] = dataRows;
            Type[] types = new Type[1];
            types[0] = dataRows.GetType();
            try
            {
                tp.GetMethod("Update", types).Invoke(this.components.Components[dataRows[0].Table.TableName + "TableAdapter"], args);
            }
            catch (Exception err)
            {
                Log("SaveToBaseDirectoryDeleted ERROR" + err.Message + " " + err.Source + err.InnerException.Message);  
                return false;
            }
            finally
            {

                Log("SaveToBaseDirectoryDeleted successfull");  
                
               
            }
            return true;
        }


        public bool CloseCheck(MDataSet.InvoiceMasterRow sourceRow)
        { 
         try
            {
                int res = this.invoiceMasterTableAdapter.InvoiceMasterMove(sourceRow.ID,sourceRow.NumCheck,sourceRow.Discount);
            }
              catch (DBConcurrencyException dbcx)
             {
              this.onInvoiceMasterDBCError(dbcx);
              return false;
              }

              catch (SqlException sqlerr)
              {
                 if (sqlerr.Class < 17)
                   {
                      OnInvoiceMasterSQLError(sqlerr,sourceRow);
                   }
                   else
                
                     caughtGlobalError(sqlerr);

                 Log("SaveToBase(MDataSet.InvoiceMasterRow sourceRow) ERROR" + sqlerr.Message + " " + sqlerr.Source + sqlerr.InnerException.Message);  
            

               return false;
         
         
              }
          catch (Exception err)
         
            {
              MessageBox.Show(err.Message);
              Log("SaveToBase(MDataSet.InvoiceMasterRow sourceRow) ERROR" + err.Message + " " + err.Source + err.InnerException.Message);  
            
              return false;
            }
            finally
            {
             RefreshData(sourceRow as MDataSet.InvoiceMasterRow);
            }
            return true;
      

        
        }

        public bool MakeToReturn(MDataSet.InvoiceMasterRow sourceRow)
        {
            int res;
            try
            {
                this.SaveToBase(sourceRow);

                res = this.invoiceMasterTableAdapter.InvoiceMasterMakeToReturn(sourceRow.ID);


            }
            catch (DBConcurrencyException dbcx)
            {
                this.onInvoiceMasterDBCError(dbcx);
                return false;
            }

            catch (SqlException sqlerr)
            {
                if (sqlerr.Class < 17)
                {
                    OnInvoiceMasterSQLError(sqlerr, sourceRow);
                }
                else

                    caughtGlobalError(sqlerr);

                Log("SaveToBase(MDataSet.InvoiceMasterRow sourceRow) ERROR" + sqlerr.Message + " " + sqlerr.Source + sqlerr.InnerException.Message);


                return false;


            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                Log("SaveToBase(MDataSet.InvoiceMasterRow sourceRow) ERROR" + err.Message + " " + err.Source + err.InnerException.Message);

                return false;
            }
            finally
            {
                RefreshData(sourceRow as MDataSet.InvoiceMasterRow);
            }
            return true;

        }
     

        public bool SaveToBase(MDataSet.InvoiceMasterRow sourceRow)
        {

            MDataSet.RemainsDataTable _rem = new MDataSet.RemainsDataTable();

            try
            {
                int res = this.invoiceMasterTableAdapter.Update(sourceRow);
             
                
                int res1 = this.invoiceDetailTableAdapter.Update(this.mDataSet.InvoiceDetail);

                if (sourceRow.HasVersion(DataRowVersion.Current))
                {

                    this.RemainsTableAdapter.FillByInvoiceMasterID(_rem, sourceRow.ID);

                    this.mDataSet.Remains.Merge(_rem);
                }
               }
              catch (DBConcurrencyException dbcx)
             {
              this.onInvoiceMasterDBCError(dbcx);
              return false;
              }

              catch (SqlException sqlerr)
              {
                 if (sqlerr.Class < 17)
                   {
                      OnInvoiceMasterSQLError(sqlerr,sourceRow);
                   }
                   else
                
                     caughtGlobalError(sqlerr);

                 Log("SaveToBase(MDataSet.InvoiceMasterRow sourceRow) ERROR" + sqlerr.Message + " " + sqlerr.Source + sqlerr.InnerException.Message);  
            

               return false;
         
         
              }
          catch (Exception err)
         
            {
              MessageBox.Show(err.Message);
              Log("SaveToBase(MDataSet.InvoiceMasterRow sourceRow) ERROR" + err.Message + " " + err.Source );  
            
              return false;
            }
            finally
            {
             RefreshData(sourceRow.Table as MDataSet.InvoiceMasterDataTable);
            }
            return true;
        }


        public bool SaveToBase(MDataSet.InvoiceDetailRow sourceRow)
        {

            if (sourceRow.HasErrors) 
                return false;
            if ((sourceRow.RowState == DataRowState.Detached)|(sourceRow.RowState==DataRowState.Unchanged))
                return true;
            if (_changesInvoiceDetail.Count == 0)
                return true;

            MDataSet.InvoiceMasterRow _invoiceMasterRow;
            _invoiceMasterRow = sourceRow.InvoiceMasterRow;
            /*����  ����� Update ����� �� �������*/
           
            if ((sourceRow.RowState == DataRowState.Modified)&sourceRow.HasVersion(DataRowVersion.Current))
            {
               if (Convert.ToInt32(sourceRow["ID", DataRowVersion.Original]) != Convert.ToInt32(sourceRow["ID", DataRowVersion.Current]))
                    return true;
            }
            //*���� �������� *//
            if (sourceRow.RowState==DataRowState.Deleted)
              _invoiceMasterRow = this.mDataSet.InvoiceMaster.FindByID(Convert.ToInt32((sourceRow as MDataSet.InvoiceDetailRow)["InvoiceMasterRef", DataRowVersion.Original]));

          try
          {

              int res = this.invoiceDetailTableAdapter.Update(sourceRow);
              this.LabelUser.Text = "������� ��������� ������";

          }

          catch (DBConcurrencyException dbcx)
          {
              this.onInvoiceDetailDBCError(dbcx);
              this.LabelUser.Text = "������ ���������� �������";
              return false;
          }

          catch (SqlException sqlerr)
          {

             if (sqlerr.Class < 17)
             {
                 OnInvoiceDetailSQLError(sqlerr,sourceRow);
             }
             else
                caughtGlobalError(sqlerr);

            Log("SaveToBase(MDataSet.InvoiceDetailRow sourceRow) ERROR" + sqlerr.Message + " " + sqlerr.Source + sqlerr.InnerException.Message);  
            
               return false;

          }
          catch (Exception err)
          {
              MessageBox.Show(err.Message);

              Log("SaveToBase(MDataSet.InvoiceDetailRow sourceRow) ERROR" + err.Message + " " + err.Source + err.InnerException.Message);  
            

              return false;
          }
            finally
            {
                this.RemainsTableAdapter.Fill(this.mDataSet.Remains);
                RefreshData(_invoiceMasterRow);
            }

            return true;

        }

     
        // ---------  Refresh 
        

        public void FillTable(string NameTable)
        {
            if (this.mDataSet.Tables[NameTable].Rows.Count == 0)
            {
                Type tp = this.components.Components[NameTable + "TableAdapter"].GetType();
                Object[] args = new Object[1];
                args[0] = this.mDataSet.Tables[NameTable];
                foreach (DataRelation relation in this.mDataSet.Tables[NameTable].ParentRelations)
                {
                  if (relation.ChildKeyConstraint != null)
                    FillTable(relation.ParentTable.ToString());
                }
                try
                {

                    tp.GetMethod("Fill").Invoke(this.components.Components[NameTable + "TableAdapter"], args);
                }
                catch (Exception err)
                {
                    Log("FillTable(string)"+ NameTable+" ) ERROR" + err.Message + " " + err.Source + err.InnerException.Message);  
            
                }

            }
           
        }


        /*FullDataset*/
       

        /*MDataset, ����� ��������� ��������� */
        public bool FillTableNewDocuments(MDataSet.ReceiptMasterDataTable source)
        {
          /*MDataSet.ReceiptMasterDataTable _tmpMaster = new MDataSet.ReceiptMasterDataTable();
            MDataSet.ReceiptDetailDataTable _tmpDetail = new MDataSet.ReceiptDetailDataTable();
*/

            try
            {
                this.receiptMasterTableAdapter.Fill(this.mDataSet.ReceiptMaster);
                this.receiptDetailTableAdapter.Fill(this.mDataSet.ReceiptDetail);

            }

            catch (SqlException sqlerr)
            {
                if (sqlerr.Class < 17)
                {
                    MessageBox.Show(sqlerr.Message);
                }
                else

                    caughtGlobalError(sqlerr);





                Log("FillTableNewDocuments(MDataSet.ReceiptMasterDataTable source) ERROR" + sqlerr.Message + " " + sqlerr.Source);

                return false;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);



                Log("FillTableNewDocuments(MDataSet.ReceiptMasterDataTable source) ERROR" + err.Message);


            }
            finally
            {
              /*this.mDataSet.ReceiptMaster.Merge(_tmpMaster);
                this.mDataSet.ReceiptDetail.Merge(_tmpDetail);
*/
            }

            return true;
           /* DataColumn[] _ercol = _tmpDetail.GetErrors()[0].GetColumnsInError();

            if (_ercol.Length >= 0)
                return false;
            else 
                return true;*/


        }
        public bool FillTableNewDocuments(MDataSet.InvoiceMasterDataTable source)
        {
            MDataSet.InvoiceMasterDataTable _tmpMaster = new MDataSet.InvoiceMasterDataTable();
            MDataSet.InvoiceDetailDataTable _tmpDetail = new MDataSet.InvoiceDetailDataTable();
            MDataSet.RemainsDataTable _tmpRemains = new MDataSet.RemainsDataTable();

            try
            {
                this.RemainsTableAdapter.Fill(_tmpRemains);
         
                this.invoiceMasterTableAdapter.Fill(_tmpMaster);
                this.invoiceDetailTableAdapter.Fill(_tmpDetail);

            }

            catch (SqlException sqlerr)
            {
                if (sqlerr.Class < 17)
                {
                    MessageBox.Show(sqlerr.Message);
                }
                else

                    caughtGlobalError(sqlerr);

                Log("FillTableNewDocuments(MDataSet.ReceiptMasterDataTable source) ERROR" + sqlerr.Message + " " + sqlerr.Source + sqlerr.InnerException.Message);  
  

                return false;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

                Log("FillTableNewDocuments(MDataSet.ReceiptMasterDataTable source) ERROR" + err.Message + " " + err.Source );  
  

                return false;
            }
            finally
            {
                this.mDataSet.Remains.Merge(_tmpRemains);
                this.mDataSet.InvoiceMaster.Merge(_tmpMaster);
                this.mDataSet.InvoiceDetail.Merge(_tmpDetail);

            }
            return true;
       

        
        }


        /*MDataset, ��������� �� ������, �� ��������� �������, �����, X ����*/
        public bool FillTableStockDocuments(MDataSet.ReceiptMasterDataTable source,DateTime begin)
        {
            MDataSet.ReceiptMasterDataTable _tmpMaster = new MDataSet.ReceiptMasterDataTable();
            MDataSet.ReceiptDetailDataTable _tmpDetail = new MDataSet.ReceiptDetailDataTable();

            


            try
            {
                this.receiptMasterTableAdapter.FillByPeriod(_tmpMaster,begin);
                this.receiptDetailTableAdapter.FillByPeriod(_tmpDetail,begin);

            }

            catch (SqlException sqlerr)
            {
                if (sqlerr.Class < 17)
                {
                    MessageBox.Show(sqlerr.Message);
                }
                else

                    caughtGlobalError(sqlerr);


                Log("FillTableStockDocuments(MDataSet.ReceiptMasterDataTable source) ERROR" + sqlerr.Message + " " + sqlerr.Source + sqlerr.InnerException.Message);  
  
                return false;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

                Log("FillTableStockDocuments(MDataSet.ReceiptMasterDataTable source) ERROR" + err.Message + " " + err.Source +err.InnerException.Message);  
  

                return false;
            }
            finally
            {
                this.mDataSet.ReceiptMaster.Merge(_tmpMaster);
                this.mDataSet.ReceiptDetail.Merge(_tmpDetail);

            }
            return true;



        }
        /*MDataset, ��������� �� ������ 
         �� ������ �������, ��������� ��������� �����*/
        public bool FillTableStockDocuments(MDataSet.ReceiptMasterDataTable source, int numPeriods)
        {
         
            MDataSet.ReceiptMasterDataTable _tmpMaster = new MDataSet.ReceiptMasterDataTable();
        //    MDataSet.ReceiptDetailDataTable _tmpDetail = new MDataSet.ReceiptDetailDataTable();
            try
               {
                  this.receiptMasterTableAdapter.FillByPeriodNum(_tmpMaster, numPeriods);
                //  this.receiptDetailTableAdapter.FillByPeriodNum(_tmpDetail, numPeriods);
              

            }
                    catch (SqlException sqlerr)
                    {
                        if (sqlerr.Class < 17)
                        {
                            MessageBox.Show(sqlerr.Message);
                        }
                        else

                            caughtGlobalError(sqlerr);

                        Log("FillTableStockDocuments(MDataSet.ReceiptMasterDataTable source) ERROR" + sqlerr.Message + " " + sqlerr.Source + sqlerr.InnerException.Message);  
  
                        return false;
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                        Log("FillTableStockDocuments(MDataSet.ReceiptMasterDataTable source) ERROR" + err.Message + " " + err.Source +err.InnerException.Message);  
  
                        return false;
                    }
                    finally
                    {
                        this.mDataSet.ReceiptMaster.Merge(_tmpMaster);
                      //  this.mDataSet.ReceiptDetail.Merge(_tmpDetail);

                    }
                    return true;
                }

        public bool FillTableStockDocuments(MDataSet.InvoiceMasterDataTable source, DateTime begin)
        {
            MDataSet.InvoiceMasterDataTable _tmpMaster = new MDataSet.InvoiceMasterDataTable();
            MDataSet.InvoiceDetailDataTable _tmpDetail = new MDataSet.InvoiceDetailDataTable();




            try
            {
                this.invoiceMasterTableAdapter.FillByPeriod(_tmpMaster, begin);
                this.invoiceDetailTableAdapter.FillByPeriod(_tmpDetail, begin);

            }

            catch (SqlException sqlerr)
            {
                if (sqlerr.Class < 17)
                {
                    MessageBox.Show(sqlerr.Message);
                }
                else

                    caughtGlobalError(sqlerr);

                Log("FillTableStockDocuments(MDataSet.InvoiceMasterDataTable source) ERROR" + sqlerr.Message + " " + sqlerr.Source + sqlerr.InnerException.Message);  
  
                return false;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                Log("FillTableStockDocuments(MDataSet.InvoiceMasterDataTable source) ERROR" + err.Message + " " + err.Source + err.InnerException.Message);  
  
                return false;
            }
            finally
            {
                this.mDataSet.InvoiceMaster.Merge(_tmpMaster);
                this.mDataSet.InvoiceDetail.Merge(_tmpDetail);

            }
            return true;



        }
       
        public bool FillTableStockDocuments(MDataSet.InvoiceMasterDataTable source, int numPeriods)
        {

            MDataSet.InvoiceMasterDataTable _tmpMaster = new MDataSet.InvoiceMasterDataTable();
            MDataSet.InvoiceDetailDataTable _tmpDetail = new MDataSet.InvoiceDetailDataTable();
            MDataSet.RemainsDataTable _rem = new MDataSet.RemainsDataTable();
            MDataSet.ProductDataTable _prod = new MDataSet.ProductDataTable();
         
            
            try
            {
                this.invoiceMasterTableAdapter.FillByPeriodNum(_tmpMaster, numPeriods);
                
                this.mDataSet.InvoiceMaster.Merge(_tmpMaster);

                foreach (MDataSet.InvoiceMasterRow mr in  _tmpMaster)
                {
                    this.invoiceDetailTableAdapter.FillByInvoiceMasterRef(_tmpDetail, mr.ID);
                   

                    this.RemainsTableAdapter.FillByInvoiceMasterID(_rem, mr.ID);
                   
                    foreach (MDataSet.RemainsRow _remrow in _rem)
                    {
                        if (_remrow.ProductRow == null)
                        {
                            this.productTableAdapter.FillById(_prod, _remrow.ProductRef);
                            this.mDataSet.Product.Merge(_prod);
                        }

                       
                    } 
                    this.mDataSet.Remains.Merge(_rem);
                    this.mDataSet.InvoiceDetail.Merge(_tmpDetail);
                }
             
            }
            catch (SqlException sqlerr)
            {
                if (sqlerr.Class < 17)
                {
                    MessageBox.Show(sqlerr.Message);
                }
                else

                    caughtGlobalError(sqlerr);

                Log("FillTableStockDocuments(MDataSet.InvoiceMasterDataTable source) ERROR" + sqlerr.Message + " " + sqlerr.Source + sqlerr.InnerException.Message);  
  
                return false;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                Log("FillTableStockDocuments(MDataSet.InvoiceMasterDataTable source) ERROR" + err.Message + " " + err.Source );  
  
                return false;
            }
            finally
            {
            }
            return true;



        }
  
        
        /*FillNew + Merge + FillDetailsById*/
        public bool RefreshData(MDataSet.ReceiptMasterRow sourceRow) 
        {
            MDataSet.ReceiptMasterDataTable _ReceiptMasterDataTable = new MDataSet.ReceiptMasterDataTable();
            MDataSet.ReceiptDetailDataTable _ReceiptDetailDataTable = new MDataSet.ReceiptDetailDataTable();
          MDataSet.ProductDataTable _productDataTable = new MDataSet.ProductDataTable();
           

            
            try
            {  this.receiptMasterTableAdapter.FillNew(_ReceiptMasterDataTable);

                this.receiptDetailTableAdapter.FillByReceiptMasterRef(_ReceiptDetailDataTable, sourceRow.ID);
                foreach (MDataSet.ReceiptDetailRow detrow in _ReceiptDetailDataTable)
                {
                    if (detrow.ProductRow == null)
                    {


                        this.productTableAdapter.FillById(_productDataTable,detrow.ProductRef);
              
                    
                    
                    }

                    this.mDataSet.Product.Merge(_productDataTable);
                
                }



            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                Log("RefreshData(MDataSet.ReceiptMasterRow sourceRow)  ERROR" + err.Message + " " + err.Source + err.InnerException.Message);  
  
                return false;
            }
            finally
            {
                this.mDataSet.ReceiptMaster.Merge(_ReceiptMasterDataTable);
                this.mDataSet.ReceiptDetail.Merge(_ReceiptDetailDataTable);
                this.mDataSet.ReceiptMaster.AcceptChanges();
                this.mDataSet.ReceiptDetail.AcceptChanges();
            }
            return true;
        }
        
        public bool RefreshData(MDataSet.InvoiceMasterRow sourceRow) 
        {
            if (sourceRow == null) return false;

           MDataSet.InvoiceMasterDataTable _invoiceMasterDataTable=new MDataSet.InvoiceMasterDataTable();
           MDataSet.InvoiceDetailDataTable _invoiceDetailDataTable = new MDataSet.InvoiceDetailDataTable();
           MDataSet.RemainsDataTable _remainsDataTable = new MDataSet.RemainsDataTable();

            try
             {


               this.RemainsTableAdapter.FillByInvoiceMasterID(_remainsDataTable, sourceRow.ID);
               this.invoiceMasterTableAdapter.FillNew(_invoiceMasterDataTable);
               this.invoiceDetailTableAdapter.FillByInvoiceMasterRef(_invoiceDetailDataTable,sourceRow.ID);

              
             }
             catch (Exception err)
             {
                 MessageBox.Show(err.Message);
                 Log("RefreshData(MDataSet.InvoiceMasterRow sourceRow) " + err.Message + " " + err.Source);  
  
                 return false;
             }
             finally
             {
                  this.mDataSet.Remains.Merge(_remainsDataTable);
                  this.mDataSet.InvoiceMaster.Merge(_invoiceMasterDataTable);
                  this.mDataSet.InvoiceDetail.Merge(_invoiceDetailDataTable); 
            

            }
            return true;

        }

        public bool RefreshData(DataTable source) 
        {
            if (source.Rows.Count == 0)
            {
                FillTable(source.TableName);
                return true;
             }
          
            //�������� �����������
            //����� � ��� ����� FillNew �  ���������� ���� 


             foreach (DataRelation relation in source.ParentRelations)
             {if (relation.ChildKeyConstraint!=null)

                 RefreshData(relation.ParentTable);
             }

            Object[] parameters = new Object[0];
            Object _newTable;
            
            Object[] args = new Object[1];


           

                try
                {
                    // ������� ������ ������� 
                    Type _typeTable = source.GetType();
                    ConstructorInfo constructorInfoObj = _typeTable.GetConstructor(Type.EmptyTypes);
                    _newTable = constructorInfoObj.Invoke(parameters);
                    args[0] = _newTable;
                }

                catch (SecurityException err)
                {
                    Log("RefreshData : " + source.TableName + err.Message + " " + err.Source + err.InnerException.Message);  
  
                    return false;
                }
                catch (Exception err)
                {
                    
                    Log("RefreshData : " + source.TableName + err.Message + " " + err.Source + err.InnerException.Message);  
  
                    return false;
                }

                // Merge
                try
                {
                    Type tp = this.components.Components[source.TableName + "TableAdapter"].GetType();
                    tp.GetMethod("FillNew").Invoke(this.components.Components[source.TableName + "TableAdapter"], args);
                    source.Merge(_newTable as DataTable, false);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                    Log("RefreshData : " + source.TableName + err.Message + " " + err.Source + err.InnerException.Message);  
  
                    return false;

                }
            

                return true;
        }

        public bool RefreshData(MDataSet.InvoiceDetailRow sourceRow)
        {
            MDataSet.InvoiceDetailDataTable  _invoiceDetailDataTable = new MDataSet.InvoiceDetailDataTable();

            try
            {
                this.invoiceDetailTableAdapter.FillNew(_invoiceDetailDataTable);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                Log("RefreshData (MDataSet.InvoiceDetailRow sourceRow) "  + err.Message + " " + err.Source + err.InnerException.Message);  
  
                return false;
            }
            finally
            {
                this.mDataSet.InvoiceDetail.Merge(_invoiceDetailDataTable, true);
            }
            return true;
             
        }


        //��� �������� �������

        public bool RefreshData(MDataSet.RemainsRow sourceRow)
        {
            MDataSet.RemainsDataTable _RemainsDataTable = new MDataSet.RemainsDataTable();

            try
            {
                this.RemainsTableAdapter.FillByReceiptDetailRef(_RemainsDataTable, sourceRow.ReceiptDetailRef);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

                Log("(MDataSet.RemainsRow sourceRow) " + err.Message + " " + err.Source + err.InnerException.Message);  
  
                return false;
            }
            finally
            {
                this.mDataSet.Remains.Merge(_RemainsDataTable);
            }
            return true;

        }

        public bool RefreshData(MDataSet.RemainsDataTable table)
        {
          
            try
            {
                this.RemainsTableAdapter.Fill(table);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

                Log("RefreshData(MDataSet.RemainsDataTable table) " + err.Message + " " + err.Source + err.InnerException.Message);

                return false;
            }
            finally
            {
              
            }
            return true;

        }

        public bool RefreshData(MDataSet.ProductDataTable dataTable, int id)
        {
            MDataSet.ProductDataTable _ProductDataTable = new MDataSet.ProductDataTable();

            try
            {
                this.productTableAdapter.FillById(_ProductDataTable,id);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

                Log("(RefreshData(MDataSet.ProductDataTable dataTable, int id)" + err.Message + " " + err.Source + err.InnerException.Message);

                return false;
            }
            finally
            {
                this.mDataSet.Product.Merge(_ProductDataTable);
            }
            return true;

        
        
        }

        //----------  Error   

        private void onDirectoryDBCError(DBConcurrencyException dbcx)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        private void OnReceiptDetailSQLError(SqlException sqlerr, MDataSet.ReceiptMasterRow sourceRow)
        {
            MessageBox.Show(sqlerr.Message);
        
        }

        private void onReceiptDetailDBCError(DBConcurrencyException dbcx)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        private void onReceiptMasterDBCError(DBConcurrencyException dbcx)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        private void OnReceiptMasterSQLError(SqlException sqlerr, MDataSet.ReceiptMasterRow sourceRow)
        {
            MessageBox.Show(sqlerr.Message, "SqlException");
        }

        private bool OnInvoiceDetailSQLError(SqlException sqlerr,MDataSet.InvoiceDetailRow row)
        {
            decimal _oldQnt = row.Quantity;

            RefreshData(row.RemainsRow);
           // ���� ������� �������
            if (row.RemainsRow.QuantityRemains == 0)
            {
                MessageBox.Show("��� ��� ������ �� ������!");
                row.RejectChanges();
                return true;
            }
            else
            { // ��������� �� ���-�� ������� � ����� ���������
                try
                {
                 row.ClearErrors();
                 row.Quantity = row.RemainsRow.QuantityRemains;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    row.RejectChanges();
                    return false;
                }
                finally
                {
                    decimal ed = _oldQnt - row.Quantity;
                    MessageBox.Show("�� ������� ��������: "+ed.ToString());
                }
                return true;
            }
        }
        private void onInvoiceDetailDBCError(DBConcurrencyException dbcx)
        {
            MDataSet.InvoiceDetailRow _invoiceDetailRow = dbcx.Row as MDataSet.InvoiceDetailRow;


            MDataSet.InvoiceDetailDataTable _invoiceDetailDataTable = new MDataSet.InvoiceDetailDataTable();

            this.invoiceDetailTableAdapter.FillById(_invoiceDetailDataTable, (dbcx.Row as MDataSet.InvoiceDetailRow).ID);

            MDataSet.InvoiceDetailRow rowInDB = (_invoiceDetailDataTable.Rows[0] as MDataSet.InvoiceDetailRow);

            /*�������� ���������*/

            if (( Convert.ToDecimal(_invoiceDetailRow["Quantity", DataRowVersion.Original] )!= rowInDB.Quantity) |
                (Convert.ToDecimal(_invoiceDetailRow["PriceRetailNDS", DataRowVersion.Original]) != rowInDB.PriceRetailNDS))
            {
                /*** �������� **/
                string strInDB = "������ ���� �������� �������������: \n";

                string strMessage;

                strInDB += rowInDB.AuthorLastModif.ToString() + "\n";

                strMessage = strInDB + "\n";
                MessageBox.Show(strMessage + "��������� �������� ", "������ ���������� �������",
                MessageBoxButtons.OK,MessageBoxIcon.Warning);
                this.mDataSet.InvoiceDetail.Merge(_invoiceDetailDataTable);
            }
            else
            {   _invoiceDetailRow.ClearErrors();
                this.mDataSet.InvoiceDetail.Merge(_invoiceDetailDataTable, true);
          
            }
        }
    
        private void OnInvoiceMasterSQLError(SqlException sqlerr, MDataSet.InvoiceMasterRow sourceRow)
        {
            MessageBox.Show(sqlerr.Message);

        }
        private void onInvoiceMasterDBCError(DBConcurrencyException dbcx)
        {
            if (this.RefreshData(dbcx.Row as MDataSet.InvoiceMasterRow))
                MessageBox.Show("������ ���� �������� ������������� :" + (dbcx.Row as MDataSet.InvoiceMasterRow).AuthorLastModif,"������ ���������� �������",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);

        }
        private void caughtGlobalError(SqlException sqlerr)
        {

            MessageBox.Show("������ ���������� � �����!", "��������� ��������", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
  
        private void processResponse(System.Windows.Forms.DialogResult response, DataTable newTable)
        {
            switch (response)
            {
                case System.Windows.Forms.DialogResult.Yes:
                    // Overwrite the database with the proposed record.
                    this.mDataSet.InvoiceMaster.Merge(newTable, true);
                    this.invoiceMasterTableAdapter.Update(this.mDataSet.InvoiceMaster);
                    this.mDataSet.InvoiceMaster.AcceptChanges();
                    break;
                case System.Windows.Forms.DialogResult.No:
                    // Cancel proposed changes and refresh dsAuthors1.
                    this.mDataSet.InvoiceMaster.Merge(newTable);
                    break;
            }
        }

    } 
}
