using Behavioral.ChainOfResponsibility.ProductListZipToSendMail.ChainOfResponsibility.Abstract;
using Behavioral.ChainOfResponsibility.ProductListZipToSendMail.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.ChainOfResponsibility.ProductListZipToSendMail.ChainOfResponsibility;

public class ExcelProcessHandler: ProcessHandler
{
    public override object Handle(object o)
    {
        var productList = o as List<Product>;
        Console.WriteLine("Product list to excel..");
        return base.Handle(productList);
    }
}
