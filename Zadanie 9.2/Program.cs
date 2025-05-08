using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_9._2
{
    class Program
    {
        //Zdefiniuj strukturę o nazwie Uczen zawierającą pola: imie, nazwisko i tablice ocen.
        //Pobierz od użytkownika liczbę uczniów i zadeklaruj odpowiednią tablicę struktur
        //umożliwiającą przechowanie informacji o imionach, nazwiskach i ocenach uczniów.
        //Następnie pobierz dane od użytkownika i w sposób czytelny wypisz wszystko na ekranie.
        struct Uczen
        {
            public string imie;
            public string nazwisko;
            public int[] oceny;
            public Uczen(string imie, string nazwisko, int[] oceny)
            {
                this.imie = imie;
                this.nazwisko = nazwisko;
                this.oceny = oceny;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę uczniów:");
            int liczbaUczniow = int.Parse(Console.ReadLine());
            Uczen[] uczniowie = new Uczen[liczbaUczniow];
            for (int i = 0; i < liczbaUczniow; i++)
            {
                Console.WriteLine($"Podaj imię ucznia {i + 1}:");
                string imie = Console.ReadLine();
                Console.WriteLine($"Podaj nazwisko ucznia {i + 1}:");
                string nazwisko = Console.ReadLine();
                Console.WriteLine($"Podaj liczbę ocen ucznia {i + 1}:");
                int liczbaOcen = int.Parse(Console.ReadLine());
                int[] oceny = new int[liczbaOcen];
                for (int j = 0; j < liczbaOcen; j++)
                {
                    Console.WriteLine($"Podaj ocenę {j + 1} ucznia {i + 1}:");
                    oceny[j] = int.Parse(Console.ReadLine());
                }
                uczniowie[i] = new Uczen(imie, nazwisko, oceny);
            }
            Console.WriteLine("\nDane uczniów:");
            foreach (var uczen in uczniowie)
            {
                Console.WriteLine($"Imię: {uczen.imie}, Nazwisko: {uczen.nazwisko}, Oceny: {string.Join(", ", uczen.oceny)}");
            }















        }
}
