using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2_warunki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Napisać program wczytujący liczbę całkowitą i wypisujący informację, czy wczytana liczba jest
            // dodatnia, ujemna, czy też równa zero

            int a;
            Console.WriteLine("Podaj liczbe");
            a = Convert.ToInt32(Console.ReadLine());
            if (a == 0)
            Console.WriteLine("Liczba jest zerem", a);
            else if (a >0) 
            Console.WriteLine("Liczba jest dodatnia", a);
            else if(a < 0) 
            Console.WriteLine("Liczba jest ujemna", a);
            Console.ReadLine();










        }
    }
}
