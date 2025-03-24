using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4._8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisz program stwierdzający, czy zadana liczba n jest pierwsza. Użyj pętli while.

            Console.WriteLine("Podaj liczbę naturalną n: ");
            Console.WriteLine(
                "Program stwierdzi, czy podana liczba n jest pierwsza.");
            int n = int.Parse(Console.ReadLine());
            int i = 2;
            bool pierwsza = true;
            while (i < n)
            {
                if (n % i == 0)
                {
                    pierwsza = false;
                    break;
                }
                i++;
            }
            if (pierwsza)
            {
                Console.WriteLine("Liczba " + n + " jest pierwsza.");
            }
            else
            {
                Console.WriteLine("Liczba " + n + " nie jest pierwsza.");
            }



        }
    }
}
