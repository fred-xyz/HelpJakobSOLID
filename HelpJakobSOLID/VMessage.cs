using System;
using System.Collections.Generic;
using System.Text;

namespace HelpJakobSOLID
{
    class VMessage : Message, IMessageHandling
    {
        //the class forwards messages by using VMessage
        public VMessage(string to, string from, string body, string subject, string cc) : base(to, from, body, subject, cc)
        {

        }
        public void sendMessage(MessageCarrier type, Message m, bool isHTML)
        {
            if (type.Equals(MessageCarrier.VMessage))
            {
                if (isHTML)
                    m.Body = ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via VMessage
            }
        }

        public void sendMessageToAll(MessageCarrier type, string[] to, Message m, bool isHTML)
        {
            if (type.Equals(MessageCarrier.VMessage))
            {
                if (isHTML)
                    m.Body = ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via VMessage
            }
        }
    }
}
