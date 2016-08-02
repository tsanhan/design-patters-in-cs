using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public interface IDispenseChain
    {
        void setNextChain(IDispenseChain netChain);
        void dispence(Currency cur);
    }
}
