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
        private double Cost { get; set; }
        private string Manufacturer { get; set; }
        private string Supplier { get; set; }
        private string ExpirationDate { get; set; }
        private string Description { get; set; }

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
