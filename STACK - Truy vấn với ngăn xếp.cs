using System;
using System.Collections.Generic;
using System.Linq;

namespace TEMP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            int t = Convert.ToInt32(Console.ReadLine());
            while (t != 0)
            {
                string input = Console.ReadLine();
                int[] a = input.Split(' ').Select(int.Parse).ToArray();
                int x = a[0];

                if (x == 1)
                {
                    int y = a[1];
                    stack.Push(y);
                }
                else if (x == 2)
                {
                    if (stack.Count != 0) stack.Pop();
                }
                else
                {
                    if (stack.Count != 0) Console.WriteLine(stack.Peek());
                    else Console.WriteLine("Empty!");
                }
                t--;
            }
        }
    }
}
