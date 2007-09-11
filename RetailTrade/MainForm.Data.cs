
namespace RetailTrade
{
   using System.Data;
    using System.Windows.Forms;
    using System;
    using System.Data.SqlClient; 
    partial class MainForm
    {
        private void DoSplash()
        {

            SplashScreen sp = new SplashScreen();
            sp.label.Text = System.Environment.UserDomainName;
            sp.ShowDialog();

        }

        private void onReceiptDetailColumn_Changing(object sender, DataColumnChangeEventArgs e)
        {
            if (e.Column == mDataSet.ReceiptDetail.QuantityColumn)

                foreach (MDataSet.vwRemainsRow remainsRow in (e.Row as MDataSet.ReceiptDetailRow).GetvwRemainsRows())

                    if (((e.Row as MDataSet.ReceiptDetailRow).Quantity - remainsRow.QuantityRemains) > ((decimal)e.ProposedValue))
                    {
                        MessageBox.Show("Товара уже продано больше!");

                        e.ProposedValue = (e.Row as MDataSet.ReceiptDetailRow).Quantity;
                    }
                    else
                        remainsRow.QuantityRemains += (decimal)e.ProposedValue - (e.Row as MDataSet.ReceiptDetailRow).Quantity;

        }

     

        private void onInvoiceMasterColumn_Changed(object sender, DataColumnChangeEventArgs e)
        {
            if (e.Column == mDataSet.InvoiceMaster.RemoteStockRefColumn)
                if ((int)e.ProposedValue != (e.Row as MDataSet.InvoiceMasterRow).RemoteStockRef)
                {
                    DataRow[] ardr = (this.mDataSet.Stock.Select(" IsLocal=1 and IsNds=" + (e.Row as MDataSet.InvoiceMasterRow).StockRowByFK_Stock_InvoiceMaster.IsNDS.ToString()));
                    int id = (ardr[0] as MDataSet.StockRow).ID;
                    (e.Row as MDataSet.InvoiceMasterRow).MainStockRef = id;
                    MessageBox.Show((e.Row as MDataSet.InvoiceMasterRow).MainStockRef.ToString());
                }

        }

        private void onInvoiceDetailColumn_Changing(object sender, DataColumnChangeEventArgs e)
        {
           
            //проверить кол-во и цену, 
                    if (e.Column == mDataSet.InvoiceDetail.QuantityColumn)
                if ((decimal)e.ProposedValue != (e.Row as MDataSet.InvoiceDetailRow).Quantity)
                {

                    decimal _newQuantityRemains = (e.Row as MDataSet.InvoiceDetailRow).vwRemainsRow.QuantityRemains + (e.Row as MDataSet.InvoiceDetailRow).Quantity;

                    if ((decimal)e.ProposedValue <= 0)
                        throw new ArgumentException("Количество не может быть нулевым!");
                    else
                        if ((decimal)e.ProposedValue > _newQuantityRemains)

                            throw new ArgumentException("Остаток на складе меньше!");
                        else
                            (e.Row as MDataSet.InvoiceDetailRow).vwRemainsRow.QuantityRemains -= (decimal)e.ProposedValue - (e.Row as MDataSet.InvoiceDetailRow).Quantity;
                }

            
        }

        private void onInvoiceDetailColumn_Changed(object sender, DataColumnChangeEventArgs e)
        { 
          /**/
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
            else
                MessageBox.Show((e.Row as MDataSet.InvoiceDetailRow)["LocalReceiptDetailRef", DataRowVersion.Current].ToString());

        }

        private void InvoiceDetail_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            if ((e.Action==DataRowAction.Change) | (e.Action==DataRowAction.Add))
           SaveToBase(e.Row as MDataSet.InvoiceDetailRow);
  
          
        }

        /******************Модификация справочников ******************/
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
            /*  else

              Type tp = this.components.Components[NameTable + "TableAdapter"].GetType();
              Object[] args = new Object[1];
              args[0] = this.mDataSet.Tables[NameTable];
              foreach (DataRelation relation in this.mDataSet.Tables[NameTable].ParentRelations)
                  FillTable(relation.ParentTable.ToString());
              tp.GetMethod("FillNew").Invoke(this.components.Components[NameTable + "TableAdapter"], args);
        */
        }

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
                MessageBox.Show("Результат апдейта:" + res.ToString());
            }
            catch
            {
                MessageBox.Show("Ошибка ReceipMaster!");
            }

            DataRow[] datarowDeleted = this.mDataSet.ReceiptDetail.Select("ReceiptMasterRef=" + sourceRow.ID.ToString(), null, DataViewRowState.Deleted);

            try
            {

                int res = this.receiptDetailTableAdapter.Update(datarowDeleted);
                MessageBox.Show("Результат апдейта:" + res.ToString());

            }
            catch
            {
                MessageBox.Show("Ошибка удаления!");

            }

            MDataSet.ReceiptDetailRow[] dr = sourceRow.GetReceiptDetailRows();


            foreach (MDataSet.ReceiptDetailRow detailRow in dr)
            {
                try
                {
                    this.OrdersTableAdapter.Update(detailRow.GetOrdersRows());
                }
                catch
                {
                    MessageBox.Show("Ошибка обновления заявок!");
                }
            }

            try
            {
                int res = this.receiptDetailTableAdapter.Update(dr);
                MessageBox.Show("Результат апдейта:" + res.ToString());
            }
            catch
            {
                MessageBox.Show(this.mDataSet.ReceiptDetail.HasErrors.ToString());

                MessageBox.Show("Ошибка обновления ReceiptDetail!");
                return false;

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
              //  this.createMessage(dbcx);
                return false;
            }

            catch
            {
                MessageBox.Show("Ошибка InvoiceMaster!");
            }

           
            finally
            {
                RefreshData(sourceRow);
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
           
            /*   Пиздец какой-то ???????????????????*/

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
                sourceRow.AcceptChanges();
            }

            catch (DBConcurrencyException dbcx)
            {
                this.createMessageInvoiceDetail(dbcx);
                return false;
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return false;
            }
            finally
            {
                this.vwRemainsTableAdapter.Fill(this.mDataSet.vwRemains);
                RefreshData(_invoiceMasterRow);
            }

            return true;

        }
        public bool RefreshData(MDataSet.InvoiceMasterRow sourceRow) 
        {
           MDataSet.InvoiceMasterDataTable _invoiceMasterDataTable=new MDataSet.InvoiceMasterDataTable();
       
          try
             {
               this.invoiceMasterTableAdapter.FillNew(_invoiceMasterDataTable,sourceRow.DateUpdate);
             }
             catch (Exception err)
             {
                 MessageBox.Show(err.Message);
                 return false;
             }
             finally
             { 
                  this.mDataSet.InvoiceMaster.Merge(_invoiceMasterDataTable,true);
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


        private void createMessageInvoiceDetail(DBConcurrencyException dbcx)
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
                string strInDB = "Запись была изменена: \n";

                string strMessage;

                strInDB += rowInDB.AuthorLastModif.ToString() + "\n";

                strMessage = strInDB + "\n";

                System.Windows.Forms.DialogResult response;

                response = MessageBox.Show(strMessage + "Изменения отменены ", "Ошибка совмесного доступа",
                MessageBoxButtons.OK);
                this.mDataSet.InvoiceDetail.Merge(_invoiceDetailDataTable);
                //   processResponse(response, _invoiceDetailDataTable);
            }

            else
            {   _invoiceDetailRow.ClearErrors();
                this.mDataSet.InvoiceDetail.Merge(_invoiceDetailDataTable, true);
               
            }
        }


        private void processResponse(System.Windows.Forms.DialogResult response, DataTable newTable)
        {
            // Execute the appropriate code depending on the button selected 
            // in the message box.
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
