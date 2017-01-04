using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLLMessage;
using AppHandleMessage;

namespace MQControl
{
    public partial class ResultViewCtrl : UserControl
    {
        public ResultViewCtrl()
        {
            InitializeComponent();

            this.initReceiveMessage();
        }
        private MessageManager _messageManager = null;

        private ViewPersonResultMessage _viewPersonResultMessage = null;
        protected override void DefWndProc(
ref System.Windows.Forms.Message m)
        {
            _messageManager.Receive(base.DefWndProc, ref m);
        }

        private void initReceiveMessage()
        {
            _messageManager = new MessageManager();
            _messageManager.AddReceiveMessage(this.createViewPersonResultMessage());

        }


        private AppHandleMessage.Message createViewPersonResultMessage()
        {
            #region
            this._viewPersonResultMessage = new ViewPersonResultMessage();
            this._viewPersonResultMessage.ViewPersonResult =
                 new ViewPersonResultMessage.DlViewPersonResult((result) =>
                 {
                     this.lbResult.Text = string.Format("***学生的成绩是{0}, {1}", result, result<60?"继续努力吧！":"及格了，很棒！");
                 });
            return this._viewPersonResultMessage;
            #endregion
        }


    }
}
