using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformDepInjec_CunstructureType.Bussiness.Abstract;
using WinformDepInjec_CunstructureType.DAL;
using WinformDepInjec_CunstructureType.DAL.Models;
using WinformDepInjec_CunstructureType.Dependency;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace WinformDepInjec_CunstructureType
{
    public partial class Form1 : Form
    {
        private IRepository<Process> _processRepository;
        private IBussinesOperations _bussinesManager;
        public Form1(IRepository<Process> productionRepository, IBussinesOperations bussinesManager)
        {
            this._processRepository = productionRepository;
            _bussinesManager = bussinesManager;
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                MessageBox.Show(_processRepository.ToString());
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_bussinesManager.GetMessage());
        }
    }
}
