namespace Credential.FactoryMethod.Models
{
    public class Director : Employee
    {
        public Director(string? name, string? deperment, double salary, int year) : base(name, deperment, salary, year)
        {
        }

        public override void Work()
        {
            Console.WriteLine($"{Name} is working");
        }
    }
}
