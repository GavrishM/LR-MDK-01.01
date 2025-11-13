using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ВременнойРяд
{
    public struct Sale              //   Продажа телефона\телефонов
    {                               //
        public string PhoneModel;   //   Модель телефона
        public int Quantity;        //   Количество
        public int Price;           //   Цена
                                    // V Цена купленных телефонов
        static public int SalePrice (int Quantity, int Price)
        {
            int salePrice = Quantity * Price;
            return salePrice;
        }


    }
}
