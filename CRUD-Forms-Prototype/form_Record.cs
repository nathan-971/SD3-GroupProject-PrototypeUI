using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CRUD_Forms_Prototype
{
    public partial class form_Record : Form
    {
        public int cellCount;
        private string[] _Data;
        private string[] _Headers;
        public string[] returnRecord;
        private bool create = false;

        public form_Record(string[] headers, string[] rowData)
        {
            InitializeComponent();
            _Data = rowData;
            _Headers = headers;
            create = false;
        }
        public form_Record(string[] headers)
        {
            InitializeComponent();
            _Headers = headers;
            create = true;
        }
        private void form_Record_Load(object sender, System.EventArgs e)
        {
            if(create) //Generate Create Record Form
            {
                genCreateForm();
            }
            else //Generate Modify Record Form
            {
                genModifyForm();
            }
        }

        private void button_Submit_Record(object sender, EventArgs e)
        {
            returnRecord = new string[_Headers.Length];
            for(int i = 0; i < _Headers.Length; i++) 
            {
                TextBox textBox = Controls.Find($"tb_dyanmic{i}", true).FirstOrDefault() as TextBox;
                if(textBox != null)
                {
                    returnRecord[i] = textBox.Text;
                }
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void genCreateForm()
        {
            int curY = 10;
            int curX = 10;
            for (int i = 0; i < _Headers.Length; i++)
            {
                Label label = new Label()
                {
                    Name = $"label_dyanmic{i}",
                    Text = _Headers[i],
                    Location = new Point(curX, curY),
                    AutoSize = true
                };
                Controls.Add(label);

                TextBox textBox = new TextBox
                {
                    Name = $"tb_dyanmic{i}",
                    Text = "",
                    Location = new Point(curX + 80, curY)
                };
                Controls.Add(textBox);

                curY += 30;
            }
            Button button = new Button
            {
                Name = "btn_Submit",
                Text = "Submit",
                Location = new Point(curX, curY),
                AutoSize = true
            };
            Controls.Add(button);
            button.Click += button_Submit_Record;
        }

        private void genModifyForm()
        {
            int curY = 10;
            int curX = 10;
            for (int i = 0; i < _Headers.Length; i++)
            {
                Label label = new Label()
                {
                    Name = $"label_dyanmic{i}",
                    Text = _Headers[i],
                    Location = new Point(curX, curY),
                    AutoSize = true
                };
                Controls.Add(label);

                TextBox textBox = new TextBox
                {
                    Name = $"tb_dyanmic{i}",
                    Text = _Data[i],
                    Location = new Point(curX + 80, curY)
                };
                Controls.Add(textBox);

                curY += 30;
            }
            Button button = new Button
            {
                Name = "btn_Save",
                Text = "Save",
                Location = new Point(curX, curY),
                AutoSize = true
            };
            Controls.Add(button);
            button.Click += button_Submit_Record;
        }
    }
}