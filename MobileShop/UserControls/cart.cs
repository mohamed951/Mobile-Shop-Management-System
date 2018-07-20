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
using SkypeDemo.UserControls.PrintBill;
namespace SkypeDemo.UserControls
{
    public partial class cart : UserControl
    {
        public cart()
        {
            InitializeComponent();
            CartTable.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void cart_Load(object sender, EventArgs e)
        {
            //dataGridView1=
        }
        private void cart_Paint(object sender, PaintEventArgs e)
        {
            businesslayer bl = new businesslayer();
            MySqlDataReader dr=bl.Select("all", "cart", "", "");
            DataTable table = new DataTable();
            if (dr != null)
            {
                table.Load(dr);
                if (table != null)
                    CartTable.DataSource = table;
            }
            double Price = 0;
            foreach (DataGridViewRow row in CartTable.Rows)
            {
                if (!row.IsNewRow)
                {
                  Price+=Convert.ToDouble(row.Cells["ModSellPrice"].Value);
                }
            }
            TotalPrice.Text = Price.ToString() + " L.E.";
            foreach (DataGridViewRow row in CartTable.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    bl.DeleteRow("cart", "MobileSerial", row.Cells["MobileSerial"].Value + "");
                    CartTable.Rows.Remove(row);
                    MessageBox.Show("Delete Operation is Completed");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            businesslayer bl = new businesslayer();
            foreach (DataGridViewRow row in CartTable.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    bl.DeleteRow("cart", "MobileSerial", row.Cells["MobileSerial"].Value + "");
                    CartTable.Rows.Remove(row);
                    MessageBox.Show("Delete Operation is Completed");
                }
            }
            double Price = 0;
            foreach (DataGridViewRow row in CartTable.Rows)
            {
                if (!row.IsNewRow)
                {
                    Price += Convert.ToDouble(row.Cells["ModSellPrice"].Value);
                }
            }
            TotalPrice.Text = Price.ToString() + " L.E.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Global.Time.Day != DateTime.Now.Day || Global.Time.Month != DateTime.Now.Month || Global.Time.Year != DateTime.Now.Year)
            {
                //MessageBox.Show("Hoba");
                Global.BillNo = 1;
            }
            else
            {
                Global.BillNo++;
            }


            Global.Time = DateTime.Now;
            BillTemplate BillTemplate = new BillTemplate();
            BillTemplate.Session = new Dictionary<string, object>();
            BillTemplate.Session["Bill"] = new BillModel();

            BillTemplate.Initialize();

            webBrowser1.DocumentText = BillTemplate.TransformText();

            
            businesslayer bl = new businesslayer();

           
            foreach (DataGridViewRow row in CartTable.Rows)
            {

                if (!row.IsNewRow)
                {
                    bl.Buy(Global.Time, row.Cells["CustomerSSN"].Value.ToString(), row.Cells["MobileSerial"].Value.ToString(), row.Cells["ModName"].Value.ToString(), row.Cells["ModSellPrice"].Value.ToString());
                }
                
            }
            
            bl.insertBill();
            MySqlDataReader dr = bl.Select("all", "cart", "", "");
            DataTable table = new DataTable();
            if (dr != null)
            {
                table.Load(dr);
                if (table != null)
                    CartTable.DataSource = table;
            }

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser1.ShowPrintPreviewDialog();
        }

    }
}
