using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformDepInjec_CunstructureType.DAL
{
    public class GenericRepository<T> : IRepository<T>
    {
        public override string ToString()
        {
            return "MyRepository with type : " + typeof(T).Name;
        }
    }
}
