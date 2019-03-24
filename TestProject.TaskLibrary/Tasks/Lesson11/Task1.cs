using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TestProject.Common.Core;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson11
{
    public class Task1 : IRunnable
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

            XMLSerializer xs = new XMLSerializer();
            Logger.Write($"{xs.Serialize(storage, "Sereiled.xml")}\n");

            string deserialize = "";
            foreach (var car in xs.DeSerialize("Sereiled.xml"))
            {
                deserialize += $"{car.CarId}: {car.Price} * {car.Quantity} = {car.Total}\n";
            }

            Logger.Write(deserialize);
        }
    }
}
