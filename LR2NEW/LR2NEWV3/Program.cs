using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2NEWV3
{
    class Program
    {
        static void Main()
        {
            //Вариант 3. Для салона красоты разрабатывается информационная подсистема учета клиентов.
            //По каждому клиенту имеются сведения об используемых услугах после каждого посещения.
            //По запросу пользователя – «название услуги» - вывести на экран список посетителей,
            //начиная с тех, кто наиболее часто пользуется данной услугой.
            //Подсчитайте среднее количество обращений по данной услуге.
            {
                Client client1 = new Client() { Name = "Ольга", Servises = new Dictionary<string, int>()};
                client1.Servises.Add("Маникюр", 3);





            }




        }
    }
}
