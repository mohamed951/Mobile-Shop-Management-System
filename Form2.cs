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
    
    public partial class Form2 : Form
    {
        int panelWidth;
        bool Hidden;
        public static String SSNProfile;
        public Form2()
        {
            InitializeComponent();
            panelWidth = PanelSlide.Width;
            Hidden = false;
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
            detailsRevenue1.BringToFront();
            
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
            detailsRevenue1.BringToFront();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            emplyee1.BringToFront();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            products1.BringToFront();


        }

        private void button9_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button9.Height;
            SidePanel.Top = button9.Top;
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

        private void Form2_Load(object sender, EventArgs e)
        {
           // products1.update_Delete_Products1.InitializeSearchProdCB();
            //products1.update_Delete_Products1.ShowProductTable();
            emplyee1.search_n_Update_Emplyee1.InitializeSearchEmpCB();
            emplyee1.search_n_Update_Emplyee1.ShowEmpTable();
            customers1.search_n_Update1.InitializeSearchCusCB();
            customers1.search_n_Update1.ShowAllData();
            products1.add_Product1.LoadAutoCompleteTextBoxes();
            products1.update_Delete_Products1.ShowProductTable();
            products1.update_Delete_Products1.InitializeSearchProdCB();
            profile1.view_Profile1.LoadProfile();


        }

        private void button13_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button13.Height;
            SidePanel.Top = button13.Top;
            sale21.BringToFront();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button11.Height;
            SidePanel.Top = button11.Top;
            customers1.BringToFront();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button12.Height;
            SidePanel.Top = button12.Top;
            browse1.BringToFront();
        }

        private void revenue1_Load(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button14.Height;
            SidePanel.Top = button14.Top;
            profile1.BringToFront();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button15.Height;
            SidePanel.Top = button15.Top;
            returns1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            backUp1.BringToFront();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void returns1_Load(object sender, EventArgs e)
        {

        }
    }
}
