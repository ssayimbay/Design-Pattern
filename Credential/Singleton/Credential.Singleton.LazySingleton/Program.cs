
using Credential.Singleton.LazySingleton;

for (int i = 0; i < 100; i++)
{
    var lazySingleton = LazySingleton.Instance;
    Console.WriteLine(lazySingleton);
}