using Behavioral.Command.FileCreator.Models;
using Behavioral.Command.FileCreator.Services.Receivers;

namespace Behavioral.Command.FileCreator.Services.Commands;

public class PdfFileCreateCommand : IFileActionCommand
{
    private readonly PdfFileCreator _pdfFileCreator;

    public PdfFileCreateCommand(FileModel fileModel)
    {
        var pdfFile = fileModel;
        pdfFile.Type = "PDF";
        _pdfFileCreator = new PdfFileCreator(pdfFile);
    }

    public async Task Execute()
    {
        var result = await _pdfFileCreator.CreateFile();
        Console.WriteLine(result);
    }
}
