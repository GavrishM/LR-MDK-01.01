using Massive_array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassiveArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Array2d array = new Array2d();
            array.SetHeigth(3);
            array.SetWidth(3);
            array.InitializeArray();
            array.SetArrayCell(2, 2, 9);
            array.SetArrayColumn(1);
            array.SetArrayRow(0);
            Console.WriteLine(array.GetArrayCell(2, 2));
            int[] ints1 = new int[3];
            int[] ints2 = new int[3];
            int[,] ints3 = new int[3, 3];
            ints1 = array.GetArrayColumn(1);
            ints2 = array.GetArrayRow(0);
            ints3 = array.GetArray();
            Console.WriteLine();
            for (int i = 0 ; i < ints1.Length ; i++) 
            {
                Console.Write(ints1[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < ints2.Length; i++)
            {
                Console.WriteLine(ints2[i]);
            }
            Console.WriteLine();
            for(int h = 0; h < array.GetHeigth(); h++)  
            {
                for(int w = 0; w < array.GetWidth(); w++) 
                {
                    Console.Write(ints3[w, h] + " ");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
