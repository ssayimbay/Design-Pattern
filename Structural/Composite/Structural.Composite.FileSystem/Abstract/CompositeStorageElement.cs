using Structural.Composite.FileSystem.Models;

namespace Structural.Composite.FileSystem.Abstract;

public abstract class CompositeStorageElement : IStorage
{
    public string Name;
    public string Path;
    public IStorage? ParentDirectory;
    public bool IsDirectory;

    protected CompositeStorageElement(string name, IStorage parent)
    {
        var parentDirectory = (MyDirectory)parent;
        Name = name;
        Path = $"{parentDirectory.Path}/{name}";
        ParentDirectory = parent;
        parentDirectory.AddContainer(this);
    }

    protected CompositeStorageElement(string name)
    {
        Path = name;
        Name = name;
    }
    public virtual IStorage Copy() => (IStorage)MemberwiseClone();
    public virtual void Rename(string newName) => Name = newName;

    public virtual void Delete()
    {
        if (ParentDirectory != null)
            ((MyDirectory)ParentDirectory).DeleteContainer(this);
    }

    public virtual void Move(MyDirectory target)
    {
        if(ParentDirectory != null)
        {
                    ((MyDirectory)ParentDirectory).DeleteContainer(this);

        ParentDirectory = target;
        Path = $"{((CompositeStorageElement)ParentDirectory).Path}/{Name}";
        ((MyDirectory)ParentDirectory).AddContainer(this);
    }
        }

}
