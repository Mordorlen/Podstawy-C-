using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_7._10
{
    internal class Program
    {
        //Napisać funkcję o nazwie NWD zwracającą wartość największego wspólnego dzielnika dla jej
        //dwóch argumentów będących liczbami naturalnymi.
        //Napisz program testujący utworzoną funkcję.


        static int NWD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        static void Main(string[] args)
        {
            
            int a = 56;
            int b = 98;
            Console.WriteLine("Największy wspólny dzielnik {0} i {1} to: {2}", a, b, NWD(a, b));
            Console.ReadKey();
        }
    }
}
