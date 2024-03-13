using System;

namespace AddTwoDigitsProgram
{
    class AddTwoDigits
    {

        private int num1;
        private int num2;


        public AddTwoDigits(int first, int second)
        {
            num1 = first;
            num2 = second;
        }


        public void Add()
        {
            int sum = num1+num2;
            Console.WriteLine($"Sum of {num1} and {num2} is: {sum}");
        }
    }

    class Program
    {
        static void Main()
        {

            Console.Write("Enter the first digit: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second digit: ");
            int number2 = Convert.ToInt32(Console.ReadLine());


            AddTwoDigits adder = new AddTwoDigits(number1,number2);


            adder.Add();
            Console.ReadKey();


         
        }
    }
}

   