using Newtonsoft.Json;
using SprzedaneWebMVC.Models;
using SprzedaneWebMVC.SprzedaneReference;
using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;

namespace SprzedaneWebMVC.Controllers
{
    public class WyszukiwarkaController : Controller
    {
        readonly string SprzedaneServiceUri = "http://localhost:1622/SprzedaneService.svc/";
        
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
            //SprzedaneServiceClient Service = new SprzedaneServiceClient();
            //IList<Przedmioty> Lista = Service.GetPrzedmioty(name);
            List<Przedmiot> Lista = new List<Przedmiot>();

            using (WebClient webClient = new WebClient())
            {
                string dwml;
                string ResourceUri = SprzedaneServiceUri + "przedmioty/" + name;
                dwml = webClient.DownloadString(ResourceUri);
                Lista = JsonConvert.DeserializeObjectAsync<List<Przedmiot>>(dwml).Result;
            }

            ViewBag.Lista = Lista;
            return View();
        }
	}
}