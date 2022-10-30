using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credential.Singleton.LazySingleton;

public class LazySingleton
{
    private static readonly Lazy<LazySingleton> _instance = new Lazy<LazySingleton>(() => new LazySingleton(), true);
    private static int _count;
    private readonly string _name;

    public LazySingleton()
    {
        _count++;
        _name = $"{nameof(LazySingleton)}-{_count}";
    }

    public static LazySingleton Instance => _instance.Value;

    public override string ToString()
    {
        return _name;
    }
}
