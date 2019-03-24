using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TestProject.Common.Core;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson11
{
    public class Task2 : IRunnable
    {
        public void Run()
        {
            List<Car> cars = new List<Car>()
            {
                new Car(123456, 15, 3),
                new Car(654321, 10, 1),
                new Car(456123, 5, 2)
            };
            CarStorage storage = new CarStorage(cars);

            JsonSerializer xs = new JsonSerializer();
            Logger.Write(xs.Serialize(storage, "Sereiled.json") + "\n");

            string deserialize = "";
            foreach (var car in xs.DeSerialize("Sereiled.json"))
            {
                deserialize += $"{car.CarId}: {car.Price} * {car.Quantity} = {car.Total}\n";
            }
            Logger.Write(deserialize);
        }
    }
}
