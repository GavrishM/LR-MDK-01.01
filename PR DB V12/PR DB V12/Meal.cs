using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_DB_V12
{
    public class Meal
    {
        [DisplayName("Название")]
        public string Name { get; set; }
        [DisplayName("Категория")]
        public string Type { get; set; }
        [DisplayName("Цена")]
        public int Price { get; set; }
        [DisplayName("Доставка")]
        public bool Delivery { get; set; }

        public Meal(string name, string type, int price, bool delivery)
        {
            Name = name;
            Type = type;
            Price = price;
            Delivery = delivery;
        }
        public Meal() { }
    }
}
