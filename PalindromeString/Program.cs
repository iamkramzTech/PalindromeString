using static System.Console;
using System;

namespace PalindromeString
{
    class Program
    {
        static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Green;
            Write("Enter a String to Check if it is a Palindrome: ");
            string text = ReadLine();
            char[] strChar = text.ToCharArray();

            //using Array.Reverse Method to reverse array of characters
            Array.Reverse(strChar);

            //Create a sting from strChar array
            string reverse = new string(strChar);
            WriteLine();
            if(text.Equals(reverse,StringComparison.OrdinalIgnoreCase))
            {
                WriteLine($"{reverse} is a Palindrome");
            }
            else
            {
                WriteLine($"{reverse} is not a Palindrome");
            }
            ReadKey();
        }
    }
}
