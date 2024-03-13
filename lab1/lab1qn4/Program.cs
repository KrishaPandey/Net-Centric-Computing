using System;


namespace lab1qn4 { 
class StudentDatabase
{
    private string[] studentNames = new string[5];


    public string this[int index]
    {
        get
        {
            return (index >= 0 && index < studentNames.Length) ? studentNames[index] : "Invalid Index";
        }
        set
        {
            if (index >= 0 && index < studentNames.Length)
            {
                studentNames[index] = value;
            }
            else
            {
                Console.WriteLine("Invalid Index");
            }
        }
    }
}

class Program
{
    static void Main()
    {

        StudentDatabase studentDb = new StudentDatabase();


        studentDb[0] = "Ram";
        studentDb[1] = "Shyam";
        studentDb[2] = "Hari";
        studentDb[3] = "Gita";
        studentDb[4] = "Sita";


        Console.WriteLine("Student Names:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Student {i + 1}: {studentDb[i]}");
        }


        Console.ReadKey();
    }
}
}