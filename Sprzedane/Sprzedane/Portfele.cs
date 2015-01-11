using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Sprzedane
{
    [DataContract]
    public class Portfele
    {
        [DataMember]
        public int AccountID { get; set; }
        [DataMember]
        public string UserID { get; set; }
        [DataMember]
        public float Saldo { get; set; }
    }
}