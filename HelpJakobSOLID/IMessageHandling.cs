using System;
using System.Collections.Generic;
using System.Text;
using static HelpJakobSOLID.Message;

namespace HelpJakobSOLID
{
    interface IMessageHandling
    {
        void sendMessage(MessageCarrier type, Message m, bool isHTML);
        void sendMessageToAll(MessageCarrier type, string[] to, Message m, bool isHTML);
    }
}
