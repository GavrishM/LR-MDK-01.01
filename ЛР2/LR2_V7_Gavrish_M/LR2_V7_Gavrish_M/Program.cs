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
        static Dictionary<string, int> findAveragePrice(Dictionary<string, List<int>> productList)
        {
            List<string> keys;
            string product = "";
            int aPrice = 0;
            Dictionary<string, int> products;
            for (int i = 0; i < productList.Count; i++) 
            {

                products.Add(product, aPrice);
            }

            return (products);
        }
        
       
        static void Main(string[] args)
        {
          //если здесь есть эта надпись, значит проект еще не доделан
        }
    }
}
