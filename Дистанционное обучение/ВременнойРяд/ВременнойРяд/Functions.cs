using System;
using System.Collections;
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
            foreach (Day day in days)
            {
                if (day.Date > start | day.Date < end)
                {
                    foreach (Sale sale in day.SaleList)
                    {
                        salesPrice += Sale.SalePrice(sale);
                    }
                }
            }
            return salesPrice;
        }
        static public void FindMostAndLeastSoldPhone(List<Day> days)
        {
            string mostSoldPhone = "";
            string leastSoldPhone = "";
            int max = 0;
            int min = 1000;
            int[] counter = new int[6];
            counter[0] = 0;
            counter[1] = 0;
            counter[2] = 0;
            counter[3] = 0;
            counter[4] = 0;
            counter[5] = 0;
            foreach (Day day in days)
            {
                foreach (Sale sale in day.SaleList)
                {
                    if (sale.PhoneModel == "iPhone 13") counter[0] += sale.Quantity;
                    if (sale.PhoneModel == "Samsung Galaxy S21") counter[1] += sale.Quantity;
                    if (sale.PhoneModel == "iPhone 15") counter[2] += sale.Quantity;
                    if (sale.PhoneModel == "Google Pixel 6") counter[3] += sale.Quantity;
                    if (sale.PhoneModel == "Samsung Galaxy S22") counter[4] += sale.Quantity;
                    if (sale.PhoneModel == "iPhone 14") counter[5] += sale.Quantity;
                }
            }
            for (int i = 0; i < 6; i++)
            {
                if (counter[i] < min)
                {
                    min = counter[i];
                }
                if (counter[i] > max)
                {
                    max = counter[i];
                }
            }
            switch (max)
            {
                case 0:
                    {
                        mostSoldPhone = "iPhone 13";
                        break;
                    }
                case 1:
                    {
                        mostSoldPhone = "Samsung Galaxy S21";
                        break;
                    }
                case 2:
                    {
                        mostSoldPhone = "iPhone 15";
                        break;
                    }
                case 3:
                    {
                        mostSoldPhone = "Google Pixel 6";
                        break;
                    }
                case 4:
                    {
                        mostSoldPhone = "Samsung Galaxy S22";
                        break;
                    }
                case 5:
                    {
                        mostSoldPhone = "iPhone 14";
                        break;
                    }
            }
            switch (min)
            {
                case 0:
                    {
                        leastSoldPhone = "iPhone 13";
                        break;
                    }
                case 1:
                    {
                        leastSoldPhone = "Samsung Galaxy S21";
                        break;
                    }
                case 2:
                    {
                        leastSoldPhone = "iPhone 15";
                        break;
                    }
                case 3:
                    {
                        leastSoldPhone = "Google Pixel 6";
                        break;
                    }
                case 4:
                    {
                        leastSoldPhone = "Samsung Galaxy S22";
                        break;
                    }
                case 5:
                    {
                        leastSoldPhone = "iPhone 14";
                        break;
                    }
            }
            Console.WriteLine("Самый продоваемый телефон: " + mostSoldPhone);
            Console.WriteLine("Телефон с наименьшим фактом продаж: " + leastSoldPhone);
        }
        static public int[] FindModelSalesPrice(List<Day> days)
        {
            int[] result = new int[6];
            foreach (Day day in days)
            {

                foreach (Sale sale in day.SaleList)
                {
                    if (sale.PhoneModel == "iPhone 13") result[0] += Sale.SalePrice(sale);
                    if (sale.PhoneModel == "Samsung Galaxy S21") result[1] += Sale.SalePrice(sale);
                    if (sale.PhoneModel == "iPhone 15") result[2] += Sale.SalePrice(sale);
                    if (sale.PhoneModel == "Google Pixel 6") result[3] += Sale.SalePrice(sale);
                    if (sale.PhoneModel == "Samsung Galaxy S22") result[4] += Sale.SalePrice(sale);
                    if (sale.PhoneModel == "iPhone 14") result[5] += Sale.SalePrice(sale);

                }
            }
            return result;
        }
        static public void FindTwoBestModel(List<Day> days)
        {
            string mostSoldPhone = "";
            string secondMostSoldPhone = "";
            int max1 = 0;
            int max2 = 0;
            int[] price = new int[6];
            price = FindModelSalesPrice(days);
            for (int i = 0; i < 6; i++)
            {
                if (price[i] > max1)
                {
                    max1 = price[i];
                }
                if (price[i] > max2)
                {
                    if (price[i] < max1)
                    {
                        max2 = price[i];
                    }
                }
                if (max1 == price[0]) mostSoldPhone = "iPhone 13";
                if (max1 == price[1]) mostSoldPhone = "Samsung Galaxy S21";
                if (max1 == price[2]) mostSoldPhone = "iPhone 15";
                if (max1 == price[3]) mostSoldPhone = "Google Pixel 6";
                if (max1 == price[4]) mostSoldPhone = "Samsung Galaxy S22";
                if (max1 == price[5]) mostSoldPhone = "iPhone 14";
                if (max2 == price[0]) secondMostSoldPhone = "iPhone 13";
                if (max2 == price[1]) secondMostSoldPhone = "Samsung Galaxy S21";
                if (max2 == price[2]) secondMostSoldPhone = "iPhone 15";
                if (max2 == price[3]) secondMostSoldPhone = "Google Pixel 6";
                if (max2 == price[4]) secondMostSoldPhone = "Samsung Galaxy S22";
                if (max2 == price[5]) secondMostSoldPhone = "iPhone 14";
            }
            Console.WriteLine("Два телефона, приносящие наибольшую прибыль:" + mostSoldPhone + ", " + secondMostSoldPhone);
        }
    }
}
