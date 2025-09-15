using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Length of your array: ");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[len];

            int k = 0;
            while (k != len)
            {
                Console.Write($"Enter value for array index {k}: ");
                numbers[k]=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                k++;
            }
            Console.Write("Sum total of the array: ");
            Console.WriteLine(Total(numbers));
        }
        static int Total(int[] numbers)
        {
            int total = 0;
            foreach (int i in numbers)
            {
                total += i;
            }
            return total;
        }
    }
}
