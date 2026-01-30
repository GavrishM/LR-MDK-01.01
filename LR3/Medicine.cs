using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3
{
    public class Medicine : MedicineGroup
    {
        private string name_;
        private string image_;
        private double cost_;
        private string manufacturer_;
        private string supplier_;
        private string expirationDate_;
        private string decription_;

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
        public string Decription
        {
            get { return decription_; }
            set { decription_ = value; }
        }

    }
}
