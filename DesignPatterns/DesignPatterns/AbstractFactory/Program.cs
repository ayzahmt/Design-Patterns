using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Which shape you would draw? Please choose one");
            Console.WriteLine("1.Circle \n2.Square \n3.Rectangle");

            var shapeType = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Which color you would paint? Please choose one");
            Console.WriteLine("1.Red \n2.Yellow \n3.Blue");
            
            var colorType = Convert.ToInt32(Console.ReadLine());

            var shapeFactory = new MainFactory().getFactory("SHAPE");
            var colorFactory = new MainFactory().getFactory("COLOR");
            
            if(shapeType == 1)
            {
                shapeFactory.getShape("Circle").draw();
            }
            else if (shapeType == 2)
            {
                shapeFactory.getShape("Square").draw();
            }
            else if (shapeType == 3)
            {
                shapeFactory.getShape("Rectangle").draw();
            }

            if (colorType == 1)
            {
                colorFactory.getColor("Red").paint();
            }
            else if (colorType == 2)
            {
                colorFactory.getColor("Yellow").paint();
            }
            else if (colorType == 3)
            {
                colorFactory.getColor("Blue").paint();
            }

            Console.Read();
        }
    }
}
