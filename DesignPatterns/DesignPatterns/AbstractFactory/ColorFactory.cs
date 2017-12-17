using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class ColorFactory : AbstractFactory
    {
        public override IColor getColor(string color)
        {
            if(color == "Red")
            {
                return new Red();
            }
            else if (color == "Blue")
            {
                return new Blue();
            }
            else if (color == "Yellow")
            {
                return new Yellow();
            }
            return null;
        }

        public override IShape getShape(string shape)
        {
            return null;
        }
    }
}
