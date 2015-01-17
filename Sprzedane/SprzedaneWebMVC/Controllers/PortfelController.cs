using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Newtonsoft.Json;
using SprzedaneWebMVC.Models;
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
    [Authorize]
    public class PortfelController : Controller
    {
        readonly string SprzedaneServiceUri = "http://localhost:1622/SprzedaneService.svc/";
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Portfel
        public ActionResult Index(string id)
        {
            List<Portfel> Lista = new List<Portfel>();
            Portfel p = new Portfel();
            ApplicationUser user = (ApplicationUser)db.IdentityUsers.Where(u => u.UserName == id);
            id = user.Id;

            using (WebClient webClient = new WebClient())
            {
                string dwml;
                dwml = webClient.DownloadString(SprzedaneServiceUri + "portfele/" + id);
                Lista = JsonConvert.DeserializeObjectAsync<IList<Portfel>>(dwml).Result.ToList();
            }
            foreach (Portfel item in Lista)
            {
                if (item.UserID == id) p = item;
            }

            return View(p);
        }

        public ActionResult SetSaldo(string id)
        {
            List<Portfel> Lista = new List<Portfel>();
            Portfel p = new Portfel();
            ApplicationUser user = (ApplicationUser)db.IdentityUsers.Where(u => u.UserName == id);
            id = user.Id;

            using (WebClient webClient = new WebClient())
            {
                string dwml;
                dwml = webClient.DownloadString(SprzedaneServiceUri + "portfele/" + id);
                Lista = JsonConvert.DeserializeObjectAsync<IList<Portfel>>(dwml).Result.ToList();
            }
            foreach (Portfel item in Lista)
            {
                if (item.UserID == id) p = item;
            }

            return View(p);
        }

        [HttpPost]
        public ActionResult SetSaldo(Portfel p)
        {
            using (WebClient webClient = new WebClient())
            {
                MemoryStream ms = new MemoryStream();
                DataContractJsonSerializer serializerToUplaod = new DataContractJsonSerializer(typeof(Przedmiot));
                serializerToUplaod.WriteObject(ms, p);
                webClient.Headers["Content-type"] = "application/json";
                webClient.UploadData(SprzedaneServiceUri + "portfele/set", "POST", ms.ToArray());
            }

            return RedirectToAction("Index");
        }
    }
}