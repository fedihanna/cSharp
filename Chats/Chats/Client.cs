using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Chats
{
    class Client : ChatBaseClass
    {
        //creating a TcpClient
        //need a TcpSrever for this to work
        //both must be connected to the same address and port .....127.0.0.1  13000
        public Client(string serverIp, int port)
        {
            this.client = new TcpClient(serverIp, port);
            
        }

        //****FOR CONNECTING
        public override void connect() //for connecting
        {
            //need a client stream for reading and writing
            this.stream = client.GetStream();
        }


        //******FOR SENDING
        //public override void send(string message)
        //{
        //    //byte array.....256
        //    //Gets an encoding for the ASCII (7-bit) character set
        //    //stream will use all that is sent by client.....
        //    byte[] msg = System.Text.Encoding.ASCII.GetBytes(message);

        //    this.stream.Write(msg, 0, msg.Length);
        //}

        //******FOR RECIEVING
        //public override string recieve() 
        //{
        //    //buffer for reading data
        //    //representing an empty string
        //    byte[] bytes = new byte[256];
        //    string data = string.Empty;

        //    int i; //declaring "i" so stream can read the incoming bytes and length

        //    if ((i = this.stream.Read(bytes, 0, bytes.Length)) != 0)
        //    {
        //        data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
        //    }
        //    return data; //returns data
        //}
    }
}
