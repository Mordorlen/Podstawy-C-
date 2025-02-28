using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Napisać program wcztytujący boki prostokąta na ekranie jego pole i obwód.
            double a, b;
                   Console.WriteLine("Podaj długość pierwszego boku: ");
             a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj długość drugiego boku: ");
             b = Convert.ToDouble(Console.ReadLine());
           Console.WriteLine("Pole={0}", a * b);
            Console.WriteLine("Pole={0}", 2*a+2*b);
            Console.ReadKey(true);


        }
    }
}
