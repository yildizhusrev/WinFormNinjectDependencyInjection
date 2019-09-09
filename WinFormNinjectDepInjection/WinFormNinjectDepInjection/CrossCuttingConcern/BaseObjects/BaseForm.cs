using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ninject;

namespace WinFormNinjectDepInjection.CrossCuttingConcern.BaseObjects
{
    /// <summary>
    /// Non-Generic BaseForm. Provides functionality for retrieving the controller.
    /// </summary>
    public class BaseForm : Form
    {
        /// <summary>
        /// Gets the controller for the given type.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        protected T GetController<T>()
            where T : class, IController
        {
            return NinjectProgram.Kernel.Get<T>();
        }
    }

    /// <summary>
    /// Generic BaseForm. Automatically retrieves the correct controller.
    /// </summary>
    /// <typeparam name="T">The type of the controller for forms.</typeparam>
    /// <remarks>This class cannot be inherited if the sub class must appear in the designer as the designer cannot instanciate generic classes.</remarks>
    public class BaseForm<T> : Form
        where T : IController
    {
        /// <summary>
        /// Gets the controller for the form.
        /// </summary>
        protected T Controller { get; private set; }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public BaseForm()
        {
            Controller = NinjectProgram.Kernel.Get<T>();
        }
    }
}
