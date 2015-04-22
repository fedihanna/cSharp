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
            var fileName = DateTime.Now.ToString("yyyyMMdd") + ".log";


            //if the file does not exist...create a text that says so
            //else if it does exist, display fileName
            if (!File.Exists(fileName))
            {
                using (var writer = File.CreateText(fileName))
                {
                    writer.WriteLine(message);
                }
            }
            else
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(message);
                }
            }
        }


        //creating the log file
        //System.IO.StreamWriter file;
    //    public Logger()
    //    {
    //        //http://stackoverflow.com/questions/5057567/how-to-do-logging-in-c
    //        //Implements a TextWriter for writing characters to a stream in a particular encoding.
    //        file = new System.IO.StreamWriter(DateTime.Now.ToString("yyyy-MM-dd-mm") + ".log", true);
    //    }


    //    //writing the log file
    //    public void Log(string message)
    //    {
    //        //writes the file in real time 
    //        //date time
    //        //Now
    //        //to string
    //         file.WriteLine(DateTime.Now.ToString("yyyy-MM-dd-mm:ss:fff") + "    " +  message);        
    //    }
        
    //    //closing the stream writer
    //    public void Close()
    //    {
    //        file.Close();
    //    }
    }
}
