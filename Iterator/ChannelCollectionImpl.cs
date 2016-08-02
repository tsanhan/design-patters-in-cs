using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class ChannelCollectionImpl : IChannelCollection
    {
        List<Channel> channelsList = new List<Channel>();

       
        public void addChannel(Channel c)
        {
            this.channelsList.Add(c);
        }


        public void removeChannel(Channel c)
        {
            this.channelsList.Remove(c);
        }

        public IChannelIterator iterator(ChannelTypeEnum type)
        {
            return new ChannelIteratorImpl(type, this.channelsList);
        }

        private class ChannelIteratorImpl : IChannelIterator
        {
            ChannelTypeEnum type;
            List<Channel> channels;
            int position;

            public ChannelIteratorImpl( ChannelTypeEnum type,List<Channel> channelsList)
            {
                this.type = type;
                this.channels = channelsList;
            }
            public bool hasNext()
            {
                while (position < this.channels.Count)
                {
                    Channel c = this.channels[this.position];
                    if (c.Type.Equals(this.type) || this.type.Equals(ChannelTypeEnum.ALL))
                        return true;
                    ++position;
                }
                return false;
            }

            public Channel next()
            {
                Channel c = channels[position++];
                return c;
            }
        }
    }
}
