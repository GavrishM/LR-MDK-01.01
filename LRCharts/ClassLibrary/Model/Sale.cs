using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Model
{
    public class Sale
    {
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
        public Sale(int quantity, DateTime date)
        {
            Quantity = quantity;
            Date = date;
        }
    }
}
