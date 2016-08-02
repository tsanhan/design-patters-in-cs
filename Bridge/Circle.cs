using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Circle : Shape
    {
        private int X, Y, Radius;
        public Circle(int x, int y, int radius, IDrawAPI drowAPI) : base(drowAPI)
        {
            this.X = x;
            this.Y = y;
            this.Radius = radius;
        }
        public override void drow()
        {
            base.DrawAPI.drawCircle(Radius, X, Y);
        }
    }
}
