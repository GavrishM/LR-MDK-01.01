using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_array
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] tekst1 = new string[3];
            tekst1[0] = "тут был текст";
            tekst1[1] = "хомяк";
            tekst1[2] = "rat";
            tekst1[1] = "тут был хомяк";
            Console.WriteLine(tekst1[0]);
            Console.WriteLine(tekst1[1]);
            Console.WriteLine(tekst1[2]);
            string[] tekst2 = new string[3];
        }
    }
}
