using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class GreenCircle : IDrawAPI
    {
        public void drawCircle(int Radius, int X, int Y)
        {
            Console.WriteLine("Drawing Circle[ color: green, radius: " + Radius + ", x: " + X + ", " + Y + "]");
        }
    }
}
