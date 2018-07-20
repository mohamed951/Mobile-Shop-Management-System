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
using SkypeDemo.DL;

namespace SkypeDemo
{
    public partial class Browse : UserControl
    {
        public Browse()
        {
            InitializeComponent();
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
           
        }

        private void Browse_Paint(object sender, PaintEventArgs e)
        {
            businesslayer bl = new businesslayer();
            MySqlDataReader dr = bl.Select("all", "returnpayment", "", "");
            DataTable table = new DataTable();
            if (dr != null)
            {
                table.Load(dr);
                if (table != null)
                    dataGridView1.DataSource = table;
            }
            
        }

    }
}
