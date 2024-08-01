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

namespace todolist.VIEW.UC
{
    public partial class priority : UserControl
    {
        public priority()
        {
            InitializeComponent();
            dtpPriority.ValueChanged += dateTimePicker1_ValueChanged;
            LoadTaskByDate(dtpPriority.Value);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LoadTaskByDate(dtpPriority.Value);
        }
    
        private void LoadTaskByDate(DateTime selectedDate)
        {
            lvwPriority.Items.Clear();
            DataTable todayTasks = TaskDAO.Instance.listTask();
            foreach (DataRow row in todayTasks.Rows)
            {
                DateTime taskDateTime = DateTime.Parse(row["StartTime"].ToString());
                DateTime endDateTime = DateTime.Parse(row["EndTime"].ToString());

                if (taskDateTime.Date == selectedDate.Date)
                {
                    string[] listViewRow =
                {
                    row["Priority"].ToString(),
                    taskDateTime.ToString("HH:mm:ss"),
                    endDateTime.ToString("HH:mm:ss"),
                    row["Description"].ToString(),
                };
                    var listViewItem = new ListViewItem(listViewRow);
                    lvwPriority.Items.Add(listViewItem);
                }
            }
            lvwPriority.Refresh();

        }

        private void btnHighest_Click(object sender, EventArgs e)
        {
            SortHighestListViewByPriority();
        }
        private void SortHighestListViewByPriority()
        {
            var items = lvwPriority.Items.Cast<ListViewItem>().ToList();
            var priorityOrder = new List<string> { "IV", "III", "II", "I",""};
            items = items.OrderBy(item => priorityOrder.IndexOf(item.SubItems[0].Text)).ToList();
            lvwPriority.Items.Clear();
            lvwPriority.Items.AddRange(items.ToArray());
            lvwPriority.Refresh();
        }

        private void btnLowest_Click(object sender, EventArgs e)
        {
            SortLowestListViewByPriority();
        }
        private void SortLowestListViewByPriority()
        {
            var items = lvwPriority.Items.Cast<ListViewItem>().ToList();
            var priorityOrder = new List<string> { "IV", "III", "II", "I", ""};
            items = items.OrderByDescending(item => priorityOrder.IndexOf(item.SubItems[0].Text)).ToList();
            lvwPriority.Items.Clear();
            lvwPriority.Items.AddRange(items.ToArray());
            lvwPriority.Refresh();
        }
    }
}
