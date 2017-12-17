using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class MainFactory
    {
        public AbstractFactory getFactory(string factoryType)
        {
            if(factoryType == "COLOR")
            {
                return new ColorFactory();
            }
            else if(factoryType == "SHAPE")
            {
                return new ShapeFactory();
            }

            return null;
        }
    }
}
