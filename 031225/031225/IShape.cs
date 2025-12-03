using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _031225
{
    public interface IShape
    {
        void Accept(IVisitor visitor);
    }
}
