using Behavioral.Command.FileCreator.Services.Commands;

namespace Behavioral.Command.FileCreator.Services;

public class FileCreateInvoker
{
    private List<IFileActionCommand>? _fileActionCommands;

    public FileCreateInvoker()
    {
        _fileActionCommands = new List<IFileActionCommand>();
    }

    public FileCreateInvoker AddCommand(IFileActionCommand fileActionCommand)
    {
        _fileActionCommands?.Add(fileActionCommand);
        return this;
    }

    public FileCreateInvoker RemoveCommand(IFileActionCommand fileActionCommand)
    {
        _fileActionCommands?.Remove(fileActionCommand);
        return this;
    }

    public void Create()
    {
        _fileActionCommands?.ForEach(command => command.Execute());
        _fileActionCommands?.Clear();
    }
}
