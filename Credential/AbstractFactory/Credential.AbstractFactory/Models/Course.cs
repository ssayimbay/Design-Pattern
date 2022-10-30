
namespace Credential.AbstractFactory.Models
{
    public class Course
    {
        public string? Name { get; set; }

        public Course(string? name)
        {
            Name = name;
        }
    }
}
