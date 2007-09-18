
namespace RetailTrade
{
   using System.Data;
    using System.Windows.Forms;
    using System;
    using System.Data.SqlClient;
    using System.Reflection;
    using System.Security; 
    partial class MainForm
    {
        private void DoSplash()
        {
            SplashScreen sp = new SplashScreen();
            sp.label.Text = System.Environment.UserDomainName;
            sp.ShowDialog();
        }
        //  --------  event

        private void ReceiptDetailColumn_Changing(object sender, DataColumnChangeEventArgs e)
        {
            if (e.Column == mDataSet.ReceiptDetail.QuantityColumn)

                foreach (MDataSet.RemainsRow remainsRow in (e.Row as MDataSet.ReceiptDetailRow).GetRemainsRows())

                    if (((e.Row as MDataSet.ReceiptDetailRow).Quantity - remainsRow.QuantityRemains) > ((decimal)e.ProposedValue))
                    {
                        MessageBox.Show("Товара уже продано больше!");

                        e.ProposedValue = (e.Row as MDataSet.ReceiptDetailRow).Quantity;
                    }
                    else
                        remainsRow.QuantityRemains += (decimal)e.ProposedValue - (e.Row as MDataSet.ReceiptDetailRow).Quantity;

        }

         private void InvoiceMasterColumn_Changing(object sender, DataColumnChangeEventArgs e)
        {
            //
        }

        private void InvoiceMasterColumn_Changed(object sender, DataColumnChangeEventArgs e)
        {
            if (e.Column == mDataSet.InvoiceMaster.RemoteStockRefColumn)
            {
                bool _isnds = this.mDataSet.Stock.FindByID(Convert.ToInt32(e.ProposedValue)).IsNDS;

                if ( _isnds!=(e.Row as MDataSet.InvoiceMasterRow).IsNDSMain)
                {
                    DataRow[] ardr = (this.mDataSet.Stock.Select(" IsLocal=1 and IsNds=" + _isnds.ToString()));
                    int id = (ardr[0] as MDataSet.StockRow).ID;
                    (e.Row as MDataSet.InvoiceMasterRow).MainStockRef = id;
                 
                }
            }
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
            {

             this.RefreshData((e.Row as MDataSet.InvoiceDetailRow).RemainsRow);
             
              if ((decimal)e.ProposedValue != (e.Row as MDataSet.InvoiceDetailRow).Quantity)
                {

                    decimal _newQuantityRemains = (e.Row as MDataSet.InvoiceDetailRow).RemainsRow.QuantityRemains + (e.Row as MDataSet.InvoiceDetailRow).Quantity;

                    if ((decimal)e.ProposedValue <= 0)
                        throw new ArgumentException("Количество не может быть нулевым!");
                    else
                        if ((decimal)e.ProposedValue > _newQuantityRemains)

                            throw new ArgumentException("Остаток на складе меньше!");
                        else
                            (e.Row as MDataSet.InvoiceDetailRow).RemainsRow.QuantityRemains -= (decimal)e.ProposedValue - (e.Row as MDataSet.InvoiceDetailRow).Quantity;
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
                (e.Row as MDataSet.InvoiceDetailRow).Quantity = (e.Row as MDataSet.InvoiceDetailRow).RemainsRow.QuantityRemains;

            }

        }

        private void InvoiceDetail_RowDeleting(object sender, DataRowChangeEventArgs e)
        {
          //  MessageBox.Show("onInvoiceDetail_RowDeleting");
        }

        private void InvoiceDetail_RowDeleted(object sender, DataRowChangeEventArgs e)
        {
            if (e.Row.HasVersion(DataRowVersion.Original))
            /*сохранить*/
            {
                SaveToBase(e.Row as MDataSet.InvoiceDetailRow);

            }
           
        }

        private void InvoiceDetail_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            if ((e.Action==DataRowAction.Change) | (e.Action==DataRowAction.Add))
           SaveToBase(e.Row as MDataSet.InvoiceDetailRow);
  
          
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
            Object[] _argsFill = new Object[2];
            _argsFill[0] = dataRows[0].Table.Clone();
            if (dataRows[0]["DateUpdate"] != DBNull.Value)
                _argsFill[1] = dataRows[0]["DateUpdate"];
            else
                _argsFill[1] = DateTime.Now;
            tp.GetMethod("FillNew").Invoke(this.components.Components[dataRows[0].Table.TableName + "TableAdapter"], _argsFill);

            try
            {

                tp.GetMethod("Update", types).Invoke(this.components.Components[dataRows[0].Table.TableName + "TableAdapter"], _args);
            }
            catch (SqlException SqlErr)
            {
                foreach (DataRow dataRow in dataRows)
                    if (dataRow.HasErrors)
                        MessageBox.Show(SqlErr.Message);
            }
            catch (Exception err)
            {

                FormDialog formDialog = new FormDialog();
                formDialog.btCancel.Enabled = false;
                Information ctlInform = new Information();
                formDialog.panel.Controls.Add(ctlInform);

                foreach (DataRow dataRow in dataRows)

                    if (dataRow.HasErrors)
                    {
                        if ((_argsFill[0] as DataTable).Rows.Find(dataRow["Id"]) != null)
                        {
                            ctlInform.labelHeader.Text = "Запись была изменена пользователем: ";
                            ctlInform.labelAsk.Text = (_argsFill[0] as DataTable).Rows.Find(dataRow["Id"])["AuthorLastModif"].ToString();
                        }
                        else
                        {
                            ctlInform.labelHeader.Text = "Ошибка совмесного доступа";
                            ctlInform.labelAsk.Text = "Запись не найдена! Обновление не возможно ";
                        }

                        if (DialogResult.OK == formDialog.ShowDialog(this.ParentForm))

                            dataRow.RejectChanges();
                    }
            }
            finally
            {
                dataRows[0].Table.Merge(_argsFill[0] as DataTable, true);
                tp.GetMethod("FillNew").Invoke(this.components.Components[dataRows[0].Table.TableName + "TableAdapter"], _argsFill);
                dataRows[0].Table.Merge(_argsFill[0] as DataTable, false);

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
            catch
            {
                return false;
            }
            finally
            {
                /*
                     Object[] _argsFill = new Object[2];
                     _argsFill[0] = dataRows[0].Table.Clone();
                     _argsFill[1] = DateTime.Now;
                     tp.GetMethod("FillNew").Invoke(this.components.Components[dataRows[0].Table.TableName + "TableAdapter"], _argsFill);
                     dataRows[0].Table.Merge(_argsFill[0] as DataTable, false);
                 */
            }
            return true;
        }


        public bool SaveToBase(MDataSet.ReceiptMasterRow sourceRow)
        {
            try
            {
                int res = this.receiptMasterTableAdapter.Update(sourceRow);
                this.actionStatusLabel.Text = "Сохранена накладная";
            }
          finally
            {
                MDataSet.ReceiptMasterDataTable tmpReceiptMaster = new MDataSet.ReceiptMasterDataTable();
                this.receiptMasterTableAdapter.Fill(tmpReceiptMaster);
                sourceRow.Table.Merge(tmpReceiptMaster);
            }

            return true;
        }
        public bool SaveToBase(MDataSet.InvoiceMasterRow sourceRow)
        {
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
               return false;
         
         
              }
          catch (Exception err)
         
            {
              MessageBox.Show(err.Message);
              return false;
            }
            finally
            {
             RefreshData(sourceRow.Table);
            }
            return true;
        }
        public bool SaveToBase(MDataSet.InvoiceDetailRow sourceRow)
        {

            if (sourceRow.HasErrors) 
                return false;
            if ((sourceRow.RowState == DataRowState.Detached)|(sourceRow.RowState==DataRowState.Unchanged))
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

          try
          {

              int res = this.invoiceDetailTableAdapter.Update(sourceRow);
              this.actionStatusLabel.Text = "Успешно обновлена строка";

          }

          catch (DBConcurrencyException dbcx)
          {
              this.onInvoiceDetailDBCError(dbcx);
              this.actionStatusLabel.Text = "Ошибка совмесного доступа";
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
               return false;

          }
          catch (Exception err)
          {
              MessageBox.Show(err.Message);
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
                    FillTable(relation.ParentTable.ToString());
                tp.GetMethod("Fill").Invoke(this.components.Components[NameTable + "TableAdapter"], args);
            }
        }
        public bool RefreshData(MDataSet.InvoiceMasterRow sourceRow) 
        {
           MDataSet.InvoiceMasterDataTable _invoiceMasterDataTable=new MDataSet.InvoiceMasterDataTable();
           MDataSet.InvoiceDetailDataTable _invoiceDetailDataTable = new MDataSet.InvoiceDetailDataTable();
         
            try
             {
               this.invoiceMasterTableAdapter.FillNew(_invoiceMasterDataTable,sourceRow.DateUpdate);
               this.invoiceDetailTableAdapter.FillByInvoiceMasterRef(_invoiceDetailDataTable,sourceRow.ID);

              
             }
             catch (Exception err)
             {
                 MessageBox.Show(err.Message);
                 return false;
             }
             finally
             { 
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


           /*foreach (DataRelation relation in sourceTable.ParentRelations)
                RefreshData(relation.ParentTable);
            */

            Object[] parameters = new Object[0];
            Object _newTable;
            
            Object[] args = new Object[2];
          
            args[1] = source.Rows[0]["DateUpdate"];

            try
            {
                // создать пустую таблицу 
               Type _typeTable = source.GetType();
               ConstructorInfo constructorInfoObj = _typeTable.GetConstructor(Type.EmptyTypes);
              _newTable=constructorInfoObj.Invoke(parameters);
               args[0] = _newTable;
            }
        
            catch (SecurityException e)
            {
                Console.WriteLine("SecurityException: " + e.Message);
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                return false;
            }

            // Merge
            try
            { 
                Type tp = this.components.Components[source.TableName + "TableAdapter"].GetType();
                tp.GetMethod("FillNew").Invoke(this.components.Components[source.TableName + "TableAdapter"], args);
                source.Merge(_newTable as DataTable,true);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return false;
            
            }
          
                return true;
        }
        public bool RefreshData(MDataSet.InvoiceDetailRow sourceRow)
        {
            MDataSet.InvoiceDetailDataTable  _invoiceDetailDataTable = new MDataSet.InvoiceDetailDataTable();

            try
            {
                this.invoiceDetailTableAdapter.FillNew(_invoiceDetailDataTable, sourceRow.DateUpdate);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return false;
            }
            finally
            {
                this.mDataSet.InvoiceDetail.Merge(_invoiceDetailDataTable, true);
            }
            return true;
             
        }
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
                return false;
            }
            finally
            {
                this.mDataSet.Remains.Merge(_RemainsDataTable);
            }
            return true;

        }

        //----------  Error   

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

            this.invoiceDetailTableAdapter.FillById(_invoiceDetailDataTable, (dbcx.Row as MDataSet.InvoiceDetailRow).ID);

            MDataSet.InvoiceDetailRow rowInDB = (_invoiceDetailDataTable.Rows[0] as MDataSet.InvoiceDetailRow);

            /*Сравнить изменения*/

            if (( Convert.ToDecimal(_invoiceDetailRow["Quantity", DataRowVersion.Original] )!= rowInDB.Quantity) |
                (Convert.ToDecimal(_invoiceDetailRow["PriceRetailNDS", DataRowVersion.Original]) != rowInDB.PriceRetailNDS))
            {
                /*** Отменить **/
                string strInDB = "Запись была изменена пользователем: \n";

                string strMessage;

                strInDB += rowInDB.AuthorLastModif.ToString() + "\n";

                strMessage = strInDB + "\n";
                MessageBox.Show(strMessage + "Изменения отменены ", "Ошибка совмесного доступа",
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
            throw new Exception("The method or operation is not implemented.");
        }
        private void onInvoiceMasterDBCError(DBConcurrencyException dbcx)
        {
            if (this.RefreshData(dbcx.Row as MDataSet.InvoiceMasterRow))
                MessageBox.Show("Запись была изменена пользователем :" + (dbcx.Row as MDataSet.InvoiceMasterRow).AuthorLastModif,"Ошибка совмесного доступа",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);

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
