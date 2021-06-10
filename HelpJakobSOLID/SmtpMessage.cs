using System;
using System.Collections.Generic;
using System.Text;

namespace HelpJakobSOLID
{
    //the class forwards messages by using Smtp
    class SmtpMessage : Message, IMessageHandling
    {
        public SmtpMessage(string to, string from, string body, string subject, string cc) : base(to, from, body, subject, cc)
        {

        }
        public void sendMessage(MessageCarrier type, Message m, bool isHTML)
        {
            //herinde sendes der en email ud til modtageren
            if (type.Equals(MessageCarrier.Smtp))
            {
                if (isHTML)
                    m.Body = ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via Smtp
            }
        }
        public void sendMessageToAll(MessageCarrier type, string[] to, Message m, bool isHTML)
        {
            if (type.Equals(MessageCarrier.Smtp))
            {
                if (isHTML)
                    m.Body = ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via Smtp
            }
        }
    }
}
