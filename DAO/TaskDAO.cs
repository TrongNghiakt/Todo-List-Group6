using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todolist.DAO
{
    internal class TaskDAO
    {
        private static TaskDAO instance;
        public static TaskDAO Instance
        {
            get { if (instance == null) instance = new TaskDAO(); return instance; }
            private set { instance = value; }
        }


        public TaskDAO() { }

        public DataTable listTask()
        {
            string query = "select StartTime,Title,Description,Priority from Tasks";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public void updateTask(DateTime StartTime, string Title, string Description,string Priority)
        {
            string query = "update tasks set Time = '" + StartTime + "', Title = N'"+Title +"', Description = N'"+Description+ "', Priority = '" + Priority+"'";
            DataProvider.Instance.ExecuteNonQuery(query);
        }


    }
}
