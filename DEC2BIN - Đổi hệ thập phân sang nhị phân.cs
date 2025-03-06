using System;
using System.Collections.Generic;

namespace TEMP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            while (t != 0)
            {
                long n = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine(Convert.ToString(n,2));
                t--;
            }
        }
    }
}
