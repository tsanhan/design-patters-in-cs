using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class ShapeFactory
    {
        private static readonly Dictionary<Color, IShape> circleMap = new Dictionary<Color, IShape>();
        public static IShape GetCircle(Color clr)
        {
            bool check = circleMap.ContainsKey(clr);
            IShape circle = new Circle(Color.black);// = (IShape)circleMap[clr];
            if (!check)
            {
                circle = new Circle(clr);
                circleMap.Add(clr, circle);
                Console.WriteLine("Creating circle of color : " + clr);

            }
            return circle;
        }
    }
}
