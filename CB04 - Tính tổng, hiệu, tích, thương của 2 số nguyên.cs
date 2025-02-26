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
            Console.WriteLine(a + b);
            Console.WriteLine(a-b);
            Console.WriteLine(a*b);
            if (b == 0) Console.WriteLine("ERROR");
            else Console.WriteLine("{0:0.00}", (float)a / b);
        }
    }
}
