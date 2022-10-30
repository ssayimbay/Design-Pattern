namespace Credential.FactoryMethod.Models;

public class Employee
{
    public string? Name { get; set; }
    public string? Deperment { get; set; }
    public double Salary { get; set; }
    public int Year { get; set; }

    public Employee(string? name, string? deperment, double salary, int year)
    {
        Name = name;
        Deperment = deperment;
        Salary = salary;
        Year = year;
    }

    public virtual void Work()
    {
        Console.WriteLine($"{Name} is working");
    }
}
