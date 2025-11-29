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
        private Dictionary<Product, double> Products_ = new Dictionary<Product, double>();

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

        public void SetProductQuantity(Product product, double quantity)
        {
            Products_.Add(product, quantity);
        }
        public void PrintProductsQuantity()
        {
            foreach (Product product in Products_.Keys)
            {
                Console.WriteLine(product.GetName() + " " + Products_[product]);
            }
        }
        public double CalcMoney()
        {
            double money = 0;
            foreach (Product product in Products_.Keys)
            {
                money += product.GetPrice() * Products_[product];
            }
            return money;
        }
    }
}
