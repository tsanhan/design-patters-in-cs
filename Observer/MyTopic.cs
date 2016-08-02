using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class MyTopic : ISubject
    {
        private List<IObserver> observers;
        
        private bool changed;
        private object MUTEX = new object();
        private object message;

        public MyTopic()
        {
            this.observers = new List<IObserver>();
        }
        public object getUpdate(IObserver obj)
        {
            return this.message;
        }

        public void notifyObservers()
        {
            List<IObserver> observersLocal = null;
            lock(this)
            {
                if (!changed)
                    return;
                observersLocal = new List<IObserver>(observers);
                this.changed = false;
            }
            foreach(IObserver obs in observers)
            {
                obs.update();
            }
        }

        public void register(IObserver obj)
        {
            Contract.Requires(obj != null);
            lock(this)
            {
                if (!observers.Contains(obj))
                    observers.Add(obj);
            }

        }

        public void unregister(IObserver obj)
        {
            lock(this)
            {
                if(observers.Contains(obj))
                {
                    observers.Remove(obj);
                }
            }
        }

        public void postMessage(string msg)
        {
            Console.WriteLine("Message Posted to Topic: " + msg);
            this.message = msg;
            this.changed = true;
            notifyObservers();
        }
    }
}
