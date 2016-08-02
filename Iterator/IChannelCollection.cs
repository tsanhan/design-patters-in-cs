using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public interface IChannelCollection
    {
        void addChannel(Channel c);
        void removeChannel(Channel c);

        IChannelIterator iterator(ChannelTypeEnum type);
    }
}
