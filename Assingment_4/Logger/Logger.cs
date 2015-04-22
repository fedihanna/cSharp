using Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogSpace
{
    public class Logger : ILoggingService
    {


        public void Log(string message)
        {
            var fileName = DateTime.Now.ToString("yyyy-MM-dd") + ".log";


            //if the file does not exist...create a text that says so
            //else if it does exist, display fileName
            if (!File.Exists(fileName))
            {
                using (var writer = File.CreateText(fileName))
                {
                    writer.WriteLine(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss (fff)") + " : " + message);
                }
            }
            else
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss (fff)") + " : " + message);
                }
            }
        }


        
    }
}
