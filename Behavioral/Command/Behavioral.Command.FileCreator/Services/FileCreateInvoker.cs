using Behavioral.Command.FileCreator.Services.Commands;

namespace Behavioral.Command.FileCreator.Services;

public class FileCreateInvoker
{
    private IFileActionCommand? _fileActionCommand;
    private List<IFileActionCommand>? _fileActionCommands;

    public FileCreateInvoker()
    {
        _fileActionCommands = new List<IFileActionCommand>();
    }

    public void SetCommand(IFileActionCommand fileActionCommand)
    {
        _fileActionCommand = fileActionCommand;
    }

    public void AddCommand(IFileActionCommand fileActionCommand)
    {
        _fileActionCommands?.Add(fileActionCommand);
    }

    public void Create()
    {
        _fileActionCommand?.Execute();
    }

    public void Creates()
    {
        _fileActionCommands?.ForEach(command => command.Execute());
    }
}
