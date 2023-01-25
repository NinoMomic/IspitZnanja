using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] niz = {2.4, 4.6, 12.7, 56.2, 11.4};
            double Prosjek=0, Najmanji = niz[0], Broj;

            for(int i = 0; i < niz.Length; i++)
            {
                Prosjek += niz[i];
            }
            Prosjek /= niz.Length;
            for(int i = 0; i < niz.Length;i++)
            {
                Broj = niz[i];
                if(Broj < Prosjek)
                {
                    if(Prosjek - Broj > Najmanji)
                    {
                        Najmanji = Broj;
                    }
                }
                else
                {
                    if(Broj - Prosjek < Najmanji)
                    {
                        Najmanji = Broj;
                    }
                }
            }
            Console.WriteLine("Najbliži broj prosjeku je: " + Najmanji + ", a Prosjek je: " + Prosjek);

            Console.ReadKey();
        }
    }
}
