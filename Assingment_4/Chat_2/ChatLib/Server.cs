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
        //creating a server
        //need a tcpClient for this to work
        //both must be connect to the address and port ....127.0.0.1, 13000

        public Server(string ip, int port)
        {
            this.server = new TcpListener(IPAddress.Parse(ip), port);
        }

//*****CONNECT

         public override

             //for connecting
            void connect()
        {
             //start the server
             //server is accepting the tcp
             //getting a stream object for streaming and writing
            server.Start();
            this.client = this.server.AcceptTcpClient();
            this.stream = client.GetStream();

        }


//******SEND
        public override void send(string message)
        {
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(message);
            this.stream.Write(msg, 0, msg.Length);
        }


//*******RECIEVE
        public override void  recieve()
        {
            //buffer for reading data
            //representing an empty string
            Byte[] bytes = new Byte[256];
            String data = String.Empty;

            //declaring "i" so stream can read the incoming bytes and length
            int i;

            if ((i = this.stream.Read(bytes, 0, bytes.Length)) != 0)
            {
                data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
            }
            
        }


//*******TERMINATE
         public override void terminate()
        {
            //disposes of all resouces used by the system
            //closes thte stream
            //stream is equal to null
            stream.Dispose();
            stream.Close();
            stream = null;

            //closes the client
            //makes client eqaul null
            client.Close();
            client = null;
        }
    
    }

        
}
