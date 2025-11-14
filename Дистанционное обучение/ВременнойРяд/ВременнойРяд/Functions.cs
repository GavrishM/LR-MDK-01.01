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
        static public int CalcSaleCount(Sale sale)
        {                                               // Цена купленных телефонов
            int salePrice = sale.Quantity * sale.Price;
            return salePrice;
        }
        static public int FindSalesPrice(List<Sale> sales, DateTime start, DateTime end)
        {
            int salesPrice = 0;
            foreach (Sale sale in sales)
            {
                if (sale.Date > start | sale.Date < end)
                {

                    salesPrice += Functions.CalcSaleCount(sale);

                }
            }
            return salesPrice;
        }
        static public void FindMostAndLeastSoldPhone(List<Sale> sales)
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
            
                foreach (Sale sale in sales)
                {
                    if (sale.PhoneModel == "iPhone 13") counter[0] += sale.Quantity;
                    if (sale.PhoneModel == "Samsung Galaxy S21") counter[1] += sale.Quantity;
                    if (sale.PhoneModel == "iPhone 15") counter[2] += sale.Quantity;
                    if (sale.PhoneModel == "Google Pixel 6") counter[3] += sale.Quantity;
                    if (sale.PhoneModel == "Samsung Galaxy S22") counter[4] += sale.Quantity;
                    if (sale.PhoneModel == "iPhone 14") counter[5] += sale.Quantity;
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
            if (max == counter[0]) mostSoldPhone = "iPhone 13";
            if (max == counter[1]) mostSoldPhone = "Samsung Galaxy S21";
            if (max == counter[2]) mostSoldPhone = "iPhone 15";
            if (max == counter[3]) mostSoldPhone = "Google Pixel 6";
            if (max == counter[4]) mostSoldPhone = "Samsung Galaxy S22";
            if (max == counter[5]) mostSoldPhone = "iPhone 14";
            if (min == counter[0]) leastSoldPhone = "iPhone 13";
            if (min == counter[1]) leastSoldPhone = "Samsung Galaxy S21";
            if (min == counter[2]) leastSoldPhone = "iPhone 15";
            if (min == counter[3]) leastSoldPhone = "Google Pixel 6";
            if (min == counter[4]) leastSoldPhone = "Samsung Galaxy S22";
            if (min == counter[5]) leastSoldPhone = "iPhone 14";
            Console.WriteLine("Самый продаваемый телефон: " + mostSoldPhone);
            Console.WriteLine("Телефон с наименьшим фактом продаж: " + leastSoldPhone);
        }
        static public int[] FindModelSalesPrice(List<Sale> sales)
        {
            int[] result = new int[6];
            

                foreach (Sale sale in sales)
                {
                    if (sale.PhoneModel == "iPhone 13") result[0] += Functions.CalcSaleCount(sale);
                    if (sale.PhoneModel == "Samsung Galaxy S21") result[1] += Functions.CalcSaleCount(sale);
                    if (sale.PhoneModel == "iPhone 15") result[2] += Functions.CalcSaleCount(sale);
                    if (sale.PhoneModel == "Google Pixel 6") result[3] += Functions.CalcSaleCount(sale);
                    if (sale.PhoneModel == "Samsung Galaxy S22") result[4] += Functions.CalcSaleCount(sale);
                    if (sale.PhoneModel == "iPhone 14") result[5] += Functions.CalcSaleCount(sale);

                }
            
            return result;
        }
        static public void FindTwoBestModel(List<Sale> sales)
        {
            string mostSoldPhone = "";
            string secondMostSoldPhone = "";
            int max1 = 0;
            int max2 = 0;
            int[] price = new int[6];
            price = FindModelSalesPrice(sales);
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
            Console.WriteLine("Два телефона, приносящие наибольшую прибыль: " + mostSoldPhone + ", " + secondMostSoldPhone);
        }
    }
}
