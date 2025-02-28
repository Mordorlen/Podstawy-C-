using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4_warunki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Napisać program wczytujący pięć liczb i wypisujący na ekranie wartość najmniejszej
            // największej z tych liczb.
            double a, b, c, d, e, min, max;

            Console.WriteLine("a ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("b ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("c ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("d ");
            d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("e ");
            e = Convert.ToDouble(Console.ReadLine());

            min = a;
            if  (b < min) min = b;
            if (c < min) min = c;
            if (d < min) min = d;
            if (e < min) min = e;
            Console.WriteLine("Liczba {0} jest najmniejsza", min);

            max = a;
            
             if (b > max) max = b;
            if (c > max) max = c;
            if (d > max) max = d;
            if (e > max) max = e;
            Console.WriteLine("Liczba {0} jest najiwksza",max);
            Console.ReadKey();


        }
    }
}
