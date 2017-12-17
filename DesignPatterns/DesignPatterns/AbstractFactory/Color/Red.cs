using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class Red : IColor
    {
        public void paint()
        {
            Console.WriteLine("Painting with Red..");
        }
    }
}
