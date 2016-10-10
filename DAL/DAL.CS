using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Marina.Entity;

namespace Marina.DB
{
    class DAL
    {
        public static void ExecuteNonQuery(string sql)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = CustomerAndBoatDatabase.getAppConfig();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandText = sql;
            con.Open();
            int k = com.ExecuteNonQuery();
            con.Close();
        }

        public static object ExecuteScalar(string sql)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = CustomerAndBoatDatabase.getAppConfig();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandText = sql;
            con.Open();
            object val = com.ExecuteScalar();
            con.Close();
            return val;
        }
        public static Customer ExecuteReader(string sql)
        {
            Customer sub = new Customer();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = CustomerAndBoatDatabase.getAppConfig();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandText = sql;
            con.Open();
            SqlDataReader ds= com.ExecuteReader();
            while (ds.Read())
            {
                sub.Phoneno  = ds.GetString(2);
                sub.Address = ds.GetString(1);
                sub.Boat1 = new Boat();
                sub.Boat1.Stateregistrationno  = ds.GetString(3);
                sub.Boat1.Slipwayno   = ds.GetInt32(5);
                sub.Boat1.Manufacturer  = ds.GetString(4);
                sub.Boat1.Validity = ds.GetString(8);
            }
            con.Close();
            return sub;
        }
        public static Slipway ExecuteReader1(string sql)
        {
            Slipway sub = new Slipway();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = CustomerAndBoatDatabase.getAppConfig();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandText = sql;
            con.Open();
            SqlDataReader ds = com.ExecuteReader();
            while (ds.Read())
            {
                sub.Id = ds.GetInt32(5);
                sub.Name = ds.GetString(10);
                sub.Volume = ds.GetInt32(5);
            }
            con.Close();
            return sub;
        }

        public static DataSet ExecuteDataSet(string sql)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = CustomerAndBoatDatabase.getAppConfig();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandText = sql;
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = com;
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            return ds;
        }
    }
}
