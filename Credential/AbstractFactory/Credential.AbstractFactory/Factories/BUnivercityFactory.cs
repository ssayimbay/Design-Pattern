using Credential.AbstractFactory.Models;

namespace Credential.AbstractFactory.Factories;

public class BUnivercityFactory : IBUnivercityFactory
{
    public Course CreateCourse(string name)
    {
        return new Course(name);
    }

    public Professor CreateProfessor(string name)
    {
        return new Professor(name);
    }

    public VirtualClassroom CreateVirtualClassroom(string name)
    {
        return new VirtualClassroom(name);
    }
}
