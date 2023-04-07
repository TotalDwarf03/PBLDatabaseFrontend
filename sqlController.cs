using PBLDatabaseFrontend.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PBLDatabaseFrontend
{
    class SQLController
    {
        SQLiteConnection conn = new SQLiteConnection(@"Data Source=pontybrynlibrary.db");
        SQLiteDataAdapter adapter;

        /// <summary>
        /// Executes Select Statements
        /// </summary>
        /// <param name="query">The query you want to run</param>
        /// <returns>A data table containing the query results</returns>
        public DataTable RunQuery(string query)
        {
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
        /// Execute Table functions such as Update or Insert
        /// </summary>
        /// <param name="nonQuery">The table function statement (i.e update)</param>
        /// <param name="parameterMap">The list of parameters using the customer ParameterMap data class (Optional)</param>
        /// <returns>The number of records changed</returns>
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

        /// <summary>
        /// Checks if Database exists - if it doesn't, create the database and populate it with default data
        /// </summary>
        public void InitialiseDatabase()
        {
            if (!File.Exists("pontybrynlibrary.db"))
            {
                SQLiteConnection.CreateFile("pontybrynlibrary.db");

                conn.Open();
                SQLiteCommand cmd = conn.CreateCommand();

                // This file contains an exported version of the SQL Database off BlackBoard
                cmd.CommandText = Resources.pontybrynlibrarySETUP;

                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        /// <summary>
        /// Applies the changes made in a given Data Table to the respective SQL Database Table
        /// </summary>
        /// <param name="dt">The Datatable to copy across</param>
        public void CopyDTtoDB(DataTable dt)
        {
            conn.Open();

            using(SQLiteCommandBuilder builder = new SQLiteCommandBuilder(adapter))
            {
                adapter.Update(dt);
            }
        }
    }
}
