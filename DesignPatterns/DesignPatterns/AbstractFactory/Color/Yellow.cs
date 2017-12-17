using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class Yellow : IColor
    {
        public void paint()
        {
            Console.WriteLine("Painting with Yellow..");
        }
    }
}
