using System;
using System.Numerics;
using System.Linq;

namespace C2501_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sum = input.Split(' ').Select(int.Parse).Sum();
            Console.WriteLine(sum);
        }
    }
}
