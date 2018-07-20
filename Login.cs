using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SkypeDemo.BL;
using MySql.Data.MySqlClient;
namespace SkypeDemo
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

  

        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown) {
                mouseX = MousePosition.X-500;
                mouseY = MousePosition.Y-15;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                button8.Image = Properties.Resources.Restore_Window_26px;
            }
            else {
                WindowState = FormWindowState.Normal;
                button8.Image = Properties.Resources.Maximize_Window_26px;
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal || WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void login1_Load_1(object sender, EventArgs e)
        {
                           
        }


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }
    }
}
