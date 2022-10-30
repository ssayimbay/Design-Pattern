using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.ChainOfResponsibility.ProductListZipToSendMail.ChainOfResponsibility.Abstract;

public interface IProcessHandler
{
    IProcessHandler SetNext(IProcessHandler processHandler);
    object Handle(object o);
}
