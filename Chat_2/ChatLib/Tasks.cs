using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks

//*******DELEGATE VOID
{
    //a delegate is a pointer to a method and arguments will have to match
    //delegate void to hand the messages to the form
    //delegate allows the programmer to encapsulate a reference to a method inside a delegate object.
    public delegate void MessageRecieved(MessageRecievedEventArgs msg);


//******MESSAGE RECIEVED EVENT ARGS

    //inheriting event args, which is built into the system
    public class MessageRecievedEventArgs : EventArgs
    {
        //a string 
        string message;

        //event args is taking the string
        //setting it to value
        public MessageRecievedEventArgs(string value)
        {
            message = value;
        }

        public string Message { get { return message; } }
    }
}
