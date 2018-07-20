using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace SkypeDemo.UserControls
{
    public partial class BackUp : UserControl
    {
        public BackUp()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try

            {

                FolderBrowserDialog FileDialog1 = new FolderBrowserDialog();

             //   openFileDialog1.Filter = "Choose file(*.txt)|*.txt;";

                if (FileDialog1.ShowDialog() == DialogResult.OK)

                {

                    ImagePath.Text = FileDialog1.SelectedPath;
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
            try
            {
                MySqlConnection myconn = new MySqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
                MySqlCommand myCommand1 = new MySqlCommand();
                MySqlBackup mybackup = new MySqlBackup(myCommand1);
                using (myconn)
                {
                    using (myCommand1)
                    {
                        using (mybackup)
                        {
                            myCommand1.Connection = myconn;
                            myconn.Open();
                            int i = 0;
                            mybackup.ExportToFile(ImagePath.Text + @"\mobileshop-" + (DateTime.Now.Day) + "-" + (DateTime.Now.Month) + "-" + (DateTime.Now.Year) + "-" + (DateTime.Now.Hour) + "-" + (DateTime.Now.Minute)  + ".sql");
                            
                            timer1.Start();
                            myconn.Close();

                        }
                    }
                }
            }


            catch
            {
             //   return false;

            }
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myconn = new MySqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
                MySqlCommand myCommand1 = new MySqlCommand();
                MySqlBackup mybackup = new MySqlBackup(myCommand1);
                using (myconn)
                {
                    using (myCommand1)
                    {
                        using (mybackup)
                        {
                            myCommand1.Connection = myconn;
                            myconn.Open();

                            mybackup.ExportToFile(ImagePath.Text + @"\mobileshop-" + (DateTime.Now.Day) + "-" + (DateTime.Now.Month) + "-" + (DateTime.Now.Year) + "-" + (DateTime.Now.Hour) + "-" + (DateTime.Now.Minute)  + ".sql");
            
                            timer1.Start();
                            myconn.Close();

                        }
                    }
                }
                // return true;
            }


            catch
            {
                //   return false;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                //   openFileDialog1.Filter = "Choose file(*.txt)|*.txt;";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    textBox1.Text = openFileDialog1.FileName;
                    ///Image.FromFile(openFileDialog1.FileName)
                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myconn = new MySqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
                MySqlCommand myCommand1 = new MySqlCommand();
                MySqlBackup mybackup = new MySqlBackup(myCommand1);
                using (myconn)
                {
                    using (myCommand1)
                    {
                        using (mybackup)
                        {
                            myCommand1.Connection = myconn;
                            myconn.Open();
                            mybackup.ImportFromFile(textBox1.Text);
                            myconn.Close();

                        }
                    }
                }
          }
            catch
            {
                //   return false;

            }
        }
    }
}
