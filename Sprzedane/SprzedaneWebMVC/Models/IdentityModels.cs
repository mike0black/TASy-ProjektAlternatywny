using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.ComponentModel.DataAnnotations;

namespace SprzedaneWebMVC.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string Email { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Adres { get; set; }
        public string KodPocztowy { get; set; }
        public string Miasto { get; set; }
        [DataType(DataType.Date)]
        public DateTime DataUrodzenia { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext//<ApplicationUser> ///POTENCJALNE BUBLE !!!!!!!
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
        
        public System.Data.Entity.DbSet<SprzedaneWebMVC.Models.ApplicationUser> IdentityUsers { get; set; }
    }
}