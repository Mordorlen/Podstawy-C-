using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6._6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadeklaruj tablicę zawierającą nazwy dni tygodnia. Wypisz elementy tablicy za pomocą pętli
            //foreach
            string[] tab = new string[7] { "Poniedziałek", "Wtorek", "Środa", "Czwartek", "Piątek", "Sobota", "Niedziela" };
            foreach (string day in tab)
            {
                Console.WriteLine(day);
            }
            Console.ReadKey();
        }
    }
}
