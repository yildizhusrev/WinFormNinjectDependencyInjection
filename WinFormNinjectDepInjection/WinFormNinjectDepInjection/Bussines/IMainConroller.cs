using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormNinjectDepInjection.CrossCuttingConcern;

namespace WinFormNinjectDepInjection.Bussines
{
    public interface IMainController : IController
    {
        string GetMessage();

    }
}
