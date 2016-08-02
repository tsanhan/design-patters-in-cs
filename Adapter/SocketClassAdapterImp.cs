using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class SocketClassAdapterImp : Socket, ISocketAdapter
    {
        public Volt get120Volt()
        {
            return getVolt();
        }

        public Volt get12Volt()
        {
            return convertVolt(getVolt(), 10);
        }

        public Volt get3Volt()
        {
            return convertVolt(getVolt(), 40);
        }

        private Volt convertVolt(Volt v, int i)
        {
            return new Volt(v.Volts / i);
        }
    }
}
