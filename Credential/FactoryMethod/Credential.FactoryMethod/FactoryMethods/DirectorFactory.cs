using Credential.FactoryMethod.Models;

namespace Credential.FactoryMethod.FactoryMethods
{
    public class DirectorFactory : IFactory
    {
        public Employee Create(string name)
        {
            return new Director(name, "director-deperment-1", 1000, 1);
        }
    }
}
