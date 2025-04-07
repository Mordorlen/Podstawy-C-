using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6._1
{
    class Program
    {
        static int Suma(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {

            //Napisz funkcję o nazwie suma wyznaczającą sumę jej dwóch argumentów będących liczbami
            //całkowitymi.Napisz program wykorzystujący funkcję suma

            Console.WriteLine("2+3={0}", Suma(2, 3));
            Console.ReadKey();




        }
    }
}
