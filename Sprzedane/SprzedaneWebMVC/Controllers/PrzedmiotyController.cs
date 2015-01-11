using Newtonsoft.Json;
using SprzedaneWebMVC.Models;
using SprzedaneWebMVC.SprzedaneReference;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Web;
using System.Web.Mvc;

namespace SprzedaneWebMVC.Controllers
{
    public class PrzedmiotyController : Controller
    {
        readonly string SprzedaneServiceUri = "http://localhost:1622/SprzedaneService.svc/";
        
        public ActionResult Index(string id, string serchIn)
        {
            IEnumerable<Przedmiot> Lista = new List<Przedmiot>();
            var serchInList = new List<string>() {"ID", "Nazwa", "Kategoria", "Cena", "Wystawiajacy", "Wygrywajacy"};
            ViewBag.SerchIN = new SelectList(serchInList);

            using (WebClient webClient = new WebClient())
            {
                string dwml;
                dwml = webClient.DownloadString(SprzedaneServiceUri + "przedmioty");
                Lista = JsonConvert.DeserializeObjectAsync<List<Przedmiot>>(dwml).Result;
            }
            if (!String.IsNullOrEmpty(id) && !String.IsNullOrEmpty(serchIn))
            {
                switch (serchIn)
                {
                    case "ID":
                        Lista = Lista.Where(p => p.ID.ToString().ToLower().Contains(id.ToString().ToLower()));
                        break;
                    case "Nazwa":
                        Lista = Lista.Where(p => p.Nazwa.ToString().ToLower().Contains(id.ToString().ToLower()));
                        break;
                    case "Kategoria":
                        Lista = Lista.Where(p => p.Kategoria.ToString().ToLower().Contains(id.ToString().ToLower()));
                        break;
                    case "Cena":
                        Lista = Lista.Where(p => p.Cena.ToString().ToLower().Contains(id.ToString().ToLower()));
                        break;
                    case "Wystawiajacy":
                        Lista = Lista.Where(p => p.Wystawiajacy.ToString().ToLower().Contains(id.ToString().ToLower()));
                        break;
                    case "Wygrywajacy":
                        Lista = Lista.Where(p => p.Wygrywajacy.ToString().ToLower().Contains(id.ToString().ToLower()));
                        break;
                }     
            }

            return View(Lista);
        }

        public ActionResult Detale(int id)
        {
            List<Przedmiot> Lista = new List<Przedmiot>();
            Przedmiot p = new Przedmiot();

            using (WebClient webClient = new WebClient())
            {
                string dwml;
                dwml = webClient.DownloadString(SprzedaneServiceUri + "przedmioty");
                Lista = JsonConvert.DeserializeObjectAsync<IList<Przedmiot>>(dwml).Result.ToList();
            }
            //Przedmiot p = (Przedmiot)(from przedmiot in Lista where przedmiot.ID == id
            //    select new Przedmiot() { ID =  przedmiot.ID, Nazwa = przedmiot.Nazwa, Kategoria = przedmiot.Kategoria,
            //    Cena = przedmiot.Cena, DataZakonczenia = przedmiot.DataZakonczenia,
            //    Wystawiajacy = przedmiot.Wystawiajacy, Wygrywajacy = przedmiot.Wygrywajacy });
            foreach (Przedmiot item in Lista)
            {
                if (item.ID == id) p = item;
            }

            return View(p);
        }

        public ActionResult Dodaj()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Dodaj(Przedmiot p)
        {
                        
            using (WebClient webClient = new WebClient())
            {
                MemoryStream ms = new MemoryStream();
                DataContractJsonSerializer serializerToUplaod = new DataContractJsonSerializer(typeof(Przedmiot));
                serializerToUplaod.WriteObject(ms, p);
                webClient.Headers["Content-type"] = "application/json";
                webClient.UploadData(SprzedaneServiceUri + "przedmioty/add", "POST", ms.ToArray());
            }
            
            return RedirectToAction("Index");
        }

        public ActionResult Usun(int id)
        {
            List<Przedmiot> Lista = new List<Przedmiot>();
            Przedmiot p = new Przedmiot();

            using (WebClient webClient = new WebClient())
            {
                string dwml;
                dwml = webClient.DownloadString(SprzedaneServiceUri + "przedmioty");
                Lista = JsonConvert.DeserializeObjectAsync<IList<Przedmiot>>(dwml).Result.ToList();
            }
            foreach (Przedmiot item in Lista)
            {
                if (item.ID == id) p = item;
            }
            
            return View(p);
        }

        [HttpPost]//[HttpDelete]
        public ActionResult Usun(Przedmiot p)
        {
            using (WebClient webClient = new WebClient())
            {
                MemoryStream ms = new MemoryStream();
                DataContractJsonSerializer serializerToUplaod = new DataContractJsonSerializer(typeof(Przedmiot));
                serializerToUplaod.WriteObject(ms, p);
                webClient.Headers["Content-type"] = "application/json";
                webClient.UploadData(SprzedaneServiceUri + "przedmioty/delete", "DELETE", ms.ToArray());
            }

            return RedirectToAction("Index");
        }

        public ActionResult Edytuj(int id)
        {
            List<Przedmiot> Lista = new List<Przedmiot>();
            Przedmiot p = new Przedmiot();

            using (WebClient webClient = new WebClient())
            {
                string dwml;
                dwml = webClient.DownloadString(SprzedaneServiceUri + "przedmioty");
                Lista = JsonConvert.DeserializeObjectAsync<IList<Przedmiot>>(dwml).Result.ToList();
            }
            foreach (Przedmiot item in Lista)
            {
                if (item.ID == id) p = item;
            }
            ViewBag.Przedmiot = p;

            return View();
        }

        [HttpPost]
        public ActionResult Edytuj(Przedmiot p)
        {
            using (WebClient webClient = new WebClient())
            {
                MemoryStream ms = new MemoryStream();
                DataContractJsonSerializer serializerToUplaod = new DataContractJsonSerializer(typeof(Przedmiot));
                serializerToUplaod.WriteObject(ms, p);
                webClient.Headers["Content-type"] = "application/json";
                webClient.UploadData(SprzedaneServiceUri + "przedmioty/edit", "PUT", ms.ToArray());
            }

            return RedirectToAction("Index");
        }
    }
}