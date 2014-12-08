﻿using SprzedaneWebMVC.SprzedaneReference;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SprzedaneWebMVC.Controllers
{
    public class WyszukiwarkaController : Controller
    {
        //
        // GET: /Wyszukiwarka/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Wyszukiwarka/PoNazwie
        public ActionResult PoNazwie(string name)
        {
            SprzedaneServiceClient Service = new SprzedaneServiceClient();
            IList<Przedmioty> Lista = Service.GetPrzedmioty(name);
            ViewBag.Lista = Lista;

            return View();
        }
	}
}