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
using MySql.Data.MySqlClient;

namespace SkypeDemo
{
    public partial class DetailsRevenue : UserControl
    {
        businesslayer bl = new businesslayer();
        public DetailsRevenue()
        {
            InitializeComponent();
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuDatepicker2_onValueChanged(object sender, EventArgs e)
       {
            
               
        
        
        
        }

        private void loginB_Click(object sender, EventArgs e)
        {
            businesslayer bl = new businesslayer();
            MySqlDataReader dr = bl.profit(firstDate.Value.ToString("yyyy-MM-dd"), endDate.Value.ToString("yyyy-MM-dd"));
            if (dr.Read()) {
                if (!dr.IsDBNull(0))
                {
                    String temp = dr.GetString(0);
                    proftext.Text = temp + "L.E.";
                }
                else proftext.Text = "0 L.E."; 
                
            }
            else proftext.Text = "0 L.E.";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //businesslayer bl = new businesslayer();
            //dataGridView1 = bl.profit(firstDate.Value.ToString("dd-MM-yyyy"), endDate.Value.ToString("dd-MM-yyyy"));
            businesslayer bl = new businesslayer();
            MySqlDataReader dr = bl.revenue(firstDate.Value.ToString("yyyy-MM-dd"), endDate.Value.ToString("yyyy-MM-dd"));
            DataTable table = new DataTable();
            if (dr != null)
            {
                table.Load(dr);
                if (table != null)
                    dataGridView1.DataSource = table;
            }
          //  dr.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
        
        
        
        
        
        }
          
   }


