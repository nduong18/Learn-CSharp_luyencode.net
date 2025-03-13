using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Collections.Generic;

namespace Duong
{
    class Program
    {
        public static void solve()
        {
            int n = Convert.ToInt32 (Console.ReadLine());
            int value = n * 2;
            Console.WriteLine(value);
        }
        public static void Main(string[] args)
        {
            solve();
        }
    }
}
