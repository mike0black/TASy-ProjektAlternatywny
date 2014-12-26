using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SprzedaneWebMVC.Models
{
    public class Przedmiot
    {
        public int ID { get; set; }
        public String Nazwa { get; set; }
        public String Kategoria { get; set; }
        public double Cena { get; set; }
        public DateTime DataZakonczenia { get; set; }
        public String Wystawiajacy { get; set; }
    }
}