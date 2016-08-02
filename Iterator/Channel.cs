using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class Channel
    {
        double frequency;
        ChannelTypeEnum TYPE;

        public Channel(double freq, ChannelTypeEnum type)
        {
            this.frequency = freq;
            this.TYPE = type;
        }

        public double Frequency
        { get { return frequency; } }

        public ChannelTypeEnum Type
        { get { return TYPE; } }

        public override string ToString()
        {
            return "Frequency=" + this.Frequency + ", Type:" + this.Type;              
        }
    }
}
