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
            string word = Console.ReadLine();

            Console.WriteLine("Word length: "+word.Length);

            string newWord="";
            int k;

            int i = 1;
            while (i <= word.Length)
            {
                k = word.Length - i;
                newWord += word[k];
                i++;
            }

            Console.WriteLine("New word: "+newWord);
        }
    }
}
