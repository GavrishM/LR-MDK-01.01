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
            
            List<Client> clients = new List<Client>
            {
                new Client()
                {
                    Name = "Ольга",
                    Services = new Dictionary<string, int>()
                    {
                        { "Маникюр", 3 },
                        { "Стрижка", 2 },
                        { "Окрашивание", 1 }
                    }
                },
                new Client()
                {
                    Name = "Анна",
                    Services = new Dictionary<string, int>()
                    {
                        { "Маникюр", 5 },
                        { "Педикюр", 2 },
                        { "Макияж", 1 }
                    }
                },
                new Client()
                {
                    Name = "Мария",
                    Services = new Dictionary<string, int>()
                    {
                        { "Стрижка", 4 },
                        { "Маникюр", 2 },
                        { "Окрашивание", 3 }
                    }
                },
                new Client()
                {
                    Name = "Елена",
                    Services = new Dictionary<string, int>()
                    {
                        { "Педикюр", 3 },
                        { "Маникюр", 1 },
                        { "Массаж", 2 }
                    }
                }
            };
            // Получаем запрос от пользователя
            string serviceName = Functions.Input();
            // Выполняем поиск и вывод результатов
            Functions.SortClientsByService(clients, serviceName);
        }
    }
}
