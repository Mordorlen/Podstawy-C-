using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3_warunki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Napisać program wczytujący trzy liczby i wypisujący na ekranie wartość najmniejszej i
            // największej z tych liczb
            
            double a, b, c;
            Console.WriteLine("Podaj liczbe pierwsza");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj liczbe druga");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj liczbe trzecia");
            c = Convert.ToDouble(Console.ReadLine());
            if
               ( (a <= b) && (b <= c) )
                    Console.WriteLine("Liczba {0} jest najmniejsza", a);
            else if    
               ( (b <= c) && (b <= a) )
                Console.WriteLine("Liczba {0} jest najmniejsza", b);
            else 
                Console.WriteLine("Liczba {0} jest najmniejsza", c);

             
            if
              ((a >= b) && (b >= c))
                Console.WriteLine("Liczba {0} jest największa", a);
            else if
               ((b >= c) && (b >= a))
                Console.WriteLine("Liczba {0} jest największa", b);
            else
                Console.WriteLine("Liczba {0} jest największa", c);
            Console.ReadKey();








        }
    }
}
