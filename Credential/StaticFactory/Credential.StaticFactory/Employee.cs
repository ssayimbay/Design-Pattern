using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credential.StaticFactory
{
    public class Employee
    {
        public string? Name { get; set; }
        public string? Deperment { get; set; }
        public double Salary { get; set; }
        public int Year { get; set; }

        private Employee(string? name, string? deperment, double salary, int year)
        {
            Name = name;
            Deperment = deperment;
            Salary = salary;
            Year = year;
        }

        public static Employee CreateNewEmployee(string name,string deperment, double salary, int year)
        {
           return new Employee(name, deperment, salary, year);
        }

        public static Employee CreateNewTemporaryEmployee(string deperment)
        {
            return new Employee("temp", deperment, 0, 0);
        }

        public virtual void Work()
        {
            Console.WriteLine($"{Name} is working");
        }
    }
}
