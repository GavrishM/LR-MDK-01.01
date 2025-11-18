using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2NEWV3
{
    class Functions
    {
        static public string Input() 
        {
            Console.WriteLine("Введите название услуги:");
            string result = Console.ReadLine();
            return result;
        }

        static public void FindClientsByService(List<Client> clients, string serviceName)
        {
            // Фильтруем клиентов, у которых есть данная услуга
            List<Client> clientsWithService = new List<Client>();
            clientsWithService = clients
                .Where(client => client.Services.ContainsKey(serviceName))
                .OrderByDescending(client => client.Services[serviceName])
                .ToList();

            if (clientsWithService.Count == 0)
            {
                Console.WriteLine("Услуга " + serviceName + " не найдена ни у одного клиента.");
                return;
            }

            // Выводим заголовок
            Console.WriteLine("Клиенты, пользующиеся услугой " + serviceName + ":");
            Console.WriteLine("=============================================");

            // Выводим клиентов в порядке убывания количества использований услуги
            foreach (Client client in clientsWithService)
            {
                int usageCount = client.Services[serviceName];
                Console.WriteLine(client.Name + " - использована " + usageCount + " раз(а)");
            }

            // Подсчитываем среднее количество обращений
            double averageUsage = clientsWithService.Average(client => client.Services[serviceName]);
            Console.WriteLine($"\nСреднее количество обращений по услуге: {averageUsage:F2}");

        }

    }

}
