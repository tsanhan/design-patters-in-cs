using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class ShapesList<T> : List<T>
    {
        //public void Clear();
        
        public void Clear()
        {
            base.Clear();
            Console.WriteLine("clearing all the shapes from drawing");
        }
    }

    public class Drawing : IShape
    {

        private ShapesList<IShape> shapes = new ShapesList<IShape>();
        

        public void drow(string fillColor)
        {
            foreach (IShape shape in shapes)
                shape.drow(fillColor);
            
        }

        public ShapesList<IShape> Shapes
        {
            get { return shapes; }
            set { shapes = value; }
        }


        
    }
}
