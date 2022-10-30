namespace Credential.AbstractFactory.Models;

public class Professor
{
    public string? Name { get; set; }

    public Professor(string? name)
    {
        Name = name;
    }
}
