using System;
using System.Collections.Generic;
using System.Linq;
namespace lab3qn6
{

    class Program
    {
        static void Main(string[] args)
        {
            // Define two lists of objects with a common property
            List<Employee> employees = new List<Employee>()
        {
            new Employee { Id = 1, Name = "Ram", DepartmentId = 101 },
            new Employee { Id = 2, Name = "Shyam", DepartmentId = 102 },
            new Employee { Id = 3, Name = "Hari", DepartmentId = 101 }
        };

            List<Department> departments = new List<Department>()
        {
            new Department { Id = 101, Name = "Engineering" },
            new Department { Id = 102, Name = "Marketing" }
        };

            // Perform inner join on the lists based on the DepartmentId property
            var query = from emp in employees
                        join dept in departments on emp.DepartmentId equals dept.Id
                        select new { emp.Name, DepartmentName = dept.Name };

            // Print the joined data
            Console.WriteLine("Employee\tDepartment");
            foreach (var item in query)
            {
                Console.WriteLine($"{item.Name}\t{item.DepartmentName}");
            }
        }
    }

    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
    }

    class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}