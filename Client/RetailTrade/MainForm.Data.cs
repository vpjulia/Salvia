
namespace RetailTradeClient
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
                        MessageBox.Show("Товара уже продано больше!");

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
                (e.Row as RetailTradeClient.MDataSet.ReceiptDetailRow).ReceiptMasterRow.SetModified();
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
             //проверить кол-во и цену, 
          if (e.Column == mDataSet.InvoiceDetail.QuantityColumn)
              if
                  ((decimal)e.ProposedValue!= (e.Row as MDataSet.InvoiceDetailRow).Quantity)
            {

             this.RefreshData((e.Row as MDataSet.InvoiceDetailRow).RemainsRow);
             
              if ((decimal)e.ProposedValue != (e.Row as MDataSet.InvoiceDetailRow).Quantity)
                {

                    decimal _newQuantityRemains = (e.Row as MDataSet.InvoiceDetailRow).RemainsRow.QuantityRemains ;

                    if ((decimal)e.ProposedValue <= 0)
                        throw new ArgumentException("Количество не может быть нулевым!");
                    else
                        if ((decimal)e.ProposedValue > _newQuantityRemains)

                            throw new ArgumentException("Остаток на складе меньше!");
                        else
                            (e.Row as MDataSet.InvoiceDetailRow).RemainsRow.QuantityRemains -= (decimal)e.ProposedValue;// -(e.Row as MDataSet.InvoiceDetailRow).Quantity;
                }
            }
           
        }

        private void InvoiceDetailColumn_Changed(object sender, DataColumnChangeEventArgs e)
        { 
            /*при добавлении проставить кол-во == остатку на сервере*/

           if ((e.Column == mDataSet.InvoiceDetail.LocalReceiptDetailRefColumn)
               &(!e.Row.HasVersion(DataRowVersion.Original)))
            {
                this.RefreshData((e.Row as MDataSet.InvoiceDetailRow).RemainsRow);
              //  (e.Row as MDataSet.InvoiceDetailRow).Quantity = (e.Row as MDataSet.InvoiceDetailRow).RemainsRow.QuantityRemains;

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

            //**Новые данные**//     


           
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
                    MessageBox.Show("Не отработана ошибка"+sqlerr.Message);
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
              /* RefreshData(sourceRow.Table as MDataSet.InvoiceMasterDataTable);*/
            }


            try
            {
               
                int res1 = this.invoiceDetailTableAdapter.Update(this.mDataSet.InvoiceDetail);
            }
            catch (DBConcurrencyException dbcx)
            {
                this.onInvoiceDetailDBCError(dbcx);

                this.SaveToBase(sourceRow);

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

                Log("SaveToBase(MDataSet.InvoiceDetail sourceRow) ERROR" + sqlerr.Message + " " + sqlerr.Source + sqlerr.InnerException.Message);


                return false;


            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                Log("SaveToBase(MDataSet.InvoiceMasterRow sourceRow) ERROR" + err.Message + " " + err.Source);

                return false;
            }
            finally
            {
                /* RefreshData(sourceRow.Table as MDataSet.InvoiceMasterDataTable);*/
            }



            return true;
        }


        public bool SaveToBase(MDataSet.InvoiceDetailRow sourceRow)
        {
 try
          {
            if (sourceRow.HasErrors) 
                return false;
            if ((sourceRow.RowState == DataRowState.Detached)|(sourceRow.RowState==DataRowState.Unchanged))
                return true;
            if (_changesInvoiceDetail.Count == 0)
                return true;

            MDataSet.InvoiceMasterRow _invoiceMasterRow;
            _invoiceMasterRow = sourceRow.InvoiceMasterRow;
            /*если  после Update полей на сервере*/
           
            if ((sourceRow.RowState == DataRowState.Modified)&sourceRow.HasVersion(DataRowVersion.Current))
            {
               if (Convert.ToInt32(sourceRow["ID", DataRowVersion.Original]) != Convert.ToInt32(sourceRow["ID", DataRowVersion.Current]))
                    return true;
            }
            //*Если удаление *//
            if (sourceRow.RowState==DataRowState.Deleted)
              _invoiceMasterRow = this.mDataSet.InvoiceMaster.FindByID(Convert.ToInt32((sourceRow as MDataSet.InvoiceDetailRow)["InvoiceMasterRef", DataRowVersion.Original]));



         
              RefreshData(_invoiceMasterRow);
              int res = this.invoiceDetailTableAdapter.Update(sourceRow);
              this.LabelUser.Text = "Успешно обновлена строка";

          }

          catch (DBConcurrencyException dbcx)
          {
              this.onInvoiceDetailDBCError(dbcx);
              this.LabelUser.Text = "Ошибка совмесного доступа";
              MainForm.Log(dbcx.Message);
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

            MainForm.Log(sqlerr.Message);
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

              
             //   this.RemainsTableAdapter.Fill(this.mDataSet.Remains);
              
                 
            }

            return true;

        }

     
        // ---------  Refresh 
        

        public void FillTable(string NameTable)
        { 
            try
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
              
                {

                    tp.GetMethod("Fill").Invoke(this.components.Components[NameTable + "TableAdapter"], args);
                } 
            }}
                catch (Exception err)
                {
                    Log("FillTable(string)"+ NameTable+" ) ERROR" + err.Message + " " + err.Source + err.InnerException.Message);  
            
                }
            }           
   
        /*FullDataset*/
       

        /*MDataset, новые приходные документы */
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
                MergeRemains(_tmpRemains);
                this.mDataSet.InvoiceMaster.Merge(_tmpMaster);
                this.mDataSet.InvoiceDetail.Merge(_tmpDetail);

            }
            return true;
       

        
        }


        /*MDataset, документы на складе, из открытого периода, новые, X дней*/
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
        /*MDataset, документы на складе 
         по номеру периода, подгрузка построчно нужна*/
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

                    MergeRemains(_rem);
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

              
               this.invoiceDetailTableAdapter.Update(this.mDataSet.InvoiceDetail);
             
               this.RemainsTableAdapter.FillByInvoiceMasterID(_remainsDataTable, sourceRow.ID);

               this.invoiceMasterTableAdapter.FillNew(_invoiceMasterDataTable);
      
               this.invoiceDetailTableAdapter.FillNew(_invoiceDetailDataTable);

          
  
             }

             catch (DBConcurrencyException dbcx)
             {
                 this.onInvoiceDetailDBCError(dbcx);
                 this.LabelUser.Text = "Ошибка совмесного доступа";
                 MainForm.Log(dbcx.Message);
                 RefreshData(sourceRow);

                 return false;

             }

             catch (Exception err)
             {
                 MessageBox.Show(err.Message);
                 Log("RefreshData(MDataSet.InvoiceMasterRow sourceRow) " + err.Message + " " + err.Source);  
  
                 return false;
             }
             finally
             {
                  MergeRemains(_remainsDataTable);
               
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
          
            //обновить справочники
            //нужен у все метод FillNew с  параметром дата 


             foreach (DataRelation relation in source.ParentRelations)
             {if (relation.ChildKeyConstraint!=null)

                 RefreshData(relation.ParentTable);
             }

            Object[] parameters = new Object[0];
            Object _newTable;
            
            Object[] args = new Object[1];


           

                try
                {
                    // создать пустую таблицу 
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


        //При удалении вызвать

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
                MergeRemains(_RemainsDataTable);
            }

            return true;
        }

        private void MergeRemains(MDataSet.RemainsDataTable _remainsDataTable)
        {
            foreach (RetailTradeClient.MDataSet.RemainsRow row in _remainsDataTable.Rows)
            {
                RetailTradeClient.MDataSet.RemainsRow parent = this.mDataSet.Remains.FindByReceiptDetailRef(row.ReceiptDetailRef);
                if (parent == null  )
                { 
                    this.mDataSet.Remains.ImportRow(row);
                    continue;
                }

                if (parent.QuantityRemains != row.QuantityRemains)
                {
                    parent.QuantityRemains = row.QuantityRemains;
                }               
            }

            this.mDataSet.Remains.AcceptChanges();
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
           // если нулевой остаток
            if (row.RemainsRow.QuantityRemains == 0)
            {
                MessageBox.Show("Уже нет товара на складе!");
                row.RejectChanges();
                return true;
            }
            else
            { // уменьшить до кол-ва остатка и снова сохранить
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
                    MessageBox.Show("Не удалось выписать: "+ed.ToString());
                }
                return true;
            }
        }
        private void onInvoiceDetailDBCError(DBConcurrencyException dbcx)
        {
            MDataSet.InvoiceDetailRow _invoiceDetailRow = dbcx.Row as MDataSet.InvoiceDetailRow;

            MDataSet.InvoiceDetailDataTable _invoiceDetailDataTable = new MDataSet.InvoiceDetailDataTable();
            if (_invoiceDetailRow.RowState == DataRowState.Deleted)
            {
                int _id = Convert.ToInt32(_invoiceDetailRow["ID", DataRowVersion.Original].ToString());

                this.invoiceDetailTableAdapter.FillById(_invoiceDetailDataTable, _id);

            }


            else
            {
               this.invoiceDetailTableAdapter.FillById(_invoiceDetailDataTable, (dbcx.Row as MDataSet.InvoiceDetailRow).ID);
           
             }
           
                     
            {   _invoiceDetailRow.ClearErrors();
                this.mDataSet.InvoiceDetail.Merge(_invoiceDetailDataTable, true);
          
            }

            MainForm.Log(" onInvoiceDetailDBCError " + "успешно");
        }
    
        private void OnInvoiceMasterSQLError(SqlException sqlerr, MDataSet.InvoiceMasterRow sourceRow)
        {
            MessageBox.Show(sqlerr.Message);

        }
        private bool onInvoiceMasterDBCError(DBConcurrencyException dbcx)
        {
            try
            {
                MDataSet.InvoiceMasterDataTable _tmpTable = new MDataSet.InvoiceMasterDataTable();

               
                    this.invoiceMasterTableAdapter.FillByPeriodNum(_tmpTable, 0);
                
                    this.mDataSet.InvoiceMaster.Merge(_tmpTable, true);

                    this.invoiceMasterTableAdapter.Update(this.mDataSet.InvoiceMaster);
            }
            catch (Exception err)
            {
                MainForm.Log("onInvoiceMasterDBCError"+ err.Message);
                return false;
            }

            return true;

        }
        private void caughtGlobalError(SqlException sqlerr)
        {

            MessageBox.Show("ОШИБКА соединения с базой!", "Розничная торговля", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
