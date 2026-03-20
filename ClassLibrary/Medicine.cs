using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Medicine
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public double Cost { get; set; }
        public string Manufacturer { get; set; }
        public string Supplier { get; set; }
        public string ExpirationDate { get; set; }
        public string Description { get; set; }

        public Medicine(string name, string image, double cost, string manufacturer, string supplier, string expirationDate, string description)
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
