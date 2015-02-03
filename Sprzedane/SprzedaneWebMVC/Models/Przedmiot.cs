using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SprzedaneWebMVC.Models
{
    public class Przedmiot
    {
        [Required]
        [Display(Name= "ID")]
        public int ID { get; set; }
        [Required]
        [Display(Name= "Nazwa")]
        public String Nazwa { get; set; }
        [Required]
        [Display(Name= "Kategoria")]
        public String Kategoria { get; set; }
        [Required]
        [Display(Name= "Cena")]
        [DataType(DataType.Currency)]
        [Range(1.00, 10000000.00, ErrorMessage= "Minimalna {0} to 1.00 zł")]
        public double Cena { get; set; }
        [Required]
        [Display(Name= "Data Zakonczenia")]
        [DataType(DataType.Date)]
        [Range(System.Type.GetType("DateTime"), DateTime.Now.Date.ToString(), DateTime.MaxValue.Date.ToString())]
        public DateTime DataZakonczenia { get; set; }
        [Required]
        [Display(Name= "Wystawiajacy")]
        public String Wystawiajacy { get; set; }
        [Display(Name= "Wygrywajacy")]
        public String Wygrywajacy { get; set; }
        [Display(Name = "Opis")]
        public String Opis { get; set; }
        [Display(Name = "Zakonczona")]
        public bool Zakonczona { get; set; }
    }
}