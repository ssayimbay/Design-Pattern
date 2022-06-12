using Behavioral.Command.FileCreator.Models;

namespace Behavioral.Command.FileCreator.Services.Receivers;

public class JsonFileCreator
{
    private readonly FileModel _fileModel;
    public JsonFileCreator(FileModel fileModel)
    {
        _fileModel = fileModel;
    }

    public Task<string> CreateFile()
    {
        return Task.FromResult($"Content : {_fileModel.Content} \n Type : {_fileModel.Type}.\n");
    }
}
