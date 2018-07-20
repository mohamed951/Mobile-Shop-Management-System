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
    public partial class Add_Product : UserControl
    {
        public Add_Product()
        {
            InitializeComponent();
        }


        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginB_Click(object sender, EventArgs e)
        {

            Byte[] buffer = new Byte[7];
            Random r = new Random();
            r.NextBytes(buffer);
            String sd = BitConverter.ToString(buffer);
            MobileSerialA.Text = sd;
        }

        private void MobileSerial_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            businesslayer b1 = new businesslayer();
            b1.InsertModel(ModelNameA.Text, CompNameA.Text, BuyCost.Text, CPU.Text, ScreenSize.Text, MobileSerialA.Text, SecondaryCam.Text, SellCost.Text, Ram.Text, PrimaryCam.Text,CompanyName.Text);
            }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BuyCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void InterStorage_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            businesslayer b1 = new businesslayer();
            b1.InsertMobile(MobileSerialA.Text,ModelName.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Byte[] buffer = new Byte[5];
            Random r = new Random();
            r.NextBytes(buffer);
            String sd = BitConverter.ToString(buffer);
            CompSerial.Text = sd;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Byte[] buffer = new Byte[4];
            Random r = new Random();
            r.NextBytes(buffer);
            String sd = BitConverter.ToString(buffer);
            ModelSerial.Text = sd;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CompNameA.Text.Equals("") || CompSerial.Text.Equals(""))
            {
                MessageBox.Show("Please, Fill The Tnput Fields");
            }
            else {
                businesslayer bl = new businesslayer();
                bl.InsertComp(CompSerial.Text, CompNameA.Text);
                LoadAutoCompleteTextBoxes();
            }
        }
        public void LoadAutoCompleteTextBoxes()
        {
            businesslayer bl = new businesslayer();
            MySqlDataReader dr = bl.Select("all", "company", null, null);
            AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                MyCollection.Add(dr.GetString(1));
            }
            CompanyName.AutoCompleteCustomSource = MyCollection;
            dr = bl.Select("all", "model", null, null);
            MyCollection = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                MyCollection.Add(dr.GetString(1));
            }
            ModelName.AutoCompleteCustomSource = MyCollection;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ModelNameA.Text.Equals("") || BuyCost.Text.Equals("") || InterStorage.Text.Equals("") || ScreenSize.Text.Equals("") || ModelSerial.Text.Equals("") || SecondaryCam.Text.Equals("") || SellCost.Text.Equals("") || Ram.Text.Equals("") || PrimaryCam.Text.Equals("") || CPU.Text.Equals("") || BuyCost.Text.Equals("")) {
                MessageBox.Show("Please, Fill The Tnput Fields");
            }
            else
            {
                businesslayer bl = new businesslayer();
                bl.InsertModel(ModelSerial.Text,ModelNameA.Text, BuyCost.Text, SellCost.Text, Ram.Text, CPU.Text, InterStorage.Text, ScreenSize.Text, PrimaryCam.Text, SecondaryCam.Text, CompanyName.Text);
                LoadAutoCompleteTextBoxes();
            }
        }
        /*
private System.Windows.Forms.TextBox CompNameA;
private System.Windows.Forms.TextBox BuyCost;
private System.Windows.Forms.TextBox InterStorage;
private System.Windows.Forms.TextBox ScreenSize;
private System.Windows.Forms.TextBox MobileSerialA;
private System.Windows.Forms.TextBox SecondaryCam;
private System.Windows.Forms.TextBox SellCost;
private System.Windows.Forms.TextBox Ram;
private System.Windows.Forms.TextBox PrimarySerial;
private System.Windows.Forms.TextBox CPU;
private System.Windows.Forms.TextBox CompSerial;
private System.Windows.Forms.TextBox ModelSerial;
*/
      
    }
}
