

using System;
using System.Collections.Generic;

namespace nsfconsole
{
    internal class Program
    {
        static void PrintModel(Car car)
        {
            Console.WriteLine(car.GetModel());
        }
        static void Main()
        {
            
            Car firstCar = new Car();
            firstCar.SetModel("Lada");
            firstCar.SetSpeed(150);
            PrintModel(firstCar);
            Car secondCar = new Car();
            secondCar.SetModel("Merc");
            secondCar.SetSpeed(300);
            PrintModel(secondCar);

            List<Car> cars = new List<Car>();
            cars.Add(firstCar);
            cars.Add(secondCar);



        }
    }
}
