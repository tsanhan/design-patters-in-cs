using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public interface IExpression
    {
        String interpret(InterpreterContext ic);
    }
}
