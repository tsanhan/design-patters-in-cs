using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class TVStopState : IState
    {
        public void doAction()
        {
            Console.WriteLine("TV is turned OFF");
        }
    }
}
