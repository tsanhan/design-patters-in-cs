using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
     
    public enum Color
    {
        red,
        green,
        blue,
        black,
        white,
        Count
    }
    public interface IShape
    {
        void Drow();
    }
}
