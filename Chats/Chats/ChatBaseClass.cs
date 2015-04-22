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
        //A protected member is accessible within its class and by derived class instances
       protected TcpListener server;
       protected TcpClient client;
       protected NetworkStream stream;

        //abstract methods for our sub classes to use
       abstract public void connect();
        public  void send( string message)
       {
           

               //byte array.....256
               //Gets an encoding for the ASCII (7-bit) character set
               //stream will use all that is sent by server.....
               byte[] msg = System.Text.Encoding.ASCII.GetBytes(message);
               this.stream.Write(msg, 0, msg.Length);
           
       }


       public string recieve() 
       {
           //buffer for reading data
           //representing an empty string
           byte[] bytes = new byte[256];
           string data = string.Empty;

           while (stream.DataAvailable)
           {

               int i; //declaring "i" so stream can read the incoming bytes and length

               if ((i = this.stream.Read(bytes, 0, bytes.Length)) != 0)
               {
                   data += System.Text.Encoding.ASCII.GetString(bytes, 0, i);
               }
           }

           return data; //returns data
       }

    }
}
