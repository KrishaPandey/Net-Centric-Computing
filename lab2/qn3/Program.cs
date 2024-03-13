using System;


namespace qn3
{

    interface ICalculator
    {
        double Add(double num1, double num2);
        double Subtract(double num1, double num2);
        double Multiply(double num1, double num2);
        double Divide(double num1, double num2);
    }

    class Calculator : ICalculator
    {
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Divide(double num1, double num2)
        {
            if (num2 != 0)
                return num1 / num2;
            else
            {
                Console.WriteLine("Cannot divide by zero.");
                return double.NaN;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            ICalculator calculator = new Calculator();

            double num1 = 100;
            double num2 = 5;

            Console.WriteLine($"Addition: {calculator.Add(num1, num2)}");
            Console.WriteLine($"Subtraction: {calculator.Subtract(num1, num2)}");
            Console.WriteLine($"Multiplication: {calculator.Multiply(num1, num2)}");
            Console.WriteLine($"Division: {calculator.Divide(num1, num2)}");

            Console.ReadKey();
        }
    }

}
