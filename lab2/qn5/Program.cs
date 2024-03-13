using System;
using System.Collections.Generic;

namespace qn5
{
    class Program
    {
        static void Main()
        {
            Dictionary<int, string> customerDictionary = new Dictionary<int, string>
            {
                { 101, "Ram " },
                { 102, "Shyam" },
                { 103, "Hari" }
            };

            foreach (var customer in customerDictionary)
            {
                Console.WriteLine($"Customer ID: {customer.Key}, Name: {customer.Value}");
            }

            Console.ReadKey();
        }
    }
}

