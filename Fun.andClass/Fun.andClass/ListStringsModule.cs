using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun.andClass
{
    class ListStringsModule
    {
        static public List<string> InputStringsList()
        { 
            List<string> outputList = new List<string>();
            
            bool isActive = true;
            while (isActive)
            {

                Console.WriteLine("Введите строку (0 для выхода с цикла)");
                string input = Console.ReadLine();

                if (input != "0")
                {
                    outputList.Add(input);
                }
                else
                {
                    isActive = false;
                }

            }

            return outputList;
        }





    }
}