using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6._5
{
    class Program
    {
        static void Main(string[] args)
        {
            //. Wczytaj liczbę naturalną n i wypisz na ekranie tą liczbę w systemie dwójkowym
            int n;
            Console.WriteLine("Podaj liczbę: ");

            n = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(n, 2);
            Console.WriteLine("Liczba " + n + " w systemie dwójkowym to: " + binary);
            Console.ReadKey();

        }
    }
}
