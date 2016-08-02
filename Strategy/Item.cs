using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Item
    {
        string upcCode;
        int price;
        public Item(string upc, int cost)
        {
            this.upcCode = upc;
            this.price = cost;
        }

        public string UpcCode { get { return upcCode; } }
        public int Price { get { return price; } }

    }
}
