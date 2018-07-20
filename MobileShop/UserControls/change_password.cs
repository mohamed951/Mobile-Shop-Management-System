using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SkypeDemo.BL;
namespace SkypeDemo.UserControls
{
    public partial class change_password : UserControl
    {
        public change_password()
        {
            InitializeComponent();
        }

        private void AddEmpB_Click(object sender, EventArgs e)
        {
            if (OldPass.Text.Equals("") || NewPass.Text.Equals("") || RNewPass.Text.Equals("")) {
                MessageBox.Show("Please,Fill The Input Fields!");
            }
            else {
                businesslayer bl = new businesslayer();
                bl.changePass(OldPass.Text, NewPass.Text, RNewPass.Text);
            }
            
        }
    }
}
