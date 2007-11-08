using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace RetailTrade.Printers
{
    class Datecs
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public unsafe struct RetData
        {
            unsafe int Count;
            unsafe int CmdMode;
            unsafe IntPtr UserData;
            unsafe IntPtr Status;
            [MarshalAs(UnmanagedType.LPStr)]
            unsafe String CmdName;
            [MarshalAs(UnmanagedType.LPStr)]
            unsafe String SendStr;
            [MarshalAs(UnmanagedType.LPStr)]
            unsafe String Whole;
            [MarshalAs(UnmanagedType.LPStr)]
            unsafe String RetItem0;
            [MarshalAs(UnmanagedType.LPStr)]
            unsafe String RetItem1;
            [MarshalAs(UnmanagedType.LPStr)]
            unsafe String RetItem2;
            [MarshalAs(UnmanagedType.LPStr)]
            unsafe String RetItem3;
            [MarshalAs(UnmanagedType.LPStr)]
            unsafe String RetItem4;
            [MarshalAs(UnmanagedType.LPStr)]
            unsafe String RetItem5;
            [MarshalAs(UnmanagedType.LPStr)]
            unsafe String RetItem6;
            [MarshalAs(UnmanagedType.LPStr)]
            unsafe String RetItem7;
            [MarshalAs(UnmanagedType.LPStr)]
            unsafe String RetItem8;
            [MarshalAs(UnmanagedType.LPStr)]
            unsafe String RetItem9;
            [MarshalAs(UnmanagedType.LPStr)]
            unsafe String RetItem10;
            [MarshalAs(UnmanagedType.LPStr)]
            unsafe String RetItem11;
            [MarshalAs(UnmanagedType.LPStr)]
            unsafe String RetItem12;
            [MarshalAs(UnmanagedType.LPStr)]
            unsafe String RetItem13;
            [MarshalAs(UnmanagedType.LPStr)]
            unsafe String RetItem14;
            [MarshalAs(UnmanagedType.LPStr)]
            unsafe String RetItem15;
            [MarshalAs(UnmanagedType.LPStr)]
            unsafe String RetItem16;
            [MarshalAs(UnmanagedType.LPStr)]
            unsafe String RetItem17;
            [MarshalAs(UnmanagedType.LPStr)]
            unsafe String RetItem18;
            [MarshalAs(UnmanagedType.LPStr)]
            unsafe String RetItem19;

            [MarshalAs(UnmanagedType.I1)]
            unsafe char OrigStat0;
            [MarshalAs(UnmanagedType.I1)]
            unsafe char OrigStat1;
            [MarshalAs(UnmanagedType.I1)]
            unsafe char OrigStat2;
            [MarshalAs(UnmanagedType.I1)]
            unsafe char OrigStat3;
            [MarshalAs(UnmanagedType.I1)]
            unsafe char OrigStat4;
            [MarshalAs(UnmanagedType.I1)]
            unsafe char OrigStat5;

        }

        public delegate int CallbackDef(ref RetData IParam);


        [DllImport("fpl.dll")]
        private static extern int InitFPport(int i1, int i2);

        [DllImport("fpl.dll")]
        private static extern int CloseFPport();

        [DllImport("fpl.dll")]
        private static extern int GetStatus(int hWnd, CallbackDef callback, int lParam, [MarshalAs(UnmanagedType.Bool)] bool noWait);
        
        [DllImport("fpl.dll")]
        private static extern int PrintNonfiscalText(int hWnd, CallbackDef callback, int lParam, [MarshalAs(UnmanagedType.LPStr)] string Text);
        [DllImport("fpl.dll")]
        private static extern int ProgrammingArticle(int hWnd, CallbackDef callback, int lParam,char tax, int numArt, int group, double price,[MarshalAs(UnmanagedType.LPStr)] string psw, [MarshalAs(UnmanagedType.LPStr)] string name);
        [DllImport("fpl.dll")]
       
        private static extern int OpenFiscalReceipt(int hWnd, CallbackDef callback, int lParam, [MarshalAs(UnmanagedType.I4)] int _operator, [MarshalAs(UnmanagedType.LPStr)] string Text,[MarshalAs(UnmanagedType.I4)] int tillnumber , bool taxcheck );
        [DllImport("fpl.dll")]
        private static extern int SaleArticle(int hWnd, CallbackDef callback, int lParam, bool sign, int numArt, double qwant, double perc, double dc);

      
        public static int Result(ref RetData i)
        {

            return 1;

        }

        public bool Init() 
        {
            int res = InitFPport(1, 19200);
            if (res == 1)
                return true;
            else
                return false;
        }

        public bool Close()
        {
            int res = CloseFPport();
            if (res == 1)
                return true;
            else
                return false;
        }

        public int PrintNonfiscalText(string Text)
        {
            CallbackDef callback = new CallbackDef(Result);
            try
            {
                unsafe
                {
                    int r = PrintNonfiscalText(0, callback, 0,Text);
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            return 1;
           
        }

        public int GetStatus()
        {
            CallbackDef callback = new CallbackDef(Result);
            try
            {
                unsafe
                {
                    int r = GetStatus(0, callback, 0, false);
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            return 1;
            
        }

        public int AddArticle()
        {
            CallbackDef callback = new CallbackDef(Result);
            try
            {
                unsafe
                {
                    int r = ProgrammingArticle(0, callback, 0, "A".ToCharArray()[0],1,1,2.5,"0000","Article1");
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            return 1;
        }

        public int OpenCheck ()
        {
            CallbackDef callback = new CallbackDef(Result);
            try
            {
                unsafe
                {
                    int r = OpenFiscalReceipt(0, callback, 0,1,"0000",1,true);
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            return 1;

        }

        public int SaleArticle()
        {
            CallbackDef callback = new CallbackDef(Result);
            try
            {
                unsafe
                {
                    int r = SaleArticle(0, callback, 0, true, 1, 2,0,0);
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            return 1;
        
        
        }
    }
}
