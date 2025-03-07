using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_2
{
    public class Triangle : IDrawable, IAreaCalculate
    {
        public double Base_ { get; set; }
        public double Heigth { get; set; }

        public Triangle(double base_, double heigth)
        {
            Base_ = base_;
            Heigth = heigth;
        }
        public void Draw()
        {
            Console.WriteLine("Drawing a Triangle.");
        }
        public double CalculateArea()
        {
            return (Base_ * Heigth)/2;
        }
    }
}
