using AppHandleMessage;
using BLLMessage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MQDemo
{
    public partial class Form1
    {
        private MessageManager _messageManager = null;

        private ViewPersonResultMessage _viewPersonResultMessage = null;
        private ViewPersonMessage _viewPersonMessage = null;
        protected override void DefWndProc(
ref System.Windows.Forms.Message m)
        {
            _messageManager.Receive(base.DefWndProc, ref m);
        }

        private void initReceiveMessage()
        {
            _messageManager = new MessageManager();
            _messageManager.AddReceiveMessage(this.createViewPersonResultMessage());
            _messageManager.AddReceiveMessage(this.createViewPersonMessage());

        }

        private Message createViewPersonMessage()
        {
            #region
            this._viewPersonMessage = new ViewPersonMessage();
            this._viewPersonMessage.ViewPersonToConsole =
                new ViewPersonMessage.DlViewPersonToConsole((person) =>
                {
                    Console.WriteLine(@"学生编号：{0}
学生姓名：{1}", person.Id, person.Name);
                });
            return this._viewPersonMessage;
            #endregion
        }

        private Message createViewPersonResultMessage()
        {
            #region
            this._viewPersonResultMessage = new ViewPersonResultMessage();
            this._viewPersonResultMessage.ViewPersonResult =
                 new ViewPersonResultMessage.DlViewPersonResult((result) =>
                 {
                     this.label2.Text = string.Format("***学生的成绩是{0}", result);
                 });
            return this._viewPersonResultMessage;
            #endregion
        }
    }
}
