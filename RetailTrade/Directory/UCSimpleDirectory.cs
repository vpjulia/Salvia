using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;

namespace RetailTrade
{
    public partial class UCSimpleDirectory : UserControl
    {
        public UCSimpleDirectory()
        {
            InitializeComponent();
        }

        public UCSimpleDirectory(DataTable source)
        {
            InitializeComponent();
                      
            this.bindingSource.DataSource=source;
            this.grid.DataSource = this.bindingSource;
        }

        private void grid_Validating(object sender, CancelEventArgs e)
        {
           if (this.gridView.FocusedRowHandle == DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
            {
                this.gridView.FocusedRowHandle = 0;
                e.Cancel = true;
            }
        }


        private void btEdit_Click(object sender, EventArgs e)
        {

            this.gridView.OptionsBehavior.Editable = true;
            this.grid.EmbeddedNavigator.Buttons.Edit.DoClick();
            this.btEdit.Enabled = false;

        }

        private void bindingSource_CurrentChanged(object sender, EventArgs e)
        {
            this.btEdit.Enabled = true;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
             this.bindingSource.EndEdit();
           //  this.grid.EmbeddedNavigator.Buttons.EndEdit.DoClick();


            DataTable dt = (this.bindingSource.DataSource as DataTable);

            if (dt.GetChanges()!= null)
            {
               FormDialog fInf = new FormDialog();
               Information infcontr = new Information();
               infcontr.Dock = DockStyle.Fill;

              DataTable tbChahgesAdd = dt.GetChanges(DataRowState.Added);
              if (tbChahgesAdd != null)
                  foreach (DataRow frRow in tbChahgesAdd.Rows)
                      infcontr.listBoxInf.Items.Add("Добавить " + "'" + frRow[1, DataRowVersion.Current].ToString()+ "'");
          

               DataTable tbChahges = dt.GetChanges(DataRowState.Modified);
               if (tbChahges!=null)
                  foreach(DataRow frRow in tbChahges.Rows)
                      infcontr.listBoxInf.Items.Add("Изменить   " + "'" + frRow[1, DataRowVersion.Original].ToString() + "' на " + " '" + frRow[1, DataRowVersion.Current].ToString() + "'");


              DataTable tbChahgesDel = dt.GetChanges(DataRowState.Deleted);
              if (tbChahgesDel != null)
                  foreach (DataRow frRow in tbChahgesDel.Rows)
                      infcontr.listBoxInf.Items.Add("Удалить   " + "'" + frRow[1, DataRowVersion.Original].ToString() + "'");

                fInf.Size = new System.Drawing.Size((Screen.PrimaryScreen.WorkingArea.Width / 3), (Screen.PrimaryScreen.WorkingArea.Height/2));
              
                 fInf.panel.Controls.Add(infcontr);

              if (DialogResult.OK == fInf.ShowDialog(this.ParentForm))
                {
                    MessageBox.Show("DialogResult.OK");
               
                  /*сохранить изменения*/
                  
                  /*сохранить добавления*/
                 
                  /*сохранить удаление*/
                  

                }

            }
          }

        private void gridView_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            this.gridView.SetColumnError(this.gridView.Columns[1], e.ErrorText.ToString());
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
             this.grid.EmbeddedNavigator.Buttons.Append.DoClick();
        
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            this.grid.EmbeddedNavigator.Buttons.Append.DoClick();
        
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.grid.Focus();
            this.gridView.FocusedColumn = this.gridView.Columns[1];
            this.gridView.FocusedRowHandle = 0; 
          
        }

        private void grid_DoubleClick(object sender, EventArgs e)
        {if  (this.ParentForm.ToString()=="FormDialog")
            (this.ParentForm as FormDialog).AcceptButton.PerformClick();
        }

        private void grid_EditorKeyDown(object sender, KeyEventArgs e)
        {
            if((e.KeyCode==Keys.Enter)&(this.gridView.State==GridState.Normal)) 
                (this.ParentForm as FormDialog).AcceptButton.PerformClick();
        }
    }
}
