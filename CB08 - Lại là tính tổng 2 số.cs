using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Duong
{
    class Program
    {
        public static void solve()
        {
            string input = Console.ReadLine();
            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

            int a =numbers[0], b =numbers[1];
            Console.WriteLine($"{a} + {b} = {a+b}");
        }
        static void Main(string[] args)
        {
           solve();
        }
    }
}
