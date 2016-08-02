using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
   public  class InterpreterClient
    {
        InterpreterContext ic;

        public InterpreterClient(InterpreterContext i)
        {
            this.ic = i;
        }

        public string interpret(string str)
        {
            IExpression exp = null;
            //create rules for expressions
            if(str.ToLower().Contains(value: "hexadecimal"))
            {

                exp = new IntToHexExpression(Convert.ToInt32(str.Substring(startIndex: 0, length: str.IndexOf(value: " "))));
                
            }
            else if(str.ToLower().Contains(value: "binary"))
            {
                exp = new IntToBinaryExpression(Convert.ToInt32(str.Substring(startIndex: 0, length: str.IndexOf(value: " "))));
            }
            return exp.interpret(ic);
        }
    }
}
