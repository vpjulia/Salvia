using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace RetailTrade.Receipt
{
    public partial class ReceiptImport : UserControl
    { 
        
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;

        private OleDbCommand oleDbVFPSelectCommand;

        private DataSet _dataset;

        private DataTable _sh;

        private OleDbConnection _connection;

        public ReceiptImport()
        {   

            InitializeComponent();
          

            string vfpOleDbConString = "User ID=;DSN=;Cache Authentication=False;Data Source=\"{0}\";Password=;Provider=\"VFPOLEDB.1\";Collating Sequence=MACHINE;Mask Password=False;Mode=Share Deny None;Extended Properties=;Encrypt Password=False";
            
            string  _vfpOleDbConString= String.Format(vfpOleDbConString, Properties.Settings.Default.PathToFarmNew);
           
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
   
            this.oleDbVFPSelectCommand = new System.Data.OleDb.OleDbCommand();
            
            _connection = new OleDbConnection(_vfpOleDbConString);


            _dataset = new DataSet();

            _dataset.Locale = new System.Globalization.CultureInfo("ru-RU");


             _connection.Open();

           _sh = _connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });

           this.oleDbVFPSelectCommand.CommandText = "SELECT pharmtrade, CPCONVERT(866, 1251, firm) as firm, sumall, ndsall, numdoc, datedoc, sclcode, CPCONVERT(866, 1251, sclname) as sclname, kolvo, cenands, summands, edizm, sclmkcd, CPCONVERT(866, 1251,sclmknm ) as sclmknm, serie, tgodn, numsertf,";

           this.oleDbVFPSelectCommand.CommandText += "datsertf, numreg, datreg, enddatreg, adding, nds, cena, summa, cenascl, tamzav FROM ?";
           this.oleDbVFPSelectCommand.Connection = _connection;

           this.oleDbVFPSelectCommand.Parameters.Add("name", OleDbType.VarChar, 75).Value= "1";

           this.oleDbDataAdapter1.SelectCommand = oleDbVFPSelectCommand;

            
            
            foreach (DataRow dr in _sh.Rows)
           { 
           this.listBox1.Items.Add(dr["TABLE_NAME"].ToString());
          DataTable _cur = _dataset.Tables.Add(dr["TABLE_NAME"].ToString());

          this.oleDbVFPSelectCommand.Parameters["name"].Value = _cur.TableName.ToString();
          this.oleDbDataAdapter1.Fill(_cur);
           }

           
           this.listBox1.SelectedItem = this.listBox1.Items[0];

        }

     
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           this.bindingSource.DataSource =this._dataset.Tables[this.listBox1.SelectedItem.ToString()];
        

        }

        private void Import()
        {

            DataTable _curTable = (this.bindingSource.DataSource as DataTable);
            
                 string orgName = this.label1.Text.Trim();
                 //(this.bindingSource1.Current as DataRowView).Row["firm"].ToString().Trim();

                 int _idOrg;


               DataRow[] organization = (this.ParentForm as MainForm).mDataSet.Organization.Select("ShortName='" +@orgName+"'");

                 if (organization.Length == 0)
                 {
                     //MessageBox.Show("Не найден поставщик в справочнике организаций");

                     _idOrg = 0;

                 }
                 else
                 {
                     _idOrg = Convert.ToInt32(organization[0]["ID"]);

                 }
          

            /*создать приход*/

                 MDataSet.ReceiptMasterRow _mast;

                _mast = (this.receiptMasterBindingSource.AddNew() as DataRowView).Row as MDataSet.ReceiptMasterRow;
                _mast.DocDate =DateTime.Parse((_curTable).Rows[0]["datedoc"].ToString());
               
                _mast.OrganizationRef = _idOrg;
                
                _mast.Note = (_curTable).Rows[0]["numdoc"].ToString();

                if ((Convert.ToDecimal((_curTable).Rows[0]["nds"].ToString())) != 0)
                {
                    _mast.MainStockRef = 1;

                    FullDataSet.ProductDataTable _proTable = new FullDataSet.ProductDataTable();
 
                    this.productTableAdapter.Fill(_proTable, true);
                    this.fullDataSet.Product.Merge(_proTable);

                }

                
               this.receiptMasterBindingSource.EndEdit();

            /**/


            /**/
            
            foreach (DataRow _row in _curTable.Rows)
            { 
                
                /*Товар */
                string _idstr = _row["SCLCODE"].ToString().Trim().Replace(" ", "");
              
                
                int _id;


                if (_idstr.Length == 0)
                {
                    _id = 0;
                }
                else
                {
                    _id = Convert.ToInt32(_idstr);
                }

            //    string nameT = _row["sclname"].ToString().Trim();


                string nameT = _row["sclname"].ToString().Trim();


                FullDataSet.ProductRow _prRow;
                _prRow = null;


                _prRow  = this.fullDataSet.Product.FindByID(_id);


                if (_prRow ==null)
                {

                    DataRow[] arrPr = this.fullDataSet.Product.Select("OldName='" + nameT + "'");

                    if (arrPr.Length == 0)

                        _row.RowError = "Не найдена";
                    else
                    {
                        _prRow = arrPr[0] as FullDataSet.ProductRow;
                    }

                }
              
                


                /* изготовитель  */

                int manufRef = 0;

               

                DataRow[] _arr = this.fullDataSet.Manufacturer.Select("Name like '"+@_row["SCLMKNM"].ToString().Substring(0,4) +"%'");
                
                if (_arr.Length !=0)
                    

                    manufRef = (_arr[0] as FullDataSet.ManufacturerRow).ID;






                if (!(_row.HasErrors))
                {

                    MDataSet.ReceiptDetailRow _det;

                    /**добавлять в детаил потом аддинг */

                    _det = (this.receiptDetailBindingSource.AddNew() as DataRowView).Row as MDataSet.ReceiptDetailRow;

                    _det.ProductRef = _prRow.ID;

                    _det.Quantity = _prRow.OldKol * Convert.ToDecimal(_row["kolvo"].ToString());

                    _det.PricePurchase = Convert.ToDecimal(_row["cena"].ToString()) / _prRow.OldKol;

                    _det.ManufacturerRef = manufRef;


                    if (_row["serie"].ToString().Length>=15)

                    _det.Series = _row["serie"].ToString().Substring(0,15);
                    else
                    _det.Series = _row["serie"].ToString();


                    _det.UseByDate =DateTime.Parse( _row["tgodn"].ToString());
                    

                    this.receiptDetailBindingSource.EndEdit();


                    {
                        MDataSet.ReceiptDetailAddingRow _add;

                        _add = (this.receiptDetailAddingBindingSource.AddNew() as DataRowView).Row as MDataSet.ReceiptDetailAddingRow;
                       _add.NUMSERTF = _row["NUMSERTF"].ToString();

                       _add.NUMREG = _row["NUMREG"].ToString();

                       _add.DATREG =DateTime.Parse(_row["DATREG"].ToString());

                       _add.ENDDATREG = DateTime.Parse(_row["ENDDATREG"].ToString());
                       
                        _add.TAMZAV = Decimal.Parse(_row["TAMZAV"].ToString());
                      //  _add.MAXNACENKA = Decimal.Parse(_row["maxnacenka"].ToString());
                        
                        _add.DATSERTF = DateTime.Parse(_row["DATSERTF"].ToString());


                        this.receiptDetailAddingBindingSource.EndEdit();

                    
 
                   
                    }






                }

            }
            

        }
        private void ReceiptImport_Load(object sender, EventArgs e)
        {
            try
            {

                this.productTableAdapter.Fill(this.fullDataSet.Product,false);
              
             
              
                
                this.manufacturerTableAdapter.Fill(this.fullDataSet.Manufacturer);
            
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
             }
            this.productBindingSource.ResetBindings(true);

            this.productBindingSource1.DataSource = this.fullDataSet.Product;
            this.productBindingSource1.ResetBindings(true);



        }

        private void btFind_Click(object sender, EventArgs e)
        {
            this.Import();
        }

        private void gridViewFrmTrade_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
           
            
            
            /*
            
            if (e.Column == this.colkolvoEnter)
              
               
               
 
                
                
                try
                {
                    string soldkod = this.gridViewFrmTrade.GetRowCellDisplayText(e.RowHandle, this.colOldKol).ToString();

                    if ((soldkod == "0")|(soldkod==""))
                        return;

                    decimal oldkol = Decimal.Parse(soldkod);
                    decimal kolfrm =  Convert.ToDecimal(this.gridViewFrmTrade.GetRowCellValue(e.RowHandle, this.colkolvo));
                                                   
                    e.DisplayText =(oldkol*kolfrm).ToString();
                }
                catch(Exception err)

                {
            MessageBox.Show(err.Message);
            }

            */


        }

        private void btProdrep_Click(object sender, EventArgs e)
        {
            if (this.bindingSource.Count==0)
                return;

            try
            {
            int _ref =Convert.ToInt32(((this.bindingSource.Current as DataRowView).Row as FarmTrade._1Row).sclcode);
            


            (this.ParentForm as MainForm).ProductReport(_ref);

            }
                catch (Exception err)
            {
                MessageBox.Show (err.Message);
                }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            int res;

            try
            {
                this.receiptMasterTableAdapter.Update( this.mDataSet.ReceiptMaster );

                this.receiptDetailTableAdapter.Update(this.mDataSet.ReceiptDetail);

                this.receiptDetailAddingTableAdapter.Update(this.mDataSet.ReceiptDetailAdding);


            }
            catch (Exception err)

            {
                MessageBox.Show(err.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            
            (this.ParentForm as MainForm).DeleteDataTab(this.Parent as TabPage);

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.mDataSet.ReceiptDetailAdding.RejectChanges();

            this.mDataSet.ReceiptDetail.RejectChanges();

            this.mDataSet.ReceiptMaster.RejectChanges();


        }

        private void btDelFile_Click(object sender, EventArgs e)
        {
            string _fileName = Properties.Settings.Default.PathToFarmNew + this.listBox1.SelectedItem.ToString();

            try
            {
                using (StreamWriter sw = File.CreateText(_fileName)) { }

                if (File.Exists(_fileName))
                {
                    File.Delete(_fileName);

                    this.listBox1.Items.Remove(this.listBox1.SelectedItem);
                }
                else
                {
                    MessageBox.Show("Файл не найден");
                }

            }
            catch (Exception err)
            {
                Console.WriteLine("Ошибка файла: {0}", err.ToString());
            }



        }
    }
}
