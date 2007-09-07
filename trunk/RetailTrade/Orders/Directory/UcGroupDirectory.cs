using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;

namespace RetailTrade
{
    public partial class UcGroupDirectory : UserControl
    {
       

        public UcGroupDirectory()
        {
            InitializeComponent();
        }
        public UcGroupDirectory(DataTable source)
        {
            InitializeComponent();

            this.bindingSource.DataSource = source;
            this.grid.DataSource = this.bindingSource;
            this.colGroupRef.FieldName =source.Columns[2].ColumnName;
            if  (source.ParentRelations.Count>0)
              
           this.LookUpEdit.DataSource=source.ParentRelations[0].ParentTable;
        }

        private MainForm FindMainForm(Form sender)
        { 
             if ((sender as MainForm)!=null)
            return (sender as MainForm);
            else 
               return  FindMainForm (sender.Owner); 
        }

        private bool SaveChange()
        {


            DataTable dt = (this.bindingSource.DataSource as DataTable);

            if (dt.GetChanges() != null)
            {
               DialogResult result;


               result = MessageBox.Show(this, "��������� ���������?",this.Tag.ToString(), MessageBoxButtons.YesNoCancel,
               
                   MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);



               if (result == DialogResult.Yes)
               {

                   /*��������� ��������*/
                   FindMainForm(this.ParentForm).SaveToBaseDirectoryDeleted(dt.Select(null, null, DataViewRowState.Deleted));

                   /*��������� ���������*/

                   FindMainForm(this.ParentForm).SaveToBaseDirectoryModifed(dt.Select(null, null, DataViewRowState.ModifiedCurrent));
                   DataTable tbChahges1 = dt.GetChanges(DataRowState.Modified);
                   /*��������� ����������*/
                   FindMainForm(this.ParentForm).SaveToBaseDirectoryModifed(dt.Select(null, null, DataViewRowState.Added));

                   (this.bindingSource.DataSource as DataTable).AcceptChanges();
                  
                   dt.AcceptChanges();
                   return true;

               }
               else
                   if (result == DialogResult.No)
                   {
                       dt.RejectChanges();
                       return true;
                   }
                   else return false;
            }

            return true;
            
        }

        private void gridView_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            this.gridView.SetColumnError(this.gridView.Columns[1], e.ErrorText.ToString());
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            this.grid.EmbeddedNavigator.Buttons.Append.DoClick();
            this.btEdit.PerformClick();
        
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            this.gridView.OptionsBehavior.Editable = true;
            this.grid.EmbeddedNavigator.Buttons.Edit.DoClick();
            this.btEdit.Enabled = false;
            this.btSave.Enabled = true;
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            int hendl = (this.grid.FocusedView as ColumnView).FocusedRowHandle;

            if (this.gridView.IsValidRowHandle(hendl) & hendl != DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
            {
                int countChild = 0;


                DataRow[] arrRows;
                DataRow mrow = (this.grid.FocusedView as ColumnView).GetDataRow(hendl);

                foreach (DataRelation relation in (this.bindingSource.DataSource as DataTable).ChildRelations)
                {

                    if (mrow.GetChildRows(relation) != null)
                    {
                        arrRows = mrow.GetChildRows(relation);

                        countChild += arrRows.Length;
                    }

                }

                if (countChild != 0)

                    MessageBox.Show("���������� ������� ������, ������ �� ��� :  " + countChild.ToString(),this.Tag.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                else

                    if (MessageBox.Show(" ������� ������? " , this.Tag.ToString(),
                         MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                         == DialogResult.Yes)
                    {
                        this.grid.EmbeddedNavigator.Buttons.Remove.DoClick();
                        this.btSave.Enabled = true;
                    }
            }


        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.grid.EmbeddedNavigator.Buttons.EndEdit.DoClick();

            if (this.SaveChange())
            {
                if ((this.ParentForm as MainForm) != null)
                    (this.ParentForm as MainForm).tabControl.TabPages.Remove((this.ParentForm as MainForm).tabControl.SelectedTab);
           }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            this.grid.EmbeddedNavigator.Buttons.EndEdit.DoClick();

            if (this.gridView.HasColumnErrors) return;

            this.btEdit.Enabled = true;
            this.btSave.Enabled = false;
            this.gridView.OptionsBehavior.Editable = false;


            if (this.SaveChange())
            {
                this.btEdit.Enabled = true;
                this.btSave.Enabled = false;

            }
            else
            {
                this.btEdit.Enabled = false;
                this.btSave.Enabled = true;
                this.gridView.OptionsBehavior.Editable = true;
            }

        }

        private void UcGroupDirectory_Validated(object sender, EventArgs e)
        {
            if (!this.SaveChange())
                MessageBox.Show("������ ����������!!!");
        }

        private void btViewDict_Click(object sender, EventArgs e)
        {
            FormDialog dform = new FormDialog();
            dform.Text =this.Tag.ToString()+" : ������" ;
            
            UCSimpleDirectory ucSimpleDirectory = new UCSimpleDirectory((this.bindingSource.DataSource as DataTable).ParentRelations[0].ParentTable );
         
            dform.panel.Controls.Add(ucSimpleDirectory);

                        
            if (DialogResult.OK == dform.ShowDialog(this))
            {
                  MessageBox.Show(ucSimpleDirectory.gridView.GetDataRow(ucSimpleDirectory.gridView.GetSelectedRows()[0])["ID"].ToString());
              //  (this.Controls.Find((sender as Button).Tag.ToString() + "lookUpEdit", true)[0] as DevExpress.XtraEditors.LookUpEdit).EditValue = ucSimpleDirectory.gridView.GetDataRow(ucSimpleDirectory.gridView.GetSelectedRows()[0])["ID"];
            }
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            this.btEdit.PerformClick();
        }

        private void btField_Click(object sender, EventArgs e)
        {
            this.gridView.ColumnsCustomization();
        }

    }
}
