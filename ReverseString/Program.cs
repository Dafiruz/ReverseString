using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] str;
            string reversedString = "";
            int length, c;

            //ask for the string
            Console.WriteLine("");
            Console.WriteLine("Insert a string, it will be reversed!");
            str = Console.ReadLine().ToArray<char>();

            //length of the string
            length = str.Length - 1;

            //reverse the string
            for (int i = length; i >= 0; i--)
            {
                reversedString += str[i];
            }

            //show the string, reversed
            Console.WriteLine("");
            Console.WriteLine(reversedString);
            Console.WriteLine("");

            //exit
            Console.WriteLine("Press Any Key to Exit!");
            Console.ReadKey();
        }
    }
}
