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
            string s = Console.ReadLine();
            int cnt = 0;
            bool inNumber = false;

            foreach (char i in s)
            {
                if (char.IsDigit(i))
                {
                    if (!inNumber)
                    {
                        cnt++;
                        inNumber = true;
                    }
                }
                else
                {
                    inNumber = false;
                }
            }

            Console.WriteLine(cnt);
  
        }
        public static void Main(string[] args)
        {
            solve();
        }
    }
}
