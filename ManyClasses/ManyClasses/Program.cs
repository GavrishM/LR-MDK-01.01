using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyClasses
{
    class Program
    {
        static void Main()
        {
            Product Merc = new Product();
            Merc.SetPrice(1000000);
            Merc.SetName("Mercedes");

            Product Uaz = new Product();
            Uaz.SetPrice(10000000);
            Uaz.SetName("Uaz");

            Storage storage = new Storage();
            storage.SetId(3);
            storage.SetAddress("Торжок, Студенческая 3");

            storage.SetProductQuantity(Merc, 2);
            storage.SetProductQuantity(Uaz, 5);
            storage.PrintProductsQuantity();
            Console.WriteLine(storage.CalcMoney());
        }
    }
}
