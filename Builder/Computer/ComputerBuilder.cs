using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class ComputerBuilder
    {

        internal bool BluetoothEnabled;
        internal bool GraphicsCardEnabled;
        internal string HDD;
        internal string RAM;

        public ComputerBuilder(string hdd, string ram)
        {
            this.HDD = hdd;
            this.RAM = ram;
        }

        public ComputerBuilder setGraphicsCardEnabled(bool isGraphicsCardEnabled)
        {
            this.GraphicsCardEnabled = isGraphicsCardEnabled;
            return this;
        }

        public ComputerBuilder setBluetoothEnabled(bool isBluetoothEnabled)
        {
            this.BluetoothEnabled = isBluetoothEnabled;
            return this;
        }

        public Computer build()
        {
            return new Computer(this);
        }
    }
}
