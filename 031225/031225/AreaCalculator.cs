using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _031225
{
    public class AreaCalculator : IVisitor //Создаем класс для вычисления площади фигур
    {
        public double Area { get; private set; }

        public void Visit(Circle circle)
        {
            Area = Math.PI * Math.Pow(circle.Radius, 2);
        }

        public void Visit(Rectangle rectangle)
        {
            Area = rectangle.Width * rectangle.Height;
        }

        public void Visit(Triangle triangle)
        {
            // Используем формулу Герона
            double s = (triangle.SideA + triangle.SideB + triangle.SideC) / 2;
            Area = Math.Sqrt(s * (s - triangle.SideA) * (s - triangle.SideB) * (s - triangle.SideC));
        }
    }
}
