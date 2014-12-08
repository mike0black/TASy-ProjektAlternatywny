using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SprzedaneWebMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Tu powinien być opis projektu - Ale nie ma";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Nasze dane kontaktowe";

            return View();
        }
    }
}