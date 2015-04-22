using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Practices.Unity;
using Interfaces;
using LogSpace;
using Ninject;
using Ninject.Modules;
using System.Reflection;
using VS.Logger;
using Chats;
using ThomasShowers_Logger;

namespace Chat_2
{
    //http://www.ninject.org/
    //create a bind class
    //mapping bind class to ninject intereface
    public  class Bind : NinjectModule
    {
        public override void Load()
        {

            //this.Bind<ILoggingService>().To<LogSpace.FediLogger>();
            this.Bind<ILoggingService>().To<ThomasShowers_Logger.Logger>();
            this.Bind<Form1>();
        }
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// //single thread apartment thread
        [STAThread] 
        static void Main()
        {
            //the application will enable certain styles 
            //sets the application defaults
            //run the application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

//*********UNITY
            //Unity being called on
            //using our ILoggingService 
            //using Logger
            //UnityContainer container = new UnityContainer();
            //container.RegisterType<ILoggingService, FediLogger>();
            //container.RegisterInstance<ILoggingService>(new FediLogger());
            //Application.Run(container.Resolve<Form1>());

//********* DotNetLog(using Unity to lauch DotNetLog)
            //http://sourceforge.net/projects/cslogger/
            UnityContainer container = new UnityContainer();
            container.RegisterType<ILoggingService, ThomasShowers_Logger.Logger>();
            Application.Run(container.Resolve<Form1>());


//********NINJECT
            //this will be used to run it in debug mode
            //http://www.ninject.org/
            //IKernel kernel = new StandardKernel();
            //kernel.Load(Assembly.GetExecutingAssembly());
            //Application.Run(new Form1(kernel.Get<ILoggingService>()));
           // Application.Run(kernel.Get<Form1>());
        }
    }
}
