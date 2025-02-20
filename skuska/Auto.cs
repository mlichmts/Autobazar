using property;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skuska
{
    internal class Auto
    {
        string znacka;
        int km;
        
        string farba;
        

        public static int rok = 2025;

        public Auto(string znacka, int pocetkm,string farba) {
            this.znacka = znacka;
            this.km = pocetkm;
            this.farba = farba;

        }

        public string Znacka
        {
            set { znacka = value; }
            get { return znacka; }
        }
        public int Km
        {
            set { km = value; }
            get { return km; }
        }

        public string Farba
        {
            set {  farba = value; }
            get { return farba; }
        }


       public Stav Stav
        {
                set;
                get;

        }
       
    }
}
