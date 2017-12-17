using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class ShapeFactory : AbstractFactory
    {
        public override IColor getColor(string color)
        {
            return null;
        }

        public override IShape getShape(string shape)
        {
            if (shape == "Circle")
            {
                return new Circle();
            }
            else if (shape == "Square")
            {
                return new Square();
            }
            else if (shape == "Rectangle")
            {
                return new Rectangle();
            }
            return null;
        }
    }
}
