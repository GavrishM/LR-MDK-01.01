using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number1
{
    class Program
    {
        static void Main(string[] args)
        {               //Вариант 4

            string input;
            int massiveSive;
            int multiplication = 1;
            bool isNumber = false;

            Console.WriteLine("Введите размер массива");
            input = Console.ReadLine();
            massiveSive = Convert.ToInt32(input);

            int[] ints = new int[massiveSive];
            for (int i = 0; i < ints.Length; i++)
            {
                Console.WriteLine("Введите число " + (i + 1));
                input = Console.ReadLine();
                ints[i] = Convert.ToInt32(input);
            }

            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] < 0)
                {
                    multiplication = multiplication * ints[i];
                }
            }

            Console.WriteLine("Произведение отрицательных элементов массива = " + multiplication);


        }
    }
}
