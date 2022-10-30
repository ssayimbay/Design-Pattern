using Credential.AbstractFactory.Models;

namespace Credential.AbstractFactory.Factories;

public interface IAUnivercityFactory
{
    public Course CreateCourse(string name);
    public Professor CreateProfessor(string name);
}
