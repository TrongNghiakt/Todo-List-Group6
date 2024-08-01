using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using todolist.VIEW.UC;

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
        public void updateTask(int id,string StartTime,string EndTime, string Description,string Priority,bool IsChecked)
        {
            string query = $"UPDATE Tasks SET StartTime = '{StartTime}', EndTime = '{EndTime}', Description = N'{Description}', Priority = '{Priority}', IsChecked = {(IsChecked ? 1 : 0)} WHERE Id = {id}";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int addTask(string StartTime,string EndTime, string Description, string Priority, bool isChecked)
        {
            string query = $"INSERT INTO Tasks (StartTime, EndTime, Description, Priority, IsChecked) VALUES ('{StartTime}', '{EndTime}', N'{Description}', '{Priority}', {(isChecked ? 1 : 0)})";
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

        public void UpdateTaskCheckedState(int taskId, bool isChecked)
        {
            string query = $"UPDATE Tasks SET IsChecked = {(isChecked ? 1 : 0)} WHERE Id = {taskId}";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
