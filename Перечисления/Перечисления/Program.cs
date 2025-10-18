using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Перечисления
{
    class Program
    {
        enum Month
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }
        enum Week
        { 
        Monday = 1,
        Tuesday,
        Wednesday,
        Friday,
        Saturday,
        Sunday
        }
        enum Colors
        { 
        Red,
        Green,
        Blue
        }
        static void Main(string[] args)
        {
            Console.WriteLine("012");
            int color = Convert.ToInt32(Console.ReadLine());
            switch (color)
            {
                case (0):
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(Colors.Red);
                    break;
                case (1):
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(Colors.Green);
                    break;
                case (2):
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(Colors.Blue);
                    break;

            }
            Console.ForegroundColor= ConsoleColor.White;
        }
    }
}

