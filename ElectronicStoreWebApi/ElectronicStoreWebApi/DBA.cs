using ElectronicStoreWebApi.Controllers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ElectronicStoreWebApi
{
    public class DBA
    {
        public SqlConnection conn { get; set; }
        public DBA()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["storeDbConnection"].ConnectionString);
        }

        public DataTable ReadAll(string query)
        {
            SqlDataReader dr;
            SqlCommand cmd = new SqlCommand(query,conn);
            conn.Open();
            dr=cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            conn.Close();
            return dt;
        }

        public bool Login(Login Login)
        {
            if(conn.State== ConnectionState.Closed)
            conn.Open();
            SqlCommand cmd = new SqlCommand("select dbo.fnIsValidUser(@Email,@Password)", conn);
            //cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Email", Login.Email);
            cmd.Parameters.AddWithValue("@Password", Login.Password);

            var result =(int) cmd.ExecuteScalar();
            if (result == 1)
                return true;
            return false;
        }

        //public int IUD(string query)
        //{

        //}
    }
}