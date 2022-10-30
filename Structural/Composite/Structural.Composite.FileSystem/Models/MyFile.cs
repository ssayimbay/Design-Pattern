using Structural.Composite.FileSystem.Abstract;

namespace Structural.Composite.FileSystem.Models;

public class MyFile : CompositeStorageElement
{
    public MyFile(string name, IStorage parent) : base(name, parent)
    {
    }
}
