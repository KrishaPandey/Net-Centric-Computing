using System;


namespace qn1
{

    delegate int AddDelegate(int a, int b);

    class Program
    {
        static void Main()
        {
            AddDelegate addDelegate = AddTwoNumbers;

            int num1 = 5;
            int num2 = 7;

            int result = addDelegate(num1, num2);

            Console.WriteLine($"Sum of {num1} and {num2} is: {result}");

            Console.ReadKey();
        }

        static int AddTwoNumbers(int a, int b)
        {
            return a + b;
        }
    }

}
