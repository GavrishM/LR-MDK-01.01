using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2_V7_Gavrish_M
{
    public class Calc
    {
        public static Dictionary<string, List<double>> FindProductsList(string UserQuery, Dictionary<string, Dictionary<string, List<double>>> categories)
        {
            Dictionary<string, List<double>> productList;
            productList = categories[UserQuery];
            return (productList);
        }
        public static Dictionary<string, double> FindAveragePrice(Dictionary<string, List<double>> productList)
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
        public static Dictionary<string, double> SortList(Dictionary<string, double> list)
        {
            var keys = list.Keys.ToArray();
            var values = list.Values.ToArray();

            Array.Sort(values, keys);
            Array.Reverse(keys);
            Array.Reverse(values);

            Dictionary<string, double> result = new Dictionary<string, double>();
            for (int i = 0; i < keys.Length; i++)
            {
                result.Add(keys[i], values[i]);
            }
            return result;
        }





    }
}
