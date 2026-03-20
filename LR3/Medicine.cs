using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3
{
    public class Medicine
    {
        private string Name { get; set; }
        private string Image {  get; set; }
        private double Cost;
        private string Manufacturer;
        private string Supplier;
        private string ExpirationDate;
        private string Description;

        public Medicine (string name, string image, double cost, string manufacturer, string supplier, string expirationDate, string description)
        {
            Name = name;
            Image = image;
            Cost = cost;
            Manufacturer = manufacturer;
            Supplier = supplier;
            ExpirationDate = expirationDate;
            Description = description;
        }
        

    }
}
