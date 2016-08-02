﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class GlassHouse : HouseTemplate
    {
        protected override void buildPillers()
        {
            Console.WriteLine("Building Glass Walls");
        }

        protected override void buildWalls()
        {
            Console.WriteLine("Building Pillars with glass coating");
        }
    }
}