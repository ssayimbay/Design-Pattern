
using Behavioral.Command.FileCreator.Models;
using Behavioral.Command.FileCreator.Services;
using Behavioral.Command.FileCreator.Services.Commands;


var excelFileCreateCommand = new ExcelFileCreateCommand(new FileModel { Content ="Test Text", Type = "Excel" });
var pdfFileCreateCommand = new PdfFileCreateCommand(new FileModel { Content = "Test Text", Type = "Excel" });
var jsonFileCreateCommand = new JsonFileCreateCommand(new FileModel { Content = "Test Text", Type = "Excel" });

var fileCreateInvoker = new FileCreateInvoker();

Console.WriteLine("EXCEL COMMAND");
fileCreateInvoker.AddCommand(excelFileCreateCommand).Create();

Console.WriteLine("PDF COMMAND");
fileCreateInvoker.AddCommand(pdfFileCreateCommand).Create();

Console.WriteLine("JSON COMMAND");
fileCreateInvoker.AddCommand(jsonFileCreateCommand).Create();

Console.WriteLine("ALL COMMAND");
fileCreateInvoker.AddCommand(excelFileCreateCommand)
                 .AddCommand(pdfFileCreateCommand)
                 .AddCommand(jsonFileCreateCommand)
                 .AddCommand(jsonFileCreateCommand)
                 .RemoveCommand(jsonFileCreateCommand)
                 .AddCommand(jsonFileCreateCommand)
                 .Create();

Console.ReadLine();
