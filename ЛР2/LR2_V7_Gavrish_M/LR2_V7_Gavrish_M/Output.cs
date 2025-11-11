using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2_V7_Gavrish_M
{
    public class Output
    {
        public static void outputList(List<string> list, Dictionary<string, double> price)
        {
            foreach (string item in list)
            {

                Console.WriteLine(item + " " + price[item]);
            }
        }
    }
}
