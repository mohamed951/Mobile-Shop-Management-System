using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkypeDemo.DL;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.IO;
namespace SkypeDemo.BL
{
    class businesslayer
    {

        public String LoginCheck(String username, String password)
        {
            Datalayer dl = new Datalayer();
            MySqlDataReader dr = dl.LoginCheck(username, password);
            if (dr.Read())
            {
                Global.GlobalVar = dr["SSN"].ToString();

                if (dr["Type"].Equals("admin"))
                {
                    return "admin";
                }
                else return "emp";
            }
            else
            {
                return null;
            }
        }
        public void InsertCust(String username, String Phone, String SSN, String Email, String fileName)
        {
            Datalayer dl = new Datalayer();
            string FileName = fileName;
            byte[] ImageData;
            FileStream fs;
            BinaryReader br;
            fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
            br = new BinaryReader(fs);
            ImageData = br.ReadBytes((int)fs.Length);
            br.Close();
            fs.Close();
            dl.insertCust(username, Phone, SSN, Email, ImageData);
        }
        public List<string> SearchComboBoxItems(String Table)
        {
            Datalayer dl = new Datalayer();
            MySqlDataReader dr = dl.GetComboBoxItems(Table);
            List<string> ColName = new List<string>();
            for (int i = 0; i < dr.FieldCount; i++)
            {
                if (!dr.GetName(i).Equals("Type") && !dr.GetName(i).Equals("ssnImage"))
                    ColName.Add(dr.GetName(i));
            }
            dr.Close();
            return ColName;
        }
        public MySqlDataReader Select(String type, String table, String col, String val)
        {
            Datalayer dl = new Datalayer();
            MySqlDataReader dr = dl.Select(type, table, col, val);
            return dr;
        }
        public void DeleteRow(String table, String col, String val)
        {
            Datalayer dl = new Datalayer();
            dl.DeleteRow(table, col, val);
        }
        public void UpdateCust(DataGridView drv)
        {
            Datalayer dl = new Datalayer();
            foreach (DataGridViewRow row in drv.Rows)
            {
                if (!row.IsNewRow)
                {
                    dl.UpdateCust(row.Cells["SSN"].Value + "", row.Cells["Name"].Value + "", row.Cells["Phone"].Value + "", row.Cells["Email"].Value + "");
                    MessageBox.Show("Update Operation is Completed");
                }
            }
        }

        public void InsertEmp(String SSN, String Name, String Phone, String Username, String Password, String Email)
        {
            Datalayer dl = new Datalayer();
            dl.InsertEmp(SSN, Name, Name, Username, Password, Email);
        }
        public void InsertModel(String ModelSerial, String ModelNameA, String BuyCost, String SellCost, String Ram, String CPU, String InterStorage, String ScreenSize, String PrimaryCam, String SecondaryCam, String CompanyName)
        {
            Datalayer dl = new Datalayer();
            dl.InsertModel(ModelSerial, ModelNameA, BuyCost, SellCost, Ram, CPU, InterStorage, ScreenSize, PrimaryCam, SecondaryCam, CompanyName);
        }
        public void InsertMobile(String MobileSerial, String ModelNameA)
        {
            Datalayer dl = new Datalayer();
            dl.InsertMobile(MobileSerial, ModelNameA);
        }
        public void returnMobile(String PID) {
            Datalayer dl = new Datalayer();
            dl.returnMobile(PID);
        }
        public void InsertComp(String CompSerial, String CompNameA)
        {
            Datalayer dl = new Datalayer();
            dl.InsertComp(CompSerial, CompNameA);
        }

        public MySqlDataReader ShowProductTable()
        {
            Datalayer dl = new Datalayer();
            MySqlDataReader dr = dl.ShowProductTable();
            return dr;
        }
        public bool IsSSNExist(String CustomerSSN)
        {
            Datalayer dl = new Datalayer();
            MySqlDataReader dr = dl.Select(null, "customer", "SSN", CustomerSSN);
            if (dr.Read())
                return true;
            else return false;
        }
        public MySqlDataReader fillCartInfo(String MobSerial)
        {
            Datalayer dl = new Datalayer();
            return dl.fillCartInfo(MobSerial);
        }
        public void changePass(String OldPass, String NewPass, String RNewPass)
        {
            Datalayer dl = new Datalayer();
            MySqlDataReader dr = dl.Select("cond", "account", "SSN", Global.GlobalVar);
            if (dr.Read())
            {
                if (!dr["Password"].Equals(OldPass))
                {
                    MessageBox.Show("Wrong Password Input");
                    dr.Close();
                    return;
                }
                else
                {
                    if (!NewPass.Equals(RNewPass))
                    {
                        MessageBox.Show("New Password Not Equal The Renter Password");
                        dr.Close();
                        return;
                    }
                    else
                    {
                        dr.Close();
                        dl.changePass(NewPass);
                        MessageBox.Show("Password Updated Successfully");
                    }
                }
            }
            dr.Close();
            return;
        }
        public void UpdateEmp(DataGridView drv)
        {
            Datalayer d1 = new Datalayer();
            foreach (DataGridViewRow row in drv.Rows)
            {
                if (!row.IsNewRow)
                {
                    d1.UpdateEmp(row.Cells["SSN"].Value + "", row.Cells["Name"].Value + "", row.Cells["Username"].Value + "", row.Cells["Password"].Value + "", row.Cells["Email"].Value + "", row.Cells["Phone"].Value + "");
                    MessageBox.Show("Update Operation is Completed");
                }
            }
        }
        public void DeleteRow1(String table, String col, String val)
        {
            Datalayer dl = new Datalayer();
            dl.DeleteRow1(table, col, val);
        }
        public MySqlDataReader SelectEmp(String type, String table, String col, String val)
        {
            Datalayer dl = new Datalayer();
            MySqlDataReader dr = dl.SelectEmp(type, table, col, val);
            return dr;
        }
        public void InsertCart(String MobSerial, String CustomerSSN, String ModName, String ModCompany, String MobSellPrice) {
            Datalayer dl = new Datalayer();
            dl.InsertCart(MobSerial,CustomerSSN,ModName,ModCompany,MobSellPrice);
        }
        public void Buy(DateTime time, String CustomerSSN,String MobileSerial, String ModName, String ModSellPrice) {
            Datalayer dl = new Datalayer();
            dl.Buy(time, CustomerSSN, MobileSerial,  ModName,ModSellPrice);
        }
        public void insertBill() {
            Datalayer dl = new Datalayer();
            dl.InsertBill();
        }
        public MySqlDataReader returnnn(String Time, String billno)
        {
            Datalayer dl = new Datalayer();
           return dl.returnnn(Time, billno);
        }
        public MySqlDataReader returnCustName(String Time, String billno)
        {
            Datalayer dl = new Datalayer();
            return dl.returnCustName(Time, billno);
        }
        
        public void Updatemodel(DataGridView drv)
        {
            Datalayer d1 = new Datalayer();
            foreach (DataGridViewRow row in drv.Rows)
            {
                if (!row.IsNewRow)
                {
                    d1.Updatemodel(row.Cells["Company_Name"].Value + "", row.Cells["Mod_Name"].Value + "", row.Cells["Mod_Quantity"].Value + "", row.Cells["Mod_Sell_Cost"].Value + "", row.Cells["Ram"].Value + "", row.Cells["CPU"].Value + "", row.Cells["Internal_Storage"].Value + "", row.Cells["Screen_Size"].Value + "", row.Cells["Primary_Camera"].Value + "", row.Cells["Secondry_Camera"].Value + "");
                    MessageBox.Show("Update Operation is Completed");
                }
            }
        }
        public void companyCheck(DataGridView drv)
        {

            Datalayer d1 = new Datalayer();
            foreach (DataGridViewRow row in drv.Rows)
            {
                if (!row.IsNewRow)
                {
                    d1.companyCheck(row.Cells["Company_Name"].Value + "", row.Cells["mod_Serial"].Value + "");
                    MessageBox.Show("Update Operation is Completed");
                }
            }
        }
        public void DeleteRow2(String table, String col, String val)
        {
            Datalayer dl = new Datalayer();
            dl.DeleteRow2(table, col, val);
        }
        public MySqlDataReader Selectmodel(String type, String table, String col, String val)
        {
            Datalayer dl = new Datalayer();
            MySqlDataReader dr = dl.Selectmodel(type, table, col, val);
            return dr;
        }
        public MySqlDataReader revenue(String date1, String date2)
        {
            Datalayer dl = new Datalayer();
            MySqlDataReader dr = dl.revenue(date1, date2);
            return dr;
        }

        public MySqlDataReader profit(String date1, String date2)
        {
            Datalayer dl = new Datalayer();
            MySqlDataReader dr = dl.profit(date1, date2);
            return dr;
        }
    }
}
