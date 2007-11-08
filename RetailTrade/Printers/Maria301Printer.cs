using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Windows.Forms;

namespace RetailTrade.Printers
{
    class Maria301Printer
    {
        public bool HasError;
        public string ErrorText;
        public string ErrorSender;

        public enum KeyPositions {Off,Work,XReport,ZReport};
      
        public KeyPositions KeyPosition
        {
            get { return (KeyPositions)GetPrinterKeyPosition(); }
           
        }

        public class  PrinterInfo
        {      //������� ����� Z 
            int NumZ;
            // ������� �� ������ ���
            decimal BalanceBegin;
            // ��������� ��������
            decimal OfIncome;
            // ��������� ������
            decimal OfExpend;
            // �������� ����������
            decimal Income;
            //������
            decimal Expend;
            //������� ��  ����� ���
            decimal BalanceEnd;
            //����� ���������� ����
            int LastCheck;
            // ����� ����� Z
            bool ifJustZ;

            public bool HasError;
            public string ErrorText;
            public string ErrorSender;

            public decimal CheckSum
            {
                get { return _CheckSumm(); }
            }
            private object _Printer;


            public PrinterInfo(object printer)
            { 
               _Printer =printer;
               this.RefreshData();
            }

            private bool _GetPrinterConfig()
            {
                String result;
               
                try
                {
                    object res = _Printer.GetType().InvokeMember("GetPrinterConfig", BindingFlags.GetProperty, null, _Printer, null);
                    result = res.ToString();
                    if (result[77].ToString() == "0")
                        ifJustZ = false;
                    else
                        ifJustZ = true;
                    NumZ = Convert.ToInt32(result.Substring(78, 12));
                    LastCheck = Convert.ToInt32(result.Substring(90, 12));
                }

                catch (Exception err)
                {
                    this.HasError = true;
                    this.ErrorText = err.Message;
                    this.ErrorSender = "_GetPrinterConfig()";
                    return false;
                }
                return true;
            }
                   
            private bool _GetCashInfo()
            {  String result;

                try
                {
                     object res = _Printer.GetType().InvokeMember("GetCashInfo", BindingFlags.GetProperty, null, _Printer, null);
                     result = res.ToString();

                    BalanceBegin = Convert.ToInt32(result.Substring(0, 10));
                    BalanceBegin = BalanceBegin/100;

                    OfIncome = Convert.ToInt32(result.Substring(10, 10)); 
                    OfIncome= OfIncome/ 100;

                    OfExpend = Convert.ToInt32(result.Substring(20, 10));
                    OfExpend =OfExpend/100;

                    Income = Convert.ToInt32(result.Substring(30, 10));
                    Income = Income / 100;

                    Expend = Convert.ToInt32(result.Substring(40, 10));
                    Expend = Expend / 100;

                    BalanceEnd = Convert.ToInt32(result.Substring(50, 10));
                    BalanceEnd = BalanceEnd / 100;
              
                }

                catch (Exception err)
                {
                    this.HasError = true;
                    this.ErrorText = err.Message;
                    this.ErrorSender = "_GetCashInfo()";
                    return false;
                }

                return true;
            }
            
            private decimal _CheckSumm()
          {

            decimal result;
            try
            {
                object res = _Printer.GetType().InvokeMember("CheckSumm", BindingFlags.GetProperty, null, _Printer, null);
                result = Convert.ToDecimal(res.ToString());
                result = result / 100;
            }
            catch (Exception err)
            {
                this.HasError = true;
                this.ErrorText = err.Message;
                this.ErrorSender = "_CheckSumm()";
                return -1;
            }

            return result;
         }

            public bool RefreshData()
            {
                if (_GetPrinterConfig() & _GetCashInfo())
                {
                    this.HasError = false;
                    this.ErrorText = "RefreshData() �������";
                    this.ErrorSender = "";
                    return true;
                }
                else

                    return false;
            }
       
        }
 
        public PrinterInfo Info;
       
        private object _printer;

        private Type _tp;
     
        private int GetPrinterKeyPosition()
        {
            object res = _printer.GetType().InvokeMember("GetPrinterKeyPosition", BindingFlags.GetProperty, null, _printer, null);

            int result;

            try
            {
                result = Convert.ToInt16(res.ToString());
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return -1;
            }

            return result;

        }
     
        public  Maria301Printer(int numuser)
        {
            try
            {
                _tp = Type.GetTypeFromProgID("M301Ole.Document");
                _printer = Activator.CreateInstance(_tp);
         
            if (this.Init(numuser))
            {
                this.Info = new PrinterInfo(_printer);

                if (this.Info.HasError)
                {
                    this.HasError = true;
                    this.ErrorText = "������ PrinterInfo";
                    this.ErrorSender = "Maria301Printer";
                }
            } 
            }

            catch (Exception err)
            {
                this.HasError = true;
                this.ErrorText = "������ M301Ole.Document "+err.Message;
                this.ErrorSender = "Type.GetTypeFromProgID";
                
                
            }
    
        }

        public bool Init(int numusers)
        {
            Object[] args = new Object[3];
        
            // ���� 
            args[0] = "1";
            
            // ������
            args[1] =numusers.ToString();
            
            //������
            args[2] = "1111111111";
            object res;
            try
            {
                 res = _printer.GetType().InvokeMember("Init", BindingFlags.InvokeMethod, null, _printer, args);
            }
            catch (Exception err)
            {
                HasError = true;
                ErrorText = "�� ������� ������������ �  �������� : " + err.Message;
                ErrorSender = "Init";
                return false;

            }

            if (res.ToString() != "0")
            {
                HasError = false;
                ErrorText = "������������� �������� �������";
                ErrorSender = "Init";
 
                return true;
            }
            else
            {
                HasError = true;
                ErrorText = "�� ������� ������������ �  ��������";
                ErrorSender ="Init";
                return false;
            }
        }

        public bool Done()
        {
            object res;
            
            try
            {
                res = _printer.GetType().InvokeMember("Done", BindingFlags.InvokeMethod, null, _printer, null);
            }
            catch
            {
                this.HasError = true;
                this.ErrorText = "������ Done()";
                this.ErrorSender = "Done()";

                return false;
            }
            if (res.ToString() == "0")
            { 
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool OpenCheck(string TradePuplet)
        {
            //** ���� ��� ������ � ���� �� ����� //*
             if (this.HasError) return false;
             if (!this.Info.RefreshData()) return false;
             if (this.KeyPosition != KeyPositions.Work)
             {
                 this.ErrorText = "���� �� �� �����";
                 this.ErrorSender = "OpenCheck";
                 return false;
             }


            Object[] args = new Object[1];
            args[0] = TradePuplet;
            object res;

            try
            {

                res = _printer.GetType().InvokeMember("OpenCheck", BindingFlags.InvokeMethod, null, _printer, args);

            }
            catch (Exception err)
            {
                this.HasError = true;
                this.ErrorText = "������ �������� ���� " + err.Message;
                this.ErrorSender = "OpenCheck";
                return false;
            }
           
                if (res.ToString() == "1")
                {
                    this.HasError = false;
                    this.ErrorText = "������ ���";
                    this.ErrorSender = "OpenCheck";


                    return true;
                }
                else
                {
                    this.HasError = true;
                    this.ErrorText = "������ �������� ���� ";
                    this.ErrorSender = "OpenCheck";
           
                    return false;
                }
            
           


        }
    
        public decimal FiscalLine(string name, decimal quantity,decimal price, bool isnds )
        {
            if (this.HasError) return 0;
            if (!this.Info.RefreshData()) return 0;

            
            if (this.KeyPosition != KeyPositions.Work) 
            { 
            
            this.ErrorText= "���� �� � ������� ���������";
            this.ErrorSender ="FiscalLine";
            return 0;
            }


            Object[] args = new Object[6];

            if (name.Length>12)
             args[0] = name.Substring(0,12);
              else
                args[0] = name;
            

            if ((Convert.ToInt32(quantity)-quantity)!=0)
            {
                /*���-��*/
             args[1] = quantity*1000;
            /*����*/
             args[2] = price*100;
           /*���������*/
             args[3] = 1;
             }

            else
            {
              /*���-��*/
             args[1] = quantity;
            /*����*/
             args[2] = price*100;
           /*���������*/
             args[3] = 0;
             }
            
           
            /*������*/
            if (isnds)
                args[4] = 1;
            else
                args[4] = 0;
           
            args[5] = 0;
               
            decimal result;

            try
            { 
                object res = _printer.GetType().InvokeMember("FiscalLine", BindingFlags.InvokeMethod, null, _printer, args);

                result = Convert.ToDecimal(res.ToString());
            }

            catch (Exception err)
            {
                this.HasError = true;
                this.ErrorText = "������ ������ ������ : " + err.Message;
                this.ErrorSender = "FiscalLine";
                return 0;
            }

            this.HasError = false;
            this.ErrorText = "������ �� ����� : " + result.ToString();
            this.ErrorSender = "FiscalLine";
            return result;

        }
 
       
        public decimal CloseCheckEx( decimal cash)
        {
            if (this.HasError) return 0;
            if (!this.Info.RefreshData()) return 0;


            if (this.KeyPosition != KeyPositions.Work)
            {

                this.ErrorText = "���� �� � ������� ���������";
                this.ErrorSender = "FiscalLine";
                return 0;
            }


            Object[] args = new Object[4];

            args[0] = (cash*100);
            args[1] = 0;
            args[2] = 0;
            args[3] = 0;

           
            decimal result;

            try
            { 
                object res = _printer.GetType().InvokeMember("CloseCheckEx", BindingFlags.InvokeMethod, null, _printer, args);

                result = Convert.ToDecimal(res.ToString());
                result = result/100;
            }

            catch (Exception err)
            {
                this.HasError = true;
                this.ErrorText = "������ �������� ����" + err.Message;
                this.ErrorSender = "CloseCheckEx";
               
                return 0;
            }

            this.HasError =false;
            this.ErrorText = "��������� ������ ���";
            this.ErrorSender = "CloseCheckEx";
               
            
            return result;


        }
        public bool AbortCheck()
        {
            if (this.HasError) return false;
            if (!this.Info.RefreshData()) return false;


            if (this.KeyPosition != KeyPositions.Work)
            {

                this.ErrorText = "���� �� � ������� ���������";
                this.ErrorSender = "FiscalLine";
                return false;
            }
            

            object res; 
                
            try
            {
                res = _printer.GetType().InvokeMember("AbortCheck", BindingFlags.InvokeMethod, null, _printer, null);
            
            if (res.ToString() == "1")
            {
                this.HasError = false;
                this.ErrorText = "������� ���";
                this.ErrorSender = "AbortCheck()";
            

                return true;
            }
            else
            {
                this.HasError = true;
                this.ErrorText = "������ ������ ����";
                this.ErrorSender = "AbortCheck()";

                return false;
            }
        }
        catch (Exception err)
        {
            this.HasError = true;
            this.ErrorText = "������ ������ ����" + err.Message;
            this.ErrorSender = "AbortCheck()";
            return false;
        }
        }
     
    
        /*    public bool GetCheckResult()
        {
            
            String result;

            try
            {
                object res = _printer.GetType().InvokeMember("GetCheckResult", BindingFlags.GetProperty, null, _printer, null);

                result = res.ToString();
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return false;
            }

            return true;
        
        }

        */
      
           
        public bool XReport()
        {
            if (this.HasError) return false;
            if (!this.Info.RefreshData()) return false;

            if (this.KeyPosition != KeyPositions.XReport)
             {
                this.ErrorText ="��������� ���� � ��������� X �����";
                this.ErrorSender = "XReport()";
                return false;
            }

             
            Object[] args = new Object[8];

           
            String result;
            object res;
            try
            { 
                res = _printer.GetType().InvokeMember("XReport", BindingFlags.GetProperty, null, _printer, args);
                res = _printer.GetType().InvokeMember("XReportFromRegisters", BindingFlags.GetProperty, null, _printer, null);
           
                result = res.ToString();
            }

            catch (Exception err)
            {
                this.HasError = true;
                this.ErrorText = "������ ��� ������ � ������: "+ err.Message;
                this.ErrorSender = "XReport()";
           
                return false;
            }

            this.HasError = false;
            this.ErrorText = "� ����� ���� ��������� ";
            this.ErrorSender = "XReport()";
            return true;
        }

        public bool ZReport()
        {
            if (this.HasError) return false;
            if (!this.Info.RefreshData()) return false;

            if (this.KeyPosition != KeyPositions.ZReport)
            {
                this.ErrorText = "��������� ���� � ��������� Z �����";
                this.ErrorSender = "ZReport()";
                return false;
            }
            Object[] args = new Object[8];

           try
            {
            
               object res = _printer.GetType().InvokeMember("ZReport", BindingFlags.GetProperty, null, _printer, null);
               String result;        
               result = res.ToString();
            }

            catch (Exception err)
            {
                this.HasError = true;
                this.ErrorText = "������ Z ������" + err.Message;
                this.ErrorSender = "ZReport";
                return false;
            }

            this.HasError = false;
            this.ErrorText = "Z �������� �������";
            this.ErrorSender = "ZReport";
            
            
            return true;
        }
  
        public bool testCheck()
        {
            this.OpenCheck("�");

          decimal  quant = 3;
          decimal pr = 7 ;

            this.FiscalLine("test",quant,pr,true);
         //   this.FiscalLineEx();
          //  this.SetCurrentCheckDirection();
         //   this.FiscalLineEx();
            this.CloseCheckEx(80);

            return true;
        
        
        }
    }
}
