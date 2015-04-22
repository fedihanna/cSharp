using Interfaces;
using System;
using System.Collections.Generic;
//using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Interfaces;

namespace LogSpace
{
    //created class FediLoggger for the purpose of output in debug mode
    //implements ILoggingService
    public class FediLogger : ILoggingService
    {

        public void Log(string message)
        {
            //debug mode will display in output screen in following format
            Debug.WriteLine(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss (fff)") + " : " + message);
        }    
    }
}
