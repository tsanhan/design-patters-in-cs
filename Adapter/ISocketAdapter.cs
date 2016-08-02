using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public interface ISocketAdapter
    {
        Volt get120Volt();
        Volt get12Volt();
        Volt get3Volt();

    }
}
