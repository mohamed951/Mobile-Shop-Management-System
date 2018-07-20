using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkypeDemo.DL
{
    class Datalayer
    {
        MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
        MySqlCommand comm = null;
        MySqlDataReader dr = null;
        public MySqlDataReader LoginCheck(String username, String password)
        {

            comm = new MySqlCommand("login", conn);
            comm.Parameters.AddWithValue("@user", username);
            comm.Parameters.AddWithValue("@pass", password);
            comm.CommandType = CommandType.StoredProcedure;

            try
            {
                if (ConnectionState.Closed == conn.State)
                    conn.Open();
                dr = comm.ExecuteReader();
                log_file h =new  log_file();
                h.log_file1(" select * from account where Username="+ username + " and Password=****");
                return dr;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public void insertCust(String username, String Cphone, String SSN, String Email, Byte[] Image)
        {

            comm = new MySqlCommand("InsertCust", conn);
            comm.Parameters.AddWithValue("@Cname", username);
            comm.Parameters.AddWithValue("@Cphone", Cphone);
            comm.Parameters.AddWithValue("@CSSN", SSN);
            comm.Parameters.AddWithValue("@CEmail", Email);
            comm.Parameters.AddWithValue("@CImage", Image);
            comm.CommandType = CommandType.StoredProcedure;
            try
            {
                if (ConnectionState.Closed == conn.State)
                    conn.Open();
                int RowsAffected = comm.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    MessageBox.Show("Insertion Complete Successfully");
                    log_file h = new log_file();
                    h.log_file1(" insert into customer value(" + SSN + "," + username + "," + Cphone + "," + Email + ")");
                }
                else
                {
                    MessageBox.Show("Error Occured Druing Insertion!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            conn.Close();
        }

        public MySqlDataReader GetComboBoxItems(String table)
        {
            comm = null;
            if (table.Equals("customer"))
                comm = new MySqlCommand("SelectAllCust", conn);
            else if (table.Equals("account"))
                comm = new MySqlCommand("SelectAllEmp", conn);
            else if (table.Equals("mobile"))
                comm = new MySqlCommand("SelectProduct", conn);
            comm.CommandType = CommandType.StoredProcedure;
            try
            {
                if (ConnectionState.Closed == conn.State)
                    conn.Open();
                return comm.ExecuteReader();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public void InsertProd(String ModName, String CompName, String BuyCost, String CPU, String ScreenSize, String PrimaryCam, String SecondryCam, String SellCost, String Ram, String MobileSerial)
        {
            //dl.InsertEmp(ModName, CompName, BuyCost, CPU, ScreenSize, PrimaryCam, SecondryCam, SellCost, Ram, MobileSerial);
        }
        public MySqlDataReader Select(String type, String table, String col, String val)
        {
            comm = new MySqlCommand("Select", conn);
            comm.Parameters.AddWithValue("@stat", type);
            comm.Parameters.AddWithValue("@col", col);
            comm.Parameters.AddWithValue("@tableN", table);
            comm.Parameters.AddWithValue("@val", val);
            comm.CommandType = CommandType.StoredProcedure;
            try
            {
                if (ConnectionState.Closed == conn.State)
                    conn.Open();
                log_file h = new log_file();
                if(type=="all")
                h.log_file1(" 'SELECT * FROM ',"+ table+ ")");
                else
                    h.log_file1("SELECT * FROM ',"+table+",' Where ',"+col+",' LIKE ''',"+val+",'%'''");
                return comm.ExecuteReader();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public void DeleteRow(String table, String col, String val)
        {
            comm = new MySqlCommand("Delete", conn);
            comm.Parameters.AddWithValue("@tableN", table);
            comm.Parameters.AddWithValue("@col", col);
            comm.Parameters.AddWithValue("@val", val);
            comm.CommandType = CommandType.StoredProcedure;
            // MessageBox.Show(table + " " + col + " " + val);
            try
            {
                if (ConnectionState.Closed == conn.State)
                    conn.Open();
                comm.ExecuteNonQuery();
                log_file h = new log_file();
                
                    h.log_file1(" Select company.Company_Name,model.Mod_Name,model.Mod_Quantity,model.Mod_Sell_Cost, model.CPU, model.Internal_Storage,model.Ram, model.Screen_Size, model.Primary_Camera, model.Secondry_Camera from company, model ");
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void UpdateCust(String SSN, String username, String Cphone, String Email)
        {
            comm = new MySqlCommand("UpdateCust", conn);
            comm.Parameters.AddWithValue("@Cname", username);
            comm.Parameters.AddWithValue("@Cphone", Cphone);
            comm.Parameters.AddWithValue("@CSSN", SSN);
            comm.Parameters.AddWithValue("@CEmail", Email);
            comm.CommandType = CommandType.StoredProcedure;
            try
            {
                if (ConnectionState.Closed == conn.State)
                    conn.Open();
                comm.ExecuteNonQuery();
                log_file h = new log_file();

                h.log_file1(" UPDATE customer SET Name = ''',"+username+",''' , Phone = ''',"+Cphone+",''' , Email = ''',"+Email+",''' WHERE SSN = ''',"+SSN+",''';'");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }
        public MySqlDataReader ShowProductTable()
        {
            comm = new MySqlCommand("SelectProduct", conn);
            comm.CommandType = CommandType.StoredProcedure;
            try
            {
                if (ConnectionState.Closed == conn.State)
                    conn.Open();
                log_file h = new log_file();

                h.log_file1(" Select company.Company_Name,model.Mod_Name,model.Mod_Quantity,model.Mod_Sell_Cost,model.CPU,model.Internal_Storage,model.Ram,model.Screen_Size,model.Primary_Camera,model.Secondry_Camera from company,model where company.Company_Serial = model.Company_Serial");

                return comm.ExecuteReader();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public void InsertEmp(String SSN, String Name, String Phone, String Username, String Password, String Email)
        {

            comm = new MySqlCommand("InsertEmp", conn);
            comm.Parameters.AddWithValue("@ESSN", SSN);
            comm.Parameters.AddWithValue("@EName", Name);
            comm.Parameters.AddWithValue("@EPhone", Phone);
            comm.Parameters.AddWithValue("@EUsername", Username);
            comm.Parameters.AddWithValue("@EPassword", Password);
            comm.Parameters.AddWithValue("@EEmail", Email);
            comm.CommandType = CommandType.StoredProcedure;
            try
            {
                if (ConnectionState.Closed == conn.State)
                    conn.Open();
                int RowsAffected = comm.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    MessageBox.Show("Employee Account Added Successfully");
                    log_file h = new log_file();

                    h.log_file1(" insert into account value("+SSN+","+Name+","+Phone+","+Username+" ,"+Password+", "+Email+",emp)");
                }
                else
                {
                    MessageBox.Show("Error In Adding Employee Account!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }
        public void InsertComp(String CompSerial, String CompNameA)
        {

            comm = new MySqlCommand("InsertComp", conn);
            comm.Parameters.AddWithValue("@CompSerial", CompSerial);
            comm.Parameters.AddWithValue("@CompName", CompNameA);
            comm.CommandType = CommandType.StoredProcedure;
            try
            {
                if (ConnectionState.Closed == conn.State)
                    conn.Open();
                int RowsAffected = comm.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    MessageBox.Show("Company Added Successfully");
                    log_file h = new log_file();

                    h.log_file1(" insert into Company value("+CompSerial+","+CompNameA+")");

                }
                else
                {
                    MessageBox.Show("Error In Adding Company!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close(); ;
        }
        public void InsertModel(String ModelSerial, String ModelNameA, String BuyCost, String SellCost, String Ram, String CPU, String InterStorage, String ScreenSize, String PrimaryCam, String SecondaryCam, String CompanyName)
        {
            MySqlDataReader dr = Select(null, "company", "Company_Name", CompanyName);
            if (!dr.Read())
            {
                MessageBox.Show("Company Name Not Found");
                return;
            }
            comm = new MySqlCommand("InsertModel", conn);
            comm.Parameters.AddWithValue("@Mod_Serial", ModelSerial);
            comm.Parameters.AddWithValue("@Mod_Name", ModelNameA);
            comm.Parameters.AddWithValue("@Mod_Buy_Cost", BuyCost);
            comm.Parameters.AddWithValue("@Mod_Sell_Cost", SellCost);
            comm.Parameters.AddWithValue("@Ram", Ram);
            comm.Parameters.AddWithValue("@CPU1", CPU);
            comm.Parameters.AddWithValue("@InternalStorage", InterStorage);
            comm.Parameters.AddWithValue("@ScreenSize", ScreenSize);
            comm.Parameters.AddWithValue("@PrimaryCam", ScreenSize);
            comm.Parameters.AddWithValue("@SecondaryCam", SecondaryCam);
            comm.Parameters.AddWithValue("@Company_Serial", dr["Company_Serial"]);
            dr.Close();
            comm.CommandType = CommandType.StoredProcedure;
            try
            {
                if (ConnectionState.Closed == conn.State)
                    conn.Open();
                int RowsAffected = comm.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    MessageBox.Show("Model Added Successfully");
                    log_file h = new log_file();

                    h.log_file1(" insert into model value("+ModelSerial+", "+ModelNameA+",0, "+BuyCost+", "+SellCost+", "+Ram+", "+CPU+", "+ InterStorage + ", "+ScreenSize+", "+PrimaryCam+", "+SecondaryCam+", "+ dr["Company_Serial"]+")");

                }
                else
                {
                    MessageBox.Show("Error In Adding Model!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close(); ;
        }
        public void InsertMobile(String Mob_Serial, String ModelNameA)
        {
            MySqlDataReader dr = Select(null, "model", "Mod_Name", ModelNameA);
            if (!dr.Read())
            {
                MessageBox.Show("Model Name Not Found");
                return;
            }
            comm = new MySqlCommand("InsertMob", conn);
            comm.Parameters.AddWithValue("@MobSerial", Mob_Serial);
            comm.Parameters.AddWithValue("@ModSerial", dr["Mod_Serial"]);
            String MBS = Mob_Serial, MDS = dr["Mod_Serial"].ToString();
            comm.CommandType = CommandType.StoredProcedure;
            dr.Close();
            try
            {
                if (ConnectionState.Closed == conn.State)
                    conn.Open();
                int RowsAffected = comm.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    MessageBox.Show("Mobile Added Successfully");
                    log_file h = new log_file();

                    h.log_file1(" 	insert into mobile value("+Mob_Serial+","+ MDS + ");UPDATE model SET Mod_Quantity = Mod_Quantity + 1 where Mod_Serial = "+ MBS+"");

                }
                else
                {
                    MessageBox.Show("Error In Adding Mobile!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close(); ;
        }
        public void returnMobile(String PID) {

            comm = new MySqlCommand("returnMobile", conn);
            comm.Parameters.AddWithValue("@PPID", PID);
            comm.CommandType = CommandType.StoredProcedure;
            try
            {
                if (ConnectionState.Closed == conn.State)
                    conn.Open();
                int RowsAffected = comm.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    MessageBox.Show("Mobile Return Successfully");

                }
                else
                {
                    MessageBox.Show("Error In returning Mobile", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close(); ;

        }
        public MySqlDataReader fillCartInfo(String MobSerial)
        {
            comm = new MySqlCommand("MobCartInfo", conn);
            comm.Parameters.AddWithValue("@MobSerial", MobSerial);
            comm.CommandType = CommandType.StoredProcedure;
            try
            {
                if (ConnectionState.Closed == conn.State)
                    conn.Open();
                log_file h = new log_file();

                h.log_file1("Select model.Mod_Name,company.Company_Name,model.Mod_Quantity,	model.Mod_Sell_Cost from company,model,mobile where company.Company_Serial = model.Company_Serial and model.Mod_Serial = mobile.Mod_Serial and mobile.Mob_Serial = "+MobSerial+"");

                return comm.ExecuteReader();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public void changePass(String NewPass)
        {
            comm = new MySqlCommand("UpdatePass", conn);
            comm.Parameters.AddWithValue("@NPass", NewPass);
            comm.Parameters.AddWithValue("@SSNID", Global.GlobalVar);
            comm.CommandType = CommandType.StoredProcedure;
            try
            {
                if (ConnectionState.Closed == conn.State)
                    conn.Open();
                comm.ExecuteNonQuery();
                log_file h = new log_file();

                h.log_file1("UPDATE account SET Password = ''',"+NewPass+",''' Where SSN = ''',"+ Global.GlobalVar+"");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }
        public void UpdateEmp(String SSN, String name, String username, String password, String Email, String Cphone)
        {
            comm = new MySqlCommand("UpdateEmp", conn);
            comm.Parameters.AddWithValue("@Cname", name);
            comm.Parameters.AddWithValue("@CUsername", username);
            comm.Parameters.AddWithValue("@CPassword", password);
            comm.Parameters.AddWithValue("@Cphone", Cphone);
            comm.Parameters.AddWithValue("@CSSN", SSN);
            comm.Parameters.AddWithValue("@CEmail", Email);
            comm.CommandType = CommandType.StoredProcedure;
            try
            {
                if (ConnectionState.Closed == conn.State)
                    conn.Open();
                comm.ExecuteNonQuery();
                log_file h = new log_file();

                h.log_file1("UPDATE account SET Name = ''',"+name+",''',Username = ''',"+username+",''',Password = ''',"+password+" ,''', Email = ''',"+Email+",''' , Phone = ''',"+Cphone+",''' WHERE SSN = ''',"+SSN+",'''");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }
        public void DeleteRow1(String table, String col, String val)
        {
            comm = new MySqlCommand("Delete", conn);
            comm.Parameters.AddWithValue("@tableN", table);
            comm.Parameters.AddWithValue("@col", col);
            comm.Parameters.AddWithValue("@val", val);
            comm.CommandType = CommandType.StoredProcedure;
            try
            {
                if (ConnectionState.Closed == conn.State)
                    conn.Open();
                comm.ExecuteNonQuery();
                log_file h = new log_file();

                h.log_file1("Delete FROM ',"+table+",' Where ',"+col+",' = ''',"+val+",'''");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public MySqlDataReader SelectEmp(String type, String table, String col, String val)
        {
            comm = new MySqlCommand("SelectEmp", conn);
            comm.Parameters.AddWithValue("@stat", type);
            comm.Parameters.AddWithValue("@col", col);
            comm.Parameters.AddWithValue("@tableN", table);
            comm.Parameters.AddWithValue("@val", val);
            comm.CommandType = CommandType.StoredProcedure;
            try
            {

                if (ConnectionState.Closed == conn.State)
                    conn.Open();
                return comm.ExecuteReader();
                log_file h = new log_file();
                if (type == "all")
                    h.log_file1(" 'SELECT * FROM '," + table + ")");
                else
                    h.log_file1("SELECT * FROM '," + table + ",' Where '," + col + ",' LIKE '''," + val + ",'%'''");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "HOBA");
                return null;
            }
        }

        public void InsertCart(String MobSerial, String CustomerSSN, String ModName, String ModCompany, String MobSellPrice)
        {

            comm = new MySqlCommand("InsertCart", conn);
            comm.Parameters.AddWithValue("@MobSerial", MobSerial);
            comm.Parameters.AddWithValue("@CustomerSSN", CustomerSSN);
            comm.Parameters.AddWithValue("@ModName", ModName);
            comm.Parameters.AddWithValue("@ModCompany", ModCompany);
            comm.Parameters.AddWithValue("@MobSellPrice", MobSellPrice);
            comm.CommandType = CommandType.StoredProcedure;
            try
            {
                if (ConnectionState.Closed == conn.State)
                    conn.Open();
                int RowsAffected = comm.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    MessageBox.Show("Added To Cart");
                    log_file h = new log_file();

                    h.log_file1("       insert into cart value("+MobSerial+", "+CustomerSSN+", "+ModName+", "+ModCompany+", "+MobSellPrice+")");


                }
                else
                {
                    MessageBox.Show("Error In Adding Model!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close(); ;
        }

        public void Buy(DateTime time, String CustomerSSN, String MobileSerial, String ModName, String ModSellPrice)
        {
            comm = new MySqlCommand("Buy", conn);
            comm.Parameters.AddWithValue("@MobileSerial1", MobileSerial);
            comm.Parameters.AddWithValue("@CustomerSSN", CustomerSSN);
            comm.Parameters.AddWithValue("@time1", time);
            comm.Parameters.AddWithValue("@ModSellPrice", ModSellPrice);
            comm.Parameters.AddWithValue("@UserID", Global.GlobalVar);
            comm.Parameters.AddWithValue("@BillNo", Global.BillNo);
            comm.CommandType = CommandType.StoredProcedure;
            try
            {
                if (ConnectionState.Closed == conn.State)
                    conn.Open();
                int RowsAffected = comm.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    //   MessageBox.Show("Added To Cart");
                    log_file h = new log_file();

                    h.log_file1("insert into payment value(null, "+MobileSerial+", "+CustomerSSN+", "+Global.GlobalVar+", " + time+","+ ModSellPrice+");update model set Mod_Quantity = Mod_Quantity - 1;Delete FROM  cart where MobileSerial = "+MobileSerial+";Delete from mobile where Mob_Serial = "+MobileSerial+"");
                }
                else
                {
                    // MessageBox.Show("Error In Adding Model!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close(); ;
        }

        public void InsertBill()
        {

            comm = new MySqlCommand("InsertBill", conn);
            comm.Parameters.AddWithValue("@time1", Global.Time);
            comm.Parameters.AddWithValue("@billNo", Global.BillNo);
            comm.CommandType = CommandType.StoredProcedure;
            try
            {
                if (ConnectionState.Closed == conn.State)
                    conn.Open();
                int RowsAffected = comm.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    MessageBox.Show("Buy Operatino Complete");
                    log_file h = new log_file();

                    h.log_file1("insert into bill value("+ Global.Time + ","+ Global.BillNo+"");

                }
                else
                {
                    MessageBox.Show("Error In Adding Model!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close(); ;
        }
        public MySqlDataReader returnnn(String Time, String billno)
        {
            comm = new MySqlCommand("returnnn", conn);
            comm.Parameters.AddWithValue("@Ctime", Time);
            comm.Parameters.AddWithValue("@Cbillno", billno);
            comm.CommandType = CommandType.StoredProcedure;
            try
            {
                if (ConnectionState.Closed == conn.State)
                    conn.Open();
                log_file h = new log_file();



                h.log_file1(" select * from payment where cast(payment.Time As Date) = " + Time + "");
                return comm.ExecuteReader();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "HOBA");
                return null;
            }

        }
        public MySqlDataReader returnCustName(String Time, String billno)
        {
            comm = new MySqlCommand("returnName", conn);
            comm.Parameters.AddWithValue("@Ctime", Time);
            comm.Parameters.AddWithValue("@Cbillno", billno);
            comm.CommandType = CommandType.StoredProcedure;
            try
            {
                if (ConnectionState.Closed == conn.State)
                    conn.Open();
                log_file h = new log_file();



                h.log_file1(" select * from payment where cast(payment.Time As Date) = " + Time + "");
                return comm.ExecuteReader();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "HOBA");
                return null;
            }

        }

        public void Updatemodel(String Namecom, String Namemode, String Quantitymode, String SellCostmode, String Rammode, String CPUmode, String InternalStoragemode, String ScreenSizemode, String PrimaryCameramode, String SecondryCameramode)
        {
            comm = new MySqlCommand("Updatemodel", conn);
            comm.Parameters.AddWithValue("@CNamecom", Namecom);
            comm.Parameters.AddWithValue("@CNamemode", Namemode);
            comm.Parameters.AddWithValue("@CQuantitymode", Quantitymode);
            comm.Parameters.AddWithValue("@CSellCostmode", SellCostmode);
            comm.Parameters.AddWithValue("@CRammode", Rammode);
            comm.Parameters.AddWithValue("@CCPUmode", CPUmode);
            comm.Parameters.AddWithValue("@CInternalStoragemode", InternalStoragemode);
            comm.Parameters.AddWithValue("@CScreenSizemode", ScreenSizemode);
            comm.Parameters.AddWithValue("@CPrimaryCameramode", PrimaryCameramode);
            comm.Parameters.AddWithValue("@CSecondryCameramode", SecondryCameramode);
            comm.CommandType = CommandType.StoredProcedure;
            try
            {
                if (ConnectionState.Closed == conn.State)
                    conn.Open();
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }
        public void companyCheck(String companyname, String modserial)
        {

            comm = new MySqlCommand("compCheck", conn);

            comm.Parameters.AddWithValue("@Ccompanyname", companyname);
            comm.Parameters.AddWithValue("@Cmodserial", modserial);
            comm.CommandType = CommandType.StoredProcedure;

            try
            {
                if (ConnectionState.Closed == conn.State)
                    conn.Open();
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }
        public void DeleteRow2(String table, String col, String val)
        {
            comm = new MySqlCommand("Delete", conn);
            comm.Parameters.AddWithValue("@tableN", table);
            comm.Parameters.AddWithValue("@col", col);
            comm.Parameters.AddWithValue("@val", val);
            comm.CommandType = CommandType.StoredProcedure;
            try
            {
                if (ConnectionState.Closed == conn.State)
                    conn.Open();
                comm.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public MySqlDataReader Selectmodel(String type, String table, String col, String val)
        {
            comm = new MySqlCommand("Selectmodel", conn);
            comm.Parameters.AddWithValue("@stat", type);
            comm.Parameters.AddWithValue("@col", col);
            comm.Parameters.AddWithValue("@tableN", table);
            comm.Parameters.AddWithValue("@val", val);
            comm.CommandType = CommandType.StoredProcedure;
            try
            {
                if (ConnectionState.Closed == conn.State)
                    conn.Open();

                return comm.ExecuteReader();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "HOBA");
                return null;
            }
        }
        public MySqlDataReader revenue(String date1, String date2)
        {
            comm = new MySqlCommand("endDate", conn);
            comm.Parameters.AddWithValue("@date1", date1);
            comm.Parameters.AddWithValue("@date2", date2);
            comm.CommandType = CommandType.StoredProcedure;
            try
            {
                if (ConnectionState.Closed == conn.State)
                    conn.Open();
                return comm.ExecuteReader();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public MySqlDataReader profit(String date1, String date2)
        {
            comm = new MySqlCommand("profit", conn);
            comm.Parameters.AddWithValue("@date1", date1);
            comm.Parameters.AddWithValue("@date2", date2);
            comm.CommandType = CommandType.StoredProcedure;
            try
            {
                if (ConnectionState.Closed == conn.State)
                    conn.Open();
                return comm.ExecuteReader();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public MySqlDataReader GetBuyPrice(String MobSerial)
        {
            comm = new MySqlCommand("GetModelBuy", conn);
            comm.Parameters.AddWithValue("@MobileSerial1", MobSerial);
            comm.CommandType = CommandType.StoredProcedure;
            try
            {
                if (ConnectionState.Closed == conn.State)
                    conn.Open();

                return comm.ExecuteReader();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message );
                return null;
            }
        }
        public MySqlDataReader GetMaxDate()
        {
            comm = new MySqlCommand("GetMaxDate", conn);
            comm.CommandType = CommandType.StoredProcedure;
            try
            {

                if (ConnectionState.Closed == conn.State)
                    conn.Open();
                return comm.ExecuteReader();
                log_file h = new log_file();
                 h.log_file1(" 'SELECT * FROM ', Bill)");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "HOBA");
                return null;
            }
        }

    }
}
