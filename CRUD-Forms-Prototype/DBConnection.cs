using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CRUD_Forms_Prototype
{
    internal class DBConnection : IDisposable
    {
        public MySqlConnection connection;

        public DBConnection(string server, string username, string password, string database)
        {
            string connectionString =
                $"Server={server};" +
                $"Database={database};" +
                $"User ID={username};" +
                $"Password={password};" +
                $"SslMode=none;";

            try
            {
                connection = new MySqlConnection(connectionString);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Error:" + ex.Message);
            }
        }

        public void Dispose()
        {
            if (connection != null)
            {
                connection.Close();
                connection.Dispose();
            }
        }

        //Query Functions
        public bool query(string query)
        {
            try
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Error: " + ex.Message);
                return false;
            }
            finally
            {
                if(connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        public Dictionary<string, string> requestDescription(string table)
        {
            Dictionary<string, string> tableDescription = new Dictionary<string, string>();
            string query = $"DESCRIBE {table};";

            try
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            string colName = reader["Field"].ToString();
                            string colType = reader["Type"].ToString();
                            tableDescription.Add(colName, colType);
                        }
                    }
                }
            }
            catch(MySqlException ex) 
            {
                MessageBox.Show("MySQL Error: " + ex.Message);
                return tableDescription = null;
            }
            finally
            {
                if(connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return tableDescription;
        }
        public DataTable requestAllRecords(string table)
        {
            DataTable dt = new DataTable();
            string query = $"SELECT * FROM {table};";
            try
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Error: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return dt;
        }
    }
}