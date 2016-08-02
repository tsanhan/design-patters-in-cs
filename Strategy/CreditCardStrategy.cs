using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class CreditCardStrategy : IPaymentStrategy
    {
        string name;
        string cardNumber;
        string CVV;
        string dateOfExpiry;

        public CreditCardStrategy(string nm,string ccNum, string cvv,string expiryDate)
        {
            this.name = nm;
            this.cardNumber = ccNum;
            this.CVV = cvv;
            this.dateOfExpiry = expiryDate;
        }
        public void pay(int amount)
        {
            Console.WriteLine(amount + " paid with credit/debit card");
        }
    }
}
