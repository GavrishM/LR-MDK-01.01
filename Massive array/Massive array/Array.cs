using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massive_array
{
    public class Array
    {
        private int Heigth_;
        private int Width_;
        private int[,] Array_;

        public void SetHeigth(int heigth)
        {
            Heigth_ = heigth;
        }
        public void SetWidth(int width)
        {
            Width_ = width;
        }
        public void InitializeArray()
        {
            Array_ = new int[Width_, Heigth_];
        }

        public int GetHeigth()
        {
            return Heigth_;
        }
        public int GetWidth()
        {
            return Width_;
        }

        public void SetArrayCell(int w, int h, int value)
        {
            if (w < Width_ && h < Heigth_)
            {
                Array_[w, h] = value;
            }
            else Console.WriteLine("Ячейка не найдена");
        }
        public void SetArrayRow(int h)
        {
            if (h < Heigth_)
            {
                for (int i = 0; i < Heigth_; i++)
                {
                    Console.WriteLine("Введите значение:");
                    Array_[i, h] = Convert.ToInt32(Console.ReadLine());
                }
            }
            else Console.WriteLine("Строка не найдена");
        }
        public void SetArrayColumn(int w)
        {
            if (w < Width_)
            {
                for (int i = 0; i < Width_; i++)
                {
                    Console.WriteLine("Введите значение:");
                    Array_[w, i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            else Console.WriteLine("Столбец не найден");

        }

        public int GetArrayCell(int w, int h, int value)
        {
            if (w < Width_ && h < Heigth_)
            {
                return Array_[w, h];
            }
            else
            {
                Console.WriteLine("Ячейка не найдена");
                return 0;            
            }
        }
        public int[] GetArrayRow(int h)
        {
            int[] result = new int[Width_];
            if (h < Heigth_)
            {
                for (int i = 0; i < Heigth_; i++)
                {
                    result[i] = Array_[i, h];
                }
            }
            else Console.WriteLine("Строка не найдена");
            return result;
        }
        public int[] GetArrayColumn(int w)
        {
            int[] result = new int[Heigth_];

            if (w < Width_)
            {
                for (int i = 0; i < Heigth_; i++)
                {
                    result[i] = Array_[w, i];
                }
            }
            else Console.WriteLine("Столбец не найден");
            return result;
        }
        public int[,] GetArray()
        {
            return Array_;
        }
    }
}
