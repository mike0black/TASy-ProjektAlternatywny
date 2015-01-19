using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;
using System.Web.ModelBinding;

namespace Sprzedane
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SprzedaneService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SprzedaneService.svc or SprzedaneService.svc.cs at the Solution Explorer and start debugging.
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]

    public class SprzedaneService : ISprzedaneService
    {
        public IList<Przedmioty> GetPrzedmiot(string id)
        {
            SprzedaneEntities dc = new SprzedaneEntities();
            IList<Przedmioty> ListaPrzedmiotow = (from p in dc.Przedmioties
                where p.ID.ToString().ToLower().Contains(id.ToLower())
                select new Przedmioty() { ID = p.ID, Nazwa = p.Nazwa, Kategoria = p.Kategoria, Cena = p.Cena,
                    DataZakonczenia = p.DataZakonczenia, Wystawiajacy = p.Wystawiajacy, Wygrywajacy = p.Wygrywajacy, Opis = p.Opis }).ToList();
            return ListaPrzedmiotow;
        }

        public IList<Przedmioty> GetAllPrzedmioty()
        {
            SprzedaneEntities dc = new SprzedaneEntities();
            IList<Przedmioty> ListaPrzedmiotow = (from p in dc.Przedmioties select new Przedmioty()
            {
                ID = p.ID, Nazwa = p.Nazwa, Kategoria = p.Kategoria, Cena = p.Cena,
                DataZakonczenia = p.DataZakonczenia,
                Wystawiajacy = p.Wystawiajacy,
                Wygrywajacy = p.Wygrywajacy,
                Opis = p.Opis
            }).ToList();
            return ListaPrzedmiotow;
        }

        public IList<Przedmioty> GetPrzedmiotyBy(string term, string by)
        {
            SprzedaneEntities dc = new SprzedaneEntities();
            List<Przedmioty> ListaPrzedmiotow = new List<Przedmioty>();
            switch (by)
            {
                case "ID":
                    ListaPrzedmiotow = (from p in dc.Przedmioties
                                        where p.ID.ToString().ToLower().Contains(term.ToLower())
                                        select new Przedmioty()
                                        {
                                            ID = p.ID,
                                            Nazwa = p.Nazwa,
                                            Kategoria = p.Kategoria,
                                            Cena = p.Cena,
                                            DataZakonczenia = p.DataZakonczenia,
                                            Wystawiajacy = p.Wystawiajacy,
                                            Wygrywajacy = p.Wygrywajacy,
                                            Opis = p.Opis
                                        }).ToList();
                    break;
                case "Nazwa":
                    ListaPrzedmiotow = (from p in dc.Przedmioties
                                        where p.Nazwa.ToLower().Contains(term.ToLower())
                                        select new Przedmioty()
                                        {
                                            ID = p.ID,
                                            Nazwa = p.Nazwa,
                                            Kategoria = p.Kategoria,
                                            Cena = p.Cena,
                                            DataZakonczenia = p.DataZakonczenia,
                                            Wystawiajacy = p.Wystawiajacy,
                                            Wygrywajacy = p.Wygrywajacy,
                                            Opis = p.Opis
                                        }).ToList();
                    break;
                case "Kategoria":
                    ListaPrzedmiotow = (from p in dc.Przedmioties
                                        where p.Kategoria.ToLower().Contains(term.ToLower())
                                        select new Przedmioty()
                                        {
                                            ID = p.ID,
                                            Nazwa = p.Nazwa,
                                            Kategoria = p.Kategoria,
                                            Cena = p.Cena,
                                            DataZakonczenia = p.DataZakonczenia,
                                            Wystawiajacy = p.Wystawiajacy,
                                            Wygrywajacy = p.Wygrywajacy,
                                            Opis = p.Opis
                                        }).ToList();
                    break;
                case "Cena":
                    ListaPrzedmiotow = (from p in dc.Przedmioties
                                        where p.Cena.ToString().ToLower().Contains(term.ToLower())
                                        select new Przedmioty()
                                        {
                                            ID = p.ID,
                                            Nazwa = p.Nazwa,
                                            Kategoria = p.Kategoria,
                                            Cena = p.Cena,
                                            DataZakonczenia = p.DataZakonczenia,
                                            Wystawiajacy = p.Wystawiajacy,
                                            Wygrywajacy = p.Wygrywajacy,
                                            Opis = p.Opis
                                        }).ToList();
                    break;
                case "Wystawiajacy":
                    ListaPrzedmiotow = (from p in dc.Przedmioties
                                        where p.Wystawiajacy.ToLower().Contains(term.ToLower())
                                        select new Przedmioty()
                                        {
                                            ID = p.ID,
                                            Nazwa = p.Nazwa,
                                            Kategoria = p.Kategoria,
                                            Cena = p.Cena,
                                            DataZakonczenia = p.DataZakonczenia,
                                            Wystawiajacy = p.Wystawiajacy,
                                            Wygrywajacy = p.Wygrywajacy,
                                            Opis = p.Opis
                                        }).ToList();
                    break;
                case "Wygrywajacy":
                    ListaPrzedmiotow = (from p in dc.Przedmioties
                                        where p.Wygrywajacy.ToLower().Contains(term.ToLower())
                                        select new Przedmioty()
                                        {
                                            ID = p.ID,
                                            Nazwa = p.Nazwa,
                                            Kategoria = p.Kategoria,
                                            Cena = p.Cena,
                                            DataZakonczenia = p.DataZakonczenia,
                                            Wystawiajacy = p.Wystawiajacy,
                                            Wygrywajacy = p.Wygrywajacy,
                                            Opis = p.Opis
                                        }).ToList();
                    break;
            }
            return ListaPrzedmiotow;
        }

        public void AddPrzedmiot(Przedmioty p)
        {
            SprzedaneEntities dc = new SprzedaneEntities();
            var przedmiot = new Przedmioties
            {
                Nazwa = p.Nazwa,
                Kategoria = p.Kategoria,
                Cena = p.Cena,
                DataZakonczenia = p.DataZakonczenia,
                Wystawiajacy = p.Wystawiajacy,
                Wygrywajacy = null,
                Opis = p.Opis
            };
            dc.Przedmioties.Add(przedmiot);
            dc.SaveChanges();
        }

        public void DeletePrzedmiot(Przedmioty p)
        {
            SprzedaneEntities dc = new SprzedaneEntities();
            var przedmiot = dc.Przedmioties.Find(p.ID);
            dc.Przedmioties.Remove(przedmiot);
            dc.SaveChanges();
        }

        public void EditPrzedmiot(Przedmioty p)
        {
            SprzedaneEntities dc = new SprzedaneEntities();
            var przedmiot = new Przedmioties
            {
                ID = p.ID,
                Nazwa = p.Nazwa,
                Kategoria = p.Kategoria,
                Cena = p.Cena,
                DataZakonczenia = p.DataZakonczenia,
                Wystawiajacy = p.Wystawiajacy,
                Wygrywajacy = p.Wygrywajacy,
                Opis = p.Opis
            };
            dc.Entry(przedmiot).State = EntityState.Modified;
            dc.SaveChanges();
        }

        public Portfele GetPortfel(string id)
        {
            Portfele portfel = new Portfele();
            SprzedaneEntities dc = new SprzedaneEntities();
            List<Portfele> Lista = (from p in dc.MoneyAccounts //where p.UserID == id
                select new Portfele() { AccountID = p.AccountID, UserID = p.UserID, Saldo = (float)p.Saldo }).ToList();
            foreach (Portfele p in Lista)
            {
                if(p.UserID == id) portfel = p;
            }
            return portfel;
        }

        public IList<Portfele> GetAllPortfele()
        {
            SprzedaneEntities dc = new SprzedaneEntities();
            IList<Portfele> Lista = (from p in dc.MoneyAccounts
                select new Portfele() { AccountID = p.AccountID, UserID = p.UserID, Saldo = (float)p.Saldo }).ToList();
            return Lista;
        }

        public void AddPortfel(Portfele p)
        {
            SprzedaneEntities dc = new SprzedaneEntities();
            var portfel = new MoneyAccounts
            {
                UserID = p.UserID,
                Saldo = (float)0.00
            };
            dc.MoneyAccounts.Add(portfel);
            dc.SaveChanges();
        }

        public void DeletePortfel(Portfele p)
        {
            SprzedaneEntities dc = new SprzedaneEntities();
            Portfele p1 = new Portfele();
            List<Portfele> Lista = (from portfel in dc.MoneyAccounts //where p.UserID == id
                                    select new Portfele() { AccountID = portfel.AccountID, UserID = portfel.UserID, Saldo = (float)portfel.Saldo }).ToList();
            foreach (Portfele p2 in Lista)
            {
                if (p2.UserID == p.UserID) p1 = p2;
            }
            var portfel1 = new MoneyAccounts
            {
                AccountID = p1.AccountID,
                UserID = p1.UserID,
                Saldo = p1.Saldo
            };
            dc.MoneyAccounts.Remove(portfel1);
            dc.SaveChanges();
        }

        public void SetSaldo(Portfele p)
        {
            SprzedaneEntities dc = new SprzedaneEntities();
            dc.MoneyAccounts.SqlQuery("Update dbo.Przedmioties " +
                "Set Saldo = @p.Saldo Where UserID = @p.UserID", p.Saldo, p.UserID);
            dc.SaveChanges();

        }
    }
}
