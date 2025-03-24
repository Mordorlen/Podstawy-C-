using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program, który będzie umożliwiał użytkownikowi obliczenia pól figur płaskich.
            //Jeżeli użytkownik wybierze 1, to powinien mieć możliwość obliczenia pola prostokąta,
            //dla 2 – pola kwadratu, a dla 3 – pola trójkąta. Program powinien pytać użytkownika, które
            //pole chce obliczyć aż do momentu, kiedy użytkownik wpisze 0(zero)

            Console.WriteLine("Wybierz figurę, dla której chcesz obliczyć pole: ");
            Console.WriteLine("1 - prostokąt");
            Console.WriteLine("2 - kwadrat");
            Console.WriteLine(
                "3 - trójkąt");
            Console.WriteLine("0 - zakończ program");
            int wybor = int.Parse(Console.ReadLine());
            Console.WriteLine(
                "Wybrano: " + wybor);
            while (wybor != 0) ;
            Console.WriteLine(
                "Podaj wymiary figury: ");
            switch (wybor)

            {
                case 1:
                    Console.WriteLine(
                        "Podaj długość boku a: ");
                    double a = double.Parse(Console.ReadLine());
                    Console.WriteLine(
                        "Podaj długość boku b: ");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine(
                        "Pole prostokąta o bokach a = " + a + " i b = " + b + " wynosi: " + a * b);
                    break;
                case 2:
                    Console.WriteLine(
                        "Podaj długość boku a: ");
                    double a1 = double.Parse(Console.ReadLine());
                    Console.WriteLine(
                        "Pole kwadratu o boku a = " + a1 + " wynosi: " + a1 * a1);
                    break;
                case 3:
                    Console.WriteLine(
                        "Podaj długość podstawy trójkąta: ");
                    double podstawa = double.Parse(Console.ReadLine());
                    Console.WriteLine(
                        "Podaj wysokość trójkąta: ");
                    double wysokosc = double.Parse(Console.ReadLine());
                    Console.WriteLine(
                        "Pole trójkąta o podstawie = " + podstawa + " i wysokości = " + wysokosc + " wynosi: " + 0.5 * podstawa * wysokosc);
                    break;
                default:
                    Console.WriteLine(
                        "Nie ma takiej opcji.");
                    break;


            }
    }
}
