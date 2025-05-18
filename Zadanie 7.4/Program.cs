using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_7._4
{
    //Napisz funkcję o nazwie ile_cyfr, która wyznacza liczbę cyfr dla zadanej liczby naturalnej jako
    //argument tej funkcji.Napisz program wykorzystujący funkcję ile_cyfr.
    class Program
    {
        static int IleCyfr(int liczba)
        {
            int licznik = 0;
            while (liczba > 0)
            {
                liczba /= 10;
                licznik++;
            }
            return licznik;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Liczba cyfr w liczbie 12345 to: {0}", IleCyfr(12345));
        }
    }
}