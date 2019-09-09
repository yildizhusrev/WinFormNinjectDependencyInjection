using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace WinFormNinjectDepInjection.CrossCuttingConcern
{
    
        public class NinjectProgram
        {
            /// <summary>
            /// Gets the inject kernal for the program.
            /// </summary>
            public static IKernel Kernel { get; protected set; }
        }
    }

