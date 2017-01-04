using AppHandleMessage;
using BLLMessage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MQDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.initReceiveMessage();
        }

        private void btnViewPerson_Click(
            object sender, EventArgs e)
        {
            new ViewPersonMessage().SendViewPersonMsg(
                new MQEntity.Person { Id = 12, Name = "lifengyan" });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ControlSet.MainForm = this;
            ControlSet.MainFormHandle = this.Handle;
            ControlSet.ResultViewCtrl = this.resultViewCtrl1.Handle;

            Thread backgroundThreadCall = new Thread(new ThreadStart(backgroundThreadCallMsg));
            backgroundThreadCall.IsBackground = true;
            backgroundThreadCall.Start();
        }

        private int result = 0;
        private void backgroundThreadCallMsg()
        {
            #region
            while (true)
            {   
                new ViewPersonResultMessage().SendPersonResultMsg(result++);
                Thread.Sleep(100);
            }
            #endregion
        }
    }
}
