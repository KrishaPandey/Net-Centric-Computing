using System;

namespace lab1qn3
{
    class Program
    {
        static void Main(string[]args)
        {
            
            int[] numbers = { 10,20,30,40,50,60 };

            
            Console.WriteLine("Original Array:");
            DisplayArray(numbers);

            
            Array.Reverse(numbers);

            Console.WriteLine("\nReversed Array:");
            DisplayArray(numbers);

            
            Console.ReadKey();
        }

        static void DisplayArray(int[] numbers)
        {
            foreach (int num in numbers)
            {
                Console.Write(num+ " ");
            }
           
        }
    }
}
