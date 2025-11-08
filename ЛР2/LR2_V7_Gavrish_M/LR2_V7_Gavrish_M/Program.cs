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
        
       
        static void Main(string[] args)
        {
          //если здесь есть эта надпись, значит проект еще не доделан
        }
    }
}
