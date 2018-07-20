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
    public partial class AddCustomer : UserControl
    {
        public AddCustomer()
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            try

            {

                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                openFileDialog1.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)

                {

                    ImagePath.Text = openFileDialog1.FileName;
                     ///Image.FromFile(openFileDialog1.FileName)
                }

            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            businesslayer bl = new businesslayer();

            if (CName.Text.Equals("") || Phone.Text.Equals("") || SSN.Text.Equals("") || Email.Text.Equals("") || ImagePath.Text.Equals(""))
            {
                MessageBox.Show("Please,Fill the inputs");
            }
            else
            {
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(Email.Text);
                if (match.Success)
                {

                    bl.InsertCust(CName.Text, Phone.Text, SSN.Text, Email.Text, ImagePath.Text);
                }
                else
                {
                    MessageBox.Show(Email.Text + " is incorrect");
                }
            }

        

    }
    }

}
