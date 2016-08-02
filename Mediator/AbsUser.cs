using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public abstract class  AbsUser
    {
        protected IChatMediator mediator;
        protected String name;

        public AbsUser(IChatMediator med, String name)
        {
            this.mediator = med;
            this.name = name;
        }

        public abstract void send(string msg);
        public abstract void receive(string msg);
    }
}
