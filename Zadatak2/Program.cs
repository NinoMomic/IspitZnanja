using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Duljina;
            Console.WriteLine("Unesite prvi string: ");
            string PrviString = Console.ReadLine();
            Console.WriteLine("Unesite drugi string: ");
            string DrugiString = Console.ReadLine();
            if(PrviString.Length > DrugiString.Length)
            {
                Duljina = DrugiString.Length;
            }
            else
            {
                Duljina = PrviString.Length;
            }
            for(int i = 0; i < Duljina; i++)
            {
                if(PrviString[i] > DrugiString[i])
                {
                    Console.WriteLine(PrviString[i] + " " + DrugiString[i]);
                }
                else
                if(PrviString[i] < DrugiString[i])
                {
                    Console.WriteLine(PrviString[i] + " " + DrugiString[i]);
                }
            }

            Console.ReadKey();
        }
    }
}
