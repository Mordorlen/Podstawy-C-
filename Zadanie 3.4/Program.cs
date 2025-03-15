using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Wczytaj dwie liczby naturalne dodatnie n i k. Narysuj z gwiazdek na ekranie prostokąt
            // posiadający n wierszy i k kolumn. Użyj pętli for.

            Console.WriteLine(
                "Podaj dwie liczby naturalne dodatnie n i k, oddzielone spacją: ");
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
        }
    }
}
