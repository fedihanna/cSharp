using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chats;
using System.Threading;
using LogSpace;
using Tasks;

namespace Chat_2
{
    public partial class Form1 : Form
    {
        //client object needed to communincate with the server
        //a thread to recieve messages
        //a delegate to interupt the main thread when a message is recieved
        Client client;
        Thread recieverThread;
        delegate void PrintTextDelegate(string text);


        //this switch helps us safetly stop the reciever thread
        //so we stop the recieved loop from executing
        bool connected = false;

        //create a log system
        Logger log = new Logger();


        public Form1()
        {
            InitializeComponent();
            AcceptButton = sendButton; //you can press enter button instead of send
            log.Log("Application started.");
        }



//*********CONNECT TOOL STRIP MENU ITEM
        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //connect to the server
            client = new Client("127.0.0.1", 13000);
            //adding a handler to run the event
            client.messageRecieved += new MessageRecieved(GetRecievedtext); //adding a pointer to GetRecievedtext method
            client.connect();
            chatTextBox.Text += "Connected to server!";
            connected = true;

            //Starting to recieve the thread
            recieverThread = new Thread(new ThreadStart(client.recieve));
            recieverThread.Start();

            log.Log("Connect to server.");
        }


//********GET RECIEVED TEXT

        //This method is excuted by the reciever thread
        //This continously checks for incoming messages
        private void GetRecievedtext(Tasks.MessageRecievedEventArgs msg)
        {

          
                    //if the chat text box is owned by the main thread(this will always be true)
                    if (chatTextBox.InvokeRequired)
                    {
                        //Interupt the main thread and send it to a pointer
                        //to the print text method and the incoming message
                        PrintTextDelegate d = new PrintTextDelegate(PrintText);
                        this.Invoke(d, new object[] { "Server:  " + msg.Message }); //Executes the specified delegate on the thread that owns the control's underlying window handle.
                    }
                    else
                    {
                        //if we dont need to interupt the main thread
                        //just print the incoming message
                        PrintText("Server:  " + msg.Message);
                    }
                    //using the logger
                    //caling from the log method
                    log.Log("Server: " + msg.Message);    
        }


//********PRINT TEXT
        //Prints incoming and outgoing messages
         private void PrintText(string text)
        {
             //setting text in the system 
             //sets the starting point for the text
             //allowing user to scroll the contents 
            chatTextBox.Text += System.Environment.NewLine + text;
            chatTextBox.SelectionStart = chatTextBox.TextLength;
            chatTextBox.ScrollToCaret();
        }


//********CHAT TEXT BOX
         private void chatTextBox_TextChanged(object sender, EventArgs e)
         {

         }


//********SEND BUTTON
         private void sendButton_Click(object sender, EventArgs e)
         {
             if (connected && messageTextBox.Text.Length > 0)
             {
                 //if connected
                 //if an outgoing message is longer than 0
                 //send it to the server
                 client.send(messageTextBox.Text);
                 PrintText("You:  " + messageTextBox.Text);
                 
                 //using the logger
                 log.Log("You: " + messageTextBox.Text);
                 messageTextBox.Text = " ";
             }
                 //if not connected 
                 //print the following 
             else if (!connected)
             {
                 PrintText("Sorry, not connected at this time.");
             }
         }


//********DISCONNECT TOOL STRIP
         private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
         {
             //we toggled the boolean to false to stop the recieved loop from executing
             //telling loop in client class to stop recieving 
             //then we dispose of the connection and the resouces used by client
             //its then safe to join the thread
             connected = false;
             client.connected = false;
             client.terminate();
             //recieverThread.Abort();
             PrintText("Diconnected.");
             log.Log("Disconnected");
             log.Close();
         }
    }//.......Class
}//.........NameSpace
