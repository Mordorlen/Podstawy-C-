using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wczytaj z klawiatury dwie liczby naturalne a i b (0<a<b). Wyznacz wszystkie liczby parzyste z
            // przedziału[a, b].Użyj pętli while.

            Console.WriteLine("Podaj dwie liczby naturalne a i b (0 < a < b): ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a < 0 || a >= b)
            {
                Console.WriteLine("Podane liczby nie spełniają warunków zadania.");
            }
            else
            {
                Console.WriteLine("Liczby parzyste z przedziału [" + a + ", " + b + "]: ");
                while (a <= b)
                {
                    if (a % 2 == 0)
                    {
                        Console.Write(a + " ");
                    }
                    a++;
                }
            }
        }
    }
}
