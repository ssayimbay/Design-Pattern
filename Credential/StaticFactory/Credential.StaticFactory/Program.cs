
using Credential.StaticFactory;

var employee1 = Employee.CreateNewTemporaryEmployee("temp deperment");
var employee2 = Employee.CreateNewEmployee("test-name", "test deperment", 1000, 1);

employee1.Work();
employee2.Work();

Console.ReadLine();