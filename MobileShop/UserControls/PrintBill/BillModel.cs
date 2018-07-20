using MySql.Data.MySqlClient;
using SkypeDemo.BL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkypeDemo.UserControls.PrintBill
{
    public class BillModel
    {
        public double TotalPrice;
        public string TotalPriceSTR;
        public string BillNo;
        public DateTime DT;
        public List<string> MobileSerial = new List<string>();
        public List<string> CustomerSSN = new List<string>();
        public List<string> ModSellPrice = new List<string>();
        public List<string> ModCompany = new List<string>();

        public void GetData(int Num, DateTime DT)
        {
            BillNo = Num.ToString();
            this.DT = DT;

            businesslayer bl = new businesslayer();
            MySqlDataReader dr = bl.Select("all", "cart", "", "");
            DataTable table = new DataTable();
            if (dr != null)
            {
                table.Load(dr);
            }

            foreach (DataRow row in table.Rows)
            {
                MobileSerial.Add(row["MobileSerial"].ToString());
                CustomerSSN.Add(row["CustomerSSN"].ToString());
                ModSellPrice.Add(row["ModSellPrice"].ToString());
                ModCompany.Add(row["ModCompany"].ToString());

                TotalPrice += Convert.ToDouble(row["ModSellPrice"].ToString());
            }
            TotalPriceSTR = TotalPrice + " L.E.";
        }
    }
}
