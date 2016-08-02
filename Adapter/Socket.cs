using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Socket
    {
        public Volt getVolt()
        {
            return new Volt(120);
        }
    }
}
