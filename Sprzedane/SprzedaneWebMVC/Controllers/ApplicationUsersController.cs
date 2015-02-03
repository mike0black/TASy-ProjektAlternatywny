using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SprzedaneWebMVC.Models;
using Microsoft.AspNet.Identity;
using System.IO;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;

namespace SprzedaneWebMVC.Controllers
{
    public class ApplicationUsersController : Controller
    {
        readonly string SprzedaneServiceUri = "http://localhost:1622/SprzedaneService.svc/";
        
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ApplicationUsers
        public ActionResult Index()
        {
            return View(db.IdentityUsers.ToList());
        }

        // GET: ApplicationUsers/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApplicationUser applicationUser = db.IdentityUsers.Find(id);
            if (applicationUser == null)
            {
                return HttpNotFound();
            }
            return View(applicationUser);
        }

        // GET: ApplicationUsers/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: ApplicationUsers/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "UserName,Email,Imie,Nazwisko,Adres,KodPocztowy,Miasto,DataUrodzenia")] ApplicationUser applicationUser)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.IdentityUsers.Add(applicationUser);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(applicationUser);
        //}

        // GET: ApplicationUsers/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApplicationUser applicationUser = db.IdentityUsers.Find(id);
            if (applicationUser == null)
            {
                return HttpNotFound();
            }
            return View(applicationUser);
        }

        // POST: ApplicationUsers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,UserName,Email,Imie,Nazwisko,Adres,KodPocztowy,Miasto,DataUrodzenia")] ApplicationUser applicationUser)
        {
            if (ModelState.IsValid)
            {
                db.Entry(applicationUser).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(applicationUser);
        }

        // GET: ApplicationUsers/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApplicationUser applicationUser = db.IdentityUsers.Find(id);
            if (applicationUser == null)
            {
                return HttpNotFound();
            }
            return View(applicationUser);
        }

        // POST: ApplicationUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            /////
            //using (WebClient webClient = new WebClient())
            //{
            //    string dwml;
            //    Portfel p = new Portfel();
            //    dwml = webClient.DownloadString(SprzedaneServiceUri + "portfele/" + id);
            //    p = JsonConvert.DeserializeObjectAsync<Portfel>(dwml).Result;
                
            //    MemoryStream ms2 = new MemoryStream();
            //    DataContractJsonSerializer serializerToUplaod = new DataContractJsonSerializer(typeof(Portfel));
            //    serializerToUplaod.WriteObject(ms2, p);
            //    webClient.Headers["Content-type"] = "application/json";
            //    webClient.UploadData(SprzedaneServiceUri + "portfele/delete", "POST", ms2.ToArray());
            //}
            /////
            
            ApplicationUser applicationUser = db.IdentityUsers.Find(id);
            db.IdentityUsers.Remove(applicationUser);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
