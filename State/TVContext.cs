using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    /// <summary>
    /// our Context object will change its behavior based on its internal state
    /// </summary>
    public class TVContext : IState
    {
        IState _tvState;
        

        public IState State
        {
            get { return _tvState; }
            set { _tvState = value; }
        }
        public void doAction()
        {
            this.State.doAction();
        }
    }
}
