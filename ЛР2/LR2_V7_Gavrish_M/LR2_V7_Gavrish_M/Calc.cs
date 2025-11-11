using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2_V7_Gavrish_M
{
    public class Calc
    {
        public static Dictionary<string, List<double>> findProductsList(string UserQuery, Dictionary<string, Dictionary<string, List<double>>> categories)
        {
            Dictionary<string, List<double>> productList;
            productList = categories[UserQuery];
            return (productList);
        }
        public static Dictionary<string, double> findAveragePrice(Dictionary<string, List<double>> productList)
        {
            double aPrice = 0;
            Dictionary<string, double> products = new Dictionary<string, double>();
            foreach (var key in productList)
            {
                foreach (double doubles in key.Value)
                {
                    aPrice += doubles;
                }
                aPrice = (aPrice / key.Value.Count) * 100;
                int teh = Convert.ToInt32(aPrice);
                aPrice = Convert.ToDouble(teh) / 100;
                products.Add(key.Key, aPrice);
            }
            return (products);
        }
        public static List<string> sortList(Dictionary<string, double> list)
        {
            List<string> result = new List<string>();
            string[] keys = new string[list.Count];
            double[] values = new double[list.Count];
            int index = 0;
            foreach (var key in list)
            {
                keys[index] = key.Key;
                values[index] = key.Value;
                index++;
            }
            Array.Sort(values, keys); // Сортировка значений
            Array.Reverse(keys);      // Перевернем массивы чтобы получить сортировку по убыванию
            Array.Reverse(values);    // ^
            foreach (var key in keys)
            {
                result.Add(key);
            }
            return result;
        }





    }
}
