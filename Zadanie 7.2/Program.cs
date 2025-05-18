using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_7._2

{
    class Program
    {
        static double Max(double x, double y)
        {

            if (x > y) return x;
            else return y;



        }
        static void Main(string[] args)


        {
            //Napisz funkcję o nazwie max, która wyznacza maksimum z dwóch liczb rzeczywistych
            //zadanych jako argumenty tej funkcji.Napisz program wykorzystujący funkcję max.

            Console.WriteLine("Max(2.5, 3.5)={0}", Max(2.5, 3.5));
            Console.WriteLine("Max(2.5, 3.5)={0}", Max(2.5, 3.5));
            Console.ReadKey();

        }
    } 
}
