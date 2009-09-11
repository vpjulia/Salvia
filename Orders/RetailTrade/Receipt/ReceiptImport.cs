using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace RetailTradeOrders.Receipt
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
            
            string  _vfpOleDbConString= String.Format(vfpOleDbConString,"D:\\Work\\FarmTrade" );
           
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
        

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           this.bindingSource1.DataSource =this._dataset.Tables[this.listBox1.SelectedItem.ToString()];
           grid.DataSource = this.bindingSource1;

        }

       

        
    }
}
