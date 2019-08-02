using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFirstApp3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Index = "Index";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Application Description Page.";
            ViewBag.MySuperProperty = "This is my first app";
            ViewBag.MyFirstName = "Marcus";
            ViewBag.MyLastName = "Beach";
            ViewBag.MyContactPhone = "Contact at 555-5555";
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Page.";
            ViewBag.MyContactPhone = "Contact at 555-5555";
            return View();
        }
    }
}