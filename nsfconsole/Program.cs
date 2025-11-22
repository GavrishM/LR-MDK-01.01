

using System;
using System.Collections.Generic;
using System.Threading;

namespace nsfconsole
{
    internal class Program
    {
        static void PrintModel(Car car)
        {
            Console.WriteLine(car.GetModel());
        }
        static Car FindFastestCar(List<Car> cars)
        {
            Car fastestCar = new Car();
            int maxSpeed = 0;
            for (int i = 0; i< cars.Count;i++)
            {
                if (cars[i].GetSpeed()> maxSpeed)
                {
                    fastestCar = cars[i];
                    maxSpeed = cars[i].GetSpeed();
                }
            }


            return fastestCar;
        }
        static void StartRace(List<Car> cars)
        {
            int t = 0;
            while (t < 7)
            {
                Console.WriteLine("============================================================================================================================================================================================");
                foreach (Car car in cars)
                {
                    int move = (car.GetSpeed() / 50 * t);
                    for (int i = 1; i < move; i++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine(car.GetModel());
                    Console.WriteLine("============================================================================================================================================================================================");
                }
                t++;
                Thread.Sleep(500);
                Console.Clear();
            }
           
           
               
        }
        static void Main()
        {
            
            Car firstCar = new Car();
            firstCar.SetModel("Lada");
            firstCar.SetSpeed(150);
            //PrintModel(firstCar);
            Car secondCar = new Car();
            secondCar.SetModel("Merc");
            secondCar.SetSpeed(1500);
            //PrintModel(secondCar);
            List<Car> cars = new List<Car>();
            cars.Add(firstCar);
            cars.Add(secondCar);
            Random rnd = new Random();
            List<string> models = new List<string>();
            
            for(int i=0;i<3;i++)
            {
                Car car = new Car();
                car.SetModel("Car"+rnd.Next(100, 1000));
                car.SetSpeed(rnd.Next(50, 3000));
                cars.Add(car);
            }
            
            StartRace(cars);
            Console.WriteLine("Победителем стал - " + FindFastestCar(cars).GetModel());

        }
    }
}
