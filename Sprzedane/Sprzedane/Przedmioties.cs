//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sprzedane
{
    using System;
    using System.Collections.Generic;
    
    public partial class Przedmioties
    {
        public int ID { get; set; }
        public string Nazwa { get; set; }
        public string Kategoria { get; set; }
        public double Cena { get; set; }
        public System.DateTime DataZakonczenia { get; set; }
        public string Wystawiajacy { get; set; }
        public string Wygrywajacy { get; set; }
        public string Opis { get; set; }
        public bool Zakonczona { get; set; }
    }
}
