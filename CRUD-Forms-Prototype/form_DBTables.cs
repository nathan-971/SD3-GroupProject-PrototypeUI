using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CRUD_Forms_Prototype
{
    public partial class form_DBTables : Form
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        private DatabaseConnection DB;
        private string[] headerData;
        private string[] rowData;
        private string currentTable = "";
        private int cellCount = 0;

        public form_DBTables()
        {
            AllocConsole();
            //Create Database Object Depending On Engine Choice and Start Form
            using (form_EngineChoice fec = new form_EngineChoice())
            {
                if (DialogResult.OK == fec.ShowDialog())
                {
                    if (fec.MySQL)
                    {
                        InitializeComponent();
                        DB = new MySQLDBCon(
                            fec.parameters[0],
                            fec.parameters[1],
                            fec.parameters[2],
                            fec.parameters[3]);

                        FormClosing += Form_DBTables_FormClosing;
                    }
                    else
                    {
                        InitializeComponent();
                        DB = new SQLServerDBCon(
                            fec.parameters[0],
                            fec.parameters[1],
                            fec.parameters[2],
                            fec.parameters[3],
                            Convert.ToBoolean(fec.parameters[4]));

                        FormClosing += Form_DBTables_FormClosing;
                    }
                }
            }
        }
        private void form_DBTables_Load(object sender, EventArgs e)
        {
            if(DB == null)
            {
                Close();
            }
        }

        private void btn_ChangeTable_Click(object sender, EventArgs e)
        {
            using (form_TableInput inputForm = new form_TableInput(DB))
            {
                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    currentTable = inputForm.inputText.Trim();
                    if(!(currentTable == string.Empty))
                    {
                        try
                        {
                            DataTable dt = DB.requestAllRecords(currentTable);
                            DGV_TableData.DataSource = dt;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An Error Occurred: " + ex.Message);
                        }
                    }
                }
            }
            cellCount = DGV_TableData.ColumnCount;
            rowData = new string[cellCount];
            headerData = new string[cellCount];

            for (int i = 0; i < cellCount; i++)
            {
                headerData[i] = DGV_TableData.Columns[i].HeaderText;
            }
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            if(currentTable == string.Empty)
            {
                MessageBox.Show("No Table Selected");
                return;
            }
            using (form_Record rf = new form_Record(headerData))
            {
                if (rf.ShowDialog() == DialogResult.OK)
                {
                    string[] newRecord = rf.returnRecord;
                    Dictionary<string, string> tableDescription = DB.requestDescription(currentTable);
                    if (validateDataAgainstDescription(tableDescription, newRecord))
                    {
                        string query = $"INSERT INTO {currentTable} VALUES (";
                        for (int i = 0; i < newRecord.Length; i++)
                        {
                            string colType = tableDescription.Values.ElementAt(i);
                            if (colType.Contains("varchar") || colType.Contains("nvarchar") || colType.Contains("char") || colType.Contains("text"))
                            {
                                query += $"'{newRecord[i].Replace("'", "''")}'";
                            }
                            else
                            {
                                query += $"{newRecord[i]}";
                            }
                            if (i + 1 < newRecord.Length)
                            {
                                query += ", ";
                            }
                        }
                        query += ");";
                        if (DB.query(query))
                        {
                            MessageBox.Show("Successfully Created Record");
                            RefreshData();
                        }
                    }
                }
            }
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (currentTable == string.Empty)
            {
                MessageBox.Show("No Table Selected");
                return;
            }

            int currentRow = DGV_TableData.CurrentCell.RowIndex;
            for (int i = 0; i < cellCount; i++)
            {
                rowData[i] = DGV_TableData.Rows[currentRow].Cells[i].Value.ToString();
            }

            using (form_Record rf = new form_Record(headerData, rowData))
            {
                if (rf.ShowDialog() == DialogResult.OK)
                {
                    string[] modifiedRecord = rf.returnRecord;
                    Dictionary<string, string> tableDescription = DB.requestDescription(currentTable);

                    if (validateDataAgainstDescription(tableDescription, modifiedRecord))
                    {
                        string query = $"UPDATE {currentTable} SET ";
                        for (int i = 0; i < headerData.Length; i++)
                        {
                            string colType = tableDescription[headerData[i]].ToLower();
                            if (colType.Contains("varchar") || colType.Contains("nvarchar") || colType.Contains("char") || colType.Contains("text"))
                            {
                                query += $"{headerData[i]} = '{modifiedRecord[i].Replace("'", "''")}'";
                            }
                            else
                            {
                                query += $"{headerData[i]} = {modifiedRecord[i]}";
                            }

                            if (i < headerData.Length - 1)
                            {
                                query += ", ";
                            }
                        }

                        string primaryKey = headerData[0];
                        string primaryKeyValue = rowData[0];
                        string primaryKeyType = tableDescription[primaryKey].ToLower();

                        if (primaryKeyType.Contains("varchar") || primaryKeyType.Contains("nvarchar") || primaryKeyType.Contains("char") || primaryKeyType.Contains("text"))
                        {
                            query += $" WHERE {primaryKey} = '{primaryKeyValue.Replace("'", "''")}';";
                        }
                        else
                        {
                            
                            query += $" WHERE {primaryKey} = {primaryKeyValue};";
                        }

                        if (DB.query(query))
                        {
                            MessageBox.Show("Record Successfully Updated");
                            RefreshData();
                        }
                    }
                }
            }
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (currentTable == string.Empty)
            {
                MessageBox.Show("No Table Selected");
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo,  MessageBoxIcon.Warning);
            if(result == DialogResult.Yes) 
            {
                int currentRow = DGV_TableData.CurrentCell.RowIndex;
                string firstCell = DGV_TableData.Rows[currentRow].Cells[0].Value.ToString();
                string firstHeader = headerData[0];

                Dictionary<string, string> tableDescription = DB.requestDescription(currentTable);
                string colType = tableDescription[firstHeader].ToLower();
                string query;
                if (colType.Contains("varchar") || colType.Contains("nvarchar") || colType.Contains("char") || colType.Contains("text"))
                {
                    query = $"DELETE FROM {currentTable} WHERE {firstHeader} = '{firstCell.Replace("'", "''")}'";
                }
                else
                {
                    query = $"DELETE FROM {currentTable} WHERE {firstHeader} = {firstCell}";
                }

                if (DB.query(query))
                {
                    MessageBox.Show("Successfully Deleted Record");
                    RefreshData();
                }
            }
        }

        private void Form_DBTables_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DB != null)
            {
                DB.Dispose();
                Console.WriteLine("MySQL Connection disposed.");
            }
        }

        //Methods for validating datatypes before processing SQL query
        private bool validateDataAgainstDescription(Dictionary<string, string> tableDescription, string[] record) 
        { 
            if(tableDescription.Count != record.Length)
            {
                MessageBox.Show($"Record Length doesnt match {currentTable}'s Description Length");
                return false;
            }

            int index = 0;
            foreach(var column in  tableDescription) 
            { 
                string columnName = column.Key;
                string columnType = column.Value;
                string value = record[index];

                if(!validateDataType(columnType, value)) 
                {
                    MessageBox.Show(
                        $"Validation Error: Column '{columnName} expects data type '{columnType}'. Provided value: '{value}'");
                    return false;
                }
                index++;
            }
            return true; 
        }
        private bool validateDataType(string type, string value) 
        { 
            try
            {
                if(type.StartsWith("int"))
                {
                    return int.TryParse(value, out _);
                }
                else if(type.StartsWith("datetime"))
                {
                    return DateTime.TryParse(value, out _);
                }
                else if(type.StartsWith("tinyint") || type.StartsWith("smallint"))
                {
                    return value == "1" || value == "0";
                }
                else if(type.StartsWith("varchar"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show($"Validation Error: " + ex.Message);
                return false;
            }
        }

        private void RefreshData()
        {
            try
            {
                DataTable dt = DB.requestAllRecords(currentTable);
                DGV_TableData.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occurred: " + ex.Message);
            }
        }
    }
}