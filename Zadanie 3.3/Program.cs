using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Napisać program wczytujący liczbę całkowitą n (n>2) i wypisujący na ekranie wartość sumy
            // 1 + 2 +…+n.Do obliczenia wartości sumy użyj pętli for.

            Console.WriteLine("Podaj liczbę całkowitą n: ");
            int n = int.Parse(Console.ReadLine());
            int result = 0;
            for (int i = 1; i <= n; i++)
            {
                result += i;
            }
            Console.WriteLine($"Suma 1+2+...+{n} = {result}");
            Console.WriteLine(
                "Naciśnij dowolny klawisz, aby zakończyć działanie programu...");
            Console.ReadKey();
        }
    }
}
