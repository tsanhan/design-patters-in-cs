using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class PaypalStrategy : IPaymentStrategy
    {
        string emailID;
        string password;

        public PaypalStrategy(string email, string pwd)
        {
            this.emailID = email;
            this.password = pwd;
        }
        public void pay(int amount)
        {
            Console.WriteLine(amount + " paid using Paypal.");
        }
    }
}
