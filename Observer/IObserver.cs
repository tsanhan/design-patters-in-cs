using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public interface IObserver
    {
        /// <summary>
        /// method to update the observer, used by subject
        /// </summary>
        void update();

        /// <summary>
        /// attach with subject to observe
        /// </summary>
        /// <param name="sub">the subject this observer observe</param>
        void setSubjet(ISubject sub);
    }
}
