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
    public partial class MainForm : BaseForm
    {
        private IMainController _controller;

        public MainForm()
        {
            InitializeComponent();
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return; 
            //The controller cannot be fetched at design time because the
            //program has not loaded the kernel. 

            init();
        }

        private void init()
        {
            _controller = GetController<IMainController>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_controller.GetMessage());  
        }
    }



  
   
}
