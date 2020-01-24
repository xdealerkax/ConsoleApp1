using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("wpisz swoje imię");
            string name = Console.ReadLine().ToString();
            Console.Clear();
            Console.WriteLine("Witaj "+name);

            Console.Read();

        }
    }
}
