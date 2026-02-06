using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClassLibrary
{
    public class Logic
    {
        public bool LogicAnd(bool x, bool y)
        {
            bool result = false;
            if (x == y) result = true;
            else result = false;
                return result;
        }
    }
}
