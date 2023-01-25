using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak5
{
    internal class Program
    {
        class NebeskoTijelo
        {
            public double BrzinaOkoOsi, BrzinaOkoSunca;

            class Planet : NebeskoTijelo
            {
                public Planet(double x, double y)
                {
                    BrzinaOkoOsi = x;
                    BrzinaOkoSunca = y;
                }

            }

            class Satelit : NebeskoTijelo
            {
                public Satelit(double x, double y)
                {
                    BrzinaOkoOsi = x;
                    BrzinaOkoSunca = y;
                }
            }

        }

        static void Main(string[] args)
        {
            Planet Zemlja = new Planet(24, 3.65);
            Satelit Mjesec = new Satelit(34, 5.456);
        }
    }
}
