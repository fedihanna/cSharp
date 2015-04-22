using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Chats
{
    class Server : ChatBaseClass
    {

        //creating a Server
        //need a TcpClient for this to work
        //both must be connected to the same address and port .....127.0.0.1  13000
        public Server(string ip, int port)
        {
            this.server = new TcpListener(IPAddress.Parse(ip), port);
        }

        //*****FOR CONNECTING
        public override void connect() //for connecting
        {
            server.Start(); 
            this.client = server.AcceptTcpClient(); //server accepting the TcpClient
            this.stream = client.GetStream(); //getting a stream object for readig and writing

        }

        //*****FOR SENDING
        //public override void send(string message) //for sending
        //{

        //    //byte array.....256
        //    //Gets an encoding for the ASCII (7-bit) character set
        //    //stream will use all that is sent by server.....
        //    byte[] msg = System.Text.Encoding.ASCII.GetBytes(message);
        //    this.stream.Write(msg, 0, msg.Length);
        //}

        //********FOR RECIEVING
        //public override string recieve() 
        //{
        //    //buffer for reading data
        //    //representing an empty string
        //    Byte[] bytes = new Byte[256];
        //    String data = String.Empty;

        //    int i; //declaring "i" so stream can read the incoming bytes and length

        //    if ((i = this.stream.Read(bytes, 0, bytes.Length)) != 0)
        //    {
        //        data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
        //    }
        //    return data; //return data
        //}
    }

        
}
