using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SprzedaneWebMVC.Models
{
    public class Portfel
    {
        [Required]
        public int AccountID { get; set; }
        [Required]
        public string UserID { get; set; }
        [DataType(DataType.Currency)]
        public float Saldo { get; set; }
    }
}