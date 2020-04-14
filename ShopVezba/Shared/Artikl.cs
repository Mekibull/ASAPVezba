using System;
using System.Collections.Generic;
using System.Text;

namespace ShopVezba.Shared
{
    public class Artikl
    {
        public int ID { get; set; }
        public string Naziv { get; set; }
        public int Kolicina { get; set; }
        public double Cena { get; set; }

        public Artikl() { }
        public Artikl(string na,int ko,double ce)
        {
            Naziv = na;
            Kolicina = ko;
            Cena = ce;
        }
        public Artikl(string na, double ce)
        {
            Naziv = na;
            Cena = ce;
        }

        public override string ToString()
        {
            return $"{Naziv}----{Kolicina}------{Cena}";
        }
    }
}
