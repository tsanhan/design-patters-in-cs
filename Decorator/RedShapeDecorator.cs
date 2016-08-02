using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class RedShapeDecorator : ShapeDecorator
    {
        public RedShapeDecorator( IShape decoratorShape):base(decoratorShape)
        {
            
        }

        public override void draw()
        {
            decoratedShape.draw();
            setRedBorder(decoratedShape);
        }

        private void setRedBorder(IShape decoratorShape)
        {
            Console.WriteLine("Border Color: Red");
        }
    }
}
