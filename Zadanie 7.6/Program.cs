using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_7._6
{
    internal class Program
    {
        //Napisać procedurę (czyli funkcję, która nie zwraca żadnej wartości) posiadającą trzy
        //parametry: a-długość boku kwadratu, znak1-znak będący konturem kwadratu, znak2-znak
        //będący wypełnieniem kwadratu.Procedura ma rysować na ekranie kwadrat o zadanych
        //argumentach. Przetestuj działanie utworzonej procedury.
        static void RysujKwadrat(int a, char znak1, char znak2)
        {
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    if (i == 0 || i == a - 1 || j == 0 || j == a - 1)
                    {
                        Console.Write(znak1);
                    }
                    else
                    {
                        Console.Write(znak2);
                    }
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            // Przykład użycia
            RysujKwadrat(5, '*', ' ');
            Console.WriteLine();
            RysujKwadrat(3, '#', '.');
        }
    }
}
