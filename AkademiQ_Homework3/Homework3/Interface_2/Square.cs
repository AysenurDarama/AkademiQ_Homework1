using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_2
{
    public class Square : IDrawable, IAreaCalculate
    {
        public double Side { get; set; }

        public Square(double side)
        {
            Side = side;
        }
        public void Draw()
        {
            Console.WriteLine("Drawing a Square.");
        }
        public double CalculateArea()
        {
            return Side * Side;
        }
    }
}
