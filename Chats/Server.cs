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


        public Server(string ip, int port)
        {
            this.server = new TcpListener(IPAddress.Parse(ip), port);
        }
        public override void connect()
        {
            server.Start();
            this.client = this.server.AcceptTcpClient();
            this.stream = client.GetStream();

        }

        public override void send(string message)
        {
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(message);
            this.stream.Write(msg, 0, msg.Length);
        }

        public override string recieve()
        {
            Byte[] bytes = new Byte[256];
            String data = String.Empty;

            int i;

            if ((i = this.stream.Read(bytes, 0, bytes.Length)) != 0)
            {
                data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
            }
            return data;
        }
    }

        
}
