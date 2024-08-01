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
            string starttime = dtpStartTime.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string endtime = dtpEndTime.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string description = txtDescription.Text;
            string priority = getSelectedPriority();
            bool isChecked = false;

            if (DateTime.Parse(starttime) > DateTime.Parse(endtime))
            {
                MessageBox.Show("Start time cannot be later than End time. Please select a valid time range.", "Invalid Time Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (description!= "")
                {
                    int id = GetTaskIdByStartTime(starttime);
                    if (id > 0)
                    {
                        // Update existing task
                        TaskDAO.Instance.updateTask(id, starttime, endtime, description, priority, isChecked);
                    }
                    else
                    {
                        // Add new task
                        TaskDAO.Instance.addTask(starttime, endtime, description, priority, isChecked);
                    }
                    LoadDataToListView();
                }
                else
                {
                    MessageBox.Show("Please enter description!");
                }
             
            }
            ClearDetailControls();
        }
        public int GetTaskIdByStartTime(string startTime)
        {
            string query = $"SELECT Id FROM Tasks WHERE StartTime = '{startTime}'";
            object result = DataProvider.Instance.ExecuteScalar(query);
            return result != null ? Convert.ToInt32(result) : -1;
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
            dtpStartTime.Value = DateTime.Now;
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
                dtpStartTime.Text = selectedItem.SubItems[0].Text;
                dtpEndTime.Text = selectedItem.SubItems[1].Text;
                txtDescription.Text = selectedItem.SubItems[2].Text;
                string priority = selectedItem.SubItems[3].Text;

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
            else
            {
                ClearDetailControls();
            }

        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            if (lvwToday.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvwToday.SelectedItems[0];
                lvwToday.Items.Remove(selectedItem);
                string startTime = selectedItem.SubItems[0].Text;
                TaskDAO.Instance.deleteTask(startTime);
                txtDescription.Clear();
                rdo1.Checked = false;
                rdo2.Checked = false;
                rdo3.Checked = false;
                rdo4.Checked = false;
                LoadDataToListView();
            }
            else
            {
                MessageBox.Show("Out of items to delete.");
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
                    row["EndTime"].ToString(),
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
