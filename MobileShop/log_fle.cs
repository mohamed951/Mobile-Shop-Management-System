using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkypeDemo
{
    public class log_file
    {
        public bool log_file1(string sqlcommend)
        {
            try
            {
                using (System.IO.StreamWriter logfile =
                    new System.IO.StreamWriter(@"C:\Users\RL\Desktop\example_logfile11.txt", true))
                    //  MessageBox.Show("logfile created");
                    logfile.WriteLine("["+sqlcommend +"]"+ " at " + DateTime.Now);

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
