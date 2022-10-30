namespace Structural.Composite.FileSystem.Abstract;

public interface IStorageContainer
{
    public void AddContainer(IStorage element);

    public void DeleteContainer(IStorage element);

    public void ListContainer();

    public List<IStorage> Elements();
}
