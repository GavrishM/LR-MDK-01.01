using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2_V7_Gavrish_M
{
    internal class Program
    {
        static string inputUserQuery(Dictionary<string, Dictionary<string, List<double>>> categories)
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
                return (UserQuery);
        }
        static Dictionary<string, List<double>> findProductsList(string UserQuery, Dictionary<string, Dictionary<string, List<double>>> categories) 
        {
            Dictionary<string, List<double>> productList;
            productList = categories[UserQuery];
            return (productList);
        }
        static Dictionary<string, double> findAveragePrice(Dictionary<string, List<double>> productList)
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
        static List<string> sortList(Dictionary<string, double> list)
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
        static void outputList(List<string> list, Dictionary<string, double> price)
        {
            foreach (string item in list)
            {

                Console.WriteLine(item + " " + price[item]);
            }
        }
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<double>>> categories = new Dictionary<string, Dictionary<string, List<double>>>();
            categories.Add("крупы", new Dictionary<string, List<double>>());
            categories.Add("овощи", new Dictionary<string, List<double>>());
            categories.Add("фрукты", new Dictionary<string, List<double>>());
            categories["крупы"].Add("пшено", new List<double>());
            categories["крупы"].Add("рис", new List<double>());
            categories["крупы"].Add("овес", new List<double>());
            categories["овощи"].Add("морковь", new List<double>());
            categories["овощи"].Add("свекла", new List<double>());
            categories["овощи"].Add("репа", new List<double>());
            categories["фрукты"].Add("яблоко", new List<double>());
            categories["фрукты"].Add("груша", new List<double>());
            categories["фрукты"].Add("киви", new List<double>());
            categories["крупы"]["пшено"].Add(1);
            categories["крупы"]["пшено"].Add(4);
            categories["крупы"]["пшено"].Add(5);
            categories["крупы"]["рис"].Add(2);
            categories["крупы"]["рис"].Add(4);
            categories["крупы"]["рис"].Add(5);
            categories["крупы"]["овес"].Add(6);
            categories["крупы"]["овес"].Add(4);
            categories["крупы"]["овес"].Add(5);
            categories["овощи"]["морковь"].Add(1);
            categories["овощи"]["морковь"].Add(4);
            categories["овощи"]["морковь"].Add(5);
            categories["овощи"]["свекла"].Add(2);
            categories["овощи"]["свекла"].Add(4);
            categories["овощи"]["свекла"].Add(5);
            categories["овощи"]["репа"].Add(6);
            categories["овощи"]["репа"].Add(4);
            categories["овощи"]["репа"].Add(5);
            categories["фрукты"]["яблоко"].Add(1);
            categories["фрукты"]["яблоко"].Add(4);
            categories["фрукты"]["яблоко"].Add(5);
            categories["фрукты"]["груша"].Add(2);
            categories["фрукты"]["груша"].Add(4);
            categories["фрукты"]["груша"].Add(5);
            categories["фрукты"]["киви"].Add(6);
            categories["фрукты"]["киви"].Add(4);
            categories["фрукты"]["киви"].Add(5);

            outputList(sortList(findAveragePrice(findProductsList(inputUserQuery(categories), categories))),
                findAveragePrice(findProductsList(inputUserQuery(categories), categories)));

        }
    }
}
//Разнести функции по модулям. Добавить вывод средней цены в вывод