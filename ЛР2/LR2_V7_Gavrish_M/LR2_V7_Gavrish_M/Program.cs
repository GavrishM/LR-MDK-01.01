using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2_V7_Gavrish_M
{
    internal class Program
    {
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
            
            Output.List(Calc.SortList(Calc.FindAveragePrice(Calc.FindProductsList(Input.UserQuery(categories), categories))));

        }
    }
}
//Разнести функции по модулям. Добавить вывод средней цены в вывод