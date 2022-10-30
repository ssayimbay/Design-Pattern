namespace Structural.Composite.FileSystem.Abstract;

public interface IStorage
{
	public void Rename(string newName);

	public void Delete();

	public IStorage Copy();

	public void Move(Models.MyDirectory target);
}
