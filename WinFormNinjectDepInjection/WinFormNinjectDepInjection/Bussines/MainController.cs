using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormNinjectDepInjection.Bussines
{
    public class MainController :IMainController
    {
        public string GetMessage()
        {
            return "Merhaba";
        }
    }
}
