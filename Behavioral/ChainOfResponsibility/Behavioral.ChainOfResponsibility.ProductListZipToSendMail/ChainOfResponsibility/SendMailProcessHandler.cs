using Behavioral.ChainOfResponsibility.ProductListZipToSendMail.ChainOfResponsibility.Abstract;
using Behavioral.ChainOfResponsibility.ProductListZipToSendMail.Models;

namespace Behavioral.ChainOfResponsibility.ProductListZipToSendMail.ChainOfResponsibility;

public class SendMailProcessHandler : ProcessHandler
{
    public override object Handle(object o)
    {
        var productList = o as List<Product>;
        Console.WriteLine("Zip file send to mail..");
        return base.Handle(null);
    }
}
