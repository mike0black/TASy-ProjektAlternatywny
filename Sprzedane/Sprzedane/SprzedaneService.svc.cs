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
                                     DataZakonczenia = p.DataZakonczenia, WystawiajacyId = p.WystawiajacyId }).ToList();
            return ListaPrzedmiotow;
        }
    }
}
