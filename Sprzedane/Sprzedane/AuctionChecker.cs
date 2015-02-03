using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Web;


namespace Sprzedane
{
    public class AuctionChecker
    {
        public void refreshAuction()
        {

            SprzedaneEntities dc = new SprzedaneEntities();
            IList<Przedmioty> ListaPrzedmiotow = (from p in dc.Przedmioties
                                                  select new Przedmioty()
                                                  {
                                                      ID = p.ID,
                                                      Nazwa = p.Nazwa,
                                                      Kategoria = p.Kategoria,
                                                      Cena = p.Cena,
                                                      DataZakonczenia = p.DataZakonczenia,
                                                      Wystawiajacy = p.Wystawiajacy,
                                                      Wygrywajacy = p.Wygrywajacy,
                                                      Opis = p.Opis,
                                                      Zakonczona = p.Zakonczona
                                                  }).ToList();
            

            foreach( Przedmioty p in ListaPrzedmiotow)
            {
                if (DateTime.Compare(p.DataZakonczenia, DateTime.Now) < 0)
                {
                    SprzedaneEntities dc2 = new SprzedaneEntities();
                    var przedmiot = new Przedmioties
                    {
                        ID = p.ID,
                        Nazwa = p.Nazwa,
                        Kategoria = p.Kategoria,
                        Cena = p.Cena,
                        DataZakonczenia = p.DataZakonczenia,
                        Wystawiajacy = p.Wystawiajacy,
                        Wygrywajacy = p.Wygrywajacy,
                        Opis = p.Opis,
                        Zakonczona = true
                    };
                    dc2.Entry(przedmiot).State = EntityState.Modified;
                    dc2.SaveChanges();
  //                  TimeSpan t = new TimeSpan(0, 1, 0);
 //                   Thread.Sleep(t);
                
                }
            }
        }
    }
}