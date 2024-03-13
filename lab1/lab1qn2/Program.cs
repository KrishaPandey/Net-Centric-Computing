

using System;
namespace lab1qn2
{
    class Student
    {
        public int ID { get; set; }
        public string NAME { get; set; }

    }
    class Program
    {
        public static void Main(string[] args)
        {
            Student s = new Student();

            s.ID = 1;
            s.NAME = "Jackson Ghimire";

            Console.WriteLine("Student ID:" + s.ID);
            Console.WriteLine("Student Name:" + s.NAME);
            Console.ReadKey();
        }
    }
}
