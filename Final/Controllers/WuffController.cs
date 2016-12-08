using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Final.Controllers
{
    public class WuffController : Controller
    {
        // GET: Wuff
        public ActionResult Index()
        {
            return View();
        }

        public string SomeCrap()
        {
            string sysTime = System.DateTime.UtcNow.ToString();
            string msg = HttpUtility.HtmlEncode("Right now is " + sysTime);
        
            return msg;
        }

        public string Counter(int num=1)
        {
            return HttpUtility.HtmlEncode("Counter is: " + num);
        }
    }
}