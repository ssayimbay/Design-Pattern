
using Behavioral.Command.FileCreator.Models;
using Behavioral.Command.FileCreator.Services;
using Behavioral.Command.FileCreator.Services.Commands;


var excelFileCreateCommand = new ExcelFileCreateCommand(new FileModel { Content ="Test Text", Type = "Excel" });
var pdfFileCreateCommand = new PdfFileCreateCommand(new FileModel { Content = "Test Text", Type = "Excel" });
var jsonFileCreateCommand = new JsonFileCreateCommand(new FileModel { Content = "Test Text", Type = "Excel" });

var fileCreateInvoker = new FileCreateInvoker();

Console.WriteLine("EXCEL COMMAND");
fileCreateInvoker.SetCommand(excelFileCreateCommand);
fileCreateInvoker.Create();

Console.WriteLine("PDF COMMAND");
fileCreateInvoker.SetCommand(pdfFileCreateCommand);
fileCreateInvoker.Create();


Console.WriteLine("JSON COMMAND");
fileCreateInvoker.SetCommand(jsonFileCreateCommand);
fileCreateInvoker.Create();

Console.WriteLine("ALL COMMAND");
fileCreateInvoker.AddCommand(excelFileCreateCommand);
fileCreateInvoker.AddCommand(pdfFileCreateCommand);
fileCreateInvoker.AddCommand(jsonFileCreateCommand);
fileCreateInvoker.Creates();

Console.ReadLine();
