using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace RetailTradeClient
{
    public partial class FormPrintDialog : Form
    {

        private string _reportName;

        private DateTime _StartDate;
 
        private DateTime _EndDate;

        private int _productRef;


        private int _tradePutletRef;

        public int TradePutletRef
        {
            get { return _tradePutletRef; }
            set { _tradePutletRef = value; }
        } 


        public int ProductRef
        {
            get { return _productRef; }
            set { _productRef = value; }
        }

        
        public DateTime StartDate
        {
            get { return _StartDate; }
            set { _StartDate = value; }
        }
       

        public DateTime EndDate
        {
            get { return _EndDate; }
            set { _EndDate = value; }
        }





        public FormPrintDialog()
        {
            InitializeComponent();
        }
 
        public FormPrintDialog(string ReportName)
        {
            InitializeComponent();
            _reportName = ReportName;

             this.startDateEdit.DataBindings.Add (new Binding("Value",this,"StartDate"));
             this.endDateEdit.DataBindings.Add (new Binding("Value",this,"EndDate"));

             _StartDate = DateTime.Today.AddDays(0 - DateTime.Today.Day+1);
             _EndDate = DateTime.Today;

             this.reportViewer.LocalReport.DataSources.Clear();         
        }
        private void FormPrintDialog_Load(object sender, EventArgs e)
        {
            switch (_reportName)
            {

                case "RetailTrade.Resources.ProductReport.rdlc":
                    this.InitProductReport();
                    break;
                    
                case "RetailTrade.Resources.ProductFullInfo.rdlc":
                    this.InitProductFullReport();
                    break;

                case "RetailTradeCLReriodical":
                    this.InitReportSum();
                    break;
               
                default:
                    {
                        return;
                    }
            }


            // this.reportViewer.ShowParameterPrompts = true;
           
            this.reportViewer.RefreshReport();
        }

        private void InitReportSum()
        {
            this.parametrsPanel.Visible = false;

            this.reportViewer.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.reportViewer.ServerReport.ReportPath = "/ReportRetailTrade/"+this._reportName;
            this.reportViewer.ServerReport.ReportServerUrl = new System.Uri("http://server/reportserver", System.UriKind.Absolute);
            this.reportViewer.ShowCredentialPrompts = false;

            ReportParameter p_tradePutletRef = new ReportParameter("TradePutletRef",this._tradePutletRef.ToString());

            reportViewer.ServerReport.SetParameters(new ReportParameter[] { p_tradePutletRef });
             

        }

        private bool InitProductReport()
        {
            try
            {
               
                this.reportViewer.LocalReport.ReportEmbeddedResource = _reportName;

                this.ProductRemainsByDateTableAdapter.Fill(this.RetailTradeClDataSet.ProductRemainsByDate, _StartDate,_EndDate,_productRef);
                
                this.ProductSelectByIdTableAdapter.Fill(this.RetailTradeClDataSet.ProductSelectById, _productRef);

                this.reportViewer.LocalReport.DataSources.Add(new ReportDataSource("RetailTradeClDataSet_ProductRemainsByDate", this.ProductRemainsByDateBindingSource));
     
               
                ReportParameter p_ProductRef = new ReportParameter("productRef", _productRef.ToString());

                ReportParameter p_StartDate = new ReportParameter("StartDate", _StartDate.ToString());

                ReportParameter p_EndDate = new ReportParameter("EndDate", _EndDate.ToString());

                reportViewer.LocalReport.SetParameters(new ReportParameter[] { p_ProductRef });
                reportViewer.LocalReport.SetParameters(new ReportParameter[] { p_StartDate });
                reportViewer.LocalReport.SetParameters(new ReportParameter[] { p_EndDate });

             


                this.reportViewer.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(LocalReport_SubreportProcessing);
                this.btRefreshReport.Click += new System.EventHandler(this.ProductRefresh);
         
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return false;
            }
            return true;
        }
   
        private void ProductRefresh(object sender, EventArgs e)
        {
            this.ProductRemainsByDateTableAdapter.Fill(this.RetailTradeClDataSet.ProductRemainsByDate, _StartDate, _EndDate, _productRef);

            ReportParameter p_ProductRef = new ReportParameter("productRef", _productRef.ToString());

            ReportParameter p_StartDate = new ReportParameter("StartDate", _StartDate.ToString());

            ReportParameter p_EndDate = new ReportParameter("EndDate", _EndDate.ToString());

            reportViewer.LocalReport.SetParameters(new ReportParameter[] { p_ProductRef });
            reportViewer.LocalReport.SetParameters(new ReportParameter[] { p_StartDate });
            reportViewer.LocalReport.SetParameters(new ReportParameter[] { p_EndDate });

            
        }

        void LocalReport_SubreportProcessing(object sender, SubreportProcessingEventArgs e)
        {
            e.DataSources.Add(new ReportDataSource("RetailTradeClDataSet_ProductSelectById", this.ProductSelectByIdBindingSource));

        }

        private bool InitProductFullReport()
        {
            this.reportViewer.LocalReport.ReportEmbeddedResource = _reportName;

            this.ProductSelectByIdTableAdapter.Fill(this.RetailTradeClDataSet.ProductSelectById, _productRef);
            this.reportViewer.LocalReport.DataSources.Add(new ReportDataSource("RetailTradeClDataSet_ProductSelectById", this.ProductSelectByIdBindingSource));
            
            this.reportViewer.RefreshReport();

            return true;

        
        }
       
        
    
     



    }
}