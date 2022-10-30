
using Behavioral.ChainOfResponsibility.ProductListZipToSendMail.ChainOfResponsibility;
using Behavioral.ChainOfResponsibility.ProductListZipToSendMail.Models;


var productList = new List<Product>
        {
            new Product { Id=1, Name="Product-1", Price=100, Stock=100},
            new Product { Id=2, Name="Product-2", Price=200, Stock=200},
            new Product { Id=3, Name="Product-3", Price=300, Stock=300},
            new Product { Id=4, Name="Product-4", Price=400, Stock=400},
        };

var excelProcessHandler = new ExcelProcessHandler();
var zipFileProcessHandler = new ZipFileProcessHandler();
var sendMailProcessHandler = new SendMailProcessHandler();

excelProcessHandler.SetNext(zipFileProcessHandler)
                   .SetNext(sendMailProcessHandler);

excelProcessHandler.Handle(productList);

Console.ReadLine();