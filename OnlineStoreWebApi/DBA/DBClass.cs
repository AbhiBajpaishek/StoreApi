using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace OnlineStoreWebApi.DBA
{
    public class DBClass
    {
        public SqlConnection conn { get; set; }

        public DBClass()
        {
            conn = new 
                SqlConnection(ConfigurationManager.ConnectionStrings["StoreDbConnection"].ConnectionString);
        }

        public bool Login(string email, string password)
        {
            conn.Open();
            string query = "select dbo.fnIsValidUser(@ID,@password)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", email);
            cmd.Parameters.AddWithValue("@password", password);
            int count = cmd.ExecuteNonQuery();
            conn.Close();
            if (count == 1)
                return true;
            return false;
        }
           

    }

    
}