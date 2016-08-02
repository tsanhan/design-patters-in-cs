using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstructFactory
{
    internal class Square : Shape
    {
        public void Drow()
        {
            Console.WriteLine("Inside Square::draw() method.");
        }
    }
}
