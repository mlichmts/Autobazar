using property;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace skuska
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Auto.rok);
          
            Random r = new Random();
            
            List<Auto> auticka = new List<Auto>();
            auticka.Add(new Auto("Skoda", r.Next(0, 400000),"red"));
            auticka.Add(new Auto("Audi", r.Next(0, 400000),"yello"));
            
            while (true)
            {

                for (int i = 0; i < auticka.Count; i++)
                {
                    if (auticka[i].Km < 1000)
                    {
                        auticka[i].Stav = Stav.novy;
                    }
                    else if (auticka[i].Km > 100 && auticka[i].Km < 100000)
                    {
                        auticka[i].Stav = Stav.skvely;
                    }
                    else
                    {
                        auticka[i].Stav = Stav.opotrebene;
                    }
                }
              

                Console.WriteLine("Upravit/Zobrazit");
                string value = Console.ReadLine();
                if (value == "Upravit")
                {
                    Console.WriteLine("Znacka/KM/Farba/nove auto");
                    string co = Console.ReadLine();
                    if (co == "nove auto")
                    {
                        Console.WriteLine("zadaj znacku");
                        string zn = Console.ReadLine();
                        Console.WriteLine("zadaj km");
                        int kmm = int.Parse(Console.ReadLine());
                        Console.WriteLine("zadaj farbu");
                        string ff = Console.ReadLine();
                        auticka.Add(new Auto(zn,kmm,ff));
                    }
                    if (co == "Znacka")
                    {
                        Console.WriteLine("pozicia auta v liste");
                        int poz = int.Parse(Console.ReadLine());
                        Console.WriteLine(auticka[poz - 1].Znacka + "\t" + "\t" + auticka[poz - 1].Km + " km" + "\t" + auticka[poz - 1].Stav);
                        Console.WriteLine("Zadaj novu znacku");
                        string znac = Console.ReadLine();
                        auticka[poz - 1].Znacka = znac;
                        Console.WriteLine("Upravene:");
                        Console.WriteLine(auticka[poz - 1].Znacka + "\t" + "\t" + auticka[poz - 1].Km + " km" + "\t" + auticka[poz - 1].Stav);
                    }
                    else if (co == "KM")
                    {
                        Console.WriteLine("pozicia auta v liste");
                        int poz = int.Parse(Console.ReadLine());
                        Console.WriteLine(auticka[poz - 1].Znacka + "\t" + "\t" + auticka[poz - 1].Km + " km" + "\t" + auticka[poz - 1].Stav);
                        Console.WriteLine("Zadaj nové kilometre");
                        int kilom = int.Parse(Console.ReadLine());
                        auticka[poz - 1].Km = kilom;
                        Console.WriteLine("Upravene:");
                        for (int i = 0; i < auticka.Count; i++)
                        {
                            if (auticka[i].Km < 1000)
                            {
                                auticka[i].Stav = Stav.novy;
                            }
                            else if (auticka[i].Km > 100 && auticka[i].Km < 100000)
                            {
                                auticka[i].Stav = Stav.skvely;
                            }
                            else
                            {
                                auticka[i].Stav = Stav.opotrebene;
                            }
                        }

                        Console.WriteLine(auticka[poz - 1].Znacka + "\t" + "\t" + auticka[poz - 1].Km + " km" + "\t" + auticka[poz - 1].Stav + "\t" + auticka[poz - 1].Farba);
                    }
                    else if (co == "Farba")
                    {
                        Console.WriteLine("pozicia auta v liste");
                        int poz = int.Parse(Console.ReadLine());
                        Console.WriteLine(auticka[poz - 1].Znacka + "\t" + "\t" + auticka[poz - 1].Km + " km" + "\t" + auticka[poz - 1].Stav + "\t" + auticka[poz - 1].Farba);
                        Console.WriteLine("Zadaj novu Farbu");
                        string farb = Console.ReadLine();
                        auticka[poz - 1].Farba = farb;
                        Console.WriteLine("Upravene:");
                        Console.WriteLine(auticka[poz - 1].Znacka + "\t" + "\t" + auticka[poz - 1].Km + " km" + "\t" + auticka[poz - 1].Stav + "\t" + auticka[poz - 1].Farba);
                    }

                }
                if (value == "Zobrazit")
                {
                    Console.WriteLine("znacka:" + "\t" + "\t" + "najazdene km:" + "\t" + "Stav" + "\t" +"        "+"Farba:");
                    Console.WriteLine("-----------------------------------------------");
                    for (int i = 0; i < auticka.Count; i++)
                    {
                        Console.WriteLine(auticka[i].Znacka + "\t" + "\t" + auticka[i].Km + " km" + "\t" + auticka[i].Stav + "\t" + auticka[i].Farba);
                        Console.WriteLine("-----------------------------------------------");
                    }
                }

            }

            
        }

    }
}
