using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Packing;

namespace Builder.Item
{
    public abstract class Burger : IItem
    {
        public abstract string name();
       

        public Packing.IPacking packing()
        {
            return new Wraper();
        }

        public abstract float price();
        
    }
}
