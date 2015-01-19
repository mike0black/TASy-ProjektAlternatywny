using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Sprzedane
{
    [DataContract]
    public class Przedmioty
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public String Nazwa { get; set; }
        [DataMember]
        public String Kategoria { get; set; }
        [DataMember]
        public double Cena { get; set; }
        [DataMember]
        public DateTime DataZakonczenia { get; set; }
        [DataMember]
        public String Wystawiajacy { get; set; }
        [DataMember]
        public String Wygrywajacy { get; set; }
        [DataMember]
        public String Opis { get; set; }
    }
}