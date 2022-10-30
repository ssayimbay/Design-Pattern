using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.ChainOfResponsibility.ProductListZipToSendMail.ChainOfResponsibility.Abstract;

public abstract class ProcessHandler : IProcessHandler
{
    private IProcessHandler? _nextProcessHandler;
    public virtual object Handle(object o)
    {
        if(_nextProcessHandler != null)
        {
            return _nextProcessHandler.Handle(o);
        }
        return null;
    }

    public IProcessHandler SetNext(IProcessHandler processHandler)
    {
        _nextProcessHandler = processHandler;
        return _nextProcessHandler;
    }
}
