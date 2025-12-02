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
    }
}
