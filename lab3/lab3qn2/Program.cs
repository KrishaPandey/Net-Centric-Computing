using System;
using System.Linq;

namespace lab3qn2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "This Is Dotnet Lab 3 Qn 2";
            var uppercaseLetters = inputString.Where(char.IsUpper);
            Console.WriteLine("Uppercase letters in the string:");
            foreach (var letter in uppercaseLetters)
            {
                Console.Write(letter + " ");
            }
        }
    }
}
