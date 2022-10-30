using Behavioral.ChainOfResponsibility.ProductListZipToSendMail.ChainOfResponsibility.Abstract;
using Behavioral.ChainOfResponsibility.ProductListZipToSendMail.Models;

namespace Behavioral.ChainOfResponsibility.ProductListZipToSendMail.ChainOfResponsibility;

public class ZipFileProcessHandler : ProcessHandler
{
    public override object Handle(object o)
    {
        var productList = o as List<Product>;
        Console.WriteLine("Excel to zip..");
        return base.Handle(productList);
    }
}
