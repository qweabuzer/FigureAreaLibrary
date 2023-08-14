using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figure_area
{
    public class Triangle : Shape
    {
        public double Osnov { get; set; }
        public double Height { get; set; }

        public Triangle(double osnov, double height)
        {
            Osnov = osnov;
            Height = height;
        }

        public override double CalculateArea()
        {
            return 0.5 * Osnov * Height;
        }
    }
}
