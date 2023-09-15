using System;
using System.Diagnostics.Metrics;

namespace övning2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad heter din favoritbok?");
            string favobok = Console.ReadLine();
            Console.WriteLine("Du älskar " + favobok);
            Console.ReadKey();
        }
    }
}