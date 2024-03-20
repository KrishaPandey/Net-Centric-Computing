using System;
using System.Linq;
namespace lab3qn5
{

    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEWDELHI", "AMSTERDAM", "ABUDHABI", "PARIS" };

            char startChar = 'N';
            char endChar = 'I';

            var result = cities.Where(city => city.StartsWith(startChar) && city.EndsWith(endChar));

            Console.WriteLine($"Cities starting with '{startChar}' and ending with '{endChar}':");
            foreach (var city in result)
            {
                Console.WriteLine(city);
            }
        }
    }
}
