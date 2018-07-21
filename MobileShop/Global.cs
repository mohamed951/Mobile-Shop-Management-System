using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using SkypeDemo.DL;
namespace SkypeDemo
{
    static class Global
    {
        
        private static string _globalVar = "";
        private static int _BillNo = 1;
        private static DateTime _Time = DateTime.Now;
        public static string GlobalVar
        {
            get { return _globalVar; }
            set { _globalVar = value; }
        }

        public static int BillNo
        {
            get { return _BillNo; }
            set { _BillNo = value; }
        }

        public static DateTime Time
        {
            get { return _Time; }
            set { _Time = value; }
        }
    }
}
