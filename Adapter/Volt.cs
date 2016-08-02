using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Volt
    {
        public int Volts { get; set; }
        public Volt( int volts)
        {
            this.Volts = volts;
        }
    }
}
