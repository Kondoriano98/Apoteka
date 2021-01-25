using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Apoteka.Models
{
    public class anketa:kontakt
    {
        public string Pitanje1 { get; set; }
        public string Pitanje2 { get; set; }
        public string Pitanje3 { get; set; }
        public int Broj { get; set; }
        public bool Anonimno { get; set; }
    }
}