﻿using System;
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
        static void Main(string[] args)
        {
          
        }
    }
}
