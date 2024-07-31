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
            string query = "select * from Tasks";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
        public void updateTask(string Time, string Description,string Priority)
        {
            string query = "update tasks set Description = N'"+Description+ "', Priority = '" + Priority+ "' where StartTime = '"+Time+"'";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int addTask(string StartTime, string Description, string Priority)
        {
            string query = $"insert into Tasks(starttime,description,priority) values ('{StartTime}','{Description}','{Priority}')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result;
        }
        public void deleteTask(string time)
        {
            string query = "delete tasks from tasks where starttime = '" + time + "'";
            DataProvider.Instance.ExecuteNonQuery (query);
        }
        public bool checkedTask(string starttime)
        {
            string query = "select * from tasks where starttime = '"+starttime+"'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }
    }
}
