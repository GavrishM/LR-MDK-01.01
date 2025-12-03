using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _031225
{
    public class Circle : IShape //Создаем класс для кругов
    {
        public double Radius { get; set; }
        public Circle(double radius) => Radius = radius;
        public void Accept(IVisitor visitor) => visitor.Visit(this);
    }
}
