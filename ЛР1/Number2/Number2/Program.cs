using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number2
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int[] ints = new int[5000];
            List<int> largeInts = new List<int>();

            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = rnd.Next(-1000, 1001);
            }

            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] > 900)
                {
                    largeInts.Add(ints[i]);
                }
            }

            Console.WriteLine("Числа больше 900:");
            Console.Write("[");
            for (int i = 0; i < largeInts.Count - 1; i++)
            {
                Console.Write(largeInts[i] + ", ");
            }
            Console.Write(largeInts[largeInts.Count - 1] + "]");

        }
    }
}
