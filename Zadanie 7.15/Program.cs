using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_7._15
{
    //Napisać procedurę rysującą na ekranie z gwiazdek choinkę dla zadanej wartości jej
    //wysokości.Napisz program testujący utworzoną procedurę.
    internal class Program
    {
        static void RysujChoinke(int wysokosc)
        {
            for (int i = 0; i < wysokosc; i++)
            {
                // Rysowanie spacji
                for (int j = 0; j < wysokosc - i - 1; j++)
                {
                    Console.Write(" ");
                }
                // Rysowanie gwiazdek
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wysokość choinki: ");
            int wysokosc = int.Parse(Console.ReadLine());
            RysujChoinke(wysokosc);
            Console.ReadKey();
        }
    }
}
