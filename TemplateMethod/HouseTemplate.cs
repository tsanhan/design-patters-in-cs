using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class HouseTemplate
    {
        public void BuildHouse()
        {
            buildFoundation();
            buildPillers();
            buildWalls();
            buildWindows();
            Console.WriteLine("House is builed");
        }
        /// <summary>
        /// default implemenation
        /// </summary>
        protected void buildWindows()
        {
            Console.WriteLine("Building Glass Windows");
        }

        protected abstract void buildWalls();
        protected abstract void buildPillers();
        protected void buildFoundation()
        {
            Console.WriteLine("Building foundation with cement,iron rods and sand");
        }
    }
}
