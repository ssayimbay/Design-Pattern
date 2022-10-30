
using Credential.FactoryMethod.Models;

namespace Credential.FactoryMethod.FactoryMethods;

internal class ManagerFactory : IFactory
{
    public Employee Create(string name)
    {
        return new Manager(name, "manager deperment-1", 1500, 2);
    }
}
