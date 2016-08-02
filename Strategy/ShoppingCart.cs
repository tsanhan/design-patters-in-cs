using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ShoppingCart
    {
        

        public List<Item> items { get; set; }
        public ShoppingCart()
        {
            items = new List<Item>();
        }
        public int calcTotal()
        {
          return  items.Sum(x => x.Price);
        }

        public void pay(IPaymentStrategy paymentMethod)
        {
            int amount = calcTotal();
            paymentMethod.pay(amount);
        }
    }
}
