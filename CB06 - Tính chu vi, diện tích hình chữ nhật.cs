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
            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

            int a = numbers[0], b = numbers[1];
            int cv = (a + b) * 2, dt = a * b;
            Console.WriteLine($"{cv}\n{dt}");
        }
    }
}
