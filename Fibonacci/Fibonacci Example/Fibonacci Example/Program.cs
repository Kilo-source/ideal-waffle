using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3, duzina;
            Console.WriteLine("Koliko brojeva ispisujemo?");
            duzina = int.Parse(Console.ReadLine());

            Console.Write(n1 + " " + n2 + " "); //Ispisivanje prva 2

            for (int i = 2; i < duzina; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");//ispisivanje broja sabratog od prethodna 2
                n1 = n2;//pomeranje broja za jedan u napred
                n2 = n3;
            }
        }
    }
}
