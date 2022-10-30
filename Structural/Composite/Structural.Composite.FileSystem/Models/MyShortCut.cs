using Structural.Composite.FileSystem.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Composite.FileSystem.Models;

internal class MyShortCut : CompositeStorageElement
{
    public MyShortCut(string name, IStorage parent) : base(name, parent)
    {
    }
}
