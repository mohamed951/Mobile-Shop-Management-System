using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkypeDemo
{
    public partial class Form1 : Form
    {
        int panelWidth;
        bool Hidden;

        public Form1()
        {
            InitializeComponent();
            sale21.BringToFront();
            panelWidth = PanelSlide.Width;
            Hidden = false;
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Hidden)
            {
                PanelSlide.Width = PanelSlide.Width + 10;
                if (PanelSlide.Width >= panelWidth)
                {
                    timer1.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                PanelSlide.Width = PanelSlide.Width - 10;
                if (PanelSlide.Width <= 0)
                {
                    timer1.Stop();
                    Hidden = true;
                    this.Refresh();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
            sale21.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            browse1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            customers1.BringToFront();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            SidePanel.Height = LogoutB.Height;
            SidePanel.Top = LogoutB.Top;
            this.Hide();
            Login f = new Login();
            f.Show();
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

        private void Form1_Load_1(object sender, EventArgs e)
        {
            customers1.search_n_Update1.InitializeSearchCusCB();
            customers1.search_n_Update1.ShowAllData();
        }

        private void PanelSlide_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button15.Height;
            SidePanel.Top = button15.Top;
            returns1.BringToFront();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button14.Height;
            SidePanel.Top = button14.Top;
            profile1.BringToFront();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }
    }
}
