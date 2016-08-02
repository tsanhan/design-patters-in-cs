using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class User : AbsUser
    {
        public User(IChatMediator med, string name) : base(med,name)
        {

        }
        public override void receive(string msg)
        {
            Console.WriteLine(this.name + ": Received Message:" + msg);
        }

        public override void send(string msg)
        {
            Console.WriteLine(this.name + " Sending Message=" + msg);
            mediator.sendMessage(msg, this);
        }
    }
}
