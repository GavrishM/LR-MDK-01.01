using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ВременнойРяд
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Магазин занимается продажей мобильных телефонов. За каждый день известно,
            //    сколько было продано и каких телефонов.
            // а) определить общую сумму проданного за период X
            // б) определить самый продаваемый телефон и телефон с наименьшим фактом продаж
            // в) определить два телефона, приносящие наибольшую прибыль
            //    Данные о продажах представить как временной ряд
            //    В качестве метки времени использовать дату(объект DateTime)
            string[] modelList = new string[6];
            modelList[0] = "iPhone 13";
            modelList[1] = "Samsung Galaxy S21";
            modelList[2] = "iPhone 15";
            modelList[3] = "Google Pixel 6";
            modelList[4] = "Samsung Galaxy S22";
            modelList[5] = "iPhone 14";
            List<Day> days= new List<Day>();
            Random rnd = new Random();




        }
    }
}
