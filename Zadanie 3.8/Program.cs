using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wczytaj z klawiatury rok_początkowy i rok_końcowy oraz wypisz na ekranie wszystkie lata
            //przestępne od roku_początkowego do roku_końcowego włącznie. Użyj pętli for.
            Console.WriteLine("Podaj rok początkowy: ");
            int rok_poczatkowy = int.Parse(Console.ReadLine());
            int rok_koncowy = int.Parse(Console.ReadLine());
            for (int i = rok_poczatkowy; i <= rok_koncowy; i++)
            {
                if (i % 4 == 0 && i % 100 != 0 || i % 400 == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
