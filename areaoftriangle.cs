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
            int width;
            int height;
            width = Convert.ToInt32(Console.ReadLine());
            height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Area(width,height));

        }
        static int Area(int width, int height)
        {
            return (width*height)/2;
        }
    }
}
