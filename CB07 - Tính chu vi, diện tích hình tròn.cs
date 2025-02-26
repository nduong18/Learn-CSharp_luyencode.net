using System;
using System.Numerics;
using System.Linq;

namespace C2501_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double cv = 3.14 * x * 2, dt = 3.14 * x * x;
            Console.WriteLine($"{cv:0.000} {dt:0.000}");
        }
    }
}
