using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyClasses
{
    public class Product
    {
        private string Name_;
        private double Price_;
        public void SetName(string name)
        {
            Name_ = name;
        }
        public string GetName() 
        {
            return Name_;
        }

        public void SetPrice(double price)
        {
            Price_ = price;
        }
        public double GetPrice()
        {
            return Price_;
        }
    }
}
