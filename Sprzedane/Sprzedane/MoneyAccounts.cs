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
    
    public partial class MoneyAccounts
    {
        public int AccountID { get; set; }
        public string UserID { get; set; }
        public Nullable<double> Saldo { get; set; }
    
        public virtual AspNetUsers AspNetUsers { get; set; }
    }
}
