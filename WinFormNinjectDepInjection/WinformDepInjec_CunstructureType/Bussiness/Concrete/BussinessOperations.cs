﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformDepInjec_CunstructureType.Bussiness.Abstract;

namespace WinformDepInjec_CunstructureType.Bussiness.Concrete
{
    public class BussinessOperations : IBussinesOperations
    {
        public string GetMessage()
        {
            return "Merhaba";
        }
    }
}
