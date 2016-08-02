using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Computer
    {
        //requierd
        private string HDD;
        private string RAM;

        //optional
        private bool isGraphicsCardEnabled;
        private bool isBluetoothEnabled;

        public string getHDD
        {
            get { return HDD; }
        }
        public string getRAM
        {
            get { return RAM; }
        }
        
        public bool GraphicsCardEnabled()
        {
            return isGraphicsCardEnabled;
        }
        public bool BluetoothEnabled()
        {
            return isBluetoothEnabled;
        }

        public Computer(ComputerBuilder builder)
        {
            this.HDD = builder.HDD;
            this.RAM = builder.RAM;
            this.isBluetoothEnabled = builder.BluetoothEnabled;
            this.isGraphicsCardEnabled = builder.GraphicsCardEnabled;
        }
    }
}
