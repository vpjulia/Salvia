using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace RetailTradeClient.Printers
{
    public class Datecs
    {
        #region Printer
        protected class Printer
        {

            [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]

            public unsafe struct RetData
            {
                public unsafe int Count;
                public unsafe int CmdMode;
                public unsafe int UserData;
                public unsafe int Status;
                [MarshalAs(UnmanagedType.LPStr)]
                public unsafe String CmdName;

                [MarshalAs(UnmanagedType.LPStr)]
                public unsafe String SendStr;
                [MarshalAs(UnmanagedType.LPStr)]
                public unsafe String Whole;
                [MarshalAs(UnmanagedType.LPStr)]
                public unsafe String RetItem1;
                [MarshalAs(UnmanagedType.LPStr)]
                public unsafe String RetItem2;
                [MarshalAs(UnmanagedType.LPStr)]
                public unsafe String RetItem3;
                [MarshalAs(UnmanagedType.LPStr)]
                public unsafe String RetItem4;
                [MarshalAs(UnmanagedType.LPStr)]
                public unsafe String RetItem5;
                [MarshalAs(UnmanagedType.LPStr)]
                public unsafe String RetItem6;
                [MarshalAs(UnmanagedType.LPStr)]
                public unsafe String RetItem7;
                [MarshalAs(UnmanagedType.LPStr)]
                public unsafe String RetItem8;
                [MarshalAs(UnmanagedType.LPStr)]
                public unsafe String RetItem9;
                [MarshalAs(UnmanagedType.LPStr)]
                public unsafe String RetItem10;
                [MarshalAs(UnmanagedType.LPStr)]
                public unsafe String RetItem11;
                [MarshalAs(UnmanagedType.LPStr)]
                public unsafe String RetItem12;
                [MarshalAs(UnmanagedType.LPStr)]
                public unsafe String RetItem13;
                [MarshalAs(UnmanagedType.LPStr)]
                public unsafe String RetItem14;
                [MarshalAs(UnmanagedType.LPStr)]
                public unsafe String RetItem15;
                [MarshalAs(UnmanagedType.LPStr)]
                public unsafe String RetItem16;
                [MarshalAs(UnmanagedType.LPStr)]
                public unsafe String RetItem17;
                [MarshalAs(UnmanagedType.LPStr)]
                public unsafe String RetItem18;
                [MarshalAs(UnmanagedType.LPStr)]
                public unsafe String RetItem19;
                [MarshalAs(UnmanagedType.LPStr)]
                public unsafe String RetItem20;

                [MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.I1, SizeConst = 6)]
                public unsafe byte[] OrigStat;

            }

            private delegate int CallbackDef(IntPtr IParam);

            [DllImport("fpl.dll")]
            private static extern int InitFPport(int i1, int i2);

            [DllImport("fpl.dll")]
            private static extern int CloseFPport();

            [DllImport("fpl.dll")]
            private static extern int GetStatus(int hWnd, CallbackDef callback, int lParam, [MarshalAs(UnmanagedType.Bool)] bool noWait);

            [DllImport("fpl.dll")]
            private static extern int DayInfo(int hWnd, CallbackDef callback, int lParam);

            [DllImport("fpl.dll")]
            private static extern int PrintFiscalText(int hWnd, CallbackDef callback, int lParam, [MarshalAs(UnmanagedType.LPStr)] string Text);


            [DllImport("fpl.dll")]
            private static extern int PrintNonfiscalText(int hWnd, CallbackDef callback, int lParam, [MarshalAs(UnmanagedType.LPStr)] string Text);
            [DllImport("fpl.dll")]
            private static extern int OpenFiscalReceipt(int hWnd, CallbackDef callback, int lParam, [MarshalAs(UnmanagedType.I4)] int _operator, [MarshalAs(UnmanagedType.LPStr)] string Text, [MarshalAs(UnmanagedType.I4)] int tillnumber, [MarshalAs(UnmanagedType.Bool)] bool taxcheck);

            [DllImport("fpl.dll")]
            private static extern int SubTotal(int hWnd, CallbackDef callback, int lParam, bool print, bool display, double per, double disc);

            [DllImport("fpl.dll")]
            private static extern int Total(int hWnd, CallbackDef callback, int lParam, [MarshalAs(UnmanagedType.LPStr)] string Text, char PaidCode, double amuont);

            [DllImport("fpl.dll")]
            private static extern int CloseFiscalReceipt(int hWnd, CallbackDef callback, int lParam);


            [DllImport("fpl.dll")]
            private static extern int ResetReceipt(int hWnd, CallbackDef callback, int lParam);

            [DllImport("fpl.dll")]
            private static extern int OperatorsReport(int hWnd, CallbackDef callback, int lParam, [MarshalAs(UnmanagedType.LPStr)] string Text);


            [DllImport("fpl.dll")]
            private static extern int DeleteArticle(int hWnd, CallbackDef callback, int lParam, int numArt, [MarshalAs(UnmanagedType.LPStr)] string Text);


            [DllImport("fpl.dll")]
            private static extern int GetCommonArticleInfo(int hWnd, CallbackDef callback, int lParam);

            [DllImport("fpl.dll")]
            private static extern int GetArticleInfo(int hWnd, CallbackDef callback, int lParam, int numArt);

            [DllImport("fpl.dll")]

            private static extern int ServiceInputOutput(int hWnd, CallbackDef callback, int lParam, double sum);


            [DllImport("fpl.dll")]

            private static extern int GetFiscalClosureStatus(int hWnd, CallbackDef callback, int lParam, bool param);
            [DllImport("fpl.dll")]

            private static extern int GetCurrentTaxes(int hWnd, CallbackDef callback, int lParam, int param);

            [DllImport("fpl.dll")]

            private static extern int LastFiscalClosure(int hWnd, CallbackDef callback, int lParam, int param);

            [DllImport("fpl.dll")]
            private static extern int SaleArticleAndDisplay(int hWnd, CallbackDef callback, int lParam, bool sign, int numArt, double qwant, double perc, double dc);


            [DllImport("fpl.dll")]
            private static extern int ProgrammingArticle(int hWnd, CallbackDef callback, int lParam, char tax, [MarshalAs(UnmanagedType.I4)] int numArt, int group, [MarshalAs(UnmanagedType.R8)] double price, [MarshalAs(UnmanagedType.LPStr)] string psw, [MarshalAs(UnmanagedType.LPStr)] string name);


            [DllImport("fpl.dll")]
            private static extern int PrintFiscalMemoryByDate(int hWnd, CallbackDef callback, int lParam, [MarshalAs(UnmanagedType.LPStr)] string psw, [MarshalAs(UnmanagedType.LPStr)] string start, [MarshalAs(UnmanagedType.LPStr)] string end);

            [DllImport("fpl.dll")]
            private static extern int PrintFiscalMemoryByNum(int hWnd, CallbackDef callback, int lParam, [MarshalAs(UnmanagedType.LPStr)] string psw, int start, int end);


            [DllImport("fpl.dll")]
            private static extern int FiscalClosure(int hWnd, CallbackDef callback, int lParam, [MarshalAs(UnmanagedType.LPStr)] string psw, char opt);







            private CallbackDef callback;
            int Result(IntPtr RetDataPtr)
            {
                rd = (RetData)Marshal.PtrToStructure(RetDataPtr, typeof(RetData));
                //общая ошибка: (S0.5)
                /*  bool bCommonError = (((rd.OrigStat[0] >> 5) & 1) == 1);

                  bool bDateTime =  (((rd.OrigStat[0] >> 2) & 1) == 1);

 
                  bool isFiscalCheckOpen = (((rd.OrigStat[2] >> 3) & 1) == 1);

                  bool isNonFiscalCheckOpen = (((rd.OrigStat[2] >> 5) & 1) == 1);


                  //Закончилась бумага (S2.0#) 
                  bool bPaperWasFinish = (bCommonError && (((rd.OrigStat[2] >> 0) & 1) == 1));


            */



                //res = (DatecsErrorsEnum)Enum.Format(typeof(DatecsErrorsEnum), rd.Status,"G");
                //Enum.Parse(typeof(DatecsErrorsEnum), rd.Status);


                Status = (DatecsErrorsEnum)rd.Status;



                return 1;

            }






            private bool Contains(DatecsErrorsEnum flag, DatecsErrorsEnum Flags)
            {

                return ((Flags & flag) == flag);

            }

            private DatecsErrorsEnum _Status;


            public struct Cash
            {
                public decimal OfIncome;

                public decimal OfExpend;

                public decimal BalanceEnd;
            }

            public struct Check
            {
                public int numCheck;

                public decimal sumCheck;

                public decimal cashCustomer;


            }

            public struct ZReport
            {
                public int num;
                public decimal sumA;
                public decimal sumD;

            }



            private ZReport _currentZ;

            internal ZReport CurrentZReport
            {
                get
                {
                    GetCurrentZreport();
                    return _currentZ;
                }
                set { _currentZ = value; }
            }



            private Cash _CashInfo;
            private Check _checkInfo;

            internal Check CheckInfo
            {
                get
                {
                    LastCheckStatus();
                    return _checkInfo;
                }
                set { _checkInfo = value; }
            }

            public Cash CashInfo
            {
                get
                {
                    ServiceInputOutput(0);
                    return _CashInfo;
                }
                set { _CashInfo = value; }
            }



            public DatecsErrorsEnum Status
            {
                get { return _Status; }
                set
                {

                    _Status = value;

                    // /*заглушить DatecsErrorsEnum.F_MODULE_NUM ^ DatecsErrorsEnum.F_FORMATTED ^ DatecsErrorsEnum.F_SER_NUM  */
                    if (Contains(DatecsErrorsEnum.F_MODULE_NUM, value))

                        _Status = _Status ^ DatecsErrorsEnum.F_MODULE_NUM;

                    if (Contains(DatecsErrorsEnum.F_FORMATTED, value))

                        _Status = _Status ^ DatecsErrorsEnum.F_FORMATTED;

                    if (Contains(DatecsErrorsEnum.F_SER_NUM, value))

                        _Status = _Status ^ DatecsErrorsEnum.F_SER_NUM;

                    // если общая ошибка - ErrorTrue, загушить

                    if (_Status == DatecsErrorsEnum.None)
                    {
                        HasError = false;
                    }

                    if (Contains(DatecsErrorsEnum.COMMON_ERROR, value) | Contains(DatecsErrorsEnum.TIMEOUT_ERROR, value))
                    {
                        _Status = _Status ^ DatecsErrorsEnum.COMMON_ERROR;

                        HasError = true;

                        ErrorText = _Status.ToString();
                    }




                }
            }


            public bool HasError;

            public string ErrorText;

            private RetData rd;

            public Printer()
            {
                _CashInfo = new Cash();


                callback = new CallbackDef(Result);

                Init();

                GetStatus();


            }

            private bool Init()
            {
                int res = InitFPport(1, 19200);
                if (res > 1)
                    return true;
                else
                    return false;
            }


            public bool Close()
            {
                ResetReceipt("ЗАКРЫТ АВТОМАТИЧЕСКИ");

                int res = CloseFPport();
                if (res == 1)
                    return true;
                else
                    return false;
            }

            //очистить артикулы
            private bool ClearArticle()
            {
                this.GetStatus();

                if (this.HasError) return false;

                int res;

                try
                {
                    unsafe
                    {
                        res = DeleteArticle(0, callback, 0, 0, "0000");
                    }
                }


                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                    HasError = true;
                    ErrorText = err.Message;
                    return false;
                }

                if (res == 0)
                {
                    return true;
                }
                else
                {
                    HasError = true;
                    ErrorText = "ClearArticle()!!!";
                    return false;

                }
            }

            //следующий пустой номер
            private int GetMaxArticle()
            {
                this.GetStatus();

                if (this.HasError) return -1;


                if (this.HasError) return -1;

                int MaxArt = -1;



                int res;

                try
                {
                    unsafe
                    {
                        res = GetCommonArticleInfo(0, callback, 0);
                        MaxArt = Convert.ToInt32(rd.RetItem3.ToString());
                        bool error = false;

                        while (!error)
                        {
                            MaxArt += 1;
                            int rs = GetArticleInfo(0, callback, 0, MaxArt);
                            if (rd.RetItem1.ToString() != "P")
                                error = true;

                        }





                    }
                }


                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                    HasError = true;
                    ErrorText = err.Message;
                    return -1;
                }

                if (res == 0)
                {
                    return MaxArt;

                }
                else
                {
                    HasError = true;
                    ErrorText = "Ошибка GetMaxArticle() !!!";
                    return -1;

                }

            }

            // добавить
            private int AddArticle(bool isNds, double price, string name)
            {
                this.GetStatus();

                if (this.HasError) return -1;

                int maxArt = this.GetMaxArticle();


                char _tax = isNds ? 'А' : 'В';


                int res;

                try
                {
                    unsafe
                    {
                        res = ProgrammingArticle(0, callback, 0, _tax, maxArt, 1, price, "0000", name);
                    }
                }


                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                    HasError = true;
                    ErrorText = err.Message;
                    return -1;
                }

                if (res == 0)
                {
                    return maxArt;
                }
                else
                {
                    HasError = true;
                    ErrorText = "Ошибка ProgrammingArticle !!!";
                    return -1;

                }

            }

            //информация о последнем Чеке
            private bool LastCheckStatus()
            {

                this.GetStatus();

                if (this.HasError) return false;

                int res;

                try
                {
                    unsafe
                    {
                        res = GetFiscalClosureStatus(0, callback, 0, true);

                        _checkInfo.numCheck = Convert.ToInt32(rd.RetItem2.ToString());

                        _checkInfo.sumCheck = Convert.ToDecimal(rd.RetItem3.ToString());
                        _checkInfo.sumCheck = _checkInfo.sumCheck / 100;


                        _checkInfo.cashCustomer = Convert.ToDecimal(rd.RetItem4.ToString());
                        _checkInfo.cashCustomer = _checkInfo.cashCustomer / 100;


                    }
                }


                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                    HasError = true;
                    ErrorText = err.Message;
                    return false;
                }

                if (res == 0)
                {
                    return true;
                }
                else
                {
                    HasError = true;
                    ErrorText = "GetFiscalStatus()!!!";
                    return false;

                }
            }


            //информация о текущих продажах
            private bool GetCurrentZreport()
            {

                this.GetStatus();

                if (this.HasError) return false;

                int res;

                try
                {
                    unsafe
                    {
                        res = GetCurrentTaxes(0, callback, 0, 0);



                        _currentZ.sumA = Convert.ToDecimal(rd.RetItem1.ToString());
                        _currentZ.sumA = _currentZ.sumA / 100;


                        _currentZ.sumD = Convert.ToDecimal(rd.RetItem3.ToString());
                        _currentZ.sumD = _currentZ.sumD / 100;

                        _currentZ.num = this.DayInfo();

                    }
                }


                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                    HasError = true;
                    ErrorText = err.Message;
                    return false;
                }

                if (res == 0)
                {
                    return true;
                }
                else
                {
                    HasError = true;
                    ErrorText = "GetFiscalStatus()!!!";
                    return false;

                }
            }

            public bool GetStatus()
            {
                int r;

                try
                {
                    unsafe
                    {
                        r = GetStatus(0, callback, 0, false);
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                    HasError = true;
                    ErrorText = err.Message;
                    return false;
                }

                if (r == 0)
                {
                    return true;
                }
                else
                {
                    HasError = true;
                    ErrorText = "Не выполнилась GetStatus !!!";
                    return false;

                }

            }

            // номер последнего Z отчета

            private int DayInfo()
            {
                int r;
                int res;
                try
                {
                    unsafe
                    {
                        r = DayInfo(0, callback, 0);
                        res = Convert.ToInt32(rd.RetItem5.ToString());


                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                    HasError = true;
                    ErrorText = err.Message;
                    return -1;
                }

                if (r == 0)
                {
                    return res;
                }
                else
                {
                    HasError = true;
                    ErrorText = "Не выполнилась GetStatus !!!";
                    return -1;

                }
            }



            //Открыть чек

            public int OpenCheck(int numOperator)
            {
                this.GetStatus();

                ClearArticle();

                if (this.HasError) return -1;


                if (this.Status == DatecsErrorsEnum.FISCAL_OPEN)
                {
                    this.HasError = true;
                    this.ErrorText = "Уже открыт чек";
                    return -1;
                }

                int res;
                try
                {
                    unsafe
                    {


                        res = OpenFiscalReceipt(0, callback, 0, numOperator, "0000", 1, true);
                    }
                }

                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                    HasError = true;
                    ErrorText = err.Message;
                    return -1;
                }

                if (res == 0)
                {
                    try
                    {
                        return Convert.ToInt32(rd.RetItem1.ToString());
                    }
                    catch
                    {
                        return -1;
                    }
                }
                else
                {
                    HasError = true;
                    ErrorText = "Не выполнилась OpenFiscalReceipt !!!";
                    return -1;

                }
            }

            //Закрыть чек
            public int CloseCheck()
            {
                this.GetStatus();

                int res;

                try
                {
                    unsafe
                    {
                        res = CloseFiscalReceipt(0, callback, 0);


                    }
                }

                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                    HasError = true;
                    ErrorText = err.Message;
                    return -1;
                }

                if (res == 0)
                {
                    return 1;
                }
                else
                {
                    HasError = true;
                    ErrorText = "Не выполнилась CloseCheck() !!!";
                    return -1;

                }
            }

            public decimal SubTotal(double discount)
            {
                this.GetStatus();

                if (this.HasError) return -1;

                if (!this.Contains(DatecsErrorsEnum.FISCAL_OPEN, this.Status))
                {
                    this.HasError = true;
                    this.ErrorText = "Не открыт чек";
                    return -1;
                }

                int res;
                decimal sum;

                try
                {
                    unsafe
                    {
                        res = SubTotal(0, callback, 0, false, true, 0, discount);
                        sum = Convert.ToDecimal(rd.RetItem1.ToString());
                        sum = sum / 100;
                    }
                }

                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                    HasError = true;
                    ErrorText = err.Message;
                    return -1;
                }

                if (res == 0)
                {
                    return sum;
                }
                else
                {
                    HasError = true;
                    ErrorText = "Не выполнилась SubTotal !!!";
                    return -1;

                }
            }

            public decimal Total(string comment, double cashCustomer, bool creditCard)
            {
                this.GetStatus();

                if (this.HasError) return -1;

                if (!this.Contains(DatecsErrorsEnum.FISCAL_OPEN, this.Status))
                {
                    this.HasError = true;
                    this.ErrorText = "Не открыт чек";
                    return -1;
                }

                int res;
                decimal sum;
                char code = creditCard ? 'D' : 'P';
                try
                {
                    unsafe
                    {
                        res = Total(0, callback, 0, comment, code, cashCustomer);
                        sum = Convert.ToDecimal(rd.RetItem2.ToString());
                        sum = sum / 100;
                    }
                }

                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                    HasError = true;
                    ErrorText = err.Message;
                    return -1;
                }

                if (res == 0)
                {
                    return sum;
                }
                else
                {
                    HasError = true;
                    ErrorText = "Не выполнилась SubTotal !!!";
                    return -1;

                }
            }

            //отмена чека

            public bool ResetReceipt(string comment)
            {
                string comnt;

                if (comment.Length > 24)
                {
                    comnt = comment.Substring(0, 24);
                }
                else
                    comnt = comment;

                this.GetStatus();

                if (!this.Contains(DatecsErrorsEnum.FISCAL_OPEN, this.Status))
                {
                    return false;
                }


                int res;


                try
                {
                    unsafe
                    {
                        res = PrintFiscalText(0, callback, 0, comnt);
                        res = ResetReceipt(0, callback, 0);

                        ClearArticle();

                    }
                }

                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                    HasError = true;
                    ErrorText = err.Message;
                    return false;
                }

                if (res == 0)
                {
                    return true;
                }
                else
                {
                    HasError = true;
                    ErrorText = "Не выполнилась ResetReceipt() !!!";
                    return false;

                }

            }

            //продажа
            public int SaleArticle(bool isNds, double price, string name, double quantity, double discount)
            {
                this.GetStatus();

                if (this.HasError) return -1;

                int numArt = this.AddArticle(isNds, price, name);

                if (numArt <= 0) return -1;



                int res;

                try
                {
                    unsafe
                    {
                        res = SaleArticleAndDisplay(0, callback, 0, true, numArt, quantity, 0, discount);
                    }
                }


                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                    HasError = true;
                    ErrorText = err.Message;
                    return -1;
                }

                if (res == 0)
                {
                    return numArt;
                }
                else
                {
                    HasError = true;
                    ErrorText = "Ошибка ProgrammingArticle !!!";
                    return -1;

                }

            }

            // возврат позиции
            public bool ReturnArticle(bool isNds, double price, string name, double quantity, double discount, int numArt)
            {
                this.GetStatus();

                if (this.HasError) return false;




                int res;

                try
                {
                    unsafe
                    {
                        res = SaleArticleAndDisplay(0, callback, 0, false, numArt, quantity, 0, discount);
                    }
                }


                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                    HasError = true;
                    ErrorText = err.Message;
                    return false;
                }

                if (res == 0)
                {
                    return true;
                }
                else
                {
                    HasError = true;
                    ErrorText = "Ошибка ProgrammingArticle !!!";
                    return false;

                }

            }

            //внес/инкассация
            public bool ServiceInputOutput(double sum)
            {
                this.GetStatus();

                if (this.Status == DatecsErrorsEnum.FISCAL_OPEN)
                {
                    return false;
                }
                int res;

                try
                {
                    unsafe
                    {
                        res = ServiceInputOutput(0, callback, 0, sum);

                        _CashInfo.BalanceEnd = Convert.ToDecimal(rd.RetItem1.ToString());

                        _CashInfo.BalanceEnd = _CashInfo.BalanceEnd / 100;

                        _CashInfo.OfIncome = Convert.ToDecimal(rd.RetItem2.ToString());
                        _CashInfo.OfIncome = _CashInfo.OfIncome / 100;


                        _CashInfo.OfExpend = Convert.ToDecimal(rd.RetItem3.ToString());
                        _CashInfo.OfExpend = _CashInfo.OfExpend / 100;



                    }
                }

                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                    HasError = true;
                    ErrorText = err.Message;
                    return false;
                }

                if (res == 0)
                {
                    return true;
                }
                else
                {
                    HasError = true;
                    ErrorText = "Не выполнилась ResetReceipt() !!!";
                    return false;

                }


            }

            //отчет по операторам
            public bool OperatorsReport()
            {
                this.GetStatus();

                if (this.Status == DatecsErrorsEnum.FISCAL_OPEN)
                {
                    return false;
                }


                int res;


                try
                {
                    unsafe
                    {
                        res = OperatorsReport(0, callback, 0, "0000");


                    }
                }

                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                    HasError = true;
                    ErrorText = err.Message;
                    return false;
                }

                if (res == 0)
                {
                    return true;
                }
                else
                {
                    HasError = true;
                    ErrorText = "Не выполнилась OperatorsReport() !!!";
                    return false;

                }

            }

            public bool PeriodZReport(int begin, int end)
            {
                this.GetStatus();
                if (HasError) return false;

                if (this.Status == DatecsErrorsEnum.FISCAL_OPEN)
                {
                    return false;
                }


                int res;



                try
                {
                    unsafe
                    {
                        res = PrintFiscalMemoryByNum(0, callback, 0, "0000", begin, end);


                    }
                }

                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                    HasError = true;
                    ErrorText = err.Message;
                    return false;
                }

                if (res == 0)
                {
                    return true;
                }
                else
                {
                    HasError = true;
                    ErrorText = "Не выполнилась OperatorsReport() !!!";
                    return false;

                }

            }

            public bool PeriodZReport(DateTime begin, DateTime end)
            {
                this.GetStatus();
                if (HasError) return false;

                if (this.Status == DatecsErrorsEnum.FISCAL_OPEN)
                {
                    return false;
                }


                int res;

                string startDate = "";

                if (begin.Day.ToString().Length == 1)
                {
                    startDate = '0' + begin.Day.ToString();
                }
                else
                {
                    startDate = begin.Day.ToString();
                }


                if (begin.Month.ToString().Length == 1)
                {
                    startDate = '0' + begin.Month.ToString();
                }
                else
                {
                    startDate += begin.Month.ToString();
                }


                startDate += begin.Year.ToString().Substring(2, 2);



                string endDate = "";


                if (end.Day.ToString().Length == 1)
                {
                    endDate = '0' + end.Day.ToString();
                }
                else
                {
                    endDate = end.Day.ToString();
                }


                if (end.Month.ToString().Length == 1)
                {
                    endDate = '0' + end.Month.ToString();
                }
                else
                {
                    endDate += end.Month.ToString();
                }


                endDate += end.Year.ToString().Substring(2, 2);





                try
                {
                    unsafe
                    {
                        res = PrintFiscalMemoryByDate(0, callback, 0, "0000", startDate, endDate);


                    }
                }

                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                    HasError = true;
                    ErrorText = err.Message;
                    return false;
                }

                if (res == 0)
                {
                    return true;
                }
                else
                {
                    HasError = true;
                    ErrorText = "Не выполнилась OperatorsReport() !!!";
                    return false;

                }

            }

            public bool XReport()
            {

                this.GetStatus();
                if (HasError) return false;

                if (this.Status == DatecsErrorsEnum.FISCAL_OPEN)
                {
                    return false;
                }




                int res;

                try
                {
                    unsafe
                    {
                        res = FiscalClosure(0, callback, 0, "0000", '2');


                    }
                }

                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                    HasError = true;
                    ErrorText = err.Message;
                    return false;
                }

                if (res == 0)
                {
                    return true;
                }
                else
                {
                    HasError = true;
                    ErrorText = "Не выполнилась XReport() !!!";
                    return false;

                }


            }
            public int PrintZReport()
            {

                this.GetStatus();
                if (HasError) return -1;

                if (this.Status == DatecsErrorsEnum.FISCAL_OPEN)
                {
                    return -1;
                }


                int res;
                int numz;

                try
                {
                    unsafe
                    {
                        res = FiscalClosure(0, callback, 0, "0000", '0');
                        numz = Convert.ToInt32(rd.RetItem1.ToString());

                        /*  _lastZ.num = Convert.ToInt32(rd.RetItem1.ToString());
                          _lastZ.sumA = Convert.ToDecimal(rd.RetItem2.ToString());
                          _lastZ.sumA = _lastZ.sumA / 100;
                          _lastZ.sumD = Convert.ToDecimal(rd.RetItem6.ToString());
                          _lastZ.sumD = _lastZ.sumD / 100;
                          */
                        ClearArticle();
                    }
                }

                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                    HasError = true;
                    ErrorText = err.Message;
                    return -1;
                }

                if (res == 0)
                {
                    return numz;
                }
                else
                {
                    HasError = true;
                    ErrorText = "Не выполнилась OperatorsReport() !!!";
                    return -1;

                }


            }



        }
        #endregion
        private PrinterCashInfo _printerCashInfo;
        protected Printer _printer;

        #region Classes
        [Flags]
        public enum DatecsErrorsEnum
        {
            None = 0x00000000,

            SYNTAX_ERROR = 0x00000001,

            INVALID_CMD = 0x00000002,

            INVALID_TIME = 0x00000004,

            PRINT_ERROR = 0x00000008,

            SUM_OVERFLOW = 0x00000010,

            CMD_NOT_ALLOWED = 0x00000020,

            RAM_CLEARED = 0x00000040,

            PRINT_RESTART = 0x00000080,

            RAM_DESTROYED = 0x00000100,

            PAPER_OUT = 0x00000200,

            FISCAL_OPEN = 0x00000400,

            NONFISCAL_OPEN = 0x00000800,

            SERVICE_OPEN = 0x00001000,

            F_ABSENT = 0x00002000,

            F_MODULE_NUM = 0x00004000,

            F_WRITE_ERROR = 0x00010000,

            F_FULL = 0x00020000,

            F_READ_ONLY = 0x00040000,

            F_CLOSE_ERROR = 0x00080000,

            F_LESS_30 = 0x00100000,

            F_FORMATTED = 0x00200000,


            F_FISCALIZED = 0x00400000,


            F_SER_NUM = 0x00800000,


            PROTOCOL_ERROR = 0x01000000,

            NACK_RECEIVED = 0x02000000,

            TIMEOUT_ERROR = 0x04000000,

            COMMON_ERROR = 0x08000000,

            F_COMMON_ERROR = 0x10000000,

            ADD_PAPER = 0x20000000


        };
        public struct PrinterCashInfo
        {
            public int NumZ;
            public decimal BalanceBegin;
            public decimal Income;
            public decimal OfExpend;
            public decimal BalanceEnd;
            public decimal LastCheckSum;
            public decimal LastCustomerCash;
            public int LastCheckNum;

        };
        #endregion

        public string ErrorText
        {
            get { return _printer.ErrorText; }
        }
        public bool HasError
        {
            get { return _printer.HasError; }

        }
        public PrinterCashInfo printerCashInfo
        {
            get
            {

                return _printerCashInfo;
            }

        }

        #region ctor.
        public Datecs()
        {
            _printer = new Printer();

            if (!HasError) this.SetPrinterCashInfo();

        }
        #endregion

        public bool CancelCheck(string comment)
        {
            return _printer.ResetReceipt(comment);
        }

        public void Close()
        {

            _printer.Close();

        }

        // --- номер чека
        public int CloseCheck(double cashCustomer, double discount, decimal controlsum, bool creditCard)
        {
            if (HasError) return -1;

            int res;
            decimal sum = _printer.SubTotal(discount);
            if (sum == -1) return -1;
            decimal discountD = Convert.ToDecimal(discount);

            if (Decimal.Round(sum, 2) != Decimal.Round(controlsum + discountD, 2))
            {
                this._printer.ErrorText = "Не сходятся суммы!!!)" + System.Environment.NewLine
                    + "printer : " + sum.ToString() + System.Environment.NewLine
                    + " base : " + controlsum.ToString() + System.Environment.NewLine
                    + " discount : " + discountD.ToString();
                return -1;
            }

            decimal allsum = _printer.Total("", cashCustomer, creditCard);

            if (allsum == -1) return -1;

            if (_printer.CloseCheck() >= 0)
            {
                res = _printer.CheckInfo.numCheck;
                return res;
            }
            return -1;
        }

        public int OpenCheck(int numOperator)
        {

            if (_printer.HasError)
                return -1;

            return _printer.OpenCheck(numOperator);

        }

        public bool ReturnArticle(int numart, bool isnds, double quantity, double price, string name)
        {
            if (this.HasError) return false;

            if (name.Length >= 24)
            {
                name = name.Substring(0, 24);
            }

            return _printer.ReturnArticle(isnds, price, name, quantity, 0, numart);
        }

        //номер артикула
        public int SaleArticle(bool isnds, double quantity, double price, string name)
        {

            if (this.HasError) return -1;


            if (name.Length >= 24)
            {

                name = name.Substring(0, 24);
            }


            return _printer.SaleArticle(isnds, price, name, quantity, 0);

        }

        #region Reports
        public bool XReport()
        {
            if (HasError) return false;
            return _printer.XReport();
        }

        public bool OfExpend(double sum)
        {
            if (HasError) return false;
            return _printer.ServiceInputOutput(0 - sum);
        }

        public int ZReport()
        {
            if (HasError) return -1;

            //_printer.OperatorsReport();
            //if (HasError) return -1;

            decimal forIn = _printer.CashInfo.BalanceEnd;

            if (HasError) return -1;
            this.SetPrinterCashInfo();

            int res = _printer.PrintZReport();
            _printer.ServiceInputOutput((double)forIn);

            decimal val = _printer.CashInfo.OfIncome;

            this.SetPrinterCashInfo();
            return res;
        }

        public bool ZPeriodReport(DateTime start, DateTime end)
        {
            if (HasError) return false;
            bool res = _printer.PeriodZReport(start, end);

            this.SetPrinterCashInfo();
            return res;
        }

        public bool ZPeriodReport(int start, int end)
        {
            if (HasError) return false;

            bool res = _printer.PeriodZReport(start, end);
            this.SetPrinterCashInfo();
            return res;
        }
        #endregion

        #region private member
        private bool SetPrinterCashInfo()
        {
            _printerCashInfo.NumZ = -1;
            _printerCashInfo.BalanceBegin = _printer.CashInfo.OfIncome;
            _printerCashInfo.OfExpend = _printer.CashInfo.OfExpend;
            _printerCashInfo.BalanceEnd = _printer.CashInfo.BalanceEnd;
            _printerCashInfo.Income = _printer.CurrentZReport.sumA + _printer.CurrentZReport.sumD;
            _printerCashInfo.LastCheckSum = _printer.CheckInfo.sumCheck;
            _printerCashInfo.LastCheckNum = _printer.CheckInfo.numCheck;
            _printerCashInfo.LastCustomerCash = _printer.CheckInfo.cashCustomer;

            return _printer.HasError;
        }
        #endregion
    }
}
