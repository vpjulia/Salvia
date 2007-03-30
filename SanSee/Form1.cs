using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SanSee
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private bool FindOpenedTabs(String TagControl)
        {

            for (int i = 0; i < tabControl1.TabPages.Count; i++)
            {
                if (tabControl1.TabPages[i].Tag.Equals(TagControl))
                {
                    tabControl1.SelectedTab = tabControl1.TabPages[i];
                    return true;
                }
            }
            return false;
        }
       
        private bool ShowNewDataTab(ToolStripItem sender)
        {
          string  _NameTable = Convert.ToString(sender.AccessibleName);
          string _TagControl = Convert.ToString(sender.Tag);
          string _Title = Convert.ToString(sender.ToolTipText);


            if (!FindOpenedTabs(_NameTable))
            {
              
                UserControl uc = null;

                switch (_TagControl)
                {
                    case "UCSPR":

                        uc = new UCSPR();
                        uc.Dock = DockStyle.Fill;

                        (uc as UCSPR).NameWorkTable = _NameTable;

                        //      (uc as UC1).Parent = this.ParentForm; 
                        uc.Tag =_NameTable;
                       
                        break;

                 case "UC_SPR_TOV":
                        uc = new UC_SPR_TOV();
                        uc.Dock = DockStyle.Fill;
                        (uc as UC_SPR_TOV).NameWorkTable = _NameTable;
                     
                        

                       /* this.sPR_TOVTableAdapter.Fill(this.MdataSet.SPR_TOV);

                        (uc as UC2).grid.DataSource = this.MdataSet.SPR_TOV;
                        (uc as UC2).LookUpEditIZG.DataSource = this.MdataSet.SPR_Izg;
                      */
                        uc.Tag = _NameTable;
                        break;

               /*     case "UC3":
                        uc = new UC3();

                        uc.Dock = DockStyle.Fill;
                        name = "Справочник товаров";
                        break;



                       case 2:
                             name = "Справочник 3";
                             break;*/
                    default:
                        {
                            return false;
                        }
                }
                TabPage newTab = new TabPage(_Title);
                newTab.Controls.Add(uc);
                tabControl1.TabPages.Add(newTab);
                tabControl1.TabPages[tabControl1.TabCount - 1].Tag = _NameTable;
                tabControl1.SelectedTab = newTab;

                return true;
            }

            return false;

        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            ShowNewDataTab((sender as ToolStripItem));
  
        }

     
 

    }
}