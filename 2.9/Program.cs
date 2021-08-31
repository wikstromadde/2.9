using System;

namespace _2._9
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hur långt hoppade Elin?");
            double längd1 = double.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Hur långt hoppade Alma?");
            double längd2 = double.Parse(Console.ReadLine());
            Console.Clear();

            double längdLängre = längd1 - längd2;

            Console.WriteLine("Elin hoppade " + längdLängre + " cm än Alma");

        }
    }
}
