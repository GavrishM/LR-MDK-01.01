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
        static void Main(string[] args)
        {
            //1. Создать произвольный ПУСТОЙ словарь, где ключ - строка, а значение список строк.
            //2. Добавить 3 ключа со своими значениями.
            //3. 
            //4. 
            //5. 
            //6. 
            //7. 


            Dictionary<string, List<string>> Dict = new Dictionary<string, List<string>>();
            Dict.Add("one", new List<string>());
            Dict["one"].Add("one");
            Dict["one"].Add("two");
            Dict["one"].Add("tree");
            Dict["one"].Add("four");
            Dict.Add("two", new List<string>());
            Dict["two"].Add("one");
            Dict["two"].Add("two");
            Dict["two"].Add("tree");
            Dict["two"].Add("four");
            Dict.Add("three", new List<string>());
            Dict["three"].Add("one");
            Dict["three"].Add("two");
            Dict["three"].Add("tree");
            Dict["three"].Add("four");
        }
    }
}
