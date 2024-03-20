using System;
using System.Linq;
namespace lab3qn3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            var squares = numbers.Select(n => new { Number = n, Square = n * n });

            Console.WriteLine("Number\tSquare");
            foreach (var pair in squares)
            {
                Console.WriteLine(pair.Number + "\t" + pair.Square);
            }
        }
    }
}
