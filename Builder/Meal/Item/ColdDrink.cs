using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Packing;

namespace Builder.Item
{
    public abstract class ColdDrink : IItem
    {
        public abstract string name();


        public IPacking packing()
        {
            return new Bottle();
        }

        public abstract float price();
        
    }
}
