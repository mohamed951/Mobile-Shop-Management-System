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
using System.Text.RegularExpressions;

namespace SkypeDemo
{
    public partial class AddEmplyee : UserControl
    {
        public AddEmplyee()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void AddEmpB_Click(object sender, EventArgs e)
        {
            businesslayer bl = new businesslayer();
            if (EmpSSN.Text.Equals("")|| EmpName.Text.Equals("") || EmpName.Text.Equals("") || EmpUsername.Text.Equals("") || EmpPassword.Text.Equals("") || EmpEmail.Text.Equals("") )
            {
                MessageBox.Show("Please,Fill the inputs");
            }
            else
            {
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(EmpEmail.Text);
                if (match.Success)
                {

                    bl.InsertEmp(EmpSSN.Text, EmpName.Text, EmpName.Text, EmpUsername.Text, EmpPassword.Text, EmpEmail.Text);
                }
                else
                {
                    MessageBox.Show(EmpEmail.Text + " is incorrect");
                }
            }
            
        }
    }
}
