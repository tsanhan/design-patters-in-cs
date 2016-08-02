using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstructFactory;


namespace AbstructFactory
{
    class ColorFactory : AbstructFactory
    {
        public override Color GetColor(string colorType)
        {

            if (colorType.ToUpper().Equals("BLUE"))
            {
                return new Blue();

            }
            else if (colorType.ToUpper().Equals("GREEN"))
            {
                return new Green();

            }
            else if (colorType.ToUpper().Equals("RED"))
            {
                return new Red();
            }
            return null;
        }

    }
}
