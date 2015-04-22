using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    //creating a interface class "ILoggingService"
    public interface ILoggingService
    {
        //A log that takes in a string message
        void Log(string message);
    }
}
