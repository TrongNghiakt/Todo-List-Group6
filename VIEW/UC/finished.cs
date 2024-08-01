using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using todolist.DAO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace todolist.VIEW.UC
{
    public partial class finished : UserControl
    {
        private Dictionary<string, bool> checkedItems = new Dictionary<string, bool>();
        public finished()
        {
            InitializeComponent();
            dtpMyPlan.ValueChanged += dateTimePicker1_ValueChanged;
            LoadTaskByDate(dtpMyPlan.Value);
            lvwMyPlan.ItemChecked += lvwMyPlan_ItemChecked;
        }

        private void LoadTaskByDate(DateTime selectedDate)
        {

            lvwMyPlan.Items.Clear();
            DataTable todayTasks = TaskDAO.Instance.listTask();

            foreach (DataRow row in todayTasks.Rows)
            {
                DateTime taskDateTime = DateTime.Parse(row["StartTime"].ToString());
                DateTime endDateTime = DateTime.Parse(row["EndTime"].ToString());

                if (taskDateTime.Date == selectedDate.Date)
                {
                    string[] listViewRow =
                    {
                         taskDateTime.ToString("HH:mm:ss"),
                         endDateTime.ToString("HH:mm:ss"),
                         row["Description"].ToString(),
                         row["Priority"].ToString(),
                     };

                    var listViewItem = new ListViewItem(listViewRow)
                    {
                        Checked = row["IsChecked"] != DBNull.Value ? Convert.ToBoolean(row["IsChecked"]) : false,
                        Tag = row["Id"].ToString()
                    };

                    lvwMyPlan.Items.Add(listViewItem);
                }
            }
            lvwMyPlan.Refresh();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LoadTaskByDate(dtpMyPlan.Value);
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool checkState = chkSelectUnselect.Checked;
            foreach (ListViewItem item in lvwMyPlan.Items)
            {
                item.Checked = checkState;

                // Cập nhật trạng thái checkbox vào cơ sở dữ liệu
                string key = item.SubItems[0].Text + "|" + item.SubItems[1].Text;
                int id = GetTaskIdByKey(key); // Cần phương thức để lấy id từ key
                if (id > 0)
                {
                    TaskDAO.Instance.updateTask(id, item.SubItems[0].Text, item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text, checkState);
                }
            }
        }
        private int GetTaskIdByKey(string key)
        {
            string[] parts = key.Split('|');
            if (parts.Length == 2)
            {
                string startTime = parts[0];
                string endTime = parts[1];

                string query = $"SELECT Id FROM Tasks WHERE StartTime = '{startTime}' AND EndTime = '{endTime}'";
                object result = DataProvider.Instance.ExecuteScalar(query);
                return result != null ? Convert.ToInt32(result) : -1;
            }
            return -1;
        }

        private void lvwMyPlan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void lvwMyPlan_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            ListViewItem item = e.Item;
            bool isChecked = item.Checked;

            // Giả định bạn có một cách để lấy id của task từ ListViewItem. Có thể là từ Text hoặc Tag
            int taskId = int.Parse(item.Tag.ToString()); // hoặc item.SubItems[x].Text nếu id là một trong các cột

            // Cập nhật cơ sở dữ liệu với trạng thái mới của checkbox
            TaskDAO.Instance.UpdateTaskCheckedState(taskId, isChecked);
        }
    }
}


