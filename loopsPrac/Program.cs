using System.Collections.Generic;
using System;
using System.Linq;

namespace linQConcept
{
    internal class Program
    {
        static void Main()
        {
            List<person> employee = new List<person>
            {
                new person { id = 001, name = "Ali", salary = 45000, DepartmentId = 1 },
                new person { id = 002, name = "Jaffar", salary = 98000, DepartmentId = 2 },
                new person { id = 003, name = "Kashaf", salary = 89000, DepartmentId = 1 }
            };

            List<department> departments = new List<department>
            {
                new department { DepartmentId = 1, DepartmentName = "IT" },
                new department { DepartmentId = 2, DepartmentName = "HR" }
            };

            var employeeWithDepartment = employee.Join(
                departments,
                emp => emp.DepartmentId,    
                dept => dept.DepartmentId,  
                (emp, dept) => new          
                {
                    emp.id,
                    emp.name,
                    emp.salary,
                    dept.DepartmentName
                });

            //foreach (var emp in employeeWithDepartment)
            //{
            //    Console.WriteLine($"Id: {emp.id}, Name: {emp.name}, Salary: {emp.salary}, Department: {emp.DepartmentName}");
            //}
            employeeWithDepartment.ToList().ForEach(emp => Console.WriteLine($"Id: {emp.id}, Name: {emp.name}, Salary: {emp.salary},  Department: {emp.DepartmentName}"));
        }
    }

    class person
    {
        public int id { get; set; }
        public string name { get; set; }
        public int salary { get; set; }
        public int DepartmentId { get; set; } 
    }

    class department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
    }
}
