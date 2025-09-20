using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> initText = new List<string>();
            initText.Add("земля");
            initText.Add("воздух");
            initText.Add("вода");
            initText.Add("Т5");
            initText.Add("свет");
            Console.WriteLine("Введите текст");
            string text = Console.ReadLine();
            Console.WriteLine("Текст "+text);
            List<string> inputText = new List<string>();
            for(int i = 0; i < initText.Count; i++)
            {

                if (initText[i].Contains(text))
                {
                    inputText.Add(initText[i]);  
                }
                
            }
            for (int i = 0; i < inputText.Count; i++)
            {
                Console.WriteLine(inputText[i]);
            }
            
            











        }
    }
}
//
//
//
//
//
//
//
//
//
//                    /\
//                   //\\
//                  //  \\
//                 //    \\
//                //\    /\\
//               //  \  /  \\
//              //    \/    \\
//             //\    /\    /\\
//            //  \  /  \  /  \\
//           //    \/    \/    \\
//          //\    /\    /\    /\\
//         //  \  /  \  /  \  /  \\
//        //    \/    \/    \/    \\
//       //\    /\    /\    /\    /\\
//      //  \  /  \  /  \  /  \  /  \\
//     //    \/    \/    \/    \/    \\