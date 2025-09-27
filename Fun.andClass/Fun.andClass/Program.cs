using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun.andClass
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              1. Добавить новый файл cs ListStringsModule
              2. ОПРЕДЕЛИТЬ функцию заполнения списка строк данными, вводимыми пользователями с клавиатуры
              3. Реализация функции
              4. Вызов реализованной функции с целью получить данные  
              5. Вывести последний элемент списка на экран и размер списка
              6.
             */
            List<string>  userList = ListStringsModule.InputStringsList();
            Console.WriteLine("Последний элемент списка: \n" + userList[userList.Count - 1]);
            Console.WriteLine("Размер списка = " + userList.Count);
        }
    }
}
