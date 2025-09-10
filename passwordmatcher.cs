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
            string pass = Console.ReadLine();
            string pass2 = Console.ReadLine();
            if (pass == "" || pass2 == "")
            {
                Console.WriteLine("One or more fields are empty!");
            }
            else
            {
                if (pass == pass2)
                {
                    Console.WriteLine("Passwords match!");
                }
                else
                {
                    Console.WriteLine("Not matched!");
                }
            }
        }
    } 
}
