using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class Dollar20Dispenser : IDispenseChain
    {
        private IDispenseChain chain;
        public void dispence(Currency cur)
        {
            if (cur.Amount >= 20)
            {
                int num = cur.Amount / 20;
                int remainer = cur.Amount % 20;
                Console.WriteLine("Dispencing " + num + " 20$ note");
                if (remainer != 0)
                {
                    this.chain.dispence(new Currency() { Amount = remainer });
                }
            }
            else
            {
                this.chain.dispence(cur);
            }
        }

        public void setNextChain(IDispenseChain nextChain)
        {
            this.chain = nextChain;
        }

    }
}
