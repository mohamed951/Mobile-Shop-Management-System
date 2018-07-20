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
using SkypeDemo.DL;
using MySql.Data.MySqlClient;
namespace SkypeDemo.UserControls
{
    public partial class login : UserControl
    {
        businesslayer bl = new businesslayer();
        public login()
        {
            InitializeComponent();
        }

        private void loginB_Click(object sender, EventArgs e)
        {
            
            String res=bl.LoginCheck(user.Text, password.Text);
            ///MessageBox.Show(Global.BillNo+"");
            ///

            //MessageBox.Show(Global.BillNo + "-------"+Global.Time+"----");

         
            bool bo = true;
            if (res == null)
            {
                bo = false;
                MessageBox.Show("Invalid Username or Password");
            }
            else if (res.Equals("admin"))
            {
              
                this.Parent.Parent.Hide();
                Form2 adminF = new Form2();
                adminF.Show();
            }
            else {
                this.Parent.Parent.Hide();
                Form1 empF = new Form1();
                empF.Show();
            }
            if (bo)
            {
                MySqlDataReader dr = new Datalayer().GetMaxDate();
                dr.Read();
                Global.Time = Convert.ToDateTime(dr.GetString(0));
                Global.BillNo = Convert.ToInt32(dr.GetString(1));
            }

            //if (Global.Time.Day != DateTime.Now.Day || Global.Time.Month != DateTime.Now.Month || Global.Time.Year != DateTime.Now.Year)
            //{
            //    //MessageBox.Show("Hoba");
            //    Global.BillNo = 1;
            //}
            //else
            //{
            //    Global.BillNo++;
            //}


            //Global.Time = DateTime.Now;
        }
    }
    
}
