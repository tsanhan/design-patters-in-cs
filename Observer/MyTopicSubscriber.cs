using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class MyTopicSubscriber : IObserver
    {
        private string name;
        private ISubject topic;

        public MyTopicSubscriber(string name)
        {
            this.name = name;
        }
        public void setSubjet(ISubject sub)
        {
            this.topic = sub;
        }

        public void update()
        {
            string msg = topic.getUpdate(this) as string;
            if (msg == null)
            {
                Console.WriteLine(name + "No message");

            }
            else
            {
                Console.WriteLine(name + ":: Consuming Message:: "+ msg);
            }
        }
    }
}
