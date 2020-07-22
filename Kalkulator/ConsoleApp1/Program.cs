using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //Deklarisanje promenjivih
                int a, b;
                string M_operacija = string.Empty;

                //Od korisnika se trazi da unese 2 broja
                Console.WriteLine("Unesite 2 broja");
                int.TryParse(Console.ReadLine(), out a); //Smesta se u promenjivu a
                int.TryParse(Console.ReadLine(), out b); //Smesta se u promenjivu b


                //Proveravanje, da li je uneto slovo umesto broja
                if (a == 0 || b == 0)
                {
                    Console.WriteLine("Uneti su pogresni podatci!");
                }
                //Biranje operacije
                Console.WriteLine("Izaberite matematicku operaciju");
                Console.WriteLine("Za sabiranje +, za oduzimanje -, za mnozenje *, za deljenje /");
                M_operacija = Console.ReadLine();
                //Procesuiranje odabrane operacije
                switch (M_operacija)
                {
                    case "/":
                        Console.WriteLine($"Rezultat Deljenja je: {a / b}");
                        break;
                    case "+":
                        Console.WriteLine($"Rezultat Sabiranja je: {a + b}");
                        break;
                    case "-":
                        Console.WriteLine($"Rezultat Oduzimanja je: {a - b}");
                        break;
                    case "*":
                        Console.WriteLine($"Rezultat Mnozenja je: {a * b}");
                        break;


                    default:
                        Console.WriteLine("Nije Unesena dobra vrednost");
                        break;
                }
                Console.WriteLine("Nastaviti sa racunanjem (D/N)");
                if (Console.ReadLine().ToLower() != "d")
                {
                    break;
                }
            }
        }
    }
}
