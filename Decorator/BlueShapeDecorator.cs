using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class BlueShapeDecorator : ShapeDecorator
    {
        public BlueShapeDecorator( IShape Shape):base(Shape)
        {
            this.decoratedShape = Shape;
        }

        public override void draw()
        {
            decoratedShape.draw();
            setRedBorder(decoratedShape);
        }
        private void setRedBorder(IShape decoratorShape)
        {
            Console.WriteLine("Border Color: Blue");
        }
    }
}
