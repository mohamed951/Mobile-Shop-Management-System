using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows;
using System.Configuration;

namespace SkypeDemo
{
    public class backup1
    {
        public backup1()
        {
            //InitializeComponent();
        }
        public bool backup2()
        {
            try
            {
                MySqlConnection myconn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString);
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
                            mybackup.ExportToFile(@"C:\Users\mohamed\Desktop\WindowsFormsApplication2\simple.sql");
                            MessageBox.Show("Database Backup successfully.....!");
                            myconn.Close();
                        }
                    }
                }
                return true;
            }


            catch
            {
                return false;

            }



        }
    }




}
