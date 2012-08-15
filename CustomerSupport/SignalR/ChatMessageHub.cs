using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SignalR.Hubs;

namespace FirstSignalR.SignalR
{
    public class ChatMessageHub : Hub
    {
        public void Send(string name, string message, string sessionId)
        {
            Clients.SendMessage(name, message, sessionId);
        }
    }
}