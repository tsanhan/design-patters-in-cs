using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class InterpreterContext
    {
        private static string ToBinaryString(long _long)
        {
            // have to do this or it won’t print the leading 0 values        
            return Convert.ToString(_long, toBase: 2);
        }

        public  string getBinary(int i)
        {
            return ToBinaryString(i);
        }

        public string getHexadecimalFormat(int i)
        {
            return Convert.ToString(i, toBase: 16);
        }

    }
}
