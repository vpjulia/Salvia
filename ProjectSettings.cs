using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace RetailTrade
{
    public partial class ProjectSettings : UserControl
    {
        private string _connectionString;


        private string _farmPathNew;

        public string FarmPathNew
        {
            get {
                _farmPathNew = Properties.Settings.Default.PathToFarmNew;

                return _farmPathNew; 
            }
            set { _farmPathNew = value;
            Properties.Settings.Default.PathToFarmNew = _farmPathNew;
            }
        }

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
          
  
            this.textBoxConString.DataBindings.Add("Text", this, "MainConnectionString");
            this.tbpathToFarmNew.DataBindings.Add("Text", this, "FarmPathNew");


        }

        private void btSave_Click(object sender, EventArgs e)
        {
               //  string tmp;
               //  System.Configuration.AppSettingsReader app = new System.Configuration.AppSettingsReader();

               //  tmp = app.GetValue("RetailTradeConnectionString", System.Type.GetType("System.String")).ToString();
          //  Properties.Settings.Default.RetailTradeConnectionString

            Properties.Settings.Default.Save();


       
        }
    }
}
