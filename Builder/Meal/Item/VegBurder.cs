using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Item
{
    class VegBurder : Burger
    {
        public override string name()
        {
            return "VegBurder";
        }

        public override float price()
        {
            return 5.65554f;
        }
    }
}
