using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebSockets;
using System.Windows.Forms;
using System.Xml.Linq;
using todolist.DAO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace todolist.VIEW.UC
{
    public partial class today : UserControl
    {
        
        public today()
        {
            InitializeComponent();
            LoadDataToListView();
            lvwToday.SelectedIndexChanged += lvwToday_SelectedIndexChanged;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string time = dtp2.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string description = txtDescription.Text;
            string priority = getSelectedPriority();

            DateTime date1 = dtp1.Value.Date;
            DateTime date2 = dtp2.Value.Date;
            if(description != "")
            {
                 if (TaskDAO.Instance.checkedTask(time))
                 {
                        TaskDAO.Instance.updateTask(time, description, priority);
                        LoadDataToListView();
                 }
                 else
                 {
                        TaskDAO.Instance.addTask(time, description, priority);
                        LoadDataToListView();
                 }
            }
            else
            {
                 MessageBox.Show("Please enter description!");
            }
            ClearDetailControls();
        }


        private string getSelectedPriority()
        {
            if (rdo1.Checked)
                return "I";
            if ( rdo2.Checked)
                return "II";
            if (rdo3.Checked)
                return "III";
            if (rdo4.Checked)
                return "IV";
            return string.Empty;
        }
        private void ClearDetailControls()
        {
            dtp2.Value = DateTime.Now;
            txtDescription.Clear();
            rdo1.Checked = false;
            rdo2.Checked = false;
            rdo3.Checked = false;
            rdo4.Checked = false;
        }



        private void lvwToday_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwToday.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvwToday.SelectedItems[0];
                dtp2.Text = selectedItem.SubItems[0].Text;
                txtDescription.Text = selectedItem.SubItems[1].Text;
                string priority = selectedItem.SubItems[2].Text;

                if(priority == "I")
                {
                    rdo1.Checked = true;
                }
                else if(priority == "II")
                {
                    rdo2.Checked = true;
                }
                else if (priority == "III")
                {
                    rdo3.Checked = true;
                }
                else if (priority == "IV")
                {
                    rdo4.Checked = true;
                }
                else
                {
                    rdo1.Checked = false;
                    rdo2.Checked = false;
                    rdo3.Checked = false;
                    rdo4.Checked = false;
                }
            }

        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            if (lvwToday.SelectedItems.Count > 0)
            {
                lvwToday.Items.Remove(lvwToday.SelectedItems[0]);

                TaskDAO.Instance.deleteTask(dtp2.Value.ToString());
                txtDescription.Clear();
                rdo1.Checked = false;
                rdo2.Checked = false;
                rdo3.Checked = false;
                rdo4.Checked = false;
                LoadDataToListView();
            }
            else
            {
                MessageBox.Show("Please select an item to delete.");
            }
        }
        private void LoadDataToListView()
        {

            lvwToday.Items.Clear();

            DataTable todayTasks = TaskDAO.Instance.listTask();

            foreach (DataRow row in todayTasks.Rows)
            {
                string[] listViewRow =
                {
                    row["StartTime"].ToString(),
                    row["Description"].ToString(),
                    row["Priority"].ToString()
                };
                var listViewItem = new ListViewItem(listViewRow);
                lvwToday.Items.Add(listViewItem);
            }

            lvwToday.Refresh();
        }

    }
}
