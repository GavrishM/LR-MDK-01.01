using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2_V7_Gavrish_M
{
    internal class Program
    {
        static string inputUserQuery(Dictionary<string, Dictionary<string, List<int>>> categories)
        {
            string UserQuery = "";
            bool chek = true;
            while (chek)
            {
                Console.WriteLine("Введи название категории");
                UserQuery = Console.ReadLine().ToLower();
                if (categories.ContainsKey(UserQuery))
                {
                    chek = false;
                }
                else
                {
                    Console.WriteLine("Неправильно. Попробуй еще раз.");
                }
            }
            return(UserQuery);
        }
        static Dictionary<string, List<int>> findProductsList(string UserQuery, Dictionary<string, Dictionary<string, List<int>>> categories) 
        {
            Dictionary<string, List<int>> productList;
            productList = categories[UserQuery];
            return (productList);
        }
        static Dictionary<string, double> findAveragePrice(Dictionary<string, List<int>> productList)
        {
            double aPrice = 0;
            Dictionary<string, double> products = new Dictionary<string, double>();
            foreach (var key in productList)
            {
                foreach (var ints in key.Value)
                {
                    aPrice += ints;
                }
                aPrice = aPrice / key.Value.Count;
                    products.Add(key.Key, aPrice);
            }
            return (products);
        }
        static List<string> sortList(Dictionary<string, double> list)
        {
            List<string> result = new List<string>();
            string[] keys = new string[list.Count];
            double[] values = new double[list.Count];
            int index = 0;
            foreach (var kvp in list)
            {
                keys[index] = kvp.Key;
                values[index] = kvp.Value;
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
        static void outputList(List<string> list)
        {
            foreach (var item in list)
            { 
            Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
          //если здесь есть эта надпись, значит проект еще не доделан
        }
    }
}
