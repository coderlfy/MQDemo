using AppHandleMessage;
using MQEntity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLLMessage
{
    public class ViewPersonMessage : Message
    {
        public override object GetData()
        {
            return this._person;
        }

        public override void Receive(string json)
        {
            #region
            Person person = JsonConvert.
                DeserializeObject<Person>(
                json, JsonHelper.JsParseSetting);

            if (this.ViewPersonToConsole != null)
                this.ViewPersonToConsole(person);
            #endregion

        }

        private Person _person = null;

        public delegate void DlViewPersonToConsole(
            Person person);
        public DlViewPersonToConsole ViewPersonToConsole { get; set; }
        public ViewPersonMessage()
        {
            base.MessageCode = MessageIntCode.ViewPersonMessage;
        }

        public bool SendViewPersonMsg(
            Person person)
        {
            base.ToControls = new List<IntPtr>();
            base.ToControls.Add(ControlSet.MainFormHandle);
            this._person = person;
            base.Send();
            return true;
        }

    }
}
