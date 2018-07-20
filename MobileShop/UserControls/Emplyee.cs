using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkypeDemo
{
    public partial class Emplyee : UserControl
    {
        public Emplyee()
        {
            InitializeComponent();
            SidePanel.Width = button1.Width;
            SidePanel.Left = button1.Left;
            search_n_Update_Emplyee1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Width = button1.Width;
            SidePanel.Left = button1.Left;
            search_n_Update_Emplyee1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Width = button2.Width;
            SidePanel.Left = button2.Left;
            addEmplyee1.BringToFront();
        }
    }
}
