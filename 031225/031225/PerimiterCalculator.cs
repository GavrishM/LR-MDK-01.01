using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _031225
{
    public class PerimeterCalculator : IVisitor
    {
        public double Perimeter { get; private set; }

        public void Visit(Circle circle)
        {
            Perimeter = 2 * Math.PI * circle.Radius;
        }

        public void Visit(Rectangle rectangle)
        {
            Perimeter = 2 * (rectangle.Width + rectangle.Height);
        }

        public void Visit(Triangle triangle)
        {
            Perimeter = triangle.SideA + triangle.SideB + triangle.SideC;
        }
    }
}
