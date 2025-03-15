using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Wczytaj liczbę naturalną n(n > 1).Narysuj na ekranie z gwiazdek trójkąt równoramienny, który
            //nie jest trójkątem prostokątnym. Użyj pętli for. Przykładowo dla n = 3 narysowany trójkąt
            //powinien wyglądać:
            //  *
            //   ***
            //  *****
            Console.WriteLine("Podaj liczbę naturalną n: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }
    }
}
