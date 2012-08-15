using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace FirstSignalR.Model
{
    public class ChatMessage
    {
        [DisplayName("Session ID: ")]
        public string SessionId { get; set; }

        [DisplayName("Message: ")]
        public string Message { get; set; }

        [DisplayName("Name: ")]
        public string Name { get; set; }
    }
}