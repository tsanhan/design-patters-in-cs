using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AbstructFactory;

namespace AbstructFactory
{
    class ShapeFactory : AbstructFactory
    {
        public override Shape GetShape(string shapeType)
        {
            if (shapeType == null)
                return null;

            if (shapeType.ToUpper().Equals("CIRCLE"))
            {
                return new Circle();

            }
            else if (shapeType.ToUpper().Equals("RECTANGLE"))
            {
                return new Rectangle();

            }
            else if (shapeType.ToUpper().Equals("SQUARE"))
            {
                return new Square();
            }

            return null;
        }
    }
}
