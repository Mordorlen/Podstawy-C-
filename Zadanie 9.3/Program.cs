using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_9._3
{
    class Program
    {
        //. Napisać program posiadający tablicę nazw owoców. Stwórz menu umożliwiające
        //zrealizowanie operacji na tablicy: dodawanie nowych owoców, usuwanie istniejących
        //owoców, modyfikowanie istniejących owoców, wyświetlanie listy owoców.
        //Oprogramuj odpowiednio pozycje menu i sprawdź, czy program poprawnie działa.

        static void Main(string[] args)
        {
            string[] fruits = new string[0];
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Dodaj owoc");
                Console.WriteLine("2. Usuń owoc");
                Console.WriteLine("3. Modyfikuj owoc");
                Console.WriteLine("4. Wyświetl listę owoców");
                Console.WriteLine("5. Wyjdź");
                Console.Write("Wybierz opcję: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        AddFruit(ref fruits);
                        break;
                    case "2":
                        RemoveFruit(ref fruits);
                        break;
                    case "3":
                        ModifyFruit(ref fruits);
                        break;
                    case "4":
                        DisplayFruits(fruits);
                        break;
                    case "5":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Niepoprawny wybór, spróbuj ponownie.");
                        break;
                }
            }
        }
        static void AddFruit(ref string[] fruits)
        {
            Console.Write("Podaj nazwę owocu do dodania: ");
            string fruit = Console.ReadLine();
            Array.Resize(ref fruits, fruits.Length + 1);
            fruits[fruits.Length - 1] = fruit;
            Console.WriteLine($"Dodano owoc: {fruit}");
        }
        static void RemoveFruit(ref string[] fruits)
        {
            Console.Write("Podaj nazwę owocu do usunięcia: ");
            string fruit = Console.ReadLine();
            int index = Array.IndexOf(fruits, fruit);
            if (index >= 0)
            {
                for (int i = index; i < fruits.Length - 1; i++)
                {
                    fruits[i] = fruits[i + 1];
                }
                Array.Resize(ref fruits, fruits.Length - 1);
                Console.WriteLine($"Usunięto owoc: {fruit}");
            }
            else
            {
                Console.WriteLine($"Owoc {fruit} nie został znaleziony.");
            }
        }
        static void ModifyFruit(ref string[] fruits)
        {
            Console.Write("Podaj nazwę owocu do modyfikacji: ");
            string oldFruit = Console.ReadLine();
            int index = Array.IndexOf(fruits, oldFruit);
            if (index >= 0)
            {
                Console.Write("Podaj nową nazwę owocu: ");
                string newFruit = Console.ReadLine();
                fruits[index] = newFruit;
                Console.WriteLine($"Zmieniono owoc {oldFruit} na {newFruit}");
            }
            else
            {
                Console.WriteLine($"Owoc {oldFruit} nie został znaleziony.");
            }
        }
        static void DisplayFruits(string[] fruits)
        {
            Console.WriteLine("Lista owoców:");
            if (fruits.Length == 0)
            {
                Console.WriteLine("Brak owoców w liście.");
            }
            else
            {
                foreach (string fruit in fruits)
                {
                    Console.WriteLine(fruit);
                }
            }
        }

    }
}
