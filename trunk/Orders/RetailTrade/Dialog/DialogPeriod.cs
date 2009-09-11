using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RetailTradeOrders.Dialog
{
    public partial class DialogPeriod : Form
    {

        private TimeSpan _Days;

        public int Days
        {
            get
            {

                _Days = _EndDate - _StartDate ;
                
                return _Days.Days; }
            
        }

        private DateTime _StartDate;

        public DateTime StartDate
        {
            get { return _StartDate; }
            set { _StartDate = value; }
        }
        private DateTime _EndDate;

        public DateTime EndDate
        {
            get { return _EndDate; }
            set { _EndDate = value; }
        }


        public DialogPeriod()
        {
            InitializeComponent();
            _StartDate = DateTime.Today;
            _EndDate = DateTime.Today;

            this.StartDateEdit.DataBindings.Add(new Binding("Value",this,"StartDate"));
            this.EndDateEdit.DataBindings.Add(new Binding("Value",this,"EndDate"));
            this.labelDiff.DataBindings.Add(new Binding("Text",this,"Days"));


        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (_StartDate > _EndDate)
            {
                this.errorProvider.SetError(this.StartDateEdit,"Неверно задан период!");
                this.DialogResult = DialogResult.None;

            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }

        }
    }
}