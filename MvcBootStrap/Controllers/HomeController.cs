using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBootStrap.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Index Page.";

            return View();
        }


        public ActionResult DashBoard()
        {
            ViewBag.Message = "App Dash Board.";

            return View();
        }

        public ActionResult Charts()
        {
            ViewBag.Message = "App Charts.";

            return View();
        }

        public ActionResult Table()
        {
            ViewBag.Message = "App Charts.";

            return View();
        }
    }
}
