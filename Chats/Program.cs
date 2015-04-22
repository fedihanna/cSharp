using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chats
{
    class Program
    {
        static void Main(string[] args)
        {
            //this object will contain either the server or client object depending on arguments
            //after upcasting, we can treat either object as the same type
                
            ChatBaseClass chat;

            if (args.Contains("-server"))
            {
                

                //if the program is started with 3 arguments:
                //arg 0 is server
                //arg 1 is IP address...127.0.0.1
                //arg 2 is port number ...8080
                Server server = new Server(args[1], Convert.ToInt32(args[2]));
                chat = (ChatBaseClass)server; //this is the upCast
            }
            else
            {
                //if the program is started with 3 arguments:
                //arg 0 is IP address...127.0.0.1
                //arg 1 is port number ...8080
                Client client = new Client(args[0], Convert.ToInt32(args[1]));
                chat = (ChatBaseClass)client;
            }
            Console.Write(Environment.NewLine + "Waiting to connect....");
            chat.connect(); //
            Console.Write(Environment.NewLine + "Server connected!");

            while(true) //infite loop
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                    if (keyInfo.Key == ConsoleKey.I) //user presses "I"
                    {
                        Console.Write(Environment.NewLine + ">>");
                        chat.send(Console.ReadLine()); //sends what I am typing
                    }

                    if (keyInfo.Key == ConsoleKey.R) //user presses "R"
                    {
                        Console.WriteLine(Environment.NewLine + "Incoming:" + 
                            chat.recieve()); //recieves message
                        
                    }
                        
                    
                }
            }
        }
    }
}
