using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 15; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    if (i % 3 != 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else if (i % 5 != 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
