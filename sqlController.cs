using PBLDatabaseFrontend.Properties;
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

        public DataTable executeSQL(string query)
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
    }
}
