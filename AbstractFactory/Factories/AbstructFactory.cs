using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstructFactory
{
    public abstract class AbstructFactory
    {
        public virtual  Color GetColor(string color)
        {
            return null;
        }
        public virtual Shape GetShape(string shape)
        {
            return null;
        }
    }
}
