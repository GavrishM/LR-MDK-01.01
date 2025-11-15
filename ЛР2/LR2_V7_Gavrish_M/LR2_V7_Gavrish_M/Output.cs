using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2_V7_Gavrish_M
{
    public class Output
    {
        public static void List(Dictionary<string, double> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
