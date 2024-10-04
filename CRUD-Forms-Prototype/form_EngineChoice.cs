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
    public partial class form_EngineChoice : Form
    {
        public bool MySQL = false;
        public string[] parameters;
        public string[] labels;
        public form_EngineChoice()
        {
            InitializeComponent();
        }

        private void btn_MYSQL_Click(object sender, EventArgs e)
        {
            labels = new string[]{ "Server", "Username", "Password", "Database" };
            parameters = new string[labels.Length];

            label_Option.Visible = false;
            label_Option.Enabled = false;

            btn_MYSQL.Visible = false;
            btn_MYSQL.Enabled = false;

            btn_SQLSERVER.Visible = false;
            btn_SQLSERVER.Enabled = false;

            int curY = 10;
            int curX = 10;
            for (int i = 0; i < labels.Length; i++)
            {
                Label label = new Label()
                {
                    Name = $"label_{labels[i]}",
                    Text = labels[i],
                    Location = new Point(curX, curY),
                    AutoSize = true
                };
                Controls.Add(label);

                TextBox textBox = new TextBox
                {
                    Name = $"tb_{labels[i]}",
                    Text = "",
                    Location = new Point(curX + 80, curY)
                };
                Controls.Add(textBox);

                curY += 20;
            }
            Button button = new Button
            {
                Name = "btn_Submit",
                Text = "Submit",
                Location = new Point(curX, curY),
                AutoSize = true
            };
            Controls.Add(button);
            
            button.Click += button_MYSQL_Submit;
        }
        private void button_MYSQL_Submit(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            for(int i = 0; i < labels.Length; i++)
            {
                TextBox textBox = Controls.Find($"tb_{labels[i]}", true).FirstOrDefault() as TextBox;

                if (textBox != null)
                {
                    parameters[i] = textBox.Text;
                }
            }
            MySQL = true;
        }

        private void btn_SQLSERVER_Click(object sender, EventArgs e)
        {
            labels = new string[]{ "Server", "Username", "Password", "Database", "Trust This Machine?"};
            parameters = new string[labels.Length];

            label_Option.Visible = false;
            label_Option.Enabled = false;

            btn_MYSQL.Visible = false;
            btn_MYSQL.Enabled = false;

            btn_SQLSERVER.Visible = false;
            btn_SQLSERVER.Visible = false;

            int curY = 10;
            int curX = 10;
            for (int i = 0; i < 4; i++)
            {
                Label label = new Label()
                {
                    Name = $"label_{labels[i]}",
                    Text = labels[i],
                    Location = new Point(curX, curY),
                    AutoSize = true
                };
                Controls.Add(label);

                TextBox textBox = new TextBox
                {
                    Name = $"tb_{labels[i]}",
                    Text = "",
                    Location = new Point(curX + 80, curY)
                };
                Controls.Add(textBox);

                curY += 20;
            }

            Label checkBoxLabel = new Label()
            {
                Name = $"label_{labels[4]}",
                Text = labels[4],
                Location = new Point(curX, curY + 20),
                AutoSize = true
            };
            Controls.Add(checkBoxLabel);

            // Position for checkbox
            CheckBox checkBox = new CheckBox
            {
                Name = $"chb_{labels[4]}",
                Text = "",
                Location = new Point(curX + checkBoxLabel.Width + 5, curY + 20)
            };
            Controls.Add(checkBox);

            Button button = new Button
            {
                Name = "btn_Submit",
                Text = "Submit",
                Location = new Point(curX, curY + 50),
                AutoSize = true
            };
            Controls.Add(button);

            button.Click += button_SQLServer_Submit;
        }
        private void button_SQLServer_Submit(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            for (int i = 0; i < 4; i++)
            {
                TextBox textBox = Controls.Find($"tb_{labels[i]}", true).FirstOrDefault() as TextBox;

                if (textBox != null)
                {
                    parameters[i] = textBox.Text;
                }
            }
            CheckBox chb = Controls.Find($"chb_{labels[4]}", true).FirstOrDefault() as CheckBox;
            parameters[4] = chb.Checked.ToString();
            MySQL = false;
        }
    }
}