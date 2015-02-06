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
        
        public ActionResult Index(string id, string serchIn, bool showEnded = true)
        {
            try
            {
                IEnumerable<Przedmiot> Lista = new List<Przedmiot>();
                var serchInList = new List<string>() { "ID", "Nazwa", "Kategoria", "Cena", "Wystawiajacy", "Wygrywajacy" };
                ViewBag.SerchIN = new SelectList(serchInList);
                ViewBag.ShowEnded = showEnded;

                if (!String.IsNullOrEmpty(id))
                {
                    using (WebClient webClient = new WebClient())
                    {
                        string dwml;
                        if(showEnded)
                            dwml = webClient.DownloadString(SprzedaneServiceUri + "przedmioty/" + id + "/" + serchIn + "/1");
                        else
                            dwml = webClient.DownloadString(SprzedaneServiceUri + "przedmioty/" + id + "/" + serchIn + "/2");
                        Lista = JsonConvert.DeserializeObjectAsync<List<Przedmiot>>(dwml).Result;
                    }
                }
                else
                {
                    using (WebClient webClient = new WebClient())
                    {
                        string dwml;
                        if (showEnded)
                            dwml = webClient.DownloadString(SprzedaneServiceUri + "przedmioty/1");
                        else
                            dwml = webClient.DownloadString(SprzedaneServiceUri + "przedmioty/2");
                        Lista = JsonConvert.DeserializeObjectAsync<List<Przedmiot>>(dwml).Result;
                    }
                }
                
                return View(Lista);
            }
            catch
            {
                return View("Error");
            }
        }

        public ActionResult Detale(int id)
        {
            try
            {
                List<Przedmiot> Lista = new List<Przedmiot>();
                Przedmiot p = new Przedmiot();

                using (WebClient webClient = new WebClient())
                {
                    string dwml;
                    dwml = webClient.DownloadString(SprzedaneServiceUri + "przedmioty/" + id.ToString());
                    Lista = JsonConvert.DeserializeObjectAsync<IList<Przedmiot>>(dwml).Result.ToList();
                }
                foreach (Przedmiot item in Lista)
                {
                    if (item.ID == id) p = item;
                }

                return View(p);
            }
            catch
            {
                return View("Error");
            }
        }

        public ActionResult Dodaj()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Dodaj(Przedmiot p)
        {
            p.Wystawiajacy = User.Identity.Name;
            if (p.DataZakonczenia > DateTime.Now)
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
            else
                return View("Error");
        }

        [Authorize]
        public ActionResult Usun(int id)
        {
            List<Przedmiot> Lista = new List<Przedmiot>();
            Przedmiot p = new Przedmiot();

            using (WebClient webClient = new WebClient())
            {
                string dwml;
                dwml = webClient.DownloadString(SprzedaneServiceUri + "przedmioty/" + id.ToString());
                Lista = JsonConvert.DeserializeObjectAsync<IList<Przedmiot>>(dwml).Result.ToList();
            }
            foreach (Przedmiot item in Lista)
            {
                if (item.ID == id) p = item;
            }

            if (User.Identity.Name == p.Wystawiajacy)
            {
                if (!p.Zakonczona)
                    return View(p);
                else
                    return View("ErrorAuctionEnded");
            }
            else
                return View("Error");
        }

        [HttpPost]
        public ActionResult Usun(Przedmiot p)
        {
            try
            {
                p.DataZakonczenia = DateTime.Now;
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
            catch
            {
                return View("Error");
            }
        }

        [Authorize]
        public ActionResult Edytuj(int id)
        {
            List<Przedmiot> Lista = new List<Przedmiot>();
            Przedmiot p = new Przedmiot();

            using (WebClient webClient = new WebClient())
            {
                string dwml;
                dwml = webClient.DownloadString(SprzedaneServiceUri + "przedmioty/" + id.ToString());
                Lista = JsonConvert.DeserializeObjectAsync<IList<Przedmiot>>(dwml).Result.ToList();
            }
            foreach (Przedmiot item in Lista)
            {
                if (item.ID == id) p = item;
            }
            if (User.Identity.Name == p.Wystawiajacy)
            {
                if (!p.Zakonczona)
                    return View(p);
                else
                    return View("ErrorAuctionEnded");
            }
            else
                return View("Error");
        }

        [HttpPost]
        public ActionResult Edytuj(Przedmiot p)
        {
            try
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
            catch
            {
                return View("Error");
            }
        }
        [Authorize]
        public ActionResult Podbij(int id)
        {
            List<Przedmiot> Lista = new List<Przedmiot>();
            Przedmiot p = new Przedmiot();

            using (WebClient webClient = new WebClient())
            {
                string dwml;
                dwml = webClient.DownloadString(SprzedaneServiceUri + "przedmioty/" + id.ToString());
                Lista = JsonConvert.DeserializeObjectAsync<IList<Przedmiot>>(dwml).Result.ToList();
            }
            foreach (Przedmiot item in Lista)
            {
                if (item.ID == id) p = item;
            }

            return View(p);
        }

        [HttpPost]
        public ActionResult Podbij(Przedmiot p)
        {
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    if (User.Identity.Name.ToString() != p.Wystawiajacy)
                    {
                        if (User.Identity.Name.ToString() != p.Wygrywajacy)
                        {
                            if (!p.Zakonczona)
                            {
                                p.Wygrywajacy = User.Identity.Name.ToString();
                                MemoryStream ms = new MemoryStream();
                                DataContractJsonSerializer serializerToUplaod = new DataContractJsonSerializer(typeof(Przedmiot));
                                serializerToUplaod.WriteObject(ms, p);
                                webClient.Headers["Content-type"] = "application/json";
                                webClient.UploadData(SprzedaneServiceUri + "przedmioty/bid", "PUT", ms.ToArray());
                            }

                            else
                            {
                                return View("ErrorAuctionSameUser");
                            }
                        }
                        else
                        {
                            return View("ErrorAuctionSameWinner");
                        }
                    }
                    else
                    {
                        return View("ErrorAuctionEnded");
                    }
                }


                return RedirectToAction("Index");
            }
            catch
            {
                return View("Error");
            }
        }
    }
}