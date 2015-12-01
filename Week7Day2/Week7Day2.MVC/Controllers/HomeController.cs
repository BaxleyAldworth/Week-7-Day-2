using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Week7Day2.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "There is hope, but not for us.";

            return View();
        }

        /*
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        */

        //"classmates/list"
        public ActionResult List()
        {
            ViewBag.Message = "Your list of classmates.";

            return View();
        }

        //"classmates/PostWallMessage"
        public ActionResult PostWallMessage()
        {
            ViewBag.Message = "Messages:";

            return View();
        }
    }
}