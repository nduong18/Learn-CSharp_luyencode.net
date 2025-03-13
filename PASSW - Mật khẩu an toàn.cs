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
            string[] str = new string[n];
            List<int> list = new List<int>();
                
            for (int i = 0; i < n; i++)
            {
                str[i] = Console.ReadLine();

                int value = Math.Min(5, Math.Max(str[i].Length - 5, 0));

                bool hasUpper = false, hasLower = false, hasDigit = false;

                foreach (char c in str[i])
                {
                    if (char.IsDigit(c)) hasDigit = true;
                    else if (char.IsLower(c)) hasLower = true;
                    else if (char.IsUpper(c)) hasUpper = true;

                    if (hasUpper && hasLower && hasDigit)
                    {
                        break;
                    }
                }

                if (hasUpper && hasLower && hasDigit) value += 5;
                else if ((hasUpper || hasLower) && (hasUpper || hasDigit) && (hasLower || hasDigit)) value += 2;
                else if (hasUpper || hasLower || hasDigit) value += 1;

                list.Add(value);

            }

            foreach (int i in list) Console.Write(i + " ");
        }
        public static void Main(string[] args)
        {
            solve();
        }
    }
}
