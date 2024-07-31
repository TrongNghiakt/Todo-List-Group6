using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todolist.DAO
{
    public class DataProvider
    {
        public static DataProvider instance;
        public static string ServerName = "MSI";
        public static string DatabaseName = "ToDoListDB";
        public static string Username = "";
        public static string Password = "123";
        private string ConStr = $@"Data Source={ServerName};Initial Catalog = {DatabaseName};  Integrated Security = True; Encrypt=False";
 
        private DataProvider() { }

        public static DataProvider Instance
        {
            get
            {
                instance = new DataProvider();
                return DataProvider.instance;
            }
            private set
            {
                DataProvider.instance = value;
            }
        }

        public DataTable ExecuteQuery(string query, object[] paramenter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection conn = new SqlConnection(ConStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                if (paramenter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains(' '))
                        {
                            if (paramenter[i] != null)
                            {
                                SqlParameter parameter = new SqlParameter(item, paramenter[i]);
                                cmd.Parameters.Add(parameter);
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue(item, DBNull.Value);
                            }
                            i++;
                        }



                    }
                    

                }


                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);

                conn.Close();

            }
            return data;
        }



        public int ExecuteNonQuery(string query, object[] paramenter = null)
        {
            int data = 0;
            using (SqlConnection conn = new SqlConnection(ConStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query,conn);
                if(paramenter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach(string item in listPara)
                    {
                        if(item.Contains(' '))
                        {
                            if (paramenter[i] != null)
                            {
                                SqlParameter parameter = new SqlParameter(item, paramenter[i]);
                                cmd.Parameters.Add(parameter);
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue (item, DBNull.Value);
                            }
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteNonQuery();
                conn.Close();
            }
            return data;
        }




        public object ExecuteScalar(string query, object[] paramenter = null)
        {
            object data = 0;
            using(SqlConnection conn = new SqlConnection(ConStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand (query,conn);
                if( paramenter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach(string item in listPara)
                    {
                        if(item.Contains(' '))
                        {
                            if (paramenter[i] != null)
                            {
                                SqlParameter parameter = new SqlParameter (item, paramenter[i]);    
                                cmd.Parameters.Add(parameter);
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue(item, DBNull.Value);
                            }
                        }
                        i++;

                    }
                }
                object scalarResult = cmd.ExecuteScalar();
                if( scalarResult != DBNull.Value )

                {
                    data = scalarResult;
                }
                conn.Close();
            }
            return data;
        }

    }
}
