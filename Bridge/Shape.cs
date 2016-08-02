using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class Shape 
    {
        protected  IDrawAPI DrawAPI { get; set; }

        public Shape(IDrawAPI drawAPI)
        {
            this.DrawAPI = drawAPI;
        }
        public abstract void drow();

    }
}
