using Structural.Composite.FileSystem.Abstract;

namespace Structural.Composite.FileSystem.Models;

public class MyDirectory : CompositeStorageElement, IStorageContainer
{
    private readonly List<IStorage> elements = new List<IStorage>();

    public MyDirectory(string name) : base(name)
    {
        IsDirectory = true;
    }

    public MyDirectory(string name, IStorage parent) : base(name, parent)
    {
        IsDirectory = true;
    }

    public void AddContainer(IStorage element) => elements.Add(element);
    public void DeleteContainer(IStorage element) => elements.Remove(element);
    public List<IStorage> Elements() => elements;

    public void ListContainer()
    {
        foreach (var element in elements)
        {
            var compositeStorageElement = (CompositeStorageElement)element;

            if (compositeStorageElement.IsDirectory)
            {
                Console.WriteLine($"\nPATH          : {compositeStorageElement.Path}\nDIRECTORY     : {compositeStorageElement.Name}");
                ListSubDirectory(compositeStorageElement);
            }

            else
            {
                Console.WriteLine($"FILE          : {compositeStorageElement.Name}");
            }
        }
        Console.WriteLine();
    }

   private void ListSubDirectory(CompositeStorageElement compositeStorageElement)
    {
        var directory = (MyDirectory)compositeStorageElement;
        directory.elements.ForEach(x =>
        {
            var element = ((CompositeStorageElement)x);
            if(element.IsDirectory)
            {
                Console.WriteLine($"SUB DIRECTORY : {element.Name}");
            }
            else
            {
                Console.WriteLine($"FILE          : {element.Name}");
            }
            
        });
    }
}
