using System;
using System.Collections.Generic;
using System.Linq;

namespace marks
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> studentMarks = new List<int> { 75, 85, 90, 80, 95 };
            var highScorersCount = studentMarks.Count(mark => mark > 80);
            Console.WriteLine( $"The number of students getting marks higher than 80 are {highScorersCount}");
        }
    }
}
