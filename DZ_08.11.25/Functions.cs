using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_08._11._25
{
    internal class Functions
    {
        static public string GenGameName() 
        {
            string result = "";
            Random rnd = new Random();
            string[,] gameNameRnd = new string[10, 4];
            {
                gameNameRnd[0, 0] = "";
                gameNameRnd[1, 0] = "";
                gameNameRnd[2, 0] = "";
                gameNameRnd[3, 0] = "";
                gameNameRnd[4, 0] = "";
                gameNameRnd[5, 0] = "";
                gameNameRnd[6, 0] = "";
                gameNameRnd[7, 0] = "";
                gameNameRnd[8, 0] = "";
                gameNameRnd[9, 0] = "";
                gameNameRnd[0, 1] = "";
                gameNameRnd[1, 1] = "";
                gameNameRnd[2, 1] = "";
                gameNameRnd[3, 1] = "";
                gameNameRnd[6, 1] = "";
                gameNameRnd[7, 1] = "";
                gameNameRnd[8, 1] = "";
                gameNameRnd[4, 1] = "";
                gameNameRnd[5, 1] = "";
                gameNameRnd[9, 1] = "";
                gameNameRnd[0, 2] = "";
                gameNameRnd[1, 2] = "";
                gameNameRnd[2, 2] = "";
                gameNameRnd[3, 2] = "";
                gameNameRnd[4, 2] = "";
                gameNameRnd[5, 2] = "";
                gameNameRnd[6, 2] = "";
                gameNameRnd[7, 2] = "";
                gameNameRnd[8, 2] = "";
                gameNameRnd[9, 2] = "";
                gameNameRnd[0, 3] = "";
                gameNameRnd[1, 3] = "";
                gameNameRnd[2, 3] = "";
                gameNameRnd[3, 3] = "";
                gameNameRnd[4, 3] = "";
                gameNameRnd[5, 3] = "";
                gameNameRnd[6, 3] = "";
                gameNameRnd[7, 3] = "";
                gameNameRnd[8, 3] = "";
                gameNameRnd[9, 3] = "";
            }
            result = gameNameRnd[rnd.Next(0, 10), 0] + gameNameRnd[rnd.Next(0, 10), 1] + gameNameRnd[rnd.Next(0, 10), 2] + gameNameRnd[rnd.Next(0, 10), 3];

            return result;
        }
        static public Game[] Gen100Games() 
        {
            Game[] result = new Game[100];
            for(int i = 0; i < result count)
            
            
            
            return  result[];
        }

    }
}
