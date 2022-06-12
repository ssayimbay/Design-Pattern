using Behavioral.Command.FileCreator.Models;

namespace Behavioral.Command.FileCreator.Services.Receivers;

public class PdfFileCreator
{
    private readonly FileModel _fileModel;
    public PdfFileCreator(FileModel fileModel)
    {
        _fileModel = fileModel;
    }

    public Task<string> CreateFile()
    {
        return Task.FromResult($"Content : {_fileModel.Content} \n Type : {_fileModel.Type}.\n");
    }
}
