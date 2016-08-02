using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class ChatMediator : IChatMediator
    {
        List<AbsUser> users;

        public ChatMediator()
        {
            this.users = new List<AbsUser>();
        }
        public void addUser(AbsUser user)
        {
            this.users.Add(user);
        }

        public void sendMessage(string msg, AbsUser user)
        {
            foreach(AbsUser u in this.users)
            {
                if (u != user)
                    u.receive(msg);
            }
        }
    }
}
