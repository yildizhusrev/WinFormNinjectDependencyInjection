using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormNinjectDepInjection.Bussines;
using WinFormNinjectDepInjection.CrossCuttingConcern;
using WinFormNinjectDepInjection.CrossCuttingConcern.BaseObjects;

namespace WinFormNinjectDepInjection
{
    public partial class Form1 : BaseForm
    {
        private IMainController _controller;
        public Form1()
        {
            InitializeComponent();
            _controller = GetController<IMainController>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_controller.GetMessage());
           
        }
    }
}
