using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
// --------------------------------------------------------------
// Group 1-1 INTEX 2016
// Carsen Beyer, Kate Cousineau, Kaitlyn Whipple, Joseph Isabell
// Northwest Labs Web App
// --------------------------------------------------------------
namespace NorthwestLabs.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

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

        public ActionResult Login()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}