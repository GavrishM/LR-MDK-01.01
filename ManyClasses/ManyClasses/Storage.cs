using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyClasses
{
    public class Storage
    {
        private int Id_;
        private string Address_;
        private Dictionary<Product, double> Products_;

        public void SetId(int id)
        {
            Id_ = id;
        }
        public int GetId()
        {
            return Id_;
        }

        public void SetAddress(string address)
        {
            Address_ = address;
        }
        public string GetAddress()
        {
            return Address_;
        }

        public void SetProducts(Dictionary<Product, double> products)
        {
            Products_ = products;
        }
        public Dictionary<Product, double> GetProducts()
        {
            return Products_;
        }

    }
}
