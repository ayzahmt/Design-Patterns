using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class Circle : IShape
    {
        public void draw()
        {
            Console.WriteLine("Circle is drawing..");
        }
    }
}
