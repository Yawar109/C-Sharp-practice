using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linQConcept
{
    internal class Program
    {
        static void Main()
        {
            List<person> employee = new List<person>
            {
            new person { id = 001, name = "Ali", salary = 45000 },
            new person { id = 002, name = "jaffar", salary = 98000 },
            new person { id = 003, name = "kashaf", salary = 89000 }
            };
            var salary = employee.Where(i => i.salary > 80000).ToList();    


            salary.ForEach(emp => Console.WriteLine($"Id: {emp.id}, Name: {emp.name}, Salary: {emp.salary}"));
        }

    }
    class person
    {
        public int id { get; set; }
        public string name { get; set; }
        public int salary { get; set; }
              
    }

}
