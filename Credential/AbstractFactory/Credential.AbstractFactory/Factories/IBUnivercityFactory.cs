using Credential.AbstractFactory.Models;

namespace Credential.AbstractFactory.Factories;

public interface IBUnivercityFactory
{
    public Course CreateCourse(string name);
    public Professor CreateProfessor(string name);
    public VirtualClassroom CreateVirtualClassroom(string name);
}
