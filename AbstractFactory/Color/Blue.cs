using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstructFactory
{
    internal class Blue : Color
    {
        public void Fill()
        {
            Console.WriteLine("Inside Blue::Fill() method.");
        }
    }
}
