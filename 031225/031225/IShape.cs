using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _031225
{
    public interface IShape //Создаем интерфейс фигур
    {
        void Accept(IVisitor visitor);
    }
}
