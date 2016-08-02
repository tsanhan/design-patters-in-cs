using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Packing;

namespace Builder.Item
{
    public interface IItem
    {
        string name();
        Packing.IPacking packing();
        float price();

    }
}
