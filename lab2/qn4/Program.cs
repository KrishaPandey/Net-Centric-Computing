using System;
using System.Collections.Generic;
namespace qn4
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.ReadKey();
        }
    }
}
