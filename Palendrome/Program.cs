using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palendrome
{
    class Program
    {
        static bool Running;

        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("Welcome to the Paledrome Test!");

            Running = true;
            while (Running)
            {
                Console.WriteLine("");
                Console.Write("Input a word to determine if it is a Palendrome: > ");
                if ((Console.ReadLine()).IsPalendrome())
                {
                    Console.WriteLine("");
                    Console.WriteLine("Congrats! - You found a Palendrome!");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Sorry, not a Palendrome.");
                }
                Console.WriteLine("");
                Console.WriteLine("Reference: A 'Palendrome' is a word that is spelled the same when all characters are reversed.");
                Console.Write("Would you like to play again? (Y/N): > ");
                if (Console.ReadLine().ToUpper() == "Y")
                {
                    Running = true;
                }
                else
                {
                    Running = false;
                }
            }
        }
    }

    public static class StringExtension
    {
        public static bool IsPalendrome(this string input)
        {
            string strOriginal = input.ToUpper();
            string str = input;
            string output = "";
            char[] charOriginal = str.ToCharArray();
            Array.Reverse(charOriginal);
            output = new string(charOriginal).ToUpper();

            if (output == strOriginal)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
