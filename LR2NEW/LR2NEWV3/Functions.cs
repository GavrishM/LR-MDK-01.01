using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2NEWV3
{
    class Functions
    {
        static public string Input(List<Servise> servises) 
        {
            Console.WriteLine("Введите название услуги:");
            string result = Console.ReadLine();
            return result;
        }
    }
}
