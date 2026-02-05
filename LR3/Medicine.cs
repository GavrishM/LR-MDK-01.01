using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3
{
    public class Medicine
    {
        private string name_;
        private string image_;
        private double cost_;
        private string manufacturer_;
        private string supplier_;
        private string expirationDate_;
        private string description_;

        public Medicine (string name, string image, double cost, string manufacturer, string supplier, string expirationDate, string description)
        {
            this.name_ = name;
            this.image_ = image;
            this.cost_ = cost;
            this.manufacturer_ = manufacturer;
            this.supplier_ = supplier;
            this.expirationDate_ = expirationDate;
            this.description_ = description;
        }

        public string Name
        {
            get { return name_; }
            set { name_ = value; }
        }
        public string Image
        {
            get { return image_; }
            set { image_ = value; }
        }
        public double Cost
        {
            get { return cost_; }
            set { cost_ = value; }
        }
        public string Manufacturer
        {
            get { return manufacturer_; }
            set { manufacturer_ = value; }
        }
        public string Supplier
        {
            get { return supplier_; }
            set { supplier_ = value; }
        }
        public string ExpirationDate
        {
            get { return expirationDate_; }
            set { expirationDate_ = value; }
        }
        public string Description
        {
            get { return description_; }
            set { description_ = value; }
        }

    }
}
