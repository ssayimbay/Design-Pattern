using Credential.AbstractFactory.Models;

namespace Credential.AbstractFactory.Factories;

public class AUnivercityFactory : IAUnivercityFactory
{
    public Course CreateCourse(string name)
    {
        return new Course(name);
    }

    public Professor CreateProfessor(string name)
    {
        return new Professor(name);
    }

}
