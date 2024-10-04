﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace CRUD_Forms_Prototype
{
    internal class SQLServerDBCon : DatabaseConnection
    {
        SqlConnection connection;
        public SQLServerDBCon(string server, string username, string password, string database, bool trustedConnection)
        {
            string connectionString =
                $"Server={server};" +
                $"Database={database};" +
                $"User ID={username};" +
                $"Password={password};" +
                $"Trusted_Connection={trustedConnection}"; //Set To False If Using SQL Authentication

            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                MessageBox.Show("SQL Server Successfully Connected");
                connection.Close();
            }
            catch (SqlException ex) 
            {
                MessageBox.Show("SQL Server Error: " + ex.Message);
            }
        }
        public override void Dispose()
        {
            if (connection != null)
            {
                connection.Close();
                connection.Dispose();
            }
        }

        public override bool query(string query)
        {
            try
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
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
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Server Error: " + ex.Message);
                return false;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        public override Dictionary<string, string> requestDescription(string table)
        {
            Dictionary<string, string> tableDescription = new Dictionary<string, string>();
            string query = $"DESCRIBE {table};";

            try
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string colName = reader["Field"].ToString();
                            string colType = reader["Type"].ToString();
                            tableDescription.Add(colName, colType);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Server Error: " + ex.Message);
                return tableDescription = null;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return tableDescription;
        }

        public override DataTable requestAllRecords(string table)
        {
            DataTable dt = new DataTable();
            string query = $"SELECT * FROM {table};";
            try
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Server Error: " + ex.Message);
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