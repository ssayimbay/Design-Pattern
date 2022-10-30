using Credential.FactoryMethod.Models;

namespace Credential.FactoryMethod.FactoryMethods;

public interface IFactory
{
    Employee Create(string name);
}
