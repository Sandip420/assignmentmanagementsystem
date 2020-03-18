using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace AssignmentDB_Project
{
    public class dbconnection
    {
        public static SqlConnection DBConnect()
        {
            var conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-O920FT4\\SQLEXPRESS;Initial Catalog=AssignmentDB;Integrated Security=True";
            if(conn.State !=ConnectionState.Open)
            {
                conn.Open();
            }
            return conn;
        }

        public static DataTable GetTableByQuery(string SqlQuery)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = DBConnect();
                command.CommandText = SqlQuery;
                command.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
                //MessageBox.Show(ex.ToString()); 
            }
        }
        public static void ExecuteNonQuery(string SqlQuery)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = DBConnect();
                command.CommandText = SqlQuery;
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
