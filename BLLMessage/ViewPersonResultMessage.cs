using AppHandleMessage;
using MQEntity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLLMessage
{
    public class ViewPersonResultMessage : Message
    {
        public override object GetData()
        {
            return this._result;
        }

        public override void Receive(string json)
        {
            #region
            if (this.ViewPersonResult != null)
                this.ViewPersonResult(int.Parse(json));
            #endregion

        }

        private int _result = 0;

        public delegate void DlViewPersonResult(
            int person);
        public DlViewPersonResult ViewPersonResult { get; set; }
        public ViewPersonResultMessage()
        {
            base.MessageCode = MessageIntCode.ViewPersonResultMessage;
        }

        public bool SendPersonResultMsg(
            int result)
        {
            base.ToControls = new List<IntPtr>();
            base.ToControls.Add(ControlSet.MainFormHandle);
            base.ToControls.Add(ControlSet.ResultViewCtrl);
            this._result = result;
            base.Send();
            return true;
        }

    }
}
