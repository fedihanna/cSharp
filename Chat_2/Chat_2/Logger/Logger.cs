using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogSpace
{
    public class Logger
    {
        //creating the log file
        System.IO.StreamWriter file;
        public Logger()
        {
            //http://stackoverflow.com/questions/5057567/how-to-do-logging-in-c
            //Implements a TextWriter for writing characters to a stream in a particular encoding.
            file = new System.IO.StreamWriter(DateTime.Now.ToString("yyyy-MM-dd-mm") + ".log", true);
        }


        //writing the log file
        public void Log(string text)
        {
            //writes the file in real time 
            //date time
            //Now
            //to string
             file.WriteLine(DateTime.Now.ToString("yyyy-MM-dd-mm:ss:fff") + "    " +  text);        
        }
        
        //closing the stream writer
        public void Close()
        {
            file.Close();
        }
    }
}
