using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący promień podstawy (r) i wysokość (h) stożka i wypisujący na ekranie objętość i pole całkowite tego stożka
            double r, h, PC, V,l;
            Console.WriteLine("podaj r");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("podaj h");
            h = Convert.ToDouble(Console.ReadLine());
            l =Math.Sqrt(r*r +h*h);
            Console.WriteLine("objętość jest rowna {0}", 1.0 / 3 * r * r * Math.PI);
            Console.WriteLine("pole całkowite jes t rowne {0}", Math.PI * r * l);
            Console.ReadKey(true);

        }
    }
}
