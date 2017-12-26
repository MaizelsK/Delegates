using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DelegateLesson
{
    public delegate void CarHandler(string message);

    public class Game
    {
        private double raceRange;

        private List<Car> cars;

        private CarHandler handler;

        private event CarHandler Finish;

        public Game()
        {
            raceRange = 6000;

            handler += new CarHandler(Program.PrintMessage);
            Finish += new CarHandler(Program.PrintMessage);

            cars = new List<Car>();

            Car[] newCars =
            {
                new LightCar("Toyota", 25),
                new SportCar("Lamborghini", 40),
                new Truck("Kamaz", 16),
                new Bus("Маршрутка", 18)
            };

            cars.AddRange(newCars);
        }

        public void Start()
        {
            Console.WriteLine("В гонке учавствуют:\n");

            int oneKm = 1000, oneHour = 3600;
            foreach (var car in cars)
            {
                double kmPerHour = (car.Speed * oneHour) / oneKm;
                handler.Invoke($"-> {car.Model}, {kmPerHour} км/ч");
            }
            Console.ReadLine(); Console.Clear();

            Console.WriteLine("3...");
            Console.Beep(); Thread.Sleep(500);
            Console.WriteLine("2...");
            Console.Beep(); Thread.Sleep(500);
            Console.WriteLine("1...");
            Console.Beep(); Thread.Sleep(500);
            Console.WriteLine("Старт!!!"); Thread.Sleep(700);

            double onePointRange = 150;
            int completeRangePoints;

            bool raceIsEnd = false;
            while (!raceIsEnd)
            {
                Console.WriteLine("|Start\t\t\t\tFinish|");

                foreach (var car in cars)
                {
                    car.Ride();

                    if (car.Distance >= raceRange)
                    {
                        Console.Clear();

                        Finish($"{car.Model} пришел первым к финишу " +
                            $"и становится победителем!");
                        Console.ReadLine();

                        raceIsEnd = true;
                        break;
                    }

                    completeRangePoints = (int)(car.Distance / onePointRange);

                    Console.WriteLine(car.Model);
                    for (int i = 0; i < completeRangePoints; i++)
                        Console.Write("-");

                    Console.WriteLine("\n");
                }

                Thread.Sleep(20);
                Console.Clear();
            }
        }
    }
}
