using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestMerge.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Welcome to ASP.NET MVC!";
            //Logon view page
            return View();
        }

        public ActionResult About()
        {
            //Redirecting to Home Page.   
            return View();
        }
    }
}
