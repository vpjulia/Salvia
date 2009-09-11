using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace RetailTradeClient
{
    public partial class ProjectSettings : UserControl
    {
        private string _connectionString;

        public string MainConnectionString
        {

            get {

                _connectionString = Properties.Settings.Default.SERVER;


                return _connectionString; 
            }
            set 
            {
                
                _connectionString =value;
                Properties.Settings.Default.SERVER = _connectionString;

            }
        }
     

        public ProjectSettings()
        {
            InitializeComponent();
          


        }

        private void button1_Click(object sender, EventArgs e)
        {
               //  string tmp;
               //  System.Configuration.AppSettingsReader app = new System.Configuration.AppSettingsReader();

               //  tmp = app.GetValue("RetailTradeConnectionString", System.Type.GetType("System.String")).ToString();
          //  Properties.Settings.Default.RetailTradeConnectionString

                


         this.textBoxConString.DataBindings.Add("Text", this, "MainConnectionString");

        }
    }
}
