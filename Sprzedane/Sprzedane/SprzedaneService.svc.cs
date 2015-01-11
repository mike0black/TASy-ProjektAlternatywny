using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;

namespace Sprzedane
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SprzedaneService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SprzedaneService.svc or SprzedaneService.svc.cs at the Solution Explorer and start debugging.
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class SprzedaneService : ISprzedaneService
    {
        public IList<Przedmioty> GetPrzedmioty(string term)
        {
            SprzedaneEntities dc = new SprzedaneEntities();
            IList<Przedmioty> ListaPrzedmiotow = (from p in dc.Przedmioties
                where p.Nazwa.ToLower().Contains(term.ToLower())
                select new Przedmioty() { ID = p.ID, Nazwa = p.Nazwa, Kategoria = p.Kategoria, Cena = p.Cena,
                    DataZakonczenia = p.DataZakonczenia, Wystawiajacy = p.Wystawiajacy, Wygrywajacy = p.Wygrywajacy }).ToList();
            return ListaPrzedmiotow;
        }
        public IList<Przedmioty> GetAllPrzedmioty()
        {
            SprzedaneEntities dc = new SprzedaneEntities();
            IList<Przedmioty> ListaPrzedmiotow = (from p in dc.Przedmioties select new Przedmioty()
            {
                ID = p.ID, Nazwa = p.Nazwa, Kategoria = p.Kategoria, Cena = p.Cena,
                DataZakonczenia = p.DataZakonczenia, Wystawiajacy = p.Wystawiajacy, Wygrywajacy = p.Wygrywajacy
            }).ToList();
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
                Wygrywajacy = null
            };
            dc.Przedmioties.Add(przedmiot);
            dc.SaveChanges();
        }

        public void DeletePrzedmiot(Przedmioty p)
        {
            SprzedaneEntities dc = new SprzedaneEntities();
            var przedmiot = new Przedmioties
            {
                Nazwa = p.Nazwa,
                Kategoria = p.Kategoria,
                Cena = p.Cena,
                DataZakonczenia = p.DataZakonczenia,
                Wystawiajacy = p.Wystawiajacy,
                Wygrywajacy = p.Wygrywajacy
            };
            dc.Przedmioties.Remove(przedmiot);
            dc.SaveChanges();
        }

        public void EditPrzedmiot(Przedmioty p)
        {
            SprzedaneEntities dc = new SprzedaneEntities();
            dc.Przedmioties.SqlQuery("Update dbo.Przedmioties " +
                "Set Nazwa = @p.Nazwa, Kategoria = @p.Kategoria, Cena = @p.Cena, " +
                "DataZakonczenia = @p.DataZakonczenia, Wystawiajacy = @p.Wystawiajacy, Wygrywajacy = @p.Wygrywajacy" +
                "Where ID = @p.ID", p.ID, p.Nazwa, p.Kategoria, p.Cena, p.DataZakonczenia, p.Wystawiajacy, p.Wygrywajacy);
            dc.SaveChanges();
        }
    }
}
