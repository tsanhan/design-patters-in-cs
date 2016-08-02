using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    /// <summary>
    /// a Leaf to the Base Component
    /// </summary>
     public class Circle : IShape
    {
        public void drow(string fillColor)
        {
            Console.WriteLine("Drowing Circle with Color: " + fillColor);
        }
    }
}
