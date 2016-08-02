using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public interface ISubject
    {
        /// <summary>
        /// resgister an observer
        /// </summary>
        /// <param name="obj"></param>
        void register(IObserver obj);

        /// <summary>
        /// unregister an observer
        /// </summary>
        /// <param name="obj"></param>
        void unregister(IObserver obj);


        void notifyObservers();

        /// <summary>
        /// method to get updated from subject
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        object getUpdate(IObserver obj);
    }
}
