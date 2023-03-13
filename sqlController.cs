﻿using PBLDatabaseFrontend.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBLDatabaseFrontend
{
    class SQLController
    {
        SQLiteConnection conn = new SQLiteConnection(@"Data Source=Resources\\pontybrynlibrary.db");

        /// <summary>
        /// 
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public DataTable RunQuery(string query)
        {
            SQLiteDataAdapter adapter;
            DataTable dt = new DataTable();

            try
            {
                SQLiteCommand cmd;

                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = query;
                adapter = new SQLiteDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch(SQLiteException ex)
            {
                Debug.WriteLine(ex.Message);
            }

            conn.Close();
            return dt;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nonQuery"></param>
        /// <param name="parameterMap"></param>
        /// <returns></returns>
        public int RunNonQuery(string nonQuery, List<ParameterMap> parameterMap)
        {
            int recordsChanged = 0;

            try
            {
                SQLiteCommand cmd;

                conn.Open();

                cmd = conn.CreateCommand();
                cmd.CommandText=nonQuery;

                foreach(ParameterMap param in parameterMap)
                {
                    cmd.Parameters.AddWithValue(param.parameterName, param.parameterValue);
                }

                recordsChanged = cmd.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                Debug.WriteLine(ex.Message);
            }

            conn.Close();
            return recordsChanged;
        }
    }
}
