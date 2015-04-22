using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace VS.Logger
{
    //created to save a file to a logging file
    //DotNetLogger implements ILoggingService
    /// <summary>
    /// 
    /// </summary>
    public class DotNetLogger : ILoggingService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public void Log(string message)
        {
            //will save to file called DotNetLogger in the folloing format
            Logger log = new Logger(1, "Dot-Net-Log-" + DateTime.Now.ToString("yyyy-MM-dd") + ".log");
            log.log(0, "DOT-NET-LOGGER", message);
            log.shutdown();
        }
    }
}
