﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DAO
{
    public class DatabaseHelper
    {
        private static bool DEBUG = false;
        private static SqlConnection sCon;
        //public static String CONNECTION_STRING { get; set; }
        private static SqlCommand mCommand;
        public static string dataSource;
        /// <summary>
        /// Open connection to Database
        /// </summary>
        /// <returns></returns>
        public static bool OpenConnection()
        {
            try
            {
                sCon = new SqlConnection(@dataSource);

                //if (sCon.State == ConnectionState.Closed)

                sCon.Open();
                return true;
                
            }
            catch
            { 
                return false;
                
            }

        }
        /// <summary>
        /// Close Connection to Database
        /// </summary>
        public static void CloseConnection()
        {
            if (sCon != null)
            {
                sCon.Close();
            }
        }

        public static String CreateConnectionString(String datasource, String databaseName)
        {
            //string sql = string.Format("Data Source=DESKTOP-F13TQRH\SQLEXPRESS; Initial Catalog = QuanLyTiecCuoi; Integrated Security = True");
            //return "Data Source = DESKTOP-F13TQRH\SQLEXPRESS; Initial Catalog = QuanLyTiecCuoi; Integrated Security = True";
            return "Data Source=" + datasource + ";Initial Catalog=" + databaseName + ";Integrated Security=True";
           
        }

        public static bool ExecuteNonQuery(string sql)
        {
            OpenConnection();

            try
            {
                SqlCommand cmd = new SqlCommand(sql, sCon);

                cmd.ExecuteNonQuery();
                CloseConnection();
                return true;
            }
            catch
            {
                return false;
            }


        }
        public static int ExcuteSql(String sql)
        {
            OpenConnection();
            int rowEffect = -1;
            mCommand = new SqlCommand();
            mCommand.Connection = sCon;
            mCommand.CommandText = sql;
            try
            {
                rowEffect = mCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                if (DEBUG)
                    Console.WriteLine(ex.Message);
                CloseConnection();
            }

            CloseConnection();
            return rowEffect;
        }

        public static DataTable GetData(String sql)
        {
            OpenConnection();
            DataTable dt = null;
            if (sCon != null)
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sql, sCon);
                dt = new DataTable();
                try
                {
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    if (DEBUG)
                        Console.WriteLine(ex.Message);
                }
            }
            CloseConnection();
            return dt;
        }

        // CheckIfExists("select * from Sanh where id = id
        public static bool CheckIfExists(string sql)
        {
            OpenConnection();
            mCommand = new SqlCommand();
            mCommand.Connection = sCon;
            mCommand.CommandText = sql;
            int rowEffect = mCommand.ExecuteNonQuery();
            CloseConnection();
            if (rowEffect > 0)
                return true;

            return false;
        }
        // CheckIfExists("select * from Sanh where id = id
        public static int CountRecord(string sql)
        {
            OpenConnection();
            mCommand = new SqlCommand();
            mCommand.Connection = sCon;
            mCommand.CommandText = sql;
            int rowEffect = (int)mCommand.ExecuteScalar();
            CloseConnection();
            return rowEffect;
        }
    }
}
