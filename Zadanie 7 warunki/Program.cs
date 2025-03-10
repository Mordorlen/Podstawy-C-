using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_7_warunki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący liczbę arabską od 1 do 3999 i wypisujący na ekranie jej
            //odpowiednik rzymski.
            Console.WriteLine("Podaj liczbę arabską od 1 do 3999: ");
            int liczba = int.Parse(Console.ReadLine());
            if (liczba < 1 || liczba > 3999)
            {
                Console.WriteLine("Liczba spoza zakresu");
            }
            else
            {
                string wynik = "";
                while (liczba >= 1000)
                {
                    wynik += "M";
                    liczba -= 1000;
                }
                if (liczba >= 900)
                {
                    wynik += "CM";
                    liczba -= 900;
                }
                if (liczba >= 500)
                {
                    wynik += "D";
                    liczba -= 500;
                }
                if (liczba >= 400)
                {
                    wynik += "CD";
                    liczba -= 400;
                }
                while (liczba >= 100)
                {
                    wynik += "C";
                    liczba -= 100;
                }
                if (liczba >= 90)
                {
                    wynik += "XC";
                    liczba -= 90;
                }
                if (liczba >= 50)
                {
                    wynik += "L";
                    liczba -= 50;
                }
                if (liczba >= 40)
                {
                    wynik += "XL";
                    liczba -= 40;
                }
                while (liczba >= 10)
                {
                    wynik += "X";
                    liczba -= 10;
                }
                if (liczba >= 9)
                {
                    wynik += "IX";
                    liczba -= 9;
                }
                if (liczba >= 5)
                {
                    wynik += "V";
                    liczba -= 5;
                }
                if (liczba >= 4)
                {
                    wynik += "IV";
                    liczba -= 4;
                }
                while (liczba >= 1)
                {
                    wynik += "I";
                    liczba -= 1;
                }
                Console.WriteLine(wynik);
            }
            Console.ReadLine();
        }
    }
}
