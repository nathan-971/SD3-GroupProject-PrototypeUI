using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Forms_Prototype
{
    public partial class form_TableInput : Form
    {
        public string inputText;
        public DatabaseConnection DBInstance;
        public form_TableInput(DatabaseConnection instance)
        {
            this.DBInstance = instance;
            InitializeComponent();
        }
        private void form_TableInput_Load(object sender, EventArgs e)
        {
            cb_Tables.Items.Clear();
            cb_Tables.DropDownStyle = ComboBoxStyle.DropDownList;
            string[] tables = DBInstance.requestAllTables();
            for (int i = 0; i < tables.Length; i++)
            {
                cb_Tables.Items.Add(tables[i]);
            }
            cb_Tables.SelectedIndex = 0;
        }
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            inputText = cb_Tables.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
