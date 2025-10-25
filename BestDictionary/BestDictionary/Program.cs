using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestDictionary
{
    class Program
    {
        static int Keyscount(Dictionary<string, List<string>> Dict)
        {
            Console.WriteLine("");
            string input = Console.ReadLine();
            int output = Dict[input].Count;
            return output;
        }
        static void Main(string[] args)
        {
            //1. Создать произвольный ПУСТОЙ словарь, где ключ - строка, а значение список строк.
            //2. Добавить 3 ключа со своими значениями.
            //3. Вывести на экран все ключи словаря.
            //4. Вывести на экран значение через ", " по ключу X (любому).
            //5. Реализуем функцию: запрос ключа пользователем. По запросу выводит число элементов значения указанного ключа.
            //6. 
            //7. 


            Dictionary<string, List<string>> Dict = new Dictionary<string, List<string>>();
            Dict.Add("colors", new List<string>() {"red", "green", "blue"});
            Dict.Add("birds", new List<string>() { "crow", "parrot"});
            Dict.Add("locations", new List<string>() { "orange_forest"});
            string keys = string.Join(",", Dict.Keys);
            Console.WriteLine(keys);
            string X = "colors";
            Console.WriteLine(string.Join(", ", Dict[X]));
            Console.WriteLine(Keyscount(Dict));

        }
    }
}
