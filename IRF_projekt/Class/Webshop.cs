using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRF_projekt
{
    class Webshop
    {
        public int Rendeles_Id { get; set; }
        public string Login { get; set; }
        public string Nev { get; set; }
        public string email { get; set; }
        public DateTime Szul_Datum { get; set; }
        public string Telefon { get; set; }
        public string Cim { get; set; }
        public DateTime Rend_Ideje { get; set; }
        public string Rendelt_Termek { get; set; }
        public int Mennyiseg { get; set; }
        public decimal egysegar { get; set; }
        public decimal Összesen { get; set; }
    }
}
