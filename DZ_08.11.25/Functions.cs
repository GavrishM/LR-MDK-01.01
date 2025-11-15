using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_08._11._25
{
    internal class Functions
    {
        static public Random rnd = new Random();
        static public string GenGameName() 
        {
            string result = "";
            string[,] gameNameRnd = new string[10, 4];
            {
                gameNameRnd[0, 0] = "Goose";
                gameNameRnd[1, 0] = "Heroes";
                gameNameRnd[2, 0] = "Fallout";
                gameNameRnd[3, 0] = "Skyrim";
                gameNameRnd[4, 0] = "Dying";
                gameNameRnd[5, 0] = "Escapist";
                gameNameRnd[6, 0] = "Castle";
                gameNameRnd[7, 0] = "Clone";
                gameNameRnd[8, 0] = "Kingdoms";
                gameNameRnd[9, 0] = "Forts";
                gameNameRnd[0, 1] = "Light";
                gameNameRnd[1, 1] = "Story";
                gameNameRnd[2, 1] = "Crashers";
                gameNameRnd[3, 1] = "Drone";
                gameNameRnd[6, 1] = "Duck";
                gameNameRnd[7, 1] = "Shelter";
                gameNameRnd[8, 1] = "Might";
                gameNameRnd[4, 1] = "Hydroner";
                gameNameRnd[5, 1] = "Stalker";
                gameNameRnd[9, 1] = "Terraria";
                gameNameRnd[0, 2] = "Danger";
                gameNameRnd[1, 2] = "Zone";
                gameNameRnd[2, 2] = "Magic";
                gameNameRnd[3, 2] = "Thrives";
                gameNameRnd[4, 2] = "Mechanic";
                gameNameRnd[5, 2] = "Potion";
                gameNameRnd[6, 2] = "Titans";
                gameNameRnd[7, 2] = "Corporation";
                gameNameRnd[8, 2] = "Istrolid";
                gameNameRnd[9, 2] = "Rock";
                gameNameRnd[0, 3] = "1";
                gameNameRnd[1, 3] = "2";
                gameNameRnd[2, 3] = "3";
                gameNameRnd[3, 3] = "4";
                gameNameRnd[4, 3] = "5";
                gameNameRnd[5, 3] = "6";
                gameNameRnd[6, 3] = "7";
                gameNameRnd[7, 3] = "8";
                gameNameRnd[8, 3] = "9";
                gameNameRnd[9, 3] = "10";
            }
            result = gameNameRnd[rnd.Next(0, 10), 0] + gameNameRnd[rnd.Next(0, 10), 1] + gameNameRnd[rnd.Next(0, 10), 2] + gameNameRnd[rnd.Next(0, 10), 3];

            return result;
        }
        static public Game[] Gen100Games() 
        {
            Game[] result = new Game[100];
            for(int i = 0; i < 100; i++)
            {
                result[i].Name = GenGameName();
                result[i].Downloads = rnd.Next(0, 10000000);
                result[i].Rates = rnd.Next(0, 10);
            }
            return  result;
        }
        static public Game[] SortGamesByDowloads(Game[] games)
        {
            Game[] result = new Game[100];
            for (int i = 0; i< 100; i++)
            {
                result[i] = games[i];
            }
            // Сортировка пузырьком по убыванию количества загрузок
            for (int i = 0; i < result.Length - 1; i++)
            {
                for (int j = 0; j < result.Length - 1 - i; j++)
                {
                    if (result[j].Downloads < result[j + 1].Downloads)
                    {
                        // Обмен элементов
                        Game temp = result[j];
                        result[j] = result[j + 1];
                        result[j + 1] = temp;
                    }
                }
            }
            return result;
        }
        static public void OutputTop10Games(Game[] games)
        {
            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine(games[i].Name + " " + games[i].Downloads + " " + games[i].Rates);
            }

        }
    }
}
