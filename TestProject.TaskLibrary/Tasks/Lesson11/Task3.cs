using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TestProject.Common.Core;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson11
{
    public class Task3 : IRunnable
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

            BinarySerializer xs = new BinarySerializer();
            Logger.Write(xs.Serialize(storage, "Sereiled.txt") + "\n");

            string deserialize = "";
            foreach (var car in xs.DeSerialize("Sereiled.txt"))
            {
                deserialize += $"{car.CarId}: {car.Price} * {car.Quantity} = {car.Total}\n";
            }
            Logger.Write(deserialize);
        }
    }
}
