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
            //storage.PrintProductsQuantity();
            //Console.WriteLine(storage.CalcMoney());
            Report rep1 = new Report();
            //rep1.SetStorage(storage);
            //rep1.PrintReport();

            //Row row1 = new Row();
            //row1.Product = "сосновая шишка";
            //row1.Price = 2123;
            //row1.Quantity = 3;
            //rep1.AddRow(row1);

            //Row row2 = new Row();
            //row2.Product = "кедровая шышка";
            //row2.Price = 2453;
            //row2.Quantity = 87;
            //rep1.AddRow(row2);

            //Row row3 = new Row();
            //row3.Product = "еловая шышка";
            //row3.Price = 2433;
            //row3.Quantity = 809;
            //rep1.AddRow(row3);

            rep1.SetStorage(storage);
            rep1.AddRow();
            Console.WriteLine(rep1.ReportToString());
            
        }
    }
}
