using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class Circle : IShape
    {
        private Color color;
        public int X { private get; set; }
        public int Y { private get; set;  }
        private int radius;


        public void setRadius(int radius)
        {
            this.radius = radius;
        }
        public Circle(Color color )
        {
            this.color = color;
        }
        public void Drow()
        {
            Console.WriteLine("Circle: Draw() [Color : " + color + ", x : " + X + ", y :" + Y + ", radius :" + radius);
        }
    }
}
