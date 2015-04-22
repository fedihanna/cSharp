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
        public Client(string serverIp, int port)
        {
            this.client = new TcpClient(serverIp, port);
            
        }
        public override void connect()
        {
            
                this.stream = client.GetStream();
            
        }

        public override void send(string message)
        {
            //decoding a range of bytes from byte array into a string
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(message);
            this.stream.Write(msg, 0, msg.Length);
        }

        public override string recieve()
        {
            byte[] bytes = new byte[256];
            string data = string.Empty;

            int i;

            // loop to recieve all data sent by client
            while ((i = this.stream.Read(bytes, 0, bytes.Length)) != 0)
            {
                //decoding the data being entered
                data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
            }
            return data;
        }
    }
}
