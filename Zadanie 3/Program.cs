using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3
{

    class Program

    {
        static double Pole_kola(double r)
        {
            return Math.PI * r * r;
        }

    
        static void Main(string[] args)
        {
            //Napisz funkcję o nazwie pole_kola, która posiada jeden parametr r-promień koła i zwraca obliczoną wartość pola koła. Napisz program wykorzystujący funkcję pole_kola.

            Console.WriteLine("Pole koła o promieniu 2 wynosi: {0}", Pole_kola(2));
           




        }
    }
}
