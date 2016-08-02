using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine(value: "Circle::draw()");
        }
    }
}
