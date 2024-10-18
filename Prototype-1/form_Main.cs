using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Prototype_1
{
    public partial class form_Main : Form
    {
        //Console For Debugging
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        [DllImport("user32.dll")]
        public static extern void ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        //1377
        //Resizing Values
        private const int HTLEFT = 10;
        private const int HTRIGHT = 11;
        private const int HTTOP = 12;
        private const int HTTOPLEFT = 13;
        private const int HTTOPRIGHT = 14;
        private const int HTBOTTOM = 15;
        private const int HTBOTTOMLEFT = 16;
        private const int HTBOTTOMRIGHT = 17;

        private bool isOpened = false;

        public form_Main()
        {
            InitializeComponent();
            AllocConsole();

            this.btn_ExpandMenu.BringToFront();
            this.panel_Nav.MouseDown += panel_Nav_MouseDown;

            #region Pitch Grid Buttons
            btn_Pitch_TOPLEFT.Click += new EventHandler(pitch_Btn_Click);
            btn_Pitch_TOPCENTRE.Click += new EventHandler(pitch_Btn_Click);
            btn_Pitch_TOPRIGHT.Click += new EventHandler(pitch_Btn_Click);

            btn_Pitch_CENTRELEFT.Click += new EventHandler(pitch_Btn_Click);
            btn_Pitch_CENTRE.Click += new EventHandler(pitch_Btn_Click);
            btn_Pitch_CENTRERIGHT.Click += new EventHandler(pitch_Btn_Click);

            btn_Pitch_BOTTOMLEFT.Click += new EventHandler(pitch_Btn_Click);
            btn_Pitch_BOTTOMCENTRE.Click += new EventHandler(pitch_Btn_Click);
            btn_Pitch_BOTTOMRIGHT.Click += new EventHandler(pitch_Btn_Click);
            #endregion
            #region Player Grid Buttons
            btn_Player_1.Click += new EventHandler(player_Btn_Click);
            btn_Player_2.Click += new EventHandler(player_Btn_Click);
            btn_Player_3.Click += new EventHandler(player_Btn_Click);
            btn_Player_4.Click += new EventHandler(player_Btn_Click);
            btn_Player_5.Click += new EventHandler(player_Btn_Click);
            btn_Player_6.Click += new EventHandler(player_Btn_Click);
            btn_Player_7.Click += new EventHandler(player_Btn_Click);
            btn_Player_8.Click += new EventHandler(player_Btn_Click);
            btn_Player_9.Click += new EventHandler(player_Btn_Click);
            btn_Player_10.Click += new EventHandler(player_Btn_Click);
            btn_Player_11.Click += new EventHandler(player_Btn_Click);
            btn_Player_12.Click += new EventHandler(player_Btn_Click);
            btn_Player_13.Click += new EventHandler(player_Btn_Click);
            btn_Player_14.Click += new EventHandler(player_Btn_Click);
            btn_Player_15.Click += new EventHandler(player_Btn_Click);
            #endregion
        }

        //Resize Window
        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x84;
            const int resizeBorderWidth = 10;

            SuspendLayout();
            if (m.Msg == WM_NCHITTEST)
            {
                base.WndProc(ref m);

                Point pos = this.PointToClient(new Point(m.LParam.ToInt32()));
                int width = this.ClientSize.Width;
                int height = this.ClientSize.Height;

                bool left = pos.X <= resizeBorderWidth;
                bool right = pos.X >= width - resizeBorderWidth;
                bool top = pos.Y <= resizeBorderWidth;
                bool bottom = pos.Y >= height - resizeBorderWidth;

                if (left && top)
                    m.Result = (IntPtr)HTTOPLEFT;
                else if (right && top)
                    m.Result = (IntPtr)HTTOPRIGHT;
                else if (left && bottom)
                    m.Result = (IntPtr)HTBOTTOMLEFT;
                else if (right && bottom)
                    m.Result = (IntPtr)HTBOTTOMRIGHT;
                else if (left)
                    m.Result = (IntPtr)HTLEFT;
                else if (right)
                    m.Result = (IntPtr)HTRIGHT;
                else if (top)
                    m.Result = (IntPtr)HTTOP;
                else if (bottom)
                    m.Result = (IntPtr)HTBOTTOM;
            }
            else
            {
                base.WndProc(ref m);
            }
            ResumeLayout();
        }

        //Drag Window Via Navbar
        private void panel_Nav_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void btn_ExpandMenu_Click(object sender, EventArgs e)
        {
            if (isOpened)
            {
                panel_Menu.Size = new Size(panel_Menu.Width, 25);
                panel_Menu.Location = new Point(panel_Menu.Location.X, panel_Menu.Location.Y + 75);

                btn_ExpandMenu.Text = "^";
                btn_ExpandMenu.Location = new Point(btn_ExpandMenu.Location.X, btn_ExpandMenu.Location.Y + 75);

                btn_Subsitution.Enabled = false;
                btn_Halftime.Enabled = false;
                btn_DisqualifyPlayer.Enabled = false;
                btn_AddInjury.Enabled = false;

                btn_Subsitution.Visible = false;
                btn_Halftime.Visible = false;
                btn_DisqualifyPlayer.Visible = false;
                btn_AddInjury.Visible = false;

                isOpened = false;
            }
            else
            {
                panel_Menu.Size = new Size(panel_Menu.Width, 100);
                panel_Menu.Location = new Point(panel_Menu.Location.X, panel_Menu.Location.Y - 75);

                btn_ExpandMenu.Text = "v";
                btn_ExpandMenu.Location = new Point(btn_ExpandMenu.Location.X, btn_ExpandMenu.Location.Y - 75);

                btn_Subsitution.Enabled = true;
                btn_Halftime.Enabled = true;
                btn_DisqualifyPlayer.Enabled = true;
                btn_AddInjury.Enabled = true;

                btn_Subsitution.Visible = true;
                btn_Halftime.Visible = true;
                btn_DisqualifyPlayer.Visible = true;
                btn_AddInjury.Visible = true;
                
                isOpened = true;
            }
        }

        private void pitch_Btn_Click(object sender, EventArgs e)
        {
            using(form_Grid fg = new form_Grid())
            {
                fg.ShowDialog();
            }
        }
        private void player_Btn_Click(object sender, EventArgs e)
        {
            using (form_Player fp = new form_Player())
            {
                fp.ShowDialog();
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Maximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}