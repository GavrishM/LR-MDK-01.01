using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ВременнойРяд
{
    internal class Functions
    {
        static public int FindSalesPrice(List<Day> days, DateTime start, DateTime end)
        {
            int salesPrice = 0;
            foreach(Day day in days) 
            {
                if (day.Date > start | day.Date < end)
                {
                    foreach (Sale sale in day.SaleList)
                    {
                        salesPrice += Sale.SalePrice(sale.Quantity, sale.Price);
                    }
                } 
            }
            return salesPrice;
        }





    }
}
