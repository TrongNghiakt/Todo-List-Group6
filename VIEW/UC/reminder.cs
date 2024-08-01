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
    public partial class reminder : UserControl
    {
        public reminder()
        {
            InitializeComponent();
            dtpReminder.ValueChanged += dtpReminder_ValueChanged;
            LoadTaskByDate(dtpReminder.Value);
            Timer timer = new Timer();
            timer.Interval = 60000; 
            timer.Tick += new EventHandler(tmrReminder_Tick);
            timer.Start();
        }
        private void LoadTaskByDate(DateTime selectedDate)
        {
            lvwReminder.Items.Clear();
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
                    var listViewItem = new ListViewItem(listViewRow);
                    lvwReminder.Items.Add(listViewItem);
                }
            }
            lvwReminder.Refresh();

        }

        private void dtpReminder_ValueChanged(object sender, EventArgs e)
        {
            LoadTaskByDate(dtpReminder.Value);
        }

        private void tmrReminder_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            foreach (ListViewItem item in lvwReminder.Items)
            {
                DateTime deadline;
                bool isValidDate = DateTime.TryParse(item.SubItems[1].Text, out deadline);

                if (isValidDate)
                {

                    if (deadline <= now.AddMinutes(5) && deadline > now) 
                    {
                        MessageBox.Show($"The task '{item.SubItems[2].Text}' is comming soon at {deadline}.", "Remind");
                    }
                }
            }
        }
    }
}
