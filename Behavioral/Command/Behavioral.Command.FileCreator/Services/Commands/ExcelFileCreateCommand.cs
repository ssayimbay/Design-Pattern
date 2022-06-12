using Behavioral.Command.FileCreator.Models;
using Behavioral.Command.FileCreator.Services.Receivers;
using System.IO;

namespace Behavioral.Command.FileCreator.Services.Commands;

public class ExcelFileCreateCommand : IFileActionCommand
{
    private ExcelFileCreator _excelFileCreator;

    public ExcelFileCreateCommand(FileModel fileModel)
    {
        var excelFile = fileModel;
        excelFile.Type = "EXCEL";
        _excelFileCreator = new ExcelFileCreator(excelFile);
    }

    public async Task Execute()
    {
        var result = await _excelFileCreator.CreateFile();
        Console.WriteLine(result);
    }
}
