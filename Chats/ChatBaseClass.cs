using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Chats
{
    abstract class ChatBaseClass
    {
        //protected properties 
       protected TcpListener server;
       protected TcpClient client;
       protected NetworkStream stream;

        //abstract methods for our sub classes to use
       abstract public void connect();
       abstract public void send( string message);

       abstract public string recieve();

    }
}
