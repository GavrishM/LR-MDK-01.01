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
            string[] modelList = new string[6];     //Список моделей телефонов
            modelList[0] = "iPhone 13";
            modelList[1] = "Samsung Galaxy S21";
            modelList[2] = "iPhone 15";
            modelList[3] = "Google Pixel 6";
            modelList[4] = "Samsung Galaxy S22";
            modelList[5] = "iPhone 14";
            int[] modelPrice = new int[6];          //Цены на модели
            modelPrice[0] = 1000;
            modelPrice[1] = 900;
            modelPrice[2] = 2500;
            modelPrice[3] = 1200;
            modelPrice[4] = 1900;
            modelPrice[5] = 1500;
            List<Sale> sales= new List<Sale>();
            Random rnd = new Random();
            int model;
            // Генерация данных за 30 дней
            for (int i = 0; i < 30; i++)
            {
                Sale sale = new Sale();
                sale.Date = DateTime.Today.AddDays(-i); // последние 30 дней
                // 5 продаж за день
                for (int j = 0; j < 5; j++)
                {
                    
                    model = rnd.Next(0, 6);        // случайная модель
                    sale.PhoneModel = modelList[model];
                    sale.Price = modelPrice[model];
                    sale.Quantity = rnd.Next(1, 6);    // 1–5 телефонов
                }
                sales.Add(sale);
            }
            DateTime start = new DateTime(2025, 10, 23);
            DateTime end = new DateTime(2025, 11, 10);
            Console.WriteLine("Общая сумма проданного за период: " + Functions.FindSalesPrice(sales, start, end));
            Functions.FindMostAndLeastSoldPhone(sales);
            Functions.FindTwoBestModel(sales);
        }
    }
}
