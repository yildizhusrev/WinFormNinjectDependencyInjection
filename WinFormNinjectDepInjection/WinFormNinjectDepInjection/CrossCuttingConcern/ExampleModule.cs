using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using WinFormNinjectDepInjection.Bussines;

namespace WinFormNinjectDepInjection.CrossCuttingConcern
{
    public class ExampleModule: NinjectModule
    {
        public override void Load()
        {
            // Here is where we define what implementations map to what interfaces.
            Bind<IMainController>().To<MainController>().InSingletonScope();


            //We can also load other modules this project depends on.
            //Kernel.Load(new NinjectModule());
        }
    }
}
