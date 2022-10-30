using Structural.Composite.FileSystem.Abstract;

namespace Structural.Composite.FileSystem.Models;

public class MyAlias : CompositeStorageElement
{
    public MyAlias(string name, IStorage parent) : base(name, parent)
    {
    }
}
