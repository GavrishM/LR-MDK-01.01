using System;
using System.Collections.Concurrent;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace _031225
{
    class Program
    {
        //Категория 1: Наследование, полиморффизм и абстракции
        //
        //Задача 1.1: «Гибкая система ролей в учетной системе»  
        //Создайте систему классов для управления сотрудниками компании с разными формами оплаты труда и ролями в системе.
        //Реализуйте абстрактный класс `Employee` с полями `Id`,
        //`FullName`, `Email` и абстрактным методом `CalculateSalary()`.
        //Создайте производные классы:
        //`FixedSalaryEmployee` (фиксированная месячная оплата).
        //`HourlySalaryEmployee` (почасовая оплата + сверхурочные).
        //`FreelancerEmployee` (оплата за проект + ставка НДФЛ).
        //Каждый тип сотрудника должен по-своему рассчитывать зарплату.
        //Доп.сложность:   Добавьте интерфейс `ISystemAccess` с методами `Login()`,
        //`Logout()`, `HasAccessToModule(string moduleName)`.
        //Реализуйте его в разных классах-ролях(например, `ManagerRole`, `AccountantRole`, `DeveloperRole`),
        //которые будут композироваться(has-a relationship) в класс `Employee`.
        //Это демонстрирует принцип предпочтения композиции над наследованием.
        //
        //Задача 1.2: «Расчет площади фигур без знания их типа»  
        //Реализуйте паттерн   «Посетитель» (Visitor)  .
        //Создайте интерфейс `IShape` с методом `Accept(IVisitor visitor)`.
        //Создайте классы фигур: `Circle`, `Rectangle`, `Triangle`.
        //Создайте интерфейс `IVisitor` с методами `Visit(Circle circle)`, `Visit(Rectangle rectangle)` и т.д.
        //Реализуйте два конкретных посетителя: `AreaCalculator`
        //(для расчета площади) и `PerimeterCalculator` (для расчета периметра).
        //Клиентский код должен работать со списком `List<IShape>`, применяя к нему разных посетителей.
        //
        //Категория 2: Паттерны проектирования и архитектура
        //
        //Задача 2.1: «Кэширующий прокси для работы с удаленным API»  
        //Симулируйте работу с внешним HTTP-API (например, погода или курсы валют).
        //Создайте интерфейс `IDataService` с методом `string FetchData(string resourceId)`.
        //Реализуйте класс `RemoteApiService`, который имитирует долгий сетевой запрос (используйте `Thread.Sleep`).
        //Реализуйте класс `CachingProxyService`, реализующий `IDataService`. 
        //Он должен:
        //Хранить полученные данные в словаре (`Dictionary<string, (string data, DateTime expiry)>`).
        //Возвращать данные из кэша, если они «свежие» (не старше N минут).
        //Если данных нет или они устарели — делегировать запрос реальному `RemoteApiService` и обновлять кэш.
        //Продемонстрируйте разницу в скорости при повторных запросах.
        //
        //Задача 2.2: «Система обработки заказов с цепочкой обязанностей»  
        //Создайте систему валидации и обработки заказа (`Order`)
        //с использованием паттерна «Цепочка обязанностей» (Chain of Responsibility).
        //Заказ содержит поля: `TotalAmount`, `Weight`, `DestinationCountry`, `PaymentMethod`.
        //Создайте абстрактный класс `OrderHandler` с полем `Successor`
        //(следующий обработчик) и методом `Handle(Order order)`.
        //Реализуйте конкретные обработчики:
        //`StockValidationHandler` (проверяет наличие товаров на складе).
        //`FraudDetectionHandler` (проверяет подозрительно крупные суммы).
        //`ShippingCostCalculatorHandler` (рассчитывает стоимость доставки в зависимости от веса и страны).
        //`PaymentProcessingHandler` (имитирует выбор способа оплаты).
        //Клиентский код должен построить цепочку и передать заказ по ней. 
        //Если какой-то обработчик обнаруживает критическую ошибку, обработка прерывается.
        //
        //Категория 3: Работа с файлами, сериализация и события  
        //
        //Задача 3.1: «Наблюдатель за изменением файлового каталога»  
        //Реализуйте систему мониторинга папки с использованием паттерна
        //«Наблюдатель» (Observer) и класса `FileSystemWatcher`.
        //Создайте класс `DirectoryMonitor` (Subject),
        //который инкапсулирует `FileSystemWatcher`.
        //Создайте интерфейс `IFileChangeListener`
        //с методом `OnFileChanged(string filePath, WatcherChangeTypes changeType)`.
        //Реализуйте несколько слушателей:
        //`LoggingListener`: записывает все события в текстовый лог-файл.
        //`IndexingListener`: обновляет in-memory индекс(простой `Dictionary`) имен файлов.
        //`BackupListener`: копирует измененный файл в папку `Backup` при его изменении.
        //`DirectoryMonitor` должен уметь добавлять,
        //удалять и уведомлять слушателей при событиях от `FileSystemWatcher`.
        //
        //Задача 3.2: «Универсальный конфигурационный менеджер с поддержкой разных форматов»  
        //Создайте класс `ConfigurationManager`, который может загружать и сохранять настройки в разных форматах.
        //Определите класс `AppConfig` с набором свойств (например, `AppName`, `Version`, `ConnectionString`, `Timeout`).
        //Создайте интерфейс `IConfigurationProvider` с методами `AppConfig Load()` и `void Save(AppConfig config)`.
        //Реализуйте конкретных провайдеров:
        //`JsonConfigurationProvider` (использует `System.Text.Json`).
        //`XmlConfigurationProvider` (использует `System.Xml.Serialization`).
        //`IniConfigurationProvider` (пишет собственный простой парсер для формата `Key=Value`).
        //Класс `ConfigurationManager` должен принимать провайдер в конструкторе(принцип Dependency Injection) и делегировать ему работу.
        //Добавьте статическое свойство `Instance` (реализация Singleton),
        //но обсудите в комментариях потенциальные проблемы такого подхода.
        //
        //Категория 4: LINQ и продвинутые структуры данных
        //
        //Задача 4.1: «Анализ лог-файла веб-сервера»  
        //Напишите программу для анализа смоделированного лог-файла.
        //Создайте класс `LogEntry` с полями: `IPAddress`,
        //`RequestTime`, `HttpMethod`, `Url`, `StatusCode`, `ResponseSize`.
        //Сгенерируйте или загрузите из файла коллекцию из 10 000+ записей.
        //Используя LINQ, выполните следующие аналитические запросы:
        //1.Топ-5 IP-адресов, с которых было больше всего запросов.
        //2.Количество ошибок (статус 5xx) в час за последние 24 часа.
        //3.Самые популярные ресурсы(URL) за день.
        //4.Общий трафик, сгенерированный каждым HTTP-методом (GET, POST).
        //5.Поиск подозрительной активности: IP-адреса,
        //которые за короткий промежуток времени (10 мин) получили много(например, >100) ошибок 4xx(возможная попытка сканирования).
        //Доп.сложность: Реализуйте кеширование результатов тяжелых агрегаций с использованием `MemoryCache`.
        //
        //Категория 5: Многопоточность и асинхронность(введение)
        //
        //Задача 5.1: «Параллельная обработка изображений с ограничением потоков»  
        //Симулируйте ресурсоемкую обработку изображений(например, применение фильтра).
        //Создайте класс `ImageProcessor` с методом `Process(string imagePath)`, который имитирует работу(`Task.Delay`).
        //На вход подается список из 100 путей к файлам.
        //Реализуйте два способа обработки:
        //1.Последовательная(в цикле).
        //2.Параллельная с использованием `SemaphoreSlim`,
        //который ограничивает количество одновременно обрабатываемых изображений(например, не более 4-х).
        //Используйте `async/await` и `Task.WhenAll`.
        //Замерьте и сравните время выполнения обоих способов.Выведите сводку по каждому обработанному файлу.
        //Задача 5.2: «Потокобезопасный кэш с уведомлениями»  
        //Реализуйте класс `ThreadSafeCache<TKey, TValue>`.
        //Внутри используйте `ConcurrentDictionary`.
        //Реализуйте методы: `AddOrUpdate`, `TryGet`, `Remove`.
        //Добавьте механизм событий (event): `OnItemAdded`, `OnItemUpdated`,
        //`OnItemRemoved`. Подписчики на события должны получать ключ и значение.
        //Важно: Обеспечьте потокобезопасность не только словаря,
        //но и процесса вызова событий (проблема гонки между проверкой и вызовом).
        //Продемонстрируйте работу кэша из нескольких потоков.
        //
        //
        //
        static void Main(string[] args)
        {
            FixedSalaryEmployee employee1 = new FixedSalaryEmployee();
            {
                employee1.SalaryMounth = 30000;
                employee1.Mounth = 2;
                employee1.FullName = "Test";
                employee1.Email = "tseT";
                employee1.Id = 1;
                Console.WriteLine(employee1.Id + " " + employee1.FullName + " " + employee1.Email + " " + employee1.CalculateSalary());
            }
            HourlySalaryEmployee employee2 = new HourlySalaryEmployee();
            {
                employee2.SalaryHour = 1000;
                employee2.Hours = 240;
                employee2.Overtime = 10;
                employee2.FullName = "Oleg";
                employee2.Email = "oleg";
                employee2.Id = 2;
                Console.WriteLine(employee2.Id + " " + employee2.FullName + " " + employee2.Email + " " + employee2.CalculateSalary());
            }
            FreelancerEmployee employee3 = new FreelancerEmployee();
            {
                employee3.SalaryProject = 50000;
                employee3.NDFL = 0.13;
                employee3.FullName = "Igor";
                employee3.Email = "rogI";
                employee3.Id = 3;
                Console.WriteLine(employee3.Id + " " + employee3.FullName + " " + employee3.Email + " " + employee3.CalculateSalary());
            }

        }
    }
}
