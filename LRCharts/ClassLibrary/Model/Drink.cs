using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Model
{
    public class Drink
    {
        public string Name { get; set; }
        public double Cost { get; set; }
        public Drink(string name, double cost) 
        {
            Name = name;
            Cost = cost;
        }
    }
}
