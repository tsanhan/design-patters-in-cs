using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class IntToHexExpression : IExpression
    {
        int i;

        public IntToHexExpression( int c)
        {
            this.i = c;
        }
        public string interpret(InterpreterContext ic)
        {
           return ic.getHexadecimalFormat(this.i);
        }
    }
}
