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
            int num;
            int len;
            Console.Write("num: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write("len: ");
            len = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[len];

            int index = 0;

            foreach (int i in array)
            {
                array[index] = num * (index + 1);
                index++;
            }

            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        } 
    } 
}
