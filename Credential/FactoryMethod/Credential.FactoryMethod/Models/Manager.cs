namespace Credential.FactoryMethod.Models;

internal class Manager : Employee
{
    public Manager(string? name, string? deperment, double salary, int year) : base(name, deperment, salary, year)
    {
    }

    public override void Work()
    {
        Console.WriteLine($"{Name} is working");
    }
}
