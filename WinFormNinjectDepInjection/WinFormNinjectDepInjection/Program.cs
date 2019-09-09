using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ninject;
using WinFormNinjectDepInjection.CrossCuttingConcern;

namespace WinFormNinjectDepInjection
{
    public class Program : NinjectProgram
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Kernel = new StandardKernel();
            Kernel.Load(new ExampleModule());
            //We load the module when the program starts.

            Application.Run(new MainForm());
        }
    }
}
