using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using Tasks;
using Interfaces;

namespace Chats
{
    public class Client : ChatBaseClass
    {
        public bool connected;

        //public event has been created
        public event MessageRecieved messageRecieved;

        private ILoggingService logger;

        public Client(ILoggingService logger)
        {
            this.client = new TcpClient("127.0.0.1", 13000);
            this.logger = logger;
        }

//*********CONNECT
        public override void connect()
        {
                this.stream = client.GetStream();
                connected = true; // set to true
                logger.Log("Client Connected");
                
        }

        public override void send(string message)
        {
            //decoding a range of bytes from byte array into a string
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(message);
            this.stream.Write(msg, 0, msg.Length);
            logger.Log("Sent: " + message);
        }


//******RECIEVE
        public override void recieve()
        { 
            //waiting for input
            string data = "";

            while (connected)
            {
                //network stream has data available
                if (stream.DataAvailable)
                {
                    //byte array of 256
                    byte[] bytes = new byte[256];
                    //i declared for loop
                    int i;

                    // loop to recieve all data sent by client
                    if ((i = this.stream.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        //decoding the data being entered
                        data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                    }
                }
                if (data.Length > 0)
                {
                    //when the data string has a value 
                    messageRecieved(new MessageRecievedEventArgs(data));
                    logger.Log("Received: " + data);
                    data = "";
                }
            }
       
        }


//********TERMINATE
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
