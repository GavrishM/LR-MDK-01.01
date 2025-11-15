using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_08._11._25
{
    class Program
    {
        static void Main(string[] args)
        {
            Functions.OutputTop10Games(Functions.SortGamesByDowloads(Functions.Gen100Games()));
        }
    }
}
