using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class SocketObjetAdapterImp : ISocketAdapter
    {
        private Socket sock = new Socket();

        public Volt get120Volt()
        {
            return sock.getVolt();

        }

        public Volt get12Volt()
        {
            Volt temp = sock.getVolt();
            return convertVolt(temp, 10);
        }

        public Volt get3Volt()
        {
            Volt temp = sock.getVolt();
            return convertVolt(temp, 40);
        }

        private Volt convertVolt(Volt v, int i)
        {
            return new Volt(v.Volts / i);
        }
    }
}
