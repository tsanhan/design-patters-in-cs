using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class IntToBinaryExpression : IExpression
    {
        int i;
        public IntToBinaryExpression(int c)
        {
            this.i = c;
        }
        public string interpret(InterpreterContext ic)
        {
            return ic.getBinary(this.i);
        }
    }
}
