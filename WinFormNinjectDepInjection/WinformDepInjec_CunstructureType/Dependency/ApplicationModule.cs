using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using WinformDepInjec_CunstructureType.Bussiness.Abstract;
using WinformDepInjec_CunstructureType.Bussiness.Concrete;
using WinformDepInjec_CunstructureType.DAL;

namespace WinformDepInjec_CunstructureType.Dependency
{
    public class ApplicationModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IBussinesOperations>().To<BussinessOperations>();
            Bind(typeof(IRepository<>)).To(typeof(GenericRepository<>));
        }
    }
}
