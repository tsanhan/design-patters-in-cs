using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstructFactory
{
    internal class Rectangle : Shape
    {
        public void Drow()
        {
            Console.WriteLine("Inside Rectangle::draw() method.");
        }
    }
}
