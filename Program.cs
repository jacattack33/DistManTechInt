using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "DeED";
            string[] inputArray = new string[] {"cat", "dog", "level", "313", "DeEd"};

            foreach(string val in inputArray)
            {
                Console.WriteLine("Is " + val + " a palindrome? " + IsPalindrome(val));
            }
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
        public static bool IsPalindrome(string input)
        {
            return input.ToLower().SequenceEqual(input.ToLower().Reverse());
        }

  
    }
}
