using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class ATMDispenseChain
    {
        public IDispenseChain c1;

        public ATMDispenseChain()
        {
            //init the chain
            this.c1 = new Dollar50Dispencer();
            IDispenseChain c2 = new Dollar20Dispenser();
            IDispenseChain c3 = new Dollar10Dispenser();

            //set the chain
            c1.setNextChain(c2);
            c2.setNextChain(c3);
        }
    }

}
