using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CRUD_Forms_Prototype
{
    public partial class form_DBTables : Form
    {
        private DBConnection DB;
        private string[] headerData;
        private string[] rowData;
        private string currentTable = "";
        private int cellCount = 0;

        public form_DBTables()
        {
            InitializeComponent();
            DB = new DBConnection("127.0.0.1", "root", "", "gaastatsdb");
        }

        private void btn_ChangeTable_Click(object sender, EventArgs e)
        {
            using (form_InputBox inputForm = new form_InputBox())
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
            using(form_Record rf = new form_Record(headerData))
            {
                if(rf.ShowDialog() == DialogResult.OK)
                {
                    string[] newRecord = rf.returnRecord;               
                    Dictionary<string, string> tableDescription = DB.requestDescription(currentTable);
                    if(validateDataAgainstDescription(tableDescription, newRecord))
                    {
                        string query = $"INSERT INTO {currentTable} VALUES(";
                        for (int i = 0; i < newRecord.Length; i++)
                        {
                            if(i+1 == newRecord.Length)
                            {
                                query += $"\"{newRecord[i]}\"";
                                continue;
                            }
                            query += $"\"{newRecord[i]}\", ";
                        }
                        query += ");";
                        if (DB.query(query))
                        {
                            MessageBox.Show("Successfully Created Record");
                            Refresh();
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
                            query += $"{headerData[i]} = '{modifiedRecord[i]}'";
                            if (i < headerData.Length - 1)
                            {
                                query += ", ";
                            }
                        }

                        string primaryKey = headerData[0];
                        string primaryKeyValue = rowData[0];
                        query += $" WHERE {primaryKey} = '{primaryKeyValue}';";
                        if (DB.query(query))
                        {
                            MessageBox.Show("Record Successfully Updated");
                            Refresh();
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
                string query = $"DELETE FROM {currentTable} WHERE {firstHeader} = \"{firstCell}\"";
                if (DB.query(query))
                {
                    MessageBox.Show("Successfully Deleted Record");
                    Refresh();
                }
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
                else if(type.StartsWith("tinyint"))
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

        private void Refresh()
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