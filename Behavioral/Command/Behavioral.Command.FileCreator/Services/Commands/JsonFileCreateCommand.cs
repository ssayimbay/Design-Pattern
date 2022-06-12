using Behavioral.Command.FileCreator.Models;
using Behavioral.Command.FileCreator.Services.Receivers;

namespace Behavioral.Command.FileCreator.Services.Commands;

public class JsonFileCreateCommand : IFileActionCommand
{
    private readonly JsonFileCreator _jsonFileCreator;

    public JsonFileCreateCommand(FileModel fileModel)
    {
        var jsonFile = fileModel;
        jsonFile.Type = "JSON";
        _jsonFileCreator = new JsonFileCreator(jsonFile);
    }

    public async Task Execute()
    {
        var result = await _jsonFileCreator.CreateFile();
        Console.WriteLine(result);
    }
}
