using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SEPROJECT.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "RESUME MANAGEMENT description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "RESUME MANAGEMENT contact page.";

            return View();
        }
    }
}