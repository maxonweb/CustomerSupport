using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstSignalR.Model;
using FirstSignalR.SignalR;
using SignalR;

namespace FirstSignalR.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var message = new ChatMessage
                {
                    Message = String.Empty,
                    Name = String.Empty,
                    SessionId = HttpContext.Session.SessionID
                };
            return View(message);
        }

        //
        // GET: /Home/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Home/Create

        [HttpPost]
        public ActionResult Create(string Name, string Message, string SessionId)
        {
            try
            {
                var context = GlobalHost.ConnectionManager.GetHubContext<ChatMessageHub>();
                context.Clients.Send(Name, Message, SessionId);

                return View();
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Get()
        {
            return View();
        }
    }
}
