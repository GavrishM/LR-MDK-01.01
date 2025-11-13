using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ВременнойРяд
{
    public struct Day
    {
        public DateTime Date;       //   Дата
        public List<Sale> SaleList; //   Список продаж за день
    }
}
