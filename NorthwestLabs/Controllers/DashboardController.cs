using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwestLabs.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        
        public ActionResult Employee()
        {
            TempData["type"] = 2;
            return View();
        }
        public ActionResult CEO()
        {
            TempData["type"] = 1;
            return View();
        }

        public ActionResult ScheduleTest()
        {
            string hold;
            if (TempData["type"] == null)
            {
                 hold = "1";
            }
            else
            {
                 hold = TempData["type"].ToString();
            }
            
            if (hold == "1")
            {
                ViewBag.Link = "../Dashboard/CEO";
            }
            else
            {
                ViewBag.Link = "../Dashboard/Employee";
            }
            TempData["type"] = Convert.ToInt32(hold);

            return View();
        }

        public ActionResult Schedule()
        {
            string hold;
            if (TempData["type"] == null)
            {
                hold = "1";
            }
            else
            {
                hold = TempData["type"].ToString();
            }

            if (hold == "1")
            {
                ViewBag.Link = "../Dashboard/CEO";
            }
            else
            {
                ViewBag.Link = "../Dashboard/Employee";
            }
            TempData["type"] = Convert.ToInt32(hold);

            return View();
        }

        public ActionResult WorkOrders()
        {
            string hold;
            if (TempData["type"] == null)
            {
                hold = "1";
            }
            else
            {
                hold = TempData["type"].ToString();
            }

            if (hold == "1")
            {
                ViewBag.Link = "../Dashboard/CEO";
            }
            else
            {
                ViewBag.Link = "../Dashboard/Employee";
            }
            TempData["type"] = Convert.ToInt32(hold);

            return View();
        }
        
        public ActionResult CreateQuote()
        {
            string hold;
            if (TempData["type"] == null)
            {
                hold = "1";
            }
            else
            {
                hold = TempData["type"].ToString();
            }

            if (hold == "1")
            {
                ViewBag.Link = "../Dashboard/CEO";
            }
            else
            {
                ViewBag.Link = "../Dashboard/Employee";
            }
            TempData["type"] = Convert.ToInt32(hold);

            return View();
        }

        public ActionResult Client()
        {
            return View();
        }
        public ActionResult TestStatus()
        {
            return View();
        }
        public ActionResult ClientWorkOrders()
        {
            return View();
        }
        public ActionResult PayInvoice()
        {
            return View();
        }
    }
}