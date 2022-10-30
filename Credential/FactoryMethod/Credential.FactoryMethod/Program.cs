

using Credential.FactoryMethod.FactoryMethods;
using Credential.FactoryMethod.Models;

IFactory directorFactory = new DirectorFactory();
IFactory managerFactory = new ManagerFactory();

List<Employee> employees = new List<Employee>();

employees.Add(directorFactory.Create("director-name-1"));
employees.Add(directorFactory.Create("director-name-2"));
employees.Add(directorFactory.Create("director-name-3"));
employees.Add(directorFactory.Create("director-name-4"));

employees.Add(managerFactory.Create("manager-name-1"));
employees.Add(managerFactory.Create("manager-name-2"));
employees.Add(managerFactory.Create("manager-name-3"));
employees.Add(managerFactory.Create("manager-name-4"));

foreach (var employee in employees)
{
    employee.Work();
}

Console.ReadLine();