using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dany jest wzór ciągu a(n)=2n-1. Napisz program wczytujący liczbę całkowitą dodatnią n i
            // wypisujący na ekranie kolejne wyrazy ciągu: a(1), a(2), …, a(n).Użyj pętli while.

            Console.WriteLine("Podaj liczbę całkowitą dodatnią n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(
                "Wyrazy ciągu a(n)=2n-1 dla n = " + n + " to: ");
            int i = 1;
            while (i <= n)
            {
                Console.Write((2 * i - 1) + " ");
                i++;
            }
        }
    }
}
