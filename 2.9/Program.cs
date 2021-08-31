using System;

namespace _2._9
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hur långt hoppade Elin? (i cm)");
            double längd1 = double.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Hur långt hoppade Alma? (i cm)");
            double längd2 = double.Parse(Console.ReadLine());
            Console.Clear();

            double längdLängre = längd1 - längd2;

            Console.WriteLine("Elin hoppade " + längdLängre + " cm längre än Alma");

        }
    }
}
