using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite niz znakova: ");
            string s1 = Console.ReadLine();
            string s2 = s1.Replace(' ','_');
            Console.WriteLine(s2);

            Console.ReadKey();
        }
    }
}
