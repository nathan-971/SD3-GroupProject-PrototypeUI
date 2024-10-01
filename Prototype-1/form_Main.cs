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

        public form_Main()
        {
            InitializeComponent();
            AllocConsole();

            panel_Nav.MouseDown += panel_Nav_MouseDown;
            panel_Nav.Paint += new PaintEventHandler(panel_Nav_Paint);
        }
        private void panel_Nav_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
        private void panel_Nav_Paint(object sender, PaintEventArgs e)
        {
            Color gradiantColor1 = new Color();
            Color gradiantColor2 = new Color();

            gradiantColor1 = Color.FromArgb(60, 120, 0);
            gradiantColor2 = Color.FromArgb(0, 80, 0);

            using (LinearGradientBrush brush = new LinearGradientBrush(panel_Nav.ClientRectangle, gradiantColor1, gradiantColor2, LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, panel_Nav.ClientRectangle);
            }
        }

        private bool isOpened = false;
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

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}