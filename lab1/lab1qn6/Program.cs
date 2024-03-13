using System;


namespace lab1qn6
{
    interface IArea
    {
        double Length { get; set; }
        double Width { get; set; }

        double CalculateArea();
    }

    
    class Rectangle : IArea
    {
        public double Length { get; set; }
        public double Width { get; set; }

      
        public double CalculateArea()
        {
            return Length * Width;
        }
    }

    class Program
    {
        static void Main()
        {
            
            Rectangle rectangle = new Rectangle();

            
            rectangle.Length = 5.0;
            rectangle.Width = 3.0;

           
            double area = rectangle.CalculateArea();
            Console.WriteLine($"Area of the rectangle: {area}");

            Console.ReadLine();
        }
    }

}
