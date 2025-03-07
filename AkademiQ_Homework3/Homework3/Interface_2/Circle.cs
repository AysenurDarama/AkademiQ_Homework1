using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_2
{
    public class Circle:IDrawable,IAreaCalculate
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }
        public void Draw()
        {
            Console.WriteLine("Drawing a Circle.");
        }
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
